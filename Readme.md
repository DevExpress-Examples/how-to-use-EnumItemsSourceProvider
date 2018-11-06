
# How to use EnumItemsSourceProvider

**EnumItemsSourceProvider** allows you to generate a list of values based on your custom Enum data type. This provider generates such a list based on an object you use in its **EnumInstance** property.

To show only certain values from your Enum data type, you need to define them separated by the space, comma, or semicolon symbol in the **WhiteList** property.

* **C#:**
```cs
public enum UserRole { Administrator, Moderator, User, Director, Manager, Developer, Linguist, ProductManager }

public class UserRoleExtension: MarkupExtension {
    protected override object ProvideValue(){
        return new UserRole();
    }
}
```

* **XAML:**
```xaml
<dx:EnumItemsSourceProvider x:Key="RolesSource"
                      WhiteList="Administrator,Moderator,User"
                      EnumInstance="{local:UserRole}"/>
```
