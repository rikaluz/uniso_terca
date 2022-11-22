<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Happy Animall</title>
<link rel="stylesheet" type="text/css" media="screen" href="css/Estilo1.css">
    
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>

    
</head>
<body>
<nav class="navbar navbar-expand-lg navbar-light bg-warning">
    <a class="navbar-brand" href="">
      <img class="nav_logo" src="imagem/logo happy animall.png" alt="..." height="40">
    </a>
    <marquee width="800"><h5>Seja Bem-Vindo ao nosso sitema!</h5></marquee>
    
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav ml-auto topnav">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Área do Colaborador</a>
                </li>
                <!-- <li class="nav-item">
                    <a class="nav-link" href="#">Administração</a>
                </li> -->
                
                <!-- <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Resources
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                        <a class="dropdown-item" href="#">Carfax</a>
                        <a class="dropdown-item" href="#">Carproof</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="#">Omnivic</a>
                    </div>
                </li> -->
                <li class="nav-item">
                    <a class="nav-link" href="#" onclick="MostraSobre();">Sobre</a>
                    
                </li>
                <!-- <li class="nav-item">
                    <a class="nav-link" href="#">Contato</a>
                </li>-->
                <li class="nav-item" style="padding-right: 4px;">
                    <a class="nav-link btn_entrar" type="button" onclick="MostraFormLogin('formularioLogin')"><span>Entrar</span></a>                  
                </li>
                <li class="nav-item">
                <a class="nav-link btn_cadastrar" type="button" onclick="MostraFormCad('formularioCad')">Cadastrar</a>
                </li>
            </ul>
        </div>
</nav>
            <!-- The Modal -->
    <div class="modal" id="msgCadSucesso">
        <div class="modal-dialog">
            <div class="modal-content">

                <!-- Modal Header -->
                <div class="modal-header">
                    <h4 class="modal-title">Usuário</h4>
                    <button type="button" class="close" data-dismiss="modal">×</button>
                </div>

                <!-- Modal body -->
                <div class="modal-body">
                    <h6>Usuário cadastrado com sucesso!</h6>
                </div>

                <!-- Modal footer -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Fechar</button>
                </div>

            </div>
        </div>
    </div>
    
<br>
    <div class="happyanimall">
        <img src="imagem/logo happy animall.png" alt="..." height="120">
        <h1>Onde seu animalzinho recebe o melhor com mais amor! </h1>
    </div>
<br>

<div id="container-formLogin" > 

<div id="msgOkBox" style="display:none">
<p id="msgOk"></p>
</div>
    <div class="box_login">
    <label class="lbAcessCol">Acesso do Colaborador </label><br>
        <form id="formularioLogin" name = "Login_user" action = "Cad_login_user.php" method = "POST">
            <input class="btspace" type = "text" placeholder = "Usuário " name = "cod_user" size = "10" ></br>
            <input class="btspace" type = "password" placeholder = "Digite a senha" name = "senha_user" size = "20" ></br>
            <input class="btEntrar" type = "submit" name = "enviar" value = "Entrar">
        </form>
        <h4>Ainda não é cadastrado?<h4>
        <button id="btCadAqui" type="button" onclick="MostraFormCad('formularioCad')">Cadastre-se aqui!</button>
    </div>
</div>

<div id="container-formCad" style="display:none" >    
    <div class="box_cadastro">
    <label class="lbCadCol">Cadastro do Colaborador </label><br>
    <label class="lbPrForm">PREENCHA O FORMULÁRIO</label>
        <form id="formulario" name = "Login_user">
        <!-- <form id="formulario" name = "Login_user" action = "Cad_login_user.php" method = "POST"> -->
            <input class="btspace" type = "text" placeholder = "Usuário " name = "cod_user" size = "10" ></br>
            <input class="btspace" type = "text" placeholder = "Nome " name = "nome_user" size = "30" ></br>
            <input class="btspace" type = "password" placeholder = "Digite a senha" name = "senha_user" size = "20" ></br>
            <input class="btCadastrar" type = "submit" onclick="MensagemCadOk()" name = "enviar" value = "Cadastrar">
            <!-- <input class="btCadastrar" type = "submit" onclick="MensagemCadOkModal()" name = "enviar" value = "Cadastrar" data-toggle="modal" data-target="#msgCadSucesso"> -->
        </form>
</div>
</div>  

<div id="container-sobre" style="display:none">
    <p id="textoSobre" >Escrever um texto sobre a empresa aqui</p>
</div>

<script type="text/javascript" src="js/showForm.js"></script>

</body>
</html>
