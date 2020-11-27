namespace FingersTheClown
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }
}