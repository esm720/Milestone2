﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Milestone_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //CREATED BY ENRIQUE SANCHEZMURILLO CST150 ON 23 JAN 2022
        class InvetoryItem //created for inventory items
        {
            public string name;
            public string description;
            public decimal price;
            public int quantity;

        }

        public void XboxItem()//item is created and sent to display method for testing
        {
            InvetoryItem xbox = new InvetoryItem();
            xbox.name = "Xbox";
            xbox.description = "Game Console";
            xbox.price = 400.00m;
            xbox.quantity = 6;

            ViewXboxInvetory(xbox);
        }


        private void ViewXboxInvetory(InvetoryItem item)// testing method
        {
            MessageBox.Show(item.name + "\n" + item.description +
                "\n" + "$" + item.price + " \n" + item.quantity);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XboxItem();
        }
    }
}
