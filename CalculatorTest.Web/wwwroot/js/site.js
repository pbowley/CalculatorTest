$(document).ready(function () {
    $("form").on("submit", function (event) {
        event.preventDefault();
        let url = getUrl($("#operation").val(), $("#start").val(), $("#amount").val());
        $.get(url)
            .done(function (data) {
                $("#result").html("The result of your calculation is: " + data + ".");
            })
            .catch(function () {
                $("#result").html("There was an error in processing your calculation.");
            });
    })
    $("#launch-modal").click(clearForm);
    $("#toggle-styles").click(toggleStyles);
});

function getUrl(operation, start, amount) {
    let urlBase = "http://localhost:5210/simplecalculator/";
    if (operation == "add") {
        return urlBase + "add/" + start + "/" + amount;
    }
    return urlBase + "subtract/" + start + "/" + amount;
}

function clearForm() {
    $("#start").val(0);
    $("#amount").val(0);
    $("#operation").val("add");
    $("#result").html("");
}

function toggleStyles() {
    if ($("#modal-alternative").length == 0) {
        $("head").append("<link rel=\"stylesheet\" id=\"modal-alternative\" type=\"text/css\" href=\"/css/modal.css\" />");
    }
    else {
        $("#modal-alternative").remove();
    }
}