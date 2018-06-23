$(document).ready(function () {

     $('#btnIngresar').click(function (e) {
        ingresar();
     })
    
})


function ingresar(){
    var pUrl = $("#URLIngresar").val(); 
    var login = $("#Login").val();
    var password = $("#Password").val();
        $.ajax({
            url: pUrl,
            method: "GET",
            data: {login,password},
            dataType: "json",
            success: function (data) { 
            },
            error: function (data) { 
            }
    });
}