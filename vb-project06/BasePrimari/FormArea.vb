Public Class FormArea
    Private Sub FormArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultText.Text = ""
    End Sub

#Region "Loads"
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
        Return False
    End Function
#End Region
#Region "Calculs"
    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de lArea i Longitud 1
    Private Function Result_AreaLong1()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) * Double.Parse(Input2.Text)) / 2
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
    'de lArea i Longitud 2
    Private Function Result_AreaLong2()
        Try
            Dim res As Double = Math.PI * Math.Pow(Double.Parse(Input1.Text), 2)
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
    'de lArea i Longitud 3
    Private Function Result_AreaLong3()
        Try
            Dim res As Double = 2 * Math.PI * Double.Parse(Input1.Text)
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
    'de lArea i Longitud 4
    Private Function Result_AreaLong4()
        Try
            Dim res As Double = Double.Parse(Input1.Text) * Double.Parse(Input2.Text)
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
#End Region
End Class