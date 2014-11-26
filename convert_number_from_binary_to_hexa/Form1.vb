Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " GUI "

  Public Sub New()
    MyBase.New()


    InitializeComponent()



  End Sub


  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub


  Private components As System.ComponentModel.IContainer


  Public WithEvents binText As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Public WithEvents hexText As System.Windows.Forms.TextBox

  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.binText = New System.Windows.Forms.TextBox()
    Me.hexText = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'binText
    '
    Me.binText.AcceptsReturn = True
    Me.binText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.binText.BackColor = System.Drawing.SystemColors.Window
    Me.binText.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.binText.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.binText.ForeColor = System.Drawing.SystemColors.WindowText
    Me.binText.Location = New System.Drawing.Point(80, 6)
    Me.binText.MaxLength = 0
    Me.binText.Name = "binText"
    Me.binText.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.binText.Size = New System.Drawing.Size(497, 20)
    Me.binText.TabIndex = 15
    '
    'hexText
    '
    Me.hexText.AcceptsReturn = True
    Me.hexText.BackColor = System.Drawing.SystemColors.Window
    Me.hexText.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.hexText.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.hexText.ForeColor = System.Drawing.SystemColors.WindowText
    Me.hexText.Location = New System.Drawing.Point(80, 32)
    Me.hexText.MaxLength = 0
    Me.hexText.Name = "hexText"
    Me.hexText.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.hexText.Size = New System.Drawing.Size(168, 20)
    Me.hexText.TabIndex = 13
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(36, 13)
    Me.Label1.TabIndex = 16
    Me.Label1.Text = "Binary"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(15, 35)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(32, 13)
    Me.Label2.TabIndex = 17
    Me.Label2.Text = "Hexa"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(440, 35)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 18
    Me.Button1.Text = "Clear"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(584, 70)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.binText)
    Me.Controls.Add(Me.hexText)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region

  Private Sub Value_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hexText.TextChanged, binText.TextChanged
    HexaDisplayValue(sender)
  End Sub


  Private Sub HexaDisplayValue(ByVal binValue As TextBox)

    Static ie As Boolean = False
    If ie Then Exit Sub
    ie = True


    Dim value As Long
    Try
      Select Case binValue.Name

        Case "binText"
          value = BinaryToLong(binValue.Text)
      End Select
    Catch ex As Exception
      MessageBox.Show("Error" & vbCrLf & ex.Message, _
          "Check your input value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

    If binValue.Name <> "hexText" Then
      hexText.Text = value.ToString("X")
    End If

    ie = False
  End Sub

  Private Function BinaryToLong(ByVal valOfBin As String) As Long


    valOfBin = valOfBin.Trim().ToUpper()
    If valOfBin.StartsWith("00") Then valOfBin = valOfBin.Substring(2)

    'remove space
    valOfBin = valOfBin.Replace(" ", "")

    '............................................................
    'read the binary number from behind

    valOfBin = New String("0", 64 - valOfBin.Length) & valOfBin


    Dim hexConvert As String = ""
    For halfByte As Integer = 0 To 15

      Dim f As Integer = 1
      Dim halfByteValue As Integer = 0

      'take 4 bit (half byte)
      For bit As Integer = 3 To 0 Step -1
        If valOfBin.Substring(halfByte * 4 + bit, 1).Equals("1") Then
          halfByteValue += f
        End If
        f *= 2
      Next bit

      hexConvert &= halfByteValue.ToString("X")
    Next halfByte


    Return Long.Parse(hexConvert, Globalization.NumberStyles.HexNumber)
  End Function




  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    hexText.Enabled = False
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    binText.Text = ""
  End Sub
End Class
