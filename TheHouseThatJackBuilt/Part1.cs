using System.Collections.Immutable;

namespace TheHouseThatJackBuilt
{
    public class Part1
    {
        static string text = "Вот дом,\r\nКоторый построил Джек.";
        List<string> list = text.Split("\r\n").ToList();

        public ImmutableList<string> Poem { get; set; }

        public ImmutableList<string> AddPart()
        {
            ImmutableList<string>.Builder poem = ImmutableList.CreateBuilder<string>();
            poem.Add("");
            Poem = poem.Concat(list).ToImmutableList();
            return Poem;
        }

    }
}
