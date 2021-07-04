
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservation.UC
{
    public partial class ucHotel : UserControl
    {
     
        public static DateTime date { get; set; } 

        public ucHotel()
        {
            InitializeComponent();
         
            
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)

        {

            date = dtPicker.Value;
            foreach (Control item in this.Controls)
            {
                if (item is ucRoom)
                {
                    ucRoom room = (ucRoom)item;
                    room.ShowStatus(dtPicker.Value);
                }

            }
        }

        private void ucRoom2_Load(object sender, EventArgs e)
        {

        }

        private void ucRoom7_Load(object sender, EventArgs e)
        {

        }

        private void ucRoom6_Load(object sender, EventArgs e)
        {

        }
    }
}
