<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAbrirBBDD = New System.Windows.Forms.Button()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Añadir = New System.Windows.Forms.Button()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Personas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAbrirBBDD
        '
        Me.BtnAbrirBBDD.Location = New System.Drawing.Point(23, 250)
        Me.BtnAbrirBBDD.Name = "BtnAbrirBBDD"
        Me.BtnAbrirBBDD.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbrirBBDD.TabIndex = 0
        Me.BtnAbrirBBDD.Text = "Abrir BBDD"
        Me.BtnAbrirBBDD.UseVisualStyleBackColor = True
        '
        'lblRuta
        '
        Me.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRuta.Location = New System.Drawing.Point(104, 250)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(280, 69)
        Me.lblRuta.TabIndex = 1
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(237, 181)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(108, 23)
        Me.Limpiar.TabIndex = 2
        Me.Limpiar.Text = "Limpiar Campos"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(328, 127)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Eliminar.Size = New System.Drawing.Size(56, 33)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(259, 127)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(63, 33)
        Me.Modificar.TabIndex = 4
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Añadir
        '
        Me.Añadir.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Añadir.Location = New System.Drawing.Point(193, 127)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(57, 33)
        Me.Añadir.TabIndex = 5
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(284, 86)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextNombre.TabIndex = 6
        '
        'TextDni
        '
        Me.TextDni.Location = New System.Drawing.Point(284, 47)
        Me.TextDni.Name = "TextDni"
        Me.TextDni.Size = New System.Drawing.Size(100, 20)
        Me.TextDni.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(34, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 10
        '
        'Personas
        '
        Me.Personas.AutoSize = True
        Me.Personas.Location = New System.Drawing.Point(31, 22)
        Me.Personas.Name = "Personas"
        Me.Personas.Size = New System.Drawing.Size(51, 13)
        Me.Personas.TabIndex = 11
        Me.Personas.Text = "Personas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 396)
        Me.Controls.Add(Me.Personas)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextDni)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.BtnAbrirBBDD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAbrirBBDD As Button
    Friend WithEvents lblRuta As Label
    Friend WithEvents Limpiar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Añadir As Button
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextDni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Personas As Label
End Class
