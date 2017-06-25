/*
 * Created by SharpDevelop.
 * User: Vitalii.Zotov
 * Date: 23.06.2017
 * Time: 20:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace unfolding
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox diameterTextBox;
		private System.Windows.Forms.TextBox thicknessTextBox;
		private System.Windows.Forms.ComboBox chamferTopComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox chamferBotComboBox;
		private System.Windows.Forms.Label Angle;
		private System.Windows.Forms.TextBox angleTrimTextBox;
		private System.Windows.Forms.TextBox angleRotateTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox nPartTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox angleSectorTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonDo;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.diameterTextBox = new System.Windows.Forms.TextBox();
			this.thicknessTextBox = new System.Windows.Forms.TextBox();
			this.chamferTopComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chamferBotComboBox = new System.Windows.Forms.ComboBox();
			this.Angle = new System.Windows.Forms.Label();
			this.angleTrimTextBox = new System.Windows.Forms.TextBox();
			this.angleRotateTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nPartTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.angleSectorTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonDo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Diameter";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thickness";
			// 
			// diameterTextBox
			// 
			this.diameterTextBox.Location = new System.Drawing.Point(100, 13);
			this.diameterTextBox.Name = "diameterTextBox";
			this.diameterTextBox.Size = new System.Drawing.Size(100, 20);
			this.diameterTextBox.TabIndex = 2;
			// 
			// thicknessTextBox
			// 
			this.thicknessTextBox.Location = new System.Drawing.Point(100, 40);
			this.thicknessTextBox.Name = "thicknessTextBox";
			this.thicknessTextBox.Size = new System.Drawing.Size(100, 20);
			this.thicknessTextBox.TabIndex = 3;
			// 
			// chamferTopComboBox
			// 
			this.chamferTopComboBox.FormattingEnabled = true;
			this.chamferTopComboBox.Items.AddRange(new object[] {
			"External",
			"Internal"});
			this.chamferTopComboBox.Location = new System.Drawing.Point(100, 67);
			this.chamferTopComboBox.Name = "chamferTopComboBox";
			this.chamferTopComboBox.Size = new System.Drawing.Size(100, 21);
			this.chamferTopComboBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Chamfer top";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Chamfer bot";
			// 
			// chamferBotComboBox
			// 
			this.chamferBotComboBox.FormattingEnabled = true;
			this.chamferBotComboBox.Items.AddRange(new object[] {
			"External",
			"Internal"});
			this.chamferBotComboBox.Location = new System.Drawing.Point(100, 94);
			this.chamferBotComboBox.Name = "chamferBotComboBox";
			this.chamferBotComboBox.Size = new System.Drawing.Size(100, 21);
			this.chamferBotComboBox.TabIndex = 8;
			// 
			// Angle
			// 
			this.Angle.Location = new System.Drawing.Point(13, 124);
			this.Angle.Name = "Angle";
			this.Angle.Size = new System.Drawing.Size(68, 17);
			this.Angle.TabIndex = 9;
			this.Angle.Text = "Angle trim";
			// 
			// angleTrimTextBox
			// 
			this.angleTrimTextBox.Location = new System.Drawing.Point(100, 121);
			this.angleTrimTextBox.Name = "angleTrimTextBox";
			this.angleTrimTextBox.Size = new System.Drawing.Size(100, 20);
			this.angleTrimTextBox.TabIndex = 10;
			// 
			// angleRotateTextBox
			// 
			this.angleRotateTextBox.Location = new System.Drawing.Point(100, 147);
			this.angleRotateTextBox.Name = "angleRotateTextBox";
			this.angleRotateTextBox.Size = new System.Drawing.Size(100, 20);
			this.angleRotateTextBox.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Angle rotate";
			// 
			// nPartTextBox
			// 
			this.nPartTextBox.Location = new System.Drawing.Point(100, 199);
			this.nPartTextBox.Name = "nPartTextBox";
			this.nPartTextBox.Size = new System.Drawing.Size(100, 20);
			this.nPartTextBox.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 202);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "N part ";
			// 
			// angleSectorTextBox
			// 
			this.angleSectorTextBox.Location = new System.Drawing.Point(100, 173);
			this.angleSectorTextBox.Name = "angleSectorTextBox";
			this.angleSectorTextBox.Size = new System.Drawing.Size(100, 20);
			this.angleSectorTextBox.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Angle sector";
			// 
			// buttonDo
			// 
			this.buttonDo.Location = new System.Drawing.Point(125, 237);
			this.buttonDo.Name = "buttonDo";
			this.buttonDo.Size = new System.Drawing.Size(75, 23);
			this.buttonDo.TabIndex = 17;
			this.buttonDo.Text = "Do";
			this.buttonDo.UseVisualStyleBackColor = true;
			this.buttonDo.Click += new System.EventHandler(this.ButtonDoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 273);
			this.Controls.Add(this.buttonDo);
			this.Controls.Add(this.angleSectorTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nPartTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.angleRotateTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.angleTrimTextBox);
			this.Controls.Add(this.Angle);
			this.Controls.Add(this.chamferBotComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.chamferTopComboBox);
			this.Controls.Add(this.thicknessTextBox);
			this.Controls.Add(this.diameterTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "unfolding";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
