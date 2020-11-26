﻿using System;

namespace GetPracticeUsingInterfaces
{
    internal class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm "
               + Height + " inches tall.");
        }

        public string FunnyThingIHave
        {
            get { return "big shoes"; }
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}