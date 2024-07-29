using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Líquido" },
                    new Alternativa { Correta = true, Descricao = "Sólido" },
                    new Alternativa { Correta = false, Descricao = "Gasoso" },
                    new Alternativa { Correta = false, Descricao = "Vaporoso" },
                }
            }
        };
    }
}
