
$(document).ready(function(){
    var listStudent=[];

    $(".btn-show-add").click(function(){
        $(".btn-reset").css("display","block");
        $(".btn-add").css("display","block");
        $(".btn-update").css("display","none");
        $(".student-details form input").prop("disabled",false);
        $(".student-details form select").prop("disabled",false);

        resetForm();

        $(".student-details").addClass("student-details-show");
    });


    $(".btn-cancel").click(function(){
        $(".student-details").removeClass("student-details-show");
    });


    $(".btn-reset").click(function(){
       resetForm();
    });


    $(".btn-add").click(function(){
        var newStudent = getData();
        listStudent.push(newStudent);
        renderListStudent();
        $(".student-details form input").val("");
        $(".student-details").removeClass("student-details-show");
    });


    //thêm data vào bảng
    function renderListStudent(){
       
        var htmlData = "";

        for(let i = 0; i< listStudent.length; i++){
            var className= "";
            if(listStudent[i].className == "0" ) className="IT1"
            else if (listStudent[i].className == "1") className = "IT2";
            else if (listStudent[i].className == "2") className = "IT3";

            htmlData+=`<tr class="align-middle">
            <th scope="row">${i+1}</th>
            <td> ID${i+1} </td>
            <td>${listStudent[i].fullName}</td>
            <td>${className}</td>
            <td>${listStudent[i].faculty}</td>
            <td>${listStudent[i].address}</td>
            <td>${listStudent[i].phoneNunber}</td>
            <td>${listStudent[i].email}</td>
            
            <td class="d-flex justify-content-evenly">
                <button type="button" class="btn btn-outline-primary btn-show-details" data-id="${i}">
                    <i class="bi bi-eye "></i>
                    Details
                </button>
                <button type="button" class="btn btn-outline-info btn-show-update" data-id="${i}"
                    style="margin:0 0.5rem 0 0.5rem;">
                    <i class="bi bi-arrow-repeat"></i>
                    Update
                </button>
                <button type="button" class="btn btn-outline-danger btn-show-delete" data-id="${i}">
                    <i class="btn-Delete bi bi-trash3"></i>
                    Delete
                </button>
            </td>
        </tr>`;
        }
        $("tbody").html(htmlData);


        //details
        $(".btn-show-details").click(function(){
            var id = $(this).data("id");
            
            itemStudent(id);

            $(".btn-reset").css("display","none");
            $(".btn-add").css("display","none");
            $(".btn-update").css("display","none");
            $(".student-details form input").prop("disabled",true);
            $(".student-details form select").prop("disabled",true);
            $(".student-details").addClass("student-details-show");
        })


        $(".btn-show-update").click(function(){
            var id = $(this).data("id");

            itemStudent(id);

            $(".btn-reset").css("display","none");
            $(".btn-add").css("display","none");
            $(".btn-update").css("display","block");
            $(".student-details form input").prop("disabled",false);
            $(".student-details form select").prop("disabled",false);
            $(".student-details").addClass("student-details-show");


            //save update
            $(".btn-update").click(function(){
                listStudent[id] = getData();
                renderListStudent();
                $(".student-details").remove("student-details-show");
            });

        });

        //delete
        $(".btn-show-delete").click(function(){
            var id = $(this).data("id");
            var isDelete = confirm("Xóa ???")
            if(isDelete){
                 listStudent.splice(id, 1);
                 renderListStudent();
            }
         });

    };


    function getData(){
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

        objectInfo.fullName = $("#Name").val();
        objectInfo.dateBirth = $("#DateBirth").val();
        objectInfo.gender = $("#Gender").val();
        objectInfo.phoneNunber = $("#PhoneNumber").val();
        objectInfo.email = $("#Email").val();
        objectInfo.address = $("#Address").val();
        objectInfo.faculty = $("#Faculty").val();
        objectInfo.className = $("#Class").val();
        
        return objectInfo;
    }


    //reset form
    function resetForm(){
        $(".student-details form input").val("");
        $(".student-details form select").val("");
    }


    function itemStudent(id){
        $("#Name").val(listStudent[id].fullName);
        $("#DateBirth").val(listStudent[id].dateBirth);
        $("#Gender").val(listStudent[id].gender);
        $("#PhoneNumber").val(listStudent[id].phoneNunber);
        $("#Email").val(listStudent[id].email);
        $("#Address").val(listStudent[id].address);
        $("#Faculty").val(listStudent[id].faculty);
        $("#Class").val(listStudent[id].className);
    }
});