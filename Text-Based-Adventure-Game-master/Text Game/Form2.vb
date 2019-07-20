Public Class Form2
    Dim count As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If forest = True Then
            pctHereUp.Left = pctForest.Left - (pctHereUp.Width - pctForest.Width) / 2
            pctHereUp.Top = pctForest.Top + (pctForest.Height + (pctHereUp.Height / 2))
        End If

        If river = True Then
            pctHereUp.Left = pctRiver.Left - (pctHereUp.Width - pctRiver.Width) / 2
            pctHereUp.Top = pctRiver.Top + (pctRiver.Height + (pctHereUp.Height / 2))
        End If

        If helicopter = True Then
            pctHereUp.Left = pctHeli.Left - (pctHereUp.Width - pctHeli.Width) / 2
            pctHereUp.Top = pctHeli.Top + (pctHeli.Height + (pctHereUp.Height / 2))
        End If

        If waterfall = True Then
            pctHereRight.Left = pctWaterfall.Left - pctHereRight.Width - 15
            pctHereRight.Top = pctWaterfall.Top + (pctWaterfall.Height / 4)
        End If

        If house = True Then
            pctHereRight.Left = pctHouse.Left - pctHereRight.Width - 15
            pctHereRight.Top = pctHouse.Top + (pctHouse.Height / 4)
        End If

        If helicopter = True Or forest = True Or river = True Then
            pctHereRight.Visible = False
            pctHereUp.Visible = True
            Label1.Visible = False
        End If

        If house = True Or waterfall = True Then
            pctHereRight.Visible = True
            pctHereUp.Visible = False
            Label1.Visible = False
        End If

        If house = True Then
            pctHouse.Visible = False
        End If
        If helicopter = True Then
            pctHeli.Visible = False
        End If
        If river = True Then
            pctRiver.Visible = False
        End If
        If waterfall = True Then
            pctWaterfall.Visible = False
        End If

        If waterfall = False Then
            If house = False Then
                If bHouse = False Then
                    If forest = False Then
                        If helicopter = False Then
                            If river = False Then
                                Label1.Visible = True
                                pctHereRight.Visible = False
                                pctHereUp.Visible = False
                            End If
                        End If
                    End If
                End If
            End If
        End If


    End Sub
End Class