/// <reference path="_references.js" />

/* CarRegistry.js */

"use strict";

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

    var carColor = $('#CarColor');
    $.each(colors, function (index, color) {
        carColor.append('<option value="' + index + '">' + color.Name + '</option>');
    });

    var carYear = $('#CarYear');
    $.each(years, function (index, year) {
        carYear.append('<option value="' + index + '">' + year.Year + '</option>');
    });


    var cars = [];

    $('#AddCar').on('click', function () {
        if ($('#CarMake').val() &&
            $('#CarModel').val() &&
            $('#CarYear').val() != -1 &&
            $('#CarColor').val() != -1 )
        {
            var car = {
                Make: $('#CarMake').val(),
                Model: $('#CarModel').val(),
                Year: $('#CarYear  option:selected').text(),
                Color : $('#CarColor option:selected').text()
            };

            $('#AddCarTable tbody').append(
                                '<tr>' + 
                                    '<td>' + car.Make + '</td>' +
                                    '<td>' + car.Model + '</td>' +
                                    '<td>' + car.Year + '</td>' +
                                    '<td>' + car.Color + '</td>' +
                                '</tr>');

            $('#AddCarSection input[type="text"]').val("");
            $('#AddCarSection select').val(-1);

           cars.push(car);

            $('#SaveCarList').show();
        }
    });

    $('#SaveCarList').on('click', function () {
 
        $.ajax({
            url: 'Home/SaveCarList',
            type: 'POST',
            dataType: 'json',
            contentType : 'application/json',
            data: JSON.stringify(cars),
            success: function (response) {
                if (response.result === true) {
                    $('#SuccessMessage').toggle('slow')
                                        .animate({ opacity: 1.0 }, 2000)
                                        .toggle('slow');
                    $('#AddCarTable tbody tr').remove();
                    $('#SaveCarList').hide();
                }
                else {
                    $('#FailMessage').toggle('slow')
                                     .animate({ opacity: 1.0 }, 2000)
                                     .toggle('slow');
                }
            }
        });
    });
});

