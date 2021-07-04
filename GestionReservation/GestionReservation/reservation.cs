using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;
using System.Windows.Forms;

namespace GestionReservation
{

    
    public partial class reservation : Form
    {
        DCDataContext dc = new DCDataContext();
        public reservation()
        {
            InitializeComponent();
        }

        private void ucHotel1_Load(object sender, EventArgs e)
        {

        }
    }
}
