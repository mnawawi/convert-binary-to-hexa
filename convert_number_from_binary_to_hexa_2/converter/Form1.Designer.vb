﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtBinary = New System.Windows.Forms.TextBox()
    Me.txtHexadecimal = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(36, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Binary"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 41)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(26, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Hex"
    '
    'txtBinary
    '
    Me.txtBinary.Location = New System.Drawing.Point(75, 12)
    Me.txtBinary.Name = "txtBinary"
    Me.txtBinary.Size = New System.Drawing.Size(343, 20)
    Me.txtBinary.TabIndex = 2
    '
    'txtHexadecimal
    '
    Me.txtHexadecimal.Location = New System.Drawing.Point(75, 38)
    Me.txtHexadecimal.Name = "txtHexadecimal"
    Me.txtHexadecimal.Size = New System.Drawing.Size(343, 20)
    Me.txtHexadecimal.TabIndex = 3
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(133, 80)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Convert"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(232, 80)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 5
    Me.Button2.Text = "Clear"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(381, 90)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(10, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "-"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(430, 111)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.txtHexadecimal)
    Me.Controls.Add(Me.txtBinary)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Converter"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtBinary As System.Windows.Forms.TextBox
  Friend WithEvents txtHexadecimal As System.Windows.Forms.TextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
