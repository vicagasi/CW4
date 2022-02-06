/*
 * Author: Victor Gasior 3
 * Date: 2/5/22
 * File: Class1.cs
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace IPhoneFactory
{
    enum manu
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
    internal class PhoneTypeChecker
    {
        IPhoneFactory factory = null;
        public IPhoneFactory PhoneChecker(manu manu)
        {
            switch (manu)
            {
                case manu.SAMSUNG:
                    factory = new SamsungFactory();
                    return factory;
                case manu.HTC:
                    factory = new HTCFactory();
                    return factory;
                case manu.NOKIA:
                    factory = new NokiaFactory();
                    return factory;
                default:
                    return null;
            }
        }
        public void CheckProducts()
        {
            ISmart SmartPhone = factory.GetSmart();
            Console.WriteLine(SmartPhone.getName());
            IDumb OldPhone = factory.GetDumb();
            Console.WriteLine(OldPhone.getName());
        }
    }

    abstract public class IPhoneFactory
    {
        abstract public ISmart GetSmart();
        abstract public IDumb GetDumb();
    }

    public class SamsungFactory : IPhoneFactory
    {
        override public ISmart GetSmart()
        {
            GalaxyS2 galaxyS2 = new GalaxyS2();
            return galaxyS2;
        }

        override public IDumb GetDumb()
        {
            Primo primo = new Primo();
            return primo;
        }
    }

    public class HTCFactory : IPhoneFactory
    {
        override public ISmart GetSmart()
        {
            Titan T = new Titan();
            return T;
        }

        override public IDumb GetDumb()
        {
            Genie genie = new Genie();
            return genie;
        }

    }

    public class NokiaFactory : IPhoneFactory
    {
        override public ISmart GetSmart()
        {
           Lumina L = new Lumina();
            return L;
        }

        override public IDumb GetDumb()
        {
            Asha a = new Asha();
            return a;
        }
    }

    public abstract class ISmart
    {
        abstract public string getName();
    }

    public abstract class IDumb
    {
        abstract public string getName();
    }

    public class Lumina : ISmart
    {
        override public string getName()
        {
            return "Lumina";
        }
    }

    public class GalaxyS2 : ISmart
    {
        override public string getName()
        {
            return "GalaxyS2";
        }
    }

    public class Titan : ISmart
    {
        override public string getName()
        {
            return "Titan";
        }
    }

    public class Asha : IDumb
    {
        override public string getName()
        {
            return "Asha";
        }
    }

    public class Genie : IDumb
    {
        override public string getName()
        {
            return "Genie";
        }
    }

    public class Primo : IDumb
    {
        override public string getName()
        {
            return "Primo";
        }
    }
}

