namespace MelisaYuksek_OOP_Proje
{
    partial class HomeForm
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
            this.btnStylist = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStylist
            // 
            this.btnStylist.Location = new System.Drawing.Point(101, 226);
            this.btnStylist.Name = "btnStylist";
            this.btnStylist.Size = new System.Drawing.Size(199, 80);
            this.btnStylist.TabIndex = 0;
            this.btnStylist.Text = "Stylist";
            this.btnStylist.UseVisualStyleBackColor = true;
            this.btnStylist.Click += new System.EventHandler(this.btnStylist_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(507, 226);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(199, 80);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnStylist);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStylist;
        private System.Windows.Forms.Button btnClient;
    }
}

