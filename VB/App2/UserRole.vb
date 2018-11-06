Imports Windows.UI.Xaml.Markup

Public Enum UserRole
    Administrator
    Moderator
    User
    Director
    Manager
    Developer
    Linguist
    ProductManager
End Enum

Public Class UserRoleExtension
    Inherits MarkupExtension

    Protected Overrides Function ProvideValue() As Object
        Return New UserRole()
    End Function
End Class

