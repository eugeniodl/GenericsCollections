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
                { "mouse", "Un mouse de computadora es un dispositivo de entrada de hardware portátil que controla un cursor en una GUI (interfaz gráfica de usuario) y puede mover y seleccionar texto." },
                { "keyboard", "Un keyboard o teclado es uno de los principales dispositivos de entrada que se utilizan con una computadora. Al igual que una máquina de escribir eléctrica, un teclado se compone de botones." },
                { "laptop", "Una laptop es una computadora personal pequeña y portátil con una pantalla y un teclado alfanumérico."},
                { "Java", "Java es un lenguaje de programación de alto nivel, basado en clases y orientado a objetos que está diseñado para tener el menor número posible de dependencias de implementación." },
                { "c++", "C++ es un potente lenguaje de programación de uso general. Se puede utilizar para desarrollar sistemas operativos, navegadores, juegos, etc." },
                { "python", "Python es un lenguaje de programación interpretado de alto nivel de propósito general. Su filosofía de diseño enfatiza la legibilidad del código." },
                { "html", "El lenguaje de marcado de hipertexto o HTML es el lenguaje de marcado estándar para documentos diseñados para mostrarse en un navegador web." },
                { "css", "Las hojas de estilo en cascada son un lenguaje de hojas de estilo que se utiliza para describir la presentación de un documento escrito en un lenguaje de marcado como HTML." },
                { "programming", "La programación informática es el proceso de diseñar y construir un programa informático ejecutable para lograr un resultado informático específico." },
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
