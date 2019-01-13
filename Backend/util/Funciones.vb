Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Module Funciones
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Public Function SafeGetString(ByRef reader As MySqlDataReader, ByVal Index As Integer) As String
        If Not reader.IsDBNull(Index) Then
            Return reader.GetString(Index)
        End If
        Return String.Empty
    End Function

    Public Function safeGetChar(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Char
        If Not reader.IsDBNull(Index) Then
            Return reader.GetChar(Index)
        End If
        Return Nothing
    End Function

    Public Function SafeGetInt(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Integer
        If Not reader.IsDBNull(Index) Then
            Return reader.GetInt32(Index)
        End If
        Return 0
    End Function

    Public Function SafeGetDate(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Date
        If Not reader.IsDBNull(Index) Then
            Return reader.GetDateTime(Index)
        End If
        Return Nothing
    End Function

    Public Function SafeGetDouble(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Double
        If Not reader.IsDBNull(Index) Then
            Return reader.GetDouble(Index)
        End If
        Return CDbl(0)
    End Function

    Public Function SafeGetDecimal(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Decimal
        If Not reader.IsDBNull(Index) Then
            Return reader.GetDecimal(Index)
        End If
        Return CDec(0)
    End Function
End Module
