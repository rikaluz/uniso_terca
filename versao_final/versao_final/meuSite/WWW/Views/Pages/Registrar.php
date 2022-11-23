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
    <link href="<?php echo INCLUDE_PATH_STATIC ?>CSS/registrar.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/4ea9f4c152.js" crossorigin="anonymous"></script>

    <title>Registro</title>
</head>
<body>
<main class="container">
    <h2>Cadastro de Usuário</h2>
        <form method="POST" action=""> <!-- Passando o metódo POST para fazer a validação no backend, e não mostrar nenhum dado para o usuário. -->
            <div class="input-group">
                <fieldset>
                    <div class="input-field">
                        <input type ="text" name="registro-id" id="registro-id" placeholder="Registro de ID *" size="14" required >
                    </div>
                </fieldset>

                <fieldset>
                    <div class="input-field">
                        <input type="text" name="name" id ="name" placeholder="Nome *" required >
                    </div>
                </fieldset>

                <fieldset>
                    <div class="input-field">
                        <input type="text" name="email" id="email" placeholder="Email *" required >
                    </div>
                </fieldset>

                <fieldset>
                    <div class="input-field">
                        <input type="password" name="password" id="password" placeholder="Digite sua senha *" required >
                    </div>
                    <div class="input-field">
                        <input type="password" name="confirm-password" id="confirm-password" placeholder="Confirme sua senha *" required>
                    </div>
                </fieldset>

                <fieldset>
                    <div id="check"><br>
                        <input type="checkbox" name="accept" required >
                        <label>I have read and agree to the <i><a id ="terms" href ="#">terms of service</a></i></label>
                    </div>

                <div class ="finish-button"><br>
                    <input type="submit" name="button-create" id="button-create" value="Continue">
                    
                </div>
            </div>
            <div>
                <input type="hidden" name="registrar" value="registrar">
            </div> 
        </form>         
</body>
</html>