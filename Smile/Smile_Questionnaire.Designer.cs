
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
            this.btnNext = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.Label();
            this.pageQuest1 = new Smile.QuestionPage.pageQuest();
            this.pageQuest2 = new Smile.QuestionPage.pageQuest();
            this.pageQuest3 = new Smile.QuestionPage.pageQuest();
            this.pageQuest4 = new Smile.QuestionPage.pageQuest();
            this.SuspendLayout();
            // 
            // btnSmile
            // 
            this.btnSmile.AutoSize = true;
            this.btnSmile.BackColor = System.Drawing.Color.Transparent;
            this.btnSmile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSmile.ForeColor = System.Drawing.Color.White;
            this.btnSmile.Location = new System.Drawing.Point(14, 10);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(80, 29);
            this.btnSmile.TabIndex = 15;
            this.btnSmile.Text = "Smile";
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(742, 534);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 20);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(433, 534);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(47, 20);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtPage
            // 
            this.txtPage.AutoSize = true;
            this.txtPage.BackColor = System.Drawing.Color.Transparent;
            this.txtPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtPage.ForeColor = System.Drawing.Color.White;
            this.txtPage.Location = new System.Drawing.Point(585, 534);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(49, 29);
            this.txtPage.TabIndex = 19;
            this.txtPage.Text = "1/4";
            // 
            // pageQuest1
            // 
            this.pageQuest1.BackColor = System.Drawing.Color.Transparent;
            this.pageQuest1.Location = new System.Drawing.Point(324, 10);
            this.pageQuest1.Name = "pageQuest1";
            this.pageQuest1.Size = new System.Drawing.Size(622, 576);
            this.pageQuest1.TabIndex = 20;
            // 
            // pageQuest2
            // 
            this.pageQuest2.BackColor = System.Drawing.Color.Transparent;
            this.pageQuest2.Location = new System.Drawing.Point(324, 10);
            this.pageQuest2.Name = "pageQuest2";
            this.pageQuest2.Size = new System.Drawing.Size(617, 576);
            this.pageQuest2.TabIndex = 21;
            // 
            // pageQuest3
            // 
            this.pageQuest3.BackColor = System.Drawing.Color.Transparent;
            this.pageQuest3.Location = new System.Drawing.Point(324, 10);
            this.pageQuest3.Name = "pageQuest3";
            this.pageQuest3.Size = new System.Drawing.Size(617, 576);
            this.pageQuest3.TabIndex = 22;
            // 
            // pageQuest4
            // 
            this.pageQuest4.BackColor = System.Drawing.Color.Transparent;
            this.pageQuest4.Location = new System.Drawing.Point(329, 12);
            this.pageQuest4.Name = "pageQuest4";
            this.pageQuest4.Size = new System.Drawing.Size(617, 576);
            this.pageQuest4.TabIndex = 23;
            // 
            // Smile_Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 607);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSmile);
            this.Controls.Add(this.pageQuest1);
            this.Controls.Add(this.pageQuest2);
            this.Controls.Add(this.pageQuest3);
            this.Controls.Add(this.pageQuest4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smile_Questionnaire";
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
        private QuestionPage.pageQuest pageQuest1;
        private QuestionPage.pageQuest pageQuest2;
        private QuestionPage.pageQuest pageQuest3;
        private QuestionPage.pageQuest pageQuest4;
    }
}