/*
 * Created by SharpDevelop.
 * User: YZHOU
 * Date: 2012/8/17
 * Time: 13:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using SharpDxf;

namespace SharpDxf.Viewer
{
	/// <summary>
	/// Description of Canvas.
	/// </summary>
	public partial class Canvas : UserControl
	{
		private bool mouse_down = false;
		
		// Dxf Document Objects
		DxfDocument dxf = new DxfDocument();
		
		public Canvas(string dxf_path)
		{
			InitializeComponent();
			dxf.Load(dxf_path);
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			//dxf.Load();
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Font ver = new Font("Arial",16);
			e.Graphics.DrawString( dxf.Version.ToString(),ver,Brushes.Red,10,10);
			base.OnPaint(e);
		}
		
		protected override void OnDoubleClick(EventArgs e)
		{
			MessageBox.Show("Double Click");
		}
		
		public Point s_pt = Point.Empty;
		public Point e_pt = Point.Empty;
		
		
		
		void CanvasMouseDown(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Hand;
			s_pt  = e.Location;
		}
		
		void CanvasMouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
			e_pt = e.Location;
			if ( s_pt != Point.Empty)
				MessageBox.Show("From "+s_pt.ToString()+"to "+e_pt.ToString());
		}
			
		void CanvasMouseWheel(object sender, MouseEventArgs e)
		{
			double zoom = e.Delta > 0 ? .2 : -.2;
			MessageBox.Show("Wheel "+zoom);
		}
	}
}
