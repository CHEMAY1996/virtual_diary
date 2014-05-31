Public Class FormSplash

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btntimetable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntimetable.Click
        Me.Hide()
        Timetable.Show()
    End Sub

    Private Sub btnalarms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalarms.Click
        Me.Hide()
        Alarms.Show()
    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        Me.Hide()
        Calender.Show()
    End Sub

    Private Sub btnhomework_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhomework.Click
        Me.Hide()
        homeworkhome.Show()
    End Sub
End Class
