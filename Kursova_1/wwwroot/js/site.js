$(document).ready(function () {
    setTimeout(function () {
        $('#tempDataMessage').fadeOut('slow');
    }, 3000);
});
$(document).ready(function () {
    $('.close').click(function () {
        $('#tempDataMessage').fadeOut('fast');
    });
});