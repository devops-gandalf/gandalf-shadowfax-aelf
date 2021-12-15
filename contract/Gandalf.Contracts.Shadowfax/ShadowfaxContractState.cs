using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace Gandalf.Contracts.Shadowfax
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public partial class ShadowfaxContractState : ContractState
    {
        // Admin
        public SingletonState<Address> Owner { get; set; }
        // state definitions go here.
        public Int64State MaximalTimeSpan { get; set; }
        public Int64State MinimalTimespan { get; set; }
        public MappedState<long,Address,UserInfo> UserInfo { get; set; }
        public SingletonState<PublicOfferList> PublicOfferList { get; set; }
        public MappedState<string, Address> Ascription { get; set; } 
    }
}