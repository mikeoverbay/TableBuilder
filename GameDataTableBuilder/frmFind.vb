Imports System.Text
Public Class frmFind

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search()
    End Sub

    Private Sub search_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles search_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            search()
        End If
    End Sub

    Private Sub search()
        If search_tb.Text.Length = 0 Then
            Return
        End If
        Dim q = From d In DATA_TABLE.AsEnumerable _
                Where d.Field(Of String)("filename").ToLower.Contains(search_tb.Text.ToLower) _
                Select _
                pkg = d.Field(Of String)("package"), _
                file = d.Field(Of String)("filename")

        pkgs_tb.Text = ""
        If q.Count = 0 Then
            pkgs_tb.Text = "Nothing found!"
            Return
        End If
        Dim pkgs As New StringBuilder
        Dim files As New StringBuilder
        For Each item In q
            pkgs.AppendLine(item.pkg)
            files.AppendLine(item.file)
        Next
        pkgs_tb.Text = pkgs.ToString
        files_tb.Text = files.ToString

    End Sub
End Class