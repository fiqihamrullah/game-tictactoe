<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlay
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblLevel = New System.Windows.Forms.Label
        Me.lblgwins = New System.Windows.Forms.Label
        Me.lblgloses = New System.Windows.Forms.Label
        Me.lblturn = New System.Windows.Forms.Label
        Me.pbtnExit = New System.Windows.Forms.PictureBox
        Me.pbPlayer = New System.Windows.Forms.PictureBox
        Me.pbCom = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pbKotakTTT = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbKotakTTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.user1_48
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(69, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 54)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.computer
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(351, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 54)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLevel.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblLevel.Location = New System.Drawing.Point(589, 118)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(169, 45)
        Me.lblLevel.TabIndex = 3
        Me.lblLevel.Text = "Easy"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblgwins
        '
        Me.lblgwins.AutoSize = True
        Me.lblgwins.BackColor = System.Drawing.Color.Transparent
        Me.lblgwins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblgwins.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgwins.ForeColor = System.Drawing.Color.Olive
        Me.lblgwins.Location = New System.Drawing.Point(655, 205)
        Me.lblgwins.Name = "lblgwins"
        Me.lblgwins.Size = New System.Drawing.Size(40, 45)
        Me.lblgwins.TabIndex = 3
        Me.lblgwins.Text = "0"
        Me.lblgwins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblgloses
        '
        Me.lblgloses.AutoSize = True
        Me.lblgloses.BackColor = System.Drawing.Color.Transparent
        Me.lblgloses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblgloses.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgloses.ForeColor = System.Drawing.Color.Olive
        Me.lblgloses.Location = New System.Drawing.Point(655, 291)
        Me.lblgloses.Name = "lblgloses"
        Me.lblgloses.Size = New System.Drawing.Size(40, 45)
        Me.lblgloses.TabIndex = 3
        Me.lblgloses.Text = "0"
        Me.lblgloses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblturn
        '
        Me.lblturn.BackColor = System.Drawing.Color.Transparent
        Me.lblturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblturn.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturn.ForeColor = System.Drawing.Color.Green
        Me.lblturn.Location = New System.Drawing.Point(589, 374)
        Me.lblturn.Name = "lblturn"
        Me.lblturn.Size = New System.Drawing.Size(179, 45)
        Me.lblturn.TabIndex = 3
        Me.lblturn.Text = "Player"
        Me.lblturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbtnExit
        '
        Me.pbtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbtnExit.Image = Global.tictactoebacktrack.My.Resources.Resources.btnexit
        Me.pbtnExit.Location = New System.Drawing.Point(598, 446)
        Me.pbtnExit.Name = "pbtnExit"
        Me.pbtnExit.Size = New System.Drawing.Size(159, 46)
        Me.pbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbtnExit.TabIndex = 4
        Me.pbtnExit.TabStop = False
        '
        'pbPlayer
        '
        Me.pbPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pbPlayer.Location = New System.Drawing.Point(127, 13)
        Me.pbPlayer.Name = "pbPlayer"
        Me.pbPlayer.Size = New System.Drawing.Size(65, 52)
        Me.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPlayer.TabIndex = 5
        Me.pbPlayer.TabStop = False
        '
        'pbCom
        '
        Me.pbCom.BackColor = System.Drawing.Color.Transparent
        Me.pbCom.Location = New System.Drawing.Point(415, 12)
        Me.pbCom.Name = "pbCom"
        Me.pbCom.Size = New System.Drawing.Size(60, 52)
        Me.pbCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCom.TabIndex = 5
        Me.pbCom.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.tictactoebacktrack.My.Resources.Resources.btntryagain
        Me.PictureBox3.Location = New System.Drawing.Point(587, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'pbKotakTTT
        '
        Me.pbKotakTTT.BackColor = System.Drawing.Color.Transparent
        Me.pbKotakTTT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbKotakTTT.Location = New System.Drawing.Point(50, 101)
        Me.pbKotakTTT.Name = "pbKotakTTT"
        Me.pbKotakTTT.Size = New System.Drawing.Size(483, 339)
        Me.pbKotakTTT.TabIndex = 6
        Me.pbKotakTTT.TabStop = False
        '
        'FrmPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tictactoebacktrack.My.Resources.Resources.bgplay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 501)
        Me.Controls.Add(Me.pbKotakTTT)
        Me.Controls.Add(Me.pbCom)
        Me.Controls.Add(Me.pbPlayer)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pbtnExit)
        Me.Controls.Add(Me.lblturn)
        Me.Controls.Add(Me.lblgloses)
        Me.Controls.Add(Me.lblgwins)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPlay"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbKotakTTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblgwins As System.Windows.Forms.Label
    Friend WithEvents lblgloses As System.Windows.Forms.Label
    Friend WithEvents lblturn As System.Windows.Forms.Label
    Friend WithEvents pbtnExit As System.Windows.Forms.PictureBox
    Friend WithEvents pbPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pbCom As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbKotakTTT As System.Windows.Forms.PictureBox
End Class
