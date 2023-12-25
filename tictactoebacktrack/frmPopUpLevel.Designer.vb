<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopUpLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopUpLevel))
        Me.pbtnSelect = New System.Windows.Forms.PictureBox
        Me.lbleasy = New System.Windows.Forms.Label
        Me.lblmedium = New System.Windows.Forms.Label
        Me.lblhard = New System.Windows.Forms.Label
        Me.lblselect = New System.Windows.Forms.Label
        Me.lblselect2 = New System.Windows.Forms.Label
        Me.lblselecthard = New System.Windows.Forms.Label
        CType(Me.pbtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbtnSelect
        '
        Me.pbtnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbtnSelect.Image = Global.tictactoebacktrack.My.Resources.Resources.btnselect
        Me.pbtnSelect.Location = New System.Drawing.Point(67, 320)
        Me.pbtnSelect.Name = "pbtnSelect"
        Me.pbtnSelect.Size = New System.Drawing.Size(166, 58)
        Me.pbtnSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbtnSelect.TabIndex = 1
        Me.pbtnSelect.TabStop = False
        '
        'lbleasy
        '
        Me.lbleasy.AutoSize = True
        Me.lbleasy.BackColor = System.Drawing.Color.Transparent
        Me.lbleasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbleasy.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleasy.ForeColor = System.Drawing.Color.Yellow
        Me.lbleasy.Location = New System.Drawing.Point(102, 95)
        Me.lbleasy.Name = "lbleasy"
        Me.lbleasy.Size = New System.Drawing.Size(88, 45)
        Me.lbleasy.TabIndex = 2
        Me.lbleasy.Text = "Easy"
        '
        'lblmedium
        '
        Me.lblmedium.AutoSize = True
        Me.lblmedium.BackColor = System.Drawing.Color.Transparent
        Me.lblmedium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmedium.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedium.ForeColor = System.Drawing.Color.Yellow
        Me.lblmedium.Location = New System.Drawing.Point(75, 164)
        Me.lblmedium.Name = "lblmedium"
        Me.lblmedium.Size = New System.Drawing.Size(142, 45)
        Me.lblmedium.TabIndex = 2
        Me.lblmedium.Text = "Medium"
        '
        'lblhard
        '
        Me.lblhard.AutoSize = True
        Me.lblhard.BackColor = System.Drawing.Color.Transparent
        Me.lblhard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblhard.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhard.ForeColor = System.Drawing.Color.Yellow
        Me.lblhard.Location = New System.Drawing.Point(102, 231)
        Me.lblhard.Name = "lblhard"
        Me.lblhard.Size = New System.Drawing.Size(92, 45)
        Me.lblhard.TabIndex = 2
        Me.lblhard.Text = "Hard"
        '
        'lblselect
        '
        Me.lblselect.BackColor = System.Drawing.Color.DarkRed
        Me.lblselect.Location = New System.Drawing.Point(1, 90)
        Me.lblselect.Name = "lblselect"
        Me.lblselect.Size = New System.Drawing.Size(304, 54)
        Me.lblselect.TabIndex = 3
        Me.lblselect.Visible = False
        '
        'lblselect2
        '
        Me.lblselect2.BackColor = System.Drawing.Color.DarkRed
        Me.lblselect2.Location = New System.Drawing.Point(1, 160)
        Me.lblselect2.Name = "lblselect2"
        Me.lblselect2.Size = New System.Drawing.Size(304, 54)
        Me.lblselect2.TabIndex = 3
        Me.lblselect2.Visible = False
        '
        'lblselecthard
        '
        Me.lblselecthard.BackColor = System.Drawing.Color.DarkRed
        Me.lblselecthard.Location = New System.Drawing.Point(1, 225)
        Me.lblselecthard.Name = "lblselecthard"
        Me.lblselecthard.Size = New System.Drawing.Size(304, 54)
        Me.lblselecthard.TabIndex = 3
        Me.lblselecthard.Visible = False
        '
        'frmPopUpLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(303, 399)
        Me.Controls.Add(Me.lblhard)
        Me.Controls.Add(Me.lblmedium)
        Me.Controls.Add(Me.lbleasy)
        Me.Controls.Add(Me.pbtnSelect)
        Me.Controls.Add(Me.lblselecthard)
        Me.Controls.Add(Me.lblselect2)
        Me.Controls.Add(Me.lblselect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPopUpLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPopUpLevel"
        CType(Me.pbtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbtnSelect As System.Windows.Forms.PictureBox
    Friend WithEvents lbleasy As System.Windows.Forms.Label
    Friend WithEvents lblmedium As System.Windows.Forms.Label
    Friend WithEvents lblhard As System.Windows.Forms.Label
    Friend WithEvents lblselect As System.Windows.Forms.Label
    Friend WithEvents lblselect2 As System.Windows.Forms.Label
    Friend WithEvents lblselecthard As System.Windows.Forms.Label
End Class
