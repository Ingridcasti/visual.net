Imports CapaEntidad
Imports Capa_Datos


Public Class CNEmpleados
    Dim datosempleado As New CDEmpleado
    Public Function validar_datos(ByVal empleado As CEEmpleado) As Boolean
        Dim resultado As Boolean = True
        If empleado.Nombre = "" Then
            resultado = False
            MessageBox.Show("El nombre es obligatorio")
        End If
        If empleado.Apellido = "" Then
            resultado = False
            MessageBox.Show("El apellido es obligatorio")
        End If
        Return resultado
    End Function
    Public Sub pruebamysql()
        datosempleado.probarconexion()
    End Sub
    Public Sub insertar(ByVal empleado As CEEmpleado)
        datosempleado.insertar(empleado)

    End Sub

    Public Sub Editar(ByVal empleado As CEEmpleado)
        datosempleado.Modificar(empleado)
    End Sub

    Public Sub Eliminar(ByVal empleado As CEEmpleado)

        If MessageBox.Show("¿Estas Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            datosempleado.Eliminar(empleado)
        End If

    End Sub
    Public Function Listar() As DataSet
        Return datosempleado.listar()
    End Function
End Class
