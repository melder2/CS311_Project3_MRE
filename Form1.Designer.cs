namespace CS311_Project3_MRE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictPizza = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbPepporoni = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).BeginInit();
            this.gbCrustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictPizza
            // 
            this.pictPizza.Image = global::CS311_Project3_MRE.Properties.Resources.Hot_Pizza__3_;
            this.pictPizza.Location = new System.Drawing.Point(-3, 1);
            this.pictPizza.Name = "pictPizza";
            this.pictPizza.Size = new System.Drawing.Size(467, 380);
            this.pictPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictPizza.TabIndex = 0;
            this.pictPizza.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(647, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BU Pizza Palace";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(490, 103);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 28);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrustType.Location = new System.Drawing.Point(756, 103);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(117, 28);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThin.Location = new System.Drawing.Point(6, 17);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(61, 24);
            this.rdoThin.TabIndex = 5;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThick.Location = new System.Drawing.Point(73, 17);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(67, 24);
            this.rdoThick.TabIndex = 6;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoThick_CheckedChanged);
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRegular.Location = new System.Drawing.Point(146, 17);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(84, 24);
            this.rdoRegular.TabIndex = 7;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            this.rdoRegular.CheckedChanged += new System.EventHandler(this.rdoRegular_CheckedChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(490, 162);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(102, 28);
            this.lblToppings.TabIndex = 8;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbPepporoni
            // 
            this.ckbPepporoni.AutoSize = true;
            this.ckbPepporoni.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbPepporoni.Location = new System.Drawing.Point(507, 223);
            this.ckbPepporoni.Name = "ckbPepporoni";
            this.ckbPepporoni.Size = new System.Drawing.Size(114, 27);
            this.ckbPepporoni.TabIndex = 9;
            this.ckbPepporoni.Text = "Pepporoni";
            this.ckbPepporoni.UseVisualStyleBackColor = true;
            this.ckbPepporoni.CheckedChanged += new System.EventHandler(this.ckbPepporoni_CheckedChanged);
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(507, 256);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(97, 27);
            this.ckbSausage.TabIndex = 10;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            this.ckbSausage.CheckedChanged += new System.EventHandler(this.ckbSausage_CheckedChanged);
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbCanadianBacon.Location = new System.Drawing.Point(507, 289);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(159, 27);
            this.ckbCanadianBacon.TabIndex = 11;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            this.ckbCanadianBacon.CheckedChanged += new System.EventHandler(this.ckbCanadianBacon_CheckedChanged);
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(507, 322);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(200, 27);
            this.ckbSpicyItalianSausage.TabIndex = 12;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            this.ckbSpicyItalianSausage.CheckedChanged += new System.EventHandler(this.ckbSpicyItalianSausage_CheckedChanged);
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenOlives.Location = new System.Drawing.Point(733, 322);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(132, 27);
            this.ckbGreenOlives.TabIndex = 16;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            this.ckbGreenOlives.CheckedChanged += new System.EventHandler(this.ckbGreenOlives_CheckedChanged);
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBlackOlives.Location = new System.Drawing.Point(733, 289);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(128, 27);
            this.ckbBlackOlives.TabIndex = 15;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            this.ckbBlackOlives.CheckedChanged += new System.EventHandler(this.ckbBlackOlives_CheckedChanged);
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenPepper.Location = new System.Drawing.Point(733, 256);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(140, 27);
            this.ckbGreenPepper.TabIndex = 14;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            this.ckbGreenPepper.CheckedChanged += new System.EventHandler(this.ckbGreenPepper_CheckedChanged);
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(733, 223);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(80, 27);
            this.ckbOnion.TabIndex = 13;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            this.ckbOnion.CheckedChanged += new System.EventHandler(this.ckbOnion_CheckedChanged);
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(932, 322);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(118, 27);
            this.ckbMushroom.TabIndex = 20;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            this.ckbMushroom.CheckedChanged += new System.EventHandler(this.ckbMushroom_CheckedChanged);
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbExtraCheese.Location = new System.Drawing.Point(932, 289);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(133, 27);
            this.ckbExtraCheese.TabIndex = 19;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            this.ckbExtraCheese.CheckedChanged += new System.EventHandler(this.ckbExtraCheese_CheckedChanged);
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBananaPeppers.Location = new System.Drawing.Point(932, 223);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(158, 27);
            this.ckbBananaPeppers.TabIndex = 17;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            this.ckbBananaPeppers.CheckedChanged += new System.EventHandler(this.ckbBananaPeppers_CheckedChanged);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderSummary.Location = new System.Drawing.Point(123, 395);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(167, 28);
            this.lblOrderSummary.TabIndex = 21;
            this.lblOrderSummary.Text = "Order Summary:";
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Location = new System.Drawing.Point(313, 395);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(560, 213);
            this.rtfOrderSummary.TabIndex = 22;
            this.rtfOrderSummary.Text = "";
            this.rtfOrderSummary.TextChanged += new System.EventHandler(this.rtfOrderSummary_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(889, 417);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(99, 28);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(939, 464);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(49, 28);
            this.lblTax.TabIndex = 24;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(924, 513);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 28);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(879, 562);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(236, 46);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbJalepeno.Location = new System.Drawing.Point(932, 256);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(103, 27);
            this.ckbJalepeno.TabIndex = 27;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            this.ckbJalepeno.CheckedChanged += new System.EventHandler(this.ckbJalepeno_CheckedChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(990, 418);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(125, 27);
            this.txtSubTotal.TabIndex = 28;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(990, 465);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(125, 27);
            this.txtTax.TabIndex = 29;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(990, 514);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 27);
            this.txtTotal.TabIndex = 30;
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(556, 103);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(151, 28);
            this.cboSize.TabIndex = 31;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rdoThin);
            this.gbCrustType.Controls.Add(this.rdoThick);
            this.gbCrustType.Controls.Add(this.rdoRegular);
            this.gbCrustType.Location = new System.Drawing.Point(879, 91);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(236, 53);
            this.gbCrustType.TabIndex = 32;
            this.gbCrustType.TabStop = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 620);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.ckbJalepeno);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbExtraCheese);
            this.Controls.Add(this.ckbBananaPeppers);
            this.Controls.Add(this.ckbGreenOlives);
            this.Controls.Add(this.ckbBlackOlives);
            this.Controls.Add(this.ckbGreenPepper);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbSpicyItalianSausage);
            this.Controls.Add(this.ckbCanadianBacon);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbPepporoni);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictPizza);
            this.Name = "Form1";
            this.Text = "BU Pizza Palace";
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).EndInit();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictPizza;
        private Label lblTitle;
        private Label lblSize;
        private Label lblCrustType;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private RadioButton rdoRegular;
        private Label lblToppings;
        private CheckBox ckbPepporoni;
        private CheckBox ckbSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbMushroom;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbBananaPeppers;
        private Label lblOrderSummary;
        private RichTextBox rtfOrderSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private Button btnCalculate;
        private CheckBox ckbJalepeno;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private ComboBox cboSize;
        private GroupBox gbCrustType;
    }
}