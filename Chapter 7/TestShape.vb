Module TestShape

    Sub Main()

        Dim myCircle As New Circle()
        Dim myRectangle As New Rectangle()

        myCircle.draw()
        myRectangle.draw()

        System.Console.ReadLine()

    End Sub

End Module
Public MustInherit Class Shape

    Public MustOverride Function draw()

End Class
Public Class Circle

    Inherits Shape

    Public Overrides Function draw()

        System.Console.WriteLine("I am drawing a Circle")

    End Function

End Class
Public Class Rectangle

    Inherits Shape

    Public Overrides Function draw()

        System.Console.WriteLine("I am drawing a Rectangle")

    End Function

End Class
Public Class Star

    Inherits Shape

    Public Overrides Function draw()

        System.Console.WriteLine("I am drawing a Star")

    End Function

End Class
Public Class Triangle

    Inherits Shape

    Public Overrides Function draw()

        System.Console.WriteLine("I am drawing a Triangle")

    End Function

End Class