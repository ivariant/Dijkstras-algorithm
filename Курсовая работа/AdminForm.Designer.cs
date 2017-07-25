namespace Курсовая_работа
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.comboBoxStartPath = new System.Windows.Forms.ComboBox();
            this.comboBoxEndPath = new System.Windows.Forms.ComboBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelStartPath = new System.Windows.Forms.Label();
            this.labelEndPath = new System.Windows.Forms.Label();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.groupBoxPath.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.Honeydew;
            this.richTextBoxInfo.Location = new System.Drawing.Point(277, 29);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(318, 213);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "";
            // 
            // comboBoxStartPath
            // 
            this.comboBoxStartPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStartPath.FormattingEnabled = true;
            this.comboBoxStartPath.Items.AddRange(new object[] {
            "Москва",
            "Киев",
            "Варшава",
            "Берлин",
            "Лондон",
            "Париж",
            "Мадрид",
            "Рим"});
            this.comboBoxStartPath.Location = new System.Drawing.Point(94, 32);
            this.comboBoxStartPath.Name = "comboBoxStartPath";
            this.comboBoxStartPath.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStartPath.TabIndex = 3;
            // 
            // comboBoxEndPath
            // 
            this.comboBoxEndPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEndPath.FormattingEnabled = true;
            this.comboBoxEndPath.Items.AddRange(new object[] {
            "Москва",
            "Киев",
            "Варшава",
            "Берлин",
            "Лондон",
            "Париж",
            "Мадрид",
            "Рим"});
            this.comboBoxEndPath.Location = new System.Drawing.Point(94, 59);
            this.comboBoxEndPath.Name = "comboBoxEndPath";
            this.comboBoxEndPath.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEndPath.TabIndex = 4;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(93, 226);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(48, 20);
            this.textBoxValue.TabIndex = 6;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(147, 220);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(32, 229);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(55, 13);
            this.labelValue.TabIndex = 8;
            this.labelValue.Text = "Значение";
            // 
            // labelStartPath
            // 
            this.labelStartPath.AutoSize = true;
            this.labelStartPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartPath.Location = new System.Drawing.Point(3, 35);
            this.labelStartPath.Name = "labelStartPath";
            this.labelStartPath.Size = new System.Drawing.Size(92, 13);
            this.labelStartPath.TabIndex = 9;
            this.labelStartPath.Text = "Начальный путь ";
            // 
            // labelEndPath
            // 
            this.labelEndPath.AutoSize = true;
            this.labelEndPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndPath.Location = new System.Drawing.Point(10, 62);
            this.labelEndPath.Name = "labelEndPath";
            this.labelEndPath.Size = new System.Drawing.Size(85, 13);
            this.labelEndPath.TabIndex = 10;
            this.labelEndPath.Text = "Конечный путь ";
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.comboBoxStartPath);
            this.groupBoxPath.Controls.Add(this.labelEndPath);
            this.groupBoxPath.Controls.Add(this.comboBoxEndPath);
            this.groupBoxPath.Controls.Add(this.labelStartPath);
            this.groupBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPath.Location = new System.Drawing.Point(29, 107);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(200, 100);
            this.groupBoxPath.TabIndex = 11;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Путь";
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.radioButtonPrice);
            this.groupBoxMatrix.Controls.Add(this.radioButtonTime);
            this.groupBoxMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMatrix.Location = new System.Drawing.Point(29, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(200, 80);
            this.groupBoxMatrix.TabIndex = 12;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Матрица";
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPrice.Location = new System.Drawing.Point(18, 42);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(86, 17);
            this.radioButtonPrice.TabIndex = 1;
            this.radioButtonPrice.Text = "Cтоимостей";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.AutoSize = true;
            this.radioButtonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTime.Location = new System.Drawing.Point(18, 19);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(70, 17);
            this.radioButtonTime.TabIndex = 0;
            this.radioButtonTime.Text = "Времени";
            this.radioButtonTime.UseVisualStyleBackColor = true;
            this.radioButtonTime.Click += new System.EventHandler(this.radioButtonTime_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 265);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.richTextBoxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель редактирования";
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.groupBoxMatrix.ResumeLayout(false);
            this.groupBoxMatrix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.ComboBox comboBoxStartPath;
        private System.Windows.Forms.ComboBox comboBoxEndPath;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelStartPath;
        private System.Windows.Forms.Label labelEndPath;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.RadioButton radioButtonTime;
    }
}