using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_simple
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();
        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertar(int valor) //creamos el metodo insertar para poder registrar el dato edad con valor entero
        {
                //creamos un nodo
                Nodo nuevo = new Nodo();
                nuevo.Edad = valor; //edad viene del valor creada en la clase nodo
                if (primero == null)
                {
                    primero = nuevo;
                    ultimo = nuevo;
                    ultimo.Sgte = null;
                }
                else
                {
                    ultimo.Sgte = nuevo;
                    ultimo = nuevo;
                    ultimo.Sgte = null;
                }
        }
        
        public bool VerLista(ListBox lista)
        {
            Nodo actual = new Nodo(); //crea el nodo actual
            actual = primero; //se le asigna el primero
            if (primero != null)
            {
                while (actual != null)
                {
                    lista.Items.Add(actual.Edad);
                    actual = actual.Sgte;
                }
                return true;
            }
            return false;
        }


        //----------------------------------------  SEMANA 2 -------------------------------------------

        public bool Buscar(int valor)
        {
            Nodo actual = new Nodo();
            actual = primero;

            //para que recorra por los datos que le pongas
            while (actual != null)
            {
                if (actual.Edad == valor) //No se puede comparar nodo con nuemeroo valor                
                    return true;
                else actual = actual.Sgte;
            }
            return false;
        }

        public bool Modificar(int dato1, int dato2)//dato1=dato que ya existe, dato2=dato al que quieres modificar
        {
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Edad == dato1)
                {
                    actual.Edad = dato2;
                    return true;
                }
                else actual = actual.Sgte;
            }
            return false;
        }

        public bool Eliminar(int valor)
        {
            Nodo actual = primero;
            Nodo ante = null; //este nodo es para 
            while (actual != null)
            {
                if (actual.Edad == valor)
                {
                    if (actual == primero)
                        primero = primero.Sgte;
                    else if (actual == ultimo)
                    {
                        ante.Sgte = null;
                        ultimo = ante;
                    }
                    else ante.Sgte = actual.Sgte;
                    return true;
                }
                else
                {
                    ante = actual;
                    actual = actual.Sgte;
                }
            }
            return false;
        }

        public void Contar()
        {
            Nodo actual = primero;
            int contador = 0;

            while (actual != null)
            {
                actual = actual.Sgte;
                contador++;
            }
            if (contador > 0)
                MessageBox.Show("La lista tiene " + contador + " edad(es)");
            else
                MessageBox.Show("La lista esta vacia");
        }
    }
}
