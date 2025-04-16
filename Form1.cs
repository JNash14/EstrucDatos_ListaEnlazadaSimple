using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_simple
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista li = new Lista();  //crear est lista que va ser el intermediario con la lista de la clase lista
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //evita que se llenen campos vacios
            {
                int edad = int.Parse(txtNuevo.Text);
                if (edad >= 0) //Verifica que la edad no puede ser numero negativo
                {
                    if (li.Buscar(edad) == false) //busca el dato almacenado en el listbox y verifica que si repite algun dato
                    {
                        li.insertar(int.Parse(txtNuevo.Text));
                        txtNuevo.Clear();
                        txtNuevo.Focus();                        
                    }
                    else MessageBox.Show("Dato existente");
                }
                else MessageBox.Show("Ingrese edades positivas");
            }
            catch (Exception) { MessageBox.Show("Campo vacio"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            li.VerLista(lstBox);
        }

        //---------------------------------------------------- SEMANA2 -------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
            /*bool rpta = li.Buscar(int.Parse(txtNuevo.Text)); //recuerda que la variable aplicada en la clase Lista es bool, por ende se tiene que crear una variable bool
            if (rpta == true) MessageBox.Show("La edad existe");
            else MessageBox.Show("La edad no existe");*/


            //otro metodo
            try //try catch se utiliza para que no tome en cuenta los campos vacios y te salga un mensaje en su lugar
            {
                if (li.Buscar(int.Parse(txtNuevo.Text))) MessageBox.Show("La edad existe");
                else MessageBox.Show("La edad no existe");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese edad a buscar");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            /*int edad1 = int.Parse(txtNuevo.Text);
            int edad2 = int.Parse(txtModifica.Text);
            if (li.Buscar(edad2) == false) li.Modificar(edad1, edad2);
            else MessageBox.Show("El nuevo dato a modificar ya existe");*/

            try
            {
                //otra forma de hacer
                if (li.Buscar(int.Parse(txtModifica.Text)) == false) li.Modificar(int.Parse(txtNuevo.Text), int.Parse(txtModifica.Text));
                else MessageBox.Show("El nuevo dato a modificar ya existe");
            }
            catch (Exception)
            {
                MessageBox.Show("Campo vacio");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try //tambien se usa para manejar errores
            {
                int edad = int.Parse(txtNuevo.Text);
                if (li.Buscar(int.Parse(txtNuevo.Text)) == true)
                    li.Eliminar(edad);
                else
                    MessageBox.Show("El dato a eliminar no existe");
            }
            catch (Exception)
            {
                MessageBox.Show("Inserte dato para eliminar");
            }

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            try
            {
                li.Contar();
            }
            catch
            {
                MessageBox.Show("La lista esta vacia");
            }
        }
    }
}
