<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArea
    Inherits FormBasePrimari

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
        Me.ResultText = New System.Windows.Forms.Label()
        Me.Input1 = New System.Windows.Forms.TextBox()
        Me.Text_Input2 = New System.Windows.Forms.Label()
        Me.Text_Input1 = New System.Windows.Forms.Label()
        Me.Input2 = New System.Windows.Forms.TextBox()
        Me.Remove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultText
        '
        Me.ResultText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ResultText.Location = New System.Drawing.Point(15, 210)
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(304, 23)
        Me.ResultText.TabIndex = 23
        Me.ResultText.Text = "ResultText"
        Me.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Input1
        '
        Me.Input1.Location = New System.Drawing.Point(160, 109)
        Me.Input1.Name = "Input1"
        Me.Input1.Size = New System.Drawing.Size(159, 20)
        Me.Input1.TabIndex = 19
        '
        'Text_Input2
        '
        Me.Text_Input2.Location = New System.Drawing.Point(12, 146)
        Me.Text_Input2.Name = "Text_Input2"
        Me.Text_Input2.Size = New System.Drawing.Size(142, 20)
        Me.Text_Input2.TabIndex = 22
        Me.Text_Input2.Text = "Text_Input2"
        Me.Text_Input2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Text_Input1
        '
        Me.Text_Input1.Location = New System.Drawing.Point(12, 109)
        Me.Text_Input1.Name = "Text_Input1"
        Me.Text_Input1.Size = New System.Drawing.Size(142, 20)
        Me.Text_Input1.TabIndex = 20
        Me.Text_Input1.Text = "Text_Input1"
        Me.Text_Input1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Input2
        '
        Me.Input2.Location = New System.Drawing.Point(160, 146)
        Me.Input2.Name = "Input2"
        Me.Input2.Size = New System.Drawing.Size(159, 20)
        Me.Input2.TabIndex = 21
        '
        'Remove
        '
        Me.Remove.Location = New System.Drawing.Point(12, 285)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(75, 23)
        Me.Remove.TabIndex = 24
        Me.Remove.Text = "Borrar"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'FormArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 343)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.ResultText)
        Me.Controls.Add(Me.Input1)
        Me.Controls.Add(Me.Text_Input2)
        Me.Controls.Add(Me.Text_Input1)
        Me.Controls.Add(Me.Input2)
        Me.Name = "FormArea"
        Me.Text = "FormArea"
        Me.Controls.SetChildIndex(Me.Title, 0)
        Me.Controls.SetChildIndex(Me.Result, 0)
        Me.Controls.SetChildIndex(Me.Input2, 0)
        Me.Controls.SetChildIndex(Me.Text_Input1, 0)
        Me.Controls.SetChildIndex(Me.Text_Input2, 0)
        Me.Controls.SetChildIndex(Me.Input1, 0)
        Me.Controls.SetChildIndex(Me.ResultText, 0)
        Me.Controls.SetChildIndex(Me.Remove, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents ResultText As Label
    Protected Friend WithEvents Input1 As TextBox
    Protected Friend WithEvents Text_Input2 As Label
    Protected Friend WithEvents Text_Input1 As Label
    Protected Friend WithEvents Input2 As TextBox
    Protected Friend WithEvents Remove As Button
End Class
