namespace Oficina.WindowsForms
{
    partial class VeiculoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.placaMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.anoMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.marcaComboBox1 = new System.Windows.Forms.ComboBox();
            this.modeloComboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combustivelComboBox3 = new System.Windows.Forms.ComboBox();
            this.cambioComboBox4 = new System.Windows.Forms.ComboBox();
            this.gravarButton1 = new System.Windows.Forms.Button();
            this.limparButton2 = new System.Windows.Forms.Button();
            this.observacaoGroupBox1 = new System.Windows.Forms.GroupBox();
            this.observacaoTextBox1 = new System.Windows.Forms.TextBox();
            this.corComboBox5 = new System.Windows.Forms.ComboBox();
            this.VeiculoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.observacaoGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano";
            // 
            // placaMaskedTextBox1
            // 
            this.placaMaskedTextBox1.Location = new System.Drawing.Point(52, 26);
            this.placaMaskedTextBox1.Mask = ">LLL<-0000";
            this.placaMaskedTextBox1.Name = "placaMaskedTextBox1";
            this.placaMaskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.placaMaskedTextBox1.TabIndex = 1;
            this.placaMaskedTextBox1.Tag = "*PLACA";
            this.placaMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // anoMaskedTextBox2
            // 
            this.anoMaskedTextBox2.Location = new System.Drawing.Point(52, 134);
            this.anoMaskedTextBox2.Mask = "0000";
            this.anoMaskedTextBox2.Name = "anoMaskedTextBox2";
            this.anoMaskedTextBox2.Size = new System.Drawing.Size(121, 20);
            this.anoMaskedTextBox2.TabIndex = 7;
            this.anoMaskedTextBox2.Tag = "*ANO";
            // 
            // marcaComboBox1
            // 
            this.marcaComboBox1.FormattingEnabled = true;
            this.marcaComboBox1.Location = new System.Drawing.Point(52, 62);
            this.marcaComboBox1.Name = "marcaComboBox1";
            this.marcaComboBox1.Size = new System.Drawing.Size(121, 21);
            this.marcaComboBox1.TabIndex = 3;
            this.marcaComboBox1.Tag = "*";
            this.marcaComboBox1.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox1_SelectedIndexChanged);
            // 
            // modeloComboBox2
            // 
            this.modeloComboBox2.FormattingEnabled = true;
            this.modeloComboBox2.Location = new System.Drawing.Point(52, 98);
            this.modeloComboBox2.Name = "modeloComboBox2";
            this.modeloComboBox2.Size = new System.Drawing.Size(121, 21);
            this.modeloComboBox2.TabIndex = 5;
            this.modeloComboBox2.Tag = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustível";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Câmbio";
            // 
            // combustivelComboBox3
            // 
            this.combustivelComboBox3.FormattingEnabled = true;
            this.combustivelComboBox3.Location = new System.Drawing.Point(322, 62);
            this.combustivelComboBox3.Name = "combustivelComboBox3";
            this.combustivelComboBox3.Size = new System.Drawing.Size(121, 21);
            this.combustivelComboBox3.TabIndex = 11;
            this.combustivelComboBox3.Tag = "*";
            // 
            // cambioComboBox4
            // 
            this.cambioComboBox4.FormattingEnabled = true;
            this.cambioComboBox4.Location = new System.Drawing.Point(322, 98);
            this.cambioComboBox4.Name = "cambioComboBox4";
            this.cambioComboBox4.Size = new System.Drawing.Size(121, 21);
            this.cambioComboBox4.TabIndex = 13;
            this.cambioComboBox4.Tag = "*";
            // 
            // gravarButton1
            // 
            this.gravarButton1.Location = new System.Drawing.Point(479, 24);
            this.gravarButton1.Name = "gravarButton1";
            this.gravarButton1.Size = new System.Drawing.Size(75, 23);
            this.gravarButton1.TabIndex = 15;
            this.gravarButton1.Text = "Gravar";
            this.gravarButton1.UseVisualStyleBackColor = true;
            this.gravarButton1.Click += new System.EventHandler(this.gravarButton1_Click);
            // 
            // limparButton2
            // 
            this.limparButton2.Location = new System.Drawing.Point(479, 55);
            this.limparButton2.Name = "limparButton2";
            this.limparButton2.Size = new System.Drawing.Size(75, 23);
            this.limparButton2.TabIndex = 16;
            this.limparButton2.Text = "Limpar";
            this.limparButton2.UseVisualStyleBackColor = true;
            this.limparButton2.Click += new System.EventHandler(this.limparButton2_Click);
            // 
            // observacaoGroupBox1
            // 
            this.observacaoGroupBox1.Controls.Add(this.observacaoTextBox1);
            this.observacaoGroupBox1.Location = new System.Drawing.Point(7, 177);
            this.observacaoGroupBox1.Name = "observacaoGroupBox1";
            this.observacaoGroupBox1.Size = new System.Drawing.Size(547, 178);
            this.observacaoGroupBox1.TabIndex = 14;
            this.observacaoGroupBox1.TabStop = false;
            this.observacaoGroupBox1.Text = "Observação (300)";
            // 
            // observacaoTextBox1
            // 
            this.observacaoTextBox1.Location = new System.Drawing.Point(5, 16);
            this.observacaoTextBox1.Multiline = true;
            this.observacaoTextBox1.Name = "observacaoTextBox1";
            this.observacaoTextBox1.Size = new System.Drawing.Size(536, 156);
            this.observacaoTextBox1.TabIndex = 0;
            // 
            // corComboBox5
            // 
            this.corComboBox5.FormattingEnabled = true;
            this.corComboBox5.Location = new System.Drawing.Point(322, 29);
            this.corComboBox5.Name = "corComboBox5";
            this.corComboBox5.Size = new System.Drawing.Size(121, 21);
            this.corComboBox5.TabIndex = 9;
            this.corComboBox5.Tag = "*";
            // 
            // VeiculoErrorProvider
            // 
            this.VeiculoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.VeiculoErrorProvider.ContainerControl = this;
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 367);
            this.Controls.Add(this.corComboBox5);
            this.Controls.Add(this.observacaoGroupBox1);
            this.Controls.Add(this.limparButton2);
            this.Controls.Add(this.gravarButton1);
            this.Controls.Add(this.cambioComboBox4);
            this.Controls.Add(this.modeloComboBox2);
            this.Controls.Add(this.combustivelComboBox3);
            this.Controls.Add(this.marcaComboBox1);
            this.Controls.Add(this.anoMaskedTextBox2);
            this.Controls.Add(this.placaMaskedTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VeiculoForm";
            this.Text = "Cadastro de Veículos";
            this.observacaoGroupBox1.ResumeLayout(false);
            this.observacaoGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox2;
        private System.Windows.Forms.ComboBox marcaComboBox1;
        private System.Windows.Forms.ComboBox modeloComboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combustivelComboBox3;
        private System.Windows.Forms.ComboBox cambioComboBox4;
        private System.Windows.Forms.Button gravarButton1;
        private System.Windows.Forms.Button limparButton2;
        private System.Windows.Forms.GroupBox observacaoGroupBox1;
        private System.Windows.Forms.TextBox observacaoTextBox1;
        private System.Windows.Forms.ComboBox corComboBox5;
        private System.Windows.Forms.ErrorProvider VeiculoErrorProvider;
    }
}

