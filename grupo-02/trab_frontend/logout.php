<?php

require("./url_raiz.php");

setcookie('autenticado', null, -1);
header("Location: $url");
die();

?>