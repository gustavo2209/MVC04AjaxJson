
function demo1() {
    $.ajax({
        url: "Home/Demo01",
        dataType: "json",
        success: function (result) {
            //alert(JSON.stringify(result));

            var msg = "El telefono cuesta S/ " + result.costo + " , su numero es: " + result.numero + (result.activo ? " y esta activo" : ", no esta activo");

            $("#dlg_message_msg").text(msg);
            $("#dlg_message").modal("show");
        }
    })
}