
namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Materials = new System.Windows.Forms.ComboBox();
            this.textBox_size_shirina = new System.Windows.Forms.TextBox();
            this.textBox_size_dlina = new System.Windows.Forms.TextBox();
            this.textBox_size_visota = new System.Windows.Forms.TextBox();
            this.label_Input = new System.Windows.Forms.Label();
            this.label_Materials = new System.Windows.Forms.Label();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.label_Output = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Calculate);
            this.groupBox1.Controls.Add(this.label_Output);
            this.groupBox1.Controls.Add(this.textBox_Output);
            this.groupBox1.Controls.Add(this.label_Materials);
            this.groupBox1.Controls.Add(this.label_Input);
            this.groupBox1.Controls.Add(this.textBox_size_visota);
            this.groupBox1.Controls.Add(this.textBox_size_dlina);
            this.groupBox1.Controls.Add(this.textBox_size_shirina);
            this.groupBox1.Controls.Add(this.comboBox_Materials);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_Materials
            // 
            this.comboBox_Materials.Items.AddRange(new object[] {
            "Кирпич",
            "Шлакоблок"});
            this.comboBox_Materials.Location = new System.Drawing.Point(24, 56);
            this.comboBox_Materials.Name = "comboBox_Materials";
            this.comboBox_Materials.Size = new System.Drawing.Size(119, 21);
            this.comboBox_Materials.TabIndex = 1;
            // 
            // textBox_size_shirina
            // 
            this.textBox_size_shirina.Location = new System.Drawing.Point(24, 187);
            this.textBox_size_shirina.Name = "textBox_size_shirina";
            this.textBox_size_shirina.Size = new System.Drawing.Size(101, 20);
            this.textBox_size_shirina.TabIndex = 2;
            // 
            // textBox_size_dlina
            // 
            this.textBox_size_dlina.Location = new System.Drawing.Point(131, 187);
            this.textBox_size_dlina.Name = "textBox_size_dlina";
            this.textBox_size_dlina.Size = new System.Drawing.Size(100, 20);
            this.textBox_size_dlina.TabIndex = 3;
            // 
            // textBox_size_visota
            // 
            this.textBox_size_visota.Location = new System.Drawing.Point(238, 187);
            this.textBox_size_visota.Name = "textBox_size_visota";
            this.textBox_size_visota.Size = new System.Drawing.Size(100, 20);
            this.textBox_size_visota.TabIndex = 4;
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Location = new System.Drawing.Point(22, 161);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(148, 13);
            this.label_Input.TabIndex = 5;
            this.label_Input.Text = "Габариты материала (ШДВ)";
            // 
            // label_Materials
            // 
            this.label_Materials.AutoSize = true;
            this.label_Materials.Location = new System.Drawing.Point(24, 37);
            this.label_Materials.Name = "label_Materials";
            this.label_Materials.Size = new System.Drawing.Size(98, 13);
            this.label_Materials.TabIndex = 6;
            this.label_Materials.Text = "Выбор материала";
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(25, 386);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(100, 20);
            this.textBox_Output.TabIndex = 7;
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Location = new System.Drawing.Point(24, 359);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(40, 13);
            this.label_Output.TabIndex = 8;
            this.label_Output.Text = "Вывод";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(24, 235);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(119, 42);
            this.button_Calculate.TabIndex = 9;
            this.button_Calculate.Text = "Расчитать кол-во материала";
            this.button_Calculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 505);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(713, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(713, 544);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет строительных материалов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Materials;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Label label_Materials;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.TextBox textBox_size_visota;
        private System.Windows.Forms.TextBox textBox_size_dlina;
        private System.Windows.Forms.TextBox textBox_size_shirina;
        private System.Windows.Forms.Button button_Calculate;
    }
}

