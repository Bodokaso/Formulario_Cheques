using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Cheques
{
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
            Process p = new Process();
            p.StartInfo.FileName = "PdfGenerator.exe";
            p.StartInfo.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "PdfGenerator_1_0_0_1");
            p.StartInfo.Arguments = $"{txtIdentificacionCliente.Text}";
            p.Start();
           
        }
    }
}
