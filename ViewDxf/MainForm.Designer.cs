/*
 * Created by SharpDevelop.
 * User: YZHOU
 * Date: 2012/8/17
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ViewDxf
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.canvas1 = new SharpDxf.Viewer.Canvas("AutoCad2004.dxf");
			this.SuspendLayout();
			// 
			// canvas1
			// 
			this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.canvas1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.canvas1.Location = new System.Drawing.Point(28, 26);
			this.canvas1.Name = "canvas1";
			this.canvas1.Size = new System.Drawing.Size(229, 212);
			this.canvas1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.canvas1);
			this.Name = "MainForm";
			this.Text = "ViewDxf";
			this.ResumeLayout(false);
		}
		private SharpDxf.Viewer.Canvas canvas1;
	}
}
