
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
    public partial class ucRoom : UserControl
    {

        DCDataContext dc = new DCDataContext();
        
        public int Num { get; set; }
        public void ShowStatus(DateTime dateRes) {


           var Liste = (from a in dc.Reservation select a).ToList();

            foreach (Reservation res in Liste)
            {
                if(res.RoomNum == this.Num && ((DateTime)res.DateRes).Date == dateRes.Date )
                {
                    this.BackColor = Color.Red;
                    return;
                }
            }
            this.BackColor = Color.Yellow;
        }
        public ucRoom()
        {
            InitializeComponent();
           
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
         lbNum.Text = Num.ToString();
           
        }

        private void réserverMenuItem_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();

            res.RoomNum = this.Num;
            res.DateRes = ucHotel.date;
            dc.Reservation.InsertOnSubmit(res);
            dc.SubmitChanges();
            this.ShowStatus(ucHotel.date);

        }

        private void libérerMenuItem_Click(object sender, EventArgs e)

        {

            var Liste = (from a in dc.Reservation select a).ToList();

            foreach (Reservation res in Liste)
            {
                if (res.RoomNum == this.Num && ((DateTime)res.DateRes).Date == ucHotel.date.Date)
                {
                    dc.Reservation.DeleteOnSubmit(res);
                    dc.SubmitChanges();
                }
            }

            this.ShowStatus(ucHotel.date);
        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
