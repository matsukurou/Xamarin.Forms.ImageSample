using System;

using Xamarin.Forms;

namespace ImageSample
{
    public class ImagePage : ContentPage
    {
        public ImagePage()
        {
            // Imageビューの生成
            var image = new Image
            {
                // 画像を読み込んでSourceプロパティに設定
                Source = ImageSource.FromResource("ImageSample.Resources.Images.button_leftArrow.png"),
            };
            
            Content = new StackLayout
            { 
                // 画面中央からレイアウト
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    image,
                }
            };
        }
    }
}


