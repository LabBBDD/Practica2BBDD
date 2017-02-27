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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 396)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.BtnAbrirBBDD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAbrirBBDD As Button
    Friend WithEvents lblRuta As Label
End Class
