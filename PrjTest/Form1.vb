Public Class Form1
    Private Sub btnConfused_Click(sender As Object, e As EventArgs) _
        Handles btnConfused.Click
        UCtrlEmotion1.setMood("confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) _
        Handles btnCool.Click
        UCtrlEmotion1.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) _
        Handles btnSmile.Click
        UCtrlEmotion1.setMood("smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) _
        Handles btnStar.Click
        UCtrlEmotion1.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) _
        Handles btnTeeth.Click
        UCtrlEmotion1.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) _
        Handles btnYell.Click
        UCtrlEmotion1.setMood("yell")
    End Sub

    Private Sub btnPuhasta_Click(sender As Object, e As EventArgs) Handles btnPuhasta.Click
        UCtrlEmotion1.ClearEmotion()
    End Sub

    ' Formi laadimise ajal määrame algolekud
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        USwitch1.setSwitch(False) ' Lüliti algselt väljas
        UBulb1.setLight("off")    ' Pirn algselt ei põle

        ' Sidume lüliti sündmuse pirni olekuga
        AddHandler USwitch1.SwitchStateChanged, AddressOf SwitchStateChanged
    End Sub

    ' Lüliti olek muutub - uuendame pirni olekut
    Private Sub SwitchStateChanged(ByVal newState As Boolean)
        If newState Then
            UBulb1.setLight("on") ' Kui lüliti on sees, pirn põleb
        Else
            UBulb1.setLight("off") ' Kui lüliti on väljas, pirn ei põle
        End If
    End Sub

End Class