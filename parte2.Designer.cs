/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 23/10/2024
 * Time: 08:07 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectoo
{
	partial class parte2
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
			this.lblNombreCompleto = new System.Windows.Forms.Label();
			this.lblRFC = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNombreCompleto
			// 
			this.lblNombreCompleto.Location = new System.Drawing.Point(13, 13);
			this.lblNombreCompleto.Name = "lblNombreCompleto";
			this.lblNombreCompleto.Size = new System.Drawing.Size(259, 37);
			this.lblNombreCompleto.TabIndex = 0;
			this.lblNombreCompleto.Text = "Nombre";
			// 
			// lblRFC
			// 
			this.lblRFC.Location = new System.Drawing.Point(13, 50);
			this.lblRFC.Name = "lblRFC";
			this.lblRFC.Size = new System.Drawing.Size(100, 23);
			this.lblRFC.TabIndex = 1;
			this.lblRFC.Text = "rfc";
			// 
			// parte2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblRFC);
			this.Controls.Add(this.lblNombreCompleto);
			this.Name = "parte2";
			this.Text = "parte2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblRFC;
		private System.Windows.Forms.Label lblNombreCompleto;
	}
}
