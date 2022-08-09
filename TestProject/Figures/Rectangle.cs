namespace TestProject.Figures
{
    public class Rectangle : Figure
    {
        public Rectangle(int height, int width, Color figureColor, Color fillColor, Point position)
        {
            Height = height;
            Width = width;
            FigureColor = figureColor;
            Position = position;
            FillColor = fillColor;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(FigureColor), Position.X, Position.Y, Width, Height);
            gr.FillRectangle(new SolidBrush(FillColor), Position.X, Position.Y, Width, Height);
        }

        public override bool IsDotInFigure(Point point)
            => point.X > Position.X && point.Y > Position.Y && point.X < Position.X + Width && point.Y < Position.Y + Height ? true : false;

    }
}
