using System;
using System.Text;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args) 
    {
      // var price = 10.2;
      // var text = "O preço do produto é: " + price;
      // var text = string.Format("O preço do produto é {0} apenas na promoção.", price);
      // var text = $"O preço do produto é: {price}";
      // var text = $@"O preço do 
      // produto é: {price}";

      // Console.WriteLine(text);

      // ===============================================
      // var text = "Testando";
      // Console.WriteLine(text.CompareTo("Testando"));
      // Console.WriteLine(text.CompareTo("testando"));
      // Console.WriteLine(text.Contains("Tando", StringComparison.OrdinalIgnoreCase));
      // Console.WriteLine(text.Contains(null));

      // ===============================================

      // var text = "Este é um texto de teste.";

      // Console.WriteLine(text.StartsWith("Este"));
      // Console.WriteLine(text.StartsWith("este"));
      // Console.WriteLine(text.StartsWith("este",StringComparison.OrdinalIgnoreCase));
      // Console.WriteLine(text.StartsWith("texto"));

      // Console.WriteLine(text.EndsWith("teste."));
      // Console.WriteLine(text.EndsWith("Test"));
      // Console.WriteLine(text.EndsWith("xpto"));

      // Console.WriteLine(text.Equals("Este é um texto de teste."));
      // Console.WriteLine(text.Equals("este é um texto de teste."));
      // Console.WriteLine(text.Equals("este é um texto de teste.", StringComparison.OrdinalIgnoreCase));

      // ===============================================

      // var text = " Este é um texto de teste. ";

      // Console.WriteLine(text.IndexOf("é"));
      // Console.WriteLine(text.LastIndexOf("s"));
      // Console.WriteLine(text.ToUpper());
      // Console.WriteLine(text.ToLower());
      // Console.WriteLine(text.Insert(5, "aqui "));
      // Console.WriteLine(text.Remove(5, 5));
      // Console.WriteLine(text.Length);
      // Console.WriteLine(text.Replace("Este", "Isto"));
      // var division = text.Split(" ");
      // Console.WriteLine(division[0]);
      // Console.WriteLine(division[1]);
      // Console.WriteLine(division[2]);
      // Console.WriteLine(division[3]);
      // Console.WriteLine(division[4]);
      // Console.WriteLine(division[5]);

      // var result = text.Substring(5, 5);
      // var result = text.Substring(5, text.LastIndexOf("o"));
      // Console.WriteLine(result);
      
      // Console.WriteLine(text.Trim());

      // ===============================================

      var text = new StringBuilder();
      text.Append("Este é ");
      text.Append("um texto ");
      text.Append("de teste.");

      Console.WriteLine(text);
    }
  }
}