<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlGameArea = New System.Windows.Forms.Panel()
        Me.picLazer2 = New System.Windows.Forms.PictureBox()
        Me.picLazer1 = New System.Windows.Forms.PictureBox()
        Me.picShip = New System.Windows.Forms.PictureBox()
        Me.picGarbage4 = New System.Windows.Forms.PictureBox()
        Me.picGarbage3 = New System.Windows.Forms.PictureBox()
        Me.picGarbage2 = New System.Windows.Forms.PictureBox()
        Me.picGarbage1 = New System.Windows.Forms.PictureBox()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.pnlGameArea.SuspendLayout()
        CType(Me.picLazer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLazer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGarbage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGarbage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGarbage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGarbage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(506, 81)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(100, 21)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "0"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Brown
        Me.lblTitle.Location = New System.Drawing.Point(200, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(218, 33)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Garbage Shooter"
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblHeading.Location = New System.Drawing.Point(525, 48)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(66, 33)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Score:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStart, Me.mnuQuit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 35)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuStart
        '
        Me.mnuStart.Name = "mnuStart"
        Me.mnuStart.Size = New System.Drawing.Size(75, 31)
        Me.mnuStart.Text = "Start"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(65, 31)
        Me.mnuQuit.Text = "Quit"
        '
        'pnlGameArea
        '
        Me.pnlGameArea.BackgroundImage = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.maxresdefault
        Me.pnlGameArea.Controls.Add(Me.picLazer2)
        Me.pnlGameArea.Controls.Add(Me.picLazer1)
        Me.pnlGameArea.Controls.Add(Me.picShip)
        Me.pnlGameArea.Controls.Add(Me.picGarbage4)
        Me.pnlGameArea.Controls.Add(Me.picGarbage3)
        Me.pnlGameArea.Controls.Add(Me.picGarbage2)
        Me.pnlGameArea.Controls.Add(Me.picGarbage1)
        Me.pnlGameArea.Location = New System.Drawing.Point(72, 105)
        Me.pnlGameArea.Name = "pnlGameArea"
        Me.pnlGameArea.Size = New System.Drawing.Size(473, 445)
        Me.pnlGameArea.TabIndex = 5
        '
        'picLazer2
        '
        Me.picLazer2.BackColor = System.Drawing.Color.Transparent
        Me.picLazer2.Enabled = False
        Me.picLazer2.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.blast_harrier_laser_1__1_
        Me.picLazer2.Location = New System.Drawing.Point(245, 311)
        Me.picLazer2.Name = "picLazer2"
        Me.picLazer2.Size = New System.Drawing.Size(10, 27)
        Me.picLazer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLazer2.TabIndex = 7
        Me.picLazer2.TabStop = False
        '
        'picLazer1
        '
        Me.picLazer1.BackColor = System.Drawing.Color.Transparent
        Me.picLazer1.Enabled = False
        Me.picLazer1.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.blast_harrier_laser_1__1_
        Me.picLazer1.Location = New System.Drawing.Point(245, 311)
        Me.picLazer1.Name = "picLazer1"
        Me.picLazer1.Size = New System.Drawing.Size(10, 27)
        Me.picLazer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLazer1.TabIndex = 6
        Me.picLazer1.TabStop = False
        '
        'picShip
        '
        Me.picShip.BackColor = System.Drawing.Color.Transparent
        Me.picShip.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.ship
        Me.picShip.Location = New System.Drawing.Point(220, 344)
        Me.picShip.Name = "picShip"
        Me.picShip.Size = New System.Drawing.Size(62, 77)
        Me.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShip.TabIndex = 5
        Me.picShip.TabStop = False
        '
        'picGarbage4
        '
        Me.picGarbage4.BackColor = System.Drawing.Color.Transparent
        Me.picGarbage4.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.TRASH
        Me.picGarbage4.Location = New System.Drawing.Point(381, 3)
        Me.picGarbage4.Name = "picGarbage4"
        Me.picGarbage4.Size = New System.Drawing.Size(57, 55)
        Me.picGarbage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGarbage4.TabIndex = 4
        Me.picGarbage4.TabStop = False
        '
        'picGarbage3
        '
        Me.picGarbage3.BackColor = System.Drawing.Color.Transparent
        Me.picGarbage3.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.TRASH
        Me.picGarbage3.Location = New System.Drawing.Point(268, 3)
        Me.picGarbage3.Name = "picGarbage3"
        Me.picGarbage3.Size = New System.Drawing.Size(54, 55)
        Me.picGarbage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGarbage3.TabIndex = 3
        Me.picGarbage3.TabStop = False
        '
        'picGarbage2
        '
        Me.picGarbage2.BackColor = System.Drawing.Color.Transparent
        Me.picGarbage2.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.TRASH
        Me.picGarbage2.Location = New System.Drawing.Point(134, 3)
        Me.picGarbage2.Name = "picGarbage2"
        Me.picGarbage2.Size = New System.Drawing.Size(56, 55)
        Me.picGarbage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGarbage2.TabIndex = 2
        Me.picGarbage2.TabStop = False
        '
        'picGarbage1
        '
        Me.picGarbage1.BackColor = System.Drawing.Color.Transparent
        Me.picGarbage1.Image = Global.Garbage_Shooter_BY_Jason_Abi_Chebli.My.Resources.Resources.TRASH
        Me.picGarbage1.Location = New System.Drawing.Point(39, 3)
        Me.picGarbage1.Name = "picGarbage1"
        Me.picGarbage1.Size = New System.Drawing.Size(56, 55)
        Me.picGarbage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGarbage1.TabIndex = 1
        Me.picGarbage1.TabStop = False
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 573)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.pnlGameArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlGameArea.ResumeLayout(False)
        CType(Me.picLazer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLazer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGarbage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGarbage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGarbage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGarbage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents picLazer2 As PictureBox
    Friend WithEvents picLazer1 As PictureBox
    Friend WithEvents picShip As PictureBox
    Friend WithEvents picGarbage4 As PictureBox
    Friend WithEvents picGarbage3 As PictureBox
    Friend WithEvents picGarbage2 As PictureBox
    Friend WithEvents picGarbage1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuStart As ToolStripMenuItem
    Friend WithEvents mnuQuit As ToolStripMenuItem
    Friend WithEvents tmrGame As Timer
End Class
