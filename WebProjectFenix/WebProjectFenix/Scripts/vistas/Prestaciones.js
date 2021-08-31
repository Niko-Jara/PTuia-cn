/*FUNCIONES PARA DESPLEGAR O NO LA SECCION*/

function mostrarSecVacac() {
    document.getElementById('SectionVacaciones').style.display = 'block';
    document.getElementById('SectionAguinaldo').style.display = 'none'; 
    document.getElementById('SectionPreavisos').style.display = 'none';
    document.getElementById('SectionCesantia').style.display = 'none';
}
function mostrarSecAguinal() {
    document.getElementById('SectionVacaciones').style.display = 'none';
    document.getElementById('SectionAguinaldo').style.display = 'block'; 
    document.getElementById('SectionPreavisos').style.display = 'none';
    document.getElementById('SectionCesantia').style.display = 'none';
}
function mostrarSecPreav() {
    document.getElementById('SectionVacaciones').style.display = 'none';
    document.getElementById('SectionAguinaldo').style.display = 'none'; 
    document.getElementById('SectionPreavisos').style.display = 'block';
    document.getElementById('SectionCesantia').style.display = 'none';
}
function mostrarSecCesan() {
    document.getElementById('SectionVacaciones').style.display = 'none';
    document.getElementById('SectionAguinaldo').style.display = 'none'; 
    document.getElementById('SectionPreavisos').style.display = 'none';
    document.getElementById('SectionCesantia').style.display = 'block';
}