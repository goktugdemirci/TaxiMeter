using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace TaxiMeter
{
    public partial class TaxiTimer : Form
    {
        DataModel dm = new DataModel();
        int counter1 = 0; int counter2 = 0; int counter3 = 0; int counter4 = 0; int counter5 = 0; int counter6 = 0; int counter7 = 0;
        double time1 = 0; double time2 = 0; double time3 = 0; double time4 = 0; double time5 = 0; double time6 = 0; double time7 = 0;
        Session S1 = new Session(); Session S2 = new Session(); Session S3 = new Session(); Session S4 = new Session(); Session S5 = new Session(); Session S6 = new Session(); Session S7 = new Session();
        Total To1 = new Total(); Total To2 = new Total(); Total To3 = new Total(); Total To4 = new Total(); Total To5 = new Total(); Total To6 = new Total(); Total To7 = new Total();
        public TaxiTimer()
        {
            InitializeComponent();
            T1.Interval = T2.Interval = T3.Interval = T4.Interval = T5.Interval = T6.Interval = T7.Interval = 1000;
        }

        private void btn_allreset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("All data will be reset, you sure ?", "All Reset", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                #region [ALL RESET]
                dm.AddChar_To(S1);dgv_analyse.DataSource = dm.ListChar_To();
                dm.AddChar_To(S2); dgv_analyse.DataSource = dm.ListChar_To();
                dm.AddChar_To(S3); dgv_analyse.DataSource = dm.ListChar_To();
                dm.AddChar_To(S4); dgv_analyse.DataSource = dm.ListChar_To();
                dm.AddChar_To(S5); dgv_analyse.DataSource = dm.ListChar_To();
                dm.AddChar_To(S6); dgv_analyse.DataSource = dm.ListChar_To();
                dm.AddChar_To(S7); dgv_analyse.DataSource = dm.ListChar_To();
                btn_30dk1.UseVisualStyleBackColor = btn_1sa1.UseVisualStyleBackColor = btn_30dk2.UseVisualStyleBackColor = btn_1sa2.UseVisualStyleBackColor = btn_30dk3.UseVisualStyleBackColor = btn_1sa3.UseVisualStyleBackColor = btn_30dk4.UseVisualStyleBackColor = btn_1sa4.UseVisualStyleBackColor = btn_30dk5.UseVisualStyleBackColor = btn_1sa5.UseVisualStyleBackColor = btn_30dk6.UseVisualStyleBackColor = btn_1sa6.UseVisualStyleBackColor = btn_30dk7.UseVisualStyleBackColor = btn_1sa7.UseVisualStyleBackColor = true;
                S1.ID = 0; S1.Name = ""; S1.Donation = 0; S1.Duration = 0; S1.TaxiDate = DateTime.MinValue;
                S2.ID = 0; S2.Name = ""; S2.Donation = 0; S2.Duration = 0; S2.TaxiDate = DateTime.MinValue;
                S3.ID = 0; S3.Name = ""; S3.Donation = 0; S3.Duration = 0; S3.TaxiDate = DateTime.MinValue;
                S4.ID = 0; S4.Name = ""; S4.Donation = 0; S4.Duration = 0; S4.TaxiDate = DateTime.MinValue;
                S5.ID = 0; S5.Name = ""; S5.Donation = 0; S5.Duration = 0; S5.TaxiDate = DateTime.MinValue;
                S6.ID = 0; S6.Name = ""; S6.Donation = 0; S6.Duration = 0; S6.TaxiDate = DateTime.MinValue;
                S7.ID = 0; S7.Name = ""; S7.Donation = 0; S7.Duration = 0; S7.TaxiDate = DateTime.MinValue;
                if (btn_start1.Text == "Pause") { btn_start1.Text = "Start"; btn_start1.BackColor = Color.YellowGreen; }
                if (btn_start2.Text == "Pause") { btn_start2.Text = "Start"; btn_start2.BackColor = Color.YellowGreen; }
                if (btn_start3.Text == "Pause") { btn_start3.Text = "Start"; btn_start3.BackColor = Color.YellowGreen; }
                if (btn_start4.Text == "Pause") { btn_start4.Text = "Start"; btn_start4.BackColor = Color.YellowGreen; }
                if (btn_start5.Text == "Pause") { btn_start5.Text = "Start"; btn_start5.BackColor = Color.YellowGreen; }
                if (btn_start6.Text == "Pause") { btn_start6.Text = "Start"; btn_start6.BackColor = Color.YellowGreen; }
                if (btn_start7.Text == "Pause") { btn_start7.Text = "Start"; btn_start7.BackColor = Color.YellowGreen; }
                counter1 = 0; counter2 = 0; counter3 = 0; counter4 = 0; counter5 = 0; counter6 = 0; counter7 = 0;
                time1 = 0; time2 = 0; time3 = 0; time4 = 0; time5 = 0; time6 = 0; time7 = 0;
                lbl_id1.Text = lbl_id2.Text = lbl_id3.Text = lbl_id4.Text = lbl_id5.Text = lbl_id6.Text = lbl_id7.Text = "null";
                T1.Stop(); T2.Stop(); T3.Stop(); T4.Stop(); T5.Stop(); T6.Stop(); T7.Stop();
                tb_char1.Text = tb_sure1.Text = tb_pay1.Text = tb_char2.Text = tb_sure2.Text = tb_pay2.Text = tb_char3.Text = tb_sure3.Text = tb_pay3.Text = tb_char4.Text = tb_sure4.Text = tb_pay4.Text = tb_char5.Text = tb_sure5.Text = tb_pay5.Text = tb_char6.Text = tb_sure6.Text = tb_pay6.Text = tb_char7.Text = tb_sure7.Text = tb_pay7.Text = "";
                lbl_saat1.Text = lbl_dakika1.Text = lbl_saniye1.Text = lbl_saat2.Text = lbl_dakika2.Text = lbl_saniye2.Text = lbl_saat3.Text = lbl_dakika3.Text = lbl_saniye3.Text = lbl_saat4.Text = lbl_dakika4.Text = lbl_saniye4.Text = lbl_saat5.Text = lbl_dakika5.Text = lbl_saniye5.Text = lbl_saat6.Text = lbl_dakika6.Text = lbl_saniye6.Text = lbl_saat7.Text = lbl_dakika7.Text = lbl_saniye7.Text = "00";
                lbl_paid1.Text = lbl_paid2.Text = lbl_paid3.Text = lbl_paid4.Text = lbl_paid5.Text = lbl_paid6.Text = lbl_paid7.Text = "Insert PpH";
                tb_char1.Enabled = tb_sure1.Enabled = tb_pay1.Enabled = btn_timeok1.Enabled = true;
                btn_30dk1.Enabled = btn_1sa1.Enabled = btn_start1.Enabled = btn_reset1.Enabled = btn_30dk2.Enabled = btn_1sa2.Enabled = btn_start2.Enabled = btn_reset2.Enabled = btn_30dk3.Enabled = btn_1sa3.Enabled = btn_start3.Enabled = btn_reset3.Enabled = btn_30dk4.Enabled = btn_1sa4.Enabled = btn_start4.Enabled = btn_reset4.Enabled = btn_30dk5.Enabled = btn_1sa5.Enabled = btn_start5.Enabled = btn_reset5.Enabled = btn_30dk6.Enabled = btn_1sa6.Enabled = btn_start6.Enabled = btn_reset6.Enabled = btn_30dk7.Enabled = btn_1sa7.Enabled = btn_start7.Enabled = btn_reset7.Enabled = false;
                tb_char2.Enabled = tb_sure2.Enabled = tb_pay2.Enabled = tb_char3.Enabled = tb_sure3.Enabled = tb_pay3.Enabled = tb_char4.Enabled = tb_sure4.Enabled = tb_pay4.Enabled = tb_char5.Enabled = tb_sure5.Enabled = tb_pay5.Enabled = tb_char6.Enabled = tb_sure6.Enabled = tb_pay6.Enabled = tb_char7.Enabled = tb_sure7.Enabled = tb_pay7.Enabled = btn_timeok2.Enabled = btn_timeok3.Enabled = btn_timeok4.Enabled = btn_timeok5.Enabled = btn_timeok6.Enabled = btn_timeok7.Enabled = true;
                #endregion
            }
        }

        #region Party Member 1

        private void btn_timeok1_Click(object sender, EventArgs e)
        {
            if (tb_char1.Text != "" && tb_sure1.Text != "" && tb_pay1.Text != "")
            {
                btn_start1.Enabled = btn_reset1.Enabled = true;
                btn_timeok1.Enabled = tb_char1.Enabled = tb_sure1.Enabled = tb_pay1.Enabled = false;
                counter1 = Convert.ToInt32(tb_sure1.Text) * 60;
                time1 = Convert.ToDouble(tb_sure1.Text) * 60;
                lbl_saat1.Text = (counter1 / 3600).ToString();
                lbl_dakika1.Text = ((counter1 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay1.Text) / 60;
                lbl_paid1.Text = (priceperminute * (time1 / 60)).ToString() + "M Gold";
                S1.TaxiDate = DateTime.Now;
                S1.Name = tb_char1.Text; 
                S1.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time1) / 60));
                S1.Duration = Convert.ToInt32(tb_sure1.Text);
                dm.AddChar_Se(S1);
                S1.ID = dm.GetID(S1.TaxiDate);
                lbl_id1.Text = S1.ID.ToString();
            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk1_Click(object sender, EventArgs e)
        {
            S1.Duration += 30;
            S1.Donation += Convert.ToDecimal(tb_pay1.Text) / 2;
            if (dm.UpdateParam(S1.Duration, S1.Donation, S1.ID))
            {
                btn_30dk1.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk1.BackColor = Color.IndianRed;
            }
            counter1 = counter1 + 1800;
            time1 = time1 + 1800;
            double priceperminute = Convert.ToDouble(tb_pay1.Text) / 60;
            lbl_paid1.Text = (priceperminute * (time1 / 60)).ToString() + " " + "M Gold";
        }

        private void btn_1sa1_Click(object sender, EventArgs e)
        {
            S1.Duration += 60;
            S1.Donation += Convert.ToDecimal(tb_pay1.Text);
            if (dm.UpdateParam(S1.Duration, S1.Donation, S1.ID))
            {
                btn_1sa1.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa1.BackColor = Color.IndianRed;
            }
            counter1 = counter1 + 3600;
            time1 = time1 + 3600;
            double priceperminute = Convert.ToDouble(tb_pay1.Text) / 60;
            lbl_paid1.Text = (priceperminute * (time1 / 60)).ToString() + "M Gold";
        }

        private void btn_start1_Click(object sender, EventArgs e)
        {
            if (btn_start1.Text == "Start")
            {
                T1.Start();
                btn_start1.Text = "Pause";
                btn_start1.BackColor = Color.Orange;
                btn_1sa1.Enabled = btn_30dk1.Enabled = true;
            }
            else
            {
                T1.Stop();
                btn_start1.Text = "Start";
                btn_start1.BackColor = Color.YellowGreen;
            }
        }
        private void T1_Tick(object sender, EventArgs e)
        {
            counter1 = counter1 - 1;
            lbl_saat1.Text = (counter1 / 3600).ToString();
            lbl_dakika1.Text = ((counter1 % 3600) / 60).ToString();
            lbl_saniye1.Text = (counter1 % 60).ToString();
        }

        private void btn_reset1_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S1);
            dgv_analyse.DataSource = dm.ListChar_To();
            S1.ID = 0;
            S1.Name = "";
            S1.Donation = 0;
            S1.Duration = 0;
            S1.TaxiDate = DateTime.MinValue;
            counter1 = 0;
            time1 = 0;
            T1.Stop();
            tb_char1.Text = tb_sure1.Text = tb_pay1.Text = "";
            lbl_saat1.Text = lbl_dakika1.Text = lbl_saniye1.Text = "00";
            lbl_paid1.Text = "Insert PpH";
            lbl_id1.Text = "null";
            tb_char1.Enabled = tb_sure1.Enabled = tb_pay1.Enabled = btn_timeok1.Enabled = true;
            btn_30dk1.Enabled = btn_1sa1.Enabled = btn_start1.Enabled = btn_reset1.Enabled = false;
            if (btn_start1.Text == "Pause") { btn_start1.Text = "Start"; btn_start1.BackColor = Color.YellowGreen; }
            btn_30dk1.UseVisualStyleBackColor = true;
            btn_1sa1.UseVisualStyleBackColor = true;
        }

        #endregion

        #region Party Member 2
        private void btn_timeok2_Click(object sender, EventArgs e)
        {
            if (tb_char2.Text != "" && tb_sure2.Text != "" && tb_pay2.Text != "")
            {
                btn_start2.Enabled = btn_reset2.Enabled = true;
                btn_timeok2.Enabled = tb_char2.Enabled = tb_sure2.Enabled = tb_pay2.Enabled = false;
                counter2 = Convert.ToInt32(tb_sure2.Text) * 60;
                time2 = Convert.ToDouble(tb_sure2.Text) * 60;
                lbl_saat2.Text = (counter2 / 3600).ToString();
                lbl_dakika2.Text = ((counter2 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay2.Text) / 60;
                lbl_paid2.Text = (priceperminute * (time2 / 60)).ToString() + "M Gold";
                S2.TaxiDate = DateTime.Now;
                S2.Name = tb_char2.Text;
                S2.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time2) / 60));
                S2.Duration = Convert.ToInt32(tb_sure2.Text);
                dm.AddChar_Se(S2);
                S2.ID = dm.GetID(S2.TaxiDate);
                lbl_id2.Text = S2.ID.ToString();
            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk2_Click(object sender, EventArgs e)
        {
            S2.Duration += 30;
            S2.Donation += Convert.ToDecimal(tb_pay2.Text) / 2;
            if (dm.UpdateParam(S2.Duration, S2.Donation, S2.ID))
            {
                btn_30dk2.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk2.BackColor = Color.IndianRed;
            }
            counter2 = counter2 + 1800;
            time2 = time2 + 1800;
            double priceperminute = Convert.ToDouble(tb_pay2.Text) / 60;
            lbl_paid2.Text = (priceperminute * (time2 / 60)).ToString() + "M Gold";
        }

        private void btn_1sa2_Click(object sender, EventArgs e)
        {
            S2.Duration += 60;
            S2.Donation += Convert.ToDecimal(tb_pay2.Text);
            if (dm.UpdateParam(S2.Duration, S2.Donation, S2.ID))
            {
                btn_1sa2.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa2.BackColor = Color.IndianRed;
            }
            counter2 = counter2 + 3600;
            time2 = time2 + 3600;
            double priceperminute = Convert.ToDouble(tb_pay2.Text) / 60;
            lbl_paid2.Text = (priceperminute * (time2 / 60)).ToString() + "M Gold";
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            if (btn_start2.Text == "Start")
            {
                T2.Start();
                btn_start2.Text = "Pause";
                btn_start2.BackColor = Color.Orange;
                btn_1sa2.Enabled = btn_30dk2.Enabled = true;
            }
            else
            {
                T2.Stop();
                btn_start2.Text = "Start";
                btn_start2.BackColor = Color.YellowGreen;
            }
        }

        private void btn_reset2_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S2);
            dgv_analyse.DataSource = dm.ListChar_To();
            S2.ID = 0;
            S2.Name = "";
            S2.Donation = 0;
            S2.Duration = 0;
            S2.TaxiDate = DateTime.MinValue;
            counter2 = 0;
            time2 = 0;
            T2.Stop();
            tb_char2.Text = tb_sure2.Text = tb_pay2.Text = "";
            lbl_saat2.Text = lbl_dakika2.Text = lbl_saniye2.Text = "00";
            lbl_paid2.Text = "Insert PpH";
            lbl_id2.Text = "null";
            tb_char2.Enabled = tb_sure2.Enabled = tb_pay2.Enabled = btn_timeok2.Enabled = true;
            btn_30dk2.Enabled = btn_1sa2.Enabled = btn_start2.Enabled = btn_reset2.Enabled = false;
            if (btn_start2.Text == "Pause") { btn_start2.Text = "Start"; btn_start2.BackColor = Color.YellowGreen; }
            btn_30dk2.UseVisualStyleBackColor = true;
            btn_1sa2.UseVisualStyleBackColor = true;
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            counter2 = counter2 - 1;
            lbl_saat2.Text = (counter2 / 3600).ToString();
            lbl_dakika2.Text = ((counter2 % 3600) / 60).ToString();
            lbl_saniye2.Text = (counter2 % 60).ToString();
        }
        #endregion

        #region Party Member 3
        private void btn_timeok3_Click(object sender, EventArgs e)
        {
            if (tb_char3.Text != "" && tb_sure3.Text != "" && tb_pay3.Text != "")
            {
                btn_start3.Enabled = btn_reset3.Enabled = true;
                btn_timeok3.Enabled = tb_char3.Enabled = tb_sure3.Enabled = tb_pay3.Enabled = false;
                counter3 = Convert.ToInt32(tb_sure3.Text) * 60;
                time3 = Convert.ToDouble(tb_sure3.Text) * 60;
                lbl_saat3.Text = (counter3 / 3600).ToString();
                lbl_dakika3.Text = ((counter3 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay3.Text) / 60;
                lbl_paid3.Text = (priceperminute * (time3 / 60)).ToString() + "M Gold";
                S3.TaxiDate = DateTime.Now;
                S3.Name = tb_char3.Text;
                S3.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time3) / 60));
                S3.Duration = Convert.ToInt32(tb_sure3.Text);
                dm.AddChar_Se(S3);
                S3.ID = dm.GetID(S3.TaxiDate);
                lbl_id3.Text = S3.ID.ToString();
            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk3_Click(object sender, EventArgs e)
        {
            S3.Duration += 30;
            S3.Donation += Convert.ToDecimal(tb_pay3.Text) / 2;
            if (dm.UpdateParam(S3.Duration, S3.Donation, S3.ID))
            {
                btn_30dk3.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk3.BackColor = Color.IndianRed;
            }
            counter3 = counter3 + 1800;
            time3 = time3 + 1800;
            double priceperminute = Convert.ToDouble(tb_pay3.Text) / 60;
            lbl_paid3.Text = (priceperminute * (time3 / 60)).ToString() + "M Gold";
        }

        private void btn_1sa3_Click(object sender, EventArgs e)
        {
            S3.Duration += 60;
            S3.Donation += Convert.ToDecimal(tb_pay3.Text);
            if (dm.UpdateParam(S3.Duration, S3.Donation, S3.ID))
            {
                btn_1sa3.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa3.BackColor = Color.IndianRed;
            }
            counter3 = counter3 + 3600;
            time3 = time3 + 3600;
            double priceperminute = Convert.ToDouble(tb_pay3.Text) / 60;
            lbl_paid3.Text = (priceperminute * (time3 / 60)).ToString() + "M Gold";
        }

        private void btn_start3_Click(object sender, EventArgs e)
        {
            if (btn_start3.Text == "Start")
            {
                T3.Start();
                btn_start3.Text = "Pause";
                btn_start3.BackColor = Color.Orange;
                btn_1sa3.Enabled = btn_30dk3.Enabled = true;
            }
            else
            {
                T3.Stop();
                btn_start3.Text = "Start";
                btn_start3.BackColor = Color.YellowGreen;
            }
        }

        private void btn_reset3_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S3);
            dgv_analyse.DataSource = dm.ListChar_To();
            S3.ID = 0;
            S3.Name = "";
            S3.Donation = 0;
            S3.Duration = 0;
            S3.TaxiDate = DateTime.MinValue;
            counter3 = 0;
            time3 = 0;
            T3.Stop();
            tb_char3.Text = tb_sure3.Text = tb_pay3.Text = "";
            lbl_saat3.Text = lbl_dakika3.Text = lbl_saniye3.Text = "00";
            lbl_paid3.Text = "Insert PpH";
            lbl_id3.Text = "null";
            tb_char3.Enabled = tb_sure3.Enabled = tb_pay3.Enabled = btn_timeok3.Enabled = true;
            btn_30dk3.Enabled = btn_1sa3.Enabled = btn_start3.Enabled = btn_reset3.Enabled = false;
            if (btn_start3.Text == "Pause") { btn_start3.Text = "Start"; btn_start3.BackColor = Color.YellowGreen; }
            btn_30dk3.UseVisualStyleBackColor = true;
            btn_1sa3.UseVisualStyleBackColor = true;
        }

        private void T3_Tick(object sender, EventArgs e)
        {
            counter3 = counter3 - 1;
            lbl_saat3.Text = (counter3 / 3600).ToString();
            lbl_dakika3.Text = ((counter3 % 3600) / 60).ToString();
            lbl_saniye3.Text = (counter3 % 60).ToString();
        }

        #endregion

        #region Party Member 4
        private void btn_timeok4_Click(object sender, EventArgs e)
        {
            if (tb_char4.Text != "" && tb_sure4.Text != "" && tb_pay4.Text != "")
            {
                btn_start4.Enabled = btn_reset4.Enabled = true;
                btn_timeok4.Enabled = tb_char4.Enabled = tb_sure4.Enabled = tb_pay4.Enabled = false;
                counter4 = Convert.ToInt32(tb_sure4.Text) * 60;
                time4 = Convert.ToDouble(tb_sure4.Text) * 60;
                lbl_saat4.Text = (counter4 / 3600).ToString();
                lbl_dakika4.Text = ((counter4 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay4.Text) / 60;
                lbl_paid4.Text = (priceperminute * (time4 / 60)).ToString() + "M Gold";
                S4.TaxiDate = DateTime.Now;
                S4.Name = tb_char4.Text;
                S4.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time4) / 60));
                S4.Duration = Convert.ToInt32(tb_sure4.Text);
                dm.AddChar_Se(S4);
                S4.ID = dm.GetID(S4.TaxiDate);
                lbl_id4.Text = S4.ID.ToString();
            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk4_Click(object sender, EventArgs e)
        {
            S4.Duration += 30;
            S4.Donation += Convert.ToDecimal(tb_pay4.Text) / 2;
            if (dm.UpdateParam(S4.Duration, S4.Donation, S4.ID))
            {
                btn_30dk4.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk4.BackColor = Color.IndianRed;
            }
            counter4 = counter4 + 1800;
            time4 = time4 + 1800;
            double priceperminute = Convert.ToDouble(tb_pay4.Text) / 60;
            lbl_paid4.Text = (priceperminute * (time4 / 60)).ToString() + "M Gold";
        }

        private void btn_1sa4_Click(object sender, EventArgs e)
        {
            S4.Duration += 60;
            S4.Donation += Convert.ToDecimal(tb_pay4.Text);
            if (dm.UpdateParam(S4.Duration, S4.Donation, S4.ID))
            {
                btn_1sa4.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa4.BackColor = Color.IndianRed;
            }
            counter4 = counter4 + 3600;
            time4 = time4 + 3600;
            double priceperminute = Convert.ToDouble(tb_pay4.Text) / 60;
            lbl_paid4.Text = (priceperminute * (time4 / 60)).ToString() + "M Gold";
        }

        private void btn_start4_Click(object sender, EventArgs e)
        {
            if (btn_start4.Text == "Start")
            {
                T4.Start();
                btn_start4.Text = "Pause";
                btn_start4.BackColor = Color.Orange;
                btn_1sa4.Enabled = btn_30dk4.Enabled = true;
            }
            else
            {
                T4.Stop();
                btn_start4.Text = "Start";
                btn_start4.BackColor = Color.YellowGreen;
            }
        }

        private void btn_reset4_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S4);
            dgv_analyse.DataSource = dm.ListChar_To();
            S4.ID = 0;
            S4.Name = "";
            S4.Donation = 0;
            S4.Duration = 0;
            S4.TaxiDate = DateTime.MinValue;
            counter4 = 0;
            time4 = 0;
            T4.Stop();
            tb_char4.Text = tb_sure4.Text = tb_pay4.Text = "";
            lbl_saat4.Text = lbl_dakika4.Text = lbl_saniye4.Text = "00";
            lbl_paid4.Text = "Insert PpH";
            lbl_id4.Text = "null";
            tb_char4.Enabled = tb_sure4.Enabled = tb_pay4.Enabled = btn_timeok4.Enabled = true;
            btn_30dk4.Enabled = btn_1sa4.Enabled = btn_start4.Enabled = btn_reset4.Enabled = false;
            if (btn_start4.Text == "Pause") { btn_start4.Text = "Start"; btn_start4.BackColor = Color.YellowGreen; }
            btn_30dk4.UseVisualStyleBackColor = true;
            btn_1sa4.UseVisualStyleBackColor = true;
        }

        private void T4_Tick(object sender, EventArgs e)
        {
            counter4 = counter4 - 1;
            lbl_saat4.Text = (counter4 / 3600).ToString();
            lbl_dakika4.Text = ((counter4 % 3600) / 60).ToString();
            lbl_saniye4.Text = (counter4 % 60).ToString();
        }
        #endregion

        #region Party Member 5
        private void btn_timeok5_Click(object sender, EventArgs e)
        {
            if (tb_char5.Text != "" && tb_sure5.Text != "" && tb_pay5.Text != "")
            {
                btn_start5.Enabled = btn_reset5.Enabled = true;
                btn_timeok5.Enabled = tb_char5.Enabled = tb_sure5.Enabled = tb_pay5.Enabled = false;
                counter5 = Convert.ToInt32(tb_sure5.Text) * 60;
                time5 = Convert.ToDouble(tb_sure5.Text) * 60;
                lbl_saat5.Text = (counter5 / 3600).ToString();
                lbl_dakika5.Text = ((counter5 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay5.Text) / 60;
                lbl_paid5.Text = (priceperminute * (time5 / 60)).ToString() + "M Gold";
                S5.TaxiDate = DateTime.Now;
                S5.Name = tb_char5.Text;
                S5.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time5) / 60));
                S5.Duration = Convert.ToInt32(tb_sure5.Text);
                dm.AddChar_Se(S5);
                S5.ID = dm.GetID(S5.TaxiDate);
                lbl_id5.Text = S5.ID.ToString();
            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk5_Click(object sender, EventArgs e)
        {
            S5.Duration += 30;
            S5.Donation += Convert.ToDecimal(tb_pay5.Text) / 2;
            if (dm.UpdateParam(S5.Duration, S5.Donation, S5.ID))
            {
                btn_30dk5.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk5.BackColor = Color.IndianRed;
            }
            counter5 = counter5 + 1800;
            time5 = time5 + 1800;
            double priceperminute = Convert.ToDouble(tb_pay5.Text) / 60;
            lbl_paid5.Text = (priceperminute * (time5 / 60)).ToString() + "M Gold";
        }

        private void btn_1sa5_Click(object sender, EventArgs e)
        {
            S5.Duration += 60;
            S5.Donation += Convert.ToDecimal(tb_pay5.Text);
            if (dm.UpdateParam(S5.Duration, S5.Donation, S5.ID))
            {
                btn_1sa5.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa5.BackColor = Color.IndianRed;
            }
            counter5 = counter5 + 3600;
            time5 = time5 + 3600;
            double priceperminute = Convert.ToDouble(tb_pay5.Text) / 60;
            lbl_paid5.Text = (priceperminute * (time5 / 60)).ToString() + "M Gold";
        }

        private void btn_start5_Click(object sender, EventArgs e)
        {
            if (btn_start5.Text == "Start")
            {
                T5.Start();
                btn_start5.Text = "Pause";
                btn_start5.BackColor = Color.Orange;
                btn_1sa5.Enabled = btn_30dk5.Enabled = true;
            }
            else
            {
                T5.Stop();
                btn_start5.Text = "Start";
                btn_start5.BackColor = Color.YellowGreen;
            }
        }

        private void btn_reset5_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S5);
            dgv_analyse.DataSource = dm.ListChar_To();
            S5.ID = 0;
            S5.Name = "";
            S5.Donation = 0;
            S5.Duration = 0;
            S5.TaxiDate = DateTime.MinValue;
            counter5 = 0;
            time5 = 0;
            T5.Stop();
            tb_char5.Text = tb_sure5.Text = tb_pay5.Text = "";
            lbl_saat5.Text = lbl_dakika5.Text = lbl_saniye5.Text = "00";
            lbl_paid5.Text = "Insert PpH";
            lbl_id5.Text = "null";
            tb_char5.Enabled = tb_sure5.Enabled = tb_pay5.Enabled = btn_timeok5.Enabled = true;
            btn_30dk5.Enabled = btn_1sa5.Enabled = btn_start5.Enabled = btn_reset5.Enabled = false;
            if (btn_start5.Text == "Pause") { btn_start5.Text = "Start"; btn_start5.BackColor = Color.YellowGreen; }
            btn_30dk5.UseVisualStyleBackColor = true;
            btn_1sa5.UseVisualStyleBackColor = true;
        }

        private void T5_Tick(object sender, EventArgs e)
        {
            counter5 = counter5 - 1;
            lbl_saat5.Text = (counter5 / 3600).ToString();
            lbl_dakika5.Text = ((counter5 % 3600) / 60).ToString();
            lbl_saniye5.Text = (counter5 % 60).ToString();
        }
        #endregion

        #region Party Member 6
        private void btn_timeok6_Click(object sender, EventArgs e)
        {
            if (tb_char6.Text != "" && tb_sure6.Text != "" && tb_pay6.Text != "")
            {
                btn_start6.Enabled = btn_reset6.Enabled = true;
                btn_timeok6.Enabled = tb_char6.Enabled = tb_sure6.Enabled = tb_pay6.Enabled = false;
                counter6 = Convert.ToInt32(tb_sure6.Text) * 60;
                time6 = Convert.ToDouble(tb_sure6.Text) * 60;
                lbl_saat6.Text = (counter6 / 3600).ToString();
                lbl_dakika6.Text = ((counter6 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay6.Text) / 60;
                lbl_paid6.Text = (priceperminute * (time6 / 60)).ToString() + "M Gold";
                S6.TaxiDate = DateTime.Now;
                S6.Name = tb_char6.Text;
                S6.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time6) / 60));
                S6.Duration = Convert.ToInt32(tb_sure6.Text);
                dm.AddChar_Se(S6);
                S6.ID = dm.GetID(S6.TaxiDate);
                lbl_id6.Text = S6.ID.ToString();
            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk6_Click(object sender, EventArgs e)
        {
            S6.Duration += 30;
            S6.Donation += Convert.ToDecimal(tb_pay6.Text) / 2;
            if (dm.UpdateParam(S6.Duration, S6.Donation, S6.ID))
            {
                btn_30dk6.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk6.BackColor = Color.IndianRed;
            }
            counter6 = counter6 + 1800;
            time6 = time6 + 1800;
            double priceperminute = Convert.ToDouble(tb_pay6.Text) / 60;
            lbl_paid6.Text = (priceperminute * (time6 / 60)).ToString() + "M Gold";
        }

        private void btn_1sa6_Click(object sender, EventArgs e)
        {
            S6.Duration += 60;
            S6.Donation += Convert.ToDecimal(tb_pay6.Text);
            if (dm.UpdateParam(S6.Duration, S6.Donation, S6.ID))
            {
                btn_1sa6.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa6.BackColor = Color.IndianRed;
            }
            counter6 = counter6 + 3600;
            time6 = time6 + 3600;
            double priceperminute = Convert.ToDouble(tb_pay6.Text) / 60;
            lbl_paid6.Text = (priceperminute * (time6 / 60)).ToString() + "M Gold";
        }

        private void btn_start6_Click(object sender, EventArgs e)
        {
            if (btn_start6.Text == "Start")
            {
                T6.Start();
                btn_start6.Text = "Pause";
                btn_start6.BackColor = Color.Orange;
                btn_1sa6.Enabled = btn_30dk6.Enabled = true;
            }
            else
            {
                T6.Stop();
                btn_start6.Text = "Start";
                btn_start6.BackColor = Color.YellowGreen;
            }
        }

        private void btn_reset6_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S6);
            dgv_analyse.DataSource = dm.ListChar_To();
            S6.ID = 0;
            S6.Name = "";
            S6.Donation = 0;
            S6.Duration = 0;
            S6.TaxiDate = DateTime.MinValue;
            counter6 = 0;
            time6 = 0;
            T6.Stop();
            tb_char6.Text = tb_sure6.Text = tb_pay6.Text = "";
            lbl_saat6.Text = lbl_dakika6.Text = lbl_saniye6.Text = "00";
            lbl_paid6.Text = "Insert PpH";
            lbl_id6.Text = "null";
            tb_char6.Enabled = tb_sure6.Enabled = tb_pay6.Enabled = btn_timeok6.Enabled = true;
            btn_30dk6.Enabled = btn_1sa6.Enabled = btn_start6.Enabled = btn_reset6.Enabled = false;
            if (btn_start6.Text == "Pause") { btn_start6.Text = "Start"; btn_start6.BackColor = Color.YellowGreen; }
            btn_30dk6.UseVisualStyleBackColor = true;
            btn_1sa6.UseVisualStyleBackColor = true;
        }

        private void T6_Tick(object sender, EventArgs e)
        {
            counter6 = counter6 - 1;
            lbl_saat6.Text = (counter6 / 3600).ToString();
            lbl_dakika6.Text = ((counter6 % 3600) / 60).ToString();
            lbl_saniye6.Text = (counter6 % 60).ToString();
        }
        #endregion

        #region Party Member 7
        private void btn_timeok7_Click(object sender, EventArgs e)
        {
            if (tb_char7.Text != "" && tb_sure7.Text != "" && tb_pay7.Text != "")
            {
                btn_start7.Enabled = btn_reset7.Enabled = true;
                btn_timeok7.Enabled = tb_char7.Enabled = tb_sure7.Enabled = tb_pay7.Enabled = false;
                counter7 = Convert.ToInt32(tb_sure7.Text) * 60;
                time7 = Convert.ToDouble(tb_sure7.Text) * 60;
                lbl_saat7.Text = (counter7 / 3600).ToString();
                lbl_dakika7.Text = ((counter7 % 3600) / 60).ToString();
                double priceperminute = Convert.ToDouble(tb_pay7.Text) / 60;
                lbl_paid7.Text = (priceperminute * (time7 / 60)).ToString() + "M Gold";
                S7.TaxiDate = DateTime.Now;
                S7.Name = tb_char7.Text;
                S7.Donation = Convert.ToDecimal(priceperminute * (Convert.ToDouble(time7) / 60));
                S7.Duration = Convert.ToInt32(tb_sure7.Text);
                dm.AddChar_Se(S7);
                S7.ID = dm.GetID(S7.TaxiDate);
                lbl_id7.Text = S7.ID.ToString();

            }
            else { MessageBox.Show("Customer info can't be null."); }
        }

        private void btn_30dk7_Click(object sender, EventArgs e) 
        {
            S7.Duration += 30;
            S7.Donation += Convert.ToDecimal(tb_pay7.Text) / 2;
            if (dm.UpdateParam(S7.Duration,S7.Donation,S7.ID))
            {
                btn_30dk7.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_30dk7.BackColor = Color.IndianRed;
            }
            counter7 = counter7 + 1800;
            time7 = time7 + 1800;
            lbl_paid7.Text = S7.Donation.ToString() + "M Gold";
        }

        private void btn_1sa7_Click(object sender, EventArgs e)
        {
            S7.Duration += 60;
            S7.Donation += Convert.ToDecimal(tb_pay7.Text);
            if (dm.UpdateParam(S7.Duration, S7.Donation, S7.ID))
            {
                btn_1sa7.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_1sa7.BackColor = Color.IndianRed;
            }
            counter7 = counter7 + 3600;
            time7 = time7 + 3600;
            lbl_paid7.Text = S7.Donation.ToString() + "M Gold";
        }

        private void btn_start7_Click(object sender, EventArgs e)
        {
            if (btn_start7.Text == "Start")
            {
                T7.Start();
                btn_start7.Text = "Pause";
                btn_start7.BackColor = Color.Orange;
                btn_1sa7.Enabled = btn_30dk7.Enabled = true;
            }
            else
            {
                T7.Stop();
                btn_start7.Text = "Start";
                btn_start7.BackColor = Color.YellowGreen;
            }
        }

        private void btn_reset7_Click(object sender, EventArgs e)
        {
            dm.AddChar_To(S7);
            dgv_analyse.DataSource = dm.ListChar_To();
            S7.ID = 0;
            S7.Name = "";
            S7.Donation = 0;
            S7.Duration = 0;
            S7.TaxiDate = DateTime.MinValue;
            counter7 = 0;
            time7 = 0;
            T7.Stop();
            tb_char7.Text = tb_sure7.Text = tb_pay7.Text = "";
            lbl_saat7.Text = lbl_dakika7.Text = lbl_saniye7.Text = "00";
            lbl_paid7.Text = "Insert PpH";
            lbl_id7.Text = "null";
            tb_char7.Enabled = tb_sure7.Enabled = tb_pay7.Enabled = btn_timeok7.Enabled = true;
            btn_30dk7.Enabled = btn_1sa7.Enabled = btn_start7.Enabled = btn_reset7.Enabled = false;
            if (btn_start7.Text == "Pause") { btn_start7.Text = "Start"; btn_start7.BackColor = Color.YellowGreen; }
            btn_30dk7.UseVisualStyleBackColor = true;
            btn_1sa7.UseVisualStyleBackColor = true;
        }

        private void T7_Tick(object sender, EventArgs e)
        {
            counter7 = counter7 - 1;
            lbl_saat7.Text = (counter7 / 3600).ToString();
            lbl_dakika7.Text = ((counter7 % 3600) / 60).ToString();
            lbl_saniye7.Text = (counter7 % 60).ToString();
        }

        #endregion


    }
}
