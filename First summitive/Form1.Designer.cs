namespace First_summitive
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
            this.ouputLable1 = new System.Windows.Forms.Label();
            this.ouputlabel2 = new System.Windows.Forms.Label();
            this.outputlabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ouputLable1
            // 
            this.ouputLable1.BackColor = System.Drawing.Color.Transparent;
            this.ouputLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouputLable1.ForeColor = System.Drawing.Color.Yellow;
            this.ouputLable1.Location = new System.Drawing.Point(129, 89);
            this.ouputLable1.Name = "ouputLable1";
            this.ouputLable1.Size = new System.Drawing.Size(142, 43);
            this.ouputLable1.TabIndex = 0;
            this.ouputLable1.Text = "HAPPY ";
            this.ouputLable1.Visible = false;
            this.ouputLable1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ouputlabel2
            // 
            this.ouputlabel2.BackColor = System.Drawing.Color.Transparent;
            this.ouputlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouputlabel2.ForeColor = System.Drawing.Color.Red;
            this.ouputlabel2.Location = new System.Drawing.Point(310, 89);
            this.ouputlabel2.Name = "ouputlabel2";
            this.ouputlabel2.Size = new System.Drawing.Size(218, 43);
            this.ouputlabel2.TabIndex = 1;
            this.ouputlabel2.Text = "NEW YEAR!!!";
            this.ouputlabel2.Visible = false;
            // 
            // outputlabel3
            // 
            this.outputlabel3.BackColor = System.Drawing.Color.Transparent;
            this.outputlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel3.ForeColor = System.Drawing.Color.Lime;
            this.outputlabel3.Location = new System.Drawing.Point(129, 155);
            this.outputlabel3.Name = "outputlabel3";
            this.outputlabel3.Size = new System.Drawing.Size(271, 40);
            this.outputlabel3.TabIndex = 2;
            this.outputlabel3.Text = "By: Nathan.Rison";
            this.outputlabel3.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(668, 86);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::First_summitive.Properties.Resources.xmass_tree;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputlabel3);
            this.Controls.Add(this.ouputlabel2);
            this.Controls.Add(this.ouputLable1);
            this.Name = "Form1";
            this.Text = "Christmas Card";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ouputLable1;
        private System.Windows.Forms.Label ouputlabel2;
        private System.Windows.Forms.Label outputlabel3;
        private System.Windows.Forms.Label label3;
    }
}

