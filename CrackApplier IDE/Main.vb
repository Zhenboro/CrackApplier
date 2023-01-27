Imports System.IO
Public Class Main

    Dim DIRCommons As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Zhenboro\CrackApplier"

    Dim BinaryFilePath As String = "CrackApplier.exe"
    Dim SaveBinaryFilePath As String = Nothing
    Dim PatchedCrackFilePath As String = Nothing

    Dim ProgramName As String = Nothing
    Dim CrackName As String = Nothing
    Dim CrackedFile As String = Nothing
    Dim CrackType As String = Nothing
    Dim InstallPath As String = Nothing
    Dim PostScriptContent As String = Nothing

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Info.Text = "Version " & My.Application.Info.Version.ToString & " (" & Application.ProductVersion & ")"
        AddTypes()
    End Sub

    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles Btn_Create.Click
        Try
            If TB_ProgramName.Text = Nothing Or TB_CrackName.Text = Nothing Or TB_CrackedFile.Text = Nothing Or CB_CrackType.Text = Nothing Or TB_InstallPath.Text = Nothing Then
                MsgBox("No puede dejar informacion vacia", MsgBoxStyle.Critical, "Aplicar configuracion")
            Else

                ProgramName = TB_ProgramName.Text
                CrackName = TB_CrackName.Text
                CrackedFile = TB_CrackedFile.Text
                CrackType = CB_CrackType.Text
                InstallPath = TB_InstallPath.Text
                If CheckBox2.Checked Then
                    PostScriptContent = RichTextBox1.Text
                Else
                    PostScriptContent = Nothing
                End If

                Dim OpenBinary As New OpenFileDialog
                OpenBinary.Filter = "Executable file (*.exe)|*.exe"
                OpenBinary.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                OpenBinary.Title = "Abrir binario..."
                OpenBinary.FileName = BinaryFilePath
                If OpenBinary.ShowDialog() = DialogResult.OK Then
                    BinaryFilePath = OpenBinary.FileName
                    Dim SaveBinary As New SaveFileDialog
                    SaveBinary.Filter = "Executable file (*.exe)|*.exe"
                    SaveBinary.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    SaveBinary.Title = "Guardar binario..."
                    SaveBinary.OverwritePrompt = True
                    If SaveBinaryFilePath = Nothing Then
                        SaveBinaryFilePath = "CrackApplier for " & CrackName & ".exe"
                    End If
                    SaveBinary.FileName = SaveBinaryFilePath
                    If SaveBinary.ShowDialog() = DialogResult.OK Then
                        SaveBinaryFilePath = SaveBinary.FileName
                    End If
                    Dim stub As String
                    Const FS1 As String = "|CA|"
                    Dim bytesEXE As Byte() = System.IO.File.ReadAllBytes(BinaryFilePath)
                    File.WriteAllBytes(SaveBinaryFilePath, bytesEXE)
                    FileOpen(1, SaveBinaryFilePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                    stub = Space(LOF(1))
                    FileGet(1, stub)
                    FileClose(1)
                    FileOpen(1, SaveBinaryFilePath, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                    Dim Author = TB_AuthorName.Text
                    Dim AuthorAction = TB_AuthorWebsite.Text
                    Dim AuthorInfo As String = Author & "|" & AuthorAction
                    If AuthorAction = Nothing Then
                        AuthorInfo = Author
                    End If
                    If CheckBox1.Checked Then
                        Dim openCrackFile As New OpenFileDialog
                        openCrackFile.Filter = "All file types(*.*)|*.*"
                        openCrackFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        openCrackFile.Title = "Abrir parche..."
                        openCrackFile.FileName = PatchedCrackFilePath
                        If openCrackFile.ShowDialog() = DialogResult.OK Then
                            PatchedCrackFilePath = openCrackFile.FileName
                            Dim Content As Byte() = My.Computer.FileSystem.ReadAllBytes(PatchedCrackFilePath)
                            FilePut(1, stub & FS1 &
                                    ProgramName & FS1 &
                                    CrackName & FS1 &
                                    CrackedFile & FS1 &
                                    CrackType & FS1 &
                                    InstallPath & FS1 &
                                    AuthorInfo & FS1 &
                                    System.Text.Encoding.Default.GetString(Content) & FS1 &
                                    PostScriptContent & FS1)
                        End If
                    Else
                        FilePut(1, stub & FS1 &
                                ProgramName & FS1 &
                                CrackName & FS1 &
                                CrackedFile & FS1 &
                                CrackType & FS1 &
                                InstallPath & FS1 &
                                AuthorInfo)
                    End If
                    FileClose(1)
                    MsgBox("¡CrackApplier creado correctamente!", MsgBoxStyle.Information, "Creacion de Aplicador")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al crear el Aplicador" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error critico")
            Console.WriteLine("[Btn_Create_Click@Main]Error: " & ex.Message)
        End Try
    End Sub

    Sub AddTypes()
        Try
            CB_CrackType.Items.Add("Licence")
            CB_CrackType.Items.Add("Password")
            CB_CrackType.Items.Add("ByPass")
            CB_CrackType.Items.Add("Auth")
            CB_CrackType.Items.Add("Code/Serial")
            CB_CrackType.Items.Add("Crack")
        Catch ex As Exception
            Console.WriteLine("[AddTypes@Main]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        GroupBox1.Enabled = CheckBox2.Checked
    End Sub
End Class