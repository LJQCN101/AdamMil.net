/*
AdamMil.Security.UI is a .NET library providing common user interface widgets
for OpenPGP-based software.
Copyright (C) 2008-2013 Adam Milazzo (http://www.adammil.net/)

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*/

namespace AdamMil.Security.UI
{
  partial class ChangePasswordForm
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
      if(disposing && (components != null))
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
      System.Windows.Forms.Label lblPass;
      System.Windows.Forms.Label lblHelp;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
      System.Windows.Forms.Label label1;
      System.Windows.Forms.Button btnOK;
      System.Windows.Forms.Button btnCancel;
      this.lblStrength = new System.Windows.Forms.Label();
      this.pass2 = new AdamMil.Security.UI.SecureTextBox();
      this.pass1 = new AdamMil.Security.UI.SecureTextBox();
      lblPass = new System.Windows.Forms.Label();
      lblHelp = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      btnOK = new System.Windows.Forms.Button();
      btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      //
      // lblPass
      //
      lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      lblPass.Location = new System.Drawing.Point(1, 139);
      lblPass.Name = "lblPass";
      lblPass.Size = new System.Drawing.Size(117, 19);
      lblPass.TabIndex = 1;
      lblPass.Text = "New Password:";
      lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      //
      // lblHelp
      //
      lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      lblHelp.Location = new System.Drawing.Point(7, 7);
      lblHelp.Name = "lblHelp";
      lblHelp.Size = new System.Drawing.Size(669, 128);
      lblHelp.TabIndex = 0;
      lblHelp.Text = resources.GetString("lblHelp.Text");
      //
      // label1
      //
      label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      label1.Location = new System.Drawing.Point(1, 166);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(117, 19);
      label1.TabIndex = 4;
      label1.Text = "Repeat Password:";
      label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      //
      // btnOK
      //
      btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      btnOK.Location = new System.Drawing.Point(263, 194);
      btnOK.Name = "btnOK";
      btnOK.Size = new System.Drawing.Size(75, 23);
      btnOK.TabIndex = 6;
      btnOK.Text = "&OK";
      btnOK.UseVisualStyleBackColor = true;
      btnOK.Click += new System.EventHandler(this.btnOK_Click);
      //
      // btnCancel
      //
      btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      btnCancel.Location = new System.Drawing.Point(344, 194);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new System.Drawing.Size(75, 23);
      btnCancel.TabIndex = 7;
      btnCancel.Text = "&Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      //
      // lblStrength
      //
      this.lblStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblStrength.Location = new System.Drawing.Point(336, 139);
      this.lblStrength.Name = "lblStrength";
      this.lblStrength.Size = new System.Drawing.Size(330, 19);
      this.lblStrength.TabIndex = 3;
      this.lblStrength.Text = "Password strength:";
      this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // pass2
      //
      this.pass2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.pass2.ImeMode = System.Windows.Forms.ImeMode.Disable;
      this.pass2.Location = new System.Drawing.Point(118, 165);
      this.pass2.Name = "pass2";
      this.pass2.RestrictToLowAscii = true;
      this.pass2.Size = new System.Drawing.Size(211, 21);
      this.pass2.TabIndex = 5;
      this.pass2.UseSystemPasswordChar = true;
      //
      // pass1
      //
      this.pass1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.pass1.ImeMode = System.Windows.Forms.ImeMode.Disable;
      this.pass1.Location = new System.Drawing.Point(118, 138);
      this.pass1.Name = "pass1";
      this.pass1.RestrictToLowAscii = true;
      this.pass1.Size = new System.Drawing.Size(211, 21);
      this.pass1.TabIndex = 2;
      this.pass1.UseSystemPasswordChar = true;
      this.pass1.TextChanged += new System.EventHandler(this.pass1_TextChanged);
      //
      // ChangePasswordForm
      //
      this.AcceptButton = btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = btnCancel;
      this.ClientSize = new System.Drawing.Size(683, 223);
      this.Controls.Add(btnCancel);
      this.Controls.Add(btnOK);
      this.Controls.Add(this.lblStrength);
      this.Controls.Add(this.pass2);
      this.Controls.Add(label1);
      this.Controls.Add(this.pass1);
      this.Controls.Add(lblPass);
      this.Controls.Add(lblHelp);
      this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChangePasswordForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Change Password";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private SecureTextBox pass1;
    private SecureTextBox pass2;
    private System.Windows.Forms.Label lblStrength;
  }
}