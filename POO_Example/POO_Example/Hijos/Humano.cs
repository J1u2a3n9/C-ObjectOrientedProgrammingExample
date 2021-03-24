using POO_Example.Interfaces;
using POO_Example.Padres;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Example.Hijos
{
    public class Humano : Animal, IReproduccion
    {
        public Humano(string nombre,int edad,char sexo):base(nombre,edad,sexo)
        {
            SetEspecie();
            SetFormaDeReproduccion();
            SetPeriodoIncubacion();
            SetTamanio();
        }
        public void SetEspecie()
        {
            this._especie = "Homo Sapiens";
        }

        public void SetFormaDeReproduccion()
        {
            this._formaReproduccion = "Viviparos";
        }

        public void SetPeriodoIncubacion()
        {
            this._periodoIncubacion = 9;
        }

        public void SetTamanio()
        {
            this._tamanio = 1.70;
        }
        public void DiAlgo(string algoParaDecir)
        {
            Console.WriteLine("Hola");
        }
       
        public override void DiTutamanio()
        {
            Console.WriteLine($"Mi tamaño es: {this._tamanio} m.");
        }

        public override void DiTuTiempoDeIncubacion()
        {
            Console.WriteLine($"El periodo de incubacion es: {this._periodoIncubacion} meses");

        }

        public override void DiTuEspecie()
        {
            Console.WriteLine($"Mi especie es: {this._especie}");
        }










    }
}
