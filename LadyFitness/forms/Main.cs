using LadyFitness.dbUtils;
using LadyFitness.forms;
using LadyFitness.vo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LadyFitness
{
    public partial class Main : Form
    {
        private DBUtils dbUtils;
        public Main()
        {
            InitializeComponent();
            dbUtils = new DBUtils();
            List<Timetable> timeTibles = dbUtils.GetTimetable(0);

            foreach(var item in timeTibles)
            {
                string[] strings = new string[] { item.WeekDay.ToString(), item.Train, item.Trainer, item.Room, item.Time.ToString("HH:mm") };
                var listViewItem = new ListViewItem(strings);
                listViewTimetable.Items.Add(listViewItem);
            }
        }

        private void найтиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formSearch = new ClientSearch();
            formSearch.Show();
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            найтиToolStripMenuItem2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addClient = new Form1();
            addClient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
