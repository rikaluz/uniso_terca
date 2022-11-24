<?php

namespace WWW\Controllers;

class CadastroController {

    public function index(){


        if (isset($_POST['cadastrar'])){

            $IdProduto = $_POST['idProduto'];
            $NomeItem = $_POST['nomeItem'];
            $FamiliaItem = $_POST['familiaItem'];
            $Unidade = $_POST['unidade'];
            $SituacaoItem = $_POST['situacao'];
            $Qtd = $_POST['quantidade'];
            $DtCadastro = $_POST['dataCadastro'];
            $DtLiberacao = $_POST['dataLiberacao'];
            $Descricao = $_POST['descricaoItem'];

            $Unidade = strtoupper($Unidade);

            if (!is_numeric($IdProduto)){

                \WWW\Utilidades::alerta('Insira apenas valores númericos!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Cadastro');
            }

            else if (is_numeric($FamiliaItem)){

                \WWW\Utilidades::alerta('Familia do Item deve haver apenas caractéres de texto!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Cadastro');
            }

            else if (is_numeric($Unidade)){

                \WWW\Utilidades::alerta('Unidade deve haver apenas caractéres de texto!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Cadastro');
            }

            else if ($SituacaoItem == 'Nenhum'){

                \WWW\Utilidades::alerta('Situação do item deve ser preenchida');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Cadastro');
            }

             else if ($DtCadastro.date('d/m/Y') > $DtLiberacao.date('d/m/Y')){

                \WWW\Utilidades::alerta('Data de liberação inválida!');
                \WWW\Utilidades::redirect(INCLUDE_PATH.'Cadastro');
            }   
   
            else {
                
                $strcon = mysqli_connect ("localhost","root","","meu_site") or die ("Erro ao conectar com o banco");
                $sql = "INSERT INTO cadastroitem VALUES ('".$IdProduto."' , '".$NomeItem."' , '".$FamiliaItem."' , '".$Unidade."' , '".$SituacaoItem."' , '".$Qtd."' , '".$DtCadastro."' , '".$DtLiberacao."' ,'".$Descricao."');";
                mysqli_query($strcon, $sql) or die ('Erro ao tentar cadastrar registro');

                \WWW\Utilidades::alerta('Cadastrado com sucesso!');
                \WWW\Utilidades::redirect(INCLUDE_PATH); 
            }

        }
        
        \WWW\Views\MainView::render('Cadastro');

    }
    
}

?>