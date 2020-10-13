window.ResetValue =
{
    GetSelectedElement: function (id) {
        var e = document.getElementById(id);
        var aux = e.options[e.selectedIndex].text;      
        return aux;
    },

    SelectElement: function (element) {      
        element.selectedIndex = 0;
    }
};