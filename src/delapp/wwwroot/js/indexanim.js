$(document).ready(function () {
    $(".img1").css("opacity","1");
    var id = 1;
    $(".main_title ul li a").mouseover(function(){

        var image = $(this).data().sid;

        if(id != image)
        {
            $(".img" + id).css("opacity","0");
            $(".img" + image).css("opacity","1");
            id = image;
        }

        
    });
})
