
namespace Csharp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_french = new System.Windows.Forms.RadioButton();
            this.rd_english = new System.Windows.Forms.RadioButton();
            this.rd_spanish = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dt_pk_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_python = new System.Windows.Forms.RadioButton();
            this.rd_java = new System.Windows.Forms.RadioButton();
            this.rd_php = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_enviar);
            this.tab1.Controls.Add(this.maskedTextBox1);
            this.tab1.Controls.Add(this.groupBox2);
            this.tab1.Controls.Add(this.comboBox1);
            this.tab1.Controls.Add(this.dt_pk_fecha);
            this.tab1.Controls.Add(this.txt_apellido);
            this.tab1.Controls.Add(this.txt_nombre);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab1.Size = new System.Drawing.Size(1180, 644);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Pestaña 1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Maroon;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enviar.Location = new System.Drawing.Point(634, 513);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(372, 58);
            this.btn_enviar.TabIndex = 8;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(179, 397);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox1.Mask = "(99) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(136, 22);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_french);
            this.groupBox2.Controls.Add(this.rd_english);
            this.groupBox2.Controls.Add(this.rd_spanish);
            this.groupBox2.Location = new System.Drawing.Point(837, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(190, 233);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idioma";
            // 
            // rd_french
            // 
            this.rd_french.AutoSize = true;
            this.rd_french.Location = new System.Drawing.Point(46, 164);
            this.rd_french.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_french.Name = "rd_french";
            this.rd_french.Size = new System.Drawing.Size(80, 21);
            this.rd_french.TabIndex = 0;
            this.rd_french.TabStop = true;
            this.rd_french.Text = "Francés";
            this.rd_french.UseVisualStyleBackColor = true;
            // 
            // rd_english
            // 
            this.rd_english.AutoSize = true;
            this.rd_english.Location = new System.Drawing.Point(46, 99);
            this.rd_english.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_english.Name = "rd_english";
            this.rd_english.Size = new System.Drawing.Size(66, 21);
            this.rd_english.TabIndex = 0;
            this.rd_english.TabStop = true;
            this.rd_english.Text = "Inglés";
            this.rd_english.UseVisualStyleBackColor = true;
            // 
            // rd_spanish
            // 
            this.rd_spanish.AutoSize = true;
            this.rd_spanish.Location = new System.Drawing.Point(46, 45);
            this.rd_spanish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_spanish.Name = "rd_spanish";
            this.rd_spanish.Size = new System.Drawing.Size(80, 21);
            this.rd_spanish.TabIndex = 0;
            this.rd_spanish.TabStop = true;
            this.rd_spanish.Text = "Español";
            this.rd_spanish.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buenos Aires",
            "Córdoba",
            "Santa Fe",
            "La Pampa",
            "Jujuy",
            "Salta",
            "Tucumán",
            "Santa Cruz"});
            this.comboBox1.Location = new System.Drawing.Point(167, 313);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // dt_pk_fecha
            // 
            this.dt_pk_fecha.Location = new System.Drawing.Point(311, 233);
            this.dt_pk_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_pk_fecha.MaxDate = new System.DateTime(2021, 8, 9, 21, 5, 15, 0);
            this.dt_pk_fecha.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dt_pk_fecha.Name = "dt_pk_fecha";
            this.dt_pk_fecha.Size = new System.Drawing.Size(265, 22);
            this.dt_pk_fecha.TabIndex = 4;
            this.dt_pk_fecha.Value = new System.DateTime(2021, 8, 9, 0, 0, 0, 0);
            // 
            // txt_apellido
            // 
            this.txt_apellido.CausesValidation = false;
            this.txt_apellido.Location = new System.Drawing.Point(723, 132);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_apellido.Multiline = true;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(421, 37);
            this.txt_apellido.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.CausesValidation = false;
            this.txt_nombre.Location = new System.Drawing.Point(151, 132);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(421, 37);
            this.txt_nombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_python);
            this.groupBox1.Controls.Add(this.rd_java);
            this.groupBox1.Controls.Add(this.rd_php);
            this.groupBox1.Location = new System.Drawing.Point(593, 233);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(217, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lenguaje";
            // 
            // rd_python
            // 
            this.rd_python.AutoSize = true;
            this.rd_python.Location = new System.Drawing.Point(65, 155);
            this.rd_python.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_python.Name = "rd_python";
            this.rd_python.Size = new System.Drawing.Size(73, 21);
            this.rd_python.TabIndex = 6;
            this.rd_python.TabStop = true;
            this.rd_python.Text = "Python";
            this.rd_python.UseVisualStyleBackColor = true;
            // 
            // rd_java
            // 
            this.rd_java.AutoSize = true;
            this.rd_java.Location = new System.Drawing.Point(65, 99);
            this.rd_java.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_java.Name = "rd_java";
            this.rd_java.Size = new System.Drawing.Size(59, 21);
            this.rd_java.TabIndex = 6;
            this.rd_java.TabStop = true;
            this.rd_java.Text = "Java";
            this.rd_java.UseVisualStyleBackColor = true;
            // 
            // rd_php
            // 
            this.rd_php.AutoSize = true;
            this.rd_php.Location = new System.Drawing.Point(65, 45);
            this.rd_php.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_php.Name = "rd_php";
            this.rd_php.Size = new System.Drawing.Size(57, 21);
            this.rd_php.TabIndex = 6;
            this.rd_php.TabStop = true;
            this.rd_php.Text = "PHP";
            this.rd_php.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Nacimiento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Teléfono:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Provincia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1172, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título Pestaña 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2.Size = new System.Drawing.Size(1664, 733);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Pestaña 2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Location = new System.Drawing.Point(4, 25);
            this.tab3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1664, 733);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Pestaña 3";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 673);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_pk_fecha;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rd_python;
        private System.Windows.Forms.RadioButton rd_java;
        private System.Windows.Forms.RadioButton rd_php;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_french;
        private System.Windows.Forms.RadioButton rd_english;
        private System.Windows.Forms.RadioButton rd_spanish;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_enviar;
    }
}

