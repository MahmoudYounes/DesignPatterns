using System;

namespace AbstractFactory
{
    public class GoogleFactory : IAbstractFactory
    {
        public IAbstractMobile Build(string mobileType)
        {
            switch(mobileType)
            {
                case "Pixel XL":
                    return new Google(mobileType, "6", "835", "12", "64");
            }
            throw new ArgumentException("Mobile type uknown");
        }
    }
}