<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calender))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEnter_new_event = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.MonthCalendar1.Location = New System.Drawing.Point(139, 137)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'lblheading
        '
        Me.lblheading.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.Location = New System.Drawing.Point(472, 65)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(324, 51)
        Me.lblheading.TabIndex = 1
        Me.lblheading.Text = "Your Calender "
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(479, 609)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(194, 42)
        Me.btnback.TabIndex = 2
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEnter_new_event
        '
        Me.btnEnter_new_event.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter_new_event.Location = New System.Drawing.Point(697, 609)
        Me.btnEnter_new_event.Name = "btnEnter_new_event"
        Me.btnEnter_new_event.Size = New System.Drawing.Size(254, 42)
        Me.btnEnter_new_event.TabIndex = 4
        Me.btnEnter_new_event.Text = "Enter new event"
        Me.btnEnter_new_event.UseVisualStyleBackColor = True
        '
        'Calender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1129, 657)
        Me.Controls.Add(Me.btnEnter_new_event)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lblheading)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Calender"
        Me.Text = "Your Calender"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblheading As System.Windows.Forms.Label
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEnter_new_event As System.Windows.Forms.Button
End Class
