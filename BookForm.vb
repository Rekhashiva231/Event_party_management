Imports System.Data.SqlClient
Public Class BookForm
    Dim pkVar As String
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Please select the event code")
            Exit Sub
        End If

        If ComboBox3.Text = "" Then
            MsgBox("Please select the provider code")
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into EventBookTab values('" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "'," & Val(TextBox1.Text) & ")"
        Dim cmd1 As New SqlCommand(q1Var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()


        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select serType,mCode,price From EventBookTab where eventcode='" & ComboBox1.Text & "'", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        DG1.Columns(0).Width = 300
        DG1.Columns(1).Width = 300
        DG1.Columns(2).Width = 100

    End Sub

    Private Sub BookForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd2 As New SqlCommand("select Eventcode from EventTab order by Eventcode", Conn)
        Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
        While D2.Read
            ComboBox1.Items.Add(D2(0))
        End While

    End Sub

    Private Sub ComboBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.Leave
        ComboBox3.Items.Clear()
        If ComboBox2.Text = "Venue" Then
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            Dim Cmd2 As New SqlCommand("select venueCode from venueTab order by venueCode", Conn)
            Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
            While D2.Read
                ComboBox3.Items.Add(D2(0))
            End While
        ElseIf ComboBox2.Text = "Food" Then
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            Dim Cmd2 As New SqlCommand("select FoodCode from FoodTab order by FoodCode", Conn)
            Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
            While D2.Read
                ComboBox3.Items.Add(D2(0))
            End While
       
        ElseIf ComboBox2.Text = "Services" Then
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            Dim Cmd2 As New SqlCommand("select ServicesCode from  ServicesTab order by ServicesCode", Conn)
            Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
            While D2.Read
                ComboBox3.Items.Add(D2(0))
            End While
        End If
    End Sub

    Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select serType,mCode,price From EventBookTab where eventcode='" & ComboBox1.Text & "'", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        DG1.Columns(0).Width = 300
        DG1.Columns(1).Width = 300
        DG1.Columns(2).Width = 100
    End Sub
End Class