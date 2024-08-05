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
            },
             new Pergunta
            {
                Id = 2,
                Enunciado = "Em qual Estado nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "RIO DE JANEIRO" },
                    new Alternativa { Correta = true, Descricao = "RIO GRANDE DO SUL" },
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA" },
                    new Alternativa { Correta = false, Descricao = "GOIÁS" },
                }
             },
              new Pergunta
              {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "GAUCHINHA" },
                    new Alternativa { Correta = true, Descricao = "PAULISTINHA" },
                    new Alternativa { Correta = false, Descricao = "PIMENTINHA" },
                    new Alternativa { Correta = false, Descricao = "ANDORINHA" },
                }
              },
               new Pergunta
               {
                  Id = 4,
                  Enunciado = "Quem é a namorada do Mickey?",
                  Alternativas = new()
                  {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA" },
                    new Alternativa { Correta = true, Descricao = "MINNIE" },
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA" },
                    new Alternativa { Correta = false, Descricao = "OLIVIA PALITO" },
                  }
               },
               new Pergunta
               {
                   Id = 5,
                   Enunciado = "Quem é o personagem do folclore brasileiro que tem apenas uma perna?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "CUCA"},
                       new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                       new Alternativa {Correta = false, Descricao = "BOITATÁ"},
                       new Alternativa {Correta = false, Descricao = "SACI-PEREÊ"},
                   }
               },
               new Pergunta
               {
                   Id = 6,
                   Enunciado = "Quem proclamou a republica no Brasil em 1889?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                       new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
                       new Alternativa {Correta = false, Descricao = "DOM PREDO II"},
                       new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO"},
                   }
               },
               new Pergunta
               {
                   Id = 7,
                   Enunciado = "Quem é o patrono do exercio brasileiro?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO"},
                       new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ"},
                       new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                       new Alternativa {Correta = false, Descricao = "MASQUÊS DE POMBAL"},
                   }
               },
               new Pergunta
               {
                   Id = 8,
                   Enunciado = "Quem era o apresentador que reprovava os calouros com uma buZina?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "RAUL GIL"},
                       new Alternativa {Correta = false, Descricao = "BOLINHA"},
                       new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALGANTI"},
                       new Alternativa {Correta = false, Descricao = "CHACRINHA"},
                   }
               },
               new Pergunta
               {
                   Id = 9,
                   Enunciado = "O que era o Frankenstein, de Mary Shelley?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "MONSTRO"},
                       new Alternativa {Correta = false, Descricao = "GORILA"},
                       new Alternativa {Correta = false, Descricao = "PRÍNCIPE"},
                       new Alternativa {Correta = false, Descricao = "SAPO"},
                   }
               },
               new Pergunta
               {
                   Id = 10,
                   Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano novo?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "VIRGEM"},
                       new Alternativa {Correta = false, Descricao = "AQUARIO"},
                       new Alternativa {Correta = false, Descricao = "CAPRICORNIO"},
                       new Alternativa {Correta = false, Descricao = "ARIES"},
                   }
               },
               new Pergunta
               {
                   Id = 11,
                   Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "HERRISON FORD"},
                       new Alternativa {Correta = false, Descricao = "GERALD FORD"},
                       new Alternativa {Correta = false, Descricao = "HENRY FORD"},
                       new Alternativa {Correta = false, Descricao = "ANNA FORD"},
                   }
               },
               new Pergunta
               {
                   Id = 12,
                   Enunciado = "qual é a cor que se associa com os grupos ecológicos?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "PRETA"},
                       new Alternativa {Correta = false, Descricao = "VERMELHA"},
                       new Alternativa {Correta = false, Descricao = "AZUL"},
                       new Alternativa {Correta = false, Descricao = "VERDE"},
                   }
               },
               new Pergunta
               {
                   Id = 13,
                   Enunciado = "A água ferve a quantos graus centígrados?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "200"},
                       new Alternativa {Correta = false, Descricao = "100"},
                       new Alternativa {Correta = false, Descricao = "170"},
                       new Alternativa {Correta = false, Descricao = "220"},
                   }
               },
               new Pergunta
               {
                   Id = 14,
                   Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "21 de abril"},
                       new Alternativa {Correta = false, Descricao = "12 de outubro"},
                       new Alternativa {Correta = false, Descricao = "7 de setembro"},
                       new Alternativa {Correta = false, Descricao = "25 de dezembro"},
                   }
               },
               new Pergunta
               {
                   Id = 15,
                   Enunciado = "Qual lugar é também chamado de Santa Sé?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "VENEZA"},
                       new Alternativa {Correta = false, Descricao = "VITÓRIA"},
                       new Alternativa {Correta = false, Descricao = "VANCOUVER"},
                       new Alternativa {Correta = false, Descricao = "VATICANO"},
                   }
               },
               new Pergunta
               {
                   Id = 16,
                   Enunciado = "Quem tem por lema a frase: 'Sempre alerta'?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "MÉDICOS"},
                       new Alternativa {Correta = false, Descricao = "ESCOTEIROS"},
                       new Alternativa {Correta = false, Descricao = "BOMBEIROS"},
                       new Alternativa {Correta = false, Descricao = "POLICIAIS"},
                   }
               },
               new Pergunta
               {
                   Id = 17,
                   Enunciado = "Quem foi o grande amor de Juliaeta?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "ROMEU"},
                       new Alternativa {Correta = false, Descricao = "ORFEU"},
                       new Alternativa {Correta = false, Descricao = "HAMLET"},
                       new Alternativa {Correta = false, Descricao = "IAGO"},
                   }
               },
               new Pergunta
               {
                   Id = 18,
                   Enunciado = "Quantos signos formam o zodiaco?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "NOVE"},
                       new Alternativa {Correta = false, Descricao = "DEZ"},
                       new Alternativa {Correta = false, Descricao = "ONZE"},
                       new Alternativa {Correta = false, Descricao = "DOZE"},
                   }
               },
               new Pergunta
               {
                   Id = 19,
                   Enunciado = "Quantos signos formam o zodiaco?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "NOVE"},
                       new Alternativa {Correta = false, Descricao = "DEZ"},
                       new Alternativa {Correta = false, Descricao = "ONZE"},
                       new Alternativa {Correta = false, Descricao = "DOZE"},
                   }
               },
               new Pergunta
               {
                   Id = 20,
                   Enunciado = "Vatapá é uma comida tipica de qual estado?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "PARANÁ"},
                       new Alternativa {Correta = false, Descricao = "SANTA CATARINA"},
                       new Alternativa {Correta = false, Descricao = "SÃO PAULO"},
                       new Alternativa {Correta = false, Descricao = "BAHIA"},
                   }
               }

        };
        
        List<Pergunta> perguntas_medias = new()
        {
             new Pergunta
             {
                   Id = 21,
                   Enunciado = "Quantas dentições naturais tem o ser humano durante a vida?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "UMA"},
                       new Alternativa {Correta = false, Descricao = "DUAS"},
                       new Alternativa {Correta = false, Descricao = "TRÊS"},
                       new Alternativa {Correta = false, Descricao = "QUATRO"},
                   }
             },
             new Pergunta
             {
                   Id = 22,
                   Enunciado = "Edinho, Filho do Pelé, jogou no Santos em que posição?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "ZAGUEIRO"},
                       new Alternativa {Correta = false, Descricao = "GOLEIRO"},
                       new Alternativa {Correta = false, Descricao = "ATACANTE"},
                       new Alternativa {Correta = false, Descricao = "ARMADOR"},
                   }
             },
             new Pergunta
             {
                   Id = 23,
                   Enunciado = "Qual é a pedra preciosa mais dura encontrada na natureza?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "ESMERALDA"},
                       new Alternativa {Correta = false, Descricao = "RUBI"},
                       new Alternativa {Correta = false, Descricao = "PÉROLA"},
                       new Alternativa {Correta = false, Descricao = "DIAMANTEW"},
                   }
             },
             new Pergunta
             {
                   Id = 24,
                   Enunciado = "Como se chama o lugar onde se guardam vinhos?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "ADEGA"},
                       new Alternativa {Correta = false, Descricao = "BIBLIOTECA"},
                       new Alternativa {Correta = false, Descricao = "SÓTÃO"},
                       new Alternativa {Correta = false, Descricao = "SALA"},
                   }
             },
             new Pergunta
             {
                   Id = 25,
                   Enunciado = "Qual cantor é conhecido como 'O rei do rock'?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "FRANK SINATRA"},
                       new Alternativa {Correta = false, Descricao = "LITTLE RICHARD"},
                       new Alternativa {Correta = false, Descricao = "ELVIS PRESLEY"},
                       new Alternativa {Correta = false, Descricao = "RICHIE VALENS"},
                   }
             },
             new Pergunta
             {
                   Id = 26,
                   Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "PRIMEIRA DAMA"},
                       new Alternativa {Correta = false, Descricao = "DONA-PRIMA"},
                       new Alternativa {Correta = false, Descricao = "PRIMA-DONA"},
                       new Alternativa {Correta = false, Descricao = "OBRA-PRIMA"},
                   }
             },
             new Pergunta
             {
                   Id = 27,
                   Enunciado = "Peroba é uma especie de?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "INSETO"},
                       new Alternativa {Correta = false, Descricao = "ARVORE"},
                       new Alternativa {Correta = false, Descricao = "VERME"},
                       new Alternativa {Correta = false, Descricao = "VERDURA"},
                   }
             },
             new Pergunta
             {
                   Id = 28,
                   Enunciado = "O alpinismo é praticado em qual lugar?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "MAR"},
                       new Alternativa {Correta = false, Descricao = "MONTANHA"},
                       new Alternativa {Correta = false, Descricao = "RIO"},
                       new Alternativa {Correta = false, Descricao = "PRAIA"},
                   }
             },
             new Pergunta
             {
                   Id = 29,
                   Enunciado = "O coliseu é um monumento histórico de que cidade européia?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "PARIS"},
                       new Alternativa {Correta = false, Descricao = "COPENHAGUE"},
                       new Alternativa {Correta = false, Descricao = "ROMA"},
                       new Alternativa {Correta = false, Descricao = "LONDRES"},
                   }
             },
             new Pergunta
             {
                   Id = 30,
                   Enunciado = "Qual é o ponto mais alto da terra?",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "EVEREST"},
                       new Alternativa {Correta = false, Descricao = "MONTE SINAI"},
                       new Alternativa {Correta = false, Descricao = "MONTE CASTELO"},
                       new Alternativa {Correta = false, Descricao = "MONTE BLANC"},
                   }
             },
             new Pergunta
             {
                   Id = 31,
                   Enunciado = "Que rio corta a cidade de Londres, na Inglaterra ",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = "TÂMISA"},
                       new Alternativa {Correta = false, Descricao = "SENA"},
                       new Alternativa {Correta = false, Descricao = "RENO"},
                       new Alternativa {Correta = false, Descricao = "AUBE"},
                   }
             },
             new Pergunta
             {
                   Id = 32,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 33,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 34,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 35,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 36,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 37,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 38,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 39,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
            new Pergunta
             {
                   Id = 40,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },

        };

        List<Pergunta> perguntas_dificeis = new()
        {
             new Pergunta
             {
                   Id = 41,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 42,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 43,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 44,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 45,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 46,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 47,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 48,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 49,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 50,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 51,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 52,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 53,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 54,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 55,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 56,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 57,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 58,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 59,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
             new Pergunta
             {
                   Id = 60,
                   Enunciado = "",
                   Alternativas = new()
                   {
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                       new Alternativa {Correta = false, Descricao = ""},
                   }
             },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
