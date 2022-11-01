'By Shannon Bennett
' 10/6/2019
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class ExportForm

    Dim MysqlCon As MySqlConnection
    Dim sqlCommand As MySqlCommand

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        'create empty string
        Dim thecsvfile As String = String.Empty
        'get the column headers
        For Each column As DataGridViewColumn In dgvDB.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next
        'trim the last comma
        thecsvfile = thecsvfile.TrimEnd(",")
        'Add the line to the output
        thecsvfile = thecsvfile & vbCr & vbLf
        'get the rows
        For Each row As DataGridViewRow In dgvDB.Rows
            'get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'write the file

        My.Computer.FileSystem.WriteAllText("export.csv", thecsvfile, False)

        MsgBox("File Saved")
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, btnRefresh.Click
        'Refresh the table
        LoadData()

    End Sub
    Function LoadData()
        'Set text colors
        lblDesc.ForeColor = Color.FromArgb(140, 35, 0)
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)

        '
        MysqlCon = New MySqlConnection
        MysqlCon.ConnectionString = "server=localhost;userid=root;database=tickedoff"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        'Joining the primary keys for the two tables (pet and customer)
        Try
            MysqlCon.Open()
            Dim Query As String
            Query = "select pet.petID, pet.petName, pet.species, pet.breed, pet.DOB, pet.gender, pet.weight, concat(customer.firstName, ' ', customer.lastName) as 'Customer Name' from pet INNER JOIN customer on pet.customerID = customer.customerID"
            sqlCommand = New MySqlCommand(Query, MysqlCon)
            SDA.SelectCommand = sqlCommand
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvDB.DataSource = bSource
            SDA.Update(dbDataset)

            MysqlCon.Close()
        Catch ex As MySqlException
            'show error message
            MessageBox.Show(ex.Message)

        Finally
            MysqlCon.Dispose()
        End Try


    End Function

    Private Sub ExportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'return to main menu
        Me.Close()
    End Sub

    Private Sub tsmiAboutCompany_Click(sender As Object, e As EventArgs) Handles tsmiAboutCompany.Click
        'show about form
        aboutForm.Show()
    End Sub

    Private Sub tsmiAboutApplication_Click(sender As Object, e As EventArgs) Handles tsmiAboutApplication.Click
        'show about app form
        AboutAppForm.Show()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'exit app
        Form1.Close()
    End Sub
End Class