Public Class Move
    Dim col As Integer
    Dim rw As Integer
    Public val As Integer
    Public Sub New(ByVal val As Integer)
        Me.val = val
    End Sub
    Public Sub New(ByVal val As Integer, ByVal row As Integer, ByVal col As Integer)
        Me.val = val
        Me.rw = row
        Me.col = col
    End Sub
    Property Column() As Integer
        Get
            Return col
        End Get
        Set(ByVal value As Integer)
            col = value
        End Set
    End Property

    Property Row() As Integer
        Get
            Return rw
        End Get
        Set(ByVal value As Integer)
            rw = value
        End Set
    End Property
    Property Value() As Integer
        Get
            Return val
        End Get
        Set(ByVal value As Integer)
            val = value
        End Set
    End Property


End Class
