// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const defaultCamp = document.querySelector('#CampDefault');
const clearCamp = document.querySelector('#CampClear');
const defaultTrip = document.querySelector('#RoadTripDefault');
const clearTrip = document.querySelector('#RoadTripClear');

const name = document.getElementById('Name');
const campName = document.getElementById('CampName');
const adjective1 = document.getElementById('Adjective1');
const activity1 = document.getElementById('Activity1');
const activity2 = document.getElementById('Activity2');
const pluralNoun = document.getElementById('PluralNoun');
const adjective2 = document.getElementById('Adjective2');
const noun = document.getElementById('Noun');
const nickName = document.getElementById('NickName');

const noun1 = document.getElementById('Noun1');

$(document).ready(function()
{
    defaultCamp.addEventListener('click', function()
    {
        if (name.getAttribute("value") === '')
        {
            name.setAttribute("value", "Mary");
        }
        
        if (campName.getAttribute("value") === '')
        {
            campName.setAttribute("value", "Dakota");
        }

        if (adjective1.getAttribute("value") === '')
        {
            adjective1.setAttribute("value", "great");
        }

        if (activity1.getAttribute("value") === '')
        {
            activity1.setAttribute("value", "fishing");
        }

        if (activity2.getAttribute("value") === '')
        {
            activity2.setAttribute("value", "rafting");
        }

        if (pluralNoun.getAttribute("value") === '')
        {
            pluralNoun.setAttribute("value", "smores");
        }

        if (adjective2.getAttribute("value") === '')
        {
            adjective2.setAttribute("value", "tasty");
        }

        if (noun.getAttribute("value") === '')
        {
            noun.setAttribute("value", "a lot");
        }

        if (nickName.getAttribute("value") === '')
        {
            nickName.setAttribute("value", "Lioness");
        }

    });
});

$(document).ready(function()
{
    clearCamp.addEventListener('click', function()
    {
        name.removeAttribute("value");
        campName.removeAttribute("value");
        adjective1.removeAttribute("value");
        activity1.removeAttribute("value");
        activity2.removeAttribute("value");
        pluralNoun.removeAttribute("value");
        adjective2.removeAttribute("value");
        noun.removeAttribute("value");
        nickName.removeAttribute("value");
    });
});

$(document).ready(function()
{
    defaultTrip.addEventListener('click', function()
    {
        if (noun1.getAttribute("value") === '')
        {
            noun1.setAttribute("value", "CAR");
        }
    });
});
