Public Class Node
    Dim nodeparent As Node
    Dim mv As Move
    Dim cnode As Integer
    Dim lstnodes As List(Of Node)
    Public Sub New()
        lstnodes = New List(Of Node)
        cnode = 0
    End Sub
    Public Function GetParent() As Node
        Return nodeparent
    End Function
    Public Function GetChildCount() As Integer
        Return lstnodes.Count
    End Function
    Public Function FirstChild() As Node
        cnode = 0
        Return lstnodes(cnode)
    End Function
    Public Function LastChild() As Node
        cnode = lstnodes.Count - 1
        Return lstnodes(cnode)
    End Function
    Public Sub AddChild(ByVal n As Node)
        lstnodes.Add(n)
    End Sub
    Public Function NextChild() As Node
        cnode += 1
        Return lstnodes(cnode)
    End Function
    Public Sub SetMove(ByVal mv As Move)
        Me.mv = mv

    End Sub
    Public Function GetMove() As Move
        Return mv
    End Function
End Class
