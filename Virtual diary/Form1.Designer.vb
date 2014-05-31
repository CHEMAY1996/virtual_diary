<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enter_new_subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enter_new_subject))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comsubject = New System.Windows.Forms.ComboBox()
        Me.combday = New System.Windows.Forms.ComboBox()
        Me.combperiod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(82, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 29)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Period"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Enter new subject below"
        '
        'comsubject
        '
        Me.comsubject.FormattingEnabled = True
        Me.comsubject.Items.AddRange(New Object() {"Biology", "Businsess Studies", "Chemistry", "Chinese Continuers", "Design and Technology", "Drama", "Economics", "English Advanced", "English Standard", "English Extension 1", "English Extension 2", "English ESL", "French Beginers", "Geography", "History (Ancient)", "History (Modern)", "Indonesian Continuers", "Industrial Technology", "Legal Studies", "Mathematics", "Mathermatics Extention 1", "Mathematics Extention 2", "Mathematics General ", "Music 1", "Music 2", "Music Extention", "Personal Development Health Physical Education (PDHPE)", "Physics", "Software Design and Development ", "Textiles and Design", "Visual Arts", "Visual Design"})
        Me.comsubject.Location = New System.Drawing.Point(193, 145)
        Me.comsubject.Name = "comsubject"
        Me.comsubject.Size = New System.Drawing.Size(368, 21)
        Me.comsubject.TabIndex = 15
        '
        'combday
        '
        Me.combday.FormattingEnabled = True
        Me.combday.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.combday.Location = New System.Drawing.Point(193, 207)
        Me.combday.Name = "combday"
        Me.combday.Size = New System.Drawing.Size(368, 21)
        Me.combday.TabIndex = 16
        '
        'combperiod
        '
        Me.combperiod.FormattingEnabled = True
        Me.combperiod.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.combperiod.Location = New System.Drawing.Point(193, 272)
        Me.combperiod.Name = "combperiod"
        Me.combperiod.Size = New System.Drawing.Size(368, 21)
        Me.combperiod.TabIndex = 17
        '
        'Enter_new_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(995, 430)
        Me.Controls.Add(Me.combperiod)
        Me.Controls.Add(Me.combday)
        Me.Controls.Add(Me.comsubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Enter_new_subject"
        Me.Text = "Enter_new_subjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comsubject As System.Windows.Forms.ComboBox
    Friend WithEvents combday As System.Windows.Forms.ComboBox
    Friend WithEvents combperiod As System.Windows.Forms.ComboBox
End Class
