﻿$(document).ready(function () {
    $('#txtTelefone').mask('(99) 9999-9999');
    $('#txtCelular').mask('(99) 9 9999-9999');
});

function showPopover(dica) {

    $('#' + dica).popover('show');

}

function hidePopover(dica) {

    $('#' + dica).popover('hide');

}