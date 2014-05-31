<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeworkhome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeworkhome))
        Me.lblheading = New System.Windows.Forms.Label()
        Me.lsthomework = New System.Windows.Forms.ListBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.Font = New System.Drawing.Font("Impact", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.Location = New System.Drawing.Point(80, 9)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(239, 39)
        Me.lblheading.TabIndex = 3
        Me.lblheading.Text = "Your homework "
        '
        'lsthomework
        '
        Me.lsthomework.FormattingEnabled = True
        Me.lsthomework.Location = New System.Drawing.Point(87, 90)
        Me.lsthomework.Name = "lsthomework"
        Me.lsthomework.Size = New System.Drawing.Size(950, 368)
        Me.lsthomework.TabIndex = 4
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(133, 481)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(137, 49)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(772, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enter new item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'homeworkhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1138, 542)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lsthomework)
        Me.Controls.Add(Me.lblheading)
        Me.Name = "homeworkhome"
        Me.Text = "homeworkhome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblheading As System.Windows.Forms.Label
    Friend WithEvents lsthomework As System.Windows.Forms.ListBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
