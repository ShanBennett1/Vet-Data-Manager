<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetInfo
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
        Me.dgvPets = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        CType(Me.dgvPets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPets
        '
        Me.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPets.Location = New System.Drawing.Point(11, 191)
        Me.dgvPets.Name = "dgvPets"
        Me.dgvPets.Size = New System.Drawing.Size(793, 302)
        Me.dgvPets.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(11, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(67, 25)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = Global.Ticked_off_vet.My.Resources.Resources.TickedOff_Logo
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(112, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(613, 102)
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"Ascending (Pet ID)", "Descending (Pet ID)", "Ascending (Pet Name)", "Descending (Pet Name)", "Ascending (DOB)", "Descending (DOB)"})
        Me.cboSort.Location = New System.Drawing.Point(94, 162)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(158, 21)
        Me.cboSort.TabIndex = 3
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSort.Location = New System.Drawing.Point(41, 162)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(47, 18)
        Me.lblSort.TabIndex = 4
        Me.lblSort.Text = "Sort:"
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(271, 162)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(106, 23)
        Me.btnSort.TabIndex = 1
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(191, 499)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 61)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(290, 499)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 61)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(389, 499)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 61)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(488, 499)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 61)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(817, 24)
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
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(130, 83)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(128, 22)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Manage Pets"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(130, 132)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(37, 18)
        Me.lblDesc.TabIndex = 4
        Me.lblDesc.Text = "info"
        '
        'PetInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 594)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvPets)
        Me.Name = "PetInfo"
        Me.Text = "PetInfo"
        CType(Me.dgvPets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPets As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents lblSort As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
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
