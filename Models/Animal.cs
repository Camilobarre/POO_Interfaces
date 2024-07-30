using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models;
//En un diagrama UML, el abstracto se representa en cursiva
public abstract class Animal
{
    public string Nombre { get; set; }
    public double PesoKG { get; set; }

    public Animal(string nombre, double peso)
    {
        this.Nombre = nombre;
        this.PesoKG = peso;
    }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nombre} está durmiendo.");
    }

    public void Caminar()
    {
        Console.WriteLine($"{Nombre} está caminando.");
    }

    //Si hay un solo método abstracto, me obliga a que la clase sea abstracta
    public abstract void Respirar();
}