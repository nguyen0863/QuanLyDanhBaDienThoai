using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace ClientQuanLyDanhBa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Banking_Library.IService1 proxy = new Banking_Library.Service1();
            EndpointAddress adddress = new EndpointAddress("http://localhost:8080/QuanLyDanhBa/QuanLyDanhBa");
            WSHttpBinding binding = new WSHttpBinding();
 
            ServiceLibrary.IQuanLyDanhBa proxy;
            proxy = ChannelFactory<ServiceLibrary.IQuanLyDanhBa>.CreateChannel(binding, adddress);
            // = new ServiceLibrary.ServiceQuanLyDanhBa();
            //IServiceBank proxy = new ServiceBankClient();
            textBox1.Text = proxy.GetAuthor();
            
            
            //*/
            //Dung ChannelFactory cho phep tao nhieu doi tuong proxy voi cac endpoint khac nhau
            //EndpointAddress address = new EndpointAddress("http://localhost:8000/BankService");
            //BasicHttpBinding binding = new BasicHttpBinding();
            //Banking_Library.IService1 proxy = ChannelFactory<Banking_Library.IService1>.CreateChannel(binding, address);
            //txtResult.Text = proxy.GetBalance("aaa").ToString();
            //IBankService proxy = ChannelFactory<IBankService>.CreateChannel(binding,  address);
            //decimal balance = proxy.GetBalance("ABC123");

            //Dung ChannelFactory cho phep tao nhieu doi tuong proxy voi cac endpoint khac nhau
            //EndpointAddress address1 = new EndpointAddress("http://localhost:8000/BankService1");
            //WSHttpBinding binding1 = new WSHttpBinding();
            //IBankService proxy1 = ChannelFactory<IBankService>.CreateChannel(binding1, address1);
            //decimal balance1 = proxy1.GetBalance("ABC123");


            //label1.Text = Convert.ToString(balance) + " and "  +  Convert.ToString(balance1);
        }
    }
}
