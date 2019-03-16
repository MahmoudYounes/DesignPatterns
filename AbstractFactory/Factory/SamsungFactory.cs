using System;

namespace AbstractFactory
{
    public class SamsungFactory : IAbstractFactory
    {
        public IAbstractMobile Build(string mobileType)
        {
            switch(mobileType)
            {
                case "S9+":
                    return new Samsung(mobileType, "8", "835", "12", "128");
                case "10":
                    return new Samsung(mobileType, "8", "845", "12", "128");
            }
            throw new ArgumentException("Mobile type uknown");
        }
    }
}