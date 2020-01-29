# TableBuilder
Used to create a xml used for pkg file look up.
It finds and add these files:</br>
dds</br>
primitive</br>
visual</br>
model</br>
atlas</br>
</br>
It also stores in that <items> entry, the package files name.
You can load the XML in to a datatable (VB or C#)and use LINQ to fine the package file a is located in.</br>
</br>
You can easily load the XML in to a datatable.
```
        DATA_TABLE.Clear()
        DATA_TABLE.Columns.Add("filename", GetType(String))
        DATA_TABLE.Columns.Add("package", GetType(String))
        DATA_TABLE.ReadXml(temp_path + "TheItemList.xml")
```
Searching is easy...</br>
```
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
```

This app will be intergrated in to nuTerra to speed up finding files.