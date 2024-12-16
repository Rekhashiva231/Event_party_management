Public Class FlashScreen
    Dim I As Integer
    Private Sub FlashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 759
        Me.Height = 310

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        I = I + 1
        If I > 5 Then
            Timer1.Enabled = False
            Me.Hide()
            AdminLoginForm.Show()
        End If
    End Sub
End Class
