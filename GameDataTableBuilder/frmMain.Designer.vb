<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.set_path_btn = New System.Windows.Forms.Button()
        Me.go_btn = New System.Windows.Forms.Button()
        Me.pkg_tb = New System.Windows.Forms.TextBox()
        Me.file_tb = New System.Windows.Forms.TextBox()
        Me.unique = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'set_path_btn
        '
        Me.set_path_btn.Location = New System.Drawing.Point(13, 13)
        Me.set_path_btn.Name = "set_path_btn"
        Me.set_path_btn.Size = New System.Drawing.Size(75, 23)
        Me.set_path_btn.TabIndex = 0
        Me.set_path_btn.Text = "Set Path"
        Me.set_path_btn.UseVisualStyleBackColor = True
        '
        'go_btn
        '
        Me.go_btn.Enabled = False
        Me.go_btn.Location = New System.Drawing.Point(118, 13)
        Me.go_btn.Name = "go_btn"
        Me.go_btn.Size = New System.Drawing.Size(75, 23)
        Me.go_btn.TabIndex = 1
        Me.go_btn.Text = "Go"
        Me.go_btn.UseVisualStyleBackColor = True
        '
        'pkg_tb
        '
        Me.pkg_tb.Location = New System.Drawing.Point(13, 63)
        Me.pkg_tb.Name = "pkg_tb"
        Me.pkg_tb.Size = New System.Drawing.Size(464, 20)
        Me.pkg_tb.TabIndex = 2
        '
        'file_tb
        '
        Me.file_tb.Location = New System.Drawing.Point(12, 106)
        Me.file_tb.Name = "file_tb"
        Me.file_tb.Size = New System.Drawing.Size(465, 20)
        Me.file_tb.TabIndex = 3
        '
        'unique
        '
        Me.unique.AutoSize = True
        Me.unique.Location = New System.Drawing.Point(13, 148)
        Me.unique.Name = "unique"
        Me.unique.Size = New System.Drawing.Size(61, 13)
        Me.unique.TabIndex = 4
        Me.unique.Text = "_________"
        '
        'search_btn
        '
        Me.search_btn.Enabled = False
        Me.search_btn.Location = New System.Drawing.Point(401, 13)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(75, 23)
        Me.search_btn.TabIndex = 5
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "This writes the data to temp\mikeo\TheItemList.xml - Set the path to res\packages" &
    " and click 'Go'"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 173)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.unique)
        Me.Controls.Add(Me.file_tb)
        Me.Controls.Add(Me.pkg_tb)
        Me.Controls.Add(Me.go_btn)
        Me.Controls.Add(Me.set_path_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Table Builder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents set_path_btn As System.Windows.Forms.Button
    Friend WithEvents go_btn As System.Windows.Forms.Button
    Friend WithEvents pkg_tb As System.Windows.Forms.TextBox
    Friend WithEvents file_tb As System.Windows.Forms.TextBox
    Friend WithEvents unique As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
