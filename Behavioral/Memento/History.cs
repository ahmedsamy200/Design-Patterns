using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class History
    {
        List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            var result = states.LastOrDefault();
            states.Remove(result);
            return result;
        }

    }
}
