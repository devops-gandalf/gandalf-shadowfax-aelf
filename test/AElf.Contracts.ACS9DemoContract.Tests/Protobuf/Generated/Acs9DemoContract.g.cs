// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs9_demo_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.ACS9DemoContract {

  /// <summary>Holder for reflection information generated from acs9_demo_contract.proto</summary>
  internal static partial class Acs9DemoContractReflection {

    #region Descriptor
    /// <summary>File descriptor for acs9_demo_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Acs9DemoContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhhY3M5X2RlbW9fY29udHJhY3QucHJvdG8aD2FlbGYvY29yZS5wcm90bxoK",
            "YWNzOS5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8iegoPSW5pdGlhbGl6ZUlucHV0EiYKD3Byb2ZpdF9y",
            "ZWNlaXZlchgBIAEoCzINLmFlbGYuQWRkcmVzcxIOCgZzeW1ib2wYAiABKAkS",
            "LwobZGl2aWRlbmRfcG9vbF9jb250cmFjdF9uYW1lGAMgASgLMgouYWVsZi5I",
            "YXNoIh4KDERlcG9zaXRJbnB1dBIOCgZhbW91bnQYASABKBIiLwoNV2l0aGRy",
            "YXdJbnB1dBIOCgZzeW1ib2wYASABKAkSDgoGYW1vdW50GAIgASgSIncKBlJl",
            "Y29yZBIZCgR0eXBlGAEgASgOMgsuUmVjb3JkVHlwZRItCgl0aW1lc3RhbXAY",
            "AiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEhMKC2Rlc2NyaXB0",
            "aW9uGAMgASgJEg4KBnN5bWJvbBgEIAEoCSJICgdQcm9maWxlEiMKDHVzZXJf",
            "YWRkcmVzcxgBIAEoCzINLmFlbGYuQWRkcmVzcxIYCgdyZWNvcmRzGAIgAygL",
            "MgcuUmVjb3JkIiwKC1JlY29yZEFkZGVkEhcKBnJlY29yZBgBIAEoCzIHLlJl",
            "Y29yZDoEoLsYASo9CgpSZWNvcmRUeXBlEgsKB1NJR05fVVAQABILCgdERVBP",
            "U0lUEAESDAoIV0lUSERSQVcQAhIHCgNVU0UQAzLnAgoQQUNTOURlbW9Db250",
            "cmFjdBI4CgpJbml0aWFsaXplEhAuSW5pdGlhbGl6ZUlucHV0GhYuZ29vZ2xl",
            "LnByb3RvYnVmLkVtcHR5IgASOgoGU2lnblVwEhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgASMgoHRGVwb3NpdBIN",
            "LkRlcG9zaXRJbnB1dBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIAEjQKCFdp",
            "dGhkcmF3Eg4uV2l0aGRyYXdJbnB1dBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0",
            "eSIAEigKA1VzZRIHLlJlY29yZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIA",
            "GkmyzPYBNUFFbGYuQ29udHJhY3RzLkFDUzlEZW1vQ29udHJhY3QuQUNTOURl",
            "bW9Db250cmFjdFN0YXRlysr2AQphY3M5LnByb3RvQiKqAh9BRWxmLkNvbnRy",
            "YWN0cy5BQ1M5RGVtb0NvbnRyYWN0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.Standards.ACS9.Acs9Reflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AElf.Contracts.ACS9DemoContract.RecordType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS9DemoContract.InitializeInput), global::AElf.Contracts.ACS9DemoContract.InitializeInput.Parser, new[]{ "ProfitReceiver", "Symbol", "DividendPoolContractName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS9DemoContract.DepositInput), global::AElf.Contracts.ACS9DemoContract.DepositInput.Parser, new[]{ "Amount" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS9DemoContract.WithdrawInput), global::AElf.Contracts.ACS9DemoContract.WithdrawInput.Parser, new[]{ "Symbol", "Amount" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS9DemoContract.Record), global::AElf.Contracts.ACS9DemoContract.Record.Parser, new[]{ "Type", "Timestamp", "Description", "Symbol" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS9DemoContract.Profile), global::AElf.Contracts.ACS9DemoContract.Profile.Parser, new[]{ "UserAddress", "Records" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS9DemoContract.RecordAdded), global::AElf.Contracts.ACS9DemoContract.RecordAdded.Parser, new[]{ "Record" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  internal enum RecordType {
    [pbr::OriginalName("SIGN_UP")] SignUp = 0,
    [pbr::OriginalName("DEPOSIT")] Deposit = 1,
    [pbr::OriginalName("WITHDRAW")] Withdraw = 2,
    [pbr::OriginalName("USE")] Use = 3,
  }

  #endregion

  #region Messages
  internal sealed partial class InitializeInput : pb::IMessage<InitializeInput> {
    private static readonly pb::MessageParser<InitializeInput> _parser = new pb::MessageParser<InitializeInput>(() => new InitializeInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitializeInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS9DemoContract.Acs9DemoContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput(InitializeInput other) : this() {
      profitReceiver_ = other.profitReceiver_ != null ? other.profitReceiver_.Clone() : null;
      symbol_ = other.symbol_;
      dividendPoolContractName_ = other.dividendPoolContractName_ != null ? other.dividendPoolContractName_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput Clone() {
      return new InitializeInput(this);
    }

    /// <summary>Field number for the "profit_receiver" field.</summary>
    public const int ProfitReceiverFieldNumber = 1;
    private global::AElf.Types.Address profitReceiver_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address ProfitReceiver {
      get { return profitReceiver_; }
      set {
        profitReceiver_ = value;
      }
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 2;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dividend_pool_contract_name" field.</summary>
    public const int DividendPoolContractNameFieldNumber = 3;
    private global::AElf.Types.Hash dividendPoolContractName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash DividendPoolContractName {
      get { return dividendPoolContractName_; }
      set {
        dividendPoolContractName_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitializeInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitializeInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProfitReceiver, other.ProfitReceiver)) return false;
      if (Symbol != other.Symbol) return false;
      if (!object.Equals(DividendPoolContractName, other.DividendPoolContractName)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (profitReceiver_ != null) hash ^= ProfitReceiver.GetHashCode();
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (dividendPoolContractName_ != null) hash ^= DividendPoolContractName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (profitReceiver_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ProfitReceiver);
      }
      if (Symbol.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Symbol);
      }
      if (dividendPoolContractName_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DividendPoolContractName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (profitReceiver_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfitReceiver);
      }
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (dividendPoolContractName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DividendPoolContractName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitializeInput other) {
      if (other == null) {
        return;
      }
      if (other.profitReceiver_ != null) {
        if (profitReceiver_ == null) {
          ProfitReceiver = new global::AElf.Types.Address();
        }
        ProfitReceiver.MergeFrom(other.ProfitReceiver);
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.dividendPoolContractName_ != null) {
        if (dividendPoolContractName_ == null) {
          DividendPoolContractName = new global::AElf.Types.Hash();
        }
        DividendPoolContractName.MergeFrom(other.DividendPoolContractName);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (profitReceiver_ == null) {
              ProfitReceiver = new global::AElf.Types.Address();
            }
            input.ReadMessage(ProfitReceiver);
            break;
          }
          case 18: {
            Symbol = input.ReadString();
            break;
          }
          case 26: {
            if (dividendPoolContractName_ == null) {
              DividendPoolContractName = new global::AElf.Types.Hash();
            }
            input.ReadMessage(DividendPoolContractName);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class DepositInput : pb::IMessage<DepositInput> {
    private static readonly pb::MessageParser<DepositInput> _parser = new pb::MessageParser<DepositInput>(() => new DepositInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DepositInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS9DemoContract.Acs9DemoContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DepositInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DepositInput(DepositInput other) : this() {
      amount_ = other.amount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DepositInput Clone() {
      return new DepositInput(this);
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 1;
    private long amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DepositInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DepositInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Amount != other.Amount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Amount != 0L) hash ^= Amount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Amount != 0L) {
        output.WriteRawTag(8);
        output.WriteSInt64(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Amount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DepositInput other) {
      if (other == null) {
        return;
      }
      if (other.Amount != 0L) {
        Amount = other.Amount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Amount = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class WithdrawInput : pb::IMessage<WithdrawInput> {
    private static readonly pb::MessageParser<WithdrawInput> _parser = new pb::MessageParser<WithdrawInput>(() => new WithdrawInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WithdrawInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS9DemoContract.Acs9DemoContractReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WithdrawInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WithdrawInput(WithdrawInput other) : this() {
      symbol_ = other.symbol_;
      amount_ = other.amount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WithdrawInput Clone() {
      return new WithdrawInput(this);
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private long amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WithdrawInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WithdrawInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Symbol != other.Symbol) return false;
      if (Amount != other.Amount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (Amount != 0L) hash ^= Amount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Symbol.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Symbol);
      }
      if (Amount != 0L) {
        output.WriteRawTag(16);
        output.WriteSInt64(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Amount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WithdrawInput other) {
      if (other == null) {
        return;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.Amount != 0L) {
        Amount = other.Amount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Symbol = input.ReadString();
            break;
          }
          case 16: {
            Amount = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Record : pb::IMessage<Record> {
    private static readonly pb::MessageParser<Record> _parser = new pb::MessageParser<Record>(() => new Record());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Record> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS9DemoContract.Acs9DemoContractReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Record() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Record(Record other) : this() {
      type_ = other.type_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      description_ = other.description_;
      symbol_ = other.symbol_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Record Clone() {
      return new Record(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::AElf.Contracts.ACS9DemoContract.RecordType type_ = global::AElf.Contracts.ACS9DemoContract.RecordType.SignUp;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Contracts.ACS9DemoContract.RecordType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 4;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Record);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Record other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (Description != other.Description) return false;
      if (Symbol != other.Symbol) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::AElf.Contracts.ACS9DemoContract.RecordType.SignUp) hash ^= Type.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != global::AElf.Contracts.ACS9DemoContract.RecordType.SignUp) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Timestamp);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (Symbol.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Symbol);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != global::AElf.Contracts.ACS9DemoContract.RecordType.SignUp) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Record other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::AElf.Contracts.ACS9DemoContract.RecordType.SignUp) {
        Type = other.Type;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::AElf.Contracts.ACS9DemoContract.RecordType) input.ReadEnum();
            break;
          }
          case 18: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            Symbol = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Profile : pb::IMessage<Profile> {
    private static readonly pb::MessageParser<Profile> _parser = new pb::MessageParser<Profile>(() => new Profile());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Profile> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS9DemoContract.Acs9DemoContractReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profile() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profile(Profile other) : this() {
      userAddress_ = other.userAddress_ != null ? other.userAddress_.Clone() : null;
      records_ = other.records_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profile Clone() {
      return new Profile(this);
    }

    /// <summary>Field number for the "user_address" field.</summary>
    public const int UserAddressFieldNumber = 1;
    private global::AElf.Types.Address userAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address UserAddress {
      get { return userAddress_; }
      set {
        userAddress_ = value;
      }
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AElf.Contracts.ACS9DemoContract.Record> _repeated_records_codec
        = pb::FieldCodec.ForMessage(18, global::AElf.Contracts.ACS9DemoContract.Record.Parser);
    private readonly pbc::RepeatedField<global::AElf.Contracts.ACS9DemoContract.Record> records_ = new pbc::RepeatedField<global::AElf.Contracts.ACS9DemoContract.Record>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.Contracts.ACS9DemoContract.Record> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Profile);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Profile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UserAddress, other.UserAddress)) return false;
      if(!records_.Equals(other.records_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (userAddress_ != null) hash ^= UserAddress.GetHashCode();
      hash ^= records_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (userAddress_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserAddress);
      }
      records_.WriteTo(output, _repeated_records_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (userAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserAddress);
      }
      size += records_.CalculateSize(_repeated_records_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Profile other) {
      if (other == null) {
        return;
      }
      if (other.userAddress_ != null) {
        if (userAddress_ == null) {
          UserAddress = new global::AElf.Types.Address();
        }
        UserAddress.MergeFrom(other.UserAddress);
      }
      records_.Add(other.records_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (userAddress_ == null) {
              UserAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(UserAddress);
            break;
          }
          case 18: {
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class RecordAdded : pb::IMessage<RecordAdded> {
    private static readonly pb::MessageParser<RecordAdded> _parser = new pb::MessageParser<RecordAdded>(() => new RecordAdded());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RecordAdded> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS9DemoContract.Acs9DemoContractReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecordAdded() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecordAdded(RecordAdded other) : this() {
      record_ = other.record_ != null ? other.record_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecordAdded Clone() {
      return new RecordAdded(this);
    }

    /// <summary>Field number for the "record" field.</summary>
    public const int RecordFieldNumber = 1;
    private global::AElf.Contracts.ACS9DemoContract.Record record_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Contracts.ACS9DemoContract.Record Record {
      get { return record_; }
      set {
        record_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RecordAdded);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RecordAdded other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Record, other.Record)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (record_ != null) hash ^= Record.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (record_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Record);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (record_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Record);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RecordAdded other) {
      if (other == null) {
        return;
      }
      if (other.record_ != null) {
        if (record_ == null) {
          Record = new global::AElf.Contracts.ACS9DemoContract.Record();
        }
        Record.MergeFrom(other.Record);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (record_ == null) {
              Record = new global::AElf.Contracts.ACS9DemoContract.Record();
            }
            input.ReadMessage(Record);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code