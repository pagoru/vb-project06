<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCad3
    Inherits FormCad

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
        'FormCad3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 343)
        Me.Name = "FormCad3"
        Me.Text = "FormCad3"
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
