Public Class Math

    Function swap(ByVal a As Integer, ByVal b As Integer)

        Dim temp As Integer

        temp = a
        a = b
        b = temp

        Return temp

    End Function

End Class

Module Module1

    Sub Main()

        Dim myMath As New Math()
        myMath.swap(2, 3)

        System.Console.ReadLine()

    End Sub

End Module

