var baiviet = {
    init: function () {
        baiviet.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: ("/Admin/DuyetBai/DuyetBaiViet"),
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    console.log(response);
                    if (response.status == false) {
                        btn.text('Duyệt bài');
                        
                    }
                    else {
                        btn.text('Hủy đăng');
                    }
                }
            });
        });
    }
}
baiviet.init();