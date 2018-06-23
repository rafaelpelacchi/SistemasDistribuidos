$(document).ready(function () { 
     $('#btnCrear').click(function (e) {
        ingresar();
     })
    
})


function ingresar(){
    var pUrl = $("#URLIngresar").val(); 
    var usuario = $("#Usuario").val();
    var password = $("#Password").val();
    var nombre = $("Nombre").val();
    var apellido = $("Apellido").val();
    
        $.ajax({
            url: pUrl,
            method: "GET",
            data: {usuario,password,nombre,apellido},
            dataType: "json",
            success: registrarUsuario (data) { 
            },
            error: alert (data) { 
            }
    });
}