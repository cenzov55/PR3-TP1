using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormEjercicio1 : Form
    {
        Form menuPrincipal;
        public FormEjercicio1(Form menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
        }

        private void FormEjercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.menuPrincipal.Show();
        }
    }
}
