namespace ProjectCS.model
{
    public class HasID<ID>
    {
        private ID id;

        public HasID()
        {
        }

        public ID Id
        {
            get => id;
            set => id = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}