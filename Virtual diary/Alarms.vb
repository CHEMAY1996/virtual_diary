Public Class Alarms

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        FormSplash.Show()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.Hide()
        Enter_New_Alarms.Show()
    End Sub

    Private Sub btntimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntimer.Click
        Me.Hide()
        Enter_New_timer.Show()
    End Sub
End Class