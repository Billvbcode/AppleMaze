Public Class FrmEdit
    Private Sub GetFiles()
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
    Private Sub FrmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim kLR As Integer
        Dim kUD As Integer
        Dim m As Integer
        Me.ToolTip1.SetToolTip(Me.PBox, "Box")
        Me.ToolTip1.SetToolTip(Me.PBlob, "Blob")
        Me.ToolTip1.SetToolTip(Me.PBomb, "Bomb")
        Me.ToolTip1.SetToolTip(Me.PChest, "Chest")
        Me.ToolTip1.SetToolTip(Me.PExit, "Exit")
        Me.ToolTip1.SetToolTip(Me.PEye, "Evil Eye")
        Me.ToolTip1.SetToolTip(Me.PEHeart, "Evil Heart")
        Me.ToolTip1.SetToolTip(Me.PEHeart2, "Evil Heart")
        Me.ToolTip1.SetToolTip(Me.PDown, "Gate")
        Me.ToolTip1.SetToolTip(Me.PDown2, "Gate2")
        Me.ToolTip1.SetToolTip(Me.PFire, "Fire")
        Me.ToolTip1.SetToolTip(Me.PFoe, "Foe")
        Me.ToolTip1.SetToolTip(Me.PGhost, "Ghost")
        Me.ToolTip1.SetToolTip(Me.PGrass, "Grass")
        Me.ToolTip1.SetToolTip(Me.PHeart1, "Heart1")
        Me.ToolTip1.SetToolTip(Me.PHeart2, "Heart2")
        Me.ToolTip1.SetToolTip(Me.Phole, "Hole")
        Me.ToolTip1.SetToolTip(Me.PKnight, "Knight")
        Me.ToolTip1.SetToolTip(Me.Pman, "Man")
        Me.ToolTip1.SetToolTip(Me.PRock, "Rock")
        Me.ToolTip1.SetToolTip(Me.Pwall, "Wall")
        Me.ToolTip1.SetToolTip(Me.PWater, "Water")
        ' 
        ' Create PictureBoxArray
        '
        Randomize()
        bNewLevel = True
        For kUD = 1 To 20
            For kLR = 1 To 20
                m = kLR + kUD * 20 - 20
                PBE(m) = New System.Windows.Forms.PictureBox()
                With PBE(m)
                    .Name = m
                    .Location = New System.Drawing.Point(25 * kLR - 10, 25 * kUD + 5)
                    .Size = New Size(25, 25)
                End With

                '  This is the line that sometimes catches people out!
                Me.Controls.Add(PBE(m))
                AddHandler PBE(m).Click, AddressOf pbe_Click
            Next
        Next
        GetFiles()
    End Sub
    Private Sub pbe_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim cmsg As PictureBox
        cmsg = sender
        Dim i As Integer
         i = Val(cmsg.Name)
        PBE(i).Tag = PicAll.Tag
        iMapE(i) = PicAll.Tag
        PBE(i).Image = PicAll.Image
        '  MessageBox.Show("btn_Click method " & cmsg.Name, "Events Demonstration ")
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub PicAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicAll.Click

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim i As Integer
        Dim j As Integer
        '
        ' Read File
        '
        Dim sFileName As String
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim value As String = My.Application.Info.DirectoryPath & "\gamlevels\"
        sFileName = value & ListBox1.Text.ToString
        Txtname.Text = ListBox1.Text.ToString
        srFileReader = System.IO.File.OpenText(sFileName)
        sInputLine = srFileReader.ReadLine()
        j = Len(sInputLine)
        iMapUD = 1
        For i = 2 To 402
             iMapE(iMapUD) = Mid(sInputLine, i, 1)
            iMapUD = iMapUD + 1
        Next
        srFileReader.Close()
        '
        'Draw Map
        '
        For i = 1 To 400
            Select Case iMapE(i)
                Case "a"
                    PBE(i).Image = PBox.Image
                    PBE(i).Tag = PBox.Tag
                Case "b"
                    PBE(i).Image = PBomb.Image
                    PBE(i).Tag = PBomb.Tag
                Case "B"
                    PBE(i).Image = PBlob.Image
                    PBE(i).Tag = PBlob.Tag
                Case "c"
                    PBE(i).Image = PChest.Image
                    PBE(i).Tag = PChest.Tag
                Case "D"
                    PBE(i).Image = PDown.Image
                    PBE(i).Tag = iMapE(i)
                Case "2"
                    PBE(i).Image = PDown2.Image
                    PBE(i).Tag = iMapE(i)
                Case "e"
                    PBE(i).Image = PExit.Image
                    PBE(i).Tag = PExit.Tag
                Case "E"
                    PBE(i).Image = PEye.Image
                    PBE(i).Tag = PEye.Tag
                Case "f"
                    PBE(i).Image = PApple.Image
                    PBE(i).Tag = PApple.Tag
                Case "F"
                    PBE(i).Image = PFire.Image
                    PBE(i).Tag = PFire.Tag
                Case "g"
                    PBE(i).Image = PGrass.Image
                    PBE(i).Tag = PGrass.Tag
                Case "G"
                    PBE(i).Image = PGhost.Image
                    PBE(i).Tag = PGhost.Tag
                Case "h"
                    PBE(i).Image = Phole.Image
                    PBE(i).Tag = Phole.Tag
                Case "I"
                    PBE(i).Image = PHeart1.Image
                    PBE(i).Tag = iMapE(i)
                Case "J"
                    PBE(i).Image = PHeart2.Image
                    PBE(i).Tag = iMapE(i)
                Case "K"
                    PBE(i).Image = PFoe.Image
                    PBE(i).Tag = iMapE(i)
                Case "L"
                    PBE(i).Image = PKnight.Image
                    PBE(i).Tag = PKnight.Tag
                Case "m"
                    PBE(i).Image = Pman.Image
                    PBE(i).Tag = Pman.Tag
                Case "M"
                    PBE(i).Image = PEHeart.Image
                    PBE(i).Tag = PEHeart.Tag
                Case "r"
                    PBE(i).Image = PRock.Image
                    PBE(i).Tag = PRock.Tag
                    PBE(i).Tag = PRock.Tag
                Case "U"
                    PBE(i).Image = PEHeart2.Image
                    PBE(i).Tag = PEHeart2.Tag
                Case "w"
                    PBE(i).Image = Pwall.Image
                    PBE(i).Tag = Pwall.Tag
                Case "x"
                    PBE(i).Image = PWater.Image
                    PBE(i).Tag = PWater.Tag
                Case Else
                    '  Label1.Text = iMapE(i)
            End Select
        Next

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub PFoe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PFoe.Click
        LblTag.Text = "Foe"
        PicAll.Image = PFoe.Image
        PicAll.Tag = PFoe.Tag
    End Sub

    Private Sub Pwall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pwall.Click
        LblTag.Text = "Wall"
        PicAll.Image = Pwall.Image
        PicAll.Tag = Pwall.Tag
    End Sub

    Private Sub PGrass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PGrass.Click
        LblTag.Text = "Grass"
        PicAll.Image = PGrass.Image
        PicAll.Tag = PGrass.Tag
    End Sub

    Private Sub Phole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Phole.Click
        LblTag.Text = "Hole"
        PicAll.Image = Phole.Image
        PicAll.Tag = Phole.Tag
    End Sub

    Private Sub PGhost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PGhost.Click
        LblTag.Text = "Grass"
        PicAll.Image = PGhost.Image
        PicAll.Tag = PGhost.Tag
    End Sub

    Private Sub Pman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pman.Click
        LblTag.Text = "Man"
        PicAll.Image = Pman.Image
        PicAll.Tag = Pman.Tag
    End Sub

    Private Sub PRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRock.Click
        LblTag.Text = "Rock"
        PicAll.Image = PRock.Image
        PicAll.Tag = PRock.Tag
    End Sub

    Private Sub PExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PExit.Click
        LblTag.Text = "Exit"
        PicAll.Image = PExit.Image
        PicAll.Tag = PExit.Tag
    End Sub

    Private Sub PWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PWater.Click
        LblTag.Text = "Water"
        PicAll.Image = PWater.Image
        PicAll.Tag = PWater.Tag
    End Sub

    Private Sub PChest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PChest.Click
        LblTag.Text = "Chest"
        PicAll.Image = PChest.Image
        PicAll.Tag = PChest.Tag
    End Sub

    Private Sub PBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBox.Click
        LblTag.Text = "Box"
        PicAll.Image = PBox.Image
        PicAll.Tag = PBox.Tag
    End Sub

    Private Sub PEye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEye.Click
        LblTag.Text = "Evil Eye"
        PicAll.Image = PEye.Image
        PicAll.Tag = PEye.Tag
    End Sub

    Private Sub PBomb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBomb.Click
        LblTag.Text = "Bomb"
        PicAll.Image = PBomb.Image
        PicAll.Tag = PBomb.Tag
    End Sub

    Private Sub PBlob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBlob.Click
        LblTag.Text = "Blob"
        PicAll.Image = PBlob.Image
        PicAll.Tag = PBlob.Tag
    End Sub

    Private Sub PFire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PFire.Click
        LblTag.Text = "Fire"
        PicAll.Image = PFire.Image
        PicAll.Tag = PFire.Tag
    End Sub

    Private Sub PEHeart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEHeart.Click
        LblTag.Text = "Evil Heart"
        PicAll.Image = PEHeart.Image
        PicAll.Tag = PEHeart.Tag
    End Sub

    Private Sub PEHeart2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEHeart2.Click
        LblTag.Text = "Evil Heart"
        PicAll.Image = PEHeart2.Image
        PicAll.Tag = PEHeart2.Tag
    End Sub

    Private Sub PKnight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PKnight.Click
        LblTag.Text = "Knight"
        PicAll.Image = PKnight.Image
        PicAll.Tag = PKnight.Tag
    End Sub

    Private Sub PApple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PApple.Click
        LblTag.Text = "Apple"
        PicAll.Image = PApple.Image
        PicAll.Tag = PApple.Tag
    End Sub

    Private Sub PDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDown.Click
        LblTag.Text = "Gate"
        PicAll.Image = PDown.Image
        PicAll.Tag = PDown.Tag
    End Sub

    Private Sub PDown2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDown2.Click
        LblTag.Text = "Gate 2"
        PicAll.Image = PDown2.Image
        PicAll.Tag = PDown2.Tag
    End Sub

    Private Sub PHeart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHeart1.Click
        LblTag.Text = "1 Ice"
        PicAll.Image = PHeart1.Image
        PicAll.Tag = PHeart1.Tag
    End Sub

    Private Sub PHeart2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHeart2.Click
        LblTag.Text = "2 Ice"
        PicAll.Image = PHeart2.Image
        PicAll.Tag = PHeart2.Tag
    End Sub


    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
        FrmGame.Show()
        FrmGame.GetFiles()
        Me.Hide()
    End Sub

    Private Sub BTNSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim sFileName As String
        If Txtname.Text = "" Then Exit Sub
        Dim value As String = My.Application.Info.DirectoryPath & "\gamlevels\"
        sFileName = value & Txtname.Text

        Dim srFileWrite As New System.IO.StreamWriter(sFileName)
        LblOut.Text = Chr(34)
        For i = 1 To 400
            LblOut.Text = LblOut.Text & iMapE(i)
        Next
        LblOut.Text = LblOut.Text & Chr(34)
        srFileWrite.WriteLine(LblOut.Text)
        srFileWrite.Close()
        LblSave.Text = Txtname.Text & "saved"
        GetFiles()
    End Sub
End Class