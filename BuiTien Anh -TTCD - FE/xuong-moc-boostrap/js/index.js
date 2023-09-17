$(document).ready(function(){
    var listProduct = [];

    listProduct.push(addProduct("sp1.png","BÀN UỐNG NƯỚC",5,"(Size vừa, nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp2.png","BÀN UỐNG NƯỚC 2",4,"(Size vừa, nâu đậm)","3.999.999"));
    listProduct.push(addProduct("sp3.png","KỆ TIVI",3,"(Size vừa, nâu đậm)","1.999.999"));
    listProduct.push(addProduct("sp4.png","KỆ ĐỂ ĐỒ",2,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct("sp5.png","KỆ ĐỂ ĐỒ",1,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct("sp6.png","SOFA",5,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct("sp7.png","KỆ ĐỂ ĐỒ",5,"(Size vừa, nâu đậm)","2.999.999"));
    listProduct.push(addProduct("sp8.png","A ĐỂ ĐỒ",5,"(Size vừa, nâu đậm)","2.999.999"));

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
            <div class="col-md-3 mb-3 col-sm-6" data-bs-toggle="modal" data-bs-target="#exampleModal">
                                <div class="">
                                    <img src="../images/xemtatca_sanpham/${listProduct[i].img}" alt="">
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
    }



    
});