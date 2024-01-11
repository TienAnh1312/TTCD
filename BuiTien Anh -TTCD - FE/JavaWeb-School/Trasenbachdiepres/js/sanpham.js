// Khai báo dữ liệu
var arrThongTinTra=[
{
    loaiSanPham: 'Trà San Tuyết',
    giaThanh: '50,000',
    thuongHieu: 'Trà Tân Cương Xanh',
    hinhAnh: '/img/sanpham/trashantuyet.jpg'
},
{
    loaiSanPham: 'Trà Oolong',
    giaThanh: '70,000',
    thuongHieu: 'Trà Sen Tây Hồ',
    hinhAnh:'/img/sanpham/traoolong.jpg'
},
{
    loaiSanPham: 'Trà Búp',
    giaThanh: '70,000',
    thuongHieu: 'Trà Lộc Tân',
    hinhAnh: '/img/sanpham/trabup.jpg'
},
]
// Gọi hàm
function hienGia(){
    var list1= document.getElementById("right-box");
    list1.innerHTML='';
    for(i=0; i<arrThongTinTra.length; i++){
        loaiTra=arrThongTinTra[i].loaiSanPham;
        giaTra=arrThongTinTra[i].giaThanh;
        hieuTra=arrThongTinTra[i].thuongHieu;
        if (thuongHieuChon_arr.length>0){
            if (thuongHieuChon_arr.includes(loaiTra)==false)continue;
        }
        list1.innerHTML+=`
        <div class="main-box">
                        <div class="product01 positionReletive">
              <div class="stars">
                <form action="">
                  <label class="star star-5" for="star-5" checked></label>
                  <label class="star star-4" for="star-4"></label>
                  <label class="star star-3" for="star-3"></label>
                  <label class="star star-2" for="star-2"></label>
                  <label class="star star-1" for="star-1"></label>
                  <p class="box02-blur">(27)</p>
                </form>
              </div> 
              <div class="new">
                <p>New</p>
              </div>
              <img src="${arrThongTinTra[i].hinhAnh}" alt="" class="positionAbsolute">
              <div class="positionAbsolute title03">
                <p >${arrThongTinTra[i].loaiSanPham}</p>
              </div>
              <div class="price positionAbsolute ">
                <p class="price-number">${arrThongTinTra[i].giaThanh}</p>
                <p class="price-curency">VND</p>
                <select>
                  <option>200g</option>
                  <option>400g</option>
                  <option>600g</option>
                </select>
              </div>
            </div>
        </div>`

    }
}
// Lọc sản phẩm
function chonTra(){
    var arr1= document.getElementByClassName ("thuongHieu");
    var thuongHieuChon_arr=[];
    for (i=0; i<arr1.length;i++){
        if (arr1[i].checked=true) thuongHieuChon_arr.push(arr[i].value);
        hienGia(thuongHieuChon_arr);
    }
}