namespace Menu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTotal = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Items.AddRange(new object[] {
            "Cola (Cold)  £0.50",
            "Coffee (Hot)  £1.00"});
            this.cmbDrink.Location = new System.Drawing.Point(23, 49);
            this.cmbDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(196, 21);
            this.cmbDrink.TabIndex = 0;
            this.cmbDrink.Text = "Please Select......";
            this.cmbDrink.SelectedIndexChanged += new System.EventHandler(this.cmbDrink_SelectedIndexChanged);
            // 
            // cmbFood
            // 
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Items.AddRange(new object[] {
            "Cheese Sandwich (Cold)  £2.00",
            "Steak Sandwich (Hot)  £4.50"});
            this.cmbFood.Location = new System.Drawing.Point(237, 49);
            this.cmbFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(204, 21);
            this.cmbFood.TabIndex = 1;
            this.cmbFood.Text = "Please Select......";
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drink";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food";
            // 
            // lstTotal
            // 
            this.lstTotal.FormattingEnabled = true;
            this.lstTotal.Location = new System.Drawing.Point(23, 92);
            this.lstTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTotal.Name = "lstTotal";
            this.lstTotal.Size = new System.Drawing.Size(417, 212);
            this.lstTotal.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 317);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 404);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.cmbDrink);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Menu Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTotal;
        private System.Windows.Forms.Button btnClear;
    }
}

