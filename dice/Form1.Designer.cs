
namespace dice
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
            this.btn_Brasser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Brasser
            // 
            this.btn_Brasser.Location = new System.Drawing.Point(12, 12);
            this.btn_Brasser.Name = "btn_Brasser";
            this.btn_Brasser.Size = new System.Drawing.Size(94, 29);
            this.btn_Brasser.TabIndex = 0;
            this.btn_Brasser.Text = "Brasser";
            this.btn_Brasser.UseVisualStyleBackColor = true;
            this.btn_Brasser.Click += new System.EventHandler(this.btn_Brasser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Brasser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Brasser;
    }
}

