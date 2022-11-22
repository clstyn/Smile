
namespace Smile
{
    partial class Smile_Questionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smile_Questionnaire));
            this.btnSmile = new System.Windows.Forms.Label();
            //this.qPage11 = new Smile.QuestionPage.qPage1();
            this.btnNext = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSmile
            // 
            this.btnSmile.AutoSize = true;
            this.btnSmile.BackColor = System.Drawing.Color.Transparent;
            this.btnSmile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmile.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSmile.ForeColor = System.Drawing.Color.White;
            this.btnSmile.Location = new System.Drawing.Point(12, 9);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(57, 22);
            this.btnSmile.TabIndex = 15;
            this.btnSmile.Text = "Smile";
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click);
            // 
            // qPage11
            // 
            /*this.qPage11.BackColor = System.Drawing.Color.Transparent;
            this.qPage11.Location = new System.Drawing.Point(263, 9);
            this.qPage11.Name = "qPage11";
            this.qPage11.Size = new System.Drawing.Size(540, 540);
            this.qPage11.TabIndex = 16;*/
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(649, 501);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 16);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(379, 501);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(36, 16);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "Prev";
            // 
            // txtPage
            // 
            this.txtPage.AutoSize = true;
            this.txtPage.BackColor = System.Drawing.Color.Transparent;
            this.txtPage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPage.ForeColor = System.Drawing.Color.White;
            this.txtPage.Location = new System.Drawing.Point(512, 501);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(32, 22);
            this.txtPage.TabIndex = 19;
            this.txtPage.Text = "1/4";
            // 
            // Smile_Questioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 569);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            //this.Controls.Add(this.qPage11);
            this.Controls.Add(this.btnSmile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smile_Questioner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smile_Questioner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSmile;
        //private QuestionPage.qPage1 qPage11;
        private System.Windows.Forms.Label btnNext;
        private System.Windows.Forms.Label btnPrev;
        private System.Windows.Forms.Label txtPage;
    }
}