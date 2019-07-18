$("#botao-frase").click(fraseAleatoria);
$("#botao-frase-id").click(buscaFrase);

function fraseAleatoria()
{
  $("#spinner").show();
    $.get("http://localhost:3000/frases", trocaFraseAleatoria).fail(function(){
      setTimeout(function(){
        $("#erro").toggle();
      },1500);
      $("#erro").show();
    })
    .always(function(){
      $("#spinner").toggle();
    })
  }


function trocaFraseAleatoria(data) {
    var frase = $(".frase");
    var numeroAleatorio = Math.floor(Math.random() * data.length);

    frase.text(data[numeroAleatorio].texto);
    atualizaTamanhoFrase();
    atualizaTempoInicial(data[numeroAleatorio].tempo);
}

function buscaFrase(){
  $("#spinner").toggle();
  var fraseId = $("#frase-id").val();
  var dados = {id: fraseId};

  $.get("http://localhost:3000/frases", dados, trocaFrase).fail(function(){
    $("#erro").toggle();
    setTimeout(function(){
      $("#erro").toggle();
    },1500);
  })
  .always(function () {
    $("#spinner").toggle();
  });
  }
  function trocaFrase(data){
      var frase = $(".frase");
      frase.text(data.texto);
      atualizaTamanhoFrase(0);
      atualizaTempoInicial(data.tempo);
  }
