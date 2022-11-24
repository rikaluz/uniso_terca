<!DOCTYPE html>
<html lang="pt-BR">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv=”Content-Type” content=”text/html; charset=iso-8859-1″>
        <link href="<?php echo INCLUDE_PATH_STATIC ?>CSS/cadastro.css" rel="stylesheet">
        
            <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
            <link rel="preconnect" href="https://fonts.googleapis.com/%22%3E">
            <link rel="preconnect" href="https://fonts.gstatic.com/" crossorigin>
            <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;700&display=swap" rel="stylesheet">
            <link href="<?php echo INCLUDE_PATH ?>WWW/Views/fontawesome/css/all.css" rel="stylesheet">
            <script src="https://kit.fontawesome.com/4ea9f4c152.js" crossorigin="anonymous"></script>

        <title>Cadastro de Item</title>
    </head>
    <body>
        <header class="cabecalho">
            <nav class="nav-area">
                <a class="nav-item" href="<?php echo INCLUDE_PATH?>Home">Home</a>
                <a class="nav-item" href="<?php echo INCLUDE_PATH?>Cadastro">Cadastrar Item</a>
                <a class="nav-item" href="<?php echo INCLUDE_PATH?>Integrantes">Integrantes</a>
            </nav>
        </header>
        
        <container class="add-form">
            <form method = "POST" action="" class="row g-3" name = "Cadastro">
                <div class="col-md-3">
                    <div class="input-group">
                      <div class="input-group-text">ID</div>
                      <input class="form-control" type = "text" name = "idProduto" size = "9" required ></br>
                    </div>
                </div>

                <div class="col-md-11">
                    <label class="form-label">Nome</label>
                    <input class="form-control" type = "text" name = "nomeItem" size = "50" required ></br>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <label class="form-label">Familia do Item</label>
                        <input class="form-control" type = "text" name = "familiaItem" size = "10"  required></br>
                    </div>

                    <div class="col-md-6">
                        <label class="form-label">Unidade</label>
                        <input class="form-control" type = "text" maxlength="2" name = "unidade" size = "2" required ></br>
                    </div>
                </div>

                <div class="col-md-12">
                    <label class="form-label">Situação</label>
                    <select name ="situacao" class="form-select" aria-label="Default select example" >
                        <option value = "Nenhum"></option>
                        <option value = "Ativo">Ativo</option>
                        <option value = "Em Analise">Em analise</option>
                        <option value = "Obsoleto">Obsoleto</option>
                        <option value = "Totalmente Obsoleto">Totalmente Obsoleto</option>
                    </select><br/>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label class="form-label">Data de Cadastro</label>
                        <input class="form-control" type="date" name="dataCadastro" value="dataCadastro"  required /></br>
                    </div>

                    <div class="col-md-6">
                        <label class="form-label">Data de Licitação</label>
                        <input class="form-control" type = "date" name="dataLiberacao" value = "dataLiberacao" required /></br>
                    </div>
                </div>
                <div class="col-md-6">
                    <label class="form-label">Quantidade</label>
                    <input class="form-control" type = "number" name = "quantidade" required ></br>
                </div>

                <div class="col-md-12">
                    <label class="form-label">Descrição</label>
                    <textarea  class="form-control" name = "descricaoItem" size = "150" ></textarea></br>
                </div>

                <div class="col-md-6">
                    <button id="btn-cadastrar" type="submit">Cadastrar</button>
                    <input type="hidden" name="cadastrar" value="cadastrar">
                </div>
            </form>
        </container>
    </body>
</html>