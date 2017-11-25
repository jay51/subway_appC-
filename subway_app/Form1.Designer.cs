namespace subway_app
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
            this.steak = new System.Windows.Forms.Button();
            this.tuna = new System.Windows.Forms.Button();
            this.lblone = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // steak
            // 
            this.steak.Location = new System.Drawing.Point(328, 93);
            this.steak.Name = "steak";
            this.steak.Size = new System.Drawing.Size(75, 23);
            this.steak.TabIndex = 0;
            this.steak.Text = "STEAK";
            this.steak.UseVisualStyleBackColor = true;
            this.steak.Click += new System.EventHandler(this.button1_Click);
            // 
            // tuna
            // 
            this.tuna.Location = new System.Drawing.Point(328, 122);
            this.tuna.Name = "tuna";
            this.tuna.Size = new System.Drawing.Size(75, 23);
            this.tuna.TabIndex = 1;
            this.tuna.Text = "TUNA";
            this.tuna.UseVisualStyleBackColor = true;
            this.tuna.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblone
            // 
            this.lblone.AutoSize = true;
            this.lblone.Location = new System.Drawing.Point(42, 103);
            this.lblone.Name = "lblone";
            this.lblone.Size = new System.Drawing.Size(40, 13);
            this.lblone.TabIndex = 2;
            this.lblone.Text = "LABEL";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(243, 253);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 3;
            this.info.Text = "message";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 326);
            this.Controls.Add(this.info);
            this.Controls.Add(this.lblone);
            this.Controls.Add(this.tuna);
            this.Controls.Add(this.steak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button steak;
        private System.Windows.Forms.Button tuna;
        private System.Windows.Forms.Label lblone;
        private System.Windows.Forms.Button info;
    }
}

