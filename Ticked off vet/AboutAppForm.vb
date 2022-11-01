'By Shannon Bennett
' 10/6/2019
Public Class AboutAppForm

    Private Sub AboutAppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the text colors
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)
        lblAbout.ForeColor = Color.FromArgb(140, 35, 0)

        lblTitle.Text = "About This Program"

        'About information
        lblAbout.Text = "
This is a custom-made application designed specifically to meet the needs of the Ticked Off Vet clinic.
It includes features/functions that are regularly accessed by staff members, 
and serves to make their everyday tasks much easier to fulfil.

Version 2.0 will be out soon... but we won't faucet."
    End Sub
End Class