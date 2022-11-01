<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Me.cboSpecies = New System.Windows.Forms.ComboBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.lblNoOfStays = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblShortStay = New System.Windows.Forms.Label()
        Me.lblLongestStay = New System.Windows.Forms.Label()
        Me.lblAverageStay = New System.Windows.Forms.Label()
        Me.lblShortStayTotal = New System.Windows.Forms.Label()
        Me.lblLongStayTotal = New System.Windows.Forms.Label()
        Me.lblAveStayTotal = New System.Windows.Forms.Label()
        Me.lblLowestBoardingCost = New System.Windows.Forms.Label()
        Me.lblLowestCostTotal = New System.Windows.Forms.Label()
        Me.lblHighestCost = New System.Windows.Forms.Label()
        Me.lblHighestCostTotal = New System.Windows.Forms.Label()
        Me.lblAverageCost = New System.Windows.Forms.Label()
        Me.lblAverageCostTotal = New System.Windows.Forms.Label()
        Me.lblNoOfStaysTotal = New System.Windows.Forms.Label()
        Me.lblTotalAmountPaid = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cboSpecies
        '
        Me.cboSpecies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Location = New System.Drawing.Point(243, 296)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.Size = New System.Drawing.Size(121, 20)
        Me.cboSpecies.TabIndex = 1
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(65, 149)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(43, 12)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Label1"
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = Global.Ticked_off_vet.My.Resources.Resources.TickedOff_Logo
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(93, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(474, 110)
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.Location = New System.Drawing.Point(189, 304)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(52, 12)
        Me.lblSpecies.TabIndex = 2
        Me.lblSpecies.Text = "Species:"
        '
        'lblNoOfStays
        '
        Me.lblNoOfStays.AutoSize = True
        Me.lblNoOfStays.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStays.Location = New System.Drawing.Point(109, 331)
        Me.lblNoOfStays.Name = "lblNoOfStays"
        Me.lblNoOfStays.Size = New System.Drawing.Size(132, 12)
        Me.lblNoOfStays.TabIndex = 2
        Me.lblNoOfStays.Text = "Total Number Of Stays:"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.Location = New System.Drawing.Point(132, 344)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(109, 12)
        Me.lblAmountPaid.TabIndex = 2
        Me.lblAmountPaid.Text = "Total Amount Paid:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(358, 333)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblShortStay
        '
        Me.lblShortStay.AutoSize = True
        Me.lblShortStay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortStay.Location = New System.Drawing.Point(26, 209)
        Me.lblShortStay.Name = "lblShortStay"
        Me.lblShortStay.Size = New System.Drawing.Size(82, 12)
        Me.lblShortStay.TabIndex = 2
        Me.lblShortStay.Text = "Shortest Stay:"
        '
        'lblLongestStay
        '
        Me.lblLongestStay.AutoSize = True
        Me.lblLongestStay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongestStay.Location = New System.Drawing.Point(28, 222)
        Me.lblLongestStay.Name = "lblLongestStay"
        Me.lblLongestStay.Size = New System.Drawing.Size(80, 12)
        Me.lblLongestStay.TabIndex = 2
        Me.lblLongestStay.Text = "Longest Stay:"
        '
        'lblAverageStay
        '
        Me.lblAverageStay.AutoSize = True
        Me.lblAverageStay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageStay.Location = New System.Drawing.Point(26, 235)
        Me.lblAverageStay.Name = "lblAverageStay"
        Me.lblAverageStay.Size = New System.Drawing.Size(82, 12)
        Me.lblAverageStay.TabIndex = 2
        Me.lblAverageStay.Text = "Average Stay:"
        '
        'lblShortStayTotal
        '
        Me.lblShortStayTotal.AutoSize = True
        Me.lblShortStayTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortStayTotal.Location = New System.Drawing.Point(114, 209)
        Me.lblShortStayTotal.Name = "lblShortStayTotal"
        Me.lblShortStayTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblShortStayTotal.TabIndex = 2
        Me.lblShortStayTotal.Text = "0 Day(s)"
        '
        'lblLongStayTotal
        '
        Me.lblLongStayTotal.AutoSize = True
        Me.lblLongStayTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongStayTotal.Location = New System.Drawing.Point(114, 222)
        Me.lblLongStayTotal.Name = "lblLongStayTotal"
        Me.lblLongStayTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblLongStayTotal.TabIndex = 2
        Me.lblLongStayTotal.Text = "0 Day(s)"
        '
        'lblAveStayTotal
        '
        Me.lblAveStayTotal.AutoSize = True
        Me.lblAveStayTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveStayTotal.Location = New System.Drawing.Point(114, 235)
        Me.lblAveStayTotal.Name = "lblAveStayTotal"
        Me.lblAveStayTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblAveStayTotal.TabIndex = 2
        Me.lblAveStayTotal.Text = "0 Day(s)"
        '
        'lblLowestBoardingCost
        '
        Me.lblLowestBoardingCost.AutoSize = True
        Me.lblLowestBoardingCost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestBoardingCost.Location = New System.Drawing.Point(348, 209)
        Me.lblLowestBoardingCost.Name = "lblLowestBoardingCost"
        Me.lblLowestBoardingCost.Size = New System.Drawing.Size(129, 12)
        Me.lblLowestBoardingCost.TabIndex = 2
        Me.lblLowestBoardingCost.Text = "Lowest Boarding cost:"
        '
        'lblLowestCostTotal
        '
        Me.lblLowestCostTotal.AutoSize = True
        Me.lblLowestCostTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestCostTotal.Location = New System.Drawing.Point(483, 209)
        Me.lblLowestCostTotal.Name = "lblLowestCostTotal"
        Me.lblLowestCostTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblLowestCostTotal.TabIndex = 2
        Me.lblLowestCostTotal.Text = "$000.00"
        '
        'lblHighestCost
        '
        Me.lblHighestCost.AutoSize = True
        Me.lblHighestCost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestCost.Location = New System.Drawing.Point(345, 222)
        Me.lblHighestCost.Name = "lblHighestCost"
        Me.lblHighestCost.Size = New System.Drawing.Size(132, 12)
        Me.lblHighestCost.TabIndex = 2
        Me.lblHighestCost.Text = "Highest Boarding Cost:"
        '
        'lblHighestCostTotal
        '
        Me.lblHighestCostTotal.AutoSize = True
        Me.lblHighestCostTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestCostTotal.Location = New System.Drawing.Point(483, 222)
        Me.lblHighestCostTotal.Name = "lblHighestCostTotal"
        Me.lblHighestCostTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblHighestCostTotal.TabIndex = 2
        Me.lblHighestCostTotal.Text = "$000.00"
        '
        'lblAverageCost
        '
        Me.lblAverageCost.AutoSize = True
        Me.lblAverageCost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCost.Location = New System.Drawing.Point(341, 235)
        Me.lblAverageCost.Name = "lblAverageCost"
        Me.lblAverageCost.Size = New System.Drawing.Size(137, 12)
        Me.lblAverageCost.TabIndex = 2
        Me.lblAverageCost.Text = "Average Boarding Cost:"
        '
        'lblAverageCostTotal
        '
        Me.lblAverageCostTotal.AutoSize = True
        Me.lblAverageCostTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCostTotal.Location = New System.Drawing.Point(483, 235)
        Me.lblAverageCostTotal.Name = "lblAverageCostTotal"
        Me.lblAverageCostTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblAverageCostTotal.TabIndex = 2
        Me.lblAverageCostTotal.Text = "$000.00"
        '
        'lblNoOfStaysTotal
        '
        Me.lblNoOfStaysTotal.AutoSize = True
        Me.lblNoOfStaysTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfStaysTotal.Location = New System.Drawing.Point(243, 331)
        Me.lblNoOfStaysTotal.Name = "lblNoOfStaysTotal"
        Me.lblNoOfStaysTotal.Size = New System.Drawing.Size(50, 12)
        Me.lblNoOfStaysTotal.TabIndex = 2
        Me.lblNoOfStaysTotal.Text = "0 Day(s)"
        '
        'lblTotalAmountPaid
        '
        Me.lblTotalAmountPaid.AutoSize = True
        Me.lblTotalAmountPaid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountPaid.Location = New System.Drawing.Point(243, 344)
        Me.lblTotalAmountPaid.Name = "lblTotalAmountPaid"
        Me.lblTotalAmountPaid.Size = New System.Drawing.Size(50, 12)
        Me.lblTotalAmountPaid.TabIndex = 2
        Me.lblTotalAmountPaid.Text = "$000.00"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip.TabIndex = 7
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
        Me.tsmiExit.Size = New System.Drawing.Size(93, 22)
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
        Me.lblTitle.Location = New System.Drawing.Point(112, 95)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 28)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Statistics"
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTotalAmountPaid)
        Me.Controls.Add(Me.lblAverageCostTotal)
        Me.Controls.Add(Me.lblAveStayTotal)
        Me.Controls.Add(Me.lblAverageCost)
        Me.Controls.Add(Me.lblAverageStay)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.lblNoOfStaysTotal)
        Me.Controls.Add(Me.lblHighestCostTotal)
        Me.Controls.Add(Me.lblHighestCost)
        Me.Controls.Add(Me.lblLongStayTotal)
        Me.Controls.Add(Me.lblLowestCostTotal)
        Me.Controls.Add(Me.lblLongestStay)
        Me.Controls.Add(Me.lblLowestBoardingCost)
        Me.Controls.Add(Me.lblShortStayTotal)
        Me.Controls.Add(Me.lblShortStay)
        Me.Controls.Add(Me.lblNoOfStays)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.cboSpecies)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Stats"
        Me.Text = "Stats"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents cboSpecies As ComboBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSpecies As Label
    Friend WithEvents lblNoOfStays As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblShortStay As Label
    Friend WithEvents lblLongestStay As Label
    Friend WithEvents lblAverageStay As Label
    Friend WithEvents lblShortStayTotal As Label
    Friend WithEvents lblLongStayTotal As Label
    Friend WithEvents lblAveStayTotal As Label
    Friend WithEvents lblLowestBoardingCost As Label
    Friend WithEvents lblLowestCostTotal As Label
    Friend WithEvents lblHighestCost As Label
    Friend WithEvents lblHighestCostTotal As Label
    Friend WithEvents lblAverageCost As Label
    Friend WithEvents lblAverageCostTotal As Label
    Friend WithEvents lblNoOfStaysTotal As Label
    Friend WithEvents lblTotalAmountPaid As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiAboutCompany As ToolStripMenuItem
    Friend WithEvents tsmiAboutApplication As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
End Class
