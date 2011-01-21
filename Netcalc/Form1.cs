using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**
 * Utility to calculate ip ranges for given subnet mask or bit length
 * Author: Mark Middleton
 */
namespace Netcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validate
            int bit = 0;
            if (int.TryParse(bitTextBox.Text, out bit))
            {
                if (bit < 0 || bit > 32) bit = -1;
            }
       
            if (!isValidIp(ipTextBox.Text) | (bit == -1 && !isValidIp(masktextBox.Text) ) )
            {
                return;
            }

            // extract ip
            int ip = extractip(ipTextBox.Text);
            int mask = (bit==0) ? extractip(masktextBox.Text) : (pow(2,bit)-1) * pow(2,32-bit);

            // convert to hex
            masktextBox.Text = convertToIp(mask);
            networkTextbox.Text = convertToIp(ip & mask);
            ipFromTextbox.Text = convertToIp( (ip & mask) + 1 );
            ipToTextBox.Text = convertToIp( (ip & mask) + (~mask) );
        }

        private int pow(int n, int p)
        {
            int t = n;
            for (int i = 1; i < p; i++)
            {
                t = t * n;
            }
            return t;
        }

        private string convertToIp(int h)
        {
            return ((h & 0xFF000000) >> 24) + "." + ((h & 0x00FF0000) >> 16) + "." + ((h & 0x0000FF00) >> 8) + "." + (h & 0x000000FF); ;
        }

        private bool isValidIp(string s)
        {
            try
            {
                extractip(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private int extractip(String s)
        {
            int h = 0;
            string [] v = s.Split('.');
            foreach (string t in v)
            {
                if (Convert.ToInt32(t) > 255)
                {
                    throw new FormatException();
                }
                h = (h << 8) + Convert.ToInt32(t);
            }
            return h;
        }
    }
}
