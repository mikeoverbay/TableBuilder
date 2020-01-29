<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.pkgs_tb = New System.Windows.Forms.TextBox()
        Me.files_tb = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(604, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'search_tb
        '
        Me.search_tb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_tb.Location = New System.Drawing.Point(12, 12)
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(586, 20)
        Me.search_tb.TabIndex = 1
        '
        'pkgs_tb
        '
        Me.pkgs_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pkgs_tb.Location = New System.Drawing.Point(0, 0)
        Me.pkgs_tb.Multiline = True
        Me.pkgs_tb.Name = "pkgs_tb"
        Me.pkgs_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pkgs_tb.Size = New System.Drawing.Size(667, 220)
        Me.pkgs_tb.TabIndex = 2
        '
        'files_tb
        '
        Me.files_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.files_tb.Location = New System.Drawing.Point(0, 0)
        Me.files_tb.Multiline = True
        Me.files_tb.Name = "files_tb"
        Me.files_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.files_tb.Size = New System.Drawing.Size(667, 217)
        Me.files_tb.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pkgs_tb)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.files_tb)
        Me.SplitContainer1.Size = New System.Drawing.Size(667, 441)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 4
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 493)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.search_tb)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmFind"
        Me.Text = "Seach Data"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents search_tb As System.Windows.Forms.TextBox
    Friend WithEvents pkgs_tb As System.Windows.Forms.TextBox
    Friend WithEvents files_tb As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
