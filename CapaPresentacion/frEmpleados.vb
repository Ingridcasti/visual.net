Imports CapaEntidad
Imports CapaNegocio


Public Class frEmpleados
    Dim negocioempleado As New CNEmpleados()
    Private Sub Limpiar()
        txtid.Value = 0
        txtnombre.Text = ""
        txtapellido.Text = ""
        picfoto.Image = Nothing

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        openfoto.ShowDialog()
        If openfoto.FileName <> "" Then
            picfoto.Load(openfoto.FileName)
        End If

        openfoto.FileName = ""

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim empleado As New CEEmpleado()
        Dim validacion As Boolean
        empleado.Id = txtid.Value
        empleado.Nombre = txtnombre.Text
        empleado.Apellido = txtapellido.Text
        empleado.Foto = picfoto.ImageLocation

        validacion = negocioempleado.validar_datos(empleado)
        If validacion = False Then Exit Sub

        If empleado.Id = 0 Then
            negocioempleado.insertar(empleado)
        Else
            negocioempleado.Editar(empleado)
        End If

        cargargrid()
        Limpiar()


    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txtid.Value = 0 Then Exit Sub

        Dim empleado As New CEEmpleado()
        empleado.Id = txtid.Value
        negocioempleado.Eliminar(empleado)
        cargargrid()
        Limpiar()
    End Sub

    Private Sub frEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrid()
    End Sub

    Private Sub cargargrid()
        gridDatos.DataSource = negocioempleado.Listar().Tables("empleado")
    End Sub

    Private Sub gridDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDatos.CellDoubleClick
        'rellenamos los txt con los datos de la fila del datagrid seleccionada
        txtid.Value = gridDatos.CurrentRow.Cells("id").Value
        txtnombre.Text = gridDatos.CurrentRow.Cells("nombre").Value
        txtapellido.Text = gridDatos.CurrentRow.Cells("apellido").Value
        'validamos que el archivo exista en la ruta que se a seleccionado
        If gridDatos.CurrentRow.Cells("foto").Value <> "" Then
            If System.IO.File.Exists(gridDatos.CurrentRow.Cells("foto").Value) Then
                ' si existe se muestra en picfoto
                picfoto.Load(gridDatos.CurrentRow.Cells("foto").Value)
            End If
        End If
    End Sub
End Class
