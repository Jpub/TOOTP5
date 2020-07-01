Module Module1

    Sub Main()

        Dim myShop As New DonutShop()
        Dim inventory() As String
        Dim ival As Integer

        System.Console.WriteLine("Instantiate the DonutShop class")

        inventory = myShop.getInventory()

        For ival = 0 To 4

            System.Console.Write("Argument ")
            System.Console.Write(ival)
            System.Console.Write(" = ")
            System.Console.WriteLine(inventory(ival))

        Next

        myShop.buyInventory(inventory(1))

        System.Console.ReadLine()

    End Sub

End Module
Public MustInherit Class Shop

    Public Function CalculateSaleTax()

        System.Console.WriteLine("Calculate Sales Tax")
        Return Nothing

    End Function

    Public MustOverride Function getInventory() As String()
    Public MustOverride Function buyInventory(ByVal i As String)

End Class
Interface Nameable

    Function getName() As String
    Function setName(ByVal n As String)

End Interface
Public Class DonutShop

    Inherits Shop
    Implements Nameable

    Dim name As String

    Dim companyName As String

    Dim menuItems() As String = {"Donuts", "Muffins", "Danish", "Coffee", "Tea"}

    Public Overrides Function getInventory() As String()

        Return menuItems

    End Function

    Public Overrides Function buyInventory(ByVal item As String)

        System.Console.WriteLine("You have just purchased " + item)

        Return Nothing

    End Function

    Function getName() As String Implements Nameable.getName

        Return name

    End Function

    Function setName(ByVal n As String) Implements Nameable.setName

        name = n

        Return Nothing

    End Function

End Class