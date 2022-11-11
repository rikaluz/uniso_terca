<?php

require("./url_raiz.php");

if(!isset($_COOKIE['autenticado'])){
    header("Location: $url");
    die();
}else{
    require("./conecta_banco.php");
    
    $familia = isset($_POST["familia"]) ? $_POST["familia"] : "";
    $unidade_medida = isset($_POST["unidade_medida"]) ? $_POST["unidade_medida"] : "";
    $situacao_item = isset($_POST["situacao_item"]) ? $_POST["situacao_item"] : "";
    $data_implantacao = isset($_POST["data_implantacao"]) ? $_POST["data_implantacao"] : "";
    $data_liberacao = isset($_POST["data_liberacao"]) ? $_POST["data_liberacao"] : "";
    $campo_narrativa = isset($_POST["campo_narrativa"]) ? $_POST["campo_narrativa"] : "";
    $saldo_estoque = isset($_POST["saldo_estoque"]) ? $_POST["saldo_estoque"] : "";

    if($familia != "" && $unidade_medida != "" && $situacao_item != "" && $data_implantacao != "" && $campo_narrativa != "" && $saldo_estoque != ""){
        $query = "INSERT INTO itens (familia, unidade_medida, situacao_item, data_implantacao, data_liberacao, campo_narrativa, saldo_estoque) VALUES (?, ?, ?, ?, ?, ?, ?)";
        $conexao->prepare($query)->execute([$familia, $unidade_medida, $situacao_item, $data_implantacao, $data_liberacao, $campo_narrativa, $saldo_estoque]);
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Cadastro de Itens</title>
    </head>
    <body>
        <?php
            require("./navbar.php");
        ?>
        <h1>Cadastro de Itens</h1>
        <form method="post">
            <p>Família</p>
            <input type="text" name="familia" required/><br>
            <p>Unidade de Medida</p>
            <input type="text" name="unidade_medida" required/><br>
            <p>Situação do Item</p>
            <select name="situacao_item" required>
                <option value="Pendente">Pendente</option>
                <option value="Finalizado">Finalizado</option>
            </select><br>
            <p>Data de Implantação</p>
            <input type="date" name="data_implantacao" required/><br>
            <p>Data de Liberação</p>
            <input type="date" name="data_liberacao"/><br>
            <p>Campo de Narrativa</p>
            <input type="text" name="campo_narrativa" required/><br>
            <p>Saldo no Estoque</p>
            <input type="number" name="saldo_estoque" required/><br><br>
            <input type="submit" value="Enviar" />
        </form>
    </body>
</html>