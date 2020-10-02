
//prikazivanje rezervacija modalnog prozora
$(function () {
    var placeholderElement = $('#modal-placeholder');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });
    });
});


//$(function () {
//    var placeholderElement = $('#modal-placeholder');
//    $('button[data-toggle="ajax-modal"]').submit(function (event) {
//        var url = $(this).data('url');
//        $.get(url).done(function (data) {
//            placeholderElement.html(data);
//            placeholderElement.find('.modal').modal('show');
//        });
//    });
//});