using TestProject.Figures;

namespace TestProject
{
    public partial class Form1 : Form
    {
        private const double _angle = 1.0472;
        private Panel? _firstPanel = null;
        private Panel? _secondPanel = null;
        private List<Connector> _connectors = new List<Connector>();

        public Form1()
        {
            InitializeComponent();
            ControlMoverOrResizer.Init(panel1);
            ControlMoverOrResizer.Init(panel2);
            ControlMoverOrResizer.Init(panel3);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Figure circle = new Circle(panel1.Height <= panel1.Width ? panel1.Height / 2 : panel1.Width / 2, Color.Black, Color.Black, new Point(0, 0));
            // Draw rectangle to show borderds of the panel
            e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0, panel1.Width - 1, panel1.Height - 1);
            circle.Draw(e.Graphics);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Figure triangle = new EquilateralTriangle(_angle, panel2.Height <= panel2.Width ? panel2.Height : panel2.Width, Color.Black, Color.Black, new Point(0, 0));
            // Draw rectangle to show borderds of the panel
            e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0, panel2.Width - 1, panel2.Height - 1);

            triangle.Draw(e.Graphics);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Figure rectangle = new Figures.Rectangle(panel3.Height - 1, panel3.Width - 1, Color.Black, Color.Black, new Point(0, 0));
            rectangle.Draw(e.Graphics);
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (_firstPanel == null)
                _firstPanel = panel1;
            else
                _secondPanel = panel1;

            if (_firstPanel != null && _secondPanel != null)
            {
                _connectors.Add(new Connector(_firstPanel, _secondPanel));

                _firstPanel = null;
                _secondPanel = null;

                this.Invalidate();
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (_firstPanel == null)
                _firstPanel = panel2;
            else
                _secondPanel = panel2;

            if (_firstPanel != null && _secondPanel != null)
            {
                _connectors.Add(new Connector(_firstPanel, _secondPanel));

                _firstPanel = null;
                _secondPanel = null;

                this.Invalidate();
            }
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            if (_firstPanel == null)
                _firstPanel = panel3;
            else
                _secondPanel = panel3;

            if (_firstPanel != null && _secondPanel != null)
            {
                _connectors.Add(new Connector(_firstPanel, _secondPanel));

                _firstPanel = null;
                _secondPanel = null;

                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Connector connector in _connectors)
            {
                connector.Draw(e.Graphics);
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            this.Invalidate();
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            panel2.Invalidate();
            this.Invalidate();
        }

        private void panel3_SizeChanged(object sender, EventArgs e)
        {
            panel3.Invalidate();
            this.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Connector connector in _connectors)
            {
                if (connector.FirstPanel.Name == "panel1")
                    connector.FirstPanel.Location = panel1.Location;
                else if (connector.SecondPanel.Name == "panel1")
                    connector.SecondPanel.Location = panel1.Location;
            }
            this.Invalidate();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Connector connector in _connectors)
            {
                if (connector.FirstPanel.Name == "panel2")
                    connector.FirstPanel.Location = panel2.Location;
                else if (connector.SecondPanel.Name == "panel2")
                    connector.SecondPanel = panel2;
            }
            this.Invalidate();
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Connector connector in _connectors)
            {
                if (connector.FirstPanel.Name == "panel3")
                    connector.FirstPanel = panel3;
                else if (connector.SecondPanel.Name == "panel3")
                    connector.SecondPanel = panel3;
            }
            this.Invalidate();
        }
    }
}