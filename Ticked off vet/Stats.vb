'By Shannon Bennett
' 10/6/2019
Imports MySql.Data.MySqlClient
Public Class Stats
    Dim MysqlCon As MySqlConnection
    Dim sqlCommand As MySqlCommand

    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlCon = New MySqlConnection
        MysqlCon.ConnectionString = "server=localhost;userid=root;database=tickedoff"
        Dim connection As New MySqlConnection("server=localhost;userid=root;database=tickedoff")
        Dim Reader As MySqlDataReader
        cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList

        lblDesc.Text = "This area allows you to quickly and easily view some useful statistics about
Ticked Off Vet regarding boarding information.
Information here can be used to make informed decisions about business direction."

        'set the tex colours
        lblDesc.ForeColor = Color.FromArgb(140, 35, 0)
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)
        lblShortStay.ForeColor = Color.FromArgb(140, 35, 0)
        lblAmountPaid.ForeColor = Color.FromArgb(140, 35, 0)
        lblAverageCost.ForeColor = Color.FromArgb(140, 35, 0)
        lblAverageCostTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblAverageStay.ForeColor = Color.FromArgb(140, 35, 0)
        lblAveStayTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblHighestCost.ForeColor = Color.FromArgb(140, 35, 0)
        lblHighestCostTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblLongestStay.ForeColor = Color.FromArgb(140, 35, 0)
        lblLongStayTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblLowestBoardingCost.ForeColor = Color.FromArgb(140, 35, 0)
        lblLowestCostTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblNoOfStays.ForeColor = Color.FromArgb(140, 35, 0)
        lblNoOfStaysTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblShortStay.ForeColor = Color.FromArgb(140, 35, 0)
        lblShortStayTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblSpecies.ForeColor = Color.FromArgb(140, 35, 0)

        lblTotalAmountPaid.ForeColor = Color.FromArgb(140, 35, 0)

        'sql commands
        Dim commandMaxCost As New MySqlCommand("SELECT MAX(stayCost) From `stay`", connection)
        Dim commandMinCost As New MySqlCommand("SELECT Min(stayCost) From `stay`", connection)
        Dim commandAvgCost As New MySqlCommand("SELECT Avg(stayCost) From `stay`", connection)
        Dim commandAvgStay As New MySqlCommand("SELECT Avg(timestampdiff(Day,`stayStartDate`, `stayEndDate`)) From stay", connection)
        Dim commandMinStay As New MySqlCommand("SELECT MIN(timestampdiff(Day,`stayStartDate`, `stayEndDate`)) From stay ", connection)
        Dim commandMaxStay As New MySqlCommand("SELECT Max(timestampdiff(Day,`stayStartDate`, `stayEndDate`)) From stay ", connection)


        connection.Open()

        lblHighestCostTotal.Text = "$" & commandMaxCost.ExecuteScalar().ToString()
        lblLowestCostTotal.Text = "$" & commandMinCost.ExecuteScalar().ToString()
        lblAverageCostTotal.Text = "$" & commandAvgCost.ExecuteScalar().ToString()
        lblAveStayTotal.Text = commandAvgStay.ExecuteScalar().ToString() & " Day(s)"
        lblShortStayTotal.Text = commandMinStay.ExecuteScalar().ToString() & " Day(s)"
        lblLongStayTotal.Text = commandMaxStay.ExecuteScalar().ToString() & " Day(s)"

        connection.Close()


        'place database information into the form
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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculate the pet stay and pet stay cost 

        MysqlCon = New MySqlConnection
        Dim connection As New MySqlConnection("server=localhost;userid=root;database=tickedoff")


        connection.Open()
        Dim totalAmount As New MySqlCommand("SELECT sum(staycost), pet.species from stay inner join pet on stay.petID = pet.petID where species = '" & cboSpecies.Text & "'", connection)
        lblTotalAmountPaid.Text = "$" & totalAmount.ExecuteScalar().ToString()

        Dim totalDaysStayed As New MySqlCommand("SELECT sum(timestampdiff(Day, stay.stayStartDate, stay.stayEndDate)) as 'Num of days', pet.species from stay inner join pet on stay.petID = pet.petID where species = '" & cboSpecies.Text & "'", connection)
        lblNoOfStaysTotal.Text = totalDaysStayed.ExecuteScalar().ToString() & " Days"
        connection.Close()



        If cboSpecies.Text = "" Then
            MsgBox("Please select a species")
        ElseIf lblTotalAmountPaid.Text = "$" Then
            MsgBox(cboSpecies.Text & " is not booked to stay. Try another species.")
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Back to main menu
        Me.Close()
    End Sub

    Private Sub tsmiAboutCompany_Click(sender As Object, e As EventArgs) Handles tsmiAboutCompany.Click
        'open About
        aboutForm.Show()
    End Sub

    Private Sub tsmiAboutApplication_Click(sender As Object, e As EventArgs) Handles tsmiAboutApplication.Click
        'open about app
        AboutAppForm.Show()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'exit app
        Form1.Close()
    End Sub
End Class