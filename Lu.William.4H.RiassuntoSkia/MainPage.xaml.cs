using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;

namespace Lu.William._4H.RiassuntoSkia
{
    public partial class MainPage : ContentPage
    {

        public int margineSinistro { get; set; } = 100;
        public int margineSopra { get; set; } = 100;
        public int larghezzaRettangolo { get; set; } = 100;
        public int altezzaRettangolo { get; set; } = 100;

        public MainPage()
        {
            InitializeComponent();
        }

        void btnDisegna_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        void Tela_PaintSurface(System.Object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            var info = e.Info;
            var canvas = e.Surface.Canvas;
            canvas.Clear();

            int larghezza = info.Rect.Width;
            int altezza = info.Rect.Height;

            SKPath rettangolo = AreaDiDisegno();
            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Black,
                StrokeWidth = 3
            };
            canvas.DrawPath(rettangolo, paint);
            Tela.InvalidateSurface();
        }
        SKPath AreaDiDisegno()
        {
            SKPath rettangolo = new SKPath();
            rettangolo.MoveTo(margineSinistro, margineSopra);

            rettangolo.LineTo(200, 100);
            rettangolo.LineTo(200, 300);
            rettangolo.LineTo(100, 300);
            rettangolo.LineTo(100, 100);

            return rettangolo;
        }
    }

}
