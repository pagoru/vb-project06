Public Class FormBasePrimari
    Private operationTimes As Integer = 0

    Private Sub TimerCurrentTime_Tick(sender As Object, e As EventArgs) Handles TimerCurrentTime.Tick
        LabelCurrentTime.Text = Now.ToLongTimeString()
    End Sub

    Private Sub BasePrimari_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("L'operació s'ha executat " + CStr(operationTimes) + " vegades!", "Informació",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Protected Overridable Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        operationTimes += 1
    End Sub

#Region "Calculs"

#End Region
End Class