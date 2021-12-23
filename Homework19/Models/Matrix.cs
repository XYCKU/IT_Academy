using System;
using System.Threading.Tasks;

namespace Models
{
    internal struct Line {
        public string word;
        public int position;
    }
    public class Matrix
    {
        private Random random = new Random();
        private int width, height, maxWordAmount, wordAmount;
        private float chance;
        private Line[] lines;
        public int Width { get => width; set => width = (value > 0)? value : throw new ArgumentOutOfRangeException(nameof(value)); }
        public int Height { get => height; set => height = (value > 0)? value : throw new ArgumentOutOfRangeException(nameof(value)); }
        public float Chance { get => chance; set => chance = (value > 0 && value <= 1)? value : throw new ArgumentOutOfRangeException(nameof(value)); }
        public Matrix(int width, int height, float chance = 0.5f, int maxWordAmount = 5)
        {
            Width = width;
            Height = height;
            Chance = chance;
            lines = new Line[height];
            this.maxWordAmount = maxWordAmount;
        }
        public async Task CycleAsync()
        {
            TryGenerate();
            Draw();
            Shift();
            await Task.Delay(100);
        }
        public void Draw()
        {
            Console.Clear();
            Console.WriteLine(new string('=', Width + 2));
            for (int i = 0; i < Height; ++i)
            {
                Console.Write('|');
                if (lines[i].word != null) { 
                    Console.Write($"{new string(' ', lines[i].position)}" +
                                        $"{lines[i].word}" +
                                        $"{new string(' ', Width - lines[i].word.Length - lines[i].position)}");
                }
                else
                {
                    Console.Write($"{new string(' ', Width)}");
                }
                Console.WriteLine('|');
            }
            Console.WriteLine(new string('=', Width + 2));
        }
        private void Shift()
        {
            if (lines[Height - 1].word != null)
            {
                --wordAmount;
            }
            for (int i = Height - 1; i > 0; --i)
            {
                lines[i] = lines[i - 1];
                lines[i - 1] = new Line { };
                if (lines[i].word != null)
                {
                    lines[i].word = lines[i].word.Shuffle();
                }
            }
        }
        private void TryGenerate()
        {
            if (wordAmount < maxWordAmount && Chance - random.NextDouble() >= 0)
            {
                ++wordAmount;
                int length = 1 + random.Next(Width / 2);
                string newWord = StringGenerator.Generate(length);
                int position = random.Next(Width - length);
                lines[0] = new Line() { word = newWord, position = position };
            }
        }
    }
}
