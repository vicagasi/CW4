/*
 * Author: Victor Gasior 3
 * Date: 2/5/22
 * File: Program.cs
*/

using System;

namespace IPhoneFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker P = new PhoneTypeChecker();

            IPhoneFactory Sfactory = new SamsungFactory();
            Sfactory = P.PhoneChecker(manu.SAMSUNG);
            P.CheckProducts();

            IPhoneFactory Nfactory = new NokiaFactory();
            Nfactory = P.PhoneChecker(manu.NOKIA);
            P.CheckProducts();

            IPhoneFactory Hfactory = new HTCFactory();
            Nfactory = P.PhoneChecker(manu.HTC);
            P.CheckProducts();
        }
    }
}