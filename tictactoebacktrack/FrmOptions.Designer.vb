<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOptions
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmblagubackground = New System.Windows.Forms.ComboBox
        Me.chkAdaSuara = New System.Windows.Forms.CheckBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.btnTutup = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lagu Background"
        '
        'cmblagubackground
        '
        Me.cmblagubackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblagubackground.FormattingEnabled = True
        Me.cmblagubackground.Items.AddRange(New Object() {"Music 1", "Music 2"})
        Me.cmblagubackground.Location = New System.Drawing.Point(230, 119)
        Me.cmblagubackground.Name = "cmblagubackground"
        Me.cmblagubackground.Size = New System.Drawing.Size(393, 21)
        Me.cmblagubackground.TabIndex = 1
        '
        'chkAdaSuara
        '
        Me.chkAdaSuara.AutoSize = True
        Me.chkAdaSuara.Location = New System.Drawing.Point(231, 171)
        Me.chkAdaSuara.Name = "chkAdaSuara"
        Me.chkAdaSuara.Size = New System.Drawing.Size(68, 17)
        Me.chkAdaSuara.TabIndex = 2
        Me.chkAdaSuara.Text = "Bersuara"
        Me.chkAdaSuara.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(26, 46)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(119, 41)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(26, 147)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(119, 41)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(26, 97)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(119, 41)
        Me.btnTutup.TabIndex = 3
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'FrmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.options
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 422)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkAdaSuara)
        Me.Controls.Add(Me.cmblagubackground)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tentukan Pilihan Permainan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmblagubackground As System.Windows.Forms.ComboBox
    Friend WithEvents chkAdaSuara As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
