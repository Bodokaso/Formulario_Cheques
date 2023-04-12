using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using System.IO;
using Formulario_Cheques.Context;
using Formulario_Cheques.Context.Models;
using System.Diagnostics;

namespace Formulario_Cheques
{
    public partial class Form1 : Form
    {
        private ChequeContext _context;
        public Form1()
        {
            _context = new ChequeContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chequeData = new Cheque()
            {
                ConceptoPago = txtConceptoPago.Text,
                FechaPago = dpFechaPago.Value,
                Monto = Convert.ToDouble(txtMontoNum.Text),
                MontoLetra = txtMontoLetras.Text,
                NombreCliente = txtNombreCliente.Text,
                IdentificacionCliente = txtIdentificacionCliente.Text
            };

            _context.Add(chequeData);
            _context.SaveChanges(); 
        
        
            foreach (Control txt in panel3.Controls)
                {
                    if (txt is TextBox)
                        ((TextBox)txt).Clear();
                }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // abrir form consulta
            ConsultaForm consultaForm = new ConsultaForm();
            consultaForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
