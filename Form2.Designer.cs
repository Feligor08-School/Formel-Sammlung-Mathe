namespace Formel_Sammlung
{
    partial class Form2
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
            groupBoxKörperAuswahl = new GroupBox();
            radioButtonKugel = new RadioButton();
            radioButtonPrisma = new RadioButton();
            radioButtonKegel = new RadioButton();
            radioButtonZylinder = new RadioButton();
            radioButtonQuader = new RadioButton();
            radioButtonWürfel = new RadioButton();
            groupBoxEingabe = new GroupBox();
            labelWert3 = new Label();
            labelWert2 = new Label();
            labelWert1 = new Label();
            txtEingabe3 = new TextBox();
            txtEingabe2 = new TextBox();
            txtEingabe1 = new TextBox();
            buttonBerechnen = new Button();
            buttonEingabeÄndern = new Button();
            buttonReset = new Button();
            buttonZeichnen = new Button();
            radioButtonVolumen = new RadioButton();
            radioButtonOberfläche = new RadioButton();
            pictureBox1 = new PictureBox();
            labelErgebnis = new Label();
            groupBoxKörperAuswahl.SuspendLayout();
            groupBoxEingabe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxKörperAuswahl
            // 
            groupBoxKörperAuswahl.Controls.Add(radioButtonKugel);
            groupBoxKörperAuswahl.Controls.Add(radioButtonPrisma);
            groupBoxKörperAuswahl.Controls.Add(radioButtonKegel);
            groupBoxKörperAuswahl.Controls.Add(radioButtonZylinder);
            groupBoxKörperAuswahl.Controls.Add(radioButtonQuader);
            groupBoxKörperAuswahl.Controls.Add(radioButtonWürfel);
            groupBoxKörperAuswahl.Location = new Point(24, 19);
            groupBoxKörperAuswahl.Name = "groupBoxKörperAuswahl";
            groupBoxKörperAuswahl.Size = new Size(189, 206);
            groupBoxKörperAuswahl.TabIndex = 0;
            groupBoxKörperAuswahl.TabStop = false;
            groupBoxKörperAuswahl.Text = "KörperAuswahl";
            // 
            // radioButtonKugel
            // 
            radioButtonKugel.AutoSize = true;
            radioButtonKugel.Location = new Point(6, 176);
            radioButtonKugel.Name = "radioButtonKugel";
            radioButtonKugel.Size = new Size(68, 24);
            radioButtonKugel.TabIndex = 5;
            radioButtonKugel.TabStop = true;
            radioButtonKugel.Text = "Kugel";
            radioButtonKugel.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrisma
            // 
            radioButtonPrisma.AutoSize = true;
            radioButtonPrisma.Location = new Point(6, 146);
            radioButtonPrisma.Name = "radioButtonPrisma";
            radioButtonPrisma.Size = new Size(74, 24);
            radioButtonPrisma.TabIndex = 4;
            radioButtonPrisma.TabStop = true;
            radioButtonPrisma.Text = "Prisma";
            radioButtonPrisma.UseVisualStyleBackColor = true;
            // 
            // radioButtonKegel
            // 
            radioButtonKegel.AutoSize = true;
            radioButtonKegel.Location = new Point(6, 116);
            radioButtonKegel.Name = "radioButtonKegel";
            radioButtonKegel.Size = new Size(68, 24);
            radioButtonKegel.TabIndex = 3;
            radioButtonKegel.TabStop = true;
            radioButtonKegel.Text = "Kegel";
            radioButtonKegel.UseVisualStyleBackColor = true;
            // 
            // radioButtonZylinder
            // 
            radioButtonZylinder.AutoSize = true;
            radioButtonZylinder.Location = new Point(6, 86);
            radioButtonZylinder.Name = "radioButtonZylinder";
            radioButtonZylinder.Size = new Size(84, 24);
            radioButtonZylinder.TabIndex = 2;
            radioButtonZylinder.TabStop = true;
            radioButtonZylinder.Text = "Zylinder";
            radioButtonZylinder.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuader
            // 
            radioButtonQuader.AutoSize = true;
            radioButtonQuader.Location = new Point(6, 56);
            radioButtonQuader.Name = "radioButtonQuader";
            radioButtonQuader.Size = new Size(79, 24);
            radioButtonQuader.TabIndex = 1;
            radioButtonQuader.TabStop = true;
            radioButtonQuader.Text = "Quader";
            radioButtonQuader.UseVisualStyleBackColor = true;
            // 
            // radioButtonWürfel
            // 
            radioButtonWürfel.AutoSize = true;
            radioButtonWürfel.Location = new Point(6, 26);
            radioButtonWürfel.Name = "radioButtonWürfel";
            radioButtonWürfel.Size = new Size(74, 24);
            radioButtonWürfel.TabIndex = 0;
            radioButtonWürfel.TabStop = true;
            radioButtonWürfel.Text = "Würfel";
            radioButtonWürfel.UseVisualStyleBackColor = true;
            // 
            // groupBoxEingabe
            // 
            groupBoxEingabe.Controls.Add(labelWert3);
            groupBoxEingabe.Controls.Add(labelWert2);
            groupBoxEingabe.Controls.Add(labelWert1);
            groupBoxEingabe.Controls.Add(txtEingabe3);
            groupBoxEingabe.Controls.Add(txtEingabe2);
            groupBoxEingabe.Controls.Add(txtEingabe1);
            groupBoxEingabe.Location = new Point(24, 231);
            groupBoxEingabe.Name = "groupBoxEingabe";
            groupBoxEingabe.Size = new Size(250, 125);
            groupBoxEingabe.TabIndex = 1;
            groupBoxEingabe.TabStop = false;
            groupBoxEingabe.Text = "Eingabe";
            // 
            // labelWert3
            // 
            labelWert3.AutoSize = true;
            labelWert3.Location = new Point(146, 99);
            labelWert3.Name = "labelWert3";
            labelWert3.Size = new Size(52, 20);
            labelWert3.TabIndex = 5;
            labelWert3.Text = "Wert 3";
            // 
            // labelWert2
            // 
            labelWert2.AutoSize = true;
            labelWert2.Location = new Point(146, 66);
            labelWert2.Name = "labelWert2";
            labelWert2.Size = new Size(52, 20);
            labelWert2.TabIndex = 4;
            labelWert2.Text = "Wert 2";
            // 
            // labelWert1
            // 
            labelWert1.AutoSize = true;
            labelWert1.Location = new Point(146, 33);
            labelWert1.Name = "labelWert1";
            labelWert1.Size = new Size(52, 20);
            labelWert1.TabIndex = 3;
            labelWert1.Text = "Wert 1";
            // 
            // txtEingabe3
            // 
            txtEingabe3.Location = new Point(6, 92);
            txtEingabe3.Name = "txtEingabe3";
            txtEingabe3.Size = new Size(125, 27);
            txtEingabe3.TabIndex = 2;
            // 
            // txtEingabe2
            // 
            txtEingabe2.Location = new Point(6, 59);
            txtEingabe2.Name = "txtEingabe2";
            txtEingabe2.Size = new Size(125, 27);
            txtEingabe2.TabIndex = 1;
            // 
            // txtEingabe1
            // 
            txtEingabe1.Location = new Point(8, 26);
            txtEingabe1.Name = "txtEingabe1";
            txtEingabe1.Size = new Size(125, 27);
            txtEingabe1.TabIndex = 0;
            // 
            // buttonBerechnen
            // 
            buttonBerechnen.Location = new Point(170, 409);
            buttonBerechnen.Name = "buttonBerechnen";
            buttonBerechnen.Size = new Size(94, 29);
            buttonBerechnen.TabIndex = 2;
            buttonBerechnen.Text = "Berechnen";
            buttonBerechnen.UseVisualStyleBackColor = true;
            buttonBerechnen.Click += buttonBerechnen_Click_1;
            // 
            // buttonEingabeÄndern
            // 
            buttonEingabeÄndern.Location = new Point(30, 370);
            buttonEingabeÄndern.Name = "buttonEingabeÄndern";
            buttonEingabeÄndern.Size = new Size(132, 29);
            buttonEingabeÄndern.TabIndex = 3;
            buttonEingabeÄndern.Text = "Eingabe Ändern";
            buttonEingabeÄndern.UseVisualStyleBackColor = true;
            buttonEingabeÄndern.Click += buttonEingabeÄndern_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(170, 370);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click_1;
            // 
            // buttonZeichnen
            // 
            buttonZeichnen.Location = new Point(30, 409);
            buttonZeichnen.Name = "buttonZeichnen";
            buttonZeichnen.Size = new Size(132, 29);
            buttonZeichnen.TabIndex = 5;
            buttonZeichnen.Text = "Zeichnen";
            buttonZeichnen.UseVisualStyleBackColor = true;
            buttonZeichnen.Click += buttonZeichnen_Click_1;
            // 
            // radioButtonVolumen
            // 
            radioButtonVolumen.AutoSize = true;
            radioButtonVolumen.Location = new Point(284, 332);
            radioButtonVolumen.Name = "radioButtonVolumen";
            radioButtonVolumen.Size = new Size(88, 24);
            radioButtonVolumen.TabIndex = 6;
            radioButtonVolumen.TabStop = true;
            radioButtonVolumen.Text = "Volumen";
            radioButtonVolumen.UseVisualStyleBackColor = true;
            // 
            // radioButtonOberfläche
            // 
            radioButtonOberfläche.AutoSize = true;
            radioButtonOberfläche.Location = new Point(284, 362);
            radioButtonOberfläche.Name = "radioButtonOberfläche";
            radioButtonOberfläche.Size = new Size(103, 24);
            radioButtonOberfläche.TabIndex = 7;
            radioButtonOberfläche.TabStop = true;
            radioButtonOberfläche.Text = "Oberfläche";
            radioButtonOberfläche.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Location = new Point(284, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 281);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // labelErgebnis
            // 
            labelErgebnis.AutoSize = true;
            labelErgebnis.Location = new Point(453, 322);
            labelErgebnis.Name = "labelErgebnis";
            labelErgebnis.Size = new Size(0, 20);
            labelErgebnis.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErgebnis);
            Controls.Add(pictureBox1);
            Controls.Add(radioButtonOberfläche);
            Controls.Add(radioButtonVolumen);
            Controls.Add(buttonZeichnen);
            Controls.Add(buttonReset);
            Controls.Add(buttonEingabeÄndern);
            Controls.Add(buttonBerechnen);
            Controls.Add(groupBoxEingabe);
            Controls.Add(groupBoxKörperAuswahl);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBoxKörperAuswahl.ResumeLayout(false);
            groupBoxKörperAuswahl.PerformLayout();
            groupBoxEingabe.ResumeLayout(false);
            groupBoxEingabe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxKörperAuswahl;
        private RadioButton radioButtonKugel;
        private RadioButton radioButtonPrisma;
        private RadioButton radioButtonKegel;
        private RadioButton radioButtonZylinder;
        private RadioButton radioButtonQuader;
        private RadioButton radioButtonWürfel;
        private GroupBox groupBoxEingabe;
        private Label labelWert3;
        private Label labelWert2;
        private Label labelWert1;
        private TextBox txtEingabe3;
        private TextBox txtEingabe2;
        private TextBox txtEingabe1;
        private Button buttonBerechnen;
        private Button buttonEingabeÄndern;
        private Button buttonReset;
        private Button buttonZeichnen;
        private RadioButton radioButtonVolumen;
        private RadioButton radioButtonOberfläche;
        private PictureBox pictureBox1;
        private Label labelErgebnis;
    }
}