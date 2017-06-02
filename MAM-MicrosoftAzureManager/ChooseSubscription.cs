using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace MAM_MicrosoftAzureManager
{
    public partial class ChooseSubscription : Form
    {

        Guid SubscriptionID;
        public ChooseSubscription()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void ChooseSubscription_Load(object sender, EventArgs e)
        {
            
            MAMDatabaseTableAdapters.SubscriptionsTableAdapter SubscriptionAdapter = new MAMDatabaseTableAdapters.SubscriptionsTableAdapter();
            comboBox1.DataSource = SubscriptionAdapter.GetExistingSubscriptions();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id";

            dataGridView1.DataSource = SubscriptionAdapter.GetExistingSubscriptions();
            dataGridView1.Refresh();


           // dataGridView1.DataSource = SubscriptionAdapter.GetExistingSubscriptions();
           //dataGridView1.Refresh();

            // Load the List Box



        }


    }
}
