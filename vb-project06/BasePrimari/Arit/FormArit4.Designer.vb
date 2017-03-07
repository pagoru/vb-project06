<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArit4
    Inherits FormArit

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ResultText
        '
        Me.ResultText.Text = ""
        '
        'Result
        '
        '
        'FormArit4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 343)
        Me.Name = "FormArit4"
        Me.Text = "FormArit4"
        Me.Controls.SetChildIndex(Me.Title, 0)
        Me.Controls.SetChildIndex(Me.Result, 0)
        Me.Controls.SetChildIndex(Me.Input2, 0)
        Me.Controls.SetChildIndex(Me.Text_Input1, 0)
        Me.Controls.SetChildIndex(Me.Text_Input2, 0)
        Me.Controls.SetChildIndex(Me.Input1, 0)
        Me.Controls.SetChildIndex(Me.ResultText, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
