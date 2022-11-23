<?php

namespace WWW\Models;

class UsuariosModel {

// Validação de Email
public static function emailExists($email){

        $pdo = \WWW\MySql::connect();
        $verificar = $pdo->prepare ("SELECT email from usuario WHERE email = ?");
        $verificar->execute(array($email));

        if($verificar->rowCount() == 1){

            return true;
        }
        else {

            return false;
        }
    }

// Validação de ID
public static function idExists($id){

    $pdo = \WWW\MySql::connect();
        $verificar = $pdo->prepare ("SELECT id_login from usuario WHERE id_login = ?");
        $verificar->execute(array($id));

        if($verificar->rowCount() == 1){

            return true;
        }
        else {

            return false;
        }
}
}

?>