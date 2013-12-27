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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuabout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuexit = New System.Windows.Forms.ToolStripMenuItem
        Me.NN = New System.Windows.Forms.TextBox
        Me.RR = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.convert = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuabout, Me.mnuexit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuabout
        '
        Me.mnuabout.Name = "mnuabout"
        Me.mnuabout.Size = New System.Drawing.Size(49, 20)
        Me.mnuabout.Text = "درباره"
        '
        'mnuexit
        '
        Me.mnuexit.Name = "mnuexit"
        Me.mnuexit.Size = New System.Drawing.Size(44, 20)
        Me.mnuexit.Text = "خروج"
        '
        'NN
        '
        Me.NN.Location = New System.Drawing.Point(12, 47)
        Me.NN.Name = "NN"
        Me.NN.Size = New System.Drawing.Size(260, 20)
        Me.NN.TabIndex = 1
        '
        'RR
        '
        Me.RR.Location = New System.Drawing.Point(12, 98)
        Me.RR.Name = "RR"
        Me.RR.Size = New System.Drawing.Size(260, 20)
        Me.RR.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "عدد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "رومی"
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(197, 124)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(75, 23)
        Me.convert.TabIndex = 5
        Me.convert.Text = "تبدیل"
        Me.convert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 159)
        Me.Controls.Add(Me.convert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RR)
        Me.Controls.Add(Me.NN)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "مبدل اعداد رومی"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuabout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NN As System.Windows.Forms.TextBox
    Friend WithEvents RR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents convert As System.Windows.Forms.Button

End Class
