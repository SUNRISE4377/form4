using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Database1;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Company", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = bindingSource;
            this.Controls.Add(dataGridView);
        }
    }
}
