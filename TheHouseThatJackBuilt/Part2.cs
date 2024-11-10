using System.Collections.Immutable;

namespace TheHouseThatJackBuilt
{
    public class Part2
    {
        static string text = "А это пшеница,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
        List<string> list = new List<string>();

        public ImmutableList<string> Poem { get; set; }

        public Part2(ImmutableList<string> poem)
        {
            Poem = poem;
        }

        public ImmutableList<string> AddPart(ImmutableList<string> prevpart)
        {
            list.Add("");
            list.AddRange(text.Split("\r\n").ToList());

            Poem = prevpart.Concat(list).ToImmutableList();
            return Poem;
        }
    }
}
