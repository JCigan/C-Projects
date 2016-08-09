using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BLOBForReal
{
    class Program
    {
        [Serializable]
        public class ChessBoard
        {
            public string color = "";
            public double squares = 0;
            public string model = "";
            public double price = 0;

            public override string ToString()
            {
                return String.Format("A {0} chess set has {1} squares, costs {2}, and is the color {3}.", model, squares, price, color);
            }
        }

        static void Main(string[] args)
        {
            ChessBoard theBest = new ChessBoard
            {
                color = "Blue",
                squares = 64,
                model = "Best Ever",
                price = 13.99
            };

            IFormatter formatter = new BinaryFormatter();

            //First I serialize
            Stream stream1 = new FileStream("NewFile.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream1, theBest);
            stream1.Close();

            //Then I deserialize
            Stream stream2 = new FileStream("NewFile.bin", FileMode.Open, FileAccess.Read);
            ChessBoard theNextBest = (ChessBoard)formatter.Deserialize(stream2);
            stream2.Close();

            Console.WriteLine(theNextBest.ToString());
        }
    }
}
