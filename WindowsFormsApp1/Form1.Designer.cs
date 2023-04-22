using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Exams";


            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.mpgTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.BackColor = Color.FromArgb(255, 80, 120, 255);
            this.ForeColor = Color.White;
            this.Font = new Font("ubuntu", 12, FontStyle.Bold);

            // distanceLabel
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(12, 15);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(82, 13);
            this.distanceLabel.TabIndex = 0;
            this.distanceLabel.Text = "Distance (miles):";

            // distanceTextBox
            this.distanceTextBox.Location = new System.Drawing.Point(100, 12);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 1;

            // mpgLabel
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.Location = new System.Drawing.Point(12, 41);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(82, 13);
            this.mpgLabel.TabIndex = 2;
            this.mpgLabel.Text = "MPG (miles/gal):";

            // mpgTextBox
            this.mpgTextBox.Location = new System.Drawing.Point(100, 38);
            this.mpgTextBox.Name = "mpgTextBox";
            this.mpgTextBox.Size = new System.Drawing.Size(100, 20);
            this.mpgTextBox.TabIndex = 3;
            // priceLabel
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 67);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(75, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price (dollars):";
            // priceTextBox
            this.priceTextBox.Location = new System.Drawing.Point(100, 64);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(100, 90);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            //this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            calculateButton.ForeColor = Color.WhiteSmoke;
            calculateButton.FlatStyle = FlatStyle.Popup;

            // gallonsLabel
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.Location = new System.Drawing.Point(12, 132);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(84, 13);
            this.gallonsLabel.TabIndex = 7;
            this.gallonsLabel.Text = "Gallons used: 0";

            // costLabel
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(12, 158);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(66, 13);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Total cost: $0";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 194);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.mpgTextBox);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.distanceLabel);
            this.Name = "MainForm";
            this.Text = "Fuel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private Label distanceLabel;
        private TextBox distanceTextBox;
        private Label mpgLabel;
        private TextBox mpgTextBox;
        private Label priceLabel;
        private TextBox priceTextBox;
        private Button calculateButton;
        private Label gallonsLabel;
        private Label costLabel;
        #endregion
    }
}

