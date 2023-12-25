<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Me.pbBtnPlay = New System.Windows.Forms.PictureBox
        Me.pbtnOptions = New System.Windows.Forms.PictureBox
        CType(Me.pbBtnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbtnOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbBtnPlay
        '
        Me.pbBtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBtnPlay.Image = Global.tictactoebacktrack.My.Resources.Resources.btnplay
        Me.pbBtnPlay.Location = New System.Drawing.Point(594, 190)
        Me.pbBtnPlay.Name = "pbBtnPlay"
        Me.pbBtnPlay.Size = New System.Drawing.Size(166, 58)
        Me.pbBtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBtnPlay.TabIndex = 0
        Me.pbBtnPlay.TabStop = False
        '
        'pbtnOptions
        '
        Me.pbtnOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbtnOptions.Image = Global.tictactoebacktrack.My.Resources.Resources.btnoptions
        Me.pbtnOptions.Location = New System.Drawing.Point(498, 279)
        Me.pbtnOptions.Name = "pbtnOptions"
        Me.pbtnOptions.Size = New System.Drawing.Size(166, 58)
        Me.pbtnOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbtnOptions.TabIndex = 0
        Me.pbtnOptions.TabStop = False
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.bgmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 490)
        Me.Controls.Add(Me.pbtnOptions)
        Me.Controls.Add(Me.pbBtnPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbBtnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbtnOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbBtnPlay As System.Windows.Forms.PictureBox
    Friend WithEvents pbtnOptions As System.Windows.Forms.PictureBox

End Class
