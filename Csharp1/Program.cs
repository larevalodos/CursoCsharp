using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    static class Program
    {
        /*
         *  Luis A. Testing Csharp tutorial 
         */
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            /*
            //Variables y tipos de datos
            string name = "Luis";
            DateTime fechaHoy = DateTime.Today;
            MessageBox.Show("Hola! "+ name + " Hoy es: " + fechaHoy.Date.ToString());
            //Vectores - Arreglos
            int[] numeros = new int[5];
            //matrices
            int[,] matiznumeros = new int[5,2];
            //arraylist (tipo de arreglo deprecado)
            ArrayList lista = new ArrayList();
            lista.Add("hola");
            lista.Add(1);
            foreach (var item in lista)
            {
                MessageBox.Show(item.ToString());
            }
            //LIST (nueva estructura)
            List<int> Lista2 = new List<int>();
            Lista2.Add(3);
            Lista2.Add(5);

            foreach (var item in Lista2)
            {
                MessageBox.Show(item.ToString());
            }
            //

            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

    }
    }
}
