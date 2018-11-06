Imports DevExpress.Mvvm

Public Class User
    Inherits BindableBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal role As UserRole)
        name = name
        id = id
        role = role
    End Sub

    Protected _ID As Integer

    Public Property ID As Integer
        Get
            Return Me._ID
        End Get
        Set(ByVal value As Integer)
            Me.SetProperty(Me._ID, value, "ID")
        End Set
    End Property

    Protected _Name As String

    Public Property Name As String
        Get
            Return Me._Name
        End Get
        Set(ByVal value As String)
            Me.SetProperty(Me._Name, value, "Name")
        End Set
    End Property

    Protected _Role As UserRole

    Public Property Role As UserRole
        Get
            Return Me._Role
        End Get
        Set(ByVal value As UserRole)
            Me.SetProperty(Me._Role, value, "Role")
        End Set
    End Property
End Class

