Public Class Form

    'Event que sactiva quan es selecciona
    'una opció dins del treeview, aquesta
    'es compara per saber quina opcio
    'es seleccionada i executa el métode
    'necessari per mostrar les opcions
    'pertinents.
    Private Function TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView.AfterSelect

        If IsNodeSelected("AreaLong_1") Then Return FormArea1.ShowDialog()
        If IsNodeSelected("AreaLong_2") Then Return FormArea2.ShowDialog()
        If IsNodeSelected("AreaLong_3") Then Return FormArea3.ShowDialog()
        If IsNodeSelected("AreaLong_4") Then Return FormArea4.ShowDialog()

        If IsNodeSelected("Arit_1") Then Return FormArit1.ShowDialog()
        If IsNodeSelected("Arit_2") Then Return FormArit2.ShowDialog()
        If IsNodeSelected("Arit_3") Then Return FormArit3.ShowDialog()
        If IsNodeSelected("Arit_4") Then Return FormArit4.ShowDialog()

        If IsNodeSelected("Cad_1") Then Return FormCad1.ShowDialog()
        If IsNodeSelected("Cad_2") Then Return FormCad2.ShowDialog()
        If IsNodeSelected("Cad_3") Then Return FormCad3.ShowDialog()

        If IsNodeSelected("Alt_1") Then Return FormAlt1.ShowDialog()
        If IsNodeSelected("Alt_2") Then Return FormAlt2.ShowDialog()
        If IsNodeSelected("Alt_3") Then Return FormAlt3.ShowDialog()

        Return False
    End Function

    'Retorna i determina si
    'el nom actual pasat com
    'a parametre es el seleccionat
    'en el treeview general
    Private Function IsNodeSelected(name As String)
        Return TreeView.Nodes.Find(name, True).First().IsSelected
    End Function

End Class
