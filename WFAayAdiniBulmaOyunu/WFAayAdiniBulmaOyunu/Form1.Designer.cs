namespace WFAayAdiniBulmaOyunu
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
            this.txtayNo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnayAdiniBul = new System.Windows.Forms.Button();
            this.lblgoster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtayNo
            // 
            this.txtayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtayNo.Location = new System.Drawing.Point(55, 68);
            this.txtayNo.Multiline = true;
            this.txtayNo.Name = "txtayNo";
            this.txtayNo.Size = new System.Drawing.Size(203, 29);
            this.txtayNo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ay Adi";
            // 
            // btnayAdiniBul
            // 
            this.btnayAdiniBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnayAdiniBul.Location = new System.Drawing.Point(55, 103);
            this.btnayAdiniBul.Name = "btnayAdiniBul";
            this.btnayAdiniBul.Size = new System.Drawing.Size(203, 51);
            this.btnayAdiniBul.TabIndex = 3;
            this.btnayAdiniBul.Text = "Ay Adini Bul";
            this.btnayAdiniBul.UseVisualStyleBackColor = true;
            this.btnayAdiniBul.Click += new System.EventHandler(this.btnayAdiniBul_Click);
            // 
            // lblgoster
            // 
            this.lblgoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblgoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgoster.Location = new System.Drawing.Point(55, 176);
            this.lblgoster.Name = "lblgoster";
            this.lblgoster.Size = new System.Drawing.Size(203, 63);
            this.lblgoster.TabIndex = 4;
            this.lblgoster.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.lblgoster);
            this.Controls.Add(this.btnayAdiniBul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtayNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtayNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnayAdiniBul;
        private System.Windows.Forms.Label lblgoster;
    }
}

