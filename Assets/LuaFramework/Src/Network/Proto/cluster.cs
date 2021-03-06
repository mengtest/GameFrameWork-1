// Code generated by protogen.
// DO NOT EDIT!!!
// source:  cluster.proto
//
using CitrusNet;
using CitrusNet.Phobos;
using System.Collections.Generic;

namespace cluster.proto {
    
    [ProtoBuf.ProtoContract]
    public enum EMsgIds {
        
        ESS_Tick = 10,
        
        ESS_ClientRequestRedirect = 11,
        
        ESS_ClientRequest = 17,
        
        ESS_ClientResponse = 18,
        
        ESS_ResourceMsgTransmit = 19,
    }


    
    [ProtoBuf.ProtoContract]
    public class SS_Tick : NetCommand {
    }

    // 玩家所在baseapp的重定向
    [ProtoBuf.ProtoContract]
    public class SS_ClientRequestRedirect : NetCommand {
        
        [ProtoBuf.ProtoMember(1)]
        public string uuid { get; set; }
        
        [ProtoBuf.ProtoMember(2)]
        public SS_ClientRequest request { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class SS_ClientRequest : NetCommand {
        // 请求资源类型
        [ProtoBuf.ProtoMember(1)]
        public string resType { get; set; }
        // 请求资源行为
        [ProtoBuf.ProtoMember(2)]
        public string resOpt { get; set; }
        // 请求资源唯一id
        [ProtoBuf.ProtoMember(3)]
        public string resId { get; set; }
        // 已经被重定向的次数
        [ProtoBuf.ProtoMember(4)]
        public int redirectTimes { get; set; }
        // 来自哪里
        [ProtoBuf.ProtoMember(5)]
        public int frontService { get; set; }
        
        [ProtoBuf.ProtoMember(6)]
        public string channelId { get; set; }
        
        [ProtoBuf.ProtoMember(7)]
        public CC_ClientHead head { get; set; }
        
        [ProtoBuf.ProtoMember(9)]
        public int contentType { get; set; }
        
        [ProtoBuf.ProtoMember(10)]
        public int contentId { get; set; }
        
        [ProtoBuf.ProtoMember(11)]
        public byte[] content { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class SS_ClientResponse : NetCommand {
        // 来自哪里
        [ProtoBuf.ProtoMember(1)]
        public int frontService { get; set; }
        
        [ProtoBuf.ProtoMember(2)]
        public string channelId { get; set; }
        
        [ProtoBuf.ProtoMember(3)]
        public CC_ClientHead head { get; set; }
        
        [ProtoBuf.ProtoMember(4)]
        public int contentType { get; set; }
        
        [ProtoBuf.ProtoMember(5)]
        public int contentId { get; set; }
        
        [ProtoBuf.ProtoMember(6)]
        public byte[] content { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class CC_ClientHead : NetCommand {
        
        [ProtoBuf.ProtoContract]
        public class MetasEntry : NetCommand {
            
            public string key { get; set; }
            
            public string value { get; set; }
        }
        
        [ProtoBuf.ProtoContract]
        public class MetaiEntry : NetCommand {
            
            public long key { get; set; }
            
            public long value { get; set; }
        }
        
        [ProtoBuf.ProtoMember(1)]
        public uint requestId { get; set; }
        
        [ProtoBuf.ProtoMember(2)]
        public int error { get; set; }
        
        [ProtoBuf.ProtoMember(3)]
        public Dictionary<string, string> metas { get; set; }
        
        [ProtoBuf.ProtoMember(4)]
        public Dictionary<long, long> metai { get; set; }
    }

    
    [ProtoBuf.ProtoContract]
    public class SS_ResourceMsgTransmit : NetCommand {
        
        [ProtoBuf.ProtoMember(1)]
        public bool request { get; set; }
        // 来自哪里
        [ProtoBuf.ProtoMember(2)]
        public string from { get; set; }
        
        [ProtoBuf.ProtoMember(3)]
        public string to { get; set; }
        // requestid == 0表示不需要回复, 其它表示需要回复
        [ProtoBuf.ProtoMember(7)]
        public int code { get; set; }
        
        [ProtoBuf.ProtoMember(8)]
        public string error { get; set; }
        
        [ProtoBuf.ProtoMember(4)]
        public long requestid { get; set; }
        
        [ProtoBuf.ProtoMember(5)]
        public int contentId { get; set; }
        
        [ProtoBuf.ProtoMember(6)]
        public byte[] content { get; set; }
    }


}