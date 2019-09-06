using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
        }

        
    }
}
