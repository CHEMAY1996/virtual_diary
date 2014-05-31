<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSplash))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btntimetable = New System.Windows.Forms.Button()
        Me.btnprojects = New System.Windows.Forms.Button()
        Me.btnalarms = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnhomework = New System.Windows.Forms.Button()
        Me.btncal = New System.Windows.Forms.Button()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Verdana", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(213, 157)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(716, 67)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to virtual diary "
        '
        'btntimetable
        '
        Me.btntimetable.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntimetable.Location = New System.Drawing.Point(158, 356)
        Me.btntimetable.Name = "btntimetable"
        Me.btntimetable.Size = New System.Drawing.Size(269, 93)
        Me.btntimetable.TabIndex = 1
        Me.btntimetable.Text = "Your timetalbe "
        Me.btntimetable.UseVisualStyleBackColor = True
        '
        'btnprojects
        '
        Me.btnprojects.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprojects.Location = New System.Drawing.Point(158, 455)
        Me.btnprojects.Name = "btnprojects"
        Me.btnprojects.Size = New System.Drawing.Size(269, 93)
        Me.btnprojects.TabIndex = 2
        Me.btnprojects.Text = "Projects"
        Me.btnprojects.UseVisualStyleBackColor = True
        '
        'btnalarms
        '
        Me.btnalarms.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalarms.Location = New System.Drawing.Point(433, 356)
        Me.btnalarms.Name = "btnalarms"
        Me.btnalarms.Size = New System.Drawing.Size(269, 93)
        Me.btnalarms.TabIndex = 3
        Me.btnalarms.Text = "Alarms " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnalarms.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(433, 455)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(269, 93)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnhomework
        '
        Me.btnhomework.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhomework.Location = New System.Drawing.Point(708, 356)
        Me.btnhomework.Name = "btnhomework"
        Me.btnhomework.Size = New System.Drawing.Size(269, 93)
        Me.btnhomework.TabIndex = 5
        Me.btnhomework.Text = "Homework"
        Me.btnhomework.UseVisualStyleBackColor = True
        '
        'btncal
        '
        Me.btncal.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncal.Location = New System.Drawing.Point(708, 455)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(269, 93)
        Me.btncal.TabIndex = 6
        Me.btncal.Text = "Your Calender "
        Me.btncal.UseVisualStyleBackColor = True
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.Font = New System.Drawing.Font("Impact", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.Location = New System.Drawing.Point(430, 284)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(0, 39)
        Me.lblheading.TabIndex = 7
        '
        'FormSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1050, 606)
        Me.Controls.Add(Me.lblheading)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.btnhomework)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnalarms)
        Me.Controls.Add(Me.btnprojects)
        Me.Controls.Add(Me.btntimetable)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "FormSplash"
        Me.Text = "Virtual diary "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btntimetable As System.Windows.Forms.Button
    Friend WithEvents btnprojects As System.Windows.Forms.Button
    Friend WithEvents btnalarms As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnhomework As System.Windows.Forms.Button
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents lblheading As System.Windows.Forms.Label

End Class
