﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Rows.Add()

        For i As Int16 = 0 To 8
            Me.DataGridView1.Columns(i).Width = 30
        Next

        PopulateGrid()

        Dim grid = ReadFromGrid()
        Dim sudoku = New Sudoku
        sudoku.SetGrid(grid)


    End Sub

    Private Sub PopulateGrid()
        Dim strGrid = ""
        Dim strGridArray As String()
        Dim grid(8, 8) As String

        For i = 0 To 80
            If strGrid = "" Then
                strGrid = i.ToString()
            Else
                strGrid = strGrid & "," & i.ToString()
            End If
            'For j = 0 To 8
            '    If strGrid = "" Then
            '        strGrid = j.ToString()
            '    Else
            '        strGrid = strGrid & "," & j.ToString()
            '    End If
            'Next
        Next

        strGridArray = strGrid.Split(",")

        grid = ConvertToGrid(strGridArray)

        For i As Int16 = 0 To 8
            For j = 0 To 8
                Dim value = grid(i, j)
                Me.DataGridView1.Rows(i).Cells(j).Value = value
            Next
        Next
    End Sub

    Private Function ReadFromGrid() As Array
        Dim strGrid = ""
        Dim grid(8, 8) As String

        For i = 0 To 8
            For j = 0 To 8
                grid(i, j) = Me.DataGridView1.Rows(i).Cells(j).Value
            Next
        Next

        Return grid
    End Function

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btTest = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(273, 202)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        '
        'btTest
        '
        Me.btTest.Location = New System.Drawing.Point(291, 12)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(75, 23)
        Me.btTest.TabIndex = 1
        Me.btTest.Text = "Test"
        Me.btTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btTest)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents btTest As Button

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        Dim grid = ReadFromGrid()
        MsgBox("0,0 : " & grid(0, 0))
        MsgBox("4,4 : " & grid(4, 4))
    End Sub
End Class
