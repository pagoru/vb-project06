<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBasePrimari
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Title = New System.Windows.Forms.Label()
        Me.LabelCurrentTime = New System.Windows.Forms.Label()
        Me.TimerCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.Result = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(12, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(304, 37)
        Me.Title.TabIndex = 5
        Me.Title.Text = "Title"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCurrentTime
        '
        Me.LabelCurrentTime.Location = New System.Drawing.Point(12, 311)
        Me.LabelCurrentTime.Name = "LabelCurrentTime"
        Me.LabelCurrentTime.Size = New System.Drawing.Size(306, 23)
        Me.LabelCurrentTime.TabIndex = 6
        Me.LabelCurrentTime.Text = "Hora"
        Me.LabelCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimerCurrentTime
        '
        Me.TimerCurrentTime.Enabled = True
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(243, 285)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(75, 23)
        Me.Result.TabIndex = 7
        Me.Result.Text = "Resultat"
        Me.Result.UseVisualStyleBackColor = True
        '
        'BasePrimari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 343)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.LabelCurrentTime)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BasePrimari"
        Me.ShowIcon = False
        Me.Text = "Pablo González Rubio"
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents Title As Label
    Friend WithEvents LabelCurrentTime As Label
    Friend WithEvents TimerCurrentTime As Timer
    Protected Friend WithEvents Result As Button
End Class
