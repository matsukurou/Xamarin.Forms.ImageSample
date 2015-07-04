using System;

using Xamarin.Forms;

namespace ImageSample
{
    public class Image_AspectAll_LayoutDefaultPage : ContentPage
    {
        /// <summary>
        /// Aspect : 全種類比較
        /// Layout : 
        ///     ・表示位置 : 画面中心
        ///     ・サイズ : デフォルト
        /// </summary>
        public Image_AspectAll_LayoutDefaultPage()
        {
            // 背景色の設定
            BackgroundColor = Color.White;

            // 全体のレイアウト
            var stackLayout = new StackLayout
            {
                // 縦は真ん中に表示
                VerticalOptions = LayoutOptions.Center,
                // 横は真ん中に表示
                HorizontalOptions = LayoutOptions.Center,
                // 背景色を設定
                BackgroundColor = Color.White,
                // スペースを設定
                Spacing = 30,
            };

            // Aspectを全てさらう
            foreach (Aspect aspect in Enum.GetValues(typeof(Aspect)))
            {
                // Aspect文字表示用のラベル
                var label = new Label
                {
                    // Aspectを文字表示
                    Text = aspect.ToString(),
                    // テキストのカラーを設定
                    TextColor = Color.Black,
                    // 中心表示にする
                    HorizontalOptions = LayoutOptions.Center,
                    // フォントサイズを設定
                    FontSize = 30,
                };
                
                // 画像
                var image = new Image
                {
                    // 画像を読み込んでSourceプロパティに設定
                    Source = ImageSource.FromResource("ImageSample.Resources.Images.icon_A.png"),
                    // 背景色を設定
                    BackgroundColor = Color.Green,
                    // アスペクトを設定
                    Aspect = aspect,
                };

                // ラベルと画像をレイアウト
                // レイアウトの幅は、ラベルの幅と画像の幅を比較して大きい方の幅になる。
                // ラベルの幅の方が大きくなった場合、このページの趣旨と異なるので注意(画像の幅が変わる)。
                var layout = new StackLayout
                {
                    Children =
                    {
                        label,
                        image,
                    },
                };

                stackLayout.Children.Add(layout);
            }

            // コンテントにレイアウトを設定
            Content = stackLayout;
        }
    }
}


