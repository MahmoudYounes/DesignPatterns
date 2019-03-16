using System;

namespace AbstractFactory
{
    public class Google : IAbstractMobile
    {
        public string MobileType{get;set;}
        public string RAM { get; set; }
        public string Processor {get;set;}
        public string Camera{get;set;}
        public string InternalStorage{get;set;}

        public Google(string type)
        {
            MobileType = type;
        }
        public Google(string type, string ram, string processor, string camera, string internalStorage)
        {
            RAM = ram;
            Processor = processor;
            Camera = camera;
            InternalStorage = internalStorage;
            MobileType = type;
        }

        public void SendPrivateInformation()
        {
            Console.WriteLine($"this mobile type is {MobileType} and has {RAM} RAM, {Processor} processor, " +
                   $"{Camera} Camera, and {InternalStorage} internal storage");
        }
    }
}