namespace INF_UE_Perfekte_Zahlen
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
            lbOutput = new ListBox();
            btStart = new Button();
            lbOb = new ListBox();
            lbOd = new ListBox();
            lbOe = new ListBox();
            lbOa = new ListBox();
            SuspendLayout();
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 32;
            lbOutput.Location = new Point(87, 465);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(444, 164);
            lbOutput.TabIndex = 0;
            // 
            // btStart
            // 
            btStart.Location = new Point(43, 32);
            btStart.Name = "btStart";
            btStart.Size = new Size(150, 46);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // lbOb
            // 
            lbOb.FormattingEnabled = true;
            lbOb.ItemHeight = 32;
            lbOb.Location = new Point(87, 286);
            lbOb.Name = "lbOb";
            lbOb.Size = new Size(444, 164);
            lbOb.TabIndex = 2;
            // 
            // lbOd
            // 
            lbOd.FormattingEnabled = true;
            lbOd.ItemHeight = 32;
            lbOd.Location = new Point(629, 94);
            lbOd.Name = "lbOd";
            lbOd.Size = new Size(444, 164);
            lbOd.TabIndex = 3;
            // 
            // lbOe
            // 
            lbOe.FormattingEnabled = true;
            lbOe.ItemHeight = 32;
            lbOe.Location = new Point(629, 286);
            lbOe.Name = "lbOe";
            lbOe.Size = new Size(444, 164);
            lbOe.TabIndex = 4;
            // 
            // lbOa
            // 
            lbOa.FormattingEnabled = true;
            lbOa.ItemHeight = 32;
            lbOa.Location = new Point(87, 94);
            lbOa.Name = "lbOa";
            lbOa.Size = new Size(444, 164);
            lbOa.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 705);
            Controls.Add(lbOa);
            Controls.Add(lbOe);
            Controls.Add(lbOd);
            Controls.Add(lbOb);
            Controls.Add(btStart);
            Controls.Add(lbOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbOutput;
        private Button btStart;
        private ListBox lbOb;
        private ListBox lbOd;
        private ListBox lbOe;
        private ListBox lbOa;
    }
}
