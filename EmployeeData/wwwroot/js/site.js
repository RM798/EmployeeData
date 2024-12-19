// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

 
/*$(document).ready(*/
function SaveData() {
   /* alert("SaveData function is working!");*/
    //$("#saveButton").click(function () {
        debugger;
    // Collect form data
       
    var EmployeeModel = new Object();
    EmployeeModel.EmployeeName = $("#EmployeeName").val(),
        EmployeeModel.DateOfBirth = $("#DateOfBirth").val(),
        EmployeeModel.Gender = $("#Gender").val(),
        EmployeeModel.Department = $("#Department").val(),
        EmployeeModel.Designation = $("#Designation").val(),
        EmployeeModel.BasicSalary = parseFloat($("#BasicSalary").val())

        // Make an AJAX call to the controller
    $.ajax({
        url: '/Home/Save', // Replace with your controller URL
        type: 'POST',
        contentType: 'json',
        data: { details: EmployeeModel },
             
            success: function (response) {
                // Show success message
                $("#result").html(`<p style="color: green;">${response.message}</p>`);
            },
            error: function (xhr, status, error) {
                // Show error message
                $("#result").html(`<p style="color: red;">Error: ${xhr.responseText || error}</p>`);
            }
    });

};
/*});*/