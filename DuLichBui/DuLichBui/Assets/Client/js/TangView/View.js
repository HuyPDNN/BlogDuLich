var dem = {
    init: function () {
        dem.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: ("/Admin/BaiViet/DuyetBai"),
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    console.log(response);

                    dem.view++;
                }
            });
        });
    }
}
dem.init();