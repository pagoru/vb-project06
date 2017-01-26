Public Class Form

    'Event que sactiva quan es prem
    'el botó per tancar dins del panel
    'Aquest oculta el panel
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ClosePanel()
    End Sub

    'Event que sactiva quan es prem
    'el botó per eliminar dins del panel
    'Aquest nateja tots els inputs
    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        ClearInputs()
    End Sub

    'Event que sactiva quan es selecciona
    'una opció dins del treeview, aquesta
    'es compara per saber quina opcio
    'es seleccionada i executa el métode
    'necessari per mostrar les opcions
    'pertinents.
    Private Function TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView.AfterSelect
        ClearPanel()
        Panel.Visible = True

        If IsNodeSelected("AreaLong_1") Then Return View_AreaLong1()
        If IsNodeSelected("AreaLong_2") Then Return View_AreaLong2()
        If IsNodeSelected("AreaLong_3") Then Return View_AreaLong3()
        If IsNodeSelected("AreaLong_4") Then Return View_AreaLong4()

        If IsNodeSelected("Arit_1") Then Return View_Arit1()
        If IsNodeSelected("Arit_2") Then Return View_Arit2()
        If IsNodeSelected("Arit_3") Then Return View_Arit3()
        If IsNodeSelected("Arit_4") Then Return View_Arit4()

        If IsNodeSelected("Cad_1") Then Return View_Cad1()
        If IsNodeSelected("Cad_2") Then Return View_Cad2()
        If IsNodeSelected("Cad_3") Then Return View_Cad3()

        If IsNodeSelected("Alt_1") Then Return View_Alt1()
        If IsNodeSelected("Alt_2") Then Return View_Alt2()
        If IsNodeSelected("Alt_3") Then Return View_Alt3()

        Panel.Visible = False
        Return False
    End Function

    'Mostra en el panel la opcio
    'Alternativa 3
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Alt3()
        Title.Text = "La taula de múltiplicar d’un número del 1 al n número indicat."
        Text_Input1.Text = "Número enter"
        Input2.Visible = False
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Alternativa 2
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Alt2()
        Title.Text = "Fibornacci de n números: (7) 1 1 2 3 5 8 13"
        Text_Input1.Text = "Número enter"
        Input2.Visible = False
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Alternativa 1
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Alt1()
        Title.Text = "Transformar un numero enter, com màxim el 999.999.999, a lletres (castellà o català), per exemple 1567 -> ‘mil quinientos sesenta y siete’."
        Text_Input1.Text = "Número enter"
        Input2.Visible = False
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Cadena de Caracters 3
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Cad3()
        Title.Text = "Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en una frase."
        Text_Input1.Text = "Cadena de carácters"
        Text_Input2.Text = "Dos carácters a buscar"
        NotNumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Cadena de Caracters 2
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Cad2()
        Title.Text = "Donada una cadena mostrar el número de vocals i consonants que té la cadena."
        Text_Input1.Text = "Cadena de carácters"
        Input2.Visible = False
        NotNumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Cadena de Caracters 1
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Cad1()
        Title.Text = "Donada una cadena mostrar la seva invertida"
        Text_Input1.Text = "Cadena de carácters"
        Input2.Visible = False
        NotNumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Aritmetica 4
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Arit4()
        Title.Text = "Multiplicació de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Aritmetica 3
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Arit3()
        Title.Text = "Divisió de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Aritmetica 2
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Arit2()
        Title.Text = "Resta de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Aritmetica 1
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_Arit1()
        Title.Text = "Suma de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Areas i logituds 1
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_AreaLong1()
        Title.Text = "Àrea del triangle"
        Text_Input1.Text = "Base"
        Text_Input2.Text = "Alçada"
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Areas i logituds 2
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_AreaLong2()
        Title.Text = "Àrea de la rodona"
        Text_Input1.Text = "Radi"
        Input2.Visible = False
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Areas i logituds 3
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_AreaLong3()
        Title.Text = "Longitud de la Circumferència"
        Text_Input1.Text = "Radi"
        Input2.Visible = False
        NumericPanel()
        Return False
    End Function

    'Mostra en el panel la opcio
    'Areas i logituds 4
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Private Function View_AreaLong4()
        Title.Text = "Àrea Rectangle"
        Text_Input1.Text = "Base"
        Text_Input2.Text = "Alçada"
        NumericPanel()
        Return False
    End Function

    'Event que sactiva quan es
    'prem el botó de resultat, aquesta
    'es compara per saber quina opcio
    'es seleccionada i executa el métode
    'necessari per mostrar les opcions
    'pertinents.
    Private Function Result_Click(sender As Object, e As EventArgs) Handles Result.Click

        If IsNodeSelected("AreaLong_1") Then Return Result_AreaLong1()
        If IsNodeSelected("AreaLong_2") Then Return Result_AreaLong2()
        If IsNodeSelected("AreaLong_3") Then Return Result_AreaLong3()
        If IsNodeSelected("AreaLong_4") Then Return Result_AreaLong4()

        If IsNodeSelected("Arit_1") Then Return Result_Arit1()
        If IsNodeSelected("Arit_2") Then Return Result_Arit2()
        If IsNodeSelected("Arit_3") Then Return Result_Arit3()
        If IsNodeSelected("Arit_4") Then Return Result_Arit4()

        If IsNodeSelected("Cad_1") Then Return Result_Cad1()
        If IsNodeSelected("Cad_2") Then Return Result_Cad2()
        If IsNodeSelected("Cad_3") Then Return Result_Cad3()

        If IsNodeSelected("Alt_1") Then Return Result_Alt1()
        If IsNodeSelected("Alt_2") Then Return Result_Alt2()
        If IsNodeSelected("Alt_3") Then Return Result_Alt3()

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Altres 3
    Private Function Result_Alt3()
        Try
            'Fibonacci
            ResultText.Text = "El recompte es de "
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Altres 2
    Private Function Result_Alt2()
        Try
            'Fibonacci
            ResultText.Text = "El recompte es de "
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Altres 1
    Private Function Result_Alt1()
        Try
            'Fumada gorda max(999.999.999)
            ResultText.Text = "El recompte es de "
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Cadena de caracters 3
    Private Function Result_Cad3()
        Try
            Dim count As Integer = 0

            If Not (Input2.Text.Length = 2) Then
                Throw New Exception()
            End If

            For index As Integer = 0 To Input1.Text.Length - 2
                If Input1.Text.Substring(index, 2) = Input2.Text Then count += 1
            Next

            ResultText.Text = "El recompte es de " + CType(count, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Cadena de caracters 2
    Private Function Result_Cad2()
        Try
            Dim voc As Integer = 0
            Dim con As Integer = 0

            For Each c As Char In Input1.Text
                If LCase(c) <> UCase(c) Then
                    If c = "A" Or c = "E" Or c = "I" Or c = "O" Or c = "U" Or c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u" Then
                        voc += 1
                    Else
                        con += 1
                    End If
                End If
            Next

            ResultText.Text = "El resultat es de " + CType(voc, String) + " vocals y " + CType(con, String) + " consonants."
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Cadena de caracters 1
    Private Function Result_Cad1()
        Try
            ResultText.Text = "El resultat es " + StrReverse(Input1.Text)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 4
    Private Function Result_Arit4()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) * Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 3
    Private Function Result_Arit3()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) / Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 2
    Private Function Result_Arit2()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) - Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 1
    Private Function Result_Arit1()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) + Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de lArea i Longitud 1
    Private Function Result_AreaLong1()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) * Double.Parse(Input2.Text)) / 2
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de lArea i Longitud 2
    Private Function Result_AreaLong2()
        Try
            Dim res As Double = Math.PI * Math.Pow(Double.Parse(Input1.Text), 2)
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de lArea i Longitud 3
    Private Function Result_AreaLong3()
        Try
            Dim res As Double = 2 * Math.PI * Double.Parse(Input1.Text)
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de lArea i Longitud 4
    Private Function Result_AreaLong4()
        Try
            Dim res As Double = Double.Parse(Input1.Text) * Double.Parse(Input2.Text)
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
        End Try

        Return False
    End Function

    'Retorna i determina si
    'el nom actual pasat com
    'a parametre es el seleccionat
    'en el treeview general
    Private Function IsNodeSelected(name As String)
        Return TreeView.Nodes.Find(name, True).First().IsSelected
    End Function

    'Reseteja el panel actual
    'amb informació per defecte
    Private Sub ClearPanel()
        Text_Input1.Text = ""
        Text_Input2.Text = ""
        Input1.Visible = True
        Input2.Visible = True
        ClearInputs()
    End Sub

    'Neteja els inputs i
    'el label de resultat
    Private Sub ClearInputs()
        Input1.Text = ""
        Input2.Text = ""
        ResultText.Text = ""
    End Sub

    'Tanca el panel actual
    'i deselecciona lopcio
    'actual del treeview
    Private Sub ClosePanel()
        TreeView.SelectedNode = TreeView.Nodes.Item(0)
        Panel.Visible = False
        ClearPanel()
    End Sub

    'Habilita les opcions denganxar,
    'copiar i tallar en el click dret dels
    'inputs
    Private Sub NumericPanel()
        InitToolStripMenuItem.Enabled = True
        IncrementarEn1ToolStripMenuItem.Enabled = True
        DecrementarEn1ToolStripMenuItem.Enabled = True
    End Sub

    'Deshabilita les opcions denganxar,
    'copiar i tallar en el click dret dels
    'inputs
    Private Sub NotNumericPanel()
        InitToolStripMenuItem.Enabled = False
        IncrementarEn1ToolStripMenuItem.Enabled = False
        DecrementarEn1ToolStripMenuItem.Enabled = False
    End Sub

    'Variable que determina quin
    'input es el seleccionat
    'actualment
    Private _activeTextBox As Integer = 0

    'Event que sexecuta quan
    'es prem lopcio de copiar
    'text en un input, aquest
    'copia el contingut de linput
    'actual al clipboard
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        If Text_Input1.IsDisposed Then
            Clipboard.SetText(Text_Input1.Text)
        ElseIf Text_Input2.IsDisposed Then
            Clipboard.SetText(Text_Input2.Text)
        End If
    End Sub

    'Event que sexecuta quan
    'es prem lopcio de tallar
    'text en un input, aquest
    'talla el contingut de linput
    'actual al clipboard
    Private Sub TallarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TallarToolStripMenuItem.Click
        If _activeTextBox = 1 Then
            Clipboard.SetText(Input1.Text)
            Input1.Text = ""
        ElseIf _activeTextBox = 2 Then
            Clipboard.SetText(Input2.Text)
            Input2.Text = ""
        End If
    End Sub

    'Event que sexecuta quan
    'es prem lopcio denganxar
    'text en un input, aquest
    'enganxa en el input actual
    'el contingut que hi ha en
    'el clipboard
    Private Sub EnganxarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnganxarToolStripMenuItem.Click
        Dim text As String = Clipboard.GetText()
        If text IsNot Nothing Then
            If _activeTextBox = 1 Then
                Input1.Text = text
            ElseIf _activeTextBox = 2 Then
                Input2.Text = text
            End If
        End If
    End Sub

    'Event que sactiva quan el Input1
    'es seleccionat, aquest event
    'estableix un numero que identifica
    'quin input ha sigut seleccionat
    Private Sub Input1_Click(sender As Object, e As EventArgs) Handles Input1.Click
        _activeTextBox = 1
    End Sub

    'Event que sactiva quan el Input2
    'es seleccionat, aquest event
    'estableix un numero que identifica
    'quin input ha sigut seleccionat
    Private Sub Input2_Click(sender As Object, e As EventArgs) Handles Input2.Click
        _activeTextBox = 2
    End Sub

End Class
