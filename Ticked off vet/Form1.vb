'By Shannon Bennett
' 10/6/2019
Public Class Form1
    Private Sub btnOpenManageInfo_Click(sender As Object, e As EventArgs) Handles btnOpenManageInfo.Click
        'open pet info form
        PetInfo.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'open export to csv form
        ExportForm.Show()
    End Sub

    Private Sub btnOpenCalculator_Click(sender As Object, e As EventArgs) Handles btnOpenCalculator.Click
        'open cost calculator form
        CostCalculatorForm.Show()
    End Sub

    Private Sub btnOpenStats_Click(sender As Object, e As EventArgs) Handles btnOpenStats.Click
        'open statistics form
        Stats.Show()
    End Sub

    Private Sub tsmiAboutCompany_Click(sender As Object, e As EventArgs) Handles tsmiAboutCompany.Click
        'show about form
        aboutForm.Show()
    End Sub

    Private Sub tsmiAboutApplication_Click(sender As Object, e As EventArgs) Handles tsmiAboutApplication.Click
        'show about application form
        AboutAppForm.Show()
    End Sub
    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        'exit application
        Me.Close()
    End Sub
End Class
