using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Interfaces;
public interface IAnimal
{
    //Por defecto, los métodos siempre son públicos
    void Comer();
    void Dormir();
    void Respirar();
    void Desplazar();
}