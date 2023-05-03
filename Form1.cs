using System.Security.Cryptography;

/**
 * Author: Michael Elder
 * CS311 Project 3
 * This project creates a pizza application that displays the subtotal, tax, total, and an order
 * summary.
 * 
 */

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
        
                
        /**
         * Summary method totals up the order based on the selections and siplays it into the 
         * SubTotal textbox, calculates the tax and displays it into the tax textbox, and totals
         * the order and siplays it in the total textbox. It also writes a summary of the pizza 
         * order to the rich text box Order Summary
         */
        private void Summary()
        {
            String crust = "";//creates string called crust
            if (rdoThin.Checked)
            { crust = "Thin crust"; }//if thin checkbox is checked crust will equal this string
            if (rdoThick.Checked)
            { crust = "Thick crust"; }//if thick checkbox is checked crust will equal this string
            else { crust = "Regular crust"; }//else prints the string
            
            double price = 0;//initiating price variable to 0
            rtfOrderSummary.Clear();//clearing the rich text box
            int size = cboSize.SelectedIndex;//assigning the selected index of cboSize to size
            rtfOrderSummary.SelectedText += "You ordered a " + cboSize.GetItemText(cboSize.SelectedItem) + " pizza with " + crust + " and the following toppings: " + "\n";
            //creating the first sentence of the rich text box combined with a string, the size of pizza, string, crust variable, and the last string

            switch (size)
            {
                case 0:
                    price += 2;//if array index is 0 increment price by 2
                    break;

                case 1:
                    price += 5;//if array index is 1 increment price by 5
                    break;

                case 2:
                    price += 10;//if array index is 0 increment price by 10
                    break;

                case 3:
                    price += 15;//if array index is 0 increment price by 15
                    break;

                case 4:
                    price += 20;//if array index is 0 increment price by 20
                    break;
            }//end switch 

            meats = new CheckBox[] {ckbPepporoni, ckbSausage, ckbCanadianBacon, ckbSpicyItalianSausage};//creating an array of meats
            foreach (var ckb in meats)//for each ckb in the array meats
            {
                if (ckb.Checked)
                {
                    rtfOrderSummary.SelectionBullet = true;//open the bullet point function
                    rtfOrderSummary.SelectedText = ckb.Text + "\n";//prints any checkboxes that have been checked for veggies in the rtf
                    price += 2;//increments price by 2 each time a ckb is selected
                    rtfOrderSummary.SelectionBullet = false;//close the bullet point function
                }//end if statement
            }//end foreach statement   
            veggies = new CheckBox[] {ckbOnion, ckbGreenPepper, ckbBlackOlives, ckbGreenOlives, ckbBananaPeppers, ckbJalepeno, ckbExtraCheese, ckbMushroom};//creating an array of veggies
            foreach (var ckb in veggies)//for each ckb in the array vegies
            {
                if (ckb.Checked)
                {
                    rtfOrderSummary.SelectionBullet = true;//open the bullet function
                    rtfOrderSummary.SelectedText = ckb.Text + "\n";//prints any checkboxes that have been checked for veggies in the rtf
                    price += 1;//increments price by 1 each time a ckb is selected
                    rtfOrderSummary.SelectionBullet = false;//close the bullet point function
                }//end if statement               
            }//end foreach statement
           
            txtSubTotal.Text = price.ToString("C");//totals the price of the size and toppings, converts to string, and puts it in the txtSubTotal
            txtTax.Text = (price * .06).ToString("C");//multiplies the price by .06 to get tax, converts to string, and puts it in the txtTax
            double sum = price + (price *.06);//sums up the subtotal + tax in the sum variable
            txtTotal.Text = sum.ToString("C");//prints the sum in a string in the txtTotal
        }//end summary method
        
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

    
    }//end class
}//end namespace
