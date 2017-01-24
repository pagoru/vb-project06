<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
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
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea del triangle")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea de la rodona")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Longitud de la Circumferència")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea Rectangle")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrees i Longituds", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suma de dos números")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resta de dos números")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divisió de dos números")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multiplicació de dos números")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aritmètica", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donada una cadena mostrar la seva invertida")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donada una cadena mostrar el número de vocals i consonants que té la cadena")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en" &
        " una frase")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cadenes", New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transformar un numero enter")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fibornacci de n números")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("La taula de múltiplicar d’un número del 1 al n número indicat")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altres", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34, TreeNode35})
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.Input1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncrementarEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecrementarEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnganxarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close = New System.Windows.Forms.Button()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Text_Input1 = New System.Windows.Forms.Label()
        Me.Text_Input2 = New System.Windows.Forms.Label()
        Me.Input2 = New System.Windows.Forms.TextBox()
        Me.ListBoxResult = New System.Windows.Forms.ListBox()
        Me.ResultText = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView
        '
        Me.TreeView.Location = New System.Drawing.Point(13, 13)
        Me.TreeView.Name = "TreeView"
        TreeNode19.Name = "AreaLong_1"
        TreeNode19.Text = "Àrea del triangle"
        TreeNode20.Name = "AreaLong_2"
        TreeNode20.Text = "Àrea de la rodona"
        TreeNode21.Name = "AreaLong_3"
        TreeNode21.Text = "Longitud de la Circumferència"
        TreeNode22.Name = "AreaLong_4"
        TreeNode22.Text = "Àrea Rectangle"
        TreeNode23.Name = "root_AreaLong"
        TreeNode23.Text = "Àrees i Longituds"
        TreeNode24.Name = "Arit_1"
        TreeNode24.Text = "Suma de dos números"
        TreeNode25.Name = "Arit_2"
        TreeNode25.Text = "Resta de dos números"
        TreeNode26.Name = "Arit_3"
        TreeNode26.Text = "Divisió de dos números"
        TreeNode27.Name = "Arit_4"
        TreeNode27.Text = "Multiplicació de dos números"
        TreeNode28.Name = "root_Arit"
        TreeNode28.Text = "Aritmètica"
        TreeNode29.Name = "Cad_1"
        TreeNode29.Text = "Donada una cadena mostrar la seva invertida"
        TreeNode30.Name = "Cad_2"
        TreeNode30.Text = "Donada una cadena mostrar el número de vocals i consonants que té la cadena"
        TreeNode31.Name = "Cad_3"
        TreeNode31.Text = "Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en" &
    " una frase"
        TreeNode32.Name = "root_Cad"
        TreeNode32.Text = "Cadenes"
        TreeNode33.Name = "Alt_1"
        TreeNode33.Text = "Transformar un numero enter"
        TreeNode34.Name = "Alt_2"
        TreeNode34.Text = "Fibornacci de n números"
        TreeNode35.Name = "Alt_3"
        TreeNode35.Text = "La taula de múltiplicar d’un número del 1 al n número indicat"
        TreeNode36.Name = "root_Alt"
        TreeNode36.Text = "Altres"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode28, TreeNode32, TreeNode36})
        Me.TreeView.Size = New System.Drawing.Size(221, 322)
        Me.TreeView.TabIndex = 0
        '
        'Input1
        '
        Me.Input1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Input1.Location = New System.Drawing.Point(148, 65)
        Me.Input1.Name = "Input1"
        Me.Input1.Size = New System.Drawing.Size(159, 20)
        Me.Input1.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitToolStripMenuItem, Me.IncrementarEn1ToolStripMenuItem, Me.DecrementarEn1ToolStripMenuItem, Me.ToolStripSeparator1, Me.CopiarToolStripMenuItem, Me.TallarToolStripMenuItem, Me.EnganxarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 164)
        '
        'InitToolStripMenuItem
        '
        Me.InitToolStripMenuItem.Name = "InitToolStripMenuItem"
        Me.InitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.InitToolStripMenuItem.Text = "Inicialitzar a valor 0"
        '
        'IncrementarEn1ToolStripMenuItem
        '
        Me.IncrementarEn1ToolStripMenuItem.Name = "IncrementarEn1ToolStripMenuItem"
        Me.IncrementarEn1ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.IncrementarEn1ToolStripMenuItem.Text = "Incrementar en 1"
        '
        'DecrementarEn1ToolStripMenuItem
        '
        Me.DecrementarEn1ToolStripMenuItem.Name = "DecrementarEn1ToolStripMenuItem"
        Me.DecrementarEn1ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DecrementarEn1ToolStripMenuItem.Text = "Decrementar en 1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'TallarToolStripMenuItem
        '
        Me.TallarToolStripMenuItem.Name = "TallarToolStripMenuItem"
        Me.TallarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TallarToolStripMenuItem.Text = "Tallar"
        '
        'EnganxarToolStripMenuItem
        '
        Me.EnganxarToolStripMenuItem.Name = "EnganxarToolStripMenuItem"
        Me.EnganxarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EnganxarToolStripMenuItem.Text = "Enganxar"
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(0, 299)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(75, 23)
        Me.Close.TabIndex = 2
        Me.Close.Text = "Tancar"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Remove
        '
        Me.Remove.Location = New System.Drawing.Point(81, 299)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(75, 23)
        Me.Remove.TabIndex = 1
        Me.Remove.Text = "Borrar"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(232, 299)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(75, 23)
        Me.Result.TabIndex = 0
        Me.Result.Text = "Resultat"
        Me.Result.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(3, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(304, 37)
        Me.Title.TabIndex = 4
        Me.Title.Text = "Title"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_Input1
        '
        Me.Text_Input1.Location = New System.Drawing.Point(0, 65)
        Me.Text_Input1.Name = "Text_Input1"
        Me.Text_Input1.Size = New System.Drawing.Size(142, 20)
        Me.Text_Input1.TabIndex = 5
        Me.Text_Input1.Text = "Text_Input1"
        Me.Text_Input1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Text_Input2
        '
        Me.Text_Input2.Location = New System.Drawing.Point(0, 102)
        Me.Text_Input2.Name = "Text_Input2"
        Me.Text_Input2.Size = New System.Drawing.Size(142, 20)
        Me.Text_Input2.TabIndex = 7
        Me.Text_Input2.Text = "Text_Input2"
        Me.Text_Input2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Input2
        '
        Me.Input2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Input2.Location = New System.Drawing.Point(148, 102)
        Me.Input2.Name = "Input2"
        Me.Input2.Size = New System.Drawing.Size(159, 20)
        Me.Input2.TabIndex = 6
        '
        'ListBoxResult
        '
        Me.ListBoxResult.FormattingEnabled = True
        Me.ListBoxResult.Location = New System.Drawing.Point(148, 141)
        Me.ListBoxResult.Name = "ListBoxResult"
        Me.ListBoxResult.Size = New System.Drawing.Size(159, 95)
        Me.ListBoxResult.TabIndex = 8
        Me.ListBoxResult.Visible = False
        '
        'ResultText
        '
        Me.ResultText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ResultText.Location = New System.Drawing.Point(0, 254)
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(304, 23)
        Me.ResultText.TabIndex = 9
        Me.ResultText.Text = "ResultText"
        Me.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Close)
        Me.Panel.Controls.Add(Me.ResultText)
        Me.Panel.Controls.Add(Me.Remove)
        Me.Panel.Controls.Add(Me.Title)
        Me.Panel.Controls.Add(Me.Result)
        Me.Panel.Controls.Add(Me.ListBoxResult)
        Me.Panel.Controls.Add(Me.Input1)
        Me.Panel.Controls.Add(Me.Text_Input2)
        Me.Panel.Controls.Add(Me.Text_Input1)
        Me.Panel.Controls.Add(Me.Input2)
        Me.Panel.Location = New System.Drawing.Point(240, 13)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(307, 322)
        Me.Panel.TabIndex = 2
        Me.Panel.Visible = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 347)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.TreeView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form"
        Me.ShowIcon = False
        Me.Text = "Pablo González Rubio"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView As TreeView
    Friend WithEvents Input1 As TextBox
    Friend WithEvents Close As Button
    Friend WithEvents Remove As Button
    Friend WithEvents Result As Button
    Friend WithEvents Text_Input1 As Label
    Friend WithEvents Title As Label
    Friend WithEvents ResultText As Label
    Friend WithEvents ListBoxResult As ListBox
    Friend WithEvents Text_Input2 As Label
    Friend WithEvents Input2 As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncrementarEn1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecrementarEn1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TallarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnganxarToolStripMenuItem As ToolStripMenuItem
End Class
