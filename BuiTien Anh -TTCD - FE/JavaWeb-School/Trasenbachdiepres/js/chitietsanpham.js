function calculatePrice() {
  var quantity = document.getElementById("quantity").value;
  var price = (quantity == 200) ? 50000 : (quantity == 400) ? 100000 : 150000;
  document.getElementById("price").innerHTML = price.toLocaleString('vi-VN');
}

$(document).ready(function() {
  $('.main-slider').slick({
      dots: false,
      infinite: true,
      speed: 500,
      fade: true,
      slidesToShow: 1,
      slidesToScroll: 1,
      asNavFor: '.nav-slider',
      prevArrow: '<button class="my-prev-arrow slick-arrow"><i class="fa-solid fa-play fa-rotate-270" style="color: #aabc44"></i></button>',
      nextArrow: '<button class="my-next-arrow slick-arrow"><i class="fa-solid fa-play fa-rotate-90" style="color: #aabc44"></i></button>'
  });

  $('.nav-slider').slick({
      dots: false,
      infinite: true,
      speed: 200,
      slidesToShow: 3,
      slidesToScroll: 1,
      asNavFor: '.main-slider',
      vertical: true,
      focusOnSelect: true,
      arrows: false
  });

  $('.product-slider').slick({
      dots: false,
      infinite: true,
      speed: 300,
      slidesToShow: 4,
      slidesToScroll: 4,
      autoplay: true,
      autoplaySpeed: 1000,
      pauseOnFocus: true,
      arrows: false,
      swipe: true,
      pauseOnFocus: true,
  });
});