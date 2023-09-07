var data=[];

function handleClickAdd(){
  
    item_Name = document.getElementById("Name").value;
    item_DateBirth = document.getElementById("DateBirth").value;
    item_Gender = document.getElementById("Gender").value;
    item_PhoneNumber = document.getElementById("PhoneNumber").value;
    item_Email = document.getElementById("Email").value;
    item_Address = document.getElementById("Address").value;
    item_Faculty = document.getElementById("Faculty").value;
    item_Class = document.getElementById("Class").value;

    let idMax = 0;
    data.forEach(element => {
        if(element.id > idMax){
            idMax=element.id;
        }
    });

    var item = {
        id:idMax+1,
        name:item_Name,
        date:item_DateBirth,
        gender:item_Gender,
        phonnumber:item_PhoneNumber,
        email:item_Email,
        address:item_Address,
        faculty:item_Faculty,
        class:item_Class
    };


    data.push(item)
    console.log(data);
    render()
    clear()
}

function render(){
    table =`
        <th scope="col" class="text-nowrap">ID</th>
        <th scope="col" class="text-nowrap">Full Name</th>
        <th scope="col" class="text-nowrap">Class</th>
        <th scope="col" class="text-nowrap">Faculty</th>
        <th scope="col" class="text-nowrap">Address</th>
        <th scope="col" class="text-nowrap">Phone Number</th>
        <th scope="col" class="text-nowrap"> Email</th>
        <th scope="col" class="text-center">Action</th>
    </td>
        </tr> `;
    for(let i=0;i<data.length;i++){
        table+=`
        <th scope="col" class="text-nowrap">${data[i].id}</th>
        <th scope="col" class="text-nowrap">${data[i].name}</th>
        <th scope="col" class="text-center">${data[i].class}</th>
        <th scope="col" class="text-center">${data[i].faculty}</th>
        <th scope="col" class="text-nowrap">${data[i].address}</th>
        <th scope="col" class="text-nowrap">${data[i].phonnumber}</th>
        <th scope="col" class="text-nowrap">${data[i].email}</th>
        <th scope="col" class="text-center"><button type="button" class="btn btn-outline-primary">
        <i class="bi bi-eye"></i>
        Details
    </button>
    <button type="button" class="btn btn-outline-info"
        style="margin:0 0.5rem 0 0.5rem;" onclick="updateitem(${data[i].id})">
        <i class="bi bi-arrow-repeat"></i>
        Update
    </button>
    <button type="button" class="btn-Delete btn btn-outline-danger " data-bs-toggle="modal"
        data-bs-target="#exampleModal" onclick="deleteItem(${data[i].id})">
        <i class="bi bi-trash3"></i>
        Delete
    </button></th>
        </tr> `;
    }
    document.getElementById("render").innerHTML= table
    $(".student-details").removeClass("student-details-show");
}
function clear(){
    document.getElementById("Name").value="";
    document.getElementById("DateBirth").value="";
    document.getElementById("Gender").value="";
    document.getElementById("PhoneNumber").value="";
    document.getElementById("Email").value="";
    document.getElementById("Address").value="";
    document.getElementById("Faculty").value="";
    document.getElementById("Class").value="";
}

function deleteItem(x){
    for(let i=0;i<data.length;i++){
        if(data[i].id==x){
            data.splice(i,1)
            render()
        }
    }
}
function updateitem(x){   
   
        for(let i=0;i<data.length;i++){
            if(data[i].id==x){

                document.getElementById("Name").value = data[i].name;
                document.getElementById("DateBirth").value = data[i].date;
                document.getElementById("Gender").value = data[i].gender;
                document.getElementById("PhoneNumber").value = data[i].phonnumber;
                document.getElementById("Email").value = data[i].email;
                document.getElementById("Address").value = data[i].address;
                document.getElementById("Faculty").value = data[i].faculty;
                document.getElementById("Class").value = data[i].class;
              
        }
    }
}

function updateitem(){
    $(".student-details-update").addClass("student-details-show");
    data.push(item)
}


$(".add-new").click(function(){
    $(".student-details").addClass("student-details-show");
    
});


$(".btn-cancel").click(function(){
    $(".student-details").removeClass("student-details-show");
});
$(".btn-cancel").click(function(){
    $(".student-details-update").removeClass("student-details-show");
});