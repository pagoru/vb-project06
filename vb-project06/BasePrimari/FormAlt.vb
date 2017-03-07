Public Class FormAlt
    Protected Sub FormAlt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultText.Text = ""
        Text_Input1.Text = ""
        Text_Input2.Text = ""
    End Sub

#Region "Loads"
    'Mostra en el panel la opcio
    'Alternativa 3
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Protected Function View_Alt3()
        Title.Text = "La taula de múltiplicar d’un número del 1 al n número indicat."
        Text_Input1.Text = "Número a multiplicar"
        Text_Input2.Text = "Número limit"
        ListBoxResult.Visible = True
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
    Protected Function View_Alt2()
        Title.Text = "Fibornacci de n números: (7) 1 1 2 3 5 8 13"
        Text_Input1.Text = "Número enter"
        ListBoxResult.Visible = True
        Input2.Visible = False
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
    Protected Function View_Alt1()
        Title.Text = "Transformar un numero enter, com màxim el 999.999.999, a lletres (castellà o català), per exemple 1567 -> ‘mil quinientos sesenta y siete’."
        Text_Input1.Text = "Número enter"
        Input2.Visible = False
        Return False
    End Function
#End Region
#Region "Calculs"
    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Altres 3
    Protected Function Result_Alt3()
        Try
            ListBoxResult.Items.Clear()
            For m As Integer = 0 To CType(Input2.Text, Integer)
                ListBoxResult.Items.Add((CType(Input1.Text, Integer) * m).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Altres 2
    Protected Function Result_Alt2()
        Try
            ListBoxResult.Items.Clear()
            For f As Integer = 0 To CType(Input1.Text, Integer)
                ListBoxResult.Items.Add(GetFibonacci(f).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Altres 1
    Protected Function Result_Alt1()
        Try
            ResultText.Text = "El nombre en català es " + GetNameFromNumber(CType(Input1.Text, Integer))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Aquest metode sutilitza com a pont 
    'de recursivitat amb el metode
    'GetNameFromNumber, que permet
    'extreure el nom de un nombre
    'enter en catala
    Protected Function GetNameFromNumberRecursive(number As String, dis As Integer, len As Integer)
        Return GetNameFromNumber(CType(number.ToString().Substring(dis, len), Integer))
    End Function

    'Retorna del 1 al 999.999.999
    'els numeros en catala, utilitza 
    'metode que crida a aquest mateix
    '(recursivitat) per tal de poder
    'extreure bona part dels nombres
    Protected Function GetNameFromNumber(number As Integer)
        Select Case (number)
            Case 1 : Return "u"
            Case 2 : Return "dos"
            Case 3 : Return "tres"
            Case 4 : Return "cuatre"
            Case 5 : Return "cinc"
            Case 6 : Return "sis"
            Case 7 : Return "set"
            Case 8 : Return "vuit"
            Case 9 : Return "nou"
            Case 10 : Return "deu"
            Case 11 : Return "onze"
            Case 12 : Return "dotze"
            Case 13 : Return "tretze"
            Case 14 : Return "catorze"
            Case 15 : Return "quinze"
            Case 16 : Return "setze"
            Case 17 To 20
                Return "di" + GetNameFromNumberRecursive(number, 1, 1)
            Case 20 : Return "vint"
            Case 21 To 29
                Return "vint-i-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 30 : Return "trenta"
            Case 31 To 39
                Return "trenta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 40 : Return "quaranta"
            Case 41 To 49
                Return "quaranta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 50 : Return "cinquanta"
            Case 51 To 59
                Return "cinquanta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 60 : Return "seixanta"
            Case 61 To 69
                Return "seixanta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 70 : Return "setanta"
            Case 71 To 79
                Return "setanta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 80 : Return "vuitanta"
            Case 81 To 89
                Return "vuitanta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 90 : Return "noranta"
            Case 91 To 99
                Return "noranta-" + GetNameFromNumberRecursive(number, 1, 1)
            Case 100 : Return "cent"
            Case 101 To 199
                Return "cent-" + GetNameFromNumberRecursive(number, 1, 2)
            Case 200 To 999
                Return GetNameFromNumberRecursive(number, 0, 1) + "-cents " + GetNameFromNumberRecursive(number, 1, 2)
            Case 1000 To 1999
                Return "mil" + GetNameFromNumberRecursive(number, 1, 3)
            Case 2000 To 9999
                Return GetNameFromNumberRecursive(number, 0, 1) + "-mil " + GetNameFromNumberRecursive(number, 1, 3)
            Case 10000 To 99999
                Return GetNameFromNumberRecursive(number, 0, 2) + "-mil " + GetNameFromNumberRecursive(number, 2, 3)
            Case 100000 To 999999
                Return GetNameFromNumberRecursive(number, 0, 3) + "-mil " + GetNameFromNumberRecursive(number, 3, 3)
            Case 1000000 To 1999999
                Return "un milió " + GetNameFromNumberRecursive(number, 1, 6)
            Case 2000000 To 9999999
                Return GetNameFromNumberRecursive(number, 0, 1) + " milions " + GetNameFromNumberRecursive(number, 1, 6)
        End Select
        Return ""
    End Function

    'Funcio recursiva
    'que retorna pasat un index
    'de la serie fibonacci, el 
    'numero que li pertoca en
    'aquesta.
    Protected Function GetFibonacci(reiterations As Integer)
        If reiterations > 1 Then
            Return GetFibonacci(reiterations - 1) + GetFibonacci(reiterations - 2)
        ElseIf reiterations = 1 Then
            Return 1
        End If
        Return 0
    End Function

    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        Input1.Text = ""
        Input2.Text = ""
        ListBoxResult.Items.Clear()
        ResultText.Text = ""
    End Sub
#End Region
End Class