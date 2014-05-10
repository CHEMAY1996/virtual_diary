<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enter_new_event
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enter_new_event))
        Me.txtnotes = New System.Windows.Forms.TextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lbleventname = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.dtpevent = New System.Windows.Forms.DateTimePicker()
        Me.lblalarm = New System.Windows.Forms.Label()
        Me.cmbeventalarm = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtnotes
        '
        Me.txtnotes.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnotes.Location = New System.Drawing.Point(270, 104)
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(434, 35)
        Me.txtnotes.TabIndex = 0
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(202, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(388, 45)
        Me.lbltitle.TabIndex = 1
        Me.lbltitle.Text = "Enter a new event below "
        '
        'lbleventname
        '
        Me.lbleventname.AutoSize = True
        Me.lbleventname.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleventname.Location = New System.Drawing.Point(86, 104)
        Me.lbleventname.Name = "lbleventname"
        Me.lbleventname.Size = New System.Drawing.Size(166, 27)
        Me.lbleventname.TabIndex = 2
        Me.lbleventname.Text = "Event name "
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(219, 377)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 48)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(412, 377)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(203, 48)
        Me.btnconfirm.TabIndex = 4
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(86, 163)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(152, 27)
        Me.lbldate.TabIndex = 5
        Me.lbldate.Text = "Event Date"
        '
        'dtpevent
        '
        Me.dtpevent.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpevent.Location = New System.Drawing.Point(270, 155)
        Me.dtpevent.Name = "dtpevent"
        Me.dtpevent.Size = New System.Drawing.Size(434, 35)
        Me.dtpevent.TabIndex = 6
        '
        'lblalarm
        '
        Me.lblalarm.AutoSize = True
        Me.lblalarm.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalarm.Location = New System.Drawing.Point(86, 233)
        Me.lblalarm.Name = "lblalarm"
        Me.lblalarm.Size = New System.Drawing.Size(82, 27)
        Me.lblalarm.TabIndex = 7
        Me.lblalarm.Text = "Alarm"
        '
        'cmbeventalarm
        '
        Me.cmbeventalarm.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbeventalarm.FormattingEnabled = True
        Me.cmbeventalarm.Location = New System.Drawing.Point(281, 225)
        Me.cmbeventalarm.Name = "cmbeventalarm"
        Me.cmbeventalarm.Size = New System.Drawing.Size(423, 35)
        Me.cmbeventalarm.TabIndex = 8
        '
        'Enter_new_event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(829, 476)
        Me.Controls.Add(Me.cmbeventalarm)
        Me.Controls.Add(Me.lblalarm)
        Me.Controls.Add(Me.dtpevent)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lbleventname)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtnotes)
        Me.Name = "Enter_new_event"
        Me.Text = "Enter new event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnotes As System.Windows.Forms.TextBox
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lbleventname As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnconfirm As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents dtpevent As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblalarm As System.Windows.Forms.Label
    Friend WithEvents cmbeventalarm As System.Windows.Forms.ComboBox
End Class
