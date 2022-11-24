<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,300;0,400;0,700;1,300&display=swap" rel="stylesheet">
    <link href="<?php echo INCLUDE_PATH_STATIC ?>CSS/home.css" rel="stylesheet">
    <link href="<?php echo INCLUDE_PATH ?>WWW/Views/fontawesome/css/all.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/4ea9f4c152.js" crossorigin="anonymous"></script>
    <script src="<?php echo INCLUDE_PATH_STATIC ?>Home.php"></script>
    
    <title>Bem vindo, <?php echo $_SESSION ['nome']; ?></title>
</head>
<body>
    <header class="cabecalho">
        <nav class="nav-area">
            <a class="nav-item">Home</a>
            <a class="nav-item" href="<?php echo INCLUDE_PATH?>Cadastro">Cadastrar Item</a>
            <a class="nav-item" href="<?php echo INCLUDE_PATH?>Integrantes">Integrantes</a>
            <a class="nav-item" id ="logout" name="logout" href="?logout"> <i class="fa-sharp fa-solid fa-arrow-right-from-bracket" id="exit-icon"></i>Sair</a>
        </nav>
    </header>
    <main>
        <section class="main-content">
            <img id="robot" src="<?php echo INCLUDE_PATH_STATIC?>Images/robot.png">
            <div class="welcome-text">
                <h1>Seja bem-vindo(a),</h1><h1 id="nome"><?php echo $_SESSION ['nome']; ?></h1>
            </div>
        </section>
    </main>
</body>

<script>
    const chk = document.getElementById("chk")

    chk.addEventListener('change', ()=> {
    document.body.classList.toggle('dark')
})
</script>
</html>