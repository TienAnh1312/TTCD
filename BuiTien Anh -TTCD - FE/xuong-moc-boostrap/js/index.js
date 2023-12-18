$(document).ready(function(){
    var listProduct = [];

    listProduct.push(addProduct(["sp1.png","sp2.png","sp3.png","sp4.png"],"BÀN UỐNG NƯỚC",5,"(Size vừa, nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp2.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC 2",4,"(Size vừa, nâu đậm)","3.999.999"));
    listProduct.push(addProduct(["sp3.png","sp2.png","sp3.png"],"KỆ TIVI",3,"(Size vừa, nâu đậm)","1.999.999"));
    listProduct.push(addProduct(["sp4.png","sp2.png","sp3.png"],"KỆ ĐỂ ĐỒ",2,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct(["sp5.png","sp2.png","sp3.png"],"KỆ ĐỂ ĐỒ",1,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct(["sp6.png","sp2.png","sp3.png"],"SOFA",5,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct(["sp7.png","sp2.png","sp3.png"],"KỆ ĐỂ ĐỒ",5,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct(["sp8.png","sp2.png","sp3.png"],"A ĐỂ ĐỒ",5,"(Size vừa, nâu đậm)","2.999.999"));

    renderListProduct(listProduct);
    

    function addProduct(imginput, nameinput, rateinput, descinput, priceinput){
        return {
            img:imginput,
            name:nameinput,
            rate:rateinput,
            desc:descinput,
            price:priceinput
        }
    }

    $("#sortRate").click(function(){
        let newListProduct = listProduct.slice();
        newListProduct = newListProduct.sort(function(a,b ){
        return b.rate - a.rate;
       }) 
       renderListProduct(newListProduct);
    });22

    $("#SortName").click(function(){
        let newListProduct = listProduct.slice();
        newListProduct = newListProduct.sort(function(a,b ){
        if(a.name < b.name)return -1;
        else if (a.name == b.name)return -1;
        else return 1;
       }) 
       renderListProduct(newListProduct);
    });

    $("#SortDefault").click(function(){
        renderListProduct(listProduct)
    })

    function renderListProduct(listProduct){
        $(".list-product .products .row").html("");
        var htmlListProduct = "";
        for(let i=0; i < listProduct.length; i++){
            var htmlstar = "";
            for(let j=0; j < listProduct[i].rate; j++){
                htmlstar+=`<i class="fa-sharp fa-solid fa-star text-brown"></i>`;
            }
    
            htmlListProduct+=`
            <div class="col-md-3 mb-3 col-sm-6 product-item" data-bs-toggle="modal" data-bs-target="#exampleModal" data-id=${i}>
                                <div class="">
                                    <img src="../images/xemtatca_sanpham/${listProduct[i].img[0]}" alt="">
                                <div class="card-body pt-3 pb-4">
                                    <h5 class="card-title text-blue text-center ">${listProduct[i].name}</h5>
                                    <span class="text-center">
                                        <div>
                                            ${htmlstar}
                                        </div>
                                        <span class="desc text-secondary d-block text-center">${listProduct[i].desc} </span>
                                        <span class="price d-block text-center">${listProduct[i].price}</span>
                                    </span>
                                  </div>
                                </div>
                            </div>
            `
        }
        $(".list-product .products .row").html(htmlListProduct);

        $(".product-item").click(function(){
            const id = $(this).data("id");
            //lấy thông tin
            var htmlStar = "Đánh giá: ";
            for(let j=0;j<listProduct[id].rate;j++){
                htmlStar+=`<i class="fa-solid fa-star text-gold"></i>`;
            }
            $("#exampleModal .title").text(listProduct[id].name);

            $("#exampleModal .rate").html(htmlStar);
            $("#exampleModal .desc").text("Mô tả" +listProduct[id].desc);
            $("#exampleModal .price").text("Giá" +listProduct[id].price);

            //lấy hình ảnh
            $(".product-slide .slider-for").html("");
            $(".product-slide .slider-nav").html("");

            var htmlProductSlide = "";
            var htmlProductSlide_Bottom = "";
            var htmlContent ="";
            for (let i = 0; i<listProduct[id].img.length;i++){
                htmlProductSlide +=`
                <div class="img-box">
                    <img src="../images/xemtatca_sanpham/${listProduct[id].img[i]}" alt="" class="w-100 object-fit-cover" style="height: 25rem;">
                </div>
                `;

                htmlProductSlide_Bottom +=`
                <div class="img-box me-2 mt-2">
                    <img src="../images/xemtatca_sanpham/${listProduct[id].img[i]}" alt="" class="w-100 ;">
                </div>
                `;
                htmlContent +=`
                
                `

            }
            $(".product-slide .slider-for").html(htmlProductSlide);
            $(".product-slide .slider-nav").html(htmlProductSlide_Bottom);
            $('.slider-for').slick('refresh');
            $('.slider-nav').slick('refresh');


        });
    }

    
});