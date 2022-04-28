function meca(id) {
    var request = $.ajax({
        url: '/admin/EditMecanico?id=' + id
    });
    request.done(function (resp) {
        console.log(resp);
        $("#edit").html(resp);
    });
};

//$('.regmec').click(function () {
//    var request = $.ajax({
//        url: '/admin/registrar'
//    });
//    request.done(function (resp) {
//        console.log(resp);
//        $("#regisMeca").html(resp);
//    });
//});

function clien(id) {
    var request = $.ajax({
        url: '/mecanico/EditCliente?id=' + id
    });
    request.done(function (resp) {
        console.log(resp);
        $("#editClie").html(resp);
    });
};

var $reques = $.ajax({
    url: '/admin/listmeca',
    type: 'GET'
});
$reques.done(function (e) {
    $('.listMeca').html(e);
});


var $btnBuscar = $('.btnBuscar');
$btnBuscar.click(function (es) {

    es.preventDefault();

    var buscar = $.ajax({
        url: '/admin/listmeca?buscarmeca=' + $('#search').val(),
        type: 'GET'
    });
    buscar.done(function (response) {
        $('.listMeca').html(response);
    });

    $('#search').val(null);
});


/*MOSTRAR LISTA DE LOS CLIENTES*/
var $reques = $.ajax({
    url: '/mecanico/allclientes',
    type: 'GET'
});
$reques.done(function (e) {
    $('.allcliente').html(e);
});

/*BUSCAR CLIENTES*/
var $btnBuscar = $('.btnBuscarCli');
$btnBuscar.click(function (es) {

    es.preventDefault();

    var buscar = $.ajax({
        url: '/mecanico/allclientes?buscarclientes=' + $('#search').val(),
        type: 'GET'
    });
    buscar.done(function (response) {
        $('.allcliente').html(response);
    });

    $('#search').val(null);
});