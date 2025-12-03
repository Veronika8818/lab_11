using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int temperature = 0;
    
        public delegate void TempHandler(string msg);

        TempHandler handlerList;

        public Form1()
        {
            InitializeComponent();
            handlerList += ShowTemperatureMessage;
        }

        public void ShowTemperatureMessage(string msg)
        {
            label1.Text += msg + "\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (handlerList != null)
            {
                temperature += 5;

                if (handlerList != null)
                {
                    handlerList("Температура: " + temperature + " °C");

                    if (temperature > 50)
                        handlerList("Критична температура");

                    else if (temperature > 30)
                        handlerList("Попередження: дуже гаряче");
                }
            }
        }
    }
}
