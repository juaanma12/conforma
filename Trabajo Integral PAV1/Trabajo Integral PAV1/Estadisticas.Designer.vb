﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Me.components = New System.ComponentModel.Container()
        Me.t_ventas_x_clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Trabajo_Integral_PAV1.DataSet1()
        Me.cmd_ventas_x_cliente = New System.Windows.Forms.Button()
        Me.cmd_productos_pedidos = New System.Windows.Forms.Button()
        Me.cmd_pedidos_cancelados = New System.Windows.Forms.Button()
        CType(Me.t_ventas_x_clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_ventas_x_clienteBindingSource
        '
        Me.t_ventas_x_clienteBindingSource.DataMember = "t_ventas_x_cliente"
        Me.t_ventas_x_clienteBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_ventas_x_cliente
        '
        Me.cmd_ventas_x_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ventas_x_cliente.Location = New System.Drawing.Point(57, 28)
        Me.cmd_ventas_x_cliente.Name = "cmd_ventas_x_cliente"
        Me.cmd_ventas_x_cliente.Size = New System.Drawing.Size(173, 48)
        Me.cmd_ventas_x_cliente.TabIndex = 0
        Me.cmd_ventas_x_cliente.Text = "Ventas por cliente"
        Me.cmd_ventas_x_cliente.UseVisualStyleBackColor = True
        '
        'cmd_productos_pedidos
        '
        Me.cmd_productos_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_productos_pedidos.Location = New System.Drawing.Point(250, 28)
        Me.cmd_productos_pedidos.Name = "cmd_productos_pedidos"
        Me.cmd_productos_pedidos.Size = New System.Drawing.Size(173, 48)
        Me.cmd_productos_pedidos.TabIndex = 0
        Me.cmd_productos_pedidos.Text = "Productos de pedido"
        Me.cmd_productos_pedidos.UseVisualStyleBackColor = True
        '
        'cmd_pedidos_cancelados
        '
        Me.cmd_pedidos_cancelados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pedidos_cancelados.Location = New System.Drawing.Point(449, 28)
        Me.cmd_pedidos_cancelados.Name = "cmd_pedidos_cancelados"
        Me.cmd_pedidos_cancelados.Size = New System.Drawing.Size(173, 48)
        Me.cmd_pedidos_cancelados.TabIndex = 0
        Me.cmd_pedidos_cancelados.Text = "Pedidos cancelados"
        Me.cmd_pedidos_cancelados.UseVisualStyleBackColor = True
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 472)
        Me.Controls.Add(Me.cmd_pedidos_cancelados)
        Me.Controls.Add(Me.cmd_productos_pedidos)
        Me.Controls.Add(Me.cmd_ventas_x_cliente)
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.t_ventas_x_clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents t_ventas_x_clienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Trabajo_Integral_PAV1.DataSet1
    Friend WithEvents cmd_ventas_x_cliente As System.Windows.Forms.Button
    Friend WithEvents cmd_productos_pedidos As System.Windows.Forms.Button
    Friend WithEvents cmd_pedidos_cancelados As System.Windows.Forms.Button
End Class