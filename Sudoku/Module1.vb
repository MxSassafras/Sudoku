Module GridFunctions
    Public Function ConvertToGrid(ByVal value As String()) As Array
        If value Is Nothing Then
            Throw New ArgumentNullException(NameOf(value))
        End If

        Dim grid(8, 8) As String
        Dim current = 0

        For i = 0 To 8
            For j = 0 To 8
                grid(i, j) = value(current)
                current = current + 1
            Next
        Next

        Return grid
    End Function
End Module
