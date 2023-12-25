<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopUpSimbol
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
        Me.pbcircle = New System.Windows.Forms.PictureBox
        Me.pbcross = New System.Windows.Forms.PictureBox
        Me.pbtnSelect = New System.Windows.Forms.PictureBox
        Me.pbhuman = New System.Windows.Forms.PictureBox
        Me.pbcom = New System.Windows.Forms.PictureBox
        CType(Me.pbcircle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcross, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbhuman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbcircle
        '
        Me.pbcircle.BackColor = System.Drawing.Color.Transparent
        Me.pbcircle.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.circle
        Me.pbcircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcircle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcircle.Location = New System.Drawing.Point(57, 70)
        Me.pbcircle.Name = "pbcircle"
        Me.pbcircle.Size = New System.Drawing.Size(108, 103)
        Me.pbcircle.TabIndex = 0
        Me.pbcircle.TabStop = False
        '
        'pbcross
        '
        Me.pbcross.BackColor = System.Drawing.Color.Transparent
        Me.pbcross.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.cross
        Me.pbcross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcross.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcross.Location = New System.Drawing.Point(57, 191)
        Me.pbcross.Name = "pbcross"
        Me.pbcross.Size = New System.Drawing.Size(108, 107)
        Me.pbcross.TabIndex = 0
        Me.pbcross.TabStop = False
        '
        'pbtnSelect
        '
        Me.pbtnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbtnSelect.Image = Global.tictactoebacktrack.My.Resources.Resources.btnselect
        Me.pbtnSelect.Location = New System.Drawing.Point(152, 315)
        Me.pbtnSelect.Name = "pbtnSelect"
        Me.pbtnSelect.Size = New System.Drawing.Size(166, 58)
        Me.pbtnSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbtnSelect.TabIndex = 1
        Me.pbtnSelect.TabStop = False
        '
        'pbhuman
        '
        Me.pbhuman.BackColor = System.Drawing.Color.Transparent
        Me.pbhuman.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.user
        Me.pbhuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbhuman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbhuman.Location = New System.Drawing.Point(275, 70)
        Me.pbhuman.Name = "pbhuman"
        Me.pbhuman.Size = New System.Drawing.Size(108, 103)
        Me.pbhuman.TabIndex = 0
        Me.pbhuman.TabStop = False
        '
        'pbcom
        '
        Me.pbcom.BackColor = System.Drawing.Color.Transparent
        Me.pbcom.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.screen_windows1
        Me.pbcom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcom.Location = New System.Drawing.Point(275, 191)
        Me.pbcom.Name = "pbcom"
        Me.pbcom.Size = New System.Drawing.Size(108, 107)
        Me.pbcom.TabIndex = 0
        Me.pbcom.TabStop = False
        '
        'frmPopUpSimbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.bgpop2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(469, 385)
        Me.Controls.Add(Me.pbtnSelect)
        Me.Controls.Add(Me.pbcom)
        Me.Controls.Add(Me.pbcross)
        Me.Controls.Add(Me.pbhuman)
        Me.Controls.Add(Me.pbcircle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPopUpSimbol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPopUpSimbol"
        CType(Me.pbcircle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcross, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbhuman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbcircle As System.Windows.Forms.PictureBox
    Friend WithEvents pbcross As System.Windows.Forms.PictureBox
    Friend WithEvents pbtnSelect As System.Windows.Forms.PictureBox
    Friend WithEvents pbhuman As System.Windows.Forms.PictureBox
    Friend WithEvents pbcom As System.Windows.Forms.PictureBox
End Class
