
namespace B_FormView
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
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModal.ForeColor = System.Drawing.Color.Blue;
            this.btnModal.Location = new System.Drawing.Point(25, 21);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(97, 50);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "모달";
            this.btnModal.UseVisualStyleBackColor = false;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModaless.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModaless.ForeColor = System.Drawing.Color.Red;
            this.btnModaless.Location = new System.Drawing.Point(161, 21);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(97, 50);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "모달리스";
            this.btnModaless.UseVisualStyleBackColor = false;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 97);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btnModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "폼 꾸미기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless;
    }
}

