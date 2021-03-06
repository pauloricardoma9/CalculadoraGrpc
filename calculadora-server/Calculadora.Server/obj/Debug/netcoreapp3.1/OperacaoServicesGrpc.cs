// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: operacao_services.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Calculadora.Server.Protos {
  public static partial class OperacaoService
  {
    static readonly string __ServiceName = "server.OperacaoService";

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
    static readonly grpc::Marshaller<global::Calculadora.Server.Protos.Message.ValoresRequest> __Marshaller_server_ValoresRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculadora.Server.Protos.Message.ValoresRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculadora.Server.Protos.Message.ResultadoResponse> __Marshaller_server_ResultadoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculadora.Server.Protos.Message.ResultadoResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse> __Method_Somar = new grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Somar",
        __Marshaller_server_ValoresRequest,
        __Marshaller_server_ResultadoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse> __Method_Subtrair = new grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Subtrair",
        __Marshaller_server_ValoresRequest,
        __Marshaller_server_ResultadoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse> __Method_Multiplicar = new grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Multiplicar",
        __Marshaller_server_ValoresRequest,
        __Marshaller_server_ResultadoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse> __Method_Dividir = new grpc::Method<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Dividir",
        __Marshaller_server_ValoresRequest,
        __Marshaller_server_ResultadoResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Calculadora.Server.Protos.OperacaoServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OperacaoService</summary>
    [grpc::BindServiceMethod(typeof(OperacaoService), "BindService")]
    public abstract partial class OperacaoServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Server.Protos.Message.ResultadoResponse> Somar(global::Calculadora.Server.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Server.Protos.Message.ResultadoResponse> Subtrair(global::Calculadora.Server.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Server.Protos.Message.ResultadoResponse> Multiplicar(global::Calculadora.Server.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Server.Protos.Message.ResultadoResponse> Dividir(global::Calculadora.Server.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(OperacaoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Somar, serviceImpl.Somar)
          .AddMethod(__Method_Subtrair, serviceImpl.Subtrair)
          .AddMethod(__Method_Multiplicar, serviceImpl.Multiplicar)
          .AddMethod(__Method_Dividir, serviceImpl.Dividir).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OperacaoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Somar, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(serviceImpl.Somar));
      serviceBinder.AddMethod(__Method_Subtrair, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(serviceImpl.Subtrair));
      serviceBinder.AddMethod(__Method_Multiplicar, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(serviceImpl.Multiplicar));
      serviceBinder.AddMethod(__Method_Dividir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Server.Protos.Message.ValoresRequest, global::Calculadora.Server.Protos.Message.ResultadoResponse>(serviceImpl.Dividir));
    }

  }
}
#endregion
