using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::System.Windows.Forms;

namespace Automata_1
{
    public class ClaseDT
    {
        //Procedimiento EJERCICIO 1
        public bool AceptarCadena(string Cad)
        { 
            int Estado = 0;
            char cc;
            int tam = Cad.Length; //tamaño de cadena
            string cadR = "";
            bool sw = false;
            if (Cad == "")
            {
                MessageBox.Show("Ingresar un cadena");
            }
            for (int i = 0;i<tam; i++)
            {
                switch (Estado)
                {
                    case 0:
                        {
                            cc = Cad[i];
                            cadR = cadR + cc;
                            if (cc == 'a')
                            {
                                Estado = 1;
                                sw = true;
                            }
                            else
                            {
                                MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                sw = false;
                                i = tam;
                            }
                        }
                        break;
                    case 1:
                        {
                            cc = Cad[i];
                            cadR = cadR + cc;
                            if (cc == 'a')
                            {
                                Estado = 1;
                                sw = true;
                            }
                            else
                            {
                                if (cc == 'c')
                                {
                                    Estado = 2;
                                    sw = true;
                                }
                                else
                                {
                                    MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                    sw = false;
                                    i = tam;
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            cc = Cad[i];
                            cadR = cadR + cc;
                            if (cc == 'b')
                            {
                                Estado = 2;
                                sw = true;
                            }
                            else
                            {
                                MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                sw = false;
                                i = tam;
                            }
                        }
                        break;
                }
            }
            return (sw);
        }

        //Procedimiento EJERCICIO 2
        public bool AceptarCadena2(string Cad)
        {
            int Estado = 0;
            char cc;
            int tam = Cad.Length; //tamaño de cadena
            string cadR = "";
            bool sw = false;
            if (Cad == "")
            {
                MessageBox.Show("Ingresar un cadena");
            }
            if (tam >= 5)
            {
                for (int i = 0; i <tam; i++)
                {
                    switch (Estado)
                    {
                        case 0:
                            {
                                cc = Cad[i];
                                cadR = cadR + cc;
                                if (cc == '1')
                                {
                                    Estado = 1;
                                    //sw = true;
                                }
                                else
                                {
                                    MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                    sw = false;
                                    i = tam;
                                }
                            }
                            break;
                        case 1:
                            {
                                cc = Cad[i];
                                cadR = cadR + cc;
                                if (cc == '1')
                                {
                                    Estado = 1;
                                    //sw = true;
                                }
                                else
                                {
                                    if (cc == '0')
                                    {
                                        Estado = 2;
                                        //sw = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                        sw = false;
                                        i = tam;
                                    }
                                }
                            }
                            break;
                        case 2:
                            {
                                cc = Cad[i];
                                cadR = cadR + cc;
                                if (cc == '0')
                                {
                                    Estado = 3;
                                    //sw = false;
                                }
                                else
                                {
                                    MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                    sw = false;
                                    i = tam;
                                }
                            }
                            break;
                        case 3:
                            {
                                cc = Cad[i];
                                cadR = cadR + cc;
                                if (cc == '1')
                                {
                                    Estado = 4;
                                    //sw = false;
                                }
                                else
                                {
                                    MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                    sw = false;
                                    i = tam;
                                }
                            }
                            break;
                        case 4:
                            {
                                cc = Cad[i];
                                cadR = cadR + cc;
                                if (cc == '1')
                                {
                                    Estado = 5;
                                    //sw = false;
                                }
                                else
                                {
                                    MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                    sw = false;
                                    i = tam;
                                }
                            }
                            break;
                        case 5:
                            {
                                cc = Cad[i];
                                cadR = cadR + cc;
                                if (cc == '1')
                                {
                                    Estado = 5;
                                    sw = true;
                                }
                                else
                                {
                                    MessageBox.Show("Error Cerca de el Ultimo Caracter: " + cadR);
                                    sw = false;
                                    i = tam;
                                }
                            }
                            break;
                    }
                }
            }
            return (sw);
        }
        //otro mwtodo usando el alfabeto ejercicio 1
        public void dt(string cad)
        {
            int estado = 0;
            char cc = ' ';
            int i = 0;
            while (i < cad.Length)
            {
                cc = cad[i];
                switch (cc)
                {
                    case 'a':
                        if (estado == 0)
                        {
                            estado = 1;
                            break;
                        }
                        else
                        {
                            if (estado == 1)
                            {
                                estado = 1;
                                break;
                            }
                            else
                            {
                                estado = 3;
                                break;
                            }
                        }
                    case 'c':
                        if (estado == 1)
                        {
                            estado = 2;
                            break;
                        }
                        else
                        {
                            estado = 3;
                            break;
                        }
                    case 'b':
                        if (estado == 2)
                        {
                            estado = 2;
                            break;
                        }
                        else
                        {
                            estado = 3;
                            break;
                        }

                    default:
                        MessageBox.Show("Error");
                        break;
                }
                i = i + 1;
            }
            if (estado != 3)
            {
                MessageBox.Show("Cadena aceptada.");
            }
            else
            {
                MessageBox.Show("Cadena NOOOO aceptada.");
            }
        }
        public void dt1(string cad)
        {
            int estado = 0;
            char cc = ' ';
            int i = 0;
            string resp = " ";
            string carR = "";
            while (i <= (cad.Length-1))
            {
                cc = cad[i];
                carR= carR + cc;   
                switch (cc)
                {
                    case '1':
                        if (estado == 0)
                        {
                            estado = 1;
                            resp = "cadena no aceptada";
                            break;
                        }
                        else
                        {
                            if (estado == 1)
                            {
                                estado = 1;
                                resp = "cadena no aceptada";
                                break;
                            }
                            else
                            {
                                if (estado == 3)
                                {
                                    estado = 4;
                                    resp = "cadena no aceptada";
                                    break;
                                }
                                else
                                {
                                    if (estado == 4)
                                    {
                                        estado = 5;
                                        resp = "cadena aceptada";
                                        
                                        break;
                                    }
                                    else
                                    {
                                        if (estado == 5)
                                        {
                                            estado = 5;
                                            resp = "cadena aceptada";
                                            break;
                                        }
                                        else
                                        {
                                            estado = 6;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    case '0':
                        if (estado == 1)
                        {
                            estado = 2;
                            resp = "cadena no aceptada";
                            break;
                        }
                        else
                        {
                            if (estado == 2)
                            {
                                estado = 3;
                                resp = "cadena no aceptada";
                                break;
                            }
                            else
                            {
                                estado = 6;
                                break;
                            }
                        }
                    default:
                        //MessageBox.Show("Error");
                        MessageBox.Show("error en el ultimo caracter: " + carR);
                        resp = "cadena no aceptada";
                        break;
                }
                i = i + 1;
            }
            if (estado != 6)
            {
                MessageBox.Show(resp);            
            }
            else
            {
                MessageBox.Show("Cadena no aceptada.");
            }
        }
        //constructor
        public ClaseDT() 
        {
        }
    }
}
