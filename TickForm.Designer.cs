namespace BtcTick
{
    partial class TickForm
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
            this.webBrowserGauge = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserGauge
            // 
            this.webBrowserGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGauge.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserGauge.Location = new System.Drawing.Point(0, 0);
            this.webBrowserGauge.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGauge.Name = "webBrowserGauge";
            this.webBrowserGauge.ScriptErrorsSuppressed = true;
            this.webBrowserGauge.ScrollBarsEnabled = false;
            this.webBrowserGauge.Size = new System.Drawing.Size(201, 185);
            this.webBrowserGauge.TabIndex = 12;
            this.webBrowserGauge.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "http://bitcoincharts.com/charts/chart.png?m=bitstampUSD&v=1&t=S&noheader=1&height" +
    "=170&width=170&r=2";
            this.pictureBox1.Location = new System.Drawing.Point(45, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(28, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(137, 142);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.Url = new System.Uri("http://bitcoincharts.com/markets/bitstampUSD.html", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(10, 13);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(32, 13);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Error";
            this.labelStatus.Visible = false;
            // 
            // TickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 185);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.webBrowserGauge);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TickForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BTC Ticker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TickForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserGauge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelStatus;
    }
}

