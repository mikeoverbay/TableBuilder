
Imports System.IO
Imports System.Text
Imports Ionic.Zip
Imports System.Globalization
Imports System.Threading

Public Class frmMain

    Private Sub set_path_btn_Click(sender As Object, e As EventArgs) Handles set_path_btn.Click
        game_path = "C:\Games\World_of_Tanks_NA\res\packages\"
        Return
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            game_path = FolderBrowserDialog1.SelectedPath
            My.Settings.game_path = game_path
            go_btn.Enabled = True
        End If

    End Sub

    Private Sub go_btn_Click(sender As Object, e As EventArgs) Handles go_btn.Click
#If 0 Then
        GoTo skip_searching
#End If
        Dim st As New Stopwatch
        st.Restart()
        total_found = 0
        duplcate_count = 0
        used_pkg_cnt = 0

        go_btn.Enabled = False '<-- dont let a reenter occur
        search_btn.Enabled = False

        Dim iPath = My.Settings.game_path
        Dim f_info = Directory.GetFiles(iPath)

        Dim PKGS(250) As String
        Dim p_cnt As Integer = 0
        Dim f_cnt As Integer = 0
        Dim cnt As Integer = 0
        list_size = 0
        ReDim thelist(2500)
        For i = 0 To 2499
            thelist(i) = New list_
            ReDim thelist(i).file_name(200000)
        Next
        'get all the packages
        For Each m In f_info
            If m.Contains(".pkg") Then
                PKGS(cnt) = m
                cnt += 1
            End If
        Next
        ReDim Preserve PKGS(cnt - 1)
        pkg_cnt = cnt - 1
        For i = 0 To cnt - 1
            Dim in_f As Boolean = False
            Using z As New Ionic.Zip.ZipFile(PKGS(i))
                For Each item In z
                    Select Case True
                        Case item.FileName.Contains("vehicles")
                            If item.FileName.Contains(".dds") Or item.FileName.Contains(".png") Or
                                 item.FileName.Contains("processed") Then
                                seach_add(item, PKGS(i))
                            End If


                    End Select

                Next
            End Using
        Next
        For cp = 0 To pkg_cnt - 1
            ReDim Preserve thelist(cp).file_name(thelist(cp).entry_length - 1)
        Next
        Dim seconds = st.ElapsedMilliseconds / 1000
        unique.Text = "I found " + total_found.ToString + " and " + duplcate_count.ToString + " duplicate files in " + seconds.ToString + " seconds."

        'We have the list so lets create the XML file
        Dim fb As New StringBuilder
        fb.AppendLine("<?xml version=""1.0"" standalone=""yes""?>")
        fb.AppendLine("<FileList>")
        For i = 0 To used_pkg_cnt
            For j = 0 To thelist(i).entry_length - 1
                fb.AppendLine("<items>")
                fb.AppendLine("<filename>" + thelist(i).file_name(j) + "</filename>")
                fb.AppendLine("<package>" + thelist(i).pkg_name + "</package>")
                fb.AppendLine("</items>")
            Next
        Next
        fb.AppendLine("</FileList>")
        File.WriteAllText(temp_path + "TheItemList.xml", fb.ToString)
        'Process.Start(temp_path + "TheItemList.xml")
        go_btn.Enabled = True
skip_searching:
        DATA_TABLE.Clear()
        DATA_TABLE.Columns.Add("filename", GetType(String))
        DATA_TABLE.Columns.Add("package", GetType(String))
        DATA_TABLE.ReadXml(temp_path + "TheItemList.xml")
        search_btn.Enabled = True
    End Sub
    Private Sub seach_add(ByRef item As ZipEntry, ByRef pkg_name As String)
        'Check if this item has already been added to our list. Return if found.
        'Check if the pkg_name is even in our list.. If not, add it!
        'removing local path of the pkg_names .. The XML file is too big!!
        pkg_name = Path.GetFileName(pkg_name)
        Dim fname = item.FileName.Replace("\", "/")
        Dim cp As Integer = 0
        For i = 0 To pkg_cnt - 1
            If thelist(i).pkg_name = pkg_name Then
                For j = 0 To thelist(i).entry_length
                    If fname = thelist(i).file_name(j) Then
                        duplcate_count += 1
                        Return
                    End If
                Next
                cp = i
                GoTo found_pkg_name
            End If
        Next
        'The pgk_name is not on the list so add it.
        For i = 0 To pkg_cnt - 1
            If thelist(i).pkg_name Is Nothing Then
                thelist(i).pkg_name = pkg_name
                'its a newly added list so it has no file_names. Go ahead and add this one.
                thelist(i).file_name(0) = fname
                thelist(i).entry_length += 1
                Return
            End If
        Next

found_pkg_name:

        'Find the pkg list and add this item.
        thelist(cp).file_name(thelist(cp).entry_length) = fname
        thelist(cp).entry_length += 1
        pkg_tb.Text = pkg_name
        file_tb.Text = fname
        total_found += 1
        If cp > used_pkg_cnt Then used_pkg_cnt = cp
        Application.DoEvents() 'so we don't lock up this app
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim nonInvariantCulture As CultureInfo = New CultureInfo("en-US")
        nonInvariantCulture.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture = nonInvariantCulture
        temp_path = Path.GetTempPath
        temp_path = "C:\!_Tank Exporter\!_Tank Exporter\bin\x86\Debug\resources\XMLdata\"
        If Not Directory.Exists(temp_path) Then
            Directory.CreateDirectory(temp_path)
        End If
        If Directory.Exists(My.Settings.game_path) Then
            game_path = My.Settings.game_path
            go_btn.Enabled = True
        End If
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        frmFind.Show()

    End Sub
End Class
