<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(172, 43)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "No Scanned."
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(127, 43)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(39, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Virus : "
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Location = New System.Drawing.Point(130, 14)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(545, 20)
        Me.textBox1.TabIndex = 12
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 14)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(107, 45)
        Me.button1.TabIndex = 11
        Me.button1.Text = "Chose And Scan"
        Me.button1.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(12, 65)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(663, 160)
        Me.listBox1.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 45)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "GetFileHash"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(142, 242)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(533, 108)
        Me.TextBox2.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 38)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Get File WinAPI Used"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(142, 372)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(202, 134)
        Me.ListBox2.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 518)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.listBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Private WithEvents folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents ListBox2 As System.Windows.Forms.ListBox

End Class
