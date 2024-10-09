function sumar() {
    var number1 = parseInt(document.getElementById("number1").value);
    var number2 = parseInt(document.getElementById("number2").value);
    
    document.getElementById("resultado").value = number1 + number2;
}

$(document).ready(function () {
    $('#sumar').click(function () {
        var num1 = parseFloat($('#number1').val()) || 0;
        var num2 = parseFloat($('#number2').val()) || 0;
        var suma = num1 + num2;
        $('#resultado').val(suma);
    });
});