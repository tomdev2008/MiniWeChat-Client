//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ChatData.proto
namespace protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatItem")]
  public partial class ChatItem : global::ProtoBuf.IExtensible
  {
    public ChatItem() {}
    
    private string _sendUserId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"sendUserId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sendUserId
    {
      get { return _sendUserId; }
      set { _sendUserId = value; }
    }
    private string _receiveUserId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"receiveUserId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string receiveUserId
    {
      get { return _receiveUserId; }
      set { _receiveUserId = value; }
    }
    private protocol.ChatItem.ChatType _chatType;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"chatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public protocol.ChatItem.ChatType chatType
    {
      get { return _chatType; }
      set { _chatType = value; }
    }
    private string _chatBody;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"chatBody", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string chatBody
    {
      get { return _chatBody; }
      set { _chatBody = value; }
    }
    private long _date = default(long);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"date", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long date
    {
      get { return _date; }
      set { _date = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ChatType")]
    public enum ChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TEXT", Value=0)]
      TEXT = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IMAGE", Value=1)]
      IMAGE = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}