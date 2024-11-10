﻿using System.Collections.Immutable;

namespace TheHouseThatJackBuilt
{
    public class Part5
    {
        static string text = "Вот пес без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
        List<string> list = new List<string>();

        public ImmutableList<string> Poem { get; set; }
        public Part5(ImmutableList<string> poem)
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
