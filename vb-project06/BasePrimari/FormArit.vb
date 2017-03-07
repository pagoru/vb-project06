Public Class FormArit
    Private Sub FormArit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultText.Text = ""
    End Sub

#Region "Loads"

#End Region
#Region "Calculs"
    'Mostra per el label de
    'resultat la informacio
    'de les operacions resultants
    'de Aritmetica 4
    Private Function Result_Arit4()
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
    Private Function Result_Arit3()
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
    Private Function Result_Arit2()
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
    Private Function Result_Arit1()
        Try
            Dim res As Double = (Double.Parse(Input1.Text) + Double.Parse(Input2.Text))
            ResultText.Text = "El resultat es " + CType(res, String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
#End Region
End Class