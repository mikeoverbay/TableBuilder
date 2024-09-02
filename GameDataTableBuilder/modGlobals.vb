
Module modGlobals
    Public thelist(1) As list_
    Public Structure list_
        Public entry_length As Integer
        Public file_name() As String
        Public pkg_name As String
        Public maxLod As String
    End Structure

    Public game_path As String
    Public list_size As Integer
    Public pkg_cnt As Integer
    Public total_found As Integer
    Public duplcate_count As Integer
    Public temp_path As String
    Public used_pkg_cnt As Integer
    Public DATA_TABLE As New DataTable("items")
End Module
