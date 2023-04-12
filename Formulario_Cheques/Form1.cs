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

namespace Formulario_Cheques
{
    public partial class Form1 : Form
    {

        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;
        public Form1()
        {
            InitializeComponent();
            upLoadData();
        }

        private void SetConnectDB()
        {
            //"Data Source = C:\\Users\\bodok\\source\\repos\\Formulario_Cheques\\Formulario_Cheques\\bin\\Debug\\cheques_db.db"
            string path = Path.Combine($"Data Source ={Environment.CurrentDirectory}", "cheques_db.db");
            sqlConn = new SQLiteConnection(path);
        }

        private void ExecuteQquery(string QueryData)
        {
            SetConnectDB();
            sqlConn.Open();
            sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = QueryData;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            sqlConn.Close();

        }

        private void upLoadData()
        {
            SetConnectDB();
            sqlConn.Open();
            sqlCmd = sqlConn.CreateCommand();
            string CommandText = "Select * from cheque";
            DB = new SQLiteDataAdapter(CommandText, sqlConn);
            DS.Reset();
            DB.Fill(DS);
            sqlConn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string QueryData = "insert or ignore into cheque(num_cheque, concepto_pago, id_cliente, monto_num, monto_letras, factura_pagada, fecha_pago)" +
                "values ('" + txtNumCheque.Text + "','" + txtConceptoPago.Text + "','" + txtIdCliente.Text + "','" + txtMontoNum.Text + "','" + txtMontoLetras.Text + "','" + txtFacturaPagada.Text + "','" + dateTimePicker1.Text + "')";
            ExecuteQquery(QueryData);
            upLoadData();
        
        
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
    }
}
