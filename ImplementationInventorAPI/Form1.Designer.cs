namespace ImplementationInventorAPI
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
            connect = new Button();
            extrude = new Button();
            SuspendLayout();
            // 
            // connect
            // 
            connect.Location = new Point(130, 141);
            connect.Name = "connect";
            connect.Size = new Size(175, 97);
            connect.TabIndex = 0;
            connect.Text = "Connect";
            connect.UseVisualStyleBackColor = true;
            connect.Click += connect_Click;
            // 
            // extrude
            // 
            extrude.Location = new Point(443, 141);
            extrude.Name = "extrude";
            extrude.Size = new Size(175, 97);
            extrude.TabIndex = 1;
            extrude.Text = "Extrude";
            extrude.UseVisualStyleBackColor = true;
            extrude.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(extrude);
            Controls.Add(connect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button connect;
        private Button extrude;
    }
}
