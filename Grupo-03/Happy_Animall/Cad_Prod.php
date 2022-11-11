<?php
    $nome = $_POST ['nome_user'];
    $senha = $_POST ['senha_user'];
    $strcon = mysqli_connect ("localhost","root","","bdha") or die ("Erro ao conectar com o banco");
    $sql = "INSERT INTO aluno VALUES ('".$nome."', '".$senha."');"; 
    mysqli_query($strcon, $sql) or die ('Erro ao tentar cadastrar registro'); 
    echo "Aluno cadastrado com sucesso";


?>