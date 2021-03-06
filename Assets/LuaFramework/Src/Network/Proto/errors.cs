// Code generated by protogen.
// DO NOT EDIT!!!
// source:  errors.proto
//
using CitrusNet;
using CitrusNet.Phobos;
using System.Collections.Generic;

namespace errors.proto {
    
    [ProtoBuf.ProtoContract]
    public enum E_Code {
        
        E_Ok = 0,
        
        E_Error = 1,
        
        E_PathNotFound = 404,
        
        E_Forbidden = 403,
        
        E_Unauthorized = 401,
        
        E_Reset = 205,
        
        E_BadRequest = 400,
        // 服务器内部错误
        E_InternalError = 500,
        // 服务器繁忙
        E_ServerIsBusy = 600,
        // api转发失败
        E_ApiForwardFailed = 601,
        // 认证失败
        E_AuthFailed = 602,
    }



}