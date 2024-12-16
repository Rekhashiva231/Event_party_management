Imports System.Data.SqlClient
Public Class ApplicantForm1
    Dim pkVar As Long
    Private Sub ApplicantForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized




       

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select StateName from StateNameTab order by statename", Conn)
        Dim D2 As SqlDataReader = Cmd1.ExecuteReader()
        While D2.Read
            ComboBox2.Items.Add(D2(0))
        End While
        TextBox1.Text = appNoVar
        TextBox2.Text = appNameVar

    End Sub


    

    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        SaveRecord()


    End Sub
    Sub SaveRecord()
        If TextBox1.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If


        appNoVar = Val(TextBox1.Text)
        appNameVar = TextBox2.Text
        q1Var = "update  MemberTab set "
        q1Var = q1Var & "StateName" & "="
        q1Var = q1Var & "'" & ComboBox2.Text & "',"
        q1Var = q1Var & "DistrictName" & "="
        q1Var = q1Var & "'" & ComboBox3.Text & "',"
        q1Var = q1Var & "Pincode" & "="
        q1Var = q1Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "add3" & "="
        q1Var = q1Var & "'" & TextBox5.Text & "',"
        q1Var = q1Var & "add2" & "="
        q1Var = q1Var & "'" & TextBox6.Text & "',"
        q1Var = q1Var & "add1" & "="
        q1Var = q1Var & "'" & TextBox7.Text & "' "
        q1Var = q1Var & "where AppNo" & "="
        q1Var = q1Var & "" & appNoVar & ""


        'MsgBox(q1Var & q1var)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand(q1Var & q1Var, Conn)
        cmd1.ExecuteNonQuery()

        Me.Close()
        ApplicantForm2.MdiParent = MDIParent1
        ApplicantForm2.Show()




    End Sub


    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub




    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
    End Sub



    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select DistrictName from DistrictNameTab where StateName='" & UCase(ComboBox2.Text) & "'", Conn)
        Dim D2 As SqlDataReader = Cmd1.ExecuteReader()
        While D2.Read
            ComboBox3.Items.Add(D2(0))
        End While
    End Sub
End Class
