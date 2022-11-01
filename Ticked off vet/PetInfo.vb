'By Shannon Bennett
' 10/6/2019
Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Public Class PetInfo
    Dim MysqlCon As MySqlConnection
    Dim sqlCommand As MySqlCommand



    Private Sub PetInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set text colours
        lblSort.ForeColor = Color.FromArgb(140, 35, 0)
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)
        lblDesc.ForeColor = Color.FromArgb(140, 35, 0)
        lblDesc.Text = "This area allows you to manage pet information."

        'load data to table
        LoadData()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddPetForm.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Refresh table
        LoadData()
    End Sub

    Function LoadData()

        MysqlCon = New MySqlConnection
        MysqlCon.ConnectionString = "server=localhost;userid=root;database=tickedoff"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        cboSort.DropDownStyle = ComboBoxStyle.DropDownList
        'Joining the primary keys for the two tables (pet and customer)
        Try
            MysqlCon.Open()
            Dim Query As String
            Query = "select pet.petID, pet.petName, pet.species, pet.breed, pet.DOB, pet.gender, pet.weight, concat(customer.firstName, ' ', customer.lastName) as 'Customer Name' from pet INNER JOIN customer on pet.customerID = customer.customerID"
            sqlCommand = New MySqlCommand(Query, MysqlCon)
            SDA.SelectCommand = sqlCommand
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            dgvPets.DataSource = bSource
            SDA.Update(dbDataset)

            MysqlCon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlCon.Dispose()
        End Try

        'Return LoadData()
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'return to main menu
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Show the delete form
        deleteDataForm.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'return to main menu
        Me.Close()
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        'Sorting the data in the datagrid view
        If cboSort.Text = "Ascending (Pet ID)" Then

            dgvPets.Sort(dgvPets.Columns("PetID"), System.ComponentModel.ListSortDirection.Ascending)

        ElseIf cboSort.Text = "Descending (Pet ID)" Then
            dgvPets.Sort(dgvPets.Columns("PetID"), System.ComponentModel.ListSortDirection.Descending)

        ElseIf cboSort.Text = "Ascending (Pet Name)" Then
            dgvPets.Sort(dgvPets.Columns("petName"), System.ComponentModel.ListSortDirection.Ascending)

        ElseIf cboSort.Text = "Descending (Pet Name)" Then
            dgvPets.Sort(dgvPets.Columns("petName"), System.ComponentModel.ListSortDirection.Descending)

        ElseIf cboSort.Text = "Ascending (DOB)" Then
            dgvPets.Sort(dgvPets.Columns("DOB"), System.ComponentModel.ListSortDirection.Ascending)

        ElseIf cboSort.Text = "Descending (DOB)" Then
            dgvPets.Sort(dgvPets.Columns("DOB"), System.ComponentModel.ListSortDirection.Descending)

        Else
            MessageBox.Show("Choose and order to sort By")
        End If

    End Sub

    Private Sub tsmiAboutCompany_Click(sender As Object, e As EventArgs) Handles tsmiAboutCompany.Click
        'open about form
        aboutForm.Show()
    End Sub

    Private Sub tsmiAboutApplication_Click(sender As Object, e As EventArgs) Handles tsmiAboutApplication.Click
        AboutAppForm.Show()
    End Sub
    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'exit app
        Form1.Close()
    End Sub
End Class