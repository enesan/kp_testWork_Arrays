namespace Kontrosha
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
            this.Sozdat_knopka = new System.Windows.Forms.Button();
            this.dim1MassivLabel = new System.Windows.Forms.Label();
            this.dim2MassivLabel = new System.Windows.Forms.Label();
            this.stupMassivLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sozdat_knopka
            // 
            this.Sozdat_knopka.Location = new System.Drawing.Point(263, 26);
            this.Sozdat_knopka.Name = "Sozdat_knopka";
            this.Sozdat_knopka.Size = new System.Drawing.Size(170, 102);
            this.Sozdat_knopka.TabIndex = 0;
            this.Sozdat_knopka.Text = "Создать массивы";
            this.Sozdat_knopka.UseVisualStyleBackColor = true;
            this.Sozdat_knopka.Click += new System.EventHandler(this.Sozdat_knopka_Click);
            // 
            // dim1MassivLabel
            // 
            this.dim1MassivLabel.AutoSize = true;
            this.dim1MassivLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dim1MassivLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dim1MassivLabel.Location = new System.Drawing.Point(12, 169);
            this.dim1MassivLabel.Name = "dim1MassivLabel";
            this.dim1MassivLabel.Size = new System.Drawing.Size(313, 19);
            this.dim1MassivLabel.TabIndex = 1;
            this.dim1MassivLabel.Text = "Отсортированный одномерный массив:";
            // 
            // dim2MassivLabel
            // 
            this.dim2MassivLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dim2MassivLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dim2MassivLabel.Location = new System.Drawing.Point(12, 255);
            this.dim2MassivLabel.Name = "dim2MassivLabel";
            this.dim2MassivLabel.Size = new System.Drawing.Size(678, 56);
            this.dim2MassivLabel.TabIndex = 2;
            this.dim2MassivLabel.Text = "Отсоротированный двумерный массив:";
            // 
            // stupMassivLabel
            // 
            this.stupMassivLabel.AutoSize = true;
            this.stupMassivLabel.BackColor = System.Drawing.SystemColors.Control;
            this.stupMassivLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stupMassivLabel.Location = new System.Drawing.Point(12, 345);
            this.stupMassivLabel.Name = "stupMassivLabel";
            this.stupMassivLabel.Size = new System.Drawing.Size(314, 19);
            this.stupMassivLabel.TabIndex = 3;
            this.stupMassivLabel.Text = "Отсортированный ступенчатый массив:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stupMassivLabel);
            this.Controls.Add(this.dim2MassivLabel);
            this.Controls.Add(this.dim1MassivLabel);
            this.Controls.Add(this.Sozdat_knopka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Sozdat_knopka;
        private Label dim1MassivLabel;
        private Label dim2MassivLabel;
        private Label stupMassivLabel;
    }
}