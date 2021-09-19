

$(document).ready(function () {
    $('#list-products').DataTable({
        pageLength:10
    });
    $(".custom-file-input").on("change", function () {
        var filelabel = $(this).next('.custom-file-label');
        var files = $(this)[0].files;
        if (files.length > 1) {
            filelabel.html(files.length + ' files selected'); 
        } else if (files.length == 1) { 
            filelabel.html(files[0].name);
        }
    });
    var image_array = $("#images").val();
    if (image_array != "") {
        if (image_array.includes(',')) {
            var image_count = image_array.split(',');
            $(".custom-file-label").html(image_count.length + ' files selected');
        } else {
            $(".custom-file-label").html(image_array);
        }
    }
    $("#category-id").change(function () {
        var catId = this.value;
        $.ajax({
            url: "/Product/FilterCategory",
            type: "Get",
            data: {CateId:catId},
            success: function (res) {
                $('#sub-category-id option:not(:first-child)').remove();
                var select = "";
                $.each(res, function (i, item) {
                    select += "<option value='" + item.subCategoryID + "'>" + item.subCategoryName + "</option>";
                });
                $("#sub-category-id").append(select);
            }
        });
    });
});
