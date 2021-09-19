function show(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();

        filerdr.onload = function (e) {
            $('#image-upload').attr('src', e.target.result);
            $('#img').val(input.files[0].name)
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}