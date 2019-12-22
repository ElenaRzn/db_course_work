using LadyFitness.dbUtils;
using LadyFitness.vo;
using System;
using System.Windows.Forms;

namespace LadyFitness.forms
{
    public partial class ClientDetail : Form
    {

        private Client client;
        private Card card;
        private DBUtils dbUtils;
        
        public ClientDetail()
        {
            InitializeComponent();
        }

        public ClientDetail(Client client)
        {
            InitializeComponent();
            this.client = client;
            dbUtils = new DBUtils();            
            labelFio.Text = client.Surname + " " + client.Name + " " + client.SecondName;
            //RefreshInfo();


        }

        private void RefreshInfo()
        {
            // карты
            card = dbUtils.GetClientCard(client.ID);
            if (card != null)
            {
                labelCardNumber.Text = card.Id.ToString();
                // слазить за типом карты
                labelCardType.Text = card.IdCardType.ToString();
                labelEndDate.Text = Convert.ToDateTime(card.StartDate).AddMonths(card.Months).ToString();

                // персональные тренировки
                var includes = dbUtils.GetInclude(card.Id);
                listBoxPersonal.Items.Clear();
                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        listBoxPersonal.Items.Add(include.RestPersonalCount + "\t" + include.Class + "\t" + include.Trainer);
                    }
                }

            }

            
                        
        }

        private void ClientDetail_Load(object sender, EventArgs e)
        {
            RefreshInfo();
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddNewCard(client);
            addCardForm.Show();
            RefreshInfo();
            Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshInfo();
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addPersonal = new AddPersonal(client, card);
            addPersonal.Show();
        }
    }
}
