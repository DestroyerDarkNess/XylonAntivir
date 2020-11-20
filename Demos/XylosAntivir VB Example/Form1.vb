Imports System.IO
Imports Xylon_Antivir.Lxib

Public Class Form1

    Dim Engine As Antivir = New Antivir()
    Dim EngineHash As Hash = New Hash()

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        folderBrowserDialog1.ShowNewFolderButton = True
        Dim result As DialogResult = folderBrowserDialog1.ShowDialog()


        If result = DialogResult.OK Then
            listBox1.Items.Clear()
            textBox1.Text = folderBrowserDialog1.SelectedPath
            Dim files As String() = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories)

            For Each file As String In files
                Dim FilePath As String = file
                Dim FileName As String = Path.GetFileName(file)
                Dim ScanResult As String = Engine.FileScan(FilePath, True, False, False)

                If ScanResult <> "False" Then
                    Dim VirusInfo As String() = ScanResult.Split("|".ToCharArray())
                    Dim FilePathEx As String = VirusInfo(0)
                    Dim VirusDefinition As String = VirusInfo(1)
                    listBox1.Items.Add("Name: " & FileName & " Path : " & FilePathEx & " Sig: [" & VirusDefinition & "]")
                End If
            Next

            label2.Text = Convert.ToString(listBox1.Items.Count)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Dim FilePath As String = OpenFileDialog1.FileName
            Dim md5 As String = EngineHash.Get_MD5_Of_File(FilePath)
            Dim shad1 As String = EngineHash.Get_SHA1_Of_File(FilePath)
            Dim shad256 As String = EngineHash.Get_Shad256_Of_File(FilePath)
            TextBox2.Text = "MD5: " & md5 & vbNewLine & "Shad1: " & shad1 & vbNewLine & "Shad256: " & shad256
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            ListBox2.Items.Clear()
            Dim GetFileInvokes As List(Of String) = Engine.ScanFileWinAPI(OpenFileDialog1.FileName)
            For Each PinvokeStr As String In GetFileInvokes
                ListBox2.Items.Add(PinvokeStr)
            Next
        End If
       
    End Sub


End Class
