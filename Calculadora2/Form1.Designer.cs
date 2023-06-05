namespace Calculadora2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.somar = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dividir.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(264, 62);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(81, 50);
            this.dividir.TabIndex = 9;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.multiplicar.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(264, 118);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(81, 50);
            this.multiplicar.TabIndex = 10;
            this.multiplicar.Text = "X";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // subtrair
            // 
            this.subtrair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.subtrair.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrair.Location = new System.Drawing.Point(264, 174);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(81, 50);
            this.subtrair.TabIndex = 11;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = false;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // somar
            // 
            this.somar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.somar.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.Location = new System.Drawing.Point(264, 230);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(81, 50);
            this.somar.TabIndex = 12;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = false;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // button_res
            // 
            this.button_res.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_res.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_res.Location = new System.Drawing.Point(264, 286);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(81, 50);
            this.button_res.TabIndex = 13;
            this.button_res.Text = "=";
            this.button_res.UseVisualStyleBackColor = false;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 65);
            this.button1.TabIndex = 24;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(96, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 65);
            this.button2.TabIndex = 25;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(180, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 65);
            this.button3.TabIndex = 26;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 65);
            this.button4.TabIndex = 27;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(97, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 65);
            this.button5.TabIndex = 28;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(181, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 65);
            this.button6.TabIndex = 29;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 65);
            this.button7.TabIndex = 30;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(97, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 65);
            this.button8.TabIndex = 31;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(181, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 65);
            this.button9.TabIndex = 32;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.virgula.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.virgula.Location = new System.Drawing.Point(181, 275);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(78, 65);
            this.virgula.TabIndex = 33;
            this.virgula.Text = ",";
            this.virgula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.apagar.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.Location = new System.Drawing.Point(12, 275);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(78, 65);
            this.apagar.TabIndex = 34;
            this.apagar.Text = "C";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button0.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(96, 275);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(78, 65);
            this.button0.TabIndex = 35;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(13, 12);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(332, 44);
            this.resultado.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 348);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox resultado;
    }
}

