<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOpenCalculator = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnOpenManageInfo = New System.Windows.Forms.Button()
        Me.btnOpenStats = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenCalculator
        '
        Me.btnOpenCalculator.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCalculator.Location = New System.Drawing.Point(223, 315)
        Me.btnOpenCalculator.Name = "btnOpenCalculator"
        Me.btnOpenCalculator.Size = New System.Drawing.Size(171, 109)
        Me.btnOpenCalculator.TabIndex = 0
        Me.btnOpenCalculator.Text = "Boarding Cost Calculator"
        Me.btnOpenCalculator.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(400, 315)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(171, 109)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Quick Export Pet Information (CSV)"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnOpenManageInfo
        '
        Me.btnOpenManageInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenManageInfo.Location = New System.Drawing.Point(223, 200)
        Me.btnOpenManageInfo.Name = "btnOpenManageInfo"
        Me.btnOpenManageInfo.Size = New System.Drawing.Size(171, 109)
        Me.btnOpenManageInfo.TabIndex = 0
        Me.btnOpenManageInfo.Text = "Manage Pet Information"
        Me.btnOpenManageInfo.UseVisualStyleBackColor = True
        '
        'btnOpenStats
        '
        Me.btnOpenStats.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenStats.Location = New System.Drawing.Point(400, 200)
        Me.btnOpenStats.Name = "btnOpenStats"
        Me.btnOpenStats.Size = New System.Drawing.Size(171, 109)
        Me.btnOpenStats.TabIndex = 0
        Me.btnOpenStats.Text = "Statistics"
        Me.btnOpenStats.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
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
        'tsmiHelp
        '
        Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAbout})
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmiHelp.Text = "Help"
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ticked_off_vet.My.Resources.Resources.TickedOff_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(223, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 124)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOpenStats)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnOpenManageInfo)
        Me.Controls.Add(Me.btnOpenCalculator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenCalculator As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnOpenManageInfo As Button
    Friend WithEvents btnOpenStats As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiHelp As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiAboutCompany As ToolStripMenuItem
    Friend WithEvents tsmiAboutApplication As ToolStripMenuItem
End Class
