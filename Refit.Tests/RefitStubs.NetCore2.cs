﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xunit;
using Nustache;
using Nustache.Core;
using Refit;
using Refit.Generator;
using Task =  System.Threading.Tasks.Task;
using System.Net;
using System.Reactive.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RichardSzalay.MockHttp;
using static System.Math;
using SomeType =  CollisionA.SomeType;
using CollisionB;
using System.Reflection;
using System.Threading;
using System.Net.Http.Headers;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIAmARefitInterfaceButNobodyUsesMe : IAmARefitInterfaceButNobodyUsesMe
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIAmARefitInterfaceButNobodyUsesMe(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task RefitMethod()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("RefitMethod", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task AnotherRefitMethod()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("AnotherRefitMethod", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NoConstantsAllowed()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

        /// <inheritdoc />
        public virtual Task SpacesShouldntBreakMe()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("SpacesShouldntBreakMe", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task ReservedWordsForParameterNames(int @int,string @string,float @long)
        {
            var arguments = new object[] { @int,@string,@long };
            var func = requestBuilder.BuildRestResultFuncForMethod("ReservedWordsForParameterNames", new Type[] { typeof(int),typeof(string),typeof(float) });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIAmHalfRefit : IAmHalfRefit
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIAmHalfRefit(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIApiWithDecimal : IApiWithDecimal
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIApiWithDecimal(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> GetWithDecimal(decimal value)
        {
            var arguments = new object[] { value };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetWithDecimal", new Type[] { typeof(decimal) });
            return (Task<string>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIBodylessApi : IBodylessApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIBodylessApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Head()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Head", new Type[] {  });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIBoringCrudApi<T, TKey> : IBoringCrudApi<T, TKey>
        where T : class
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIBoringCrudApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<T> Create(T paylod)
        {
            var arguments = new object[] { paylod };
            var func = requestBuilder.BuildRestResultFuncForMethod("Create", new Type[] { typeof(T) });
            return (Task<T>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<T>> ReadAll()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("ReadAll", new Type[] {  });
            return (Task<List<T>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<T> ReadOne(TKey key)
        {
            var arguments = new object[] { key };
            var func = requestBuilder.BuildRestResultFuncForMethod("ReadOne", new Type[] { typeof(TKey) });
            return (Task<T>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Update(TKey key,T payload)
        {
            var arguments = new object[] { key,payload };
            var func = requestBuilder.BuildRestResultFuncForMethod("Update", new Type[] { typeof(TKey),typeof(T) });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Delete(TKey key)
        {
            var arguments = new object[] { key };
            var func = requestBuilder.BuildRestResultFuncForMethod("Delete", new Type[] { typeof(TKey) });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIBrokenWebApi : IBrokenWebApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIBrokenWebApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<bool> PostAValue(string derp)
        {
            var arguments = new object[] { derp };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostAValue", new Type[] { typeof(string) });
            return (Task<bool>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIGitHubApi : IGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) });
            return (Task<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserObservable", new Type[] { typeof(string) });
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserCamelCase", new Type[] { typeof(string) });
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetOrgMembers", new Type[] { typeof(string) });
            return (Task<List<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            var func = requestBuilder.BuildRestResultFuncForMethod("FindUsers", new Type[] { typeof(string) });
            return (Task<UserSearchResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetIndex", new Type[] {  });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetIndexObservable", new Type[] {  });
            return (IObservable<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<User> NothingToSeeHere()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHere", new Type[] {  });
            return (Task<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<User>> NothingToSeeHereWithMetadata()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHereWithMetadata", new Type[] {  });
            return (Task<ApiResponse<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<User>> GetUserWithMetadata(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserWithMetadata", new Type[] { typeof(string) });
            return (Task<ApiResponse<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<ApiResponse<User>> GetUserObservableWithMetadata(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserObservableWithMetadata", new Type[] { typeof(string) });
            return (IObservable<ApiResponse<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<User> CreateUser(User user)
        {
            var arguments = new object[] { user };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateUser", new Type[] { typeof(User) });
            return (Task<User>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIHttpBinApi<TResponse, TParam, THeader> : IHttpBinApi<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIHttpBinApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TParam),typeof(THeader) });
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQuery(TParam param)
        {
            var arguments = new object[] { param };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetQuery", new Type[] { typeof(TParam) });
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQueryWithIncludeParameterName(TParam param)
        {
            var arguments = new object[] { param };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetQueryWithIncludeParameterName", new Type[] { typeof(TParam) });
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TValue> GetQuery1<TValue>(TParam param)
        {
            var arguments = new object[] { param };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetQuery1", new Type[] { typeof(TParam) }, new Type[] { typeof(TValue) });
            return (Task<TValue>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIHttpContentApi : IHttpContentApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIHttpContentApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<HttpContent> PostFileUpload(HttpContent content)
        {
            var arguments = new object[] { content };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostFileUpload", new Type[] { typeof(HttpContent) });
            return (Task<HttpContent>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<HttpContent>> PostFileUploadWithMetadata(HttpContent content)
        {
            var arguments = new object[] { content };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostFileUploadWithMetadata", new Type[] { typeof(HttpContent) });
            return (Task<ApiResponse<HttpContent>>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedResponseTestsIMyAliasService : ResponseTests.IMyAliasService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedResponseTestsIMyAliasService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<TestAliasObject> GetTestObject()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetTestObject", new Type[] {  });
            return (Task<TestAliasObject>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedAuthenticatedClientHandlerTestsIMyAuthenticatedService : AuthenticatedClientHandlerTests.IMyAuthenticatedService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedAuthenticatedClientHandlerTestsIMyAuthenticatedService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> GetUnauthenticated()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUnauthenticated", new Type[] {  });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<string> GetAuthenticated()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAuthenticated", new Type[] {  });
            return (Task<string>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedINamespaceCollisionApi : INamespaceCollisionApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedINamespaceCollisionApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<SomeType> SomeRequest()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("SomeRequest", new Type[] {  });
            return (Task<SomeType>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedTestNestedINestedGitHubApi : TestNested.INestedGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedTestNestedINestedGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) });
            return (Task<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserObservable", new Type[] { typeof(string) });
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUserCamelCase", new Type[] { typeof(string) });
            return (IObservable<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetOrgMembers", new Type[] { typeof(string) });
            return (Task<List<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            var func = requestBuilder.BuildRestResultFuncForMethod("FindUsers", new Type[] { typeof(string) });
            return (Task<UserSearchResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetIndex", new Type[] {  });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetIndexObservable", new Type[] {  });
            return (IObservable<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("NothingToSeeHere", new Type[] {  });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedINonGenericInterfaceWithGenericMethod : INonGenericInterfaceWithGenericMethod
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedINonGenericInterfaceWithGenericMethod(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task PostMessage<T>(T message)
            where T : IMessage
        {
            var arguments = new object[] { message };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostMessage", new Type[] { typeof(T) }, new Type[] { typeof(T) });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostMessage<T, U, V>(T message,U param1,V param2)
            where T : IMessage where U : T
        {
            var arguments = new object[] { message,param1,param2 };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostMessage", new Type[] { typeof(T),typeof(U),typeof(V) }, new Type[] { typeof(T), typeof(U), typeof(V) });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedINpmJs : INpmJs
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedINpmJs(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<RootObject> GetCongruence()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetCongruence", new Type[] {  });
            return (Task<RootObject>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIRequestBin : IRequestBin
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIRequestBin(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Post", new Type[] {  });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostRawStringDefault(string str)
        {
            var arguments = new object[] { str };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostRawStringDefault", new Type[] { typeof(string) });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostRawStringJson(string str)
        {
            var arguments = new object[] { str };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostRawStringJson", new Type[] { typeof(string) });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostRawStringUrlEncoded(string str)
        {
            var arguments = new object[] { str };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostRawStringUrlEncoded", new Type[] { typeof(string) });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task PostGeneric<T>(T param)
        {
            var arguments = new object[] { param };
            var func = requestBuilder.BuildRestResultFuncForMethod("PostGeneric", new Type[] { typeof(T) }, new Type[] { typeof(T) });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIRunscopeApi : IRunscopeApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIRunscopeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStream(Stream stream)
        {
            var arguments = new object[] { stream };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadStream", new Type[] { typeof(Stream) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStreamPart(StreamPart stream)
        {
            var arguments = new object[] { stream };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadStreamPart", new Type[] { typeof(StreamPart) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytes(byte[] bytes)
        {
            var arguments = new object[] { bytes };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadBytes", new Type[] { typeof(byte[]) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytesPart(ByteArrayPart bytes)
        {
            var arguments = new object[] { bytes };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadBytesPart", new Type[] { typeof(ByteArrayPart) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadString(string someString)
        {
            var arguments = new object[] { someString };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadString", new Type[] { typeof(string) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadFileInfo", new Type[] { typeof(IEnumerable<FileInfo>),typeof(FileInfo) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadFileInfoPart", new Type[] { typeof(IEnumerable<FileInfoPart>),typeof(FileInfoPart) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadJsonObject(ModelObject theObject)
        {
            var arguments = new object[] { theObject };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadJsonObject", new Type[] { typeof(ModelObject) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadJsonObjects(IEnumerable<ModelObject> theObjects)
        {
            var arguments = new object[] { theObjects };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadJsonObjects", new Type[] { typeof(IEnumerable<ModelObject>) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadMixedObjects(IEnumerable<ModelObject> theObjects,AnotherModel anotherModel,FileInfo aFile,AnEnum anEnum,string aString,int anInt)
        {
            var arguments = new object[] { theObjects,anotherModel,aFile,anEnum,aString,anInt };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadMixedObjects", new Type[] { typeof(IEnumerable<ModelObject>),typeof(AnotherModel),typeof(FileInfo),typeof(AnEnum),typeof(string),typeof(int) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadHttpContent(HttpContent content)
        {
            var arguments = new object[] { content };
            var func = requestBuilder.BuildRestResultFuncForMethod("UploadHttpContent", new Type[] { typeof(HttpContent) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIStreamApi : IStreamApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIStreamApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<Stream> GetRemoteFile(string filename)
        {
            var arguments = new object[] { filename };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetRemoteFile", new Type[] { typeof(string) });
            return (Task<Stream>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<ApiResponse<Stream>> GetRemoteFileWithMetadata(string filename)
        {
            var arguments = new object[] { filename };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetRemoteFileWithMetadata", new Type[] { typeof(string) });
            return (Task<ApiResponse<Stream>>)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIUseOverloadedGenericMethods<TResponse, TParam, THeader> : IUseOverloadedGenericMethods<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIUseOverloadedGenericMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TParam),typeof(THeader) });
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(THeader param,TParam header)
        {
            var arguments = new object[] { param,header };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(THeader),typeof(TParam) });
            return (Task<TResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> Get(int httpstatuscode)
        {
            var arguments = new object[] { httpstatuscode };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TValue> Get<TValue>(int someVal)
        {
            var arguments = new object[] { someVal };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) }, new Type[] { typeof(TValue) });
            return (Task<TValue>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TValue> Get<TValue, TInput>(TInput input)
        {
            var arguments = new object[] { input };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TInput) }, new Type[] { typeof(TValue), typeof(TInput) });
            return (Task<TValue>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get<TInput1, TInput2>(TInput1 input1,TInput2 input2)
        {
            var arguments = new object[] { input1,input2 };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(TInput1),typeof(TInput2) }, new Type[] { typeof(TInput1), typeof(TInput2) });
            return (Task)func(Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    partial class AutoGeneratedIUseOverloadedMethods : IUseOverloadedMethods
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIUseOverloadedMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] {  });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> Get(int httpstatuscode)
        {
            var arguments = new object[] { httpstatuscode };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(int) });
            return (Task<HttpResponseMessage>)func(Client, arguments);
        }

    }
}
