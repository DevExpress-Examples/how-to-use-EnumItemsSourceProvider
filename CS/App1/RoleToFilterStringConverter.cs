using DevExpress.Data.Filtering;
using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;

namespace App1
{

    public class RoleToFilterStringConverter : MarkupExtension, IValueConverter
    {
        protected override object ProvideValue()
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return CriteriaOperator.Parse("[Role] == ?", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
