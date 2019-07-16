var tempoInicial  = $("#tempo-digitacao").text();
var campo = $(".campo-digitacao");

$(function(){
  atualizaTamanhoFrase();
  inicializaContadores();
  inicializaCronometro();
  inicializaMarcadores();
  $("#botao-reiniciar").click(reiniciaJogo);

});
function atualizaTamanhoFrase() {
  var frase = $(".frase").text();
  var numeroPalavras = frase.split(" ").length;
  var tamanhoFrase = $("#tamanho-frase");
  tamanhoFrase.text(numeroPalavras);

}
  function inicializaContadores(){
    campo.on("input", function(){
      var conteudo = campo.val();

      var qtdPalavras = conteudo.split(/\S+/).length -1;
      $("#contador-palavras").text(qtdPalavras);

      var qtdCaracteres = conteudo.length;
      $("#contador-caracteres").text(qtdCaracteres);
      console.log(qtdPalavras);

    });
  }

function inicializaCronometro(){
var tempoRestante = $("#tempo-digitacao").text();
campo.one("focus", function(){
    var cronometroId = setInterval(function(){
    tempoRestante--;
      console.log(tempoRestante);
    $("#tempo-digitacao").text(tempoRestante);
      if(tempoRestante<1){
            clearInterval(cronometroId);
            finalizaJogo();
      }
    },1000);
  });
}

function finalizaJogo()
{
  campo.attr("disabled", true);
  campo.toggleClass("campo-desativado");
  inserePlacar();

}
  function inicializaMarcadores()
  {
    var frase = $(".frase").text();
    campo.on("input", function(){
      var digitado = campo.val();
      var comparavel = frase.substr(0,digitado.length);
      console.log("Digitado"+ digitado);
      console.log("Frase C." + comparavel);

      if(digitado == comparavel)
      {
        campo.addClass("campo-correto");
        campo.removeClass("campo-errado");
      }
      else
      {
        campo.addClass("campo-errado");
        campo.removeClass("campo-correto");
      }

    });

  }
function inserePlacar() {
  var corpoTabela = $(".placar").find("tbody");
  var usuario = "carlos";
  var numeroPalavras =$("#contador-palavras").text();
  var botaoRemover = "<a href='#'><i class='small material-icons'>delete</i></a>"

  var linha = "<tr>"+
               "<td>"+usuario +"</td>"+
               "<td>"+numeroPalavras +"</td>"+
                "<td>"+ botaoRemover +"</td>"+
               "</tr>";
  corpoTabela.prepend(linha);
}


$(".botao-remover").click(function () {
  console.log("this");
});
function reiniciaJogo()
{
    campo.attr("disabled", false);
    campo.val("");
    $("#contador-palavras").text("0");
    $("#contador-caracteres").text("0");
    $("#tempo-digitacao").text(tempoInicial);
    inicializaCronometro();
    campo.toggleClass("campo-desativado");
    campo.removeClass("campo-errrado");
    campo.removeClass("campo-correto");
}
