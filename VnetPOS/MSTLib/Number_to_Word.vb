
Public Module Number_to_Word

    Dim Words As String
    Dim getw As String
    Dim num As Integer
    Function numtoword(ByVal num As String) As String
        If Val(num) <> 0 Then
            numtoword = ConvertNumerToWords(num) & " only"

        Else
            numtoword = "Zero"
        End If
    End Function

    Private Function GetDivideby(ByVal len1 As Byte) As Long
        Select Case len1
            Case 1, 2 : GetDivideby = 1
            Case 3, 3 : GetDivideby = 100 : getw = " Hundred"
            Case 4, 5 : GetDivideby = 1000 : getw = " Thousand"
            Case 6, 7 : GetDivideby = 100000 : getw = " Lac"
            Case 8, 9 : GetDivideby = 10000000 : getw = " Crore"
        End Select
    End Function

    Private Function ConvertNumerToWords(ByVal NumberToConvert As String) As String
        On Error Resume Next
        Dim divideby As Long, Remainder As Long, Quotient As Long, dividend As Long
        Dim Quotient1 As String, Remainder1 As String, textcontent() As String

        textcontent = Split(NumberToConvert, ".")
        Remainder = Val(textcontent(0))
        Remainder1 = Remainder
        Do While Val(Remainder1) > 0
            dividend = Remainder
            divideby = GetDivideby(Len(Remainder1))

            Quotient = dividend \ divideby
            Quotient1 = Quotient

            wordings(Quotient1)

            Words = Words & getw
            getw = ""
            Remainder = dividend Mod divideby
            Remainder1 = Remainder
        Loop

        If UBound(textcontent) = 1 Then
            If Len(textcontent(1)) = 1 Then
                Words = Words & " Rupees and" & Getsinglenumber(Val(textcontent(1))) & " Paise"
            ElseIf Len(textcontent(1)) = 2 Then
                Words = Words & " Rupees and" & Getty(Left(textcontent(1), 1))
                Words = Words & Getsinglenumber(Right(textcontent(1), 1)) & " Paise"
            End If
        End If

        ConvertNumerToWords = Words
        Words = ""
    End Function

    Private Function wordings(ByVal common As String) As String
        If Val(common) < 20 Then
            Words = Words & Getsinglenumber(Val(common))
        Else
            Words = Words & Getty(Left(common, 1))
            Words = Words & Getsinglenumber(Right(common, 1))
        End If
        Return Words
    End Function

    Private Function Getsinglenumber(ByVal number As Long) As String
        Dim Str As String = ""
        Select Case number
            Case 1 : Str = " One"
            Case 2 : Str = " Two"
            Case 3 : Str = " Three"
            Case 4 : Str = " Four"
            Case 5 : Str = " Five"
            Case 6 : Str = " Six"
            Case 7 : Str = " Seven"
            Case 8 : Str = " Eight"
            Case 9 : Str = " Nine"
            Case 10 : Str = " Ten"
            Case 11 : Str = " Eleven"
            Case 12 : Str = " Twelve"
            Case 13 : Str = " Thirteen"
            Case 14 : Str = " Fourteen"
            Case 15 : Str = " Fifteen"
            Case 16 : Str = " Sixteen"
            Case 17 : Str = " Seventeen"
            Case 18 : Str = " Eighteen"
            Case 19 : Str = " Nineteen"
        End Select
        Return Str
    End Function

    Private Function Getty(ByVal number As Long) As String
        Dim Str As String = ""
        Select Case number
            Case 2 : Str = " Twenty"
            Case 3 : Str = " Thirty"
            Case 4 : Str = " Forty"
            Case 5 : Str = " Fifty"
            Case 6 : Str = " Sixty"
            Case 7 : Str = " Seventy"
            Case 8 : Str = " Eighty"
            Case 9 : Str = " Ninty"
        End Select
        Return Str
    End Function


End Module
