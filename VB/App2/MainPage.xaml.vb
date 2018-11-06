Imports DevExpress.Data.Filtering
Public NotInheritable Class MainPage
    Inherits Page
    Sub New()
        EnumProcessingHelper.RegisterEnum(GetType(UserRole))
        InitializeComponent()
    End Sub
End Class
