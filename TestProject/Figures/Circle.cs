namespace TestProject.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(int radius, Color figureColor, Color fillColor, Point position)
        {
            Radius = radius;
            FigureColor = figureColor;
            FillColor = fillColor;
            Position = position;
            Height = radius * 2;
            Width = radius * 2;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(FigureColor), Position.X, Position.Y, Width, Height);
            gr.FillEllipse(new SolidBrush(FillColor), Position.X, Position.Y, Width, Height);
        }

        public override bool IsDotInFigure(Point point) =>
            Math.Pow((int)(Position.X + Radius / 2) - point.X, 2) + Math.Pow((int)(Position.Y + Radius / 2) - point.Y, 2)
                <= Radius * Radius ? true : false;
        
    }
}
