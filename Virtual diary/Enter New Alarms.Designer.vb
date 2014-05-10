<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enter_New_Alarms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enter_New_Alarms))
        Me.lblhead = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.dtpAlarmtime = New System.Windows.Forms.DateTimePicker()
        Me.lbldatetime = New System.Windows.Forms.Label()
        Me.cmbalarmsound = New System.Windows.Forms.ComboBox()
        Me.lblsound = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtalarm = New System.Windows.Forms.TextBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.nuphours = New System.Windows.Forms.NumericUpDown()
        Me.lblcolon = New System.Windows.Forms.Label()
        Me.nupminutes = New System.Windows.Forms.NumericUpDown()
        Me.lbl24 = New System.Windows.Forms.Label()
        CType(Me.nuphours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupminutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblhead
        '
        Me.lblhead.AutoSize = True
        Me.lblhead.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhead.Location = New System.Drawing.Point(76, 9)
        Me.lblhead.Name = "lblhead"
        Me.lblhead.Size = New System.Drawing.Size(364, 43)
        Me.lblhead.TabIndex = 0
        Me.lblhead.Text = "Enter a new alarm below"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(84, 399)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 55)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(275, 399)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(124, 55)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'dtpAlarmtime
        '
        Me.dtpAlarmtime.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAlarmtime.Location = New System.Drawing.Point(382, 134)
        Me.dtpAlarmtime.Name = "dtpAlarmtime"
        Me.dtpAlarmtime.Size = New System.Drawing.Size(458, 35)
        Me.dtpAlarmtime.TabIndex = 3
        '
        'lbldatetime
        '
        Me.lbldatetime.AutoSize = True
        Me.lbldatetime.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatetime.Location = New System.Drawing.Point(79, 140)
        Me.lbldatetime.Name = "lbldatetime"
        Me.lbldatetime.Size = New System.Drawing.Size(292, 27)
        Me.lbldatetime.TabIndex = 4
        Me.lbldatetime.Text = "Date for your alarm "
        '
        'cmbalarmsound
        '
        Me.cmbalarmsound.FormattingEnabled = True
        Me.cmbalarmsound.Location = New System.Drawing.Point(396, 207)
        Me.cmbalarmsound.Name = "cmbalarmsound"
        Me.cmbalarmsound.Size = New System.Drawing.Size(444, 21)
        Me.cmbalarmsound.TabIndex = 5
        '
        'lblsound
        '
        Me.lblsound.AutoSize = True
        Me.lblsound.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsound.Location = New System.Drawing.Point(79, 207)
        Me.lblsound.Name = "lblsound"
        Me.lblsound.Size = New System.Drawing.Size(166, 27)
        Me.lblsound.TabIndex = 6
        Me.lblsound.Text = "Alarm sound"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Alarm name "
        '
        'txtalarm
        '
        Me.txtalarm.Location = New System.Drawing.Point(396, 276)
        Me.txtalarm.Name = "txtalarm"
        Me.txtalarm.Size = New System.Drawing.Size(444, 20)
        Me.txtalarm.TabIndex = 8
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(84, 345)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(82, 27)
        Me.lbltime.TabIndex = 9
        Me.lbltime.Text = "Time "
        '
        'nuphours
        '
        Me.nuphours.Location = New System.Drawing.Point(396, 345)
        Me.nuphours.Name = "nuphours"
        Me.nuphours.Size = New System.Drawing.Size(120, 20)
        Me.nuphours.TabIndex = 10
        '
        'lblcolon
        '
        Me.lblcolon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcolon.Location = New System.Drawing.Point(522, 335)
        Me.lblcolon.Name = "lblcolon"
        Me.lblcolon.Size = New System.Drawing.Size(100, 30)
        Me.lblcolon.TabIndex = 11
        Me.lblcolon.Text = ":"
        '
        'nupminutes
        '
        Me.nupminutes.Location = New System.Drawing.Point(628, 345)
        Me.nupminutes.Name = "nupminutes"
        Me.nupminutes.Size = New System.Drawing.Size(120, 20)
        Me.nupminutes.TabIndex = 12
        '
        'lbl24
        '
        Me.lbl24.AutoSize = True
        Me.lbl24.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl24.Location = New System.Drawing.Point(391, 93)
        Me.lbl24.Name = "lbl24"
        Me.lbl24.Size = New System.Drawing.Size(334, 27)
        Me.lbl24.TabIndex = 13
        Me.lbl24.Text = "Time in 24 hour format "
        '
        'Enter_New_Alarms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(913, 502)
        Me.Controls.Add(Me.lbl24)
        Me.Controls.Add(Me.nupminutes)
        Me.Controls.Add(Me.lblcolon)
        Me.Controls.Add(Me.nuphours)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.txtalarm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblsound)
        Me.Controls.Add(Me.cmbalarmsound)
        Me.Controls.Add(Me.lbldatetime)
        Me.Controls.Add(Me.dtpAlarmtime)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblhead)
        Me.Name = "Enter_New_Alarms"
        Me.Text = "Enter_New_Alarms"
        CType(Me.nuphours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupminutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblhead As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents dtpAlarmtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldatetime As System.Windows.Forms.Label
    Friend WithEvents cmbalarmsound As System.Windows.Forms.ComboBox
    Friend WithEvents lblsound As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtalarm As System.Windows.Forms.TextBox
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents nuphours As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblcolon As System.Windows.Forms.Label
    Friend WithEvents nupminutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl24 As System.Windows.Forms.Label
End Class
