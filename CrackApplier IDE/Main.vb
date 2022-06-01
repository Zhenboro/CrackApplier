Imports System.IO
Public Class Main

    Dim DIRCommons As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Zhenboro\CrackApplier"

    Dim ProgramName As String = Nothing
    Dim CrackName As String = Nothing
    Dim CrackedFile As String = Nothing
    Dim CrackType As String = Nothing
    Dim InstallPath As String = Nothing

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

                Dim OpenBinary As New OpenFileDialog
                OpenBinary.Filter = "Executable file (*.exe)|*.exe"
                OpenBinary.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                OpenBinary.Title = "Abrir binario..."
                OpenBinary.FileName = "CrackApplier.exe"
                If OpenBinary.ShowDialog() = DialogResult.OK Then
                    Dim Temp As String = Nothing
                    Dim SaveBinary As New SaveFileDialog
                    SaveBinary.Filter = "Executable file (*.exe)|*.exe"
                    SaveBinary.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    SaveBinary.Title = "Guardar binario..."
                    SaveBinary.OverwritePrompt = True
                    SaveBinary.FileName = "CrackApplier for " & CrackName & ".exe"
                    If SaveBinary.ShowDialog() = DialogResult.OK Then
                        Temp = SaveBinary.FileName
                    End If
                    Dim stub As String
                    Const FS1 As String = "|CA|"
                    Dim bytesEXE As Byte() = System.IO.File.ReadAllBytes(OpenBinary.FileName)
                    File.WriteAllBytes(Temp, bytesEXE)
                    FileOpen(1, Temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                    stub = Space(LOF(1))
                    FileGet(1, stub)
                    FileClose(1)
                    FileOpen(1, Temp, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                    If CheckBox1.Checked Then
                        Dim openCrackFile As New OpenFileDialog
                        openCrackFile.Filter = "All file types(*.*)|*.*"
                        openCrackFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        openCrackFile.Title = "Abrir parche..."
                        If openCrackFile.ShowDialog() = DialogResult.OK Then
                            Dim Content As Byte() = My.Computer.FileSystem.ReadAllBytes(openCrackFile.FileName)
                            FilePut(1, stub & FS1 & ProgramName & FS1 & CrackName & FS1 & CrackedFile & FS1 & CrackType & FS1 & InstallPath & FS1 & System.Text.Encoding.Default.GetString(Content) & FS1)
                        End If
                    Else
                        FilePut(1, stub & FS1 & ProgramName & FS1 & CrackName & FS1 & CrackedFile & FS1 & CrackType & FS1 & InstallPath & FS1)
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
End Class