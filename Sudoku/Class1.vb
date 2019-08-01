Public Class Sudoku
    Private _RealGrid(,) As String

    Public Sub SetGrid(grid(,) As String)
        _RealGrid = grid

        Dim test As String

        test = grid(8, 8)
        test = 18
        MsgBox("8,8 : " & grid(8, 8))
    End Sub
End Class

Public Class GroupOfNine

End Class