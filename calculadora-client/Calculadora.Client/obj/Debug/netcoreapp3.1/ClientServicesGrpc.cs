// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: client_services.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Calculadora.Client.Protos {
  public static partial class ClientService
  {
    static readonly string __ServiceName = "client.ClientService";

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
    static readonly grpc::Marshaller<global::Calculadora.Client.Protos.Message.ValoresRequest> __Marshaller_client_ValoresRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculadora.Client.Protos.Message.ValoresRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculadora.Client.Protos.Message.ResultadoResponse> __Marshaller_client_ResultadoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculadora.Client.Protos.Message.ResultadoResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse> __Method_Somar = new grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Somar",
        __Marshaller_client_ValoresRequest,
        __Marshaller_client_ResultadoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse> __Method_Subtrair = new grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Subtrair",
        __Marshaller_client_ValoresRequest,
        __Marshaller_client_ResultadoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse> __Method_Multiplicar = new grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Multiplicar",
        __Marshaller_client_ValoresRequest,
        __Marshaller_client_ResultadoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse> __Method_Dividir = new grpc::Method<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Dividir",
        __Marshaller_client_ValoresRequest,
        __Marshaller_client_ResultadoResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Calculadora.Client.Protos.ClientServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClientService</summary>
    [grpc::BindServiceMethod(typeof(ClientService), "BindService")]
    public abstract partial class ClientServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Client.Protos.Message.ResultadoResponse> Somar(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Client.Protos.Message.ResultadoResponse> Subtrair(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Client.Protos.Message.ResultadoResponse> Multiplicar(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculadora.Client.Protos.Message.ResultadoResponse> Dividir(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ClientService</summary>
    public partial class ClientServiceClient : grpc::ClientBase<ClientServiceClient>
    {
      /// <summary>Creates a new client for ClientService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ClientServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClientService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ClientServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ClientServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ClientServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Somar(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Somar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Somar(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Somar, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> SomarAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SomarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> SomarAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Somar, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Subtrair(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subtrair(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Subtrair(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Subtrair, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> SubtrairAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubtrairAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> SubtrairAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Subtrair, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Multiplicar(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Multiplicar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Multiplicar(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Multiplicar, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> MultiplicarAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MultiplicarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> MultiplicarAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Multiplicar, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Dividir(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Dividir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculadora.Client.Protos.Message.ResultadoResponse Dividir(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Dividir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> DividirAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DividirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculadora.Client.Protos.Message.ResultadoResponse> DividirAsync(global::Calculadora.Client.Protos.Message.ValoresRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Dividir, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ClientServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ClientServiceBase serviceImpl)
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
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClientServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Somar, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(serviceImpl.Somar));
      serviceBinder.AddMethod(__Method_Subtrair, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(serviceImpl.Subtrair));
      serviceBinder.AddMethod(__Method_Multiplicar, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(serviceImpl.Multiplicar));
      serviceBinder.AddMethod(__Method_Dividir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculadora.Client.Protos.Message.ValoresRequest, global::Calculadora.Client.Protos.Message.ResultadoResponse>(serviceImpl.Dividir));
    }

  }
}
#endregion
