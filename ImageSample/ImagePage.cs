using System;

using Xamarin.Forms;

namespace ImageSample
{
    public class ImagePage : ContentPage
    {
        public ImagePage()
        {
            // 背景色の設定
            BackgroundColor = Color.White;

            // Imageビューの生成
            var image = new Image
            {
                // 画像を読み込んでSourceプロパティに設定
                Source = ImageSource.FromResource("ImageSample.Resources.Images.icon_A.png"),
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


