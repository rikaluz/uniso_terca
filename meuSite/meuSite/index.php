<?php
// Inicialização da aplicação * 

    session_start();
    
    define('INCLUDE_PATH_STATIC','http://localhost/meuSite/WWW/Views/Pages/');
    define('INCLUDE_PATH','http://localhost/meuSite/');

    require('vendor/autoload.php');

    $app = new WWW\Application();

    $app->run();

?>