$(document).ready(function(){
    //  $('.slide-product').slick();
    const myModalEl = document.getElementById('exampleModal')
    myModalEl.addEventListener('show.bs.modal', event => {
        $('.slider-for').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        asNavFor: '.slider-nav'
    });
    $('.slider-nav').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        asNavFor: '.slider-for',
        dots: true,
        focusOnSelect: true
    });
    })

    
        var products=[];
        products.push(htProduct("BÀN UỐNG NƯỚC","sp1.png","sp2.png",5,"Mô tả: OK","Giá: 8.999.999"));
        
        renderproducts(products);
    
        function htProduct( nameslide,slideinput,slide_nav, rateinput,descsinput,pricesinput ){
         
            return {
                name:nameslide,
                slide:slideinput,
                nav:slide_nav,
                rate:rateinput,
                descs:descsinput,   
                prices:pricesinput
            }
        }
        
        function renderproducts(products){
            $(".modal .modal-content.modal-body").html("");
            var htmlproducts = "";
            for(let i=0; i < products.length; i++){
                var htmlstars = "";
                for(let j=0; j < products[i].rate; j++){ 
                    htmlstars+=`<i class="fa-sharp fa-solid fa-star text-brown"></i>`;
                }
                htmlproducts+=`
                <div class="modal-body">     
                        <div class="title text-blue">
                        ${products[i].name}
                        </div>
                        <div class="product-info d-flex">
                            <div class="product-slide" style="width: 55%;">
                                <div class="slider-for w-100">
                                    <div class="img-box">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100 " style="height: 25rem;">
                                    </div>
                                    <div class="img-box">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100 " style="height: 25rem;">
                                    </div>
                                    <div class="img-box">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100 " style="height: 25rem;">
                                    </div>
                                    <div class="img-box">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100 " style="height: 25rem;">
                                    </div>
                                    <div class="img-box">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100 " style="height: 25rem;">
                                    </div>
                                   
                                </div>
                                <div class="slider-nav mt-3">
                                    <div class="img-box me-2">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100">
                                    </div>
                                    <div class="img-box me-2">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100">
                                    </div>
                                    <div class="img-box me-2">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100">
                                    </div>
                                    <div class="img-box me-2">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100">
                                    </div>
                                    <div class="img-box me-2">
                                        <img src="../images/xemtatca_sanpham/${products[i].slide}" alt="" class="w-100">
                                    </div>
                                </div>
                            </div>
                            <div class="product-desc" style="width: 40%;">
                                <div class="rate">
                                    Đánh giá: 
                                    ${htmlstars}
                                </div>
                                <div class="desc">
                                    Mô tả:
                                </div>
                                <div class="price">
                                </div>
                            </div>
                        </div>
                    </div>
                `
            }
            $(".modal-body").html(htmlproducts);
        }
   
 });