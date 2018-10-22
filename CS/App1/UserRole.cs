﻿using Windows.UI.Xaml.Markup;

namespace App1
{
    public enum UserRole
    {
        Administrator,
        Moderator,
        User,
        Director,
        Manager,
        Developer,
        Linquist,
        ProductManager
    }

    public class UserRoleExtension: MarkupExtension
    {
        protected override object ProvideValue()
        {
            return new UserRole();
        }
    }
}
