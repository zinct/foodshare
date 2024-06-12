﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodShareAPI.Requests;
using FoodShareAPI.Controllers;
using Microsoft.VisualBasic.Logging;
using FoodShareCore.API;
using Newtonsoft.Json;
using GUI.Models;
using System.Xml.Linq;
using System.Net;

namespace GUI
{
    public partial class PageLogin : Form
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                String username = (String)textBox1.Text;
                String password = (String)textBox2.Text;

                ClientAPI api = new ClientAPI();
                LoginRequest body = new LoginRequest { Username = username, Password = password };
                HttpResponseMessage responseMassage = await api.PostAsJson("/auth/login", body);

                Console.WriteLine(responseMassage.ToString());  

                if (responseMassage.StatusCode == HttpStatusCode.InternalServerError)
                {

                    MessageBox.Show("Username atau Password salah.");
                    throw new Exception("Terjadi kesalahan ketika melakukan request ke API");

                }
                else if (responseMassage.StatusCode == HttpStatusCode.OK)
                {

                    this.Close();
                    new DashBoard().Show();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
 
        }
    }
}