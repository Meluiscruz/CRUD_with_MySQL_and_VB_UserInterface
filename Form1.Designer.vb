<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventory
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.strCodeBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.strNameBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.strDescriptionBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.strCostBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.strSaleBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.strSuppliesBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.strNoteBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CreateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UpdateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.tblQuery = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.strQueryByNameBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ExportButton = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.tblQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strCodeBox
        '
        Me.strCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strCodeBox.DefaultText = ""
        Me.strCodeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strCodeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strCodeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strCodeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strCodeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strCodeBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strCodeBox.ForeColor = System.Drawing.Color.Black
        Me.strCodeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strCodeBox.Location = New System.Drawing.Point(48, 48)
        Me.strCodeBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strCodeBox.Name = "strCodeBox"
        Me.strCodeBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strCodeBox.PlaceholderText = "Product's Code"
        Me.strCodeBox.SelectedText = ""
        Me.strCodeBox.Size = New System.Drawing.Size(432, 49)
        Me.strCodeBox.TabIndex = 0
        '
        'strNameBox
        '
        Me.strNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strNameBox.DefaultText = ""
        Me.strNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strNameBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strNameBox.ForeColor = System.Drawing.Color.Black
        Me.strNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strNameBox.Location = New System.Drawing.Point(48, 103)
        Me.strNameBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strNameBox.Name = "strNameBox"
        Me.strNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strNameBox.PlaceholderText = "Product's Name"
        Me.strNameBox.SelectedText = ""
        Me.strNameBox.Size = New System.Drawing.Size(432, 49)
        Me.strNameBox.TabIndex = 1
        '
        'strDescriptionBox
        '
        Me.strDescriptionBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strDescriptionBox.DefaultText = ""
        Me.strDescriptionBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strDescriptionBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strDescriptionBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strDescriptionBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strDescriptionBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strDescriptionBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strDescriptionBox.ForeColor = System.Drawing.Color.Black
        Me.strDescriptionBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strDescriptionBox.Location = New System.Drawing.Point(48, 158)
        Me.strDescriptionBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strDescriptionBox.Name = "strDescriptionBox"
        Me.strDescriptionBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strDescriptionBox.PlaceholderText = "Product's Description"
        Me.strDescriptionBox.SelectedText = ""
        Me.strDescriptionBox.Size = New System.Drawing.Size(432, 49)
        Me.strDescriptionBox.TabIndex = 2
        '
        'strCostBox
        '
        Me.strCostBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strCostBox.DefaultText = ""
        Me.strCostBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strCostBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strCostBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strCostBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strCostBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strCostBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strCostBox.ForeColor = System.Drawing.Color.Black
        Me.strCostBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strCostBox.Location = New System.Drawing.Point(48, 215)
        Me.strCostBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strCostBox.Name = "strCostBox"
        Me.strCostBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strCostBox.PlaceholderText = "Purchase Price"
        Me.strCostBox.SelectedText = ""
        Me.strCostBox.Size = New System.Drawing.Size(432, 49)
        Me.strCostBox.TabIndex = 3
        '
        'strSaleBox
        '
        Me.strSaleBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strSaleBox.DefaultText = ""
        Me.strSaleBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strSaleBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strSaleBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strSaleBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strSaleBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strSaleBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strSaleBox.ForeColor = System.Drawing.Color.Black
        Me.strSaleBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strSaleBox.Location = New System.Drawing.Point(48, 271)
        Me.strSaleBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strSaleBox.Name = "strSaleBox"
        Me.strSaleBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strSaleBox.PlaceholderText = "Sale Price"
        Me.strSaleBox.SelectedText = ""
        Me.strSaleBox.Size = New System.Drawing.Size(432, 49)
        Me.strSaleBox.TabIndex = 4
        '
        'strSuppliesBox
        '
        Me.strSuppliesBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strSuppliesBox.DefaultText = ""
        Me.strSuppliesBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strSuppliesBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strSuppliesBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strSuppliesBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strSuppliesBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strSuppliesBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strSuppliesBox.ForeColor = System.Drawing.Color.Black
        Me.strSuppliesBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strSuppliesBox.Location = New System.Drawing.Point(48, 328)
        Me.strSuppliesBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strSuppliesBox.Name = "strSuppliesBox"
        Me.strSuppliesBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strSuppliesBox.PlaceholderText = "Supplies"
        Me.strSuppliesBox.SelectedText = ""
        Me.strSuppliesBox.Size = New System.Drawing.Size(432, 49)
        Me.strSuppliesBox.TabIndex = 5
        '
        'strNoteBox
        '
        Me.strNoteBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strNoteBox.DefaultText = ""
        Me.strNoteBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strNoteBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strNoteBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strNoteBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strNoteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strNoteBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strNoteBox.ForeColor = System.Drawing.Color.Black
        Me.strNoteBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strNoteBox.Location = New System.Drawing.Point(48, 383)
        Me.strNoteBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strNoteBox.Name = "strNoteBox"
        Me.strNoteBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strNoteBox.PlaceholderText = "Notes"
        Me.strNoteBox.SelectedText = ""
        Me.strNoteBox.Size = New System.Drawing.Size(432, 49)
        Me.strNoteBox.TabIndex = 6
        '
        'CreateButton
        '
        Me.CreateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CreateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CreateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CreateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CreateButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateButton.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.CreateButton.ForeColor = System.Drawing.Color.White
        Me.CreateButton.Location = New System.Drawing.Point(512, 45)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(250, 60)
        Me.CreateButton.TabIndex = 7
        Me.CreateButton.Text = "New Item"
        '
        'SaveButton
        '
        Me.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SaveButton.Enabled = False
        Me.SaveButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(512, 117)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(250, 60)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save"
        '
        'DeleteButton
        '
        Me.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(512, 262)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(250, 60)
        Me.DeleteButton.TabIndex = 10
        Me.DeleteButton.Text = "Delete"
        '
        'UpdateButton
        '
        Me.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdateButton.FillColor = System.Drawing.Color.Yellow
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateButton.ForeColor = System.Drawing.Color.Black
        Me.UpdateButton.Location = New System.Drawing.Point(512, 189)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(250, 60)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "Update"
        '
        'tblQuery
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.tblQuery.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblQuery.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.tblQuery.ColumnHeadersHeight = 22
        Me.tblQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblQuery.DefaultCellStyle = DataGridViewCellStyle18
        Me.tblQuery.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblQuery.Location = New System.Drawing.Point(46, 469)
        Me.tblQuery.Name = "tblQuery"
        Me.tblQuery.RowHeadersVisible = False
        Me.tblQuery.RowHeadersWidth = 62
        Me.tblQuery.RowTemplate.Height = 28
        Me.tblQuery.Size = New System.Drawing.Size(1120, 288)
        Me.tblQuery.TabIndex = 11
        Me.tblQuery.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.tblQuery.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.tblQuery.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.tblQuery.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.tblQuery.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.tblQuery.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.tblQuery.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblQuery.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblQuery.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tblQuery.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblQuery.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.tblQuery.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tblQuery.ThemeStyle.HeaderStyle.Height = 22
        Me.tblQuery.ThemeStyle.ReadOnly = False
        Me.tblQuery.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.tblQuery.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tblQuery.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblQuery.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblQuery.ThemeStyle.RowsStyle.Height = 28
        Me.tblQuery.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblQuery.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'strQueryByNameBox
        '
        Me.strQueryByNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.strQueryByNameBox.DefaultText = ""
        Me.strQueryByNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.strQueryByNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.strQueryByNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strQueryByNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.strQueryByNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strQueryByNameBox.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.strQueryByNameBox.ForeColor = System.Drawing.Color.Black
        Me.strQueryByNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.strQueryByNameBox.Location = New System.Drawing.Point(663, 389)
        Me.strQueryByNameBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.strQueryByNameBox.Name = "strQueryByNameBox"
        Me.strQueryByNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.strQueryByNameBox.PlaceholderText = "Query by Product's Name"
        Me.strQueryByNameBox.SelectedText = ""
        Me.strQueryByNameBox.Size = New System.Drawing.Size(504, 49)
        Me.strQueryByNameBox.TabIndex = 12
        '
        'ExportButton
        '
        Me.ExportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExportButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExportButton.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ExportButton.ForeColor = System.Drawing.Color.White
        Me.ExportButton.Location = New System.Drawing.Point(912, 312)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(250, 60)
        Me.ExportButton.TabIndex = 13
        Me.ExportButton.Text = "Print Query"
        '
        'FormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 797)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.strQueryByNameBox)
        Me.Controls.Add(Me.tblQuery)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.strNoteBox)
        Me.Controls.Add(Me.strSuppliesBox)
        Me.Controls.Add(Me.strSaleBox)
        Me.Controls.Add(Me.strCostBox)
        Me.Controls.Add(Me.strDescriptionBox)
        Me.Controls.Add(Me.strNameBox)
        Me.Controls.Add(Me.strCodeBox)
        Me.Name = "FormInventory"
        Me.Text = "Inventory"
        CType(Me.tblQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents strCodeBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents strNameBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents strDescriptionBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents strCostBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents strSaleBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents strSuppliesBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents strNoteBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CreateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UpdateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tblQuery As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents strQueryByNameBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ExportButton As Guna.UI2.WinForms.Guna2Button
End Class
