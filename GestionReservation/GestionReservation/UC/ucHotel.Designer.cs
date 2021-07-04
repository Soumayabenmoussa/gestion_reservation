
namespace GestionReservation.UC
{
    partial class ucHotel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.ucRoom9 = new GestionReservation.UC.ucRoom();
            this.ucRoom6 = new GestionReservation.UC.ucRoom();
            this.ucRoom2 = new GestionReservation.UC.ucRoom();
            this.ucRoom8 = new GestionReservation.UC.ucRoom();
            this.ucRoom7 = new GestionReservation.UC.ucRoom();
            this.ucRoom4 = new GestionReservation.UC.ucRoom();
            this.ucRoom3 = new GestionReservation.UC.ucRoom();
            this.ucRoom1 = new GestionReservation.UC.ucRoom();
            this.ucRoom5 = new GestionReservation.UC.ucRoom();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date de réservation :";
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(183, 195);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(246, 24);
            this.dtPicker.TabIndex = 4;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // ucRoom9
            // 
            this.ucRoom9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom9.Location = new System.Drawing.Point(356, 8);
            this.ucRoom9.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom9.Name = "ucRoom9";
            this.ucRoom9.Num = 9;
            this.ucRoom9.Size = new System.Drawing.Size(171, 55);
            this.ucRoom9.TabIndex = 2;
            // 
            // ucRoom6
            // 
            this.ucRoom6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom6.Location = new System.Drawing.Point(356, 66);
            this.ucRoom6.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom6.Name = "ucRoom6";
            this.ucRoom6.Num = 6;
            this.ucRoom6.Size = new System.Drawing.Size(171, 55);
            this.ucRoom6.TabIndex = 2;
            this.ucRoom6.Load += new System.EventHandler(this.ucRoom6_Load);
            // 
            // ucRoom2
            // 
            this.ucRoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom2.Location = new System.Drawing.Point(356, 124);
            this.ucRoom2.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom2.Name = "ucRoom2";
            this.ucRoom2.Num = 3;
            this.ucRoom2.Size = new System.Drawing.Size(171, 55);
            this.ucRoom2.TabIndex = 2;
            this.ucRoom2.Load += new System.EventHandler(this.ucRoom2_Load);
            // 
            // ucRoom8
            // 
            this.ucRoom8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom8.Location = new System.Drawing.Point(182, 8);
            this.ucRoom8.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom8.Name = "ucRoom8";
            this.ucRoom8.Num = 8;
            this.ucRoom8.Size = new System.Drawing.Size(171, 55);
            this.ucRoom8.TabIndex = 2;
            // 
            // ucRoom7
            // 
            this.ucRoom7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom7.Location = new System.Drawing.Point(8, 8);
            this.ucRoom7.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom7.Name = "ucRoom7";
            this.ucRoom7.Num = 7;
            this.ucRoom7.Size = new System.Drawing.Size(171, 55);
            this.ucRoom7.TabIndex = 2;
            this.ucRoom7.Load += new System.EventHandler(this.ucRoom7_Load);
            // 
            // ucRoom4
            // 
            this.ucRoom4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom4.Location = new System.Drawing.Point(182, 66);
            this.ucRoom4.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom4.Name = "ucRoom4";
            this.ucRoom4.Num = 5;
            this.ucRoom4.Size = new System.Drawing.Size(171, 55);
            this.ucRoom4.TabIndex = 2;
            // 
            // ucRoom3
            // 
            this.ucRoom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom3.Location = new System.Drawing.Point(8, 66);
            this.ucRoom3.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom3.Name = "ucRoom3";
            this.ucRoom3.Num = 4;
            this.ucRoom3.Size = new System.Drawing.Size(171, 55);
            this.ucRoom3.TabIndex = 2;
            // 
            // ucRoom1
            // 
            this.ucRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom1.Location = new System.Drawing.Point(182, 124);
            this.ucRoom1.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom1.Name = "ucRoom1";
            this.ucRoom1.Num = 2;
            this.ucRoom1.Size = new System.Drawing.Size(171, 55);
            this.ucRoom1.TabIndex = 2;
            // 
            // ucRoom5
            // 
            this.ucRoom5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucRoom5.Location = new System.Drawing.Point(8, 124);
            this.ucRoom5.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom5.Name = "ucRoom5";
            this.ucRoom5.Num = 1;
            this.ucRoom5.Size = new System.Drawing.Size(171, 55);
            this.ucRoom5.TabIndex = 2;
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucRoom9);
            this.Controls.Add(this.ucRoom6);
            this.Controls.Add(this.ucRoom2);
            this.Controls.Add(this.ucRoom8);
            this.Controls.Add(this.ucRoom7);
            this.Controls.Add(this.ucRoom4);
            this.Controls.Add(this.ucRoom3);
            this.Controls.Add(this.ucRoom1);
            this.Controls.Add(this.ucRoom5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(538, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucRoom ucRoom5;
        private ucRoom ucRoom1;
        private ucRoom ucRoom2;
        private ucRoom ucRoom3;
        private ucRoom ucRoom4;
        private ucRoom ucRoom6;
        private ucRoom ucRoom7;
        private ucRoom ucRoom8;
        private ucRoom ucRoom9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}
