<?php
   $arr = array(); //Declara��o da vari�vel array
   //Atribui��o dos valores na posi��o correspondente no array
   $arr['nome'] = "Evandro";
   $arr['sobrenome'] = "Balmant";
   $arr['idade'] = 25;
   $arr['macho'] = true;
   /**
    * OBS.: Uma requisi��o AJAX recebe como retorno tudo o
    * que voc� escreve no lado do servidor, portanto n�o
    * fazemos um return e sim um echo ou print.
    */
   //A fun��o json_encode() converte um array para o formato JSON
   echo json_encode($arr);
?>