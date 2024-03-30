using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class Canvas
    {
        private ITool toolType;

        public void SetTool(ITool tool)
        {
            toolType = tool;
        }

        public ITool GetTool()
        {
            return toolType;
        }

        public void MouseDown()
        {
            toolType.MouseDown();
        }

        public void MouseUp()
        {
            toolType.MouseUp();
        }
    }
}
