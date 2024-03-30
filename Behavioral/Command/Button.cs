using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Button
    {
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}
