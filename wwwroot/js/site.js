$(function () {

    var DOM = {
        "ButtonNew": "#btnNuevo",
        "List": "#divLista",
        "Input": "#txtNuevo",
        "Cargando": "#lblCargando"
    };

    function ready() {
        $(DOM.ButtonNew).click(InsertName);
        RenderAll();
    }

    function ShowLoader() {
        $(DOM.Cargando).show();
    }

    function HideLoader() {
        $(DOM.Cargando).hide();
    }

    function InsertName() {
        var newName = $(DOM.Input).val();
        if (!newName || newName === "" || newName === " ") {
            alert("Ingrese un nombre");
        } else {
            ShowLoader();
            $(".disabledLoading").attr("disabled", "disabled");
            $.ajax({
                "url": "Home/Insert",
                "data": { "Nombre": newName },
                "type": "POST"
            }).done(function (rta) {
                if (rta) {
                    RenderAll();
                } else {
                    alert("Ha habido un error al guardar el registro");
                }
                $(".disabledLoading").removeAttr("disabled");
           });
        }
    }

    function RenderAll() {
        ShowLoader();
        $.ajax({
            "url": "Home/GetAll",
            "type": "GET"
        }).done(function (data) {
            var html = "";
            $.each(data, function (i, usuario) {
                html += '<li class="list-group-item">' + usuario.nombre + '</li>';
            });
            $(DOM.List).html(html);
            HideLoader();
        });
    }

    ready();
});
