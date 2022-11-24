<?php

namespace WWW\Controllers;

class HomeController {

    public function index(){

        if (isset($_GET['logout'])){
            session_unset();
            session_destroy();

            \WWW\Utilidades::redirect(INCLUDE_PATH);
        }
        
        if(isset($_SESSION['login'])){
            // Redenriza a Home do usuário.
            \WWW\Views\MainView::render('Home');
            
        }
        
        // Renderiza para fazer Login / Criar conta.
        else {
            
            if(isset($_POST['login'])){

                $login = $_POST['id'];
                $senha = $_POST['password'];

                // Verificar se há conta no BD
                $verifica = \WWW\MySql::connect()->prepare("SELECT * FROM usuario WHERE id_login = ?");
                $verifica->execute(array($login));

                if($verifica->rowCount() == 0){

                    //$boot = $_GET["boot"];   Tentando passar o bootstrap pra validação de login.
                    //echo($boot); 

                    \WWW\Utilidades::alerta('ID ou senha incorreto.');
                    \WWW\Utilidades::redirect(INCLUDE_PATH);
                }
                
                else {
                    $dados = $verifica->fetch();
                    $senhaBanco = $dados['senha'];

                    if(\WWW\Bcrypt::check($senha,$senhaBanco)){

                        $_SESSION['nome'] = explode (' ', $dados['nome'])[0];
                        $_SESSION['login'] = $dados['id_login'];
                        \WWW\Utilidades::redirect(INCLUDE_PATH);
                    }
                    
                    else {

                        \WWW\Utilidades::alerta('ID ou senha incorreto.');
                        \WWW\Utilidades::redirect(INCLUDE_PATH);  
                    }
                }
            }

            \WWW\Views\MainView::render('Login');
        }
    }
}

?>