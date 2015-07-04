using System;

using Xamarin.Forms;

namespace ImageSample
{
    public class Image_AspectAll_LayoutFillPage : ContentPage
    {
        /// <summary>
        /// Aspect : 全種類比較
        /// Layout : 
        ///     ・表示位置 : 画面中心
        ///     ・サイズ : デフォルト
        /// </summary>
        public Image_AspectAll_LayoutFillPage()
        {
            // 背景色の設定
            BackgroundColor = Color.White;

            // 全体のレイアウト
            // レイアウトにスケールをかけているので、レイアウトの中のもの全てにスケールがかかる
            var stackLayout = new StackLayout
            {
                // 縦は真ん中に表示
                VerticalOptions = LayoutOptions.Center,
                // 横は画面全体に広げる
                HorizontalOptions = LayoutOptions.FillAndExpand,
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


