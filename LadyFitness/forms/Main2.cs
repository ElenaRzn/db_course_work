using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadyFitness.forms
{
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitness2DataSet11.SelectTimetable". При необходимости она может быть перемещена или удалена.
            this.selectTimetableTableAdapter.Fill(this.fitness2DataSet11.SelectTimetable);

        }
    }
}
