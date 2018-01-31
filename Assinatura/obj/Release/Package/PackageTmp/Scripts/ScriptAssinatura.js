$(document).ready(function () {
    $('#txtTelefone').mask('99 9999-9999');
    $('#txtCelular').mask('99 99999-9999');

    $('#txtNome').focus();

 });

function showPopover(dica) {

    $('#' + dica).popover('show');

}

function hidePopover(dica) {

    $('#' + dica).popover('hide');

}

function limparCampos() {

    $('#txtNome').val("");
    $('#txtEmail').val("");
    $('#txtCelular').val("");
    $('#txtTelefone').val("");
    $('#txtDep').val("");

    $('#txtNome').focus();



}