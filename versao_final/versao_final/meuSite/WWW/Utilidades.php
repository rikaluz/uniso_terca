<?php

namespace WWW;

class Utilidades {

    public static function redirect($url){

        echo '<script>window.location.href="'.$url.'"</script>';
        die();
    }

    public static function alerta($mensagem){

        echo '<script> alert("'.$mensagem.'")</script>';

        // Echo <div class="alert alert-success" role="alert">
        //              This is a success alert—check it out!
        //      </div>   Tentando passar bootstrap pra validação
    }
}

?>