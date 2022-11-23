<?php

namespace WWW\Controllers;

class RegistrarController{

    public function index(){

        if (isset($_POST['registrar'])){

            $id = $_POST['registro-id'];
            $nome = $_POST['name'];
            $email = $_POST['email'];
            $senha = $_POST['password'];
            $confirmaSenha = $_POST['confirm-password'];


            // Validação para ver se o Email é válido.
            if(!filter_var($email,FILTER_VALIDATE_EMAIL)){

                \WWW\Utilidades::alerta('E-mail Inválido!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }
        
            // Validação para o ID conter apenas números.
            else if (!preg_match('/(?=.\d)/', $id)){
                \WWW\Utilidades::alerta('ID inválido\nUtilize apenas valores númericos');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }
                      
            // Validação de senhas. (Regex)
            else if (!preg_match('/(?=.*\d)/',$senha)){

                \WWW\Utilidades::alerta('A senha deve conter pelo menos 1 número.');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }

            else if (!preg_match('/(?=.*[A-Z])/',$senha)){

                \WWW\Utilidades::alerta('A senha deve conter pelo menos 1 letra maiúscula.');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }

            else if (!preg_match('/(?=.*[a-z])/',$senha)){

                \WWW\Utilidades::alerta('A senha deve conter pelo menos 1 letra minúscula.');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }

            else if (!preg_match('/\S{6,30}$/',$senha)){

                \WWW\Utilidades::alerta('A senha deve haver no mínimo 6 e no máximo 30 caractéres.');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }


            // Validação para ver se as senhas são iguais.
            else if($senha != $confirmaSenha){

                \WWW\Utilidades::alerta('As senhas devem ser iguais.');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }


            // Validação de Email, caso o email já exista.
            else if(\WWW\Models\UsuariosModel::emailExists($email)){

                \WWW\Utilidades::alerta('E-mail já cadastrado!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }

            // Validação de ID, caso o ID ja exista.
            else if(\WWW\Models\UsuariosModel::idExists($id)){

                \WWW\Utilidades::alerta('ID já cadastrado!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Registrar');
            }
            

            // Caso tudo esteja OK, cadastra e criptografa a senha.
            else{

                $senha = \WWW\Bcrypt::hash($senha);
                $registro = \WWW\MySql::connect()->prepare("INSERT INTO usuario VALUES (null,?,?,?,?)");
                $registro->execute(array($nome,$id,$email,$senha));

                \WWW\Utilidades::alerta('Cadastrado com sucesso!');
                \WWW\Utilidades::redirect(INCLUDE_PATH);
            }

        } 
        
        \WWW\Views\MainView::render('Registrar'); 

    }
}

?>