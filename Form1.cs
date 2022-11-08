using System.Security.Cryptography;

namespace CS311_Project3_MRE
{
    public partial class Form1 : Form
    {
        private CheckBox[] meats;
        private CheckBox[] veggies;

        public Form1()
        {
            InitializeComponent();
           
        }//end constructor

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summary();
        }//end btnCalculate_Click method
        
        private void rtfOrderSummary_TextChanged(object sender, EventArgs e)
        {
            
        }//end rtfOrderSummary_TextChanged method

        private void ckbPepporoni_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end ckbPepporoni_CheckedChanged method

        private void ckbSausage_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end ckbSausage_CheckedChanged method

        private void ckbCanadianBacon_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end ckbCanadianBacon_CheckedChanged method

        private void ckbSpicyItalianSausage_CheckedChanged(object sender, EventArgs e)
        {
     
        }//end ckbSpicyItalianSausage_CheckedChanged method

        private void ckbOnion_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end ckbOnion_CheckedChanged method

        private void ckbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
          
        }//end ckbGreenPepper_CheckedChanged method

        private void ckbBlackOlives_CheckedChanged(object sender, EventArgs e)
        {
         
        }//end ckbBlackOlives_CheckedChanged method

        private void ckbGreenOlives_CheckedChanged(object sender, EventArgs e)
        {
  
        }//end ckbGreenOlives_CheckedChanged method

        private void ckbBananaPeppers_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end ckbBananaPeppers_CheckedChanged method

        private void ckbJalepeno_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end ckbJalepeno_CheckedChanged method

        private void ckbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
      
        }//end ckbExtraCheese_CheckedChanged method

        private void ckbMushroom_CheckedChanged(object sender, EventArgs e)
        {
       
        }//end ckbMushroom_CheckedChanged method

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
           
        }//end rdoThin_CheckedChanged method

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
         
        }//end rdoThick_CheckedChanged method

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            
        }//end rdoRegular_CheckedChanged method

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }//end cboSize_SelectedIndexChanged method
        
        private void Summary()
        {
            double price = 0;
            rtfOrderSummary.Text += "";
            int size = cboSize.SelectedIndex;
            rtfOrderSummary.Text += "You ordered a " + cboSize.GetItemText(cboSize.SelectedItem) + " pizza with " + rtfOrderSummary.SelectedText + " and the following toppings: " + "\n";
            
            switch (size)
            {
                case 0:
                    price += 2;
                    break;

                case 1:
                    price += 5;
                    break;

                case 2:
                    price += 10;
                    break;

                case 3:
                    price += 15;
                    break;

                case 4:
                    price += 20;
                    break;
            }
            
            if (rdoThin.Checked)
                rtfOrderSummary.SelectedText = "Thin crust";
            if (rdoThick.Checked)
                rtfOrderSummary.SelectedText = "Thick crust";
            else rtfOrderSummary.SelectedText = "Regular crust";

            meats = new CheckBox[] {ckbPepporoni, ckbSausage, ckbCanadianBacon, ckbSpicyItalianSausage};
            foreach (var ckb in meats)
                if (ckb.Checked)
                rtfOrderSummary.Text = ckb.Text + "\n";
                price += 2;
                
            veggies = new CheckBox[] {ckbOnion, ckbGreenPepper, ckbBlackOlives, ckbGreenOlives, ckbBananaPeppers, ckbJalepeno, ckbExtraCheese, ckbMushroom};
            foreach(var ckb in veggies)    
                if (ckb.Checked)
                rtfOrderSummary.Text = ckb.Text + "\n";
                price += 1;
            
           
            txtSubTotal.Text = price.ToString("C");
            txtTax.Text = (price * .06).ToString("C");
            double sum = price + (price *.06);
            txtTotal.Text = sum.ToString("C");
        }//end summary method
    
    }//end class
}//end namespace