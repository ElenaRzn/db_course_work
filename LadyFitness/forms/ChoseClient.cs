using System;
using System.Windows.Forms;

namespace LadyFitness.forms
{
    public partial class ChoseClient : Form
    {
        ClientSearch search;
        public ChoseClient(ClientSearch search)
        {
            this.search = search;
            InitializeComponent();
            foreach (var item in search.clients)
            {
                listBoxClients.Items.Add(item.ToString());
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(listBoxClients.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите клиента из списка.");
                return;
            }
            string surname = listBoxClients.SelectedItem.ToString();

            var clientInfo = surname.Split(' ');
            
            var client = new vo.Client(Convert.ToInt32(clientInfo[0]), clientInfo[1], clientInfo[2], clientInfo[3], 
                clientInfo[4], Convert.ToDateTime(clientInfo[5]));

            var clientForm = new ClientDetail(client);
            clientForm.Show();
            this.Close();
        }
    }
}
