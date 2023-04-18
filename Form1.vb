Public Class frmBill
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblSavings.Text = ""
        lblAverageSavings.Text = ""
        lblMaxSavings.Text = ""
        If IO.File.Exists("C:\Users\evanm\Desktop\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\Users\evanm\Desktop\savings.txt")
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonths.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("This file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        Dim intSelectedCityIndex As Integer

        intSelectedCityIndex = cboMonths.SelectedIndex
        lblSavings.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
        btnStatistics.Visible = True
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ComputeAverage()
        ComputeMaxSavings()

    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblMaxSavings.Text = strYearValue & " had the most significant monthly savings"
    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill = +_decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverageSavings.Text = "The average monthly savings: " & decAverageNumberOfBill.ToString("C2")

    End Sub
End Class
