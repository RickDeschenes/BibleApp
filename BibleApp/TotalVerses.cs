using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherBibleApp
{
    public partial class TotalVerses : Form
    {
        public TotalVerses()
        {
            InitializeComponent();
        }

        private void TotalVerses_Load(object sender, EventArgs e)
        {
            BibleDetails bd = new BibleDetails();
        }
    }
}
