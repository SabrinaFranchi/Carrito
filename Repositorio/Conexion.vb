Imports System.Data.SqlClient

Public Class Conexion
    Dim con As SqlConnection
    Public puntero As SqlConnection
    Public EstadoConexion As Boolean = False
    Public Sub conectar()
        con = New SqlConnection
        con.ConnectionString = ConfigurationManager.ConnectionStrings("BDSegMascConnectionString").ToString
        Try
            con.Open()
            puntero = con
            EstadoConexion = True
        Catch ex As Exception
            EstadoConexion = False
        End Try
    End Sub
    Public Sub desconectar()
        con.Close()
    End Sub
End Class
