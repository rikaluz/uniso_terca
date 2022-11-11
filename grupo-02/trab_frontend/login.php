<?php

require("./url_raiz.php");

if(isset($_COOKIE['autenticado'])){
    header("Location: $url");
    die();
}else{
    require("./conecta_banco.php");
    
    $nome_usuario = isset($_POST["nome_usuario"]) ? $_POST["nome_usuario"] : "";
    $senha = isset($_POST["senha"]) ? $_POST["senha"] : "";
    $erro = "";
    
    if($nome_usuario !== ""){
        $usuario = $conexao->query("SELECT * FROM usuarios WHERE nome_usuario = '$nome_usuario'")->fetch();
        if(!empty($usuario)){
            if($senha !== ""){
                if(password_verify($senha, $usuario["senha"])){
                    $cookie_autenticacao = ["autenticado", true];
                    setcookie($cookie_autenticacao[0], $cookie_autenticacao[1], time()+3600);
                    header("Location: $url");
                    die();
                }else{
                    $erro = "Senha inválida.";
                }
            }
        }else{
            $erro = "Usuário não cadastrado.";
        }
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Login</title>
    </head>
    <body>
        <?php
            require("./navbar.php");
        ?>
        <h1>Login</h1>
        <form method="post">
            <p>Nome de Usuário</p>
            <input type="text" name="nome_usuario" placeholder="Nome de Usuário" required/><br>
            <p>Senha</p>
            <input type="password" name="senha" placeholder="Senha" required/><br><br>
            <div><?php if(isset($erro)) echo $erro; ?></div>
            <input type="submit" value="Enviar" />
        </form>
    </body>
</html>