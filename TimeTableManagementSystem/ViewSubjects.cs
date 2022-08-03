using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagementSystem.Models;
using TimeTableManagementSystem.CRUD;
using System.Data.SQLite;

namespace TimeTableManagementSystem
{
    public partial class ViewSubjects : Form
    {
        public ViewSubjects()
        {
            InitializeComponent();
        }

        private void ViewSubjects_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("subjectid", typeof(int));
            tb.Columns.Add("subjectname", typeof(String));

            SQLiteDataAdapter sqlDA = CRUD.SubjectsCRUD.viewSubjects();
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "subjects");
            dataGridView1.DataSource = ds.Tables["subjects"].DefaultView;
        }
    }
}
