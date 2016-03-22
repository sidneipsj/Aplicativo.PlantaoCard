jQuery(document).ready(function(){
   //Ao clicar em um elemento do tipo button
   jQuery("button").click(function(){
      //Requisição Ajax
      jQuery.ajax({
         url: "pagina.php", //URL de destino
         dataType: "json", //Tipo de Retorno
         success: function(json){ //Se ocorrer tudo certo
            var msg = "Nome: " + json.nome + "\n";
            msg += "Sobrenome: " + json.sobrenome + "\n";
            msg += "Idade: " + json.idade;
            alert(msg);
         }
      });
   });
})