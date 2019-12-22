using LadyFitness.dbUtils;
using LadyFitness.vo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LadyFitness.forms
{
    public partial class ClientSearch : Form
    {
        private DBUtils dbUtils; 
        public Client ThisClient { get; set; }
        public List<Client> clients { get; set; }

        public ClientSearch()
        {
            InitializeComponent();
            dbUtils = new DBUtils();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxCardNumber.Text))
            {
                // будем искать по номеру карты
                clients = dbUtils.searchClient(textBoxCardNumber.Text);
            }
            if(!string.IsNullOrEmpty(textBoxSurname.Text) || !string.IsNullOrEmpty(textBoxName.Text) || !string.IsNullOrEmpty(textBoxSecondName.Text)) {
                // будем искать по ФИО
                clients = dbUtils.searchClient(textBoxSurname.Text, textBoxName.Text, textBoxSecondName.Text);
            }


            if (clients != null)
            {
                if (clients.Count > 1)
                {
                    var choose = new ChoseClient(this);
                    choose.Show();
                    this.Close();
                    return;
                } 
                else
                {
                    var clientForm = new ClientDetail(clients[0]);
                    clientForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Клиент не найден. Уточните параметры и попробуйте снова.");
            }

        }
    }
}
