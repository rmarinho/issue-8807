namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
}

public class SampleView : GraphicsView
{
    public SampleView()
    {
        Drawable = new EllipseDrawable();
    }

    protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
    {
        return new Size(widthConstraint, heightConstraint);
    }
}

public class EllipseDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        Rect ellipseBounds = new Rect(dirtyRect.Center, new Size(30));
        canvas.FillColor = Colors.Blue;
        canvas.SetShadow(new SizeF(0f, 10f), 10f, Colors.Red);
        canvas.DrawString("Welcome to MAUI !!!", 10, 50, HorizontalAlignment.Left);
        canvas.FillEllipse(ellipseBounds);
    }
}

