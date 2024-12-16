Imports System.Data.SqlClient
Public Class AdminLoginForm


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from loginTab where uName='" & UCase(UsernameTextBox.Text) & "' and pword='" & PasswordTextBox.Text & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.Read Then


            MDIParent1.Show()
            Me.Hide()
            If Conn.State = ConnectionState.Open Then Conn.Close()
        Else
            MsgBox("Username or Password is not correct please check")
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class
