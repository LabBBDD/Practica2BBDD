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
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextDni = New System.Windows.Forms.TextBox()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LBPersonas = New System.Windows.Forms.ListBox()
        Me.Personas = New System.Windows.Forms.Label()
        Me.BtbConectar = New System.Windows.Forms.Button()
        Me.PnlArriba = New System.Windows.Forms.Panel()
        Me.PnlArriba.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAbrirBBDD
        '
        Me.BtnAbrirBBDD.Location = New System.Drawing.Point(27, 220)
        Me.BtnAbrirBBDD.Name = "BtnAbrirBBDD"
        Me.BtnAbrirBBDD.Size = New System.Drawing.Size(75, 69)
        Me.BtnAbrirBBDD.TabIndex = 0
        Me.BtnAbrirBBDD.Text = "Abrir BBDD"
        Me.BtnAbrirBBDD.UseVisualStyleBackColor = True
        '
        'lblRuta
        '
        Me.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRuta.Location = New System.Drawing.Point(108, 220)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(280, 69)
        Me.lblRuta.TabIndex = 1
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(185, 161)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(191, 23)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.Text = "Limpiar Campos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(320, 116)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(56, 33)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(251, 116)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(63, 33)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnAñadir.Location = New System.Drawing.Point(185, 116)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(57, 33)
        Me.BtnAñadir.TabIndex = 5
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(251, 75)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(125, 20)
        Me.TextNombre.TabIndex = 6
        '
        'TextDni
        '
        Me.TextDni.Location = New System.Drawing.Point(251, 39)
        Me.TextDni.Name = "TextDni"
        Me.TextDni.Size = New System.Drawing.Size(125, 20)
        Me.TextDni.TabIndex = 7
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(185, 39)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(26, 13)
        Me.LblDNI.TabIndex = 8
        Me.LblDNI.Text = "DNI"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(185, 78)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 9
        Me.LblNombre.Text = "Nombre"
        '
        'LBPersonas
        '
        Me.LBPersonas.FormattingEnabled = True
        Me.LBPersonas.Location = New System.Drawing.Point(15, 33)
        Me.LBPersonas.Name = "LBPersonas"
        Me.LBPersonas.Size = New System.Drawing.Size(164, 160)
        Me.LBPersonas.TabIndex = 10
        '
        'Personas
        '
        Me.Personas.AutoSize = True
        Me.Personas.Location = New System.Drawing.Point(23, 11)
        Me.Personas.Name = "Personas"
        Me.Personas.Size = New System.Drawing.Size(51, 13)
        Me.Personas.TabIndex = 11
        Me.Personas.Text = "Personas"
        '
        'BtbConectar
        '
        Me.BtbConectar.Location = New System.Drawing.Point(27, 304)
        Me.BtbConectar.Name = "BtbConectar"
        Me.BtbConectar.Size = New System.Drawing.Size(361, 50)
        Me.BtbConectar.TabIndex = 12
        Me.BtbConectar.Text = "Conectar con la base de datos"
        Me.BtbConectar.UseVisualStyleBackColor = True
        '
        'PnlArriba
        '
        Me.PnlArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlArriba.Controls.Add(Me.TextDni)
        Me.PnlArriba.Controls.Add(Me.LBPersonas)
        Me.PnlArriba.Controls.Add(Me.BtnLimpiar)
        Me.PnlArriba.Controls.Add(Me.BtnEliminar)
        Me.PnlArriba.Controls.Add(Me.Personas)
        Me.PnlArriba.Controls.Add(Me.BtnModificar)
        Me.PnlArriba.Controls.Add(Me.BtnAñadir)
        Me.PnlArriba.Controls.Add(Me.LblNombre)
        Me.PnlArriba.Controls.Add(Me.TextNombre)
        Me.PnlArriba.Controls.Add(Me.LblDNI)
        Me.PnlArriba.Location = New System.Drawing.Point(12, 7)
        Me.PnlArriba.Name = "PnlArriba"
        Me.PnlArriba.Size = New System.Drawing.Size(388, 207)
        Me.PnlArriba.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 371)
        Me.Controls.Add(Me.PnlArriba)
        Me.Controls.Add(Me.BtbConectar)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.BtnAbrirBBDD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PnlArriba.ResumeLayout(False)
        Me.PnlArriba.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAbrirBBDD As Button
    Friend WithEvents lblRuta As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextDni As TextBox
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LBPersonas As ListBox
    Friend WithEvents Personas As Label
    Friend WithEvents BtbConectar As Button
    Friend WithEvents PnlArriba As Panel
End Class
