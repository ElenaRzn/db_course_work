using LadyFitness.dbUtils;
using LadyFitness.forms;
using System;
using System.Windows.Forms;

namespace LadyFitness
{
    public partial class Form1 : Form
    {

        private int idClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbUtils = new DBUtils();
            idClient = dbUtils.AddClient(textBoxName.Text, textBoxSurname.Text, textBoxSecondName.Text,
                textBoxPassport.Text, dateTimePicker1.Value);
            buttonAddCard.Visible = true;
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddNewCard(new vo.Client(idClient, textBoxName.Text, textBoxSurname.Text,
                textBoxSecondName.Text, textBoxPassport.Text, dateTimePicker1.Value));
            addCardForm.Show();
            this.Close();

        }
    }
}
