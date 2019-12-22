using LadyFitness.dbUtils;
using LadyFitness.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadyFitness
{
    public partial class AddNewCard : Form
    {
        private DBUtils dbUtils;
        private Client client;

        public AddNewCard()
        {
            InitializeComponent();
        }

        public AddNewCard(Client client)
        {
            InitializeComponent();
            this.client = client;
            dbUtils = new DBUtils();
            labelName.Text = client.Name;
            labelSecondName.Text = client.SecondName;
            labelSurname.Text = client.Surname;
        }

        /// <summary>
        ///Сохранить в БД карту по конкретному клиенту. Брать данные из формы - плохо? 
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            var cardType = comboBoxCardType.SelectedIndex + 1;
            var begin = monthCalendarStart.SelectionStart;
            int months = (int)numericUpDownStart.Value;
            dbUtils.AddCard(client.ID, cardType, begin, months);
            var clientDetail = new forms.ClientDetail(client);
            clientDetail.Show();
            this.Close();
        }

    }
}
