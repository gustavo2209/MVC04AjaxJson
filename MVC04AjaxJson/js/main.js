
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

function demo2() {
    $.ajax({
        url: "Home/Demo02",
        dataType: "json",
        success: function (result) {
            //alert(JSON.stringify(result));

            var msg = "Lista de Telefonos<br><span style='font-size: 14px; display: block'>";

            for (var i = 0; i < result.length; i++) {
                msg += result[i].numero + "(precio: " + result[i].costo + (result[i].activo ? " y esta activo" : ", no esta activo") + ")<br>";
            }

            msg += "</span>";

            $("#dlg_message_msg").html(msg);
            $("#dlg_message").modal("show");
        }
    })
}

function demo3() {
    $.ajax({
        url: "Home/Demo03",
        dataType: "json",
        success: function (result) {
            //{ "nombre": "Alicia Neruda", 
            //    "telefonos": [
            //{
            //"numero": "999627956",
            //    "costo": 700,
            //        "activo": true
            //},
            //{
            //    "numero": "988627956",
            //        "costo": 800,
            //            "activo": true
            //},
            //{
            //    "numero": "785627956",
            //        "costo": 750,
            //            "activo": false
            //}
            //]
        
            //alert(JSON.stringify(result));

            var msg = "Telefonos de " + result.nombre + "<br><span style='font-size: 14px; display: block'>";

            for (var i = 0; i < result.telefonos.length; i++) {
                msg += result.telefonos[i].numero + "(precio: " + result.telefonos[i].costo + (result.telefonos[i].activo ? " y esta activo" : ", no esta activo") + ")<br>";
            }

            msg += "</span>";

            $("#dlg_message_msg").html(msg);
            $("#dlg_message").modal("show");
        }
    })
}

function demo4() {
    $.ajax({
        url: "Home/Demo04",
        dataType: "json",
        success: function (result) {

            var msg = "";

            for (var i = 0; i < result.length; i++) {
                msg += "Telefonos de " + result[i].nombre + "<br><span style='font-size: 14px; display: block'>";
                for (var j = 0; j < result[i].telefonos.length; j++) {
                    msg += result[i].telefonos[j].numero + "(precio: " + result[i].telefonos[j].costo + (result[i].telefonos[j].activo ? " y esta activo" : ", no esta activo") + ")<br>";
                }
            }

            msg += "</span>";

            $("#dlg_message_msg").html(msg);
            $("#dlg_message").modal("show");
        }
    })
}