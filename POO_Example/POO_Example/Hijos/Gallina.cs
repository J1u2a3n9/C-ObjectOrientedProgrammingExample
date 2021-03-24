using POO_Example.Interfaces;
using POO_Example.Padres;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Example.Hijos
{
    class Gallina : Animal, IReproduccion
    {
        public Gallina(string nombre, int edad, char sexo) : base(nombre, edad, sexo)
        {
            SetEspecie();
            SetFormaDeReproduccion();
            SetPeriodoIncubacion();
            SetTamanio();
        }
        public void SetEspecie()
        {
            this._especie = "Gallus Domesticus";
        }

        public void SetFormaDeReproduccion()
        {
            this._formaReproduccion = "Oviparos";
        }

        public void SetPeriodoIncubacion()
        {
            this._periodoIncubacion = 21;
        }

        public void SetTamanio()
        {
            this._tamanio = 40;
        }

        public void DiAlgo(string algoParaDecir)
        {
            Console.WriteLine("Cucurucuru");
        }

        public override void DiTutamanio()
        {
            Console.WriteLine($"Mi tamaño es: {this._tamanio} cm");
        }

        public override void DiTuTiempoDeIncubacion()
        {
            Console.WriteLine($"El periodo de incubacion es: {this._periodoIncubacion} dias");

        }

        public override void DiTuEspecie()
        {
            Console.WriteLine($"Mi especie es: {this._especie}");
        }











    }

}

/*
 *      
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

        }
       
        public override void DiTutamanio()
        {
            Console.WriteLine($"Mi tamaño es: {this._tamanio}");
        }

        public override void DiTuTiempoDeIncubacion()
        {
            Console.WriteLine($"El periodo de incubacion es: {this._periodoIncubacion}");

        }

        public override void DiTuEspecie()
        {
            Console.WriteLine($"Mi especie es: {this._especie}");
        }










    }
 */