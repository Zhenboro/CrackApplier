Public Class Main

    Dim DIRCommons As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Zhenboro\CrackApplier"

    Dim ProgramName As String = Nothing
    Dim CrackName As String = Nothing
    Dim CrackedFile As String = Nothing
    Dim CrackType As String = Nothing
    Dim InstallPath As String = Nothing
    Dim Author As String = Nothing
    Dim AuthorAction As String = Nothing
    Dim byteContent As Byte() = Nothing

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Info.Text = "Version " & My.Application.Info.Version.ToString & " (" & Application.ProductVersion & ")"
        CommonActions()
    End Sub

    Sub CommonActions()
        Try
            'Comprueba que exista la carpeta comun
            If Not My.Computer.FileSystem.DirectoryExists(DIRCommons) Then
                My.Computer.FileSystem.CreateDirectory(DIRCommons)
            End If

            'Carga la configuracion del Aplicador
            LoadInject()

            'Muestra la configuracion del Aplicador
            ShowApplierConfiguration()
        Catch ex As Exception
            Console.WriteLine("[CommonActions@Main]Error: " & ex.Message)
        End Try
    End Sub

    Sub LoadInject()
        Try
            FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read)
            Dim stubb As String = Space(LOF(1))
            Dim FileSplit = "|CA|"
            FileGet(1, stubb)
            FileClose(1)
            Dim opt() As String = Split(stubb, FileSplit)
            ProgramName = opt(1)
            CrackName = opt(2)
            CrackedFile = opt(3)
            CrackType = opt(4)
            InstallPath = opt(5)
            If opt(6).contains("|") Then
                Dim AuthorArgs() As String = opt(6).Split("|")
                Author = AuthorArgs(0)
                AuthorAction = AuthorArgs(1)
            Else
                Author = opt(6)
            End If
            Try
                byteContent = System.Text.Encoding.Default.GetBytes(opt(7))
            Catch
            End Try
        Catch ex As Exception
            MsgBox("Error al leer la configuracion del Aplicador" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error critico")
            Console.WriteLine("[LoadInject@Main]Error: " & ex.Message)
            End
        End Try
    End Sub
    Sub ShowApplierConfiguration()
        Try
            TB_ProgramName.Text = ProgramName
            TB_CrackName.Text = CrackName
            TB_CrackedFile.Text = CrackedFile
            TB_CrackType.Text = CrackType
            TB_InstallPath.Text = InstallPath
            Me.Text = CrackName & " for " & ProgramName & " - CrackApplier"
            If Author <> Nothing Then
                Lbl_Credits.Text = Author
            End If
        Catch ex As Exception
            Console.WriteLine("[ShowApplierConfiguration@Main]Error: " & ex.Message)
        End Try
    End Sub
    Sub CopyItTo(ByVal filePath As String)
        Try
            If My.Computer.FileSystem.FileExists(filePath) Then
                My.Computer.FileSystem.DeleteFile(filePath)
            End If
            If byteContent.Length > 0 Then
                My.Computer.FileSystem.WriteAllBytes(filePath, byteContent, False)
            Else
                My.Computer.FileSystem.WriteAllBytes(filePath, My.Resources.ResourceManager.GetObject("CrackFile"), False)
            End If
        Catch ex As Exception
            MsgBox("Error al extraer el parche." & vbCrLf & ex.Message)
            Console.WriteLine("[CopyItTo@Main]Error: " & ex.Message)
        End Try
    End Sub



    Private Sub Btn_OriginalBackup_Click(sender As Object, e As EventArgs) Handles Btn_OriginalBackup.Click
        Try
            Dim backupFilePath As String = DIRCommons & "\" & CrackedFile
            If My.Computer.FileSystem.FileExists(backupFilePath) Then
                If MessageBox.Show("Ya existe una copia de seguridad de '" & CrackedFile & "'" & vbCrLf & "¿Desea reemplazarla?", "Confirmar Reemplazar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(backupFilePath)
                Else
                    If MessageBox.Show("¿Desea restaurar la copia de seguridad?", "Confirmar Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If My.Computer.FileSystem.FileExists(InstallPath & "\" & CrackedFile) Then
                            My.Computer.FileSystem.DeleteFile(InstallPath & "\" & CrackedFile)
                        End If
                        My.Computer.FileSystem.CopyFile(backupFilePath, InstallPath & "\" & CrackedFile)
                        MsgBox("¡Copia de seguridad restaurada correctamente!")
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End If
            My.Computer.FileSystem.CopyFile(InstallPath & "\" & CrackedFile, backupFilePath)
            MsgBox("¡Copia de seguridad creada correctamente!" & vbCrLf & "El fichero se a guardado en: " & backupFilePath)
            If MessageBox.Show("¿Desea abrir la ruta que almacena la copia de seguridad?", "Ver copia de seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Process.Start("explorer.exe", "/select, " & backupFilePath)
            End If
        Catch ex As Exception
            MsgBox("Error al crear copia de seguridad." & vbCrLf & ex.Message)
            Console.WriteLine("[Btn_OriginalBackup_Click@Main]Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_AutoApply_Click(sender As Object, e As EventArgs) Handles Btn_AutoApply.Click
        Try
            Dim targetFilePath As String = InstallPath & "\" & CrackedFile
            CopyItTo(targetFilePath)
            MsgBox("¡Crack aplicado correctamente!", MsgBoxStyle.Information, "Crack Aplicado")
        Catch ex As Exception
            Console.WriteLine("[Btn_AutoApply_Click@Main]Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_ExtractCrack_Click(sender As Object, e As EventArgs) Handles Btn_ExtractCrack.Click
        Try
            Dim SaveCrack As New SaveFileDialog
            SaveCrack.Filter = "All file types (*.*)|*.*"
            SaveCrack.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            SaveCrack.Title = "Guardar parche..."
            SaveCrack.OverwritePrompt = True
            SaveCrack.FileName = CrackedFile
            If SaveCrack.ShowDialog() = DialogResult.OK Then
                CopyItTo(SaveCrack.FileName)
            End If
        Catch ex As Exception
            Console.WriteLine("[Btn_ExtractCrack_Click@Main]Error: " & ex.Message)
        End Try
    End Sub



    Private Sub Lbl_Credits_Click(sender As Object, e As EventArgs) Handles Lbl_Credits.Click
        Credits()
    End Sub
    Private Sub Main_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Credits()
    End Sub
    Sub Credits()
        Try
            If Author <> Nothing Then
                If AuthorAction <> Nothing Then
                    If MessageBox.Show("'" & ProgramName & " " & CrackName & "' was created by " & Author & vbCrLf & "¿Want some information about the author: " & Author & "?", "Credits", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Process.Start(AuthorAction)
                        Threading.Thread.Sleep(500)
                        MsgBox("CrackApplier was created by Zhenboro", MsgBoxStyle.Information, "CrackApplier")
                    End If
                Else
                    MessageBox.Show("'" & ProgramName & " " & CrackName & "' was created by " & Author, "Credits", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                End If
            Else
                If MessageBox.Show("Crack Applier was created and coded by Zhenboro." & vbCrLf & "¿Wanna see more information?", "Credits", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Process.Start("https://github.com/Zhenboro")
                    Threading.Thread.Sleep(500)
                    Process.Start("https://www.youtube.com/channel/UCSzZaz23dy19GXfSmlmxrOw")
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("[Credits@Main]Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Lbl_CrackedFile_Click(sender As Object, e As EventArgs) Handles Lbl_CrackedFile.Click
        Try
            Process.Start("explorer.exe", "/select, " & InstallPath & "\" & CrackedFile)
        Catch ex As Exception
            Console.WriteLine("[Lbl_CrackedFile_Click@Main]Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Lbl_InstallPath_Click(sender As Object, e As EventArgs) Handles Lbl_InstallPath.Click
        Try
            Process.Start(InstallPath)
        Catch ex As Exception
            Console.WriteLine("[Lbl_InstallPath_Click@Main]Error: " & ex.Message)
        End Try
    End Sub
End Class