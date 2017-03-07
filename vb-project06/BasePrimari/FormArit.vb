Public Class FormArit
    Private Sub FormArit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultText.Text = ""
    End Sub

#Region "Loads"
    'Mostra en el panel la opcio
    'Aritmetica 4
    'Aquesta mostra el panel, un titol
    'adequat per aquesta vista de panel
    'Tambe posa invisible els inputs
    'no necessaris del panel i selecciona
    'un metode per elegir si les opcions
    'disponibles del click dret sobre els
    'inputs
    Protected Function View_Arit4()
        Title.Text = "Multiplicació de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
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
    Protected Function View_Arit3()
        Title.Text = "Divisió de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
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
    Protected Function View_Arit2()
        Title.Text = "Resta de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
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
    Protected Function View_Arit1()
        Title.Text = "Suma de dos números"
        Text_Input1.Text = "Número 1"
        Text_Input2.Text = "Número 2"
        Return False
    End Function
#End Region
#Region "Calculs"
    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 4
    Protected Function Result_Arit4()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) * Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 3
    Protected Function Result_Arit3()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) / Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 2
    Protected Function Result_Arit2()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) - Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 1
    Protected Function Result_Arit1()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) + Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
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