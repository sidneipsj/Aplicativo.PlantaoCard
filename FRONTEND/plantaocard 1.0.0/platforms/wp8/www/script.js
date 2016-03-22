//var xml_string = "<CONSULTAR_CARTOES_PARAM><CREDENCIADO><CODACESSO>17</CODACESSO><SENHA>1111</SENHA></CREDENCIADO><NOME_CARTAO>6064213004465078</NOME_CARTAO></CONSULTAR_CARTOES_PARAM>" 

$(document).onclick(function () {
    $.ajax({
        type: "GET",
        url: "http://localhost:65527/api/cartao",
        // data: xml_string,
        crossDomain: true,
        cache: false,
        dataType: "json",
        success: function (data) {
            console.log(data);
            alert(data);
        },
        error: function (data) {
            console.log(data);
            alert("error.");
        }
    });
});/**
 * Created by sidnei on 21/01/2016.
 */
