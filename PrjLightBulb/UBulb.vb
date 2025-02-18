Public Class UBulb
    ' Lüliti oleku hoidmine
    Private Sub selectLight(ByVal intLight As Integer)
        pbLight.Image = imgLoend.Images(intLight)
    End Sub

    Public Sub setLight(ByVal strLight As String)
        Select Case strLight
            Case "off"
                Me.selectLight(0)
            Case "on"
                Me.selectLight(1)
            Case Else
                Me.selectLight(0)
        End Select
    End Sub

End Class