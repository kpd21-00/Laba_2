namespace Laba_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._bMatr = new System.Windows.Forms.Button();
            this._bMatrRand = new System.Windows.Forms.Button();
            this._cbOper = new System.Windows.Forms.ComboBox();
            this._tbMatr = new System.Windows.Forms.TextBox();
            this._bCreateMatr = new System.Windows.Forms.Button();
            this._dgvMatr1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._bSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._dgvMatr2 = new System.Windows.Forms.DataGridView();
            this._dgvMatr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._tbTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMatr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMatr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMatr)).BeginInit();
            this.SuspendLayout();
            // 
            // _bMatr
            // 
            this._bMatr.Location = new System.Drawing.Point(1017, 517);
            this._bMatr.Name = "_bMatr";
            this._bMatr.Size = new System.Drawing.Size(75, 23);
            this._bMatr.TabIndex = 0;
            this._bMatr.Text = "Рассчитать";
            this._bMatr.UseVisualStyleBackColor = true;
            this._bMatr.Click += new System.EventHandler(this._bMatr_Click);
            // 
            // _bMatrRand
            // 
            this._bMatrRand.Location = new System.Drawing.Point(967, 43);
            this._bMatrRand.Name = "_bMatrRand";
            this._bMatrRand.Size = new System.Drawing.Size(108, 36);
            this._bMatrRand.TabIndex = 1;
            this._bMatrRand.Text = "Рандомные значения";
            this._bMatrRand.UseVisualStyleBackColor = true;
            this._bMatrRand.Click += new System.EventHandler(this._bMatrRand_Click);
            // 
            // _cbOper
            // 
            this._cbOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOper.FormattingEnabled = true;
            this._cbOper.Items.AddRange(new object[] {
            "Сложение",
            "Умножение"});
            this._cbOper.Location = new System.Drawing.Point(555, 52);
            this._cbOper.Name = "_cbOper";
            this._cbOper.Size = new System.Drawing.Size(121, 21);
            this._cbOper.TabIndex = 2;
            // 
            // _tbMatr
            // 
            this._tbMatr.Location = new System.Drawing.Point(39, 53);
            this._tbMatr.Name = "_tbMatr";
            this._tbMatr.Size = new System.Drawing.Size(100, 20);
            this._tbMatr.TabIndex = 5;
            this._tbMatr.Text = "5";
            this._tbMatr.TextChanged += new System.EventHandler(this._tbMatr_TextChanged);
            // 
            // _bCreateMatr
            // 
            this._bCreateMatr.Location = new System.Drawing.Point(182, 49);
            this._bCreateMatr.Name = "_bCreateMatr";
            this._bCreateMatr.Size = new System.Drawing.Size(115, 25);
            this._bCreateMatr.TabIndex = 6;
            this._bCreateMatr.Text = "Создать матрицы";
            this._bCreateMatr.UseVisualStyleBackColor = true;
            this._bCreateMatr.Click += new System.EventHandler(this._bCreateMatr_Click);
            // 
            // _dgvMatr1
            // 
            this._dgvMatr1.AllowUserToAddRows = false;
            this._dgvMatr1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._dgvMatr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvMatr1.ColumnHeadersVisible = false;
            this._dgvMatr1.Location = new System.Drawing.Point(57, 266);
            this._dgvMatr1.Name = "_dgvMatr1";
            this._dgvMatr1.RowHeadersVisible = false;
            this._dgvMatr1.Size = new System.Drawing.Size(240, 150);
            this._dgvMatr1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "+/x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // _bSave
            // 
            this._bSave.Location = new System.Drawing.Point(1017, 546);
            this._bSave.Name = "_bSave";
            this._bSave.Size = new System.Drawing.Size(75, 43);
            this._bSave.TabIndex = 12;
            this._bSave.Text = "Сохранить результат";
            this._bSave.UseVisualStyleBackColor = true;
            this._bSave.Click += new System.EventHandler(this._bSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Размерности матриц";
            // 
            // _dgvMatr2
            // 
            this._dgvMatr2.AllowUserToAddRows = false;
            this._dgvMatr2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._dgvMatr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvMatr2.ColumnHeadersVisible = false;
            this._dgvMatr2.Location = new System.Drawing.Point(354, 266);
            this._dgvMatr2.Name = "_dgvMatr2";
            this._dgvMatr2.RowHeadersVisible = false;
            this._dgvMatr2.Size = new System.Drawing.Size(240, 150);
            this._dgvMatr2.TabIndex = 14;
            // 
            // _dgvMatr
            // 
            this._dgvMatr.AllowUserToAddRows = false;
            this._dgvMatr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this._dgvMatr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvMatr.ColumnHeadersVisible = false;
            this._dgvMatr.Location = new System.Drawing.Point(662, 266);
            this._dgvMatr.Name = "_dgvMatr";
            this._dgvMatr.RowHeadersVisible = false;
            this._dgvMatr.Size = new System.Drawing.Size(240, 150);
            this._dgvMatr.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Метод рассчета";
            // 
            // _tbTime
            // 
            this._tbTime.Location = new System.Drawing.Point(813, 558);
            this._tbTime.Name = "_tbTime";
            this._tbTime.ReadOnly = true;
            this._tbTime.Size = new System.Drawing.Size(100, 20);
            this._tbTime.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 613);
            this.Controls.Add(this._tbTime);
            this.Controls.Add(this._dgvMatr);
            this.Controls.Add(this._dgvMatr2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._bSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dgvMatr1);
            this.Controls.Add(this._bCreateMatr);
            this.Controls.Add(this._tbMatr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbOper);
            this.Controls.Add(this._bMatrRand);
            this.Controls.Add(this._bMatr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._dgvMatr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMatr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMatr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bMatr;
        private System.Windows.Forms.Button _bMatrRand;
        private System.Windows.Forms.ComboBox _cbOper;
        private System.Windows.Forms.TextBox _tbMatr;
        private System.Windows.Forms.Button _bCreateMatr;
        private System.Windows.Forms.DataGridView _dgvMatr1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _bSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView _dgvMatr2;
        private System.Windows.Forms.DataGridView _dgvMatr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbTime;
    }
}

