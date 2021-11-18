using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_POO2_UNED_RonnyGamboa
{
    public partial class FrmPrincipal : Form
    {
        private int n = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se agregran filas al DataGridView
            int row = dtgAgenda.Rows.Add();
            n = row;

            //Se agrega cada valor ingresado al DataGridView
            dtgAgenda.Rows[row].Cells[0].Value = txtNombre.Text;
            dtgAgenda.Rows[row].Cells[1].Value = txtTel.Text;
            dtgAgenda.Rows[row].Cells[2].Value = txtCel.Text;
            dtgAgenda.Rows[row].Cells[3].Value = txtEmail.Text;

            //Se limpian los textbox
            txtCel.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            {
                try
                {
                    dtgAgenda.Rows.RemoveAt(n);
                }
                catch (Exception) //bloque catch para captura de error
                {
                    string mensaje = "Se produjo un error , no se pudo borrar la fila";
                    MessageBox.Show(mensaje);
                }

            }
        }

     

        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtgAgenda.Columns[0].Width = 300;
            dtgAgenda.Columns[1].Width = 100;
            dtgAgenda.Columns[2].Width = 100;
            dtgAgenda.Columns[3].Width = 200;
        }

        private void dtgAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lblinfo.Text = "Info CellClick: " + (string)dtgAgenda.Rows[n].Cells[1].Value;
            }
        }

    }
}
