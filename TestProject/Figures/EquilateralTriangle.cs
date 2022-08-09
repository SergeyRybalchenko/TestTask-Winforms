namespace TestProject.Figures
{
    public class EquilateralTriangle : Figure
    {
        public double Angle { get; set; }
        public int Side { get; set; }

        public EquilateralTriangle(double angle, int side, Color figureColor, Color fillColor, Point position)
        {
            Angle = angle;
            Side = side;
            FigureColor = figureColor;
            FillColor = fillColor;
            Position = position;
            Height = Side;
            Width = (int)(Side * Math.Sqrt(3) / 2);
        }

        public override void Draw(Graphics gr)
        {
            var points = new Point[3]
            {
                new Point(Position.X, Position.Y),
                new Point(Position.X, Side),
                new Point((int)(Side * Math.Sin(Angle)), Side / 2)
            };

            gr.DrawPolygon(new Pen(FigureColor), points);
            gr.FillPolygon(new SolidBrush(FillColor), points);
        }

        public override bool IsDotInFigure(Point point)
        {
            return point.X > Position.X && point.Y > Position.Y && point.X < Position.X + Width && point.Y < Position.Y + Height ? true : false;
        }
    }
}
