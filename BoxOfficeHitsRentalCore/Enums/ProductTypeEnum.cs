namespace BoxOfficeHitsRentalCore.Enums
{
    public struct ProductTypeEnum
    {
        private const string FirstProductType = "Film";
        private const string SecondProductType = "Film Box Set";
        private const string ThirdProductType = "TV Series Box Set";

        internal readonly static ProductTypeEnum First = new ProductTypeEnum(FirstProductType);
        internal readonly static ProductTypeEnum Second = new ProductTypeEnum(SecondProductType);
        internal readonly static ProductTypeEnum Third = new ProductTypeEnum(ThirdProductType);

        private readonly string Type;
        private ProductTypeEnum(string type) => Type = type;

        internal ProductTypeEnum SelectType()
        {
            switch (Type)
            {
                case FirstProductType:
                    return First;
                case SecondProductType:
                    return Second;
                default:
                    return Third;
            }
        }
    }
}
