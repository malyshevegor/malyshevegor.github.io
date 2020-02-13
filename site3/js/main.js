$(window).scroll(function(){
    let scroll = $(window).scrollTop();
    console.log(scroll);
    
    $('.sky').css({
        top: scroll/10 + "%",
    })
    
    $('.mou1').css({
        top: 35 + (scroll/25) + "%",
    })
    
    $('.mou2').css({
        top: 46 + (scroll/30) + "%",
    })
    
    $('.mou3').css({
        top: 45 + (scroll/37) + "%",
    })
    
    $('.mou4').css({
        top: (scroll/60) + "%",
    })
    
    $('.chel').css({
        top: 46 + (scroll/65) + "%",
    })
});


