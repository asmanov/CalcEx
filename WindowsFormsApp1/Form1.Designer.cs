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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.mpgTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // distanceLabel
            // 
            resources.ApplyResources(this.distanceLabel, "distanceLabel");
            this.distanceLabel.Name = "distanceLabel";
            // 
            // distanceTextBox
            // 
            resources.ApplyResources(this.distanceTextBox, "distanceTextBox");
            this.distanceTextBox.Name = "distanceTextBox";
            // 
            // mpgLabel
            // 
            resources.ApplyResources(this.mpgLabel, "mpgLabel");
            this.mpgLabel.Name = "mpgLabel";
            // 
            // mpgTextBox
            // 
            resources.ApplyResources(this.mpgTextBox, "mpgTextBox");
            this.mpgTextBox.Name = "mpgTextBox";
            // 
            // priceLabel
            // 
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.Name = "priceLabel";
            
            // 
            // priceTextBox
            // 
            resources.ApplyResources(this.priceTextBox, "priceTextBox");
            this.priceTextBox.Name = "priceTextBox";
            // 
            // calculateButton
            // 
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // gallonsLabel
            // 
            resources.ApplyResources(this.gallonsLabel, "gallonsLabel");
            this.gallonsLabel.Name = "gallonsLabel";
            // 
            // costLabel
            // 
            resources.ApplyResources(this.costLabel, "costLabel");
            this.costLabel.Name = "costLabel";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_ukraine_552041;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_russia_551878;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_france_300016;
            this.button2.Name = "button2";
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_uk_flag_2412363;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.mpgTextBox);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.distanceLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
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

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

