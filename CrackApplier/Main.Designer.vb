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
        Me.components = New System.ComponentModel.Container()
        Me.TB_ProgramName = New System.Windows.Forms.TextBox()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.GB_Info = New System.Windows.Forms.GroupBox()
        Me.Lbl_InstallPath = New System.Windows.Forms.Label()
        Me.TB_InstallPath = New System.Windows.Forms.TextBox()
        Me.Lbl_CrackType = New System.Windows.Forms.Label()
        Me.TB_CrackType = New System.Windows.Forms.TextBox()
        Me.Lbl_CrackedFile = New System.Windows.Forms.Label()
        Me.TB_CrackedFile = New System.Windows.Forms.TextBox()
        Me.Lbl_CrackName = New System.Windows.Forms.Label()
        Me.TB_CrackName = New System.Windows.Forms.TextBox()
        Me.Lbl_ProgramName = New System.Windows.Forms.Label()
        Me.GB_Options = New System.Windows.Forms.GroupBox()
        Me.Btn_AutoApply = New System.Windows.Forms.Button()
        Me.Btn_ExtractCrack = New System.Windows.Forms.Button()
        Me.Btn_OriginalBackup = New System.Windows.Forms.Button()
        Me.Lbl_Credits = New System.Windows.Forms.Label()
        Me.MyToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.GB_Info.SuspendLayout()
        Me.GB_Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_ProgramName
        '
        Me.TB_ProgramName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_ProgramName.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_ProgramName.Location = New System.Drawing.Point(140, 27)
        Me.TB_ProgramName.Name = "TB_ProgramName"
        Me.TB_ProgramName.ReadOnly = True
        Me.TB_ProgramName.Size = New System.Drawing.Size(322, 20)
        Me.TB_ProgramName.TabIndex = 3
        Me.MyToolTip.SetToolTip(Me.TB_ProgramName, "Indica el nombre del programa al cual va dirigido el crack")
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(229, 50)
        Me.Lbl_Title.TabIndex = 8
        Me.Lbl_Title.Text = "Crack Applier"
        '
        'GB_Info
        '
        Me.GB_Info.Controls.Add(Me.Lbl_InstallPath)
        Me.GB_Info.Controls.Add(Me.TB_InstallPath)
        Me.GB_Info.Controls.Add(Me.Lbl_CrackType)
        Me.GB_Info.Controls.Add(Me.TB_CrackType)
        Me.GB_Info.Controls.Add(Me.Lbl_CrackedFile)
        Me.GB_Info.Controls.Add(Me.TB_CrackedFile)
        Me.GB_Info.Controls.Add(Me.Lbl_CrackName)
        Me.GB_Info.Controls.Add(Me.TB_CrackName)
        Me.GB_Info.Controls.Add(Me.Lbl_ProgramName)
        Me.GB_Info.Controls.Add(Me.TB_ProgramName)
        Me.GB_Info.Location = New System.Drawing.Point(22, 72)
        Me.GB_Info.Name = "GB_Info"
        Me.GB_Info.Size = New System.Drawing.Size(484, 179)
        Me.GB_Info.TabIndex = 60
        Me.GB_Info.TabStop = False
        '
        'Lbl_InstallPath
        '
        Me.Lbl_InstallPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_InstallPath.AutoSize = True
        Me.Lbl_InstallPath.Location = New System.Drawing.Point(34, 134)
        Me.Lbl_InstallPath.Name = "Lbl_InstallPath"
        Me.Lbl_InstallPath.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_InstallPath.TabIndex = 50
        Me.Lbl_InstallPath.Text = "Install path:"
        Me.MyToolTip.SetToolTip(Me.Lbl_InstallPath, "Ruta de instalacion")
        '
        'TB_InstallPath
        '
        Me.TB_InstallPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_InstallPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_InstallPath.Location = New System.Drawing.Point(140, 131)
        Me.TB_InstallPath.Name = "TB_InstallPath"
        Me.TB_InstallPath.ReadOnly = True
        Me.TB_InstallPath.Size = New System.Drawing.Size(322, 20)
        Me.TB_InstallPath.TabIndex = 7
        Me.MyToolTip.SetToolTip(Me.TB_InstallPath, "Indica en donde se copiara el ejecutable/complemento modificado")
        '
        'Lbl_CrackType
        '
        Me.Lbl_CrackType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CrackType.AutoSize = True
        Me.Lbl_CrackType.Location = New System.Drawing.Point(34, 108)
        Me.Lbl_CrackType.Name = "Lbl_CrackType"
        Me.Lbl_CrackType.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_CrackType.TabIndex = 40
        Me.Lbl_CrackType.Text = "Crack type:"
        Me.MyToolTip.SetToolTip(Me.Lbl_CrackType, "Tipo de crack")
        '
        'TB_CrackType
        '
        Me.TB_CrackType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_CrackType.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_CrackType.Location = New System.Drawing.Point(140, 105)
        Me.TB_CrackType.Name = "TB_CrackType"
        Me.TB_CrackType.ReadOnly = True
        Me.TB_CrackType.Size = New System.Drawing.Size(322, 20)
        Me.TB_CrackType.TabIndex = 6
        Me.MyToolTip.SetToolTip(Me.TB_CrackType, "Indica el tipo de crack")
        '
        'Lbl_CrackedFile
        '
        Me.Lbl_CrackedFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CrackedFile.AutoSize = True
        Me.Lbl_CrackedFile.Location = New System.Drawing.Point(34, 82)
        Me.Lbl_CrackedFile.Name = "Lbl_CrackedFile"
        Me.Lbl_CrackedFile.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_CrackedFile.TabIndex = 30
        Me.Lbl_CrackedFile.Text = "Cracked file:"
        Me.MyToolTip.SetToolTip(Me.Lbl_CrackedFile, "Nombre del fichero a modificar")
        '
        'TB_CrackedFile
        '
        Me.TB_CrackedFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_CrackedFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_CrackedFile.Location = New System.Drawing.Point(140, 79)
        Me.TB_CrackedFile.Name = "TB_CrackedFile"
        Me.TB_CrackedFile.ReadOnly = True
        Me.TB_CrackedFile.Size = New System.Drawing.Size(322, 20)
        Me.TB_CrackedFile.TabIndex = 5
        Me.MyToolTip.SetToolTip(Me.TB_CrackedFile, "Indica el nombre del ejecutable/complemento original que sera reemplazado por la " &
        "version modificada")
        '
        'Lbl_CrackName
        '
        Me.Lbl_CrackName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CrackName.AutoSize = True
        Me.Lbl_CrackName.Location = New System.Drawing.Point(34, 56)
        Me.Lbl_CrackName.Name = "Lbl_CrackName"
        Me.Lbl_CrackName.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_CrackName.TabIndex = 20
        Me.Lbl_CrackName.Text = "Crack name:"
        Me.MyToolTip.SetToolTip(Me.Lbl_CrackName, "Nombre del parche")
        '
        'TB_CrackName
        '
        Me.TB_CrackName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_CrackName.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_CrackName.Location = New System.Drawing.Point(140, 53)
        Me.TB_CrackName.Name = "TB_CrackName"
        Me.TB_CrackName.ReadOnly = True
        Me.TB_CrackName.Size = New System.Drawing.Size(322, 20)
        Me.TB_CrackName.TabIndex = 4
        Me.MyToolTip.SetToolTip(Me.TB_CrackName, "Indica el nombre del ejecutable/complemento modificado que esta contenido en Crac" &
        "kApplier")
        '
        'Lbl_ProgramName
        '
        Me.Lbl_ProgramName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_ProgramName.AutoSize = True
        Me.Lbl_ProgramName.Location = New System.Drawing.Point(23, 30)
        Me.Lbl_ProgramName.Name = "Lbl_ProgramName"
        Me.Lbl_ProgramName.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_ProgramName.TabIndex = 10
        Me.Lbl_ProgramName.Text = "Program name:"
        Me.MyToolTip.SetToolTip(Me.Lbl_ProgramName, "Nombre del programa")
        '
        'GB_Options
        '
        Me.GB_Options.Controls.Add(Me.Btn_AutoApply)
        Me.GB_Options.Controls.Add(Me.Btn_ExtractCrack)
        Me.GB_Options.Controls.Add(Me.Btn_OriginalBackup)
        Me.GB_Options.Location = New System.Drawing.Point(16, 257)
        Me.GB_Options.Name = "GB_Options"
        Me.GB_Options.Size = New System.Drawing.Size(497, 75)
        Me.GB_Options.TabIndex = 70
        Me.GB_Options.TabStop = False
        '
        'Btn_AutoApply
        '
        Me.Btn_AutoApply.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_AutoApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AutoApply.Location = New System.Drawing.Point(153, 23)
        Me.Btn_AutoApply.Name = "Btn_AutoApply"
        Me.Btn_AutoApply.Size = New System.Drawing.Size(191, 34)
        Me.Btn_AutoApply.TabIndex = 1
        Me.Btn_AutoApply.Text = "Auto Apply"
        Me.MyToolTip.SetToolTip(Me.Btn_AutoApply, "Instala el ejecutable modificado (crack) automaticamente")
        Me.Btn_AutoApply.UseVisualStyleBackColor = True
        '
        'Btn_ExtractCrack
        '
        Me.Btn_ExtractCrack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_ExtractCrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ExtractCrack.Location = New System.Drawing.Point(350, 23)
        Me.Btn_ExtractCrack.Name = "Btn_ExtractCrack"
        Me.Btn_ExtractCrack.Size = New System.Drawing.Size(130, 34)
        Me.Btn_ExtractCrack.TabIndex = 2
        Me.Btn_ExtractCrack.Text = "Extract crack to"
        Me.MyToolTip.SetToolTip(Me.Btn_ExtractCrack, "Extrae el ejecutable (crack) de CrackApplier y guardalo en algun lugar")
        Me.Btn_ExtractCrack.UseVisualStyleBackColor = True
        '
        'Btn_OriginalBackup
        '
        Me.Btn_OriginalBackup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_OriginalBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_OriginalBackup.Location = New System.Drawing.Point(17, 23)
        Me.Btn_OriginalBackup.Name = "Btn_OriginalBackup"
        Me.Btn_OriginalBackup.Size = New System.Drawing.Size(130, 34)
        Me.Btn_OriginalBackup.TabIndex = 0
        Me.Btn_OriginalBackup.Text = "Original Backup"
        Me.MyToolTip.SetToolTip(Me.Btn_OriginalBackup, "Crea una copia del ejecutable original (Recomendado)")
        Me.Btn_OriginalBackup.UseVisualStyleBackColor = True
        '
        'Lbl_Credits
        '
        Me.Lbl_Credits.Cursor = System.Windows.Forms.Cursors.Help
        Me.Lbl_Credits.Location = New System.Drawing.Point(12, 335)
        Me.Lbl_Credits.Name = "Lbl_Credits"
        Me.Lbl_Credits.Size = New System.Drawing.Size(504, 37)
        Me.Lbl_Credits.TabIndex = 9
        Me.Lbl_Credits.Text = "Zhenboro"
        Me.Lbl_Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MyToolTip.SetToolTip(Me.Lbl_Credits, "CrackApplier desarrollado por Zhenboro.")
        '
        'Lbl_Info
        '
        Me.Lbl_Info.Cursor = System.Windows.Forms.Cursors.Help
        Me.Lbl_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.Lbl_Info.Location = New System.Drawing.Point(247, 9)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(270, 13)
        Me.Lbl_Info.TabIndex = 5
        Me.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 381)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.Lbl_Credits)
        Me.Controls.Add(Me.GB_Options)
        Me.Controls.Add(Me.GB_Info)
        Me.Controls.Add(Me.Lbl_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crack Applier by Zhenboro"
        Me.TopMost = True
        Me.GB_Info.ResumeLayout(False)
        Me.GB_Info.PerformLayout()
        Me.GB_Options.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_ProgramName As TextBox
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents GB_Info As GroupBox
    Friend WithEvents Lbl_ProgramName As Label
    Friend WithEvents Lbl_CrackType As Label
    Friend WithEvents TB_CrackType As TextBox
    Friend WithEvents Lbl_CrackedFile As Label
    Friend WithEvents TB_CrackedFile As TextBox
    Friend WithEvents Lbl_CrackName As Label
    Friend WithEvents TB_CrackName As TextBox
    Friend WithEvents Lbl_InstallPath As Label
    Friend WithEvents TB_InstallPath As TextBox
    Friend WithEvents GB_Options As GroupBox
    Friend WithEvents Btn_OriginalBackup As Button
    Friend WithEvents Btn_AutoApply As Button
    Friend WithEvents Btn_ExtractCrack As Button
    Friend WithEvents Lbl_Credits As Label
    Friend WithEvents MyToolTip As ToolTip
    Friend WithEvents Lbl_Info As Label
End Class
