using System.Data;

namespace PSIA4___testing
{
    public partial class Form1 : Form
    {
        private DataTable gridEmpleados;
        public bool fTipo = true;
        public string tipo = "Planta";
        public Form1()
        {
            InitializeComponent();
            gridEmpleados = new DataTable();
            gridEmpleados.Columns.Add("Nombre");
            gridEmpleados.Columns.Add("Identificacion");
            gridEmpleados.Columns.Add("Antiguedad");
            gridEmpleados.Columns.Add("Vinculacion");
      
            dataGridView1.DataSource = gridEmpleados;

            //textBox1.Text = String.Format("{0:000}", 2);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

    
            
       
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "000")
            {
                txtCodigo.Text = "";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!(txtCodigo.Text == ""))
            {
                txtCodigo.Text = txtCodigo.Text.ToString().PadLeft(3, '0');

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(txtCodigo.Text == ""))
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtCodigo.Text = txtCodigo.Text.ToString().PadLeft(3, '0');
                }
            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboTipo.SelectedIndex == 0)
            {
                tipo = "Planta";
                fTipo = true;
            }
            else if (comboTipo.SelectedIndex == 1)
            {
                tipo = "Termino fijo";
                fTipo = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados EmpleadoN = new Empleados(txtNombre.Text, txtCodigo.Text, (Int32)nmrEdad.Value, fTipo);



            this.gridEmpleados.Rows.Add(EmpleadoN.emp_nombre, EmpleadoN.emp_identificacion, EmpleadoN.emp_edad, tipo);
            //dGridVisitantes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }
    }
}