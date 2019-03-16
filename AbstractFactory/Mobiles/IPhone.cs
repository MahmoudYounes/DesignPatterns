using System;

namespace AbstractFactory
{
    public class IPhone : IAbstractMobile
    {
        public string MobileType{get;set;}
        public string RAM { get; set; }
        public string Processor {get;set;}
        public string Camera{get;set;}
        public string InternalStorage{get;set;}

        public IPhone(string type)
        {
            MobileType = type;
        }
        public void SendPrivateInformation()
        {
            Console.WriteLine($"this mobile type is {MobileType} and has {RAM} RAM, {Processor} processor, " +
                   $"{Camera} Camera, and {InternalStorage} internal storage");
        }
    }
}