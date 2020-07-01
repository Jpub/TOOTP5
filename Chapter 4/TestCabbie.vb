Module TestCabbie

    Sub Main()

        Dim joe As New Cabbie("Joe", 1234)

        joe.Name = "joe"

        Console.WriteLine(joe.Name)

        Console.ReadLine()

    End Sub

End Module
Public Class Cabbie

    Dim _Name As String

    Sub New()

        _Name = ""

    End Sub

    Sub New(ByVal name As String, ByVal serialNumber As String)

        _Name = name
        Dim myCab As New Cab(serialNumber)

    End Sub

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property


End Class
Public Class Cab

    Dim _SerialNumber As String

    Sub New(ByVal val As String)

        serialNumber = val

    End Sub
    
    'SerialNumber is public for get and private for set
    Public Property SerialNumber() As String
        Get
            Return _SerialNumber
        End Get
        Private Set(ByVal value As String)
            _SerialNumber = value
        End Set
End Property

End Class
