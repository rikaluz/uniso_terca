<?php

require_once("./config.php");

try {
  $conexao = new PDO("mysql:host=$servername;dbname=$bdname", $username, $password);
  $conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch(PDOException $erro) {
  echo "Erro na conexão: " . $erro->getMessage();
}

?>