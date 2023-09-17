namespace PainoIndeksi
{
    partial class BMIForm
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
            label2 = new Label();
            painoTB = new TextBox();
            pituusTB = new TextBox();
            LaskeBT = new Button();
            vastausLB = new Label();
            kuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            label2.Click += label2_Click;
            // 
            // painoTB
            // 
            painoTB.Location = new Point(150, 23);
            painoTB.Name = "painoTB";
            painoTB.Size = new Size(100, 33);
            painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            pituusTB.Location = new Point(150, 71);
            pituusTB.Name = "pituusTB";
            pituusTB.Size = new Size(100, 33);
            pituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(12, 126);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(238, 31);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(12, 182);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(76, 25);
            vastausLB.TabIndex = 5;
            vastausLB.Text = "Vastaus";
            vastausLB.Visible = false;
            // 
            // kuvausLB
            // 
            kuvausLB.AutoSize = true;
            kuvausLB.Location = new Point(12, 221);
            kuvausLB.Name = "kuvausLB";
            kuvausLB.Size = new Size(72, 25);
            kuvausLB.TabIndex = 6;
            kuvausLB.Text = "Kuvaus";
            kuvausLB.Visible = false;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 318);
            Controls.Add(kuvausLB);
            Controls.Add(vastausLB);
            Controls.Add(LaskeBT);
            Controls.Add(pituusTB);
            Controls.Add(painoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "BMIForm";
            Text = "Painoindeksilaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button LaskeBT;
        private Label vastausLB;
        private Label kuvausLB;
    }
}