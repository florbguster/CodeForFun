/// <reference path="_references.js" />

$(document).ready(function () {

    var colors = [
        { Name: "White" },
        { Name: "Blue" },
        { Name: "Green" },
        { Name: "Red" },
        { Name: "Black" },
        { Name: "Silver" },
    ];

    var years = [
        { Year: 2010 },
        { Year: 2012 },
        { Year: 2013 },
        { Year: 2014},
        { Year: 2015 }
    ];

    var colorDropdown = $('#ColorDropdown');
    $.each(colors, function (index, color) {
        colorDropdown.append('<option value="'+ index +'">'+ color.Name +'</option>');
    });

    var yearDropdown = $('#YearDropdown');
    $.each(years, function (index, year) {
        yearDropdown.append('<option value="' + index + '">' + year.Year + '</option>');
    });
});

