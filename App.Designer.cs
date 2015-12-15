namespace jimney
{
    partial class App
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
            this.overlayControlMain = new jimney.OverlayControl();
            this.SuspendLayout();
            // 
            // overlayControlMain
            // 
            this.overlayControlMain.Enabled = false;
            this.overlayControlMain.Location = new System.Drawing.Point(0, 0);
            this.overlayControlMain.Name = "overlayControlMain";
            this.overlayControlMain.Size = new System.Drawing.Size(800, 600);
            this.overlayControlMain.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.overlayControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.App_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private OverlayControl overlayControlMain;
    }
}

