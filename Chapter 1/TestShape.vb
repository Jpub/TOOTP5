Module TestShape

    Sub Main()

        Dim myCircle As New Circle(2.2)
        Dim myRectangle As New Rectangle(2.2, 3.3)
        Dim result As Double

        result = myCircle.calcArea()
        System.Console.Write("Circle area =  ")
        System.Console.WriteLine(result)

        result = myRectangle.calcArea()
        System.Console.Write("Rectangle area =  ")
        System.Console.WriteLine(result)

        System.Console.Read()
    End Sub

End Module
Public MustInherit Class Shape

    Protected area As Double

    Public MustOverride Function calcArea() As Double

End Class
Public Class Circle

    Inherits Shape

    Dim radius As Double

    Sub New(ByVal r As Double)

        radius = r

    End Sub

    Public Overrides Function calcArea() As Double

        area = 3.14 * (radius * radius)
        Return area

    End Function

End Class
Public Class Rectangle

    Inherits Shape

    Dim length As Double
    Dim width As Double

    Sub New(ByVal l As Double, ByVal w As Double)

        length = l
        width = w

    End Sub

    Public Overrides Function calcArea() As Double

        area = length * width
        Return area

    End Function

End Class