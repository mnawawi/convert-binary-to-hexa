
Imports Microsoft.VisualBasic
Imports System.Math


Public Class Form1
  Dim Bry As Integer
  Dim Dec As Integer
  Dim Hex As String

  Private Function converttobin()
    Bry = txtBinary.Text

    Dec = Convert.ToInt32(Bry, 2)

    Hex = Convert.ToString(Dec, 16)

    txtHexadecimal.Text = Hex

    Return 0
  End Function


  Private Sub txtBinary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBinary.KeyPress

    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 49 Then

      If txtBinary.Text = "" Then
        txtHexadecimal.Enabled = True
      End If

      txtHexadecimal.Enabled = True

    Else

      txtHexadecimal.Enabled = False

    End If

    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 49 Then

      If Asc(e.KeyChar) = 8 Then
        e.Handled = False
      Else
        e.Handled = True
        MessageBox.Show("Insert Binary number only ( 1 or 0 )", "Warning")
      End If
    End If

  End Sub



  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    txtBinary.Text = ""
    txtHexadecimal.Text = ""

    txtBinary.Enabled = True
    txtHexadecimal.Enabled = False
  End Sub


  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtHexadecimal.Enabled = False
  End Sub



  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    converttobin()
  End Sub
End Class
