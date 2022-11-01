'By Shannon Bennett
' 10/6/2019
Public Class CostCalculatorForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        calculate()
    End Sub

    Function GetSurcharge(animal As String) As Integer
        Dim surcharge As Integer

        Select Case animal.Trim()
            Case "Cat", "Dog", "Ferret"
                surcharge = 5
            Case "Goat"
                surcharge = 12
            Case "Guinea Pig", "Mouse", "Rat", "Tortoise"
                surcharge = 0
            Case "Horse"
                surcharge = 22
            Case "Koala"
                surcharge = 20
            Case "Rabbit"
                surcharge = 3
            Case "Snake"
                surcharge = 15
            Case "Yak"
                surcharge = 108
        End Select

        Return surcharge

    End Function



    Function calculate() As Double
        Dim baseRate As Double = 20
        Dim percent As Double = 0.9
        Dim total As Double = 0

        ' Getting surchage for animal and adding with base rate
        total = baseRate + GetSurcharge(cboSpecies.Text)

        'alert for if combobox is empty
        If cboSpecies.Text = "" Then
            MessageBox.Show("Please pick a pet")

        End If


        'If Weight is greater than 12 kg, multiplying with 1.5 plus error handling
        If IsNumeric(txtPetWeight.Text) = False Then
            MsgBox("Weight must be a number")

        ElseIf IsNumeric(txtPetWeight.Text) Then
            If txtPetWeight.Text <= 0 Then
                MsgBox("Weight must be more than 0")
            ElseIf txtPetWeight.Text >= 12 Then
                total = total + txtPetWeight.Text * 1.5
            End If

        End If


        If IsNumeric(txtPetWeight.Text) And IsNumeric(txtStayLength.Text) Then
            ' Now multiplying it with staylength
            total = total * txtStayLength.Text
        End If


        'if stay > 10 days, giving 10 % discont plus error exeptions
        If IsNumeric(txtStayLength.Text) = False Then
            MsgBox("Stay must be a number")

        ElseIf IsNumeric(txtStayLength.Text) Then
            If txtStayLength.Text <= 0 Then
                MsgBox("Stay must be more than 0")
            ElseIf txtStayLength.Text > 10 Then
                total = total * percent
            End If
        End If

        'Show the total 
        lblTotalCost.Text = "$" & total
        Return total

    End Function

    Private Sub CostCalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set combo box as drop down list
        cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList

        'set colours for the text
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)
        lblPetWeight.ForeColor = Color.FromArgb(140, 35, 0)
        lblSpecies.ForeColor = Color.FromArgb(140, 35, 0)
        lblStayLength.ForeColor = Color.FromArgb(140, 35, 0)
        lblTotal.ForeColor = Color.FromArgb(140, 35, 0)
        lblTotalCost.ForeColor = Color.FromArgb(140, 35, 0)
        lblDesc.ForeColor = Color.FromArgb(140, 35, 0)
        lblDesc.Text = "The boarding cost calculator allows you to quickly and easily see the
applicable cost of using the animal boarding services of Ticked Off Vet.
Just enter a few simple bits of information and the cost will be calculated."

    End Sub

    Private Sub tsmiAboutCompany_Click(sender As Object, e As EventArgs) Handles tsmiAboutCompany.Click
        'Show about Form
        aboutForm.Show()
    End Sub

    Private Sub tsmiAboutApplication_Click(sender As Object, e As EventArgs) Handles tsmiAboutApplication.Click
        'Show about app From
        AboutAppForm.Show()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'exit entire app
        Form1.Close()
    End Sub
End Class