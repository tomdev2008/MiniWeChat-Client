//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ChatLog.proto
// Note: requires additional types generated from: ChatDataItem.proto
namespace MiniWeChat
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatLog")]
  public partial class ChatLog : global::ProtoBuf.IExtensible
  {
    public ChatLog() {}
    
    private long _date = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"date", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long date
    {
      get { return _date; }
      set { _date = value; }
    }
    private readonly global::System.Collections.Generic.List<MiniWeChat.ChatDataItem> _itemList = new global::System.Collections.Generic.List<MiniWeChat.ChatDataItem>();
    [global::ProtoBuf.ProtoMember(3, Name=@"itemList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<MiniWeChat.ChatDataItem> itemList
    {
      get { return _itemList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}