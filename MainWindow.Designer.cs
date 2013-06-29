namespace PhotoboothMono
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStartKiosk = new System.Windows.Forms.Button();
			this.txtCaptureDirectory = new System.Windows.Forms.TextBox();
			this.txtCaptureExtension = new System.Windows.Forms.TextBox();
			this.txtPreviewSeconds = new System.Windows.Forms.NumericUpDown();
			this.txtFontName = new System.Windows.Forms.TextBox();
			this.txtFontSize = new System.Windows.Forms.TextBox();
			this.txtPrompt = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPreviewSeconds)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.txtPrompt, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.txtFontSize, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtFontName, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtPreviewSeconds, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStartKiosk, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.txtCaptureDirectory, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCaptureExtension, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 261);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 90);
			this.label6.TabIndex = 4;
			this.label6.Text = "Prompt Text:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Capture Extension:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Preview Seconds:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(68, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Font:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Font Size:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Capture Directory:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnStartKiosk
			// 
			this.btnStartKiosk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartKiosk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.btnStartKiosk, 2);
			this.btnStartKiosk.Location = new System.Drawing.Point(3, 223);
			this.btnStartKiosk.Name = "btnStartKiosk";
			this.btnStartKiosk.Size = new System.Drawing.Size(408, 35);
			this.btnStartKiosk.TabIndex = 5;
			this.btnStartKiosk.Text = "Start Kiosk";
			this.btnStartKiosk.UseVisualStyleBackColor = true;
			this.btnStartKiosk.Click += new System.EventHandler(this.btnStartKiosk_Click);
			// 
			// txtCaptureDirectory
			// 
			this.txtCaptureDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCaptureDirectory.Location = new System.Drawing.Point(105, 3);
			this.txtCaptureDirectory.Name = "txtCaptureDirectory";
			this.txtCaptureDirectory.Size = new System.Drawing.Size(306, 20);
			this.txtCaptureDirectory.TabIndex = 6;
			// 
			// txtCaptureExtension
			// 
			this.txtCaptureExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCaptureExtension.Location = new System.Drawing.Point(105, 29);
			this.txtCaptureExtension.Name = "txtCaptureExtension";
			this.txtCaptureExtension.Size = new System.Drawing.Size(306, 20);
			this.txtCaptureExtension.TabIndex = 7;
			// 
			// txtPreviewSeconds
			// 
			this.txtPreviewSeconds.Location = new System.Drawing.Point(105, 55);
			this.txtPreviewSeconds.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.txtPreviewSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtPreviewSeconds.Name = "txtPreviewSeconds";
			this.txtPreviewSeconds.Size = new System.Drawing.Size(55, 20);
			this.txtPreviewSeconds.TabIndex = 1;
			this.txtPreviewSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtFontName
			// 
			this.txtFontName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFontName.Location = new System.Drawing.Point(105, 81);
			this.txtFontName.Name = "txtFontName";
			this.txtFontName.Size = new System.Drawing.Size(306, 20);
			this.txtFontName.TabIndex = 8;
			// 
			// txtFontSize
			// 
			this.txtFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFontSize.Location = new System.Drawing.Point(105, 107);
			this.txtFontSize.Name = "txtFontSize";
			this.txtFontSize.Size = new System.Drawing.Size(306, 20);
			this.txtFontSize.TabIndex = 9;
			// 
			// txtPrompt
			// 
			this.txtPrompt.AcceptsReturn = true;
			this.txtPrompt.AcceptsTab = true;
			this.txtPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrompt.Location = new System.Drawing.Point(105, 133);
			this.txtPrompt.Multiline = true;
			this.txtPrompt.Name = "txtPrompt";
			this.txtPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPrompt.Size = new System.Drawing.Size(306, 84);
			this.txtPrompt.TabIndex = 10;
			this.txtPrompt.WordWrap = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 281);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "Photobooth";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPreviewSeconds)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnStartKiosk;
		private System.Windows.Forms.TextBox txtPrompt;
		private System.Windows.Forms.TextBox txtFontSize;
		private System.Windows.Forms.TextBox txtFontName;
		private System.Windows.Forms.NumericUpDown txtPreviewSeconds;
		private System.Windows.Forms.TextBox txtCaptureDirectory;
		private System.Windows.Forms.TextBox txtCaptureExtension;
	}
}

