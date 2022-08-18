Imports MySql.Data.MySqlClient
Imports CapaEntidad



Public Class CDEmpleado
    Private _cadenaconexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=curso_vb"
    Public Sub probarconexion()
        Dim conexion As New MySqlConnection(_cadenaconexion)


        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MessageBox.Show("conectado")
        conexion.Close()
    End Sub
    Public Sub insertar(ByVal empleados As CEEmpleado)
        Dim conexion As New MySqlConnection(_cadenaconexion)
        conexion.Open()
        Dim query As String = "INSERT INTO `empleados` (`nombre`, `apellido`, `foto`) VALUES ('" & empleados.Nombre & "', '" & empleados.Apellido & "', '" & MySql.Data.MySqlClient.MySqlHelper.EscapeString(empleados.Foto) & " ');"

        Dim comando As New MySqlCommand(query, conexion)
        comando.ExecuteNonQuery()
        conexion.Close()
        MessageBox.Show("Registro creado")
    End Sub

    Public Sub Modificar(ByVal empleado As CEEmpleado)
        Dim Conexion As New MySqlConnection(_cadenaconexion)
        Conexion.Open()
        Dim Query As String = "UPDATE `empleados` SET `nombre`='" & empleado.Nombre & "', `apellido`='" & empleado.Apellido & "', `foto`='" & MySql.Data.MySqlClient.MySqlHelper.EscapeString(empleado.Foto) & "' WHERE  `id`=" & empleado.Id & ";"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()
        MessageBox.Show("Registro Editado")
    End Sub

    Public Sub Eliminar(ByVal empleado As CEEmpleado)
        Dim Conexion As New MySqlConnection(_cadenaconexion)
        Conexion.Open()
        Dim Query As String = "DELETE FROM `empleados` WHERE  `id`=" & empleado.Id & ";"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()
        MessageBox.Show("Registro Eliminado")
    End Sub

    Public Function listar() As DataSet
        Dim conexion As New MySqlConnection(_cadenaconexion)
        conexion.Open()
        Dim query As String = "SELECT * FROM `empleados` LIMIT 1000;"
        Dim adaptador As MySqlDataAdapter
        Dim dataset As New DataSet
        adaptador = New MySqlDataAdapter(query, conexion)
        adaptador.Fill(dataset, "empleado")
        Return dataset


    End Function
End Class
