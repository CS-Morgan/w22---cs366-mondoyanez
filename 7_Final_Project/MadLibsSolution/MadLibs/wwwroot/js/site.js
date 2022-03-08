// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const defaultCamp = document.querySelector('#CampDefault');

const name = document.getElementById('Name');
const campName = document.getElementById('CampName');
const adjective1 = document.getElementById('Adjective1');
const activity1 = document.getElementById('Activity1');
const activity2 = document.getElementById('Activity2');
const pluralNoun = document.getElementById('PluralNoun');
const adjective2 = document.getElementById('Adjective2');
const noun = document.getElementById('Noun');
const nickName = document.getElementById('NickName');

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