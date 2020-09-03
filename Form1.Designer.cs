namespace Doddsinator_3000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListLhop = new System.Windows.Forms.ImageList(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.lessons = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picProblem = new System.Windows.Forms.PictureBox();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.lbProblems = new System.Windows.Forms.Label();
            this.imageListDef = new System.Windows.Forms.ImageList(this.components);
            this.btnFormulas = new System.Windows.Forms.Button();
            this.picSheet = new System.Windows.Forms.PictureBox();
            this.imageListApp = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListLhop
            // 
            this.imageListLhop.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLhop.ImageStream")));
            this.imageListLhop.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLhop.Images.SetKeyName(0, "1.png");
            this.imageListLhop.Images.SetKeyName(1, "2.png");
            this.imageListLhop.Images.SetKeyName(2, "3.png");
            this.imageListLhop.Images.SetKeyName(3, "4.png");
            this.imageListLhop.Images.SetKeyName(4, "5.png");
            this.imageListLhop.Images.SetKeyName(5, "6.png");
            this.imageListLhop.Images.SetKeyName(6, "7.png");
            this.imageListLhop.Images.SetKeyName(7, "8.png");
            this.imageListLhop.Images.SetKeyName(8, "9.png");
            this.imageListLhop.Images.SetKeyName(9, "10.png");
            this.imageListLhop.Images.SetKeyName(10, "11.png");
            this.imageListLhop.Images.SetKeyName(11, "12.png");
            this.imageListLhop.Images.SetKeyName(12, "13.png");
            this.imageListLhop.Images.SetKeyName(13, "14.png");
            this.imageListLhop.Images.SetKeyName(14, "15.png");
            this.imageListLhop.Images.SetKeyName(15, "16.png");
            this.imageListLhop.Images.SetKeyName(16, "17.png");
            this.imageListLhop.Images.SetKeyName(17, "18.png");
            this.imageListLhop.Images.SetKeyName(18, "19.png");
            this.imageListLhop.Images.SetKeyName(19, "20.png");
            this.imageListLhop.Images.SetKeyName(20, "21.png");
            this.imageListLhop.Images.SetKeyName(21, "22.png");
            this.imageListLhop.Images.SetKeyName(22, "23.png");
            this.imageListLhop.Images.SetKeyName(23, "24.png");
            this.imageListLhop.Images.SetKeyName(24, "25.png");
            this.imageListLhop.Images.SetKeyName(25, "26.png");
            this.imageListLhop.Images.SetKeyName(26, "27.png");
            this.imageListLhop.Images.SetKeyName(27, "28.png");
            this.imageListLhop.Images.SetKeyName(28, "29.png");
            this.imageListLhop.Images.SetKeyName(29, "30.png");
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(56, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(226, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Calc Study Tool!";
            // 
            // lessons
            // 
            this.lessons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessons.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessons.ForeColor = System.Drawing.Color.Black;
            this.lessons.FormattingEnabled = true;
            this.lessons.Items.AddRange(new object[] {
            "L\'Hopital\'s Rule",
            "Definite Integrals",
            "Application of Integals"});
            this.lessons.Location = new System.Drawing.Point(9, 112);
            this.lessons.Name = "lessons";
            this.lessons.Size = new System.Drawing.Size(219, 28);
            this.lessons.TabIndex = 1;
            this.lessons.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a lesson";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerate.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(234, 107);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 38);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Problems";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // picProblem
            // 
            this.picProblem.BackColor = System.Drawing.Color.White;
            this.picProblem.Location = new System.Drawing.Point(43, 169);
            this.picProblem.Name = "picProblem";
            this.picProblem.Size = new System.Drawing.Size(256, 256);
            this.picProblem.TabIndex = 4;
            this.picProblem.TabStop = false;
            this.picProblem.Click += new System.EventHandler(this.PicProblem_Click);
            // 
            // btnReveal
            // 
            this.btnReveal.BackColor = System.Drawing.Color.DimGray;
            this.btnReveal.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReveal.ForeColor = System.Drawing.Color.White;
            this.btnReveal.Location = new System.Drawing.Point(63, 526);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(236, 59);
            this.btnReveal.TabIndex = 5;
            this.btnReveal.Text = "Reveal Answer";
            this.btnReveal.UseVisualStyleBackColor = false;
            this.btnReveal.Visible = false;
            this.btnReveal.Click += new System.EventHandler(this.BtnReveal_Click);
            this.btnReveal.MouseLeave += new System.EventHandler(this.BtnReveal_MouseLeave);
            this.btnReveal.MouseHover += new System.EventHandler(this.BtnReveal_MouseHover);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DimGray;
            this.btnRight.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(203, 476);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(140, 44);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "I got it right!";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.BackColor = System.Drawing.Color.DimGray;
            this.btnWrong.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrong.ForeColor = System.Drawing.Color.White;
            this.btnWrong.Location = new System.Drawing.Point(12, 476);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(140, 44);
            this.btnWrong.TabIndex = 7;
            this.btnWrong.Text = "I got it wrong";
            this.btnWrong.UseVisualStyleBackColor = false;
            this.btnWrong.Visible = false;
            this.btnWrong.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbProblems
            // 
            this.lbProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProblems.AutoSize = true;
            this.lbProblems.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblems.ForeColor = System.Drawing.Color.White;
            this.lbProblems.Location = new System.Drawing.Point(115, 444);
            this.lbProblems.Name = "lbProblems";
            this.lbProblems.Size = new System.Drawing.Size(0, 23);
            this.lbProblems.TabIndex = 8;
            // 
            // imageListDef
            // 
            this.imageListDef.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDef.ImageStream")));
            this.imageListDef.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDef.Images.SetKeyName(0, "1.png");
            this.imageListDef.Images.SetKeyName(1, "2.png");
            this.imageListDef.Images.SetKeyName(2, "3.png");
            this.imageListDef.Images.SetKeyName(3, "4.png");
            this.imageListDef.Images.SetKeyName(4, "5.png");
            this.imageListDef.Images.SetKeyName(5, "6.png");
            this.imageListDef.Images.SetKeyName(6, "7.png");
            this.imageListDef.Images.SetKeyName(7, "8.png");
            this.imageListDef.Images.SetKeyName(8, "9.png");
            this.imageListDef.Images.SetKeyName(9, "11.png");
            this.imageListDef.Images.SetKeyName(10, "12.png");
            this.imageListDef.Images.SetKeyName(11, "13.png");
            this.imageListDef.Images.SetKeyName(12, "14.png");
            this.imageListDef.Images.SetKeyName(13, "15.png");
            this.imageListDef.Images.SetKeyName(14, "16.png");
            this.imageListDef.Images.SetKeyName(15, "17.png");
            this.imageListDef.Images.SetKeyName(16, "18.png");
            this.imageListDef.Images.SetKeyName(17, "20.png");
            this.imageListDef.Images.SetKeyName(18, "21.png");
            this.imageListDef.Images.SetKeyName(19, "22.png");
            this.imageListDef.Images.SetKeyName(20, "23.png");
            this.imageListDef.Images.SetKeyName(21, "24.png");
            this.imageListDef.Images.SetKeyName(22, "25.png");
            this.imageListDef.Images.SetKeyName(23, "26.png");
            this.imageListDef.Images.SetKeyName(24, "27.png");
            this.imageListDef.Images.SetKeyName(25, "28.png");
            this.imageListDef.Images.SetKeyName(26, "29.png");
            this.imageListDef.Images.SetKeyName(27, "30.png");
            this.imageListDef.Images.SetKeyName(28, "31.png");
            // 
            // btnFormulas
            // 
            this.btnFormulas.BackColor = System.Drawing.Color.DimGray;
            this.btnFormulas.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulas.ForeColor = System.Drawing.Color.White;
            this.btnFormulas.Location = new System.Drawing.Point(247, 63);
            this.btnFormulas.Name = "btnFormulas";
            this.btnFormulas.Size = new System.Drawing.Size(85, 38);
            this.btnFormulas.TabIndex = 9;
            this.btnFormulas.Text = "Open Formula Sheet";
            this.btnFormulas.UseVisualStyleBackColor = false;
            this.btnFormulas.Click += new System.EventHandler(this.btnFormulas_Click);
            // 
            // picSheet
            // 
            this.picSheet.Image = ((System.Drawing.Image)(resources.GetObject("picSheet.Image")));
            this.picSheet.Location = new System.Drawing.Point(399, 42);
            this.picSheet.Name = "picSheet";
            this.picSheet.Size = new System.Drawing.Size(265, 508);
            this.picSheet.TabIndex = 10;
            this.picSheet.TabStop = false;
            // 
            // imageListApp
            // 
            this.imageListApp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListApp.ImageStream")));
            this.imageListApp.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListApp.Images.SetKeyName(0, "1.png");
            this.imageListApp.Images.SetKeyName(1, "2.png");
            this.imageListApp.Images.SetKeyName(2, "3.png");
            this.imageListApp.Images.SetKeyName(3, "4.png");
            this.imageListApp.Images.SetKeyName(4, "5.png");
            this.imageListApp.Images.SetKeyName(5, "6.png");
            this.imageListApp.Images.SetKeyName(6, "7.png");
            this.imageListApp.Images.SetKeyName(7, "8.png");
            this.imageListApp.Images.SetKeyName(8, "9.png");
            this.imageListApp.Images.SetKeyName(9, "10.png");
            this.imageListApp.Images.SetKeyName(10, "11.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 587);
            this.Controls.Add(this.picSheet);
            this.Controls.Add(this.btnFormulas);
            this.Controls.Add(this.lbProblems);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.picProblem);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessons);
            this.Controls.Add(this.lbTitle);
            this.MinimumSize = new System.Drawing.Size(387, 626);
            this.Name = "Form1";
            this.Text = "Calculus Study Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListLhop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox lessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picProblem;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Label lbProblems;
        private System.Windows.Forms.ImageList imageListDef;
        private System.Windows.Forms.Button btnFormulas;
        private System.Windows.Forms.PictureBox picSheet;
        private System.Windows.Forms.ImageList imageListApp;
    }
}

