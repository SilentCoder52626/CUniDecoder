using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UraniumUI.Icons.MaterialIcons;
using UraniumUI.Resources;
using UraniumUI.Views;

namespace CUniDecoder.Controls
{
    public class CopyButton : StatefulContentView
    {
        public CopyButton()
        {
            HorizontalOptions = LayoutOptions.End;
            VerticalOptions = LayoutOptions.End;
            Margin = 20;
            var copyImageSource = new FontImageSource
            {
                Glyph = MaterialSharp.Content_copy,
                FontFamily = "MaterialRegular",
            };
            copyImageSource.SetAppThemeColor(
                FontImageSource.ColorProperty,
                ColorResource.GetColor("Black"),
                ColorResource.GetColor("White"));

            var img = new Image
            {
                Source = copyImageSource,
                HeightRequest = 20
            };

            Content = img;

            TappedCommand = new Command(async () =>
            {
                await Clipboard.Default.SetTextAsync(TextToCopy);

                img.Source = new FontImageSource
                {
                    Glyph = MaterialSharp.Done,
                    FontFamily = "MaterialRegular",
                    Color = Color.FromArgb("#8BC34A")
                }; ;

                await Task.Delay(1000);

                img.Source = copyImageSource;
            });
        }

        public string TextToCopy { get => (string)GetValue(TextToCopyProperty); set => SetValue(TextToCopyProperty, value); }

        public static readonly BindableProperty TextToCopyProperty = BindableProperty.Create(
            nameof(TextToCopy),
            typeof(string),
            typeof(CopyButton));
    }
}
