var pacientes  = document.querySelectorAll(".paciente");

pacientes.forEach(function(paciente){
  paciente.addEventListener("dblclick", function (){
    console.log("fui clickado c 2 click");
    this.remove();
  })
})
