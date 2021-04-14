'use strict';


const abrir = document.getElementById("BtnVerUsuarios");
const tablamodal =document.getElementById("tablamodal");


abrir.onclick = ()=>{
    alert("Estas dando click");
    tablamodal.style.display = "block";
}