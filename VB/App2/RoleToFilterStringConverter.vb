Imports DevExpress.Data.Filtering
Imports Windows.UI.Xaml.Markup

Public Class RoleToFilterStringConverter
    Inherits MarkupExtension
    Implements IValueConverter

    Protected Overrides Function ProvideValue() As Object
        Return Me
    End Function

    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal language As String) As Object Implements IValueConverter.Convert
        Return CriteriaOperator.Parse("[Role] == ?", value)
    End Function

    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal language As String) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class

