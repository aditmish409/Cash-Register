namespace Cash_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sneakerLabel = new System.Windows.Forms.Label();
            this.foot4lifelabel = new System.Windows.Forms.Label();
            this.slidesLabel = new System.Windows.Forms.Label();
            this.bootsLabel = new System.Windows.Forms.Label();
            this.sneakersInput = new System.Windows.Forms.TextBox();
            this.slidesInput = new System.Windows.Forms.TextBox();
            this.bootsInput = new System.Windows.Forms.TextBox();
            this.calculateTotalsbutton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChangebutton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptbutton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.newReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sneakerLabel
            // 
            this.sneakerLabel.AutoSize = true;
            this.sneakerLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakerLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.sneakerLabel.Location = new System.Drawing.Point(55, 100);
            this.sneakerLabel.Name = "sneakerLabel";
            this.sneakerLabel.Size = new System.Drawing.Size(205, 24);
            this.sneakerLabel.TabIndex = 0;
            this.sneakerLabel.Text = "Number of Sneakers:";
            // 
            // foot4lifelabel
            // 
            this.foot4lifelabel.BackColor = System.Drawing.Color.OrangeRed;
            this.foot4lifelabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foot4lifelabel.ForeColor = System.Drawing.Color.White;
            this.foot4lifelabel.Location = new System.Drawing.Point(-1, 0);
            this.foot4lifelabel.Name = "foot4lifelabel";
            this.foot4lifelabel.Size = new System.Drawing.Size(802, 59);
            this.foot4lifelabel.TabIndex = 1;
            this.foot4lifelabel.Text = "Foot 4 Less";
            this.foot4lifelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slidesLabel
            // 
            this.slidesLabel.AutoSize = true;
            this.slidesLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidesLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.slidesLabel.Location = new System.Drawing.Point(64, 141);
            this.slidesLabel.Name = "slidesLabel";
            this.slidesLabel.Size = new System.Drawing.Size(178, 24);
            this.slidesLabel.TabIndex = 2;
            this.slidesLabel.Text = "Number of Slides:";
            // 
            // bootsLabel
            // 
            this.bootsLabel.AutoSize = true;
            this.bootsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootsLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.bootsLabel.Location = new System.Drawing.Point(64, 184);
            this.bootsLabel.Name = "bootsLabel";
            this.bootsLabel.Size = new System.Drawing.Size(177, 24);
            this.bootsLabel.TabIndex = 3;
            this.bootsLabel.Text = "Number of Boots:";
            // 
            // sneakersInput
            // 
            this.sneakersInput.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakersInput.Location = new System.Drawing.Point(266, 100);
            this.sneakersInput.Name = "sneakersInput";
            this.sneakersInput.Size = new System.Drawing.Size(92, 28);
            this.sneakersInput.TabIndex = 4;
            // 
            // slidesInput
            // 
            this.slidesInput.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidesInput.Location = new System.Drawing.Point(266, 141);
            this.slidesInput.Name = "slidesInput";
            this.slidesInput.Size = new System.Drawing.Size(92, 28);
            this.slidesInput.TabIndex = 5;
            // 
            // bootsInput
            // 
            this.bootsInput.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootsInput.Location = new System.Drawing.Point(266, 184);
            this.bootsInput.Name = "bootsInput";
            this.bootsInput.Size = new System.Drawing.Size(92, 28);
            this.bootsInput.TabIndex = 6;
            // 
            // calculateTotalsbutton
            // 
            this.calculateTotalsbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateTotalsbutton.FlatAppearance.BorderSize = 3;
            this.calculateTotalsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.calculateTotalsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.calculateTotalsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalsbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalsbutton.ForeColor = System.Drawing.Color.OrangeRed;
            this.calculateTotalsbutton.Location = new System.Drawing.Point(68, 224);
            this.calculateTotalsbutton.Name = "calculateTotalsbutton";
            this.calculateTotalsbutton.Size = new System.Drawing.Size(290, 44);
            this.calculateTotalsbutton.TabIndex = 7;
            this.calculateTotalsbutton.Text = "Calculate Totals";
            this.calculateTotalsbutton.UseVisualStyleBackColor = false;
            this.calculateTotalsbutton.Click += new System.EventHandler(this.calculateTotalsbutton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.subtotalLabel.Location = new System.Drawing.Point(68, 287);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(81, 22);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.taxLabel.Location = new System.Drawing.Point(68, 318);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(42, 22);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalLabel.Location = new System.Drawing.Point(68, 349);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(77, 22);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Black;
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.subtotalOutput.Location = new System.Drawing.Point(266, 287);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(92, 22);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Black;
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.taxOutput.Location = new System.Drawing.Point(266, 318);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(92, 22);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Black;
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalOutput.Location = new System.Drawing.Point(266, 349);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(92, 22);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(68, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 11);
            this.label1.TabIndex = 14;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.tenderedLabel.Location = new System.Drawing.Point(68, 404);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(96, 22);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(266, 404);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(92, 28);
            this.tenderedInput.TabIndex = 16;
            // 
            // calculateChangebutton
            // 
            this.calculateChangebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateChangebutton.FlatAppearance.BorderSize = 3;
            this.calculateChangebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.calculateChangebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.calculateChangebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangebutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangebutton.ForeColor = System.Drawing.Color.OrangeRed;
            this.calculateChangebutton.Location = new System.Drawing.Point(68, 441);
            this.calculateChangebutton.Name = "calculateChangebutton";
            this.calculateChangebutton.Size = new System.Drawing.Size(290, 44);
            this.calculateChangebutton.TabIndex = 17;
            this.calculateChangebutton.Text = "Calculate Change";
            this.calculateChangebutton.UseVisualStyleBackColor = false;
            this.calculateChangebutton.Click += new System.EventHandler(this.calculateChangebutton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.changeLabel.Location = new System.Drawing.Point(68, 502);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(96, 22);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Black;
            this.changeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.changeOutput.Location = new System.Drawing.Point(266, 502);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(92, 22);
            this.changeOutput.TabIndex = 19;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printReceiptbutton
            // 
            this.printReceiptbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printReceiptbutton.FlatAppearance.BorderSize = 3;
            this.printReceiptbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.printReceiptbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.printReceiptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptbutton.ForeColor = System.Drawing.Color.OrangeRed;
            this.printReceiptbutton.Location = new System.Drawing.Point(68, 536);
            this.printReceiptbutton.Name = "printReceiptbutton";
            this.printReceiptbutton.Size = new System.Drawing.Size(290, 44);
            this.printReceiptbutton.TabIndex = 20;
            this.printReceiptbutton.Text = "Print Receipt";
            this.printReceiptbutton.UseVisualStyleBackColor = false;
            this.printReceiptbutton.Click += new System.EventHandler(this.printReceiptbutton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.Black;
            this.receiptOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptOutput.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.receiptOutput.Location = new System.Drawing.Point(384, 105);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(388, 419);
            this.receiptOutput.TabIndex = 21;
            this.receiptOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newReceipt
            // 
            this.newReceipt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newReceipt.FlatAppearance.BorderSize = 3;
            this.newReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.newReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.newReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newReceipt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReceipt.ForeColor = System.Drawing.Color.OrangeRed;
            this.newReceipt.Location = new System.Drawing.Point(384, 536);
            this.newReceipt.Name = "newReceipt";
            this.newReceipt.Size = new System.Drawing.Size(388, 44);
            this.newReceipt.TabIndex = 22;
            this.newReceipt.Text = "New Receipt";
            this.newReceipt.UseVisualStyleBackColor = false;
            this.newReceipt.Click += new System.EventHandler(this.newReceipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(379, 607);
            this.Controls.Add(this.newReceipt);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.printReceiptbutton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangebutton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateTotalsbutton);
            this.Controls.Add(this.bootsInput);
            this.Controls.Add(this.slidesInput);
            this.Controls.Add(this.sneakersInput);
            this.Controls.Add(this.bootsLabel);
            this.Controls.Add(this.slidesLabel);
            this.Controls.Add(this.foot4lifelabel);
            this.Controls.Add(this.sneakerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sneakerLabel;
        private System.Windows.Forms.Label foot4lifelabel;
        private System.Windows.Forms.Label slidesLabel;
        private System.Windows.Forms.Label bootsLabel;
        private System.Windows.Forms.TextBox sneakersInput;
        private System.Windows.Forms.TextBox slidesInput;
        private System.Windows.Forms.TextBox bootsInput;
        private System.Windows.Forms.Button calculateTotalsbutton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChangebutton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptbutton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button newReceipt;
    }
}

