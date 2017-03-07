Public Class FormCad
    Private Sub FormCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultText.Text = ""
    End Sub

#Region "Loads"
    'Mostra en el panel la opcio
    'Cadena de Caracters 3
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Protected Function View_Cad3()
        Title.Text = "Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en una frase."
        Text_Input1.Text = "Cadena de carácters"
        Text_Input2.Text = "Dos carácters a buscar"
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
    Protected Function View_Cad2()
        Title.Text = "Donada una cadena mostrar el número de vocals i consonants que té la cadena."
        Text_Input1.Text = "Cadena de carácters"
        Input2.Visible = False
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
    Protected Function View_Cad1()
        Title.Text = "Donada una cadena mostrar la seva invertida"
        Text_Input1.Text = "Cadena de carácters"
        Input2.Visible = False
        Return False
    End Function
#End Region
#Region "Calculs"
    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Cadena de caracters 3
    Protected Function Result_Cad3()
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
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Cadena de caracters 2
    Protected Function Result_Cad2()
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
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Cadena de caracters 1
    Protected Function Result_Cad1()
        Try
            ResultText.Text = "El resultat es " + StrReverse(Input1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        Input1.Text = ""
        Input2.Text = ""
        ResultText.Text = ""
    End Sub
#End Region
End Class