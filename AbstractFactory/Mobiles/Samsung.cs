using System;

namespace AbstractFactory
{
    public class Samsung : IAbstractMobile
    {
        public string MobileType{get;set;}
        public string RAM { get; set; }
        public string Processor {get;set;}
        public string Camera{get;set;}
        public string InternalStorage{get;set;}

        public Samsung(string type)
        {
            MobileType = type;
        }
        public Samsung(string type, string ram, string processor, string camera, string internalStorage)
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