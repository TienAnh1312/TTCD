function handleClickAdd(){
    var objectInfo = {
        fullName: "",
        dateBirth: "",
        gender: "",
        phoneNunber: "",
        email: "",
        address: "",
        faculty: "",
        className: "",
    };




    objectInfo.fullName = document.getElementById("Name").value;
    objectInfo.dateBirth = document.getElementById("DateBirth").value;
    objectInfo.gender = document.getElementById("Gender").value;
    objectInfo.phoneNunber = document.getElementById("PhoneNumber").value;
    objectInfo.email = document.getElementById("Email").value;
    objectInfo.address = document.getElementById("Address").value;
    objectInfo.faculty = document.getElementById("Faculty").value;
    objectInfo.className = document.getElementById("Class").value;
    

    var gender = "";
    var className= "";
    if(objectInfo.className == "0" ) objectInfo.className="IT1"
    else if (objectInfo.className == "1") objectInfo.className = "IT2";
    else if (objectInfo.className == "2") objectInfo.className = "IT3";

    var htmlTbody = `<tr class="align-middle">
    <th scope="row">2</th>
    <td> 003 </td>
    <td>${objectInfo.fullName}</td>
    <td>${objectInfo.className}</td>
    <td>${objectInfo.faculty}</td>
    <td>${objectInfo.address}</td>
    <td>${objectInfo.phoneNunber}</td>
    <td>${objectInfo.email}</td>
    
    <td class="d-flex justify-content-evenly">
        <button type="button" class="btn btn-outline-primary">
            <i class="bi bi-eye"></i>
            Details
        </button>
        <button type="button" class="btn btn-outline-info"
            style="margin:0 0.5rem 0 0.5rem;">
            <i class="bi bi-arrow-repeat"></i>
            Update
        </button>
        <button type="button" class="btn btn-outline-danger" data-bs-toggle="modal"
            data-bs-target="#exampleModal" onclick="Delete-item()">
            <i class="btn-Delete bi bi-trash3"></i>
            Delete
        </button>
    </td>
</tr>`;
    document.querySelector("tbody").innerHTML += htmlTbody; 
    console.log(objectInfo);
    $(".student-details").removeClass("student-details-show");

    
}
// document.querySelector(".add-new"),addEventListener('click',function(){
//     // document.querySelector(".student-details").style.display = 'block';
//     document.querySelector(".student-details").classList.add("student-details-show");
// });
$(".add-new").click(function(){
    $(".student-details").addClass("student-details-show");
    
});

// document.querySelector(".btn-cancel").addEventListener('click',function(){
//     document.querySelector(".student-details").classList.remove("student-details-show");
// });

$(".btn-cancel").click(function(){
    $(".student-details").removeClass("student-details-show");
});



