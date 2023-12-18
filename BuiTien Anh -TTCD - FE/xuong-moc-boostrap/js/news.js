$(document).ready(function(){
    var pagination= {
        pageSize: 3,
        pageNumber: 1,
        skip: 0,
        recordCount: 12,
        recordShow : 0,
        totalPage : 0
    }


    var listnews = [];
    function addNews(imginput, nameinput,paraminput){
        return {
            img:imginput,
            name:nameinput,
            param:paraminput,
            
        }
    }
    listnews.push(addNews("sp1.png", "Thông tin 1", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp2.png", "Thông tin 2", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp3.png", "Thông tin 3", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp4.png", "Thông tin 4", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp5.png", "Thông tin 5", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp6.png", "Thông tin 6", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp7.png", "Thông tin 7", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp8.png", "Thông tin 8", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp9.png", "Thông tin 9", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp10.png", "Thông tin 10", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp11.png", "Thông tin 11", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    listnews.push(addNews("sp12.png", "Thông tin 12", " illum? Aspernatur fugit atque animi dolore voluptate voluptatibus?"))
    renderListNews(listnews)
   

    function renderListNews(listnews){
        $(".listNews .news .row").html("");
        pagination.recordCount = listnews.length;

        var htmlListNews = "";
        for(let i= pagination.skip; i < pagination.skip + pagination.pageSize ; i++){   
            htmlListNews+=`
          
                <div class="col-md-4 mb-4 col-sm-6 news-item">
                    <div class="card">
                        <img src="../images/xemtatca_sanpham/${listnews[i].img}" alt="">
                    <div class="card-body py-2">
                        <h5 class="card-title text-blue text-center ">${listnews[i].name}"</h5>
                        <p>
                        ${listnews[i].param}</p>
                      </div>
                    </div>
                </div>
                
            `
        }
        pagination.totalPage = Math.round(pagination.recordCount / pagination.pageSize);
        $("nav .pagination").html("");
        var htmlPageNumber = ``;
        for (let i = 0; i < pagination.totalPage; i++) {
            htmlPageNumber += `
            <li class="page-item page-item-number" data-page-number="${i+1}"><a class="page-link" href="#">${i+1}</a></li>
            `
            
        }
        var htmlPagination = `
            <li class="page-item">
            <a class="page-link" href="#" aria-label="Previous">
            <span aria-hidden="true">&laquo;</span>
            </a>
            </li>
            ${htmlPageNumber}
            <li class="page-item">
                <a class="page-link" href="#" aria-label="Next">
                <span aria-hidden="true">&raquo;</span>
                </a>
            </li>`
        $("nav .pagination").html(htmlPagination);
        $(".listNews .news .row").html(htmlListNews);
      
        $(".page-item-number").click(function(){
            const pageNumber = $(this).data("pageNumber");
            pagination.pageNumber = pageNumber;
            pagination.skip = (pageNumber - 1)*pagination.pageSize;
            renderListNews(listnews)
        })

    }
})