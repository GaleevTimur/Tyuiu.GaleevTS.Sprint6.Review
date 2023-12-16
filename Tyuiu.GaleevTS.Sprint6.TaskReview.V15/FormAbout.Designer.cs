
namespace Tyuiu.GaleevTS.Sprint6.TaskReview.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxProfile_GTS = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_GTS = new System.Windows.Forms.TextBox();
            this.buttonClose_GTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile_GTS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile_GTS
            // 
            this.pictureBoxProfile_GTS.Image = global::Tyuiu.GaleevTS.Sprint6.TaskReview.V15.Properties.Resources.AQACCjVFilY9tQfBWZnO63NB_Nn4FCReV4vHENhJeJ6zLqLBhoEJT2aAcVEWfIOu155FrW6vSR2F0doiZ_aV_CZAKpA;
            this.pictureBoxProfile_GTS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxProfile_GTS.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile_GTS.Name = "pictureBoxProfile_GTS";
            this.pictureBoxProfile_GTS.Size = new System.Drawing.Size(266, 239);
            this.pictureBoxProfile_GTS.TabIndex = 2;
            this.pictureBoxProfile_GTS.TabStop = false;
            // 
            // textBoxInfo_GTS
            // 
            this.textBoxInfo_GTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfo_GTS.Location = new System.Drawing.Point(301, 13);
            this.textBoxInfo_GTS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInfo_GTS.Multiline = true;
            this.textBoxInfo_GTS.Name = "textBoxInfo_GTS";
            this.textBoxInfo_GTS.ReadOnly = true;
            this.textBoxInfo_GTS.Size = new System.Drawing.Size(383, 213);
            this.textBoxInfo_GTS.TabIndex = 3;
            this.textBoxInfo_GTS.Text = resources.GetString("textBoxInfo_GTS.Text");
            // 
            // buttonClose_GTS
            // 
            this.buttonClose_GTS.Location = new System.Drawing.Point(511, 241);
            this.buttonClose_GTS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose_GTS.Name = "buttonClose_GTS";
            this.buttonClose_GTS.Size = new System.Drawing.Size(173, 46);
            this.buttonClose_GTS.TabIndex = 4;
            this.buttonClose_GTS.Text = "ОК";
            this.buttonClose_GTS.UseVisualStyleBackColor = true;
            this.buttonClose_GTS.Click += new System.EventHandler(this.buttonClose_GTS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 300);
            this.Controls.Add(this.buttonClose_GTS);
            this.Controls.Add(this.textBoxInfo_GTS);
            this.Controls.Add(this.pictureBoxProfile_GTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile_GTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile_GTS;
        private System.Windows.Forms.TextBox textBoxInfo_GTS;
        private System.Windows.Forms.Button buttonClose_GTS;
    }
}