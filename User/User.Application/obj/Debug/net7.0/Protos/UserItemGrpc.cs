// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/UserItem.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserApp.Application {
  public static partial class UserItem
  {
    static readonly string __ServiceName = "UserItem";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.createUserRequest> __Marshaller_createUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.createUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.createUserResponse> __Marshaller_createUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.createUserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.GetAllUserRequest> __Marshaller_GetAllUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.GetAllUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.GetAllUserResponse> __Marshaller_GetAllUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.GetAllUserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.ReadUserRequest> __Marshaller_ReadUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.ReadUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.ReadUserResponse> __Marshaller_ReadUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.ReadUserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.UpdateUserRequest> __Marshaller_UpdateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.UpdateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserApp.Application.UpdateUserResponse> __Marshaller_UpdateUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserApp.Application.UpdateUserResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserApp.Application.createUserRequest, global::UserApp.Application.createUserResponse> __Method_createUser = new grpc::Method<global::UserApp.Application.createUserRequest, global::UserApp.Application.createUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "createUser",
        __Marshaller_createUserRequest,
        __Marshaller_createUserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserApp.Application.GetAllUserRequest, global::UserApp.Application.GetAllUserResponse> __Method_ListUser = new grpc::Method<global::UserApp.Application.GetAllUserRequest, global::UserApp.Application.GetAllUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListUser",
        __Marshaller_GetAllUserRequest,
        __Marshaller_GetAllUserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserApp.Application.ReadUserRequest, global::UserApp.Application.ReadUserResponse> __Method_ReadToDo = new grpc::Method<global::UserApp.Application.ReadUserRequest, global::UserApp.Application.ReadUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadToDo",
        __Marshaller_ReadUserRequest,
        __Marshaller_ReadUserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserApp.Application.UpdateUserRequest, global::UserApp.Application.UpdateUserResponse> __Method_UpdateUser = new grpc::Method<global::UserApp.Application.UpdateUserRequest, global::UserApp.Application.UpdateUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateUser",
        __Marshaller_UpdateUserRequest,
        __Marshaller_UpdateUserResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserApp.Application.UserItemReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserItem</summary>
    [grpc::BindServiceMethod(typeof(UserItem), "BindService")]
    public abstract partial class UserItemBase
    {
      /// <summary>
      ///create
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserApp.Application.createUserResponse> createUser(global::UserApp.Application.createUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///getAll
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserApp.Application.GetAllUserResponse> ListUser(global::UserApp.Application.GetAllUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///Get One
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserApp.Application.ReadUserResponse> ReadToDo(global::UserApp.Application.ReadUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///}
      ///Update
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserApp.Application.UpdateUserResponse> UpdateUser(global::UserApp.Application.UpdateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UserItemBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_createUser, serviceImpl.createUser)
          .AddMethod(__Method_ListUser, serviceImpl.ListUser)
          .AddMethod(__Method_ReadToDo, serviceImpl.ReadToDo)
          .AddMethod(__Method_UpdateUser, serviceImpl.UpdateUser).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserItemBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_createUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserApp.Application.createUserRequest, global::UserApp.Application.createUserResponse>(serviceImpl.createUser));
      serviceBinder.AddMethod(__Method_ListUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserApp.Application.GetAllUserRequest, global::UserApp.Application.GetAllUserResponse>(serviceImpl.ListUser));
      serviceBinder.AddMethod(__Method_ReadToDo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserApp.Application.ReadUserRequest, global::UserApp.Application.ReadUserResponse>(serviceImpl.ReadToDo));
      serviceBinder.AddMethod(__Method_UpdateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserApp.Application.UpdateUserRequest, global::UserApp.Application.UpdateUserResponse>(serviceImpl.UpdateUser));
    }

  }
}
#endregion
