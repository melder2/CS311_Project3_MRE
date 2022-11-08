namespace CS311_Project3_MRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double price = 0;
        }//end constructor

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summary();
        }//end btnCalculate_Click method

        private void rtfOrderSummary_TextChanged(object sender, EventArgs e)
        {
            //rtfOrderSummary.Text = "You ordered a " + cboSize.GetItemText(cboSize.SelectedItem) + "pizza with " + gbCrustType + " and the following toppings: ";
        }//end rtfOrderSummary_TextChanged method

        private void ckbPepporoni_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPepporoni.Checked)
                rtfOrderSummary.Text += "Pepporoni\n";
            else rtfOrderSummary.Text = null;
            
        }//end ckbPepporoni_CheckedChanged method

        private void ckbSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSausage.Checked)
                rtfOrderSummary.Text += "Sausage\n";
            else rtfOrderSummary.Text = null;
        }//end ckbSausage_CheckedChanged method

        private void ckbCanadianBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCanadianBacon.Checked)
                rtfOrderSummary.Text += "Canadian Bacon\n";
            else rtfOrderSummary.Text = null;
        }//end ckbCanadianBacon_CheckedChanged method

        private void ckbSpicyItalianSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSpicyItalianSausage.Checked)
                rtfOrderSummary.Text += "Spicy Italian Sausage\n";
            else rtfOrderSummary.Text = null;
        }//end ckbSpicyItalianSausage_CheckedChanged method

        private void ckbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOnion.Checked)
                rtfOrderSummary.Text += "Onion\n";
            else rtfOrderSummary.Text = null;
        }//end ckbOnion_CheckedChanged method

        private void ckbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGreenPepper.Checked)
                rtfOrderSummary.Text += "Green Pepper\n";
            else rtfOrderSummary.Text = null;
        }//end ckbGreenPepper_CheckedChanged method

        private void ckbBlackOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBlackOlives.Checked)
                rtfOrderSummary.Text += "Black Olives\n";
            else rtfOrderSummary.Text = null;
        }//end ckbBlackOlives_CheckedChanged method

        private void ckbGreenOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGreenOlives.Checked)
                rtfOrderSummary.Text += "Green Olives\n";
            else rtfOrderSummary.Text = null;
        }//end ckbGreenOlives_CheckedChanged method

        private void ckbBananaPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBananaPeppers.Checked)
                rtfOrderSummary.Text += "Banana Peppers\n";
            else rtfOrderSummary.Text = null;
        }//end ckbBananaPeppers_CheckedChanged method

        private void ckbJalepeno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbJalepeno.Checked)
                rtfOrderSummary.Text += "Jalepeno\n";
            else rtfOrderSummary.Text = null;
        }//end ckbJalepeno_CheckedChanged method

        private void ckbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbExtraCheese.Checked)
                rtfOrderSummary.Text += "Extra Cheese\n";
            else rtfOrderSummary.Text = null;
        }//end ckbExtraCheese_CheckedChanged method

        private void ckbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMushroom.Checked)
                rtfOrderSummary.Text += "Mushroom\n";
            else rtfOrderSummary.Text = null;
        }//end ckbMushroom_CheckedChanged method

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThin.Checked)
                rtfOrderSummary.Text += "Thin Crust\n";
            else rtfOrderSummary.Text = null;
        }//end rdoThin_CheckedChanged method

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThick.Checked)
                rtfOrderSummary.Text += "Thick Crust\n";
            else rtfOrderSummary.Text = null;
        }//end rdoThick_CheckedChanged method

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegular.Checked)
                rtfOrderSummary.Text += "Regular Crust\n";
            else rtfOrderSummary.Text = null;
        }//end rdoRegular_CheckedChanged method

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            String data = cboSize.GetItemText(cboSize.SelectedItem);
            rtfOrderSummary.Text = data;
        }//end cboSize_SelectedIndexChanged method

        private void Summary()
        {
            double price = 0;
            if (cboSize.GetItemText(cboSize.SelectedItem) == "Small")
                price += 2;
            if (cboSize.GetItemText(cboSize.SelectedItem) == "Medium")
                price += 5;
            if (cboSize.GetItemText(cboSize.SelectedItem) == "Large")
                price += 10;
            if (cboSize.GetItemText(cboSize.SelectedItem) == "X-Large")
                price += 15;
            if (cboSize.GetItemText(cboSize.SelectedItem) == "Ginormous")
                price += 20;
            if (ckbPepporoni.Checked)
                price += 2;
            if (ckbSausage.Checked)
                price += 2;
            if (ckbCanadianBacon.Checked)
                price += 2;
            if (ckbSpicyItalianSausage.Checked)
                price += 2;
            if (ckbOnion.Checked)
                price += 1;
            if (ckbGreenPepper.Checked)
                price += 1;
            if (ckbBlackOlives.Checked)
                price += 1;
            if (ckbGreenOlives.Checked)
                price += 1;
            if (ckbBananaPeppers.Checked)
                price += 1;
            if (ckbJalepeno.Checked)
                price += 1;
            if (ckbExtraCheese.Checked)
                price += 1;
            if (ckbMushroom.Checked)
                price += 1;
           
            txtSubTotal.Text = price.ToString("C");
            txtTax.Text = (price * .06).ToString("C");
            double sum = price + (price *.06);
            txtTotal.Text = sum.ToString("C");
        }//end summary method
    
    }//end class
}//end namespace