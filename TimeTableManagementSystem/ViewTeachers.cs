using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystem
{
    public partial class ViewTeachers : Form
    {
        public ViewTeachers()
        {
            InitializeComponent();
        }

        private void ViewTeachers_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("teacherid", typeof(int));
            tb.Columns.Add("teachername", typeof(String));

            SQLiteDataAdapter sqlDA = CRUD.SubjectsCRUD.viewSubjects();
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "teachers");
            dataGridView1.DataSource = ds.Tables["teachers"].DefaultView;
        }
    }
}
