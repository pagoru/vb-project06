Public Class Form

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ClosePanel()
    End Sub

    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        ClearInputs()
    End Sub

    Private Function TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView.AfterSelect
        ClearPanel()
        Panel.Visible = True

        If IsNodeSelected("AreaLong_1") Then Return View_AreaLong1()

        Panel.Visible = False
        Return False
    End Function

    Private Function Result_Click(sender As Object, e As EventArgs) Handles Result.Click

        If IsNodeSelected("AreaLong_1") Then Return Result_AreaLong1()

        Return False
    End Function

    Private Function IsNodeSelected(Name As String)
        Return TreeView.Nodes.Find(Name, True).First().IsSelected
    End Function

    Private Sub ClearPanel()
        Text_Input1.Text = ""
        Text_Input2.Text = ""
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        Input1.Text = ""
        Input2.Text = ""
        ResultText.Text = ""
    End Sub

    Private Sub ClosePanel()
        TreeView.SelectedNode = TreeView.Nodes.Item(0)
        Panel.Visible = False
        ClearPanel()
    End Sub

    Private Sub NumericPanel()
        InitToolStripMenuItem.Enabled = True
        IncrementarEn1ToolStripMenuItem.Enabled = True
        DecrementarEn1ToolStripMenuItem.Enabled = True
    End Sub
    Private Sub NotNumericPanel()
        InitToolStripMenuItem.Enabled = False
        IncrementarEn1ToolStripMenuItem.Enabled = False
        DecrementarEn1ToolStripMenuItem.Enabled = False
    End Sub

    Private Function View_AreaLong1()
        Title.Text = "Àrea del triangle"
        Text_Input1.Text = "Base"
        Text_Input2.Text = "Alçada"
        NumericPanel()
        Return False
    End Function

    Private Function Result_AreaLong1()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) * Double.Parse(Input2.Text)) / 2
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function
    Private Function Result_AreaLong2()
        Try
            Dim res As Double = Math.PI * Math.Pow(Double.Parse(Input1.Text), 2)
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    Public activeTextBox As Integer
    'Copiar
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        If Text_Input1.IsDisposed Then
            Clipboard.SetText(Text_Input1.Text)
        ElseIf Text_Input2.IsDisposed Then
            Clipboard.SetText(Text_Input2.Text)
        End If
    End Sub

    'Tallar
    Private Sub TallarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TallarToolStripMenuItem.Click
        If activeTextBox = 1 Then
            Clipboard.SetText(Input1.Text)
            Input1.Text = ""
        ElseIf activeTextBox = 2 Then
            Clipboard.SetText(Input2.Text)
            Input2.Text = ""
        End If
    End Sub

    'Enganxar
    Private Sub EnganxarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnganxarToolStripMenuItem.Click
        Dim text As String = Clipboard.GetText()
        If text IsNot Nothing Then
            If activeTextBox = 1 Then
                Input1.Text = text
            ElseIf activeTextBox = 2 Then
                Input2.Text = text
            End If
        End If
    End Sub

    Private Sub Input1_Click(sender As Object, e As EventArgs) Handles Input1.Click
        activeTextBox = 1
    End Sub

    Private Sub Input2_Click(sender As Object, e As EventArgs) Handles Input2.Click
        activeTextBox = 2
    End Sub
End Class
