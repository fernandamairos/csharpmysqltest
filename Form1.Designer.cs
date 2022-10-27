
namespace mysqltest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtepisodes = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Episodes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(15, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(109, 23);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtepisodes
            // 
            this.txtepisodes.Location = new System.Drawing.Point(15, 85);
            this.txtepisodes.Name = "txtepisodes";
            this.txtepisodes.Size = new System.Drawing.Size(109, 23);
            this.txtepisodes.TabIndex = 5;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(15, 133);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(109, 23);
            this.txtyear.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(15, 177);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(109, 23);
            this.txtscore.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtepisodes);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MyAnimeList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtepisodes;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Label label4;
    }
}

