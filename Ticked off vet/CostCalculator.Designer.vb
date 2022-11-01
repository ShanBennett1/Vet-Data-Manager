<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cboSpecies = New System.Windows.Forms.ComboBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblPetWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblStayLength = New System.Windows.Forms.Label()
        Me.txtStayLength = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(270, 428)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(131, 13)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "Copyright 2019 Ticked Off"
        '
        'cboSpecies
        '
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Location = New System.Drawing.Point(273, 272)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.Size = New System.Drawing.Size(121, 21)
        Me.cboSpecies.TabIndex = 2
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(105, 13)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(522, 129)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(10, 163)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(59, 13)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Information"
        '
        'lblPetWeight
        '
        Me.lblPetWeight.AutoSize = True
        Me.lblPetWeight.Location = New System.Drawing.Point(204, 302)
        Me.lblPetWeight.Name = "lblPetWeight"
        Me.lblPetWeight.Size = New System.Drawing.Size(63, 13)
        Me.lblPetWeight.TabIndex = 1
        Me.lblPetWeight.Text = "Pet Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(273, 299)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 3
        '
        'lblStayLength
        '
        Me.lblStayLength.AutoSize = True
        Me.lblStayLength.Location = New System.Drawing.Point(203, 332)
        Me.lblStayLength.Name = "lblStayLength"
        Me.lblStayLength.Size = New System.Drawing.Size(67, 13)
        Me.lblStayLength.TabIndex = 1
        Me.lblStayLength.Text = "Stay Length:"
        '
        'txtStayLength
        '
        Me.txtStayLength.Location = New System.Drawing.Point(273, 325)
        Me.txtStayLength.Name = "txtStayLength"
        Me.txtStayLength.Size = New System.Drawing.Size(100, 20)
        Me.txtStayLength.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(389, 299)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 46)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(159, 370)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(108, 24)
        Me.lblTotalCost.TabIndex = 1
        Me.lblTotalCost.Text = "Total Cost : "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(269, 370)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 24)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "$xxx.xx"
        '
        'CostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 450)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtStayLength)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblStayLength)
        Me.Controls.Add(Me.cboSpecies)
        Me.Controls.Add(Me.lblPetWeight)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "CostCalculator"
        Me.Text = "CostCalculator"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblCopyright As Label
    Friend WithEvents cboSpecies As ComboBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblPetWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblStayLength As Label
    Friend WithEvents txtStayLength As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotal As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTotalCost.Click, lblTotal.Click

    End Sub

    Private Sub CostCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
