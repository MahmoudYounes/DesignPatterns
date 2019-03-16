using System;

namespace AbstractFactory
{
    // this is the client class
    public class CIA
    {
        IAbstractMobile _mobile;
        public CIA(IAbstractMobile mobile)
        {
            _mobile = mobile;
        }

        public void Eavesdrop()
        {
            _mobile.SendPrivateInformation();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string mobileType = "5T";
            
            var mobileFactory = new OnePlusFactory();
            
            var mobilePhone = mobileFactory.Build(mobileType);
            
            var spy = new CIA(mobilePhone);

            spy.Eavesdrop();
        }
    }
}
