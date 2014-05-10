Public Class Enter_New_Alarms

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Me.Hide()
        Alarms.Show()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        Alarms.Show()
    End Sub

    Private Sub txtalarm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtalarm.TextChanged

    End Sub
End Class