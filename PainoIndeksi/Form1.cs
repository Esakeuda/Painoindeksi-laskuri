namespace PainoIndeksi
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);
            if (painoindeksi < 18.5 )
            {
                vastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                vastausLB.ForeColor = Color.Blue;
                kuvausLB.Text = "Alipaino";
                kuvausLB.ForeColor = Color.Blue;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
            else if (painoindeksi  < 25)
            {
                vastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                vastausLB.ForeColor = Color.Green;
                kuvausLB.Text = "Normaalipaino";
                kuvausLB.ForeColor = Color.Green;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
           else if (painoindeksi < 40)
            {
                vastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                vastausLB.ForeColor = Color.DarkOrange;
                kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor = Color.DarkOrange;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
            else 
            {
                vastausLB.Text = "Painoindeksisi on: " + painoindeksi;
                vastausLB.ForeColor = Color.Red;
                kuvausLB.Text = "Huomattava ylipaino";
                kuvausLB.ForeColor = Color.Red;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
        }
    }
}