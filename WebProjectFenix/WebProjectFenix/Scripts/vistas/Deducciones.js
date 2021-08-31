/*FUNCIONES PARA DESPLEGAR O NO LA SECCION*/

function mostrarSecIncap() {
    document.getElementById('SectionIncapacidad').style.display = 'block';
    document.getElementById('SectionPermisos').style.display = 'none'; 
    document.getElementById('SectionAusencia').style.display = 'none';
    document.getElementById('SectionEmbargos').style.display = 'none';
    document.getElementById('SectionAdelantos').style.display = 'none';
    document.getElementById('SectionLlegadasTardias').style.display = 'none';
    document.getElementById('SectionImpRenta').style.display = 'none'
}
function mostrarSecPerm() {
    document.getElementById('SectionPermisos').style.display = 'block';
    document.getElementById('SectionIncapacidad').style.display = 'none'; 
    document.getElementById('SectionAusencia').style.display = 'none';
    document.getElementById('SectionEmbargos').style.display = 'none';
    document.getElementById('SectionAdelantos').style.display = 'none';
    document.getElementById('SectionLlegadasTardias').style.display = 'none';
    document.getElementById('SectionImpRenta').style.display = 'none'
}
function mostrarSecAusen() {
    document.getElementById('SectionAusencia').style.display = 'block';
    document.getElementById('SectionPermisos').style.display = 'none';
    document.getElementById('SectionIncapacidad').style.display = 'none'; 
    document.getElementById('SectionEmbargos').style.display = 'none';
    document.getElementById('SectionAdelantos').style.display = 'none';
    document.getElementById('SectionLlegadasTardias').style.display = 'none';
    document.getElementById('SectionImpRenta').style.display = 'none'
}
function mostrarSecEmbargos() {
    document.getElementById('SectionEmbargos').style.display = 'block'
    document.getElementById('SectionAusencia').style.display = 'none';
    document.getElementById('SectionPermisos').style.display = 'none';
    document.getElementById('SectionIncapacidad').style.display = 'none'; 
    document.getElementById('SectionAdelantos').style.display = 'none';
    document.getElementById('SectionLlegadasTardias').style.display = 'none';
    document.getElementById('SectionImpRenta').style.display = 'none'
}
function mostrarSecAdelantos() {
    document.getElementById('SectionAdelantos').style.display = 'block'
    document.getElementById('SectionEmbargos').style.display = 'none'
    document.getElementById('SectionAusencia').style.display = 'none';
    document.getElementById('SectionPermisos').style.display = 'none';
    document.getElementById('SectionIncapacidad').style.display = 'none'; 
    document.getElementById('SectionLlegadasTardias').style.display = 'none';
    document.getElementById('SectionImpRenta').style.display = 'none'
}
function mostrarSecLlegTard() {
    document.getElementById('SectionLlegadasTardias').style.display = 'block'
    document.getElementById('SectionAdelantos').style.display = 'none'
    document.getElementById('SectionEmbargos').style.display = 'none'
    document.getElementById('SectionAusencia').style.display = 'none';
    document.getElementById('SectionPermisos').style.display = 'none';
    document.getElementById('SectionIncapacidad').style.display = 'none'; 
    document.getElementById('SectionImpRenta').style.display = 'none'
}
function mostrarSecImpRenta() {
    document.getElementById('SectionImpRenta').style.display = 'block'
    document.getElementById('SectionLlegadasTardias').style.display = 'none'
    document.getElementById('SectionAdelantos').style.display = 'none'
    document.getElementById('SectionEmbargos').style.display = 'none'
    document.getElementById('SectionAusencia').style.display = 'none';
    document.getElementById('SectionPermisos').style.display = 'none';
    document.getElementById('SectionIncapacidad').style.display = 'none'; 
}