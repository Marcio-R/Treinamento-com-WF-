using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroWF
{
    public partial class Frm_Veiculos : Form
    {
        public Frm_Veiculos(string v)
        {
            InitializeComponent();

            tb_listaCar.Text = v;
        }
    }
}
