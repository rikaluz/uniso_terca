<!doctype html>
<html lang="en">
  <head>
    <title>Happy Animall | Cadastro de Produto</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet"  href="css/style.css">
  </head>
  <body>
    <div class="container menu_cadastro">
        <img src="imagem/logo happy animall.png" />
        <p>#nome usuario#</p>
        <ul class="list-group">
            <li class="list-group-item"><button class="btn_menu">SAIR</button></li>

        </ul>
    </div>
    <div >
    <div class="container box_cadastro">
        <div class="form-group">
          <label for="">Nome do Produto</label>
          <input type="text" class="form-control" name="" id="txtNome" aria-describedby="emailHelpId" placeholder="">
   
          <label for="">Grupo</label>
          <input type="text" class="form-control" name="" id="txtGrupo" aria-describedby="emailHelpId" placeholder="">
          
          <label for="">Descrição</label>
          <input type="text" class="form-control" name="" id="txtDescricao" aria-describedby="emailHelpId" placeholder="">

          <label for="">Unidade</label>
          <input type="text" class="form-control" name="" id="txtUnidade" aria-describedby="emailHelpId" placeholder="">

          <label for="">Preço</label>
          <input type="text" class="form-control" name="" id="txtPreco" aria-describedby="emailHelpId" placeholder="">

          <label for="">Marca</label>
          <input type="text" class="form-control" name="" id="txtMarca" aria-describedby="emailHelpId" placeholder="">

          <label for="">Estoque</label>
          <input type="text" class="form-control" name="" id="txtEstoque" aria-describedby="emailHelpId" placeholder="">

          <div class="box-data">
            <label for="dtpDataLiberacao">Data de Liberação</label>
            <input
              type="date"
              id="dtpDataLiberacao"
              value="2022-08-29"
              required
            />
            <br>
            <label for="dtpDataImpletacao">Data de Implementação</label>
            <input
              type="date"
              id="dtpDataImpletacao"
              value="2022-08-29"
              required
            />
          </div>
        </div>
       
    </div>
    <div class="container box_button_cadastrar">
    <button type="button" class="btn btn_cadastrar">Cadastrar</button>
    </div>
    <div class="container box_button_cadastrar">
      <button type="button" class="btn btn_cadastrar">Atualizar</button>
      </div>
      <div class="container box_button_cadastrar">
        <button type="button" class="btn btn_cadastrar">Excluir</button>
        </div>
    </div>
   
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>