// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: greeter_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.GreeterContract {

  #region Events
  #endregion
  internal static partial class GreeterContractContainer
  {
    static readonly string __ServiceName = "GreeterContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.GreeterContract.GreetToOutput> __Marshaller_GreetToOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.GreeterContract.GreetToOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.GreeterContract.GreetedList> __Marshaller_GreetedList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.GreeterContract.GreetedList.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_Greet = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.Action,
        __ServiceName,
        "Greet",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_StringValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.GreeterContract.GreetToOutput> __Method_GreetTo = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.GreeterContract.GreetToOutput>(
        aelf::MethodType.Action,
        __ServiceName,
        "GreetTo",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_GreetToOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.GreeterContract.GreetedList> __Method_GetGreetedList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.GreeterContract.GreetedList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetGreetedList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_GreetedList);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.GreeterContract.GreeterContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.GreeterContract.GreeterContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class GreeterContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> Greet
      {
        get { return __factory.Create(__Method_Greet); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.GreeterContract.GreetToOutput> GreetTo
      {
        get { return __factory.Create(__Method_GreetTo); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.GreeterContract.GreetedList> GetGreetedList
      {
        get { return __factory.Create(__Method_GetGreetedList); }
      }

    }
  }
}
#endregion
