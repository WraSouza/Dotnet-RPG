// See https://aka.ms/new-console-template for more information
using Dotnet_RPG.src.Entities;
Knight arus = new Knight("Arus",23,"Knight");

Wizard wizard = new Wizard("Jennica",23,"White Wizard");

Ninja ninja = new Ninja("Shisui", 30,"Ninja");

BlackWizard blackWizard = new BlackWizard("Geralt",35,"Black Wizard");

Console.WriteLine(blackWizard.Attack("dragao"));
