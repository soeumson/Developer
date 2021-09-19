var pageSize = 6;
var pageIndex = 0;
$(document).ready(function () {
    LoadData();
});
$(".load").click(function () {
    $(".more").text("Loading...");
    var start = setInterval(function () {
        pageIndex++;
        LoadData();
        clearInterval(start);
    }, 1000);
});
function LoadData() {
    $.ajax({
        url: "/Product/GetDataCatalogue",
        type: "Get",
        contentType: "application/json",
        data: { "pageIndex": pageIndex, "pageSize": pageSize },
        dataType: "text",
        success: function (response) {
            if (response != null || response != undefined) {

                $.each(JSON.parse(response), function (i, item) {

                    var image_name = "";
                    if (item.Images != null) {
                        image_name = item.Images.split(',')[0];
                    }
                    if (item.TotalOrder == null)
                        item.TotalOrder = 0;
                    if (item.Favourite == null)
                        item.Favourite = 0;
                    var row = $("<div data-id=" + item.Encryted + " class='col-lg-4 col-md-6 col-sm-6 main-item'></div>").on("click", detailItem);
                    var image = $("<div class='ms-card-img'><img src='/product_images/" + image_name + "' alt='No Image' style='width:530px;height:150px;'/></div>");
                    var card = $("<div class='ms-card'></div>");
                    var body = $("<div class='ms-card-body'></div>");
                    var wrapper1 = $("<div class='wrapper-new2'><h6>" + item.ProductName + "</h6><span class='white'> " + item.Currency + "" + item.Price + "</span></div>");
                    var wrapper2 = $("<div class='wrapper-new1'><span>Total Order :<strong class='color-red'>" + item.TotalOrder + "</strong> </span><span>Favourite :<strong class='color-red'>" + item.Favourite + "</strong></span></div>");
                    var wrapper2 = $("<div class='wrapper-new1'><span>Total Order :<strong class='color-red'>" + item.TotalOrder + "</strong> </span><span>Favourite :<strong class='color-red'>" + item.Favourite + "</strong></span></div>");
                    body.append(wrapper1).append(wrapper2);
                    card.append(image);
                    card.append(body);
                    row.append(card);
                    $(".bind-item").append(row);
                });
                $(".more").text("Load More");
            }
        },
        error: function () {
            alert("Error while retrieving data!");
        }
    });
}
function detailItem() {
    $("#detail-item-modal").modal("show");
    getItemById($(this).data("id"));
}
function getItemById(itemId) {
    $.ajax({
        url: "/Product/GetItemById",
        type: "Get",
        dataType: "text",
        data: { ItemId: itemId },
        success: function (response) {
            if (response != null || response != undefined) {
                var data = JSON.parse(response);

                $("#product-code").text(data.ProductCode);
                $("#product-name").text(data.ProductName);
                $("#category").text(data.CategoryName);
                $("#sub-category").text(data.SubCategoryName);
                $("#model").text(data.ModelName);
                $("#uom").text(data.UomName);
                $("#qty").text(data.Qty);
                $("#price").text(data.Currency + "" + data.Price.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
                if (data.DiscountActive == true) {
                    $("#discount-active").html('<span class="badge badge-success">Active</span>');
                } else {
                    $("#discount-active").html('<span class="badge badge-danger">InActive</span>');
                }
                $("#discount-type").text(data.DiscountType);
                $("#discount-value").text(data.Currency + "" + data.DiscountValue.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
                $("#fee-included").text(data.Currency + "" + data.FeeIncluded.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
                $("#vat-included").text(data.Currency + "" + data.VatIncluded.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
                if (data.Status == true) {
                    $("#status").html('<span class="badge badge-success">Available</span>');
                } else {
                    $("#status").html('<span class="badge badge-danger">UnAvailable</span>');
                }
                if (data.ManageStock == true) {
                    $("#manage-stock").html('<span class="badge badge-success">Mange</span>');
                } else {
                    $("#manage-stock").html('<span class="badge badge-success">Not Manage</span>');
                }
                $("#create-by").text(data.CreateBy);
                $("#product-detail").text(data.Description);
                if (data.Favourite == null) {
                    $("#favourite").text(0);
                } else {
                    $("#favourite").text(data.Favourite);
                }
                if (data.TotalOrder == null) {
                    $("#total-order").text(0);
                } else {
                    $("#total-order").text(data.TotalOrder);
                }
               
                $("#create-date").text(data.CreateDate);
                if (data.Images != null) {
                    $("#img").html("<img src='/product_images/" + data.Images.split(',')[0] + "' alt='No Image' style='width:530px;height:150px;'>");
                } else {
                    $("#img").html("<img src='' alt='No Image' style='width:530px;height:150px;'>");
                }
            }
        }
    });
}

