'By Shannon Bennett
' 10/6/2019
Imports MySql.Data.MySqlClient
Public Class AddPetForm
    Dim MysqlCon As MySqlConnection
    Dim sqlCommand As MySqlCommand


    Private Sub AddPetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set text colours
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)
        lblPetName.ForeColor = Color.FromArgb(140, 35, 0)
        lblDOB.ForeColor = Color.FromArgb(140, 35, 0)
        lblweight.ForeColor = Color.FromArgb(140, 35, 0)
        lblSpecies.ForeColor = Color.FromArgb(140, 35, 0)
        lblgender.ForeColor = Color.FromArgb(140, 35, 0)
        lblBreed.ForeColor = Color.FromArgb(140, 35, 0)
        lblcustomerName.ForeColor = Color.FromArgb(140, 35, 0)

        'Make the combo boxes select only
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList
        cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList

        'Block future dates
        dtpDOB.MaxDate = Date.Today

        MysqlCon = New MySqlConnection
        Dim Reader As MySqlDataReader
        MysqlCon.ConnectionString = "server=localhost;userid=root;database=tickedoff"

        'Add the species into the combo box 
        Try
            MysqlCon.Open()
            Dim Query As String
            Query = "select * from tickedoff.petspecies"
            sqlCommand = New MySqlCommand(Query, MysqlCon)
            Reader = sqlCommand.ExecuteReader

            While Reader.Read
                Dim sSpecies = Reader.GetString("species")
                cboSpecies.Items.Add(sSpecies)
            End While


            MysqlCon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlCon.Dispose()
        End Try





    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MysqlCon = New MySqlConnection
        MysqlCon.ConnectionString = "server=localhost;userid=root;database=tickedoff"
        Dim Reader As MySqlDataReader
        Dim vdob As String


        vdob = Format(dtpDOB.Value, "yyyy-MM-dd")

        'Ensure the text boxes have the correct format entered
        If IsNumeric(txtPetName.Text) Then
            MsgBox("Name must not be a number")
            Exit Sub
        End If

        If IsNumeric(txtWeight.Text) = False Then
            MsgBox("Weight must be a number")
            Exit Sub
        End If

        If IsNumeric(txtBreed.Text) Then
            MsgBox("Breed must not be a number")
            Exit Sub
        End If

        If IsNumeric(txtCustomerID.Text) = False Then
            MsgBox("Customer ID must be a number")
            Exit Sub
        End If


        'ensure the text boxes are not empty
        If txtPetName.Text = "" Then
            MessageBox.Show("Please fill pet name")
            Exit Sub
        End If

        If cboSpecies.Text = "" Then
            MessageBox.Show("Please fill Species")
            Exit Sub
        End If

        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please customer ID")
            Exit Sub
        End If

        If txtWeight.Text = "" Then
            MessageBox.Show("Please fill pet weight")
            Exit Sub
        End If


        'Fill the entered information into the database
        Try
            MysqlCon.Open()
            Dim Query As String
            Query = "insert into tickedoff.Pet (petName, species, breed, DOB, gender, weight, customerID) values ('" & txtPetName.Text & "', '" & cboSpecies.Text & "', '" & txtBreed.Text & "', '" & vdob & "', '" & cboGender.Text & "', '" & txtWeight.Text & "', '" & txtCustomerID.Text & "')"
            sqlCommand = New MySqlCommand(Query, MysqlCon)
            Reader = sqlCommand.ExecuteReader

            MessageBox.Show("Data saved")


            MysqlCon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlCon.Dispose()
        End Try



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close the application 
        Me.Close()
    End Sub

    Private Sub cboSpecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSpecies.SelectedIndexChanged

    End Sub

    Private Sub tsmiAboutCompany_Click(sender As Object, e As EventArgs) Handles tsmiAboutCompany.Click
        'Show about form
        aboutForm.Show()
    End Sub

    Private Sub tsmiAboutApplication_Click(sender As Object, e As EventArgs) Handles tsmiAboutApplication.Click
        'Show about app form
        AboutAppForm.Show()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'Exit entire application
        Form1.Close()
    End Sub
End Class