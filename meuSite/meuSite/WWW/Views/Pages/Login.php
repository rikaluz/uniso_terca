<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,300;0,400;0,700;1,300&display=swap" rel="stylesheet">
    <link href="<?php echo INCLUDE_PATH_STATIC ?>CSS/login.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    
    <title>Login</title>
</head>
<body>
<body>
<form method="POST" action="">
    <div class="box">
            <div class="login-title">
                <h1>Bem-vindo!</h1>
            </div>
            <div class="id-login">
           <!--  <div  method ="GET" hidden class="alert alert-primary" role="alert" name="boot" method="POST">
            Senha ou Email Incorretos!      Tentando passar o bootstrap pra validar login.
            </div> -->
                <i id="icon-id" class="bi bi-person"></i>
                <input id ="login" type="text" name="id"placeholder="Insira seu ID" required>
                <div class="underline"></div>
            </div> 
            <div class="password-login">
                <i id="icon-password" class="bi bi-key"></i>
                <input id="password" type="password" name="password" placeholder="Insira sua senha" required>
                <div class="underline"></div>
            </div>
            <div class="button-login">
                <input type="submit" id="button" value="Login">
                <input type="hidden" name="login">
            </div>
            <div class="new-user">
                <p>Novo usuário?</p>
                <a href="<?php echo INCLUDE_PATH ?>Registrar">Criar conta!</a>
            </div>
        </form>
    </div>
</body>
</body>
</html>