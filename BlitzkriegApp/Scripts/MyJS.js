$(document).ready(function () {
    $('.button-left').click(function () {
        $('.sidebar').toggleClass('fliph');
    });

});


$(document).ready(function () {
    $('.material-button-toggle').on("click", function () {
        $(this).toggleClass('open');
        $('.option').toggleClass('scale-on');
    });
});

var clock;
$(document).ready(function() {
        clock = $('.clock').FlipClock({
            clockFace: 'TwentyFourHourClock',
            language: 'pl',
            showSeconds: false
        });
    });
