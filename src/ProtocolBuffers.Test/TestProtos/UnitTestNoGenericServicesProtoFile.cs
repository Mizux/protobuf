// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos.NoGenericService {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class UnitTestNoGenericServicesProtoFile {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      registry.Add(global::Google.ProtocolBuffers.TestProtos.NoGenericService.UnitTestNoGenericServicesProtoFile.TestExtension);
    }
    #endregion
    #region Extensions
    public const int TestExtensionFieldNumber = 1000;
    public static pb::GeneratedExtensionBase<int> TestExtension;
    #endregion
    
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_google_protobuf_no_generic_services_test_TestMessage__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage, global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage.Builder> internal__static_google_protobuf_no_generic_services_test_TestMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static UnitTestNoGenericServicesProtoFile() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CjJnb29nbGUvcHJvdG9idWYvdW5pdHRlc3Rfbm9fZ2VuZXJpY19zZXJ2aWNl" + 
          "cy5wcm90bxIoZ29vZ2xlLnByb3RvYnVmLm5vX2dlbmVyaWNfc2VydmljZXNf" + 
          "dGVzdBokZ29vZ2xlL3Byb3RvYnVmL2NzaGFycF9vcHRpb25zLnByb3RvIiMK" + 
          "C1Rlc3RNZXNzYWdlEgkKAWEYASABKAUqCQjoBxCAgICAAioTCghUZXN0RW51" + 
          "bRIHCgNGT08QATKCAQoLVGVzdFNlcnZpY2UScwoDRm9vEjUuZ29vZ2xlLnBy" + 
          "b3RvYnVmLm5vX2dlbmVyaWNfc2VydmljZXNfdGVzdC5UZXN0TWVzc2FnZRo1" + 
          "Lmdvb2dsZS5wcm90b2J1Zi5ub19nZW5lcmljX3NlcnZpY2VzX3Rlc3QuVGVz" + 
          "dE1lc3NhZ2U6TgoOdGVzdF9leHRlbnNpb24SNS5nb29nbGUucHJvdG9idWYu" + 
          "bm9fZ2VuZXJpY19zZXJ2aWNlc190ZXN0LlRlc3RNZXNzYWdlGOgHIAEoBUJk" + 
          "gAEAiAEAkAEAwj5YCjJHb29nbGUuUHJvdG9jb2xCdWZmZXJzLlRlc3RQcm90" + 
          "b3MuTm9HZW5lcmljU2VydmljZRIiVW5pdFRlc3ROb0dlbmVyaWNTZXJ2aWNl" + 
          "c1Byb3RvRmlsZQ==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_google_protobuf_no_generic_services_test_TestMessage__Descriptor = Descriptor.MessageTypes[0];
        internal__static_google_protobuf_no_generic_services_test_TestMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage, global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage.Builder>(internal__static_google_protobuf_no_generic_services_test_TestMessage__Descriptor,
                new string[] { "A", });
        global::Google.ProtocolBuffers.TestProtos.NoGenericService.UnitTestNoGenericServicesProtoFile.TestExtension = pb::GeneratedSingleExtension<int>.CreateInstance(global::Google.ProtocolBuffers.TestProtos.NoGenericService.UnitTestNoGenericServicesProtoFile.Descriptor.Extensions[0]);
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Enums
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public enum TestEnum {
    FOO = 1,
  }
  
  #endregion
  
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class TestMessage : pb::ExtendableMessage<TestMessage, TestMessage.Builder> {
    private TestMessage() { }
    private static readonly TestMessage defaultInstance = new TestMessage().MakeReadOnly();
    private static readonly string[] _testMessageFieldNames = new string[] { "a" };
    private static readonly uint[] _testMessageFieldTags = new uint[] { 8 };
    public static TestMessage DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestMessage DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override TestMessage ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.NoGenericService.UnitTestNoGenericServicesProtoFile.internal__static_google_protobuf_no_generic_services_test_TestMessage__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TestMessage, TestMessage.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.NoGenericService.UnitTestNoGenericServicesProtoFile.internal__static_google_protobuf_no_generic_services_test_TestMessage__FieldAccessorTable; }
    }
    
    public const int AFieldNumber = 1;
    private bool hasA;
    private int a_;
    public bool HasA {
      get { return hasA; }
    }
    public int A {
      get { return a_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!ExtensionsAreInitialized) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _testMessageFieldNames;
      pb::ExtendableMessage<TestMessage, TestMessage.Builder>.ExtensionWriter extensionWriter = CreateExtensionWriter(this);
      if (hasA) {
        output.WriteInt32(1, field_names[0], A);
      }
      extensionWriter.WriteUntil(536870912, output);
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasA) {
          size += pb::CodedOutputStream.ComputeInt32Size(1, A);
        }
        size += ExtensionsSerializedSize;
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static TestMessage ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestMessage ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestMessage ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestMessage ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static TestMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static TestMessage ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private TestMessage MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestMessage prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::ExtendableBuilder<TestMessage, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(TestMessage cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private TestMessage result;
      
      private TestMessage PrepareBuilder() {
        if (resultIsReadOnly) {
          TestMessage original = result;
          result = new TestMessage();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override TestMessage MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage.Descriptor; }
      }
      
      public override TestMessage DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage.DefaultInstance; }
      }
      
      public override TestMessage BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is TestMessage) {
          return MergeFrom((TestMessage) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(TestMessage other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.NoGenericService.TestMessage.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasA) {
          A = other.A;
        }
          this.MergeExtensionFields(other);
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_testMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _testMessageFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasA = input.ReadInt32(ref result.a_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasA {
        get { return result.hasA; }
      }
      public int A {
        get { return result.A; }
        set { SetA(value); }
      }
      public Builder SetA(int value) {
        PrepareBuilder();
        result.hasA = true;
        result.a_ = value;
        return this;
      }
      public Builder ClearA() {
        PrepareBuilder();
        result.hasA = false;
        result.a_ = 0;
        return this;
      }
    }
    static TestMessage() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.NoGenericService.UnitTestNoGenericServicesProtoFile.Descriptor, null);
    }
  }
  
  #endregion
  
  #region Services
  /*
  * Service generation is now disabled by default, use the following option to enable:
  * option (google.protobuf.csharp_file_options).service_generator_type = GENERIC;
  */
  #endregion
  
}

#endregion Designer generated code
