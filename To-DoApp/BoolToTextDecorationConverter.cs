using System.Globalization;

namespace To_DoApp;

public class BoolToTextDecorationConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool isCompleted = (bool)value;
        return isCompleted ? TextDecorations.Strikethrough : TextDecorations.None;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is TextDecorations decorations && decorations == TextDecorations.Strikethrough;
    }
}