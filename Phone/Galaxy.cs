using System;

namespace Phones{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            string ringtone = Phone.ringTone;
            string rung = this.ringtone;
        }
    
        public string Unlock() 
        {
            string unlocked = "has been unlocked by passcode";
            return unlocked; 
            
            
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine($"{this._versionNumber}")        
        }
    }
    
}
