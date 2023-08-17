using Roleplay.Bank;

namespace Roleplay.Business
{
    public class Business {
        
        public string Name;

        public long OwnerId;

        public List<BusinessMember> Members = new(); 

        public List<Job> JobEntries = new();

        public BankAccount? ActiveBankAccount;

        public Business(string name, long ownerId) {
            this.Name = name;
            this.OwnerId = ownerId;
        }
    
        
    }
}