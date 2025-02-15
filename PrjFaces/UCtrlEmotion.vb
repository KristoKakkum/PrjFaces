Public Class UCtrlEmotion
    Private Sub selectMod(ByVal intMood As Integer)
        pbEmotion.Image = imgLoend.Images(intMood)
    End Sub

    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "confused"
                Me.SelectMood(0)
            Case "cool"
                Me.SelectMood(1)
            Case "smile"
                Me.SelectMood(2)
            Case "star"
                Me.SelectMood(3)
            Case "teeth"
                Me.SelectMood(4)
            Case "yell"
                Me.SelectMood(5)
            Case Else
                Me.SelectMood(0)

        End Select
    End Sub

End Class
