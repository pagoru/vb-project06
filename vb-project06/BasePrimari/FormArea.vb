Public Class FormArea
    Private Sub FormArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultText.Text = ""
    End Sub

#Region "Loads"

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