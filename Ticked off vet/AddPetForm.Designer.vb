<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPetForm
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
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblweight = New System.Windows.Forms.Label()
        Me.lblcustomerName = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.cboSpecies = New System.Windows.Forms.ComboBox()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetName.Location = New System.Drawing.Point(27, 77)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(61, 12)
        Me.lblPetName.TabIndex = 0
        Me.lblPetName.Text = "Pet Name:"
        '
        'txtPetName
        '
        Me.txtPetName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetName.Location = New System.Drawing.Point(90, 73)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(100, 20)
        Me.txtPetName.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(116, 296)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 83)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtBreed
        '
        Me.txtBreed.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBreed.Location = New System.Drawing.Point(383, 164)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(100, 20)
        Me.txtBreed.TabIndex = 1
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(90, 166)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 1
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.Location = New System.Drawing.Point(330, 76)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(52, 12)
        Me.lblSpecies.TabIndex = 0
        Me.lblSpecies.Text = "Species:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(50, 124)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(33, 12)
        Me.lblDOB.TabIndex = 0
        Me.lblDOB.Text = "DOB:"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(332, 122)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(50, 12)
        Me.lblgender.TabIndex = 0
        Me.lblgender.Text = "Gender:"
        '
        'lblweight
        '
        Me.lblweight.AutoSize = True
        Me.lblweight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblweight.Location = New System.Drawing.Point(40, 171)
        Me.lblweight.Name = "lblweight"
        Me.lblweight.Size = New System.Drawing.Size(46, 12)
        Me.lblweight.TabIndex = 0
        Me.lblweight.Text = "Weight:"
        '
        'lblcustomerName
        '
        Me.lblcustomerName.AutoSize = True
        Me.lblcustomerName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomerName.Location = New System.Drawing.Point(247, 214)
        Me.lblcustomerName.Name = "lblcustomerName"
        Me.lblcustomerName.Size = New System.Drawing.Size(130, 12)
        Me.lblcustomerName.TabIndex = 0
        Me.lblcustomerName.Text = "(Existing) Customer ID:"
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"M", "F", "U"})
        Me.cboGender.Location = New System.Drawing.Point(383, 118)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(54, 20)
        Me.cboGender.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(267, 296)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 83)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(383, 211)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(54, 20)
        Me.txtCustomerID.TabIndex = 1
        '
        'cboSpecies
        '
        Me.cboSpecies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Location = New System.Drawing.Point(383, 71)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.Size = New System.Drawing.Size(121, 20)
        Me.cboSpecies.TabIndex = 4
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreed.Location = New System.Drawing.Point(339, 170)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(42, 12)
        Me.lblBreed.TabIndex = 0
        Me.lblBreed.Text = "Breed:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(89, 118)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(206, 20)
        Me.dtpDOB.TabIndex = 5
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip.TabIndex = 6
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(217, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(84, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add Pet "
        '
        'AddPetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 391)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cboSpecies)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.lblBreed)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.lblcustomerName)
        Me.Controls.Add(Me.lblweight)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPetName)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "AddPetForm"
        Me.Text = "AddPetForm"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPetName As Label
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblSpecies As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents lblweight As Label
    Friend WithEvents lblcustomerName As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents cboSpecies As ComboBox
    Friend WithEvents lblBreed As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmiHelp As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiAboutCompany As ToolStripMenuItem
    Friend WithEvents tsmiAboutApplication As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
End Class
