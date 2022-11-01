'By Shannon Bennett
' 10/6/2019
Public Class aboutForm
    Private Sub aboutForm_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the text colours
        lblTitle.ForeColor = Color.FromArgb(0, 87, 172)
        lblAbout.ForeColor = Color.FromArgb(140, 35, 0)

        lblTitle.Text = "About this company"

        'About the application
        lblAbout.Text = "
Ticked Off is a long-established vet practice that has been operating in the Hornsby area of Sydney for many years. 
Keith Cabrade, son-in-law of long-term businessman Victor Grahams, owns the magical practice.

Ticked Off has recently received a series of accolades from the industry for their ingenious invention of the
easy-tick-disposal product, the Pop Bag. This incredibly clever invention has catapulted Ticked Off to veterinary 
fame in a way that no bag has done before!

Ticked Off is 100% committed to good service, so hopefully you won't be ticked off... get it?! LOLs. 
Just a little taste of our witty, vet-flavoured humour."

    End Sub

End Class