using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListaPaises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkedListBox2.Items.Add(checkedListBox1.SelectedItem);
                int i = checkedListBox1.SelectedIndex;
                checkedListBox1.Items.RemoveAt(i);
            }catch { MessageBox.Show("Revisa la acción"); }
        }

        private void butIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                checkedListBox1.Items.Add(checkedListBox2.SelectedItem);
                int i = checkedListBox2.SelectedIndex;
                checkedListBox2.Items.RemoveAt(i);
            }catch { MessageBox.Show("Revisa la acción"); }
        }

        private void butCambio_Click(object sender, EventArgs e)
        {

            //checkedListBox1.SelectedItem = textEditar.Text.ToString() ;
            
        }

        private void textEditar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
