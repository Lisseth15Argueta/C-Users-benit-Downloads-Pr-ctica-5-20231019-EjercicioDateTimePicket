namespace ejercicioDateTimePicker
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
            label1 = new Label();
            TimePickerEdad = new DateTimePicker();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 7);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Verificacion de edad";
            // 
            // TimePickerEdad
            // 
            TimePickerEdad.CustomFormat = " dddd dd MMMM yy";
            TimePickerEdad.Format = DateTimePickerFormat.Custom;
            TimePickerEdad.Location = new Point(185, 46);
            TimePickerEdad.Margin = new Padding(3, 2, 3, 2);
            TimePickerEdad.Name = "TimePickerEdad";
            TimePickerEdad.Size = new Size(339, 23);
            TimePickerEdad.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(280, 99);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 22);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular edad";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(218, 141);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(237, 21);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Aqui ira la validacion de edad";
            lblResultado.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(TimePickerEdad);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker TimePickerEdad;
        private Button btnCalcular;
        private Label lblResultado;
    }
}