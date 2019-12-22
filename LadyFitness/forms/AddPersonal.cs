using LadyFitness.dbUtils;
using LadyFitness.vo;
using System;
using System.Windows.Forms;

namespace LadyFitness.forms
{
    public partial class AddPersonal : Form
    {
        private DBUtils dbUtils;
        private Client client;
        private Card card;

        public AddPersonal()
        {
            InitializeComponent();
        }

        public AddPersonal(Client client, Card card)
        {
            InitializeComponent();
            this.client = client;
            this.card = card;
            dbUtils = new DBUtils();
            labelName.Text = client.Name;
            labelSecondName.Text = client.SecondName;
            labelSurname.Text = client.Surname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardId = card.Id;
            string name = textBoxTrainName.Text;
            foreach(int weekDayIndex in listBoxWeekDay.SelectedIndices)
            {
                dbUtils.AddPersonal(cardId, comboBoxTrainer.SelectedIndex + 1, comboBoxRoom.SelectedIndex + 1,
                weekDayIndex + 1, textBoxTrainName.Text, dateTimePicker.Value, Convert.ToInt32(textBoxCost.Text),
                Convert.ToInt32(textBoxCount.Text));
            }

            this.Close();
        }
    }
}
