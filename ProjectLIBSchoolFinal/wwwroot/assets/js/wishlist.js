$(document).ready(function () {

    $(".aboutquiz .box ").click(function () {
        $(".aboutquiz .box").css('background', 'white');
        $(".aboutquiz .box").css('border-top', 'solid 4px #385BCE');
        $(".aboutquiz .boxmidle").css('background', '#195EC8');
        $(".aboutquiz .boxmidle").css('border', 'none');

        $(".aboutquiz .favo").css('color', '#273044');
        $(".aboutquiz .active").css('color', 'white');
        
        $("#course").show();
        $("#comment").hide();
    });

    $(".aboutquiz .boxmidle ").click(function () {
        $(".aboutquiz .boxmidle").css('background', 'white');
        $(".aboutquiz .boxmidle").css('border-top', 'solid 4px #385BCE');
        $(".aboutquiz .box").css('background', '#195EC8');
        $(".aboutquiz .box").css('border', 'none');

        $(".aboutquiz .active").css('color', '#273044');
        $(".aboutquiz .favo").css('color', 'white');

        $("#course").hide();
        $("#comment").show();
    });
    $(".aboutquiz .favo").css('color', 'white');
    $("#comment").hide();


});