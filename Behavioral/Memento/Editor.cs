using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Editor
    {
        private string content;

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
           return content;
        }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restor(EditorState state)
        {
            content = state.GetContent();
        }
    }
}
