﻿using System.Collections;
//definicion y creacion de un diccionario
Dictionary<string, int> dep = new Dictionary<string, int>()
{
    {"Boaco",185013},
    {"Carazo",197139},
    {"Chinandega",439906},
    {"Chontales",190863},
    {"Costa Caribe Norte",530586},
    {"Costa Caribe Sur",414543},
    {"Estelí",229866},
    {"Granada",214317},
    {"Jinotega",475630},
    {"León",421050},
    {"Madriz",174744},
    {"Managua",1575819},
    {"Masaya",391903},
    {"Matagalpa",593503},
    {"Nueva Segovia",271581},
    {"Río San Juan",135446},
    {"Rivas",182645}
};
//mostrar el diccionario
foreach (var item in dep)
    Console.WriteLine($"{item.Key,-20} ==> {item.Value,10:N0}");
//Suma de toda la poblacion
Console.WriteLine($"Poblacion general: {dep.Values.Sum():N0}");
//Mayor y Menor poblacion
var minResult = dep.Where(x => x.Value == dep.Values.Min());
var maxResult = dep.Where(x => x.Value == dep.Values.Max());
Console.WriteLine($"poblacion General: {dep.Values.Sum():N0}");
Console.WriteLine($"Menor Población:{minResult.First().Key}");
Console.WriteLine($"Mayor Población:{maxResult.First().Key}");

