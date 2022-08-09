namespace TestProject.Figures
{
    public abstract class Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Color FigureColor { get; set; }
        public Color FillColor { get; set; }
        public Point Position { get; set; }
        public abstract void Draw(Graphics gr);
        public abstract bool IsDotInFigure(Point point);
    }
}
                