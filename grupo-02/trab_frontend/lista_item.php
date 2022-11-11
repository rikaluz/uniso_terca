<?php
//  TODO listagem de itens
require("./url_raiz.php");

if(!isset($_COOKIE['autenticado'])){
    header("Location: $url");
    die();
}else{
    require("./conecta_banco.php");
    
    $familia = isset($_POST["familia"]) ? $_POST["familia"] : "";

    function get_info($conexao, $familia)
    {
        if($familia != ""){
            $item = $conexao->query("SELECT * FROM itens WHERE familia = '$familia'");
        }else{
            $item = $conexao->query("SELECT * FROM itens");
        }
        if ($row = $item->fetchAll()) {
            return $row;
        }
        return false;
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Listagem de Itens</title>
    </head>
    <body>
        <?php
            require("./navbar.php");
        ?>
        <h1>Listagem de Itens</h1>
        <form method="post">
            <p>Família</p>
            <input type="text" name="familia"/><br><br>
            <input type="submit" value="Enviar" />
        </form>
        <table border="1">
        <tr COLSPAN=2 BGCOLOR="#d0d0d0">
            <th>cod_item</th>
            <th>familia</th>
            <th>unidade_medida</th>
            <th>situacao_item</th>
            <th>data_implantacao</th>
            <th>data_liberacao</th>
            <th>campo_narrativa</th>
            <th>saldo_estoque</th>
        </tr>
        <?php
            $result = get_info($conexao, $familia);
            foreach($result as $row)
            {
        ?>
        <tr>
            <td><?php echo $row["cod_item"] ?></td>
            <td><?php echo $row["familia"] ?></td>
            <td><?php echo $row["unidade_medida"] ?></td>
            <td><?php echo $row["situacao_item"] ?></td>
            <td><?php echo $row["data_implantacao"] ?></td>
            <td><?php echo $row["data_liberacao"] ?></td>
            <td><?php echo $row["campo_narrativa"] ?></td>
            <td><?php echo $row["saldo_estoque"] ?></td>
        </tr>
        <?php
            }
        ?>
        </table>
    </body>
</html>