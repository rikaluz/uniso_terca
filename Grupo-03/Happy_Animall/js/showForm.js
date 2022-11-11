
function MostraFormLogin() {
document.getElementById("container-formLogin").style.display = "grid";
document.getElementById("container-formCad").style.display = "none";
document.getElementById("container-sobre").style.display = "none";
document.getElementById("msgOkBox").style.display = "none";
e.preventDefault();
return false
 }

function MostraFormCad() {
    document.getElementById("container-formLogin").style.display = "none";
    document.getElementById("container-formCad").style.display = "grid";
    document.getElementById("container-sobre").style.display = "none";
    document.getElementById("msgOkBox").style.display = "none";
    e.preventDefault();
    return false
    }

function MensagemCadOk() {
    var msgOk  = document.getElementById("msgOk").innerHTML;
    msgOk = "Cadastro efetuado com sucesso!<br> Faça login para entrar </br>";
    document.getElementById("msgOk").innerHTML = msgOk;
    document.getElementById("msgOkBox").style.display = "";
    

    document.getElementById("container-formLogin").style.display = "grid";
    document.getElementById("container-formCad").style.display = "none";
    document.getElementById("container-sobre").style.display = "none";
    e.preventDefault();
    return false;
        }

function MensagemCadOkModal() {
  document.getElementById("container-formLogin").style.display = "grid";
  document.getElementById("container-formCad").style.display = "none";
  document.getElementById("container-sobre").style.display = "none";
  document.getElementById("msgOkBox").style.display = "none";
  e.preventDefault();
  return false;
  }

function MostraSobre() {
  document.getElementById("container-sobre").style.display = "grid";
  document.getElementById("container-formLogin").style.display = "none";
  document.getElementById("container-formCad").style.display = "none";
  document.getElementById("msgOkBox").style.display = "none";
  e.preventDefault();
  }

    