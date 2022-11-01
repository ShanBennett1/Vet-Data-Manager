<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostCalculatorForm
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
        Me.txtStayLength = New System.Windows.Forms.TextBox()
        Me.txtPetWeight = New System.Windows.Forms.TextBox()
        Me.cboSpecies = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblPetWeight = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.lblStayLength = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStayLength
        '
        Me.txtStayLength.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStayLength.Location = New System.Drawing.Point(183, 248)
        Me.txtStayLength.Name = "txtStayLength"
        Me.txtStayLength.Size = New System.Drawing.Size(121, 20)
        Me.txtStayLength.TabIndex = 14
        '
        'txtPetWeight
        '
        Me.txtPetWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetWeight.Location = New System.Drawing.Point(183, 213)
        Me.txtPetWeight.Name = "txtPetWeight"
        Me.txtPetWeight.Size = New System.Drawing.Size(121, 20)
        Me.txtPetWeight.TabIndex = 13
        '
        'cboSpecies
        '
        Me.cboSpecies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Items.AddRange(New Object() {"Cat", "Dog", "Ferret", "Goat", "Guinea Pig", "Mouse", "Rat", "Tortoise", "Horse", "Koala", "Rabbit", "Snake", "Yak"})
        Me.cboSpecies.Location = New System.Drawing.Point(183, 161)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.Size = New System.Drawing.Size(121, 20)
        Me.cboSpecies.TabIndex = 12
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(179, 313)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 12)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(249, 313)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(43, 12)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "$00.00"
        '
        'lblPetWeight
        '
        Me.lblPetWeight.AutoSize = True
        Me.lblPetWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetWeight.Location = New System.Drawing.Point(121, 216)
        Me.lblPetWeight.Name = "lblPetWeight"
        Me.lblPetWeight.Size = New System.Drawing.Size(67, 12)
        Me.lblPetWeight.TabIndex = 9
        Me.lblPetWeight.Text = "Pet Weight:"
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.Location = New System.Drawing.Point(132, 164)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(52, 12)
        Me.lblSpecies.TabIndex = 10
        Me.lblSpecies.Text = "Species:"
        '
        'lblStayLength
        '
        Me.lblStayLength.AutoSize = True
        Me.lblStayLength.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStayLength.Location = New System.Drawing.Point(117, 251)
        Me.lblStayLength.Name = "lblStayLength"
        Me.lblStayLength.Size = New System.Drawing.Size(74, 12)
        Me.lblStayLength.TabIndex = 11
        Me.lblStayLength.Text = "Stay Length:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(310, 232)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(504, 24)
        Me.MenuStrip.TabIndex = 15
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(92, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'tsmiAbout
        '
        Me.tsmiAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAboutCompany, Me.tsmiAboutApplication})
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Size = New System.Drawing.Size(107, 22)
        Me.tsmiAbout.Text = "About"
        '
        'tsmiAboutCompany
        '
        Me.tsmiAboutCompany.Name = "tsmiAboutCompany"
        Me.tsmiAboutCompany.Size = New System.Drawing.Size(191, 22)
        Me.tsmiAboutCompany.Text = "About this company"
        '
        'tsmiAboutApplication
        '
        Me.tsmiAboutApplication.Name = "tsmiAboutApplication"
        Me.tsmiAboutApplication.Size = New System.Drawing.Size(191, 22)
        Me.tsmiAboutApplication.Text = "About this application"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(96, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(305, 28)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Boarding Cost Calculator"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(58, 75)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(32, 12)
        Me.lblDesc.TabIndex = 16
        Me.lblDesc.Text = "label"
        '
        'CostCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 359)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.txtStayLength)
        Me.Controls.Add(Me.txtPetWeight)
        Me.Controls.Add(Me.cboSpecies)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblPetWeight)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.lblStayLength)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "CostCalculatorForm"
        Me.Text = "CostCalculatorForm"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStayLength As TextBox
    Friend WithEvents txtPetWeight As TextBox
    Friend WithEvents cboSpecies As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblPetWeight As Label
    Friend WithEvents lblSpecies As Label
    Friend WithEvents lblStayLength As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiAboutCompany As ToolStripMenuItem
    Friend WithEvents tsmiAboutApplication As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDesc As Label
End Class
