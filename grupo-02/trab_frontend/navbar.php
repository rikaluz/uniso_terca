<?php
require("./url_raiz.php");
?>

<div id="navbar">
    <ul id="lista_navbar">
        <?php echo '<li><a href="' . $url . '/">Home</a></li>'; ?>
        <?php echo '<li><a href="' . $url . '/login.php">Login</a></li>'; ?>
        <?php echo '<li><a href="' . $url . '/cadastro.php">Cadastro</a></li>'; ?>
        <?php echo '<li><a href="' . $url . '/lista_item.php">Listagem de Itens</a></li>'; ?>
        <?php echo '<li><a href="' . $url . '/cadastro_item.php">Cadastro de Itens</a></li>'; ?>
        <?php echo '<li><a href="' . $url . '/logout.php">Logout</a></li>'; ?>
    </ul>
</div>