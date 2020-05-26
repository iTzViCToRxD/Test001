$(document).ready(function () {
    $("#Enviar").click(function (e) {
        Validacion();
    });
});

function Validacion() {
    $.each(_PreguntasObligatorias, function (i, pregunta) {
        if (pregunta.TipoPregunta == 'ESMULTIPLE') {
            var respuestaEsMultiple = [];
            $('.CheckBox_' + pregunta.Id + ':checked').each(
                function () {
                    respuestaEsMultiple.push($(this).val());
                }
            );
            if (respuestaEsMultiple.length == 0) {
                Mensaje('.CheckBox_' + pregunta.Id, pregunta.Descripcion);
                //$('.CheckBox_' + pregunta.Id).focus();

                //$('#texto01').text(pregunta.Descripcion);
                //$('#modalConfirmacion').modal({
                //    show: true
                //});
            }
        } else if (pregunta.TipoPregunta == 'ESPARRAFO') {
            //TODO - VMAM - Por llamada de PM (2020-05-22 13:35) se cancela
            //Se detiene en las validaciones de las preguntas
            console.log('a');
        }
    });
}

function Mensaje(componente, pregunta) {
    $(componente).focus();
    $('#texto01').text(pregunta);
    $('#modalConfirmacion').modal({
        show: true
    });
}