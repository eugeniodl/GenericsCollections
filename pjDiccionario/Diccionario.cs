using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjDiccionario
{
    public static class Diccionario
    {
        private static Dictionary<string, string> _diccionario
            = new Dictionary<string, string>()
            {
                { "mouse", "A computer mouse is a handheld hardware input device that controls a cursor in a GUI (graphical user interface) and can move and select text." },
                { "keyboard", "A keyboard is one of the primary input devices used with a computer. Similar to an electric typewriter, a keyboard is composed of buttons" },
                { "laptop", "A laptop, laptop computer, or notebook computer is a small, portable personal computer with a screen and alphanumeric keyboard."},
                { "Java", "Java is a high-level, class-based, object-oriented programming language that is designed to have as few implementation dependencies as possible." },
                { "c++", "C++ is a powerful general-purpose programming language. It can be used to develop operating systems, browsers, games, and so on." },
                { "python", "Python is an interpreted high-level general-purpose programming language. Its design philosophy emphasizes code readability." },
                { "html", "The HyperText Markup Language, or HTML is the standard markup language for documents designed to be displayed in a web browser." },
                { "css", "Cascading Style Sheets is a style sheet language used for describing the presentation of a document written in a markup language such as HTML." },
                { "programming", "Computer programming is the process of designing and building an executable computer program to accomplish a specific computing result." },
            };

        public static string GetSignificado(string palabra)
        {
            try
            {
                return _diccionario[palabra];
            }
            catch
            {

                return "La palabra no se encuentra " +
                    "en el diccionario.";
            }
        }
    }
}
