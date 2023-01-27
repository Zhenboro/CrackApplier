<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.Lbl_Credits = New System.Windows.Forms.Label()
        Me.GB_Info = New System.Windows.Forms.GroupBox()
        Me.CB_CrackType = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Lbl_InstallPath = New System.Windows.Forms.Label()
        Me.TB_InstallPath = New System.Windows.Forms.TextBox()
        Me.Lbl_CrackType = New System.Windows.Forms.Label()
        Me.Lbl_CrackedFile = New System.Windows.Forms.Label()
        Me.TB_CrackedFile = New System.Windows.Forms.TextBox()
        Me.Lbl_CrackName = New System.Windows.Forms.Label()
        Me.TB_CrackName = New System.Windows.Forms.TextBox()
        Me.Lbl_ProgramName = New System.Windows.Forms.Label()
        Me.TB_ProgramName = New System.Windows.Forms.TextBox()
        Me.GB_Options = New System.Windows.Forms.GroupBox()
        Me.Btn_Create = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_AuthorName = New System.Windows.Forms.Label()
        Me.TB_AuthorName = New System.Windows.Forms.TextBox()
        Me.Lbl_AuthorWebsite = New System.Windows.Forms.Label()
        Me.TB_AuthorWebsite = New System.Windows.Forms.TextBox()
        Me.GB_Info.SuspendLayout()
        Me.GB_Options.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(291, 50)
        Me.Lbl_Title.TabIndex = 10
        Me.Lbl_Title.Text = "Crack Applier IDE"
        '
        'Lbl_Info
        '
        Me.Lbl_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.Lbl_Info.Location = New System.Drawing.Point(309, 9)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(208, 50)
        Me.Lbl_Info.TabIndex = 6
        Me.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_Credits
        '
        Me.Lbl_Credits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Credits.Location = New System.Drawing.Point(12, 411)
        Me.Lbl_Credits.Name = "Lbl_Credits"
        Me.Lbl_Credits.Size = New System.Drawing.Size(505, 37)
        Me.Lbl_Credits.TabIndex = 6
        Me.Lbl_Credits.Text = "Zhenboro"
        Me.Lbl_Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GB_Info
        '
        Me.GB_Info.Controls.Add(Me.TB_AuthorWebsite)
        Me.GB_Info.Controls.Add(Me.Lbl_AuthorWebsite)
        Me.GB_Info.Controls.Add(Me.Lbl_AuthorName)
        Me.GB_Info.Controls.Add(Me.TB_AuthorName)
        Me.GB_Info.Controls.Add(Me.CB_CrackType)
        Me.GB_Info.Controls.Add(Me.CheckBox1)
        Me.GB_Info.Controls.Add(Me.Lbl_InstallPath)
        Me.GB_Info.Controls.Add(Me.TB_InstallPath)
        Me.GB_Info.Controls.Add(Me.Lbl_CrackType)
        Me.GB_Info.Controls.Add(Me.Lbl_CrackedFile)
        Me.GB_Info.Controls.Add(Me.TB_CrackedFile)
        Me.GB_Info.Controls.Add(Me.Lbl_CrackName)
        Me.GB_Info.Controls.Add(Me.TB_CrackName)
        Me.GB_Info.Controls.Add(Me.Lbl_ProgramName)
        Me.GB_Info.Controls.Add(Me.TB_ProgramName)
        Me.GB_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Info.Location = New System.Drawing.Point(3, 3)
        Me.GB_Info.Name = "GB_Info"
        Me.GB_Info.Size = New System.Drawing.Size(491, 233)
        Me.GB_Info.TabIndex = 20
        Me.GB_Info.TabStop = False
        '
        'CB_CrackType
        '
        Me.CB_CrackType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CB_CrackType.FormattingEnabled = True
        Me.CB_CrackType.Location = New System.Drawing.Point(160, 98)
        Me.CB_CrackType.Name = "CB_CrackType"
        Me.CB_CrackType.Size = New System.Drawing.Size(289, 21)
        Me.CB_CrackType.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(216, 151)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Inject?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Lbl_InstallPath
        '
        Me.Lbl_InstallPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_InstallPath.AutoSize = True
        Me.Lbl_InstallPath.Location = New System.Drawing.Point(54, 128)
        Me.Lbl_InstallPath.Name = "Lbl_InstallPath"
        Me.Lbl_InstallPath.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_InstallPath.TabIndex = 80
        Me.Lbl_InstallPath.Text = "Install path:"
        '
        'TB_InstallPath
        '
        Me.TB_InstallPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_InstallPath.Location = New System.Drawing.Point(160, 125)
        Me.TB_InstallPath.Name = "TB_InstallPath"
        Me.TB_InstallPath.Size = New System.Drawing.Size(289, 20)
        Me.TB_InstallPath.TabIndex = 4
        '
        'Lbl_CrackType
        '
        Me.Lbl_CrackType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CrackType.AutoSize = True
        Me.Lbl_CrackType.Location = New System.Drawing.Point(54, 101)
        Me.Lbl_CrackType.Name = "Lbl_CrackType"
        Me.Lbl_CrackType.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_CrackType.TabIndex = 70
        Me.Lbl_CrackType.Text = "Crack type:"
        '
        'Lbl_CrackedFile
        '
        Me.Lbl_CrackedFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CrackedFile.AutoSize = True
        Me.Lbl_CrackedFile.Location = New System.Drawing.Point(49, 75)
        Me.Lbl_CrackedFile.Name = "Lbl_CrackedFile"
        Me.Lbl_CrackedFile.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_CrackedFile.TabIndex = 60
        Me.Lbl_CrackedFile.Text = "Cracked file:"
        '
        'TB_CrackedFile
        '
        Me.TB_CrackedFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_CrackedFile.Location = New System.Drawing.Point(160, 72)
        Me.TB_CrackedFile.Name = "TB_CrackedFile"
        Me.TB_CrackedFile.Size = New System.Drawing.Size(289, 20)
        Me.TB_CrackedFile.TabIndex = 2
        '
        'Lbl_CrackName
        '
        Me.Lbl_CrackName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CrackName.AutoSize = True
        Me.Lbl_CrackName.Location = New System.Drawing.Point(48, 49)
        Me.Lbl_CrackName.Name = "Lbl_CrackName"
        Me.Lbl_CrackName.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_CrackName.TabIndex = 50
        Me.Lbl_CrackName.Text = "Crack name:"
        '
        'TB_CrackName
        '
        Me.TB_CrackName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_CrackName.Location = New System.Drawing.Point(160, 46)
        Me.TB_CrackName.Name = "TB_CrackName"
        Me.TB_CrackName.Size = New System.Drawing.Size(289, 20)
        Me.TB_CrackName.TabIndex = 1
        '
        'Lbl_ProgramName
        '
        Me.Lbl_ProgramName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_ProgramName.AutoSize = True
        Me.Lbl_ProgramName.Location = New System.Drawing.Point(37, 23)
        Me.Lbl_ProgramName.Name = "Lbl_ProgramName"
        Me.Lbl_ProgramName.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_ProgramName.TabIndex = 40
        Me.Lbl_ProgramName.Text = "Program name:"
        '
        'TB_ProgramName
        '
        Me.TB_ProgramName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_ProgramName.Location = New System.Drawing.Point(160, 20)
        Me.TB_ProgramName.Name = "TB_ProgramName"
        Me.TB_ProgramName.Size = New System.Drawing.Size(289, 20)
        Me.TB_ProgramName.TabIndex = 0
        '
        'GB_Options
        '
        Me.GB_Options.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Options.Controls.Add(Me.Btn_Create)
        Me.GB_Options.Location = New System.Drawing.Point(12, 333)
        Me.GB_Options.Name = "GB_Options"
        Me.GB_Options.Size = New System.Drawing.Size(505, 75)
        Me.GB_Options.TabIndex = 30
        Me.GB_Options.TabStop = False
        '
        'Btn_Create
        '
        Me.Btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Create.Location = New System.Drawing.Point(157, 20)
        Me.Btn_Create.Name = "Btn_Create"
        Me.Btn_Create.Size = New System.Drawing.Size(191, 34)
        Me.Btn_Create.TabIndex = 8
        Me.Btn_Create.Text = "Create CrackApplier"
        Me.Btn_Create.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(505, 265)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GB_Info)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(497, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(497, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Scripting"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 204)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Post Script"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Post Script"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(479, 185)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(395, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PowerShell (*.ps1)"
        '
        'Lbl_AuthorName
        '
        Me.Lbl_AuthorName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_AuthorName.AutoSize = True
        Me.Lbl_AuthorName.Location = New System.Drawing.Point(54, 182)
        Me.Lbl_AuthorName.Name = "Lbl_AuthorName"
        Me.Lbl_AuthorName.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_AuthorName.TabIndex = 83
        Me.Lbl_AuthorName.Text = "Author name:"
        '
        'TB_AuthorName
        '
        Me.TB_AuthorName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_AuthorName.Location = New System.Drawing.Point(160, 179)
        Me.TB_AuthorName.Name = "TB_AuthorName"
        Me.TB_AuthorName.Size = New System.Drawing.Size(183, 20)
        Me.TB_AuthorName.TabIndex = 6
        '
        'Lbl_AuthorWebsite
        '
        Me.Lbl_AuthorWebsite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_AuthorWebsite.AutoSize = True
        Me.Lbl_AuthorWebsite.Location = New System.Drawing.Point(44, 208)
        Me.Lbl_AuthorWebsite.Name = "Lbl_AuthorWebsite"
        Me.Lbl_AuthorWebsite.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_AuthorWebsite.TabIndex = 84
        Me.Lbl_AuthorWebsite.Text = "Author website:"
        '
        'TB_AuthorWebsite
        '
        Me.TB_AuthorWebsite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_AuthorWebsite.Location = New System.Drawing.Point(160, 205)
        Me.TB_AuthorWebsite.Name = "TB_AuthorWebsite"
        Me.TB_AuthorWebsite.Size = New System.Drawing.Size(183, 20)
        Me.TB_AuthorWebsite.TabIndex = 7
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GB_Options)
        Me.Controls.Add(Me.Lbl_Credits)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.Lbl_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crack Applier IDE by Zhenboro"
        Me.GB_Info.ResumeLayout(False)
        Me.GB_Info.PerformLayout()
        Me.GB_Options.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Lbl_Info As Label
    Friend WithEvents Lbl_Credits As Label
    Friend WithEvents GB_Info As GroupBox
    Friend WithEvents Lbl_InstallPath As Label
    Friend WithEvents TB_InstallPath As TextBox
    Friend WithEvents Lbl_CrackType As Label
    Friend WithEvents Lbl_CrackedFile As Label
    Friend WithEvents TB_CrackedFile As TextBox
    Friend WithEvents Lbl_CrackName As Label
    Friend WithEvents TB_CrackName As TextBox
    Friend WithEvents Lbl_ProgramName As Label
    Friend WithEvents TB_ProgramName As TextBox
    Friend WithEvents GB_Options As GroupBox
    Friend WithEvents Btn_Create As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CB_CrackType As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_AuthorWebsite As TextBox
    Friend WithEvents Lbl_AuthorWebsite As Label
    Friend WithEvents Lbl_AuthorName As Label
    Friend WithEvents TB_AuthorName As TextBox
End Class
