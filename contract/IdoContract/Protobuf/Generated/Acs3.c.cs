// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs3.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS3 {

  #region Events
  internal partial class ProposalCreated : aelf::IEvent<ProposalCreated>
  {
    public global::System.Collections.Generic.IEnumerable<ProposalCreated> GetIndexed()
    {
      return new List<ProposalCreated>
      {
      new ProposalCreated
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ProposalCreated GetNonIndexed()
    {
      return new ProposalCreated
      {
        ProposalId = ProposalId,
      };
    }
  }

  internal partial class ProposalReleased : aelf::IEvent<ProposalReleased>
  {
    public global::System.Collections.Generic.IEnumerable<ProposalReleased> GetIndexed()
    {
      return new List<ProposalReleased>
      {
      new ProposalReleased
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ProposalReleased GetNonIndexed()
    {
      return new ProposalReleased
      {
        ProposalId = ProposalId,
      };
    }
  }

  internal partial class OrganizationCreated : aelf::IEvent<OrganizationCreated>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationCreated> GetIndexed()
    {
      return new List<OrganizationCreated>
      {
      };
    }

    public OrganizationCreated GetNonIndexed()
    {
      return new OrganizationCreated
      {
        OrganizationAddress = OrganizationAddress,
      };
    }
  }

  internal partial class ReceiptCreated : aelf::IEvent<ReceiptCreated>
  {
    public global::System.Collections.Generic.IEnumerable<ReceiptCreated> GetIndexed()
    {
      return new List<ReceiptCreated>
      {
      new ReceiptCreated
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ReceiptCreated GetNonIndexed()
    {
      return new ReceiptCreated
      {
        ProposalId = ProposalId,
        Address = Address,
        ReceiptType = ReceiptType,
        Time = Time,
      };
    }
  }

  internal partial class OrganizationWhiteListChanged : aelf::IEvent<OrganizationWhiteListChanged>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationWhiteListChanged> GetIndexed()
    {
      return new List<OrganizationWhiteListChanged>
      {
      };
    }

    public OrganizationWhiteListChanged GetNonIndexed()
    {
      return new OrganizationWhiteListChanged
      {
        OrganizationAddress = OrganizationAddress,
        ProposerWhiteList = ProposerWhiteList,
      };
    }
  }

  internal partial class OrganizationThresholdChanged : aelf::IEvent<OrganizationThresholdChanged>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationThresholdChanged> GetIndexed()
    {
      return new List<OrganizationThresholdChanged>
      {
      };
    }

    public OrganizationThresholdChanged GetNonIndexed()
    {
      return new OrganizationThresholdChanged
      {
        OrganizationAddress = OrganizationAddress,
        ProposerReleaseThreshold = ProposerReleaseThreshold,
      };
    }
  }

  #endregion
  internal static partial class AuthorizationContractContainer
  {
    static readonly string __ServiceName = "acs3.AuthorizationContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.CreateProposalInput> __Marshaller_acs3_CreateProposalInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.CreateProposalInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.ProposalReleaseThreshold> __Marshaller_acs3_ProposalReleaseThreshold = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.ProposalReleaseThreshold.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.ProposerWhiteList> __Marshaller_acs3_ProposerWhiteList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.ProposerWhiteList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.CreateProposalBySystemContractInput> __Marshaller_acs3_CreateProposalBySystemContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.CreateProposalBySystemContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.ProposalOutput> __Marshaller_acs3_ProposalOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.ProposalOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.ValidateProposerInWhiteListInput> __Marshaller_acs3_ValidateProposerInWhiteListInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.ValidateProposerInWhiteListInput.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS3.CreateProposalInput, global::AElf.Types.Hash> __Method_CreateProposal = new aelf::Method<global::AElf.Standards.ACS3.CreateProposalInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateProposal",
        __Marshaller_acs3_CreateProposalInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Approve = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Approve",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Reject = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Reject",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Abstain = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Abstain",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Release = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Release",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS3.ProposalReleaseThreshold, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeOrganizationThreshold = new aelf::Method<global::AElf.Standards.ACS3.ProposalReleaseThreshold, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeOrganizationThreshold",
        __Marshaller_acs3_ProposalReleaseThreshold,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS3.ProposerWhiteList, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeOrganizationProposerWhiteList = new aelf::Method<global::AElf.Standards.ACS3.ProposerWhiteList, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeOrganizationProposerWhiteList",
        __Marshaller_acs3_ProposerWhiteList,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS3.CreateProposalBySystemContractInput, global::AElf.Types.Hash> __Method_CreateProposalBySystemContract = new aelf::Method<global::AElf.Standards.ACS3.CreateProposalBySystemContractInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateProposalBySystemContract",
        __Marshaller_acs3_CreateProposalBySystemContractInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ClearProposal = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ClearProposal",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Standards.ACS3.ProposalOutput> __Method_GetProposal = new aelf::Method<global::AElf.Types.Hash, global::AElf.Standards.ACS3.ProposalOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProposal",
        __Marshaller_aelf_Hash,
        __Marshaller_acs3_ProposalOutput);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_ValidateOrganizationExist = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "ValidateOrganizationExist",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::AElf.Standards.ACS3.ValidateProposerInWhiteListInput, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_ValidateProposerInWhiteList = new aelf::Method<global::AElf.Standards.ACS3.ValidateProposerInWhiteListInput, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "ValidateProposerInWhiteList",
        __Marshaller_acs3_ValidateProposerInWhiteListInput,
        __Marshaller_google_protobuf_BoolValue);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS3.Acs3Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS3.Acs3Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class AuthorizationContractReferenceState : global::AElf.Sdk.CSharp.State.ContractReferenceState
    {
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Standards.ACS3.CreateProposalInput, global::AElf.Types.Hash> CreateProposal { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> Approve { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> Reject { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> Abstain { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> Release { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Standards.ACS3.ProposalReleaseThreshold, global::Google.Protobuf.WellKnownTypes.Empty> ChangeOrganizationThreshold { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Standards.ACS3.ProposerWhiteList, global::Google.Protobuf.WellKnownTypes.Empty> ChangeOrganizationProposerWhiteList { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Standards.ACS3.CreateProposalBySystemContractInput, global::AElf.Types.Hash> CreateProposalBySystemContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> ClearProposal { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Standards.ACS3.ProposalOutput> GetProposal { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue> ValidateOrganizationExist { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Standards.ACS3.ValidateProposerInWhiteListInput, global::Google.Protobuf.WellKnownTypes.BoolValue> ValidateProposerInWhiteList { get; set; }
    }
  }
}
#endregion
