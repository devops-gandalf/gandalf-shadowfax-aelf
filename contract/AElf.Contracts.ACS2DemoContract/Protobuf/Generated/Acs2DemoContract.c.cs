// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs2_demo_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.ACS2DemoContract {

  #region Events
  #endregion
  public static partial class ACS2DemoContractContainer
  {
    static readonly string __ServiceName = "ACS2DemoContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Types.Transaction> __Marshaller_aelf_Transaction = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Transaction.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS2.ResourceInfo> __Marshaller_acs2_ResourceInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS2.ResourceInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.ACS2DemoContract.TransferCreditsInput> __Marshaller_TransferCreditsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.ACS2DemoContract.TransferCreditsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Types.Transaction, global::AElf.Standards.ACS2.ResourceInfo> __Method_GetResourceInfo = new aelf::Method<global::AElf.Types.Transaction, global::AElf.Standards.ACS2.ResourceInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetResourceInfo",
        __Marshaller_aelf_Transaction,
        __Marshaller_acs2_ResourceInfo);

    static readonly aelf::Method<global::AElf.Contracts.ACS2DemoContract.TransferCreditsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_TransferCredits = new aelf::Method<global::AElf.Contracts.ACS2DemoContract.TransferCreditsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "TransferCredits",
        __Marshaller_TransferCreditsInput,
        __Marshaller_google_protobuf_Empty);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.ACS2DemoContract.Acs2DemoContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS2.Acs2Reflection.Descriptor.Services[0],
          global::AElf.Contracts.ACS2DemoContract.Acs2DemoContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    /// <summary>Base class for the contract of ACS2DemoContract</summary>
    public abstract partial class ACS2DemoContractBase : AElf.Sdk.CSharp.CSharpSmartContract<AElf.Contracts.ACS2DemoContract.ACS2DemoContractState>
    {
      public virtual global::AElf.Standards.ACS2.ResourceInfo GetResourceInfo(global::AElf.Types.Transaction input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty TransferCredits(global::AElf.Contracts.ACS2DemoContract.TransferCreditsInput input)
      {
        throw new global::System.NotImplementedException();
      }

    }

    public static aelf::ServerServiceDefinition BindService(ACS2DemoContractBase serviceImpl)
    {
      return aelf::ServerServiceDefinition.CreateBuilder()
          .AddDescriptors(Descriptors)
          .AddMethod(__Method_GetResourceInfo, serviceImpl.GetResourceInfo)
          .AddMethod(__Method_TransferCredits, serviceImpl.TransferCredits).Build();
    }

  }
}
#endregion
