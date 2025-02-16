Public Class USwitch
    ' Lüliti oleku hoidmine
    Private switchState As Boolean = False ' False = Väljas, True = Sees

    ' Meetod lüliti graafika uuendamiseks
    Private Sub updateSwitchImage()
        If switchState Then
            pbSwitch.Image = imgList.Images(1) ' "Sees" oleku pilt
        Else
            pbSwitch.Image = imgList.Images(0) ' "Väljas" oleku pilt
        End If
    End Sub

    ' Meetod lüliti oleku muutmiseks
    Public Sub setSwitch(ByVal isOn As Boolean)
        switchState = isOn
        updateSwitchImage()
    End Sub

    ' Meetod lüliti oleku saamiseks
    Public Function getSwitchState() As Boolean
        Return switchState
    End Function

    ' Klikk muudab lüliti olekut
    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click
        switchState = Not switchState ' Vahetame olekut
        updateSwitchImage()

        ' Kohe peale lüliti olekumuutust uuendame pirni olekut
        If switchState Then
            ' Kui lüliti on sees, siis pirn põleb
            RaiseEvent SwitchStateChanged(True)
        Else
            ' Kui lüliti on väljas, siis pirn ei põle
            RaiseEvent SwitchStateChanged(False)
        End If
    End Sub

    ' Uus sündmus, mis edastab lüliti oleku muutuse Form1-le
    Public Event SwitchStateChanged(ByVal newState As Boolean)
End Class
