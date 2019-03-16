using System;

namespace AbstractFactory
{
    public class OnePlusFactory : IAbstractFactory
    {
        public IAbstractMobile Build(string mobileType)
        {
            switch(mobileType)
            {
                case "5T":
                    return new OnePlus(mobileType, "8", "835", "12", "128");
                case "6":
                    return new OnePlus(mobileType, "8", "845", "12", "128");
                case "6T":
                    return new OnePlus(mobileType, "12", "845", "12", "256");
            }
            throw new ArgumentException("Mobile type uknown");
        }
    }
}