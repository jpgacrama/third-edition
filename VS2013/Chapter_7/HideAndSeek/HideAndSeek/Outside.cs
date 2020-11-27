namespace HideAndSeek
{
    internal class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot)
            : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                    newDescription += " It’s very hot.";
                return newDescription;
            }
        }
    }
}