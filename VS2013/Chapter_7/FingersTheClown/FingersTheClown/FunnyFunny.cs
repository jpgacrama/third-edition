using System;

namespace FingersTheClown
{
    internal class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;

        public string FunnyThingIHave
        {
            get { return "Hi kids! I have " + funnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}