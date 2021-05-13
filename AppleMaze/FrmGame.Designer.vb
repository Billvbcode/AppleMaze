<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGame
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblApples = New System.Windows.Forms.Label()
        Me.TimFire = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimFoe = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblIce = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimShoot = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PIceBlock = New System.Windows.Forms.PictureBox()
        Me.PFoe = New System.Windows.Forms.PictureBox()
        Me.PKnight = New System.Windows.Forms.PictureBox()
        Me.Pice = New System.Windows.Forms.PictureBox()
        Me.PHeart = New System.Windows.Forms.PictureBox()
        Me.PEHeart = New System.Windows.Forms.PictureBox()
        Me.PBomb = New System.Windows.Forms.PictureBox()
        Me.PFire = New System.Windows.Forms.PictureBox()
        Me.PBlob = New System.Windows.Forms.PictureBox()
        Me.PEyeShoot = New System.Windows.Forms.PictureBox()
        Me.PGhost = New System.Windows.Forms.PictureBox()
        Me.PEye = New System.Windows.Forms.PictureBox()
        Me.PDown = New System.Windows.Forms.PictureBox()
        Me.PBox = New System.Windows.Forms.PictureBox()
        Me.PChest = New System.Windows.Forms.PictureBox()
        Me.PWater = New System.Windows.Forms.PictureBox()
        Me.PExit = New System.Windows.Forms.PictureBox()
        Me.PRock = New System.Windows.Forms.PictureBox()
        Me.Pman = New System.Windows.Forms.PictureBox()
        Me.Phole = New System.Windows.Forms.PictureBox()
        Me.PApple = New System.Windows.Forms.PictureBox()
        Me.PGrass = New System.Windows.Forms.PictureBox()
        Me.Pwall = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pHeart2 = New System.Windows.Forms.PictureBox()
        Me.PApple2 = New System.Windows.Forms.PictureBox()
        Me.pBomb2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PIceBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PFoe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PKnight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBomb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBlob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEyeShoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PGhost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PChest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PApple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PGrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pHeart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PApple2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBomb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(582, 343)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 121)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(601, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'LblApples
        '
        Me.LblApples.AutoSize = True
        Me.LblApples.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApples.Location = New System.Drawing.Point(112, 9)
        Me.LblApples.Name = "LblApples"
        Me.LblApples.Size = New System.Drawing.Size(0, 16)
        Me.LblApples.TabIndex = 16
        '
        'TimFire
        '
        Me.TimFire.Interval = 400
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'TimFoe
        '
        Me.TimFoe.Interval = 400
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(588, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'LblIce
        '
        Me.LblIce.AutoSize = True
        Me.LblIce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIce.Location = New System.Drawing.Point(618, 186)
        Me.LblIce.Name = "LblIce"
        Me.LblIce.Size = New System.Drawing.Size(0, 16)
        Me.LblIce.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "N - Next Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(581, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "L - Last Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(581, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Q - Quit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.EditToolStripMenuItem.Text = "Editor"
        '
        'TimShoot
        '
        Me.TimShoot.Interval = 200
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(581, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "F - Fire"
        '
        'PIceBlock
        '
        Me.PIceBlock.Image = Global.WindowsApplication1.My.Resources.Resources.iceblock
        Me.PIceBlock.Location = New System.Drawing.Point(658, 521)
        Me.PIceBlock.Name = "PIceBlock"
        Me.PIceBlock.Size = New System.Drawing.Size(31, 25)
        Me.PIceBlock.TabIndex = 37
        Me.PIceBlock.TabStop = False
        Me.PIceBlock.Tag = "L"
        Me.PIceBlock.Visible = False
        '
        'PFoe
        '
        Me.PFoe.Image = Global.WindowsApplication1.My.Resources.Resources.E1
        Me.PFoe.Location = New System.Drawing.Point(12, 552)
        Me.PFoe.Name = "PFoe"
        Me.PFoe.Size = New System.Drawing.Size(31, 25)
        Me.PFoe.TabIndex = 30
        Me.PFoe.TabStop = False
        Me.PFoe.Tag = "F"
        '
        'PKnight
        '
        Me.PKnight.Image = Global.WindowsApplication1.My.Resources.Resources.knight
        Me.PKnight.Location = New System.Drawing.Point(568, 552)
        Me.PKnight.Name = "PKnight"
        Me.PKnight.Size = New System.Drawing.Size(31, 25)
        Me.PKnight.TabIndex = 29
        Me.PKnight.TabStop = False
        Me.PKnight.Tag = "L"
        '
        'Pice
        '
        Me.Pice.Image = Global.WindowsApplication1.My.Resources.Resources.Ice
        Me.Pice.Location = New System.Drawing.Point(581, 186)
        Me.Pice.Name = "Pice"
        Me.Pice.Size = New System.Drawing.Size(31, 25)
        Me.Pice.TabIndex = 27
        Me.Pice.TabStop = False
        Me.Pice.Tag = "D"
        '
        'PHeart
        '
        Me.PHeart.Image = Global.WindowsApplication1.My.Resources.Resources.Heart
        Me.PHeart.Location = New System.Drawing.Point(582, 84)
        Me.PHeart.Name = "PHeart"
        Me.PHeart.Size = New System.Drawing.Size(31, 25)
        Me.PHeart.TabIndex = 26
        Me.PHeart.TabStop = False
        Me.PHeart.Tag = "D"
        '
        'PEHeart
        '
        Me.PEHeart.Image = Global.WindowsApplication1.My.Resources.Resources.eheart
        Me.PEHeart.Location = New System.Drawing.Point(494, 552)
        Me.PEHeart.Name = "PEHeart"
        Me.PEHeart.Size = New System.Drawing.Size(31, 25)
        Me.PEHeart.TabIndex = 23
        Me.PEHeart.TabStop = False
        Me.PEHeart.Tag = "U"
        '
        'PBomb
        '
        Me.PBomb.Image = Global.WindowsApplication1.My.Resources.Resources.bomb
        Me.PBomb.Location = New System.Drawing.Point(581, 155)
        Me.PBomb.Name = "PBomb"
        Me.PBomb.Size = New System.Drawing.Size(31, 25)
        Me.PBomb.TabIndex = 22
        Me.PBomb.TabStop = False
        Me.PBomb.Tag = "b"
        '
        'PFire
        '
        Me.PFire.Image = Global.WindowsApplication1.My.Resources.Resources.Fire
        Me.PFire.Location = New System.Drawing.Point(457, 552)
        Me.PFire.Name = "PFire"
        Me.PFire.Size = New System.Drawing.Size(31, 25)
        Me.PFire.TabIndex = 21
        Me.PFire.TabStop = False
        Me.PFire.Tag = "F"
        '
        'PBlob
        '
        Me.PBlob.Image = Global.WindowsApplication1.My.Resources.Resources.Blob
        Me.PBlob.Location = New System.Drawing.Point(420, 552)
        Me.PBlob.Name = "PBlob"
        Me.PBlob.Size = New System.Drawing.Size(31, 25)
        Me.PBlob.TabIndex = 20
        Me.PBlob.TabStop = False
        Me.PBlob.Tag = "B"
        '
        'PEyeShoot
        '
        Me.PEyeShoot.Image = Global.WindowsApplication1.My.Resources.Resources.e2
        Me.PEyeShoot.Location = New System.Drawing.Point(621, 521)
        Me.PEyeShoot.Name = "PEyeShoot"
        Me.PEyeShoot.Size = New System.Drawing.Size(31, 25)
        Me.PEyeShoot.TabIndex = 19
        Me.PEyeShoot.TabStop = False
        Me.PEyeShoot.Tag = "x"
        Me.PEyeShoot.Visible = False
        '
        'PGhost
        '
        Me.PGhost.Image = Global.WindowsApplication1.My.Resources.Resources.ghost
        Me.PGhost.Location = New System.Drawing.Point(139, 552)
        Me.PGhost.Name = "PGhost"
        Me.PGhost.Size = New System.Drawing.Size(31, 25)
        Me.PGhost.TabIndex = 17
        Me.PGhost.TabStop = False
        Me.PGhost.Tag = "G"
        '
        'PEye
        '
        Me.PEye.Image = Global.WindowsApplication1.My.Resources.Resources.eye1
        Me.PEye.Location = New System.Drawing.Point(383, 552)
        Me.PEye.Name = "PEye"
        Me.PEye.Size = New System.Drawing.Size(31, 25)
        Me.PEye.TabIndex = 15
        Me.PEye.TabStop = False
        Me.PEye.Tag = "E"
        '
        'PDown
        '
        Me.PDown.Image = Global.WindowsApplication1.My.Resources.Resources.down
        Me.PDown.Location = New System.Drawing.Point(531, 552)
        Me.PDown.Name = "PDown"
        Me.PDown.Size = New System.Drawing.Size(31, 25)
        Me.PDown.TabIndex = 14
        Me.PDown.TabStop = False
        Me.PDown.Tag = "D"
        '
        'PBox
        '
        Me.PBox.Image = Global.WindowsApplication1.My.Resources.Resources.Box
        Me.PBox.Location = New System.Drawing.Point(346, 552)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(31, 25)
        Me.PBox.TabIndex = 13
        Me.PBox.TabStop = False
        Me.PBox.Tag = "a"
        '
        'PChest
        '
        Me.PChest.Image = Global.WindowsApplication1.My.Resources.Resources.chest
        Me.PChest.Location = New System.Drawing.Point(309, 552)
        Me.PChest.Name = "PChest"
        Me.PChest.Size = New System.Drawing.Size(24, 25)
        Me.PChest.TabIndex = 12
        Me.PChest.TabStop = False
        Me.PChest.Tag = "c"
        '
        'PWater
        '
        Me.PWater.Image = Global.WindowsApplication1.My.Resources.Resources.Water
        Me.PWater.Location = New System.Drawing.Point(272, 552)
        Me.PWater.Name = "PWater"
        Me.PWater.Size = New System.Drawing.Size(31, 25)
        Me.PWater.TabIndex = 11
        Me.PWater.TabStop = False
        Me.PWater.Tag = "x"
        '
        'PExit
        '
        Me.PExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.PExit.Location = New System.Drawing.Point(244, 552)
        Me.PExit.Name = "PExit"
        Me.PExit.Size = New System.Drawing.Size(31, 25)
        Me.PExit.TabIndex = 10
        Me.PExit.TabStop = False
        Me.PExit.Tag = "e"
        '
        'PRock
        '
        Me.PRock.Image = Global.WindowsApplication1.My.Resources.Resources.Rock
        Me.PRock.Location = New System.Drawing.Point(207, 552)
        Me.PRock.Name = "PRock"
        Me.PRock.Size = New System.Drawing.Size(31, 25)
        Me.PRock.TabIndex = 9
        Me.PRock.TabStop = False
        Me.PRock.Tag = "r"
        '
        'Pman
        '
        Me.Pman.Image = Global.WindowsApplication1.My.Resources.Resources.Man
        Me.Pman.Location = New System.Drawing.Point(176, 552)
        Me.Pman.Name = "Pman"
        Me.Pman.Size = New System.Drawing.Size(31, 25)
        Me.Pman.TabIndex = 8
        Me.Pman.TabStop = False
        Me.Pman.Tag = "m"
        '
        'Phole
        '
        Me.Phole.Image = Global.WindowsApplication1.My.Resources.Resources.Hole
        Me.Phole.Location = New System.Drawing.Point(108, 552)
        Me.Phole.Name = "Phole"
        Me.Phole.Size = New System.Drawing.Size(25, 25)
        Me.Phole.TabIndex = 7
        Me.Phole.TabStop = False
        Me.Phole.Tag = "h"
        '
        'PApple
        '
        Me.PApple.Image = Global.WindowsApplication1.My.Resources.Resources.Food
        Me.PApple.Location = New System.Drawing.Point(581, 115)
        Me.PApple.Name = "PApple"
        Me.PApple.Size = New System.Drawing.Size(25, 25)
        Me.PApple.TabIndex = 6
        Me.PApple.TabStop = False
        Me.PApple.Tag = "f"
        '
        'PGrass
        '
        Me.PGrass.Image = Global.WindowsApplication1.My.Resources.Resources.Ground
        Me.PGrass.Location = New System.Drawing.Point(77, 552)
        Me.PGrass.Name = "PGrass"
        Me.PGrass.Size = New System.Drawing.Size(25, 25)
        Me.PGrass.TabIndex = 5
        Me.PGrass.TabStop = False
        Me.PGrass.Tag = "g"
        '
        'Pwall
        '
        Me.Pwall.Image = Global.WindowsApplication1.My.Resources.Resources.Wall
        Me.Pwall.Location = New System.Drawing.Point(46, 552)
        Me.Pwall.Name = "Pwall"
        Me.Pwall.Size = New System.Drawing.Size(25, 25)
        Me.Pwall.TabIndex = 4
        Me.Pwall.TabStop = False
        Me.Pwall.Tag = "w"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(588, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'pHeart2
        '
        Me.pHeart2.Image = Global.WindowsApplication1.My.Resources.Resources.Heart
        Me.pHeart2.Location = New System.Drawing.Point(609, 552)
        Me.pHeart2.Name = "pHeart2"
        Me.pHeart2.Size = New System.Drawing.Size(31, 25)
        Me.pHeart2.TabIndex = 39
        Me.pHeart2.TabStop = False
        Me.pHeart2.Tag = "D"
        '
        'PApple2
        '
        Me.PApple2.Image = Global.WindowsApplication1.My.Resources.Resources.Food
        Me.PApple2.Location = New System.Drawing.Point(646, 552)
        Me.PApple2.Name = "PApple2"
        Me.PApple2.Size = New System.Drawing.Size(25, 25)
        Me.PApple2.TabIndex = 40
        Me.PApple2.TabStop = False
        Me.PApple2.Tag = "f"
        '
        'pBomb2
        '
        Me.pBomb2.Image = Global.WindowsApplication1.My.Resources.Resources.bomb
        Me.pBomb2.Location = New System.Drawing.Point(677, 552)
        Me.pBomb2.Name = "pBomb2"
        Me.pBomb2.Size = New System.Drawing.Size(31, 25)
        Me.pBomb2.TabIndex = 41
        Me.pBomb2.TabStop = False
        Me.pBomb2.Tag = "b"
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 589)
        Me.Controls.Add(Me.pBomb2)
        Me.Controls.Add(Me.PApple2)
        Me.Controls.Add(Me.pHeart2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PIceBlock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PFoe)
        Me.Controls.Add(Me.PKnight)
        Me.Controls.Add(Me.LblIce)
        Me.Controls.Add(Me.Pice)
        Me.Controls.Add(Me.PHeart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PEHeart)
        Me.Controls.Add(Me.PBomb)
        Me.Controls.Add(Me.PFire)
        Me.Controls.Add(Me.PBlob)
        Me.Controls.Add(Me.PEyeShoot)
        Me.Controls.Add(Me.PGhost)
        Me.Controls.Add(Me.LblApples)
        Me.Controls.Add(Me.PEye)
        Me.Controls.Add(Me.PDown)
        Me.Controls.Add(Me.PBox)
        Me.Controls.Add(Me.PChest)
        Me.Controls.Add(Me.PWater)
        Me.Controls.Add(Me.PExit)
        Me.Controls.Add(Me.PRock)
        Me.Controls.Add(Me.Pman)
        Me.Controls.Add(Me.Phole)
        Me.Controls.Add(Me.PApple)
        Me.Controls.Add(Me.PGrass)
        Me.Controls.Add(Me.Pwall)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmGame"
        Me.Text = "Maze Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PIceBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PFoe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PKnight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHeart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEHeart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBomb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBlob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEyeShoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PGhost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PChest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PApple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PGrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pHeart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PApple2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBomb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pwall As System.Windows.Forms.PictureBox
    Friend WithEvents PGrass As System.Windows.Forms.PictureBox
    Friend WithEvents PApple As System.Windows.Forms.PictureBox
    Friend WithEvents Phole As System.Windows.Forms.PictureBox
    Friend WithEvents PWater As System.Windows.Forms.PictureBox
    Friend WithEvents PExit As System.Windows.Forms.PictureBox
    Friend WithEvents PRock As System.Windows.Forms.PictureBox
    Friend WithEvents Pman As System.Windows.Forms.PictureBox
    Friend WithEvents PEye As System.Windows.Forms.PictureBox
    Friend WithEvents PDown As System.Windows.Forms.PictureBox
    Friend WithEvents PBox As System.Windows.Forms.PictureBox
    Friend WithEvents PChest As System.Windows.Forms.PictureBox
    Friend WithEvents LblApples As System.Windows.Forms.Label
    Friend WithEvents PGhost As System.Windows.Forms.PictureBox
    Friend WithEvents TimFire As System.Windows.Forms.Timer
    Friend WithEvents PEHeart As System.Windows.Forms.PictureBox
    Friend WithEvents PBomb As System.Windows.Forms.PictureBox
    Friend WithEvents PFire As System.Windows.Forms.PictureBox
    Friend WithEvents PBlob As System.Windows.Forms.PictureBox
    Friend WithEvents PEyeShoot As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TimFoe As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PHeart As System.Windows.Forms.PictureBox
    Friend WithEvents Pice As System.Windows.Forms.PictureBox
    Friend WithEvents LblIce As System.Windows.Forms.Label
    Friend WithEvents PKnight As System.Windows.Forms.PictureBox
    Friend WithEvents PFoe As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimShoot As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PIceBlock As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pHeart2 As System.Windows.Forms.PictureBox
    Friend WithEvents PApple2 As System.Windows.Forms.PictureBox
    Friend WithEvents pBomb2 As System.Windows.Forms.PictureBox

End Class
