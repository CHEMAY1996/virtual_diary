Public Class Calender

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        FormSplash.Show()
    End Sub

    Private Sub btnEnter_new_event_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter_new_event.Click
        Me.Hide()
        Enter_new_event.Show()
    End Sub
End Class