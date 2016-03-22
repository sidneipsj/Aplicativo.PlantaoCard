<?php
   $arr = array(); //Declaraчуo da variсvel array
   //Atribuiчуo dos valores na posiчуo correspondente no array
   $arr['nome'] = "Evandro";
   $arr['sobrenome'] = "Balmant";
   $arr['idade'] = 25;
   $arr['macho'] = true;
   /**
    * OBS.: Uma requisiчуo AJAX recebe como retorno tudo o
    * que vocъ escreve no lado do servidor, portanto nуo
    * fazemos um return e sim um echo ou print.
    */
   //A funчуo json_encode() converte um array para o formato JSON
   echo json_encode($arr);
?>