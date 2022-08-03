using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystem.CRUD;
using System.Data.SQLite;
namespace TimeTableManagementSystem
{
    public partial class ViewClasses : Form
    {
        public ViewClasses()
        {
            InitializeComponent();

        }

        private void ViewClasses_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("ClassID", typeof(int));
            tb.Columns.Add("classname", typeof(String));

            SQLiteDataAdapter sqlDA = CRUD.SubjectsCRUD.viewSubjects();
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "classes");
            dataGridView1.DataSource = ds.Tables["classes"].DefaultView;


        }
    }
}
