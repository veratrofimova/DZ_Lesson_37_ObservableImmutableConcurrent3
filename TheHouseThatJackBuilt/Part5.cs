﻿using System.Collections.Immutable;

namespace TheHouseThatJackBuilt
{
    public class Part5
    {
        static string text = "Вот пес без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
        List<string> list = text.Split("\r\n").ToList();

        private ImmutableList<string>.Builder _newPart;
        public ImmutableList<string>.Builder NewPart => _newPart;

        private ImmutableList<string>.Builder _poem;
        public ImmutableList<string>.Builder Poem => _poem;

        public Part5()
        {
            _newPart = ImmutableList.CreateBuilder<string>();
            _newPart.Add("");

            foreach (var row in list)
                _newPart.Add(row);

            _newPart.ToImmutable();
        }

        public void AddPart(ImmutableList<string>.Builder prevpart)
        {
            _poem = ImmutableList.CreateBuilder<string>();
            _poem.AddRange(prevpart);
            _poem.AddRange(NewPart);
            _poem.ToImmutable();
        }
    }
}
