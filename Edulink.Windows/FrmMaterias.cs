using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmMaterias : Form
    {
        private int _carreraId;
        public FrmMaterias(int carreraId)
        {
            InitializeComponent();
            _carreraId = carreraId;
        }
    }
}
