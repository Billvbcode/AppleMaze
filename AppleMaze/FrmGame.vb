Public Class FrmGame
    Dim iLevel As Integer
    Dim iManLoc As Integer
    Dim sManDir As String
    Dim iIceLoc As Integer
    Dim sIceDir As String
    Dim iManOld As Integer
    Dim bEye As Boolean
    Dim bEyeFire As Boolean
    Dim iEyeAdd As Integer
    Dim bEyeFire2 As Boolean
    Dim iEyeAdd2 As Integer
    Dim iEyeLoc As Integer
    Dim iEyeLoc2 As Integer
    Dim iHeartLoc As Integer
    Dim sKeyValue As String
    Dim iFadd As Integer
    Dim iFold As Integer
    Public Sub CountApples()
        '
        ' Count the apples left
        '
        Dim i As Integer
        iApple = 0
        For i = 1 To 400
            If PB(i).Tag = "f" Then iApple = iApple + 1
            If PB(i).Tag = "I" Then iApple = iApple + 1
            If PB(i).Tag = "J" Then iApple = iApple + 1
        Next
        LblApples.Text = "Apples = " & iApple
        Label3.Text = iManLoc & " " & iLevel & " " & iManOld
    End Sub
    Private Sub DrawMap()
        'Draw Map
        Dim i As Integer
        Dim k As Integer
        Dim l As Integer
        If bNewLevel Then iChest = 0
        ice = 0
        LblIce.Text = "FIRE=" & ice
        PHeart.Visible = False
        PApple.Visible = False
        PBomb.Visible = False
        bEye = False
        bEyeFire = False
        TimFire.Enabled = False
        TimFoe.Enabled = False
        TimShoot.Enabled = False
        bFoe = False
        colFoe = New Collection
        cFoe = New ClsFoe
        cFoe.FoeTag = "?"
        cFoe.FoeTagNow = "?"
        colFoe.Add(cFoe)
        For i = 1 To 400
            Select Case iMap(i)
                Case "a"
                    PB(i).Image = PBox.Image
                    PB(i).Tag = PBox.Tag
                Case "b"
                    PB(i).Image = PBomb.Image
                    PB(i).Tag = PBomb.Tag
                Case "B"
                    PB(i).Image = PBlob.Image
                    PB(i).Tag = PBlob.Tag
                    cFoe = New ClsFoe         ' Add blob to foe class
                    cFoe.FoeTag = "B"
                    cFoe.FoeTagNow = "B"
                    cFoe.FoeiAdd = 1
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Blob"
                    cFoe.FoePic = PBlob.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "c"
                    PB(i).Image = PChest.Image
                    PB(i).Tag = PChest.Tag
                    If bNewLevel Then
                        iChest = iChest + 1
                        sChest(iChest) = PChest.Tag
                        iChestLoc(iChest) = i
                    End If
                Case "D", "2"
                    PB(i).Image = PDown.Image
                    PB(i).Tag = iMap(i)
                    cFoe = New ClsFoe         ' Add Gates to foe class
                    cFoe.FoeTag = iMap(i)
                    cFoe.FoeTagNow = iMap(i)
                    cFoe.FoeiAdd = 1
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Gate"
                    cFoe.FoePic = PDown.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "e"
                    PB(i).Image = PExit.Image
                    PB(i).Tag = PExit.Tag
                Case "E"
                    PB(i).Image = PEye.Image
                    PB(i).Tag = PEye.Tag
                    bEye = True
                Case "f"
                    PB(i).Image = PApple.Image
                    PB(i).Tag = PApple.Tag
                Case "F"
                    PB(i).Image = PFire.Image
                    PB(i).Tag = PFire.Tag
                    cFoe = New ClsFoe         ' Add fire to foe class
                    cFoe.FoeTag = "F"
                    cFoe.FoeTagNow = "F"
                    cFoe.FoeiAdd = 1
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Fire"
                    cFoe.FoePic = PFire.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "g"
                    PB(i).Image = PGrass.Image
                    PB(i).Tag = PGrass.Tag
                Case "G"
                    PB(i).Image = PGhost.Image
                    PB(i).Tag = PGhost.Tag
                    cFoe = New ClsFoe         ' Add ghost to foe class
                    cFoe.FoeTag = "G"
                    cFoe.FoeTagNow = "G"
                    cFoe.FoeiAdd = -20
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Ghost"
                    cFoe.FoePic = PGhost.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "h"
                    PB(i).Image = Phole.Image
                    PB(i).Tag = Phole.Tag
                Case "I", "J"
                    PB(i).Image = PHeart.Image
                    PB(i).Tag = iMap(i)
                Case "K"
                    PB(i).Image = PFoe.Image
                    PB(i).Tag = iMap(i)
                    cFoe = New ClsFoe         ' Add foe to foe class
                    cFoe.FoeTag = iMap(i)
                    cFoe.FoeTagNow = iMap(i)
                    cFoe.FoeiAdd = -20
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Foe"
                    cFoe.FoePic = PFoe.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "L"
                    PB(i).Image = PKnight.Image
                    PB(i).Tag = PKnight.Tag
                    cFoe = New ClsFoe         ' Add Knight to foe class
                    cFoe.FoeTag = "L"
                    cFoe.FoeTagNow = "L"
                    cFoe.FoeiAdd = 1
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Knight"
                    cFoe.FoePic = PKnight.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "m"
                    PB(i).Image = Pman.Image
                    PB(i).Tag = Pman.Tag
                    iManLoc = i
                    iManOld = i
                Case "M"
                    PB(i).Image = PEHeart.Image
                    PB(i).Tag = PEHeart.Tag
                    cFoe = New ClsFoe         ' Add Evil Heart across to foe class
                    cFoe.FoeTag = "M"
                    cFoe.FoeTagNow = "M"
                    cFoe.FoeiAdd = -1
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Evil Heart"
                    cFoe.FoePic = PEHeart.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "r"
                    PB(i).Image = PRock.Image
                    PB(i).Tag = PRock.Tag
                    PB(i).Tag = PRock.Tag
                Case "U"
                    PB(i).Image = PEHeart.Image
                    PB(i).Tag = PEHeart.Tag
                    cFoe = New ClsFoe         ' Add Evil Heart up to foe class
                    cFoe.FoeTag = "U"
                    cFoe.FoeTagNow = "U"
                    cFoe.FoeiAdd = -20
                    cFoe.FoeLoc = i
                    cFoe.FoeiStart = i
                    cFoe.FoeMsg = "Evil Heart"
                    cFoe.FoePic = PEHeart.Image
                    colFoe.Add(cFoe)
                    bFoe = True
                Case "w"
                    PB(i).Image = Pwall.Image
                    PB(i).Tag = Pwall.Tag
                Case "x"
                    PB(i).Image = PWater.Image
                    PB(i).Tag = PWater.Tag
                Case Else
                    Label1.Text = iMap(i)
            End Select
        Next
        ' Label3.Text = iManLoc & " " & iLevel
        '
        ' Put Apples(f) in random chests
        '
        k = 0
        If iChest > 0 Then k = 1 + Int(iChest / 10)
        If k > 0 And bNewLevel Then
            For l = 1 To k
