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
using SharpDxf;
using System.Windows.Forms;

namespace SharpDxf.Viewer
{
	/// <summary>
	/// Description of Canvas.
	/// </summary>
	public partial class Canvas : UserControl
	{
		DxfDocument dxf = new DxfDocument();
		public Canvas(string dxf_path)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dxf.Load(dxf_path);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			Font ver = new Font("Arial",16);
			e.Graphics.DrawString( dxf.Version.ToString(),ver,Brushes.Red,10,10);
			base.OnPaint(e);
		}
	}
}
