namespace Register_Summative
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
            this.Title = new System.Windows.Forms.Label();
            this.Item1 = new System.Windows.Forms.Label();
            this.Item2 = new System.Windows.Forms.Label();
            this.Item3 = new System.Windows.Forms.Label();
            this.CoffeeInput = new System.Windows.Forms.TextBox();
            this.TeaInput = new System.Windows.Forms.TextBox();
            this.DonutInput = new System.Windows.Forms.TextBox();
            this.TotalButton = new System.Windows.Forms.Button();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.BlackBar = new System.Windows.Forms.Label();
            this.TenderedLabel = new System.Windows.Forms.Label();
            this.Tendered = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.ReciptButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.WhiteBox = new System.Windows.Forms.Label();
            this.ReciptTitle = new System.Windows.Forms.Label();
            this.Recipt = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Blue;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(-3, -1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(660, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sammy\'s";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Item1.Location = new System.Drawing.Point(32, 83);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(130, 17);
            this.Item1.TabIndex = 1;
            this.Item1.Text = "Number of Coffees:";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Item2.Location = new System.Drawing.Point(32, 124);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(127, 17);
            this.Item2.TabIndex = 2;
            this.Item2.Text = "Number of Donuts:\r\n";
            // 
            // Item3
            // 
            this.Item3.AutoSize = true;
            this.Item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Item3.Location = new System.Drawing.Point(32, 165);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(114, 17);
            this.Item3.TabIndex = 3;
            this.Item3.Text = "Number of Teas:";
            // 
            // CoffeeInput
            // 
            this.CoffeeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeInput.Location = new System.Drawing.Point(174, 80);
            this.CoffeeInput.Name = "CoffeeInput";
            this.CoffeeInput.Size = new System.Drawing.Size(100, 23);
            this.CoffeeInput.TabIndex = 4;
            // 
            // TeaInput
            // 
            this.TeaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeaInput.Location = new System.Drawing.Point(174, 159);
            this.TeaInput.Name = "TeaInput";
            this.TeaInput.Size = new System.Drawing.Size(100, 23);
            this.TeaInput.TabIndex = 5;
            // 
            // DonutInput
            // 
            this.DonutInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonutInput.Location = new System.Drawing.Point(174, 121);
            this.DonutInput.Name = "DonutInput";
            this.DonutInput.Size = new System.Drawing.Size(100, 23);
            this.DonutInput.TabIndex = 6;
            // 
            // TotalButton
            // 
            this.TotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalButton.Location = new System.Drawing.Point(35, 196);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(239, 25);
            this.TotalButton.TabIndex = 7;
            this.TotalButton.Text = "Calculate Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SubtotalLabel.Location = new System.Drawing.Point(32, 235);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(64, 17);
            this.SubtotalLabel.TabIndex = 8;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TaxLabel.Location = new System.Drawing.Point(32, 264);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(35, 17);
            this.TaxLabel.TabIndex = 9;
            this.TaxLabel.Text = "Tax:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TotalLabel.Location = new System.Drawing.Point(32, 293);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 17);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "Total:";
            // 
            // Subtotal
            // 
            this.Subtotal.BackColor = System.Drawing.Color.White;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.Location = new System.Drawing.Point(171, 235);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(100, 23);
            this.Subtotal.TabIndex = 11;
            // 
            // Tax
            // 
            this.Tax.BackColor = System.Drawing.Color.White;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(171, 264);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(100, 23);
            this.Tax.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.White;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(171, 293);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 23);
            this.Total.TabIndex = 13;
            // 
            // BlackBar
            // 
            this.BlackBar.BackColor = System.Drawing.Color.Black;
            this.BlackBar.Location = new System.Drawing.Point(35, 326);
            this.BlackBar.Name = "BlackBar";
            this.BlackBar.Size = new System.Drawing.Size(239, 10);
            this.BlackBar.TabIndex = 14;
            // 
            // TenderedLabel
            // 
            this.TenderedLabel.AutoSize = true;
            this.TenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenderedLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TenderedLabel.Location = new System.Drawing.Point(32, 353);
            this.TenderedLabel.Name = "TenderedLabel";
            this.TenderedLabel.Size = new System.Drawing.Size(74, 17);
            this.TenderedLabel.TabIndex = 15;
            this.TenderedLabel.Text = "Tendered:";
            // 
            // Tendered
            // 
            this.Tendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tendered.Location = new System.Drawing.Point(171, 347);
            this.Tendered.Name = "Tendered";
            this.Tendered.Size = new System.Drawing.Size(100, 23);
            this.Tendered.TabIndex = 16;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(35, 376);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(239, 25);
            this.ChangeButton.TabIndex = 17;
            this.ChangeButton.Text = "Calculate Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ChangeLabel.Location = new System.Drawing.Point(32, 417);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(61, 17);
            this.ChangeLabel.TabIndex = 18;
            this.ChangeLabel.Text = "Change:";
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.White;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(171, 417);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(100, 23);
            this.Change.TabIndex = 19;
            // 
            // ReciptButton
            // 
            this.ReciptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciptButton.Location = new System.Drawing.Point(32, 452);
            this.ReciptButton.Name = "ReciptButton";
            this.ReciptButton.Size = new System.Drawing.Size(239, 25);
            this.ReciptButton.TabIndex = 20;
            this.ReciptButton.Text = "Print Recipt";
            this.ReciptButton.UseVisualStyleBackColor = true;
            this.ReciptButton.Click += new System.EventHandler(this.ReciptButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(325, 427);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(272, 25);
            this.NewOrderButton.TabIndex = 22;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // WhiteBox
            // 
            this.WhiteBox.BackColor = System.Drawing.Color.White;
            this.WhiteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WhiteBox.Location = new System.Drawing.Point(325, 80);
            this.WhiteBox.Name = "WhiteBox";
            this.WhiteBox.Size = new System.Drawing.Size(272, 344);
            this.WhiteBox.TabIndex = 24;
            // 
            // ReciptTitle
            // 
            this.ReciptTitle.BackColor = System.Drawing.Color.White;
            this.ReciptTitle.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciptTitle.ForeColor = System.Drawing.Color.Black;
            this.ReciptTitle.Location = new System.Drawing.Point(415, 83);
            this.ReciptTitle.Name = "ReciptTitle";
            this.ReciptTitle.Size = new System.Drawing.Size(87, 23);
            this.ReciptTitle.TabIndex = 25;
            this.ReciptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Recipt
            // 
            this.Recipt.BackColor = System.Drawing.Color.White;
            this.Recipt.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipt.Location = new System.Drawing.Point(325, 118);
            this.Recipt.Name = "Recipt";
            this.Recipt.Size = new System.Drawing.Size(272, 306);
            this.Recipt.TabIndex = 26;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(295, 455);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(346, 23);
            this.ErrorLabel.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(653, 522);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Recipt);
            this.Controls.Add(this.ReciptTitle);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.ReciptButton);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.Tendered);
            this.Controls.Add(this.TenderedLabel);
            this.Controls.Add(this.BlackBar);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.DonutInput);
            this.Controls.Add(this.TeaInput);
            this.Controls.Add(this.CoffeeInput);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.WhiteBox);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Item1;
        private System.Windows.Forms.Label Item2;
        private System.Windows.Forms.Label Item3;
        private System.Windows.Forms.TextBox CoffeeInput;
        private System.Windows.Forms.TextBox TeaInput;
        private System.Windows.Forms.TextBox DonutInput;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label BlackBar;
        private System.Windows.Forms.Label TenderedLabel;
        private System.Windows.Forms.TextBox Tendered;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Button ReciptButton;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Label WhiteBox;
        private System.Windows.Forms.Label ReciptTitle;
        private System.Windows.Forms.Label Recipt;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

