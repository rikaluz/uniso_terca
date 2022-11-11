<?php

require("./url_raiz.php");

if(isset($_COOKIE['autenticado'])){
    header("Location: $url");
    die();
}else{
    require("./conecta_banco.php");

    $nome_usuario = isset($_POST["nome_usuario"]) ? $_POST["nome_usuario"] : "";
    $senha = isset($_POST["senha"]) ? $_POST["senha"] : "";
    $confirma_senha = isset($_POST["confirma_senha"]) ? $_POST["confirma_senha"] : "";
    $erro = "";

    if($nome_usuario !== ""){
        $usuario = $conexao->query("SELECT * FROM usuarios WHERE nome_usuario = '$nome_usuario'")->fetch();
        if(!empty($usuario)){
            $erro = "Usuário já cadastrado.";
        }else{
            if($senha !== ""){
                if($senha === $confirma_senha){
                    if(strlen($senha) < 8){
                        $erro = "A senha precisa ter no mínimo 8 caracteres.";
                    }else{
                        $senha = password_hash($senha, PASSWORD_BCRYPT);
                        $query = "INSERT INTO usuarios (nome_usuario, senha) VALUES (?, ?)";
                        $conexao->prepare($query)->execute([$nome_usuario, $senha]);
                        header("Location: $url/login.php");
                        die();
                    }
                }else{
                    $erro = "As senhas precisam ser iguais.";
                }
            }
        }
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Cadastro</title>
    </head>
    <body>
        <?php
            require("./navbar.php");
        ?>
        <h1>Cadastro</h1>
        <form method="post">
            <p>Nome de Usuário</p>
            <input type="text" name="nome_usuario" placeholder="Nome de Usuário" required/><br>
            <p>Senha</p>
            <input type="password" name="senha" placeholder="Senha" required/><br>
            <p>Confirmar Senha</p>
            <input type="password" name="confirma_senha" placeholder="Confirmar Senha" required/><br><br>
            <div><?php if(isset($erro)) echo $erro; ?></div>
            <input type="submit" value="Enviar" />
        </form>
    </body>
</html>