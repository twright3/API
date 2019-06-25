

$(function () {
    $("#logo").text("twright Swagger Harness");
    $("#logo").attr("href", "https://twrightfinancialapi.azurewebsites.net");


    $("title").text("twright Swagger");

    $("link[sizes='32x32']").attr("href", "/Images/Browser_Logo.jpg");
    $("link[sizes='16x16']").attr("href", "/Images/Browser_Logo.jpg");

    $("a[data-id='Households']").first().text("Custom Swagger Controller");

    $("html")[0].style.visibility = "visible";

});

