using System.Collections.Immutable;

namespace TheHouseThatJackBuilt
{
    public class Part1
    {
        static string text1 = "Вот дом,\r\nКоторый построил Джек.";
        List<string> list1 = text1.Split("\r\n").ToList();

        private ImmutableList<string>.Builder _newPart;
        public ImmutableList<string>.Builder NewPart => _newPart;

        private ImmutableList<string>.Builder _poem;
        public ImmutableList<string>.Builder Poem => _poem;

        public Part1()
        {
            _newPart = ImmutableList.CreateBuilder<string>();

            foreach (var part in list1)
                _newPart.Add(part);

            _newPart.ToImmutable();
        }

        public void AddPart()
        {
            _poem = ImmutableList.CreateBuilder<string>();
            _poem.AddRange(_newPart);
            _poem.ToImmutable();
        }

    }
}
