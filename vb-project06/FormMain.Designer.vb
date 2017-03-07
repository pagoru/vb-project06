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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea del triangle")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea de la rodona")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Longitud de la Circumferència")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea Rectangle")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrees i Longituds", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suma de dos números")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resta de dos números")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divisió de dos números")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multiplicació de dos números")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aritmètica", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donada una cadena mostrar la seva invertida")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donada una cadena mostrar el número de vocals i consonants que té la cadena")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en" &
        " una frase")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cadenes", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transformar un numero enter")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fibornacci de n números")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("La taula de múltiplicar d’un número del 1 al n número indicat")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altres", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncrementarEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecrementarEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnganxarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView
        '
        Me.TreeView.Location = New System.Drawing.Point(13, 13)
        Me.TreeView.Name = "TreeView"
        TreeNode1.Name = "AreaLong_1"
        TreeNode1.Text = "Àrea del triangle"
        TreeNode2.Name = "AreaLong_2"
        TreeNode2.Text = "Àrea de la rodona"
        TreeNode3.Name = "AreaLong_3"
        TreeNode3.Text = "Longitud de la Circumferència"
        TreeNode4.Name = "AreaLong_4"
        TreeNode4.Text = "Àrea Rectangle"
        TreeNode5.Name = "root_AreaLong"
        TreeNode5.Text = "Àrees i Longituds"
        TreeNode6.Name = "Arit_1"
        TreeNode6.Text = "Suma de dos números"
        TreeNode7.Name = "Arit_2"
        TreeNode7.Text = "Resta de dos números"
        TreeNode8.Name = "Arit_3"
        TreeNode8.Text = "Divisió de dos números"
        TreeNode9.Name = "Arit_4"
        TreeNode9.Text = "Multiplicació de dos números"
        TreeNode10.Name = "root_Arit"
        TreeNode10.Text = "Aritmètica"
        TreeNode11.Name = "Cad_1"
        TreeNode11.Text = "Donada una cadena mostrar la seva invertida"
        TreeNode12.Name = "Cad_2"
        TreeNode12.Text = "Donada una cadena mostrar el número de vocals i consonants que té la cadena"
        TreeNode13.Name = "Cad_3"
        TreeNode13.Text = "Donat dos caracters dins quantes vegades apareix aquest dos caracters seguints en" &
    " una frase"
        TreeNode14.Name = "root_Cad"
        TreeNode14.Text = "Cadenes"
        TreeNode15.Name = "Alt_1"
        TreeNode15.Text = "Transformar un numero enter"
        TreeNode16.Name = "Alt_2"
        TreeNode16.Text = "Fibornacci de n números"
        TreeNode17.Name = "Alt_3"
        TreeNode17.Text = "La taula de múltiplicar d’un número del 1 al n número indicat"
        TreeNode18.Name = "root_Alt"
        TreeNode18.Text = "Altres"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode14, TreeNode18})
        Me.TreeView.Size = New System.Drawing.Size(505, 322)
        Me.TreeView.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitToolStripMenuItem, Me.IncrementarEn1ToolStripMenuItem, Me.DecrementarEn1ToolStripMenuItem, Me.ToolStripSeparator1, Me.CopiarToolStripMenuItem, Me.TallarToolStripMenuItem, Me.EnganxarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 142)
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
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 347)
        Me.Controls.Add(Me.TreeView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form"
        Me.ShowIcon = False
        Me.Text = "Pablo González Rubio"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView As TreeView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncrementarEn1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecrementarEn1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TallarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnganxarToolStripMenuItem As ToolStripMenuItem
End Class
