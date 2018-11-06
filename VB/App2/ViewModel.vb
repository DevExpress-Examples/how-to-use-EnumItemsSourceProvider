Imports DevExpress.Mvvm

Public Class ViewModel
    Inherits ViewModelBase

    Protected _Users As ObservableCollection(Of User)

    Public ReadOnly Property Users As ObservableCollection(Of User)
        Get

            If Me._Users Is Nothing Then
                Me._Users = New ObservableCollection(Of User)() From {
                    New User(0, "Jack", UserRole.Administrator),
                    New User(1, "Ron", UserRole.User),
                    New User(2, "John", UserRole.User),
                    New User(3, "Antoni", UserRole.User),
                    New User(4, "Paul", UserRole.Moderator)
                }
            End If

            Return Me._Users
        End Get
    End Property

    Protected _SelectedRole As UserRole

    Public Property SelectedRole As UserRole
        Get
            Return Me._SelectedRole
        End Get
        Set(ByVal value As UserRole)
            Me.SetProperty(Me._SelectedRole, value, "SelectedRole")
        End Set
    End Property
End Class
