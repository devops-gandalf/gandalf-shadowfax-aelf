// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: treasury_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Treasury {

  #region Events
  #endregion
  internal static partial class TreasuryContractContainer
  {
    static readonly string __ServiceName = "Treasury.TreasuryContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.DonateAllInput> __Marshaller_Treasury_DonateAllInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.DonateAllInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.DividendPoolWeightSetting> __Marshaller_Treasury_DividendPoolWeightSetting = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.DividendPoolWeightSetting.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.MinerRewardWeightSetting> __Marshaller_Treasury_MinerRewardWeightSetting = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.MinerRewardWeightSetting.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AuthorityInfo> __Marshaller_AuthorityInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthorityInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleInput> __Marshaller_Treasury_GetWelfareRewardAmountSampleInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleOutput> __Marshaller_Treasury_GetWelfareRewardAmountSampleOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.DividendPoolWeightProportion> __Marshaller_Treasury_DividendPoolWeightProportion = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.DividendPoolWeightProportion.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Treasury.MinerRewardWeightProportion> __Marshaller_Treasury_MinerRewardWeightProportion = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Treasury.MinerRewardWeightProportion.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_InitialTreasuryContract = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "InitialTreasuryContract",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_InitialMiningRewardProfitItem = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "InitialMiningRewardProfitItem",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Treasury.DonateAllInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DonateAll = new aelf::Method<global::AElf.Contracts.Treasury.DonateAllInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DonateAll",
        __Marshaller_Treasury_DonateAllInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Treasury.DividendPoolWeightSetting, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetDividendPoolWeightSetting = new aelf::Method<global::AElf.Contracts.Treasury.DividendPoolWeightSetting, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetDividendPoolWeightSetting",
        __Marshaller_Treasury_DividendPoolWeightSetting,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Treasury.MinerRewardWeightSetting, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMinerRewardWeightSetting = new aelf::Method<global::AElf.Contracts.Treasury.MinerRewardWeightSetting, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMinerRewardWeightSetting",
        __Marshaller_Treasury_MinerRewardWeightSetting,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateMiningReward = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateMiningReward",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeTreasuryController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeTreasuryController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleInput, global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleOutput> __Method_GetWelfareRewardAmountSample = new aelf::Method<global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleInput, global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetWelfareRewardAmountSample",
        __Marshaller_Treasury_GetWelfareRewardAmountSampleInput,
        __Marshaller_Treasury_GetWelfareRewardAmountSampleOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Hash> __Method_GetTreasurySchemeId = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Hash>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTreasurySchemeId",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Treasury.DividendPoolWeightProportion> __Method_GetDividendPoolWeightProportion = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Treasury.DividendPoolWeightProportion>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDividendPoolWeightProportion",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Treasury_DividendPoolWeightProportion);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Treasury.MinerRewardWeightProportion> __Method_GetMinerRewardWeightProportion = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Treasury.MinerRewardWeightProportion>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMinerRewardWeightProportion",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Treasury_MinerRewardWeightProportion);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetTreasuryController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTreasuryController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Treasury.TreasuryContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.Treasury.TreasuryContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class TreasuryContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> InitialTreasuryContract
      {
        get { return __factory.Create(__Method_InitialTreasuryContract); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> InitialMiningRewardProfitItem
      {
        get { return __factory.Create(__Method_InitialMiningRewardProfitItem); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Treasury.DonateAllInput, global::Google.Protobuf.WellKnownTypes.Empty> DonateAll
      {
        get { return __factory.Create(__Method_DonateAll); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Treasury.DividendPoolWeightSetting, global::Google.Protobuf.WellKnownTypes.Empty> SetDividendPoolWeightSetting
      {
        get { return __factory.Create(__Method_SetDividendPoolWeightSetting); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Treasury.MinerRewardWeightSetting, global::Google.Protobuf.WellKnownTypes.Empty> SetMinerRewardWeightSetting
      {
        get { return __factory.Create(__Method_SetMinerRewardWeightSetting); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty> UpdateMiningReward
      {
        get { return __factory.Create(__Method_UpdateMiningReward); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeTreasuryController
      {
        get { return __factory.Create(__Method_ChangeTreasuryController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleInput, global::AElf.Contracts.Treasury.GetWelfareRewardAmountSampleOutput> GetWelfareRewardAmountSample
      {
        get { return __factory.Create(__Method_GetWelfareRewardAmountSample); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Hash> GetTreasurySchemeId
      {
        get { return __factory.Create(__Method_GetTreasurySchemeId); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Treasury.DividendPoolWeightProportion> GetDividendPoolWeightProportion
      {
        get { return __factory.Create(__Method_GetDividendPoolWeightProportion); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Treasury.MinerRewardWeightProportion> GetMinerRewardWeightProportion
      {
        get { return __factory.Create(__Method_GetMinerRewardWeightProportion); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetTreasuryController
      {
        get { return __factory.Create(__Method_GetTreasuryController); }
      }

    }
  }
}
#endregion