Pickagain:
                i = 3000 * Rnd()
                i = i Mod iChest
                If sChest(i + 1) = "f" Then GoTo Pickagain
                sChest(i + 1) = "f"
            Next
        End If
        bNewLevel = False
        If iChest > 0 Then
            For l = 1 To iChest
                If sChest(l) = "f" Then
                    PB(iChestLoc(l)).Tag = "f"
                End If
            Next
        End If
        CountApples()
        If bFoe Then TimFoe.Enabled = True
    End Sub
    Public Sub GetFiles()
        '
        ' Read all the levels
        '
        Dim value As String = My.Application.Info.DirectoryPath & "\gamlevels\"
        Dim di As New IO.DirectoryInfo(value)
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.lev")
        Dim dra As IO.FileInfo
        Dim sMsg As String
        sMsg = value
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub Moveme()
        Dim LocNew As Integer
        Dim LocNew2 As Integer
        Dim j As Integer
        Dim x As Integer
        If bEyeFire Then Exit Sub
        LocNew = iManLoc
        LocNew2 = iManLoc
        PApple.Visible = False
        PHeart.Visible = False
        Select Case sKeyValue
            Case Keys.F          ' Fire
                If ice > 0 Then
                    ice = ice - 1
                    LblIce.Text = "Fire= " & ice
                    sIceDir = sManDir
                    Select Case sIceDir
                        Case "L"
                            iFadd = -1
                        Case "R"
                            iFadd = 1
                        Case "U"
                            iFadd = -20
                        Case "D"
                            iFadd = 20
                    End Select
                    iIceLoc = iManLoc + iFadd
                    iFold = 0
                    TimShoot.Enabled = True
                End If
                Exit Sub
            Case Keys.J, Keys.Left   'Left
                LocNew = LocNew - 1
                LocNew2 = iManLoc - 2
                sManDir = "L"
            Case Keys.K, Keys.Right   'Right
                LocNew = LocNew + 1
                LocNew2 = iManLoc + 2
                sManDir = "R"
            Case Keys.I, Keys.Up     'Up
                LocNew = LocNew - 20
                LocNew2 = iManLoc - 40
                sManDir = "U"
            Case Keys.M, Keys.Down   'Down
                LocNew = LocNew + 20
                LocNew2 = iManLoc + 40
                sManDir = "D"
            Case Keys.N               ' Next level
                If iLevel < ListBox1.Items.Count Then iLevel = iLevel + 1
                TimFoe.Enabled = False
                TimFire.Enabled = False
                bNewLevel = True
                ReadLevel()
                DrawMap()
                Exit Sub
            Case Keys.L                    ' Last level
                If iLevel > 1 Then iLevel = iLevel - 1
                TimFoe.Enabled = False
                TimFire.Enabled = False
                bNewLevel = True
                ReadLevel()
                DrawMap()
                Exit Sub
            Case Keys.Q                     ' Quit
                End
            Case Keys.R                   ' Restart level
                TimFoe.Enabled = False
                TimFire.Enabled = False
                bNewLevel = True
                ReadLevel()
                DrawMap()
                Exit Sub
        End Select
        If LocNew < 21 Or LocNew > 380 Then Exit Sub
        Select Case PB(LocNew).Tag
            Case "a"                                         '  Push Box into water
                If LocNew2 > 21 And LocNew2 < 380 Then
                    If PB(LocNew2).Tag = "g" Then
                        PB(iManLoc).Image = PGrass.Image
                        PB(iManLoc).Tag = PGrass.Tag
                        iManLoc = LocNew
                        PB(iManLoc).Image = Pman.Image
                        PB(iManLoc).Tag = Pman.Tag
                        PB(LocNew2).Image = PBox.Image
                        PB(LocNew2).Tag = PBox.Tag
                    ElseIf PB(LocNew2).Tag = "x" Then
                        PB(iManLoc).Image = PGrass.Image
                        PB(iManLoc).Tag = PGrass.Tag
                        iManLoc = LocNew
                        PB(iManLoc).Image = Pman.Image
                        PB(iManLoc).Tag = Pman.Tag
                        PB(LocNew2).Image = PGrass.Image
                        PB(LocNew2).Tag = PGrass.Tag
                    End If
                End If
            Case "e"                                  '  Exit
                CountApples()
                If iApple = 0 Then
                    MsgBox("Next Level!", MsgBoxStyle.OkOnly, "Next")
                    bNewLevel = True
                    If iLevel < ListBox1.Items.Count Then iLevel = iLevel + 1
                    ReadLevel()
                    DrawMap()
                    Exit Sub
                End If
            Case "B", "E", "F", "h", "G", "M", "L", "U", "x"
                TimFoe.Enabled = False
                TimFire.Enabled = False
                If PB(LocNew).Tag = "B" Then MsgBox("Oh no - You hit a Blob!", MsgBoxStyle.OkOnly, "Blob")
                '  If PB(LocNew).Tag = "D" Then MsgBox("Oh no - You hit a Gate!", MsgBoxStyle.OkOnly, "Gate")
                ' If PB(LocNew).Tag = "2" Then MsgBox("Oh no - You hit a Gate!", MsgBoxStyle.OkOnly, "Gate")
                If PB(LocNew).Tag = "E" Then MsgBox("Oh no - You hit a Evil eye!", MsgBoxStyle.OkOnly, "Evil eye")
                If PB(LocNew).Tag = "F" Then MsgBox("Oh no - You hit Fire!", MsgBoxStyle.OkOnly, "Fire")
                If PB(LocNew).Tag = "G" Then MsgBox("Oh no - You hit a Ghost!", MsgBoxStyle.OkOnly, "Ghost")
                If PB(LocNew).Tag = "L" Then MsgBox("Oh no - You hit a Knight", MsgBoxStyle.OkOnly, "Evil Heart")
                If PB(LocNew).Tag = "M" Then MsgBox("Oh no - You hit a Evil Heart!", MsgBoxStyle.OkOnly, "Evil Heart")
                If PB(LocNew).Tag = "h" Then MsgBox("Oh no - You hit a Hole!", MsgBoxStyle.OkOnly, "Hole")
                If PB(LocNew).Tag = "U" Then MsgBox("Oh no - You hit a Evil Heart!", MsgBoxStyle.OkOnly, "Evil Heart")
                If PB(LocNew).Tag = "x" Then MsgBox("Oh no - You fell in the Water!", MsgBoxStyle.OkOnly, "Water")
                ReadLevel()
                DrawMap()
                Exit Sub
            Case "b", "f", "g", "c", "I", "J"
                If PB(LocNew).Tag = "f" Then PApple.Visible = True
                If PB(LocNew).Tag = "b" Then PBomb.Visible = True
                If PB(LocNew).Tag = "I" Then ice = ice + 1
                If PB(LocNew).Tag = "J" Then ice = ice + 2
                If PB(LocNew).Tag = "I" Then PHeart.Visible = True
                If PB(LocNew).Tag = "J" Then PHeart.Visible = True
                LblIce.Text = "Fire= " & ice
                PB(iManLoc).Image = PGrass.Image
                PB(iManLoc).Tag = PGrass.Tag
                iManLoc = LocNew
                PB(iManLoc).Image = Pman.Image
                PB(iManLoc).Tag = Pman.Tag
            Case "r"                                         '  Push Rock into hole
                If LocNew2 > 21 And LocNew2 < 380 Then
                    If PB(LocNew2).Tag = "g" Then
                        PB(iManLoc).Image = PGrass.Image
                        PB(iManLoc).Tag = PGrass.Tag
                        iManLoc = LocNew
                        PB(iManLoc).Image = Pman.Image
                        PB(iManLoc).Tag = Pman.Tag
                        PB(LocNew2).Image = PRock.Image
                        PB(LocNew2).Tag = PRock.Tag
                    ElseIf PB(LocNew2).Tag = "h" Then
                        PB(iManLoc).Image = PGrass.Image
                        PB(iManLoc).Tag = PGrass.Tag
                        iManLoc = LocNew
                        PB(iManLoc).Image = Pman.Image
                        PB(iManLoc).Tag = Pman.Tag
                        PB(LocNew2).Image = PGrass.Image
                        PB(LocNew2).Tag = PGrass.Tag
                    End If
                End If
            Case "w"                      'Wall
                If PBomb.Visible Then
                    PB(iManLoc).Image = PGrass.Image
                    PB(iManLoc).Tag = PGrass.Tag
                    iManLoc = LocNew
                    PB(iManLoc).Image = Pman.Image
                    PB(iManLoc).Tag = Pman.Tag
                    PBomb.Visible = False
                End If
        End Select
        CountApples()
        '
        'Evil Eye Shoot
        '
        bEyeFire = False
        For x = 1 To 400
            If bEye Then
                If PB(x).Tag = "E" Then
                    For j = x + 1 To x + 19
                        If PB(j).Tag = "g" Or PB(j).Tag = "m" Then
                            If PB(j).Tag = "m" Then
                                iEyeAdd = 1
                                bEyeFire = True
                                iEyeLoc = x + 1
                            End If
                        Else
                            Exit For
                        End If
                    Next
                    For j = 1 To 19
                        If PB(x - j).Tag = "g" Or PB(x - j).Tag = "m" Then
                            If PB(x - j).Tag = "m" Then
                                iEyeAdd = -1
                                bEyeFire = True
                                iEyeLoc = x - 1
                            End If
                        Else
                            Exit For
                        End If
                    Next
                    For j = x + 20 To 400 Step 20
                        If PB(j).Tag = "g" Or PB(j).Tag = "m" Then
                            If PB(j).Tag = "m" Then
                                iEyeAdd = 20
                                bEyeFire = True
                                iEyeLoc = x + 20
                            End If
                        Else
                            Exit For
                        End If
                    Next
                    For j = 20 To 400 Step 20
                        If PB(x - j).Tag = "g" Or PB(x - j).Tag = "m" Then
                            If PB(x - j).Tag = "m" Then
                                iEyeAdd = -20
                                bEyeFire = True
                                iEyeLoc = x - 20
                            End If
                        Else
                            Exit For
                        End If
                    Next

                End If
            End If
        Next
        If bEyeFire Then  'Evil eye fire timer
            TimFoe.Enabled = False
            TimFire.Enabled = True
        End If
    End Sub
    Private Sub ReadLevel()
        '
        ' Read one level
        '
        Dim i As Integer
        Dim j As Integer
        Dim sFileName As String
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim value As String = My.Application.Info.DirectoryPath & "\gamlevels\"
        ' Button1.Visible = False
        sFileName = value & ListBox1.Items(iLevel - 1).ToString
        srFileReader = System.IO.File.OpenText(sFileName)
        sInputLine = srFileReader.ReadLine()
        j = Len(sInputLine)
        iMapUD = 1
        For i = 2 To 402
            Label2.Text = i
            iMap(iMapUD) = Mid(sInputLine, i, 1)
            iMapUD = iMapUD + 1
        Next
        srFileReader.Close()
    End Sub

    Private Sub FrmGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        sKeyValue = e.KeyValue
        Moveme()
    End Sub
    Private Sub FrmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim kLR As Integer
        Dim kUD As Integer
        Dim m As Integer
        ' 
        ' Create PictureBoxArray
        '
        Me.ToolTip1.SetToolTip(Me.PBox, "Box")
        Me.ToolTip1.SetToolTip(Me.PBlob, "Blob")
        Me.ToolTip1.SetToolTip(Me.PBomb, "Bomb")
        Me.ToolTip1.SetToolTip(Me.PChest, "Chest")
        Me.ToolTip1.SetToolTip(Me.PExit, "Exit")
        Me.ToolTip1.SetToolTip(Me.PEye, "Evil Eye")
        Me.ToolTip1.SetToolTip(Me.PEHeart, "Evil Heart")
        Me.ToolTip1.SetToolTip(Me.PDown, "Gate")
        Me.ToolTip1.SetToolTip(Me.PFire, "Fire")
        Me.ToolTip1.SetToolTip(Me.PFoe, "Foe")
        Me.ToolTip1.SetToolTip(Me.PGhost, "Ghost")
        Me.ToolTip1.SetToolTip(Me.PGrass, "Grass")
        Me.ToolTip1.SetToolTip(Me.PHeart, "Heart")
        Me.ToolTip1.SetToolTip(Me.Phole, "Hole")
        Me.ToolTip1.SetToolTip(Me.PKnight, "Knight")
        Me.ToolTip1.SetToolTip(Me.Pman, "Man")
        Me.ToolTip1.SetToolTip(Me.PRock, "Rock")
        Me.ToolTip1.SetToolTip(Me.Pwall, "Wall")
        Me.ToolTip1.SetToolTip(Me.PWater, "Water")
        Me.ToolTip1.SetToolTip(Me.pBomb2, "Bomb")
        Me.ToolTip1.SetToolTip(Me.pheart2, "Heart")
        Me.ToolTip1.SetToolTip(Me.PApple2, "Apple")
        Randomize()
        sManDir = "L"
        iLevel = 1
        bNewLevel = True
        For kUD = 1 To 20
            For kLR = 1 To 20
                m = kLR + kUD * 20 - 20
                PB(m) = New System.Windows.Forms.PictureBox()
                With PB(m)
                    .Name = m
                    .Location = New System.Drawing.Point(25 * kLR - 10, 25 * kUD + 5)
                    .Size = New Size(25, 25)
                End With

                '  This is the line that sometimes catches people out!
                Me.Controls.Add(PB(m))
                ' AddHandler PB(m).Click, AddressOf pb_Click
            Next
        Next
        GetFiles()
        ReadLevel()
        DrawMap()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DrawMap()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        sKeyValue = e.KeyValue
        Moveme()
    End Sub

    Private Sub TimFire_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimFire.Tick
        If bEyeFire Then
            If PB(iEyeLoc).Tag = "g" Then
                PB(iEyeLoc).Image = PEyeShoot.Image
                iEyeLoc = iEyeLoc + iEyeAdd
            Else
                TimFoe.Enabled = False
                TimFire.Enabled = False
                TimShoot.Enabled = False
                MsgBox("Oh no - You got hit!", MsgBoxStyle.OkOnly, "Hit")
                ReadLevel()
                DrawMap()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TimFoe_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimFoe.Tick
        Dim j As Integer
        Dim x As Integer
        '
        '   All Foes that move
        '
        For Each cFoe In colFoe
            Select Case cFoe.FoeTagNow
                Case "L"                    'Move Knight
                    x = cFoe.FoeLoc
                    For j = x + 1 To x + 19
                        If PB(j).Tag = "g" Then
                        ElseIf PB(j).Tag = "m" Then
                            cFoe.FoeiAdd = cFoe.FoeiAdd + 1
                            If cFoe.FoeiAdd = 3 Then
                                PB(cFoe.FoeLoc).Image = PGrass.Image
                                PB(cFoe.FoeLoc).Tag = PGrass.Tag
                                cFoe.FoeLoc = cFoe.FoeLoc + 1
                                If PB(cFoe.FoeLoc).Tag = "m" Then
                                    TimFoe.Enabled = False
                                    TimFire.Enabled = False
                                    TimShoot.Enabled = False
                                    MsgBox("Oh no - You were hit by a Knight!", MsgBoxStyle.OkOnly, cFoe.FoeMsg)
                                    ReadLevel()
                                    DrawMap()
                                    Exit Sub
                                End If
                                PB(cFoe.FoeLoc).Image = cFoe.FoePic
                                PB(cFoe.FoeLoc).Tag = cFoe.FoeTagNow
                                cFoe.FoeiAdd = 1
                            End If
                        Else

                            Exit For
                        End If
                    Next
                Case "D"                    'Quick Flash gate
                    If cFoe.FoeiAdd = 3 Then
                        If PB(cFoe.FoeLoc).Tag = "D" Then
                            PB(cFoe.FoeLoc).Image = PGrass.Image
                            PB(cFoe.FoeLoc).Tag = PGrass.Tag
                            cFoe.FoeiAdd = 1
                        Else
                            PB(cFoe.FoeLoc).Image = cFoe.FoePic
                            If PB(cFoe.FoeLoc).Tag = "m" Then
                                TimFoe.Enabled = False
                                TimFire.Enabled = False
                                TimShoot.Enabled = False
                                MsgBox("Oh no - You were hit by a Gate!", MsgBoxStyle.OkOnly, cFoe.FoeMsg)
                                ReadLevel()
                                DrawMap()
                                Exit Sub
                            End If
                            PB(cFoe.FoeLoc).Tag = cFoe.FoeTagNow
                            cFoe.FoeiAdd = 1
                        End If
                    Else
                        cFoe.FoeiAdd = cFoe.FoeiAdd + 1
                    End If
                Case "2"                    'Slow Flash gate
                    If cFoe.FoeiAdd = 5 Then
                        If PB(cFoe.FoeLoc).Tag = "2" Then
                            PB(cFoe.FoeLoc).Image = PGrass.Image
                            PB(cFoe.FoeLoc).Tag = PGrass.Tag
                            cFoe.FoeiAdd = 1
                        Else
                            PB(cFoe.FoeLoc).Image = cFoe.FoePic
                            If PB(cFoe.FoeLoc).Tag = "m" Then
                                TimFoe.Enabled = False
                                TimFire.Enabled = False
                                TimShoot.Enabled = False
                                MsgBox("Oh no - You were hit by a Gate!", MsgBoxStyle.OkOnly, cFoe.FoeMsg)
                                ReadLevel()
                                DrawMap()
                                Exit Sub
                            End If
                            PB(cFoe.FoeLoc).Tag = cFoe.FoeTagNow
                            cFoe.FoeiAdd = 1
                        End If
                    Else
                        cFoe.FoeiAdd = cFoe.FoeiAdd + 1
                    End If
                Case "B", "F", "G", "M", "U"            'Blob,Fire,Ghost,EHAcross,EHUp
                    j = cFoe.FoeLoc + cFoe.FoeiAdd
                    If PB(j).Tag = "g" Or PB(j).Tag = "m" Then
                        If PB(j).Tag = "m" Then
                            TimFoe.Enabled = False
                            TimFire.Enabled = False
                            TimShoot.Enabled = False
                            MsgBox("Oh no - You hit THE " & cFoe.FoeMsg & "!", MsgBoxStyle.OkOnly, cFoe.FoeMsg)
                            ReadLevel()
                            DrawMap()
                            Exit Sub
                        Else
                            PB(cFoe.FoeLoc).Image = PGrass.Image
                            PB(cFoe.FoeLoc).Tag = PGrass.Tag
                            cFoe.FoeLoc = j
                            PB(cFoe.FoeLoc).Image = cFoe.FoePic
                            PB(cFoe.FoeLoc).Tag = cFoe.FoeTagNow
                        End If
                    Else
                        If cFoe.FoeTagNow = "F" Then
                            PB(cFoe.FoeLoc).Image = PGrass.Image
                            PB(cFoe.FoeLoc).Tag = PGrass.Tag
                            cFoe.FoeLoc = cFoe.FoeiStart
                        Else
                            cFoe.FoeiAdd = cFoe.FoeiAdd * -1
                        End If
                    End If
                    If cFoe.FoeTagNow = "M" Or cFoe.FoeTagNow = "U" Then   'Evil Heart Shoots
                        x = cFoe.FoeLoc
                        bEyeFire2 = False
                        For j = x + 1 To x + 19
                            If PB(j).Tag = "g" Or PB(j).Tag = "m" Then
                                If PB(j).Tag = "m" Then
                                    iEyeAdd2 = 1
                                    bEyeFire2 = True
                                    iEyeLoc2 = x + 1
                                End If
                            Else
                                Exit For
                            End If
                        Next
                        For j = 1 To 19
                            If PB(x - j).Tag = "g" Or PB(x - j).Tag = "m" Then
                                If PB(x - j).Tag = "m" Then
                                    iEyeAdd2 = -1
                                    bEyeFire2 = True
                                    iEyeLoc2 = x - 1
                                End If
                            Else
                                Exit For
                            End If
                        Next
                        For j = x + 20 To 400 Step 20
                            If PB(j).Tag = "g" Or PB(j).Tag = "m" Then
                                If PB(j).Tag = "m" Then
                                    iEyeAdd2 = 20
                                    iEyeLoc2 = x + 20
                                    bEyeFire2 = True
                                End If
                            Else
                                Exit For
                            End If
                        Next
                        For j = 20 To 400 Step 20
                            If PB(x - j).Tag = "g" Or PB(x - j).Tag = "m" Then
                                If PB(x - j).Tag = "m" Then
                                    iEyeAdd2 = -20
                                    bEyeFire2 = True
                                    iEyeLoc2 = x - 20
                                End If
                            Else
                                Exit For
                            End If
                        Next
                        If bEyeFire2 And TimFire.Enabled = False Then
                            iEyeAdd = iEyeAdd2
                            iEyeLoc = iEyeLoc2
                            bEyeFire = True
                            TimFoe.Enabled = False
                            TimFire.Enabled = True
                            Exit Sub
                        End If
                    End If
                Case "Z"                                    ' Melt Foe
                    Label9.Text = cFoe.FoeiMelt
                    cFoe.FoeiMelt = cFoe.FoeiMelt - 1
                    If cFoe.FoeiMelt <= 0 Then
                        cFoe.FoeTagNow = cFoe.FoeTag
                        PB(cFoe.FoeLoc).Image = cFoe.FoePic
                        PB(cFoe.FoeLoc).Tag = cFoe.FoeTagNow
                    End If

            End Select
        Next
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        TimFoe.Enabled = False
        TimFire.Enabled = False
        TimShoot.Enabled = False
        Me.Hide()
        FrmEdit.Show()
    End Sub

    Private Sub TimShoot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimShoot.Tick
        Dim j As Integer
        j = iIceLoc
        If j > 21 And j < 380 Then
            Label2.Text = PB(j).Tag
            If PB(j).Tag = "g" Then
                If iFold <> 0 Then PB(iFold).Image = PGrass.Image
                PB(j).Image = Pice.Image
            Else
                Select Case PB(j).Tag
                    Case "B", "F", "K", "G", "L", "M", "U"    'Freeze Enemy
                        For Each cFoe In colFoe
                            If cFoe.FoeLoc = j Then
                                cFoe.FoeTagNow = "Z"
                                cFoe.FoeiMelt = 15
                                PB(j).Image = PIceBlock.Image
                                PB(j).Tag = "Z"
                            End If
                        Next
                    Case "Z"
                        For Each cFoe In colFoe           'Eliminate Enemy
                            If cFoe.FoeLoc = j Then
                                cFoe.FoeTagNow = "?"
                                PB(j).Image = PGrass.Image
                                PB(j).Tag = PGrass.Tag
                            End If
                        Next
                End Select
                If iFold <> 0 Then PB(iFold).Image = PGrass.Image
                TimShoot.Enabled = False
                Exit Sub
            End If
            iFold = j
            iIceLoc = iIceLoc + iFadd
        Else
            If iFold <> 0 Then PB(iFold).Image = PGrass.Image
            TimShoot.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub FrmGame_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
