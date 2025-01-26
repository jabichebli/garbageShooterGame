Public Class Form1
    '*******************************************
    '  This program is a Garbage Shooter game. *
    '       Created By Jason Abi Chebli        *
    '              On 17/07/2017               *
    '*******************************************

    Dim MoveLeft As Boolean = False  ' stores MoveLeft As Boolean = False in memory
    Dim MoveRight As Boolean = False ' stores MoveRight As Boolean = False in memory

    Private Sub mnuStart_Click(sender As Object, e As EventArgs) Handles mnuStart.Click
        tmrGame.Enabled = True
        lblScore.Text = "0"
        picGarbage1.Top = 0
        picGarbage2.Top = 0
        picGarbage3.Top = 0
        picGarbage4.Top = 0

    End Sub
    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        End
    End Sub
    Private Function Collide(ByVal ObjA As Object, ByVal ObjB As Object) As Boolean
        If ObjA.bounds.intersectswith(ObjB.bounds) Then ' tests if ObjA intersect with objB
            Collide = True
        Else
            Collide = False
        End If

    End Function

    Private Sub frmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then ' tests if keys.left is let go
            MoveLeft = True
            picShip.Left = picShip.Left - 15

        End If
        If e.KeyCode = Keys.Right Then ' tests if keys.right is let go
            picShip.Left = picShip.Left + 15

        End If
        If e.KeyCode = Keys.Space Then ' tests if keys.space is pressed down
            Select Case picLazer1.Enabled
                Case = False
                    picLazer1.Top = picShip.Top - 20
                    picLazer1.Left = picShip.Left + 25
                    picLazer1.Visible = True
                    picLazer1.Enabled = True
            End Select
            Select Case picLazer2.Enabled
                Case = False
                    picLazer2.Top = picShip.Top - 20
                    picLazer2.Left = picShip.Left + 25
                    picLazer2.Visible = True
                    picLazer2.Enabled = True
            End Select


        End If
        If picLazer1.Top <= 90 Then
            tmrGame.Enabled = False
            picLazer1.Top = picShip.Top - 20
            picLazer1.Left = picShip.Left + 25
            picLazer1.Enabled = False
            picLazer1.Visible = False
            tmrGame.Enabled = True
        End If
        If picLazer2.Top <= 90 Then
            tmrGame.Enabled = False
            picLazer2.Top = picShip.Top - 20
            picLazer2.Left = picShip.Left + 25
            picLazer2.Enabled = False
            picLazer2.Visible = False
            tmrGame.Enabled = True
        End If

    End Sub
    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then ' tests if keys.left is let go
            MoveLeft = True
            picShip.Left = picShip.Left - 15

        End If
        If e.KeyCode = Keys.Right Then ' tests if keys.right is let go
            picShip.Left = picShip.Left + 15

        End If
        If e.KeyCode = Keys.Space Then ' tests if keys.space is pressed down
            Select Case picLazer1.Enabled
                Case = False
                    picLazer1.Top = picShip.Top - 20
                    picLazer1.Left = picShip.Left + 25
                    picLazer1.Visible = True
                    picLazer1.Enabled = True
            End Select
            Select Case picLazer2.Enabled
                Case = False
                    picLazer2.Top = picShip.Top - 20
                    picLazer2.Left = picShip.Left + 25
                    picLazer2.Visible = True
                    picLazer2.Enabled = True
            End Select
        End If
        If picLazer1.Top <= 90 Then
            tmrGame.Enabled = False
            picLazer1.Top = picShip.Top - 20
            picLazer1.Left = picShip.Left + 25
            picLazer1.Enabled = False
            picLazer1.Visible = False
            tmrGame.Enabled = True
        End If
        If picLazer2.Top <= 90 Then
            tmrGame.Enabled = False
            picLazer2.Top = picShip.Top - 20
            picLazer2.Left = picShip.Left + 25
            picLazer2.Enabled = False
            picLazer2.Visible = False
            tmrGame.Enabled = True
        End If
    End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        picGarbage1.Top = picGarbage1.Top + 25
        picGarbage2.Top = picGarbage2.Top + 27
        picGarbage3.Top = picGarbage3.Top + 23
        picGarbage4.Top = picGarbage4.Top + 21



        If picLazer1.Visible = True Then 'tests if picLazer1 is visible
            picLazer1.Top = picLazer1.Top - 30
        End If
        If picLazer2.Visible = True Then 'tests if picLazer2 is visible
            picLazer2.Top = picLazer2.Top - 30
        End If


        If picGarbage1.Top + picGarbage1.Height > pnlGameArea.Height Then ' tests if picGarbage1.Top + picGarbage1.Height > pnlGameArea.Height
            picGarbage1.Top = 0
            picGarbage1.Left = Rnd() * (pnlGameArea.Width)
        End If

        If picGarbage2.Top + picGarbage2.Height > pnlGameArea.Height Then ' tests if picGarbage2.Top + picGarbage2.Height > pnlGameArea.Height
            picGarbage2.Top = 0
            picGarbage2.Left = Rnd() * (pnlGameArea.Width)
        End If

        If picGarbage3.Top + picGarbage3.Height > pnlGameArea.Height Then ' tests if picGarbage3Top + picGarbage3.Height > pnlGameArea.Height
            picGarbage3.Top = 0
            picGarbage3.Left = Rnd() * (pnlGameArea.Width)
        End If

        If picGarbage4.Top + picGarbage4.Height > pnlGameArea.Height Then ' tests if picGarbage4.Top + picGarbage4.Height > pnlGameArea.Height
            picGarbage4.Top = 0
            picGarbage4.Left = Rnd() * (pnlGameArea.Width)
        End If

        If Collide(picGarbage1, picShip) Then 'tests if there is a collision with picGarbage1 and picShip
            tmrGame.Enabled = False
            MsgBox("You got hit! Game Over! Your score was " & lblScore.Text & "!")
        End If
        If Collide(picGarbage2, picShip) Then 'tests if there is a collision with picGarbage2 and picShip
            tmrGame.Enabled = False
            MsgBox("You got hit! Game Over! Your score was " & lblScore.Text & "!")
        End If
        If Collide(picGarbage3, picShip) Then 'tests if there is a collision with picGarbage3 and picShip
            tmrGame.Enabled = False
            MsgBox("You got hit! Game Over! Your score was " & lblScore.Text & "!")
        End If
        If Collide(picGarbage4, picShip) Then 'tests if there is a collision with picGarbage4 and picShip
            tmrGame.Enabled = False
            MsgBox("You got hit! Game Over! Your score was " & lblScore.Text & "!")
        End If


        If Collide(picGarbage1, picLazer1) Then 'tests if there is a collision with picGarbage1 and picLazer1
            picGarbage1.Top = 0
            picGarbage1.Left = Rnd() * (pnlGameArea.Width)
            picLazer1.Top = picShip.Top - 20
            picLazer1.Left = picShip.Left + 25
            lblScore.Text = Val(lblScore.Text) + 5
            picLazer1.Visible = False
            picLazer1.Enabled = False
        End If
        If Collide(picGarbage2, picLazer1) Then 'tests if there is a collision with picGarbage2 and picLazer1
            picGarbage2.Top = 0
            picGarbage2.Left = Rnd() * (pnlGameArea.Width)

            lblScore.Text = Val(lblScore.Text) + 5
            picLazer1.Visible = False
            picLazer1.Enabled = False
        End If
        If Collide(picGarbage3, picLazer1) Then 'tests if there is a collision with picGarbage3 and picLazer1
            picGarbage3.Top = 0
            picGarbage3.Left = Rnd() * (pnlGameArea.Width)
            lblScore.Text = Val(lblScore.Text) + 5
            picLazer1.Visible = False
            picLazer1.Enabled = False
        End If
        If Collide(picGarbage4, picLazer1) Then 'tests if there is a collision with picGarbage4 and picLazer1
            picGarbage4.Top = 0
            picGarbage4.Left = Rnd() * (pnlGameArea.Width)

            lblScore.Text = Val(lblScore.Text) + 5
            picLazer1.Visible = False
            picLazer1.Enabled = False
        End If

        If Collide(picGarbage1, picLazer2) Then 'tests if there is a collision with picGarbage1 and picLazer2
            picGarbage1.Top = 0
            picGarbage1.Left = Rnd() * (pnlGameArea.Width)

            lblScore.Text = Val(lblScore.Text) + 5
            picLazer2.Visible = False
            picLazer2.Enabled = False
        End If
        If Collide(picGarbage2, picLazer2) Then 'tests if there is a collision with picGarbage2 and picLazer2
            picGarbage2.Top = 0
            picGarbage2.Left = Rnd() * (pnlGameArea.Width)

            lblScore.Text = Val(lblScore.Text) + 5
            picLazer2.Visible = False
            picLazer2.Enabled = False
        End If
        If Collide(picGarbage3, picLazer2) Then 'tests if there is a collision with picGarbage3 and picLazer2
            picGarbage3.Top = 0
            picGarbage3.Left = Rnd() * (pnlGameArea.Width)

            lblScore.Text = Val(lblScore.Text) + 5
            picLazer2.Visible = False
            picLazer2.Enabled = False
        End If
        If Collide(picGarbage4, picLazer2) Then 'tests if there is a collision with picGarbage4 and picLazer2
            picGarbage4.Top = 0
            picGarbage4.Left = Rnd() * (pnlGameArea.Width)
            lblScore.Text = Val(lblScore.Text) + 5
            picLazer2.Visible = False
            picLazer2.Enabled = False
        End If
    End Sub

End Class
