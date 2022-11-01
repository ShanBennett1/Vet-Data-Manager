'By Shannon Bennett
' 10/6/2019
Imports MySql.Data.MySqlClient
Public Class deleteDataForm
    Dim connection As New MySqlConnection("server=localhost;userid=root;database=tickedoff")

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim command As New MySqlCommand("DELETE FROM `pet` WHERE `petId` = @id", connection)

        'Ask if user if sure before progressing
        Dim res As DialogResult
        res = MsgBox("Are you sure you want to save this data?", MessageBoxButtons.YesNo)
        'if yes then delete selected item
        If res = Windows.Forms.DialogResult.Yes Then

            command.Parameters.Add("@id", MySqlDbType.Int64).Value = txtID.Text

            connection.Open()

            Try

                If command.ExecuteNonQuery() = 1 Then

                    MessageBox.Show("Data Deleted")
                    Me.Close()
                Else

                    MessageBox.Show("Error")

                End If

            Catch ex As Exception

                MessageBox.Show("Something Wrong")

            End Try


            connection.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Go back to the main menu
        Me.Close()
    End Sub

    Private Sub deleteDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set text colours
        lblDelete.ForeColor = Color.FromArgb(140, 35, 0)
        lblPetid.ForeColor = Color.FromArgb(140, 35, 0)


    End Sub
End Class