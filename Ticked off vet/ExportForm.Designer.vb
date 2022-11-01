<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        ' Me.Ticked_off_databaseDataSet = New Ticked_off_vet.ticked_off_databaseDataSet()
        Me.PetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.PetTableAdapter = New Ticked_off_vet.ticked_off_databaseDataSetTableAdapters.petTableAdapter()
        ' Me.TableAdapterManager = New Ticked_off_vet.ticked_off_databaseDataSetTableAdapters.TableAdapterManager()
        Me.PetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDB = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        ' CType(Me.Ticked_off_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(153, 472)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(262, 81)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export Data To CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(149, 363)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(567, 22)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Press ""Export Data To CSV"" Export all of the above pet data ."
        '
        'Ticked_off_databaseDataSet
        '
        'Me.Ticked_off_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PetBindingSource
        '
        Me.PetBindingSource.DataMember = "pet"
        '  Me.PetBindingSource.DataSource = Me.Ticked_off_databaseDataSet
        '
        'PetTableAdapter
        '
        '  Me.PetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.bookingTableAdapter = Nothing
        'Me.TableAdapterManager.customerTableAdapter = Nothing
        'Me.TableAdapterManager.inventoryTableAdapter = Nothing
        'Me.TableAdapterManager.petTableAdapter = Me.PetTableAdapter
        'Me.TableAdapterManager.staffTableAdapter = Nothing
        'Me.TableAdapterManager.statesTableAdapter = Nothing
        'Me.TableAdapterManager.UpdateOrder = Ticked_off_vet.ticked_off_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PetBindingSource1
        '
        Me.PetBindingSource1.DataMember = "pet"
        '  Me.PetBindingSource1.DataSource = Me.Ticked_off_databaseDataSet
        '
        'dgvDB
        '
        Me.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDB.Location = New System.Drawing.Point(13, 38)
        Me.dgvDB.Name = "dgvDB"
        Me.dgvDB.Size = New System.Drawing.Size(789, 274)
        Me.dgvDB.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(455, 472)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(262, 81)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh Table"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 482)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 61)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(814, 24)
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
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(279, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(228, 22)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Export Pet Data To CSV"
        '
        'ExportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 565)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvDB)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExport)
        Me.Name = "ExportForm"
        Me.Text = "ExportForm"
        ' CType(Me.Ticked_off_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExport As Button
    Friend WithEvents lblDesc As Label
    'Friend WithEvents Ticked_off_databaseDataSet As ticked_off_databaseDataSet
    Friend WithEvents PetBindingSource As BindingSource
    ' Friend WithEvents PetTableAdapter As ticked_off_databaseDataSetTableAdapters.petTableAdapter
    'Friend WithEvents TableAdapterManager As ticked_off_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PetBindingSource1 As BindingSource
    Friend WithEvents dgvDB As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmiFile As ToolStripMenuItem
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiAboutCompany As ToolStripMenuItem
    Friend WithEvents tsmiAboutApplication As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
End Class
