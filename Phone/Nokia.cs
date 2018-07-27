using System;

namespace Phones
{
            public class Nokia : Phone, IRingable 
            {
                public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
                   : base(versionNumber, batteryPercentage, carrier, ringTone) {}
                    public string Ring() 
                    {
                        string ring = "Ringgg Ring Ringg";
                        return ring; 
                    }
                    public string Unlock() 
                    {
                        string unlocked = "unlocked with passcode";
                        return unlocked;
                        // your code here
                    }
                    public override void DisplayInfo() 
                    {
                        // your code here            
                    }
            }
            
}
