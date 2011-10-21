using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace HostQuanLyDanhBa
{
    public partial class HostQuanLyDanhBa : Form
    {
        ServiceHost host;
        public HostQuanLyDanhBa()
        {
            InitializeComponent();
            Type instanceType = typeof(ServiceLibrary.ServiceQuanLyDanhBa);
            Uri baseAddress = new Uri(txtBaseLocation.Text);
            host = new ServiceHost(instanceType, baseAddress);
            cbbEndPoints.Items.Add("BasicHttpBinding");
            cbbEndPoints.Items.Add("WSHttpBinding");
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Uri baseAddress = new Uri("http://localhost:8080/QuanLyDanhBa");
            //Uri baseAddress = new Uri(txtBaseLocation.Text);
            
            //Type instanceType = typeof(ServiceLibrary.ServiceQuanLyDanhBa);


            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            if (chkbShowMEX.Checked == true)
                smb.HttpGetEnabled = true;
            else smb.HttpGetEnabled = false;

            using (this.host)
            {
                
                Type contractType = typeof(ServiceLibrary.IQuanLyDanhBa);

                string relativeAddress = txtLocation.Text;//"QuanLyDanhBa";
                
                if (cbbEndPoints.SelectedIndex == 0)
                {
                    host.AddServiceEndpoint(contractType, new BasicHttpBinding(), relativeAddress);
                    //MessageBox.Show("0");
                }
                else if (cbbEndPoints.SelectedIndex == 1)
                host.AddServiceEndpoint(contractType, new WSHttpBinding(), relativeAddress);
                
                host.Open();
                MessageBox.Show("Server is hosting");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            host.Close();
            MessageBox.Show("Server is stopped");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("app.config is saved");
        }



    }
}
