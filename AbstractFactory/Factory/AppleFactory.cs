using System;

namespace AbstractFactory
{
    public class AppleFactory : IAbstractFactory
    {
        public IAbstractMobile Build(string mobileType)
        {
            switch(mobileType)
            {
                case "IPhone X":
                    return new Apple(mobileType, "6", "835", "12", "64");
                case "IPhone Xs":
                    return new Apple(mobileType, "4", "825", "10", "32");
            }
            throw new ArgumentException("Mobile type uknown");
        }
    }
}