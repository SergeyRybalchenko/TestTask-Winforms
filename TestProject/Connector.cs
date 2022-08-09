using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Connector
    {
        public Panel FirstPanel { get; set; }
        public Panel SecondPanel { get; set; }

        public Connector(Panel firstPanel, Panel secondPanel)
        {
            FirstPanel = firstPanel;
            SecondPanel = secondPanel;
        }
        
        public void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color.Black),
                new Point(FirstPanel.Location.X + FirstPanel.Width / 2,
                          FirstPanel.Location.Y + FirstPanel.Height / 2),
                new Point(SecondPanel.Location.X + SecondPanel.Width / 2,
                          SecondPanel.Location.Y + SecondPanel.Height / 2));
        }
    }
}
