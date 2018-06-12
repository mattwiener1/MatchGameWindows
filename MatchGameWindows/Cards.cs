using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MatchingGame.ENUMs;
using System.Threading.Tasks;

namespace MatchingGame
{
    class Cards
    {
        public int Width { get; set; } = 5;
        public string Color { get; set; }
        public int Height { get; set; } = 8;


        public static string SetColor()
        {
            Random cardColor = new Random();
            System.Threading.Thread.Sleep(1000);
            return Enum.GetName(typeof(Colors), cardColor.Next(0, 4));
        }

        public static List<Cards> NewCards(int howMany)
        {
            var cards = new List<Cards>();
            do
            {
                if (howMany % 2 != 0 || howMany == 2)
                {
                    Console.WriteLine("Please enter a valid starting number. Numbers must be even, and cannot be the number 2");
                    var test = Console.ReadLine();

                    if (!(Int32.TryParse(test, out howMany)))
                    {
                        howMany = 3;
                    }

                }
            } while (howMany % 2 != 0 || howMany == 2);
            
            howMany = howMany / 2;

            for (var i = 0; i <= howMany - 1; i++)
            {
                var card = new Cards();
                card.Color = SetColor();
                cards.Add(card);
                cards.Add(card);
            }


            return cards;
        }

        
        
    }

    public class CardLocation
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int CardNumber { get; set; }

        public static List<CardLocation> PointsList(int howMany)
        {

            var xSpacing = Console.BufferWidth / (howMany / 2);
            var xCentered = xSpacing / 2;
            var ySpacing = 80 / 2;
            var yCentered = ySpacing / 2;

            var points = new List<CardLocation>();
            for (var i = 0; i <= howMany; i++)
            {
                
            }

            return points;
        }


    }
}

