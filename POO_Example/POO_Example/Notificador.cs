using POO_Example.Hijos;
using POO_Example.Padres;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Example
{
    class Notificador
    {
        public void Menu()
        {
            Animal especie=new Animal("",0,' ');
            char opc='S';
            do
            {
                Console.WriteLine("                     BIENVENIDO                              ");
                Console.WriteLine("         1)Humano");
                Console.WriteLine("         2)Gallina");
                Console.Write("Escoja La especie de la cual desea saber mas informacion:  ");
                opc = Convert.ToChar(Console.ReadLine());
                switch (opc)
                {
                    case '1':
                        especie = new Humano("Jose", 22, 'M');
                        break;
                    case '2':
                        especie = new Gallina("Pepe", 1, 'F');
                        break;
                }
                MostrarSubMenu(ref opc, ref especie);
                Console.Write("Desea continuar? :   ");
                opc = Convert.ToChar(Console.ReadLine());

            } while (opc == 'S' || opc == 's');
        }


        public void MostrarMenuCategoria(ref char opc)
        {

                Console.WriteLine("         1)Preguntar su Nombre");
                Console.WriteLine("         2)Preguntar su especie");
                Console.WriteLine("         3)Preguntar su Genero");
                Console.WriteLine("         4)Preguntar su Edad");
                Console.WriteLine("         5)Preguntar su tamaño");
                Console.WriteLine("         6)Preguntar su tiempo de incubacion");
                Console.Write("Escoja una opcion:   ");
                opc = Convert.ToChar(Console.ReadLine());

           

        }

        public void MostrarSubMenu(ref char opc,ref Animal especie)
        {
            do
            {
                MostrarMenuCategoria(ref opc);
                switch (opc)
                {
                    case '1':
                        especie.DiTuNombre();
                        break;
                    case '2':
                        especie.DiTuEspecie();
                        break;
                    case '3':
                        especie.DiTuGenero();
                        break;
                    case '4':
                        especie.DiTuEdad();
                        break;
                    case '5':
                        especie.DiTutamanio();
                        break;
                    case '6':
                        especie.DiTuTiempoDeIncubacion();
                        break;
                }
                Console.Write("Desea continuar Si=S No=N:   ");
                opc = Convert.ToChar(Console.ReadLine());
            } while (opc == 'S' || opc=='s');
            

           
        }
       
    }
}
