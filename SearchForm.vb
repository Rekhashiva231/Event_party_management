Imports System.Data.SqlClient
Public Class SearchForm
    Dim pkVar As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlVar As String
        sqlVar = ""
        If Not ComboBox1.Text = "" Then
            sqlVar = " statename = '" & ComboBox1.Text & "'"
        End If
        If Not ComboBox2.Text = "" Then
            If sqlVar = "" Then
                sqlVar = " DistrictName = '" & ComboBox2.Text & "'"
            Else
                sqlVar = sqlVar & " and DistrictName = '" & ComboBox2.Text & "'"
            End If
        End If
        If Not ComboBox3.Text = "" Then
            If sqlVar = "" Then
                sqlVar = " companyTypeName = '" & ComboBox3.Text & "'"
            Else
                sqlVar = sqlVar & "  and companyTypeName = '" & ComboBox3.Text & "'"
            End If
        End If

        If Not sqlVar = "" Then
            sqlVar = " Where " & sqlVar
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select compcode,compname,companytypeName,details,add1,add2,add3,pincode From CompanyTab " & sqlVar & " order by compName", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub SearchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1a As New SqlCommand("select companytypeName from companytypeTab order by companytypename", Conn)
        Dim D1 As SqlDataReader = Cmd1a.ExecuteReader()
        While D1.Read
            ComboBox3.Items.Add(D1(0))
        End While



        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select StateName from StateNameTab order by statename", Conn)
        Dim D2 As SqlDataReader = Cmd1.ExecuteReader()
        While D2.Read
            ComboBox1.Items.Add(D2(0))
        End While
    End Sub

    Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select DistrictName from DistrictNameTab where StateName='" & UCase(ComboBox1.Text) & "'", Conn)
        Dim D2 As SqlDataReader = Cmd1.ExecuteReader()
        While D2.Read
            ComboBox2.Items.Add(D2(0))
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select Prodcode,Details,CatCode,Price From CompanyProductTab where compcode='" & pkVar & "' order by ProdCode", Conn)
        adp.Fill(DS1)
        DG2.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub
End Class