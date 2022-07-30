# dotnetcore_httpclient_demo

## .NET 是什么？

* [一文搞清到底什么是 .NET?](https://www.cnblogs.com/haogj/p/9265031.html)
* [.NET 官方站点](https://dot.net/)
* [Benchmarks](https://www.techempower.com/benchmarks/#section=data-r20)
* [.NET 的测试项目](https://github.com/TechEmpower/FrameworkBenchmarks/tree/master/frameworks/CSharp/aspnetcore)

## RESTful Web API 设计

根据 HTTP 方法定义 API 操作
HTTP 协议定义了大量为请求赋于语义的方法。 大多数 RESTful Web API 使用的常见 HTTP 方法是：

* GET 检索位于指定 URI 处的资源的表示形式。 响应消息的正文包含所请求资源的详细信息。
* POST 在指定的 URI 处创建新资源。 请求消息的正文将提供新资源的详细信息。 请注意，POST 还用于触发不实际创建资源的操作。
* PUT 在指定的 URI 处创建或替换资源。 请求消息的正文指定要创建或更新的资源。
* PATCH 对资源执行部分更新。 请求正文包含要应用到资源的一组更改。
* DELETE 删除位于指定 URI 处的资源。

See: [RESTful Web API 设计](https://docs.microsoft.com/zh-cn/azure/architecture/best-practices/api-design)

## Fake JSON Server

Fake JSON Server 是使用 .NET Web API 开发的模拟 Web API 服务器，提供标准的 REST API 支持，可以作为原型来模拟后端 API，或者临时用于 CRUD 的后端。Fake JSON Server 可以作为体验版的 GraphQL 查询和变化支持。

* 不需要定义资源类型，直接使用动态类型
* 不需要定义路由，路由动态处理
* 不需要数据库，数据保存在单个 JSON 文件中
* 不需要准备，只需要启动该服务器，API 就可以用于任何数据

### 项目地址
[.NET Fake JSON Server 模拟 JSON 服务器](https://github.com/haoguanjun/dotnet-fake-json-server)

### 文档
* [Fake JSON Server 中文文档](https://www.cnblogs.com/haogj/p/16482959.html)
* [Fiddler 抓取 https 设置详解](https://www.cnblogs.com/joe235/p/14393412.html)

## Web 开发工具

* [Fiddler Classic](https://www.telerik.com/fiddler/fiddler-classic) 通用的 HTTP 协议查看器
* [Postman](https://www.postman.com/downloads/) 专业的 API 开发测试工具
* [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) 集成于 Visual Studio Code 中的 REST 客户端工具

## 依赖注入

### 技术资料

* [依赖注入在 dotnet core 中实现与使用：1 基本概念 ](https://www.cnblogs.com/haogj/p/11370314.html)
* [依赖注入在 dotnet core 中实现与使用：2 使用 Extensions DependencyInjection](https://www.cnblogs.com/haogj/p/11375019.html)
* [依赖注入在 dotnet core 中实现与使用：3 使用 Lazy<T> 延迟实例化](https://www.cnblogs.com/haogj/p/11450422.html)
* [依赖注入在 dotnet core 中实现与使用：4. 集成 Autofac ](https://www.cnblogs.com/haogj/p/13683730.html)
* [依赖注入在 dotnet core 中实现与使用：5. 使用支持 Unicode 的 HtmlEncoder](https://www.cnblogs.com/haogj/p/13785680.html)

### NuGet
* [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)

## Configuration

给定一个或多个配置源，该 IConfiguration 类型提供配置数据的统一视图。 配置是只读的，配置模式不设计为以编程方式可写。 接口 IConfiguration 是所有配置源的单个表示形式，如下图所示：
![](https://docs.microsoft.com/zh-cn/dotnet/core/extensions/media/configuration-sources.svg#lightbox)

### 技术资料
* [.NET 中的配置](https://docs.microsoft.com/zh-cn/dotnet/core/extensions/configuration)
* [Options 模式](https://docs.microsoft.com/en-us/dotnet/core/extensions/options)
* [ASP.NET Core: ConfigurationBuilder](https://www.cnblogs.com/haogj/p/13896680.html)

### NuGet
* [Microsoft.Extensions.Configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/) 配置核心包，内置支持基于内存的配置
* [Microsoft.Extensions.Configuration.Json](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/) 提供基于 JSON 配置文件支持
* [Microsoft.Extensions.Configuration.EnvironmentVariables](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.EnvironmentVariables/) 提供基于环境变量的配置支持，环境变量前缀 ASPNET_ENVIRONMENT
* [Microsoft.Extensions.Configuration.CommandLine ](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.CommandLine/) 提供基于命令行参数的配置支持
* [Microsoft.Extensions.Configuration.Binder](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Binder/) 提供将配置中的配置数据绑定到对象上，提供 .Get<T> 扩展方法和 Bind() 扩展方法
* [Microsoft.Extensions.Options](https://www.nuget.org/packages/Microsoft.Extensions.Options/) 基于依赖注入，提供强类型的方式访问配置信息
* [Microsoft.Extensions.Options.ConfigurationExtensions](https://www.nuget.org/packages/Microsoft.Extensions.Options.ConfigurationExtensions/) 提供 Configure<TOptions> 扩展方法，完成绑定和注册到依赖注入容器两步操作

## Host

* [理解 ASP.NET Core: Host](https://www.cnblogs.com/haogj/p/13885461.html)
* [ASP.NET Core IHostBuilder](https://www.cnblogs.com/haogj/p/13895947.html)
* [理解 ASP.NET Core: 实现 Application_Start 和 Application_End](https://www.cnblogs.com/haogj/p/13969359.html)

## 日志 Log

.NET 环境下原生就支持多种形式的日志导出方式，它们各有其特殊的使用场景和用途。
### 1. Debugger
该静态类型是针对开发环境下，例如在 Visual Studio 开发中，支持 .NET 与调试器进行通信的媒介。在将调试器附加到应用进程之后，可以在 Dubugger 调试输出窗口中看到输出的日志信息。它只在调试模式有效。使用较少。

### 2. TraceSource 跟踪日志
基于观察者模式，只有一种 TraceSource 类型，可以通过名称和最低日志级别创建一个 TraceSource 对象，入喉记录日志。在调试模式下，因为日志框架注册了类型为 DefaultTraceListener 的监听器，可以在 Visual Studio 的输出窗口中看到日志输出。

### 3. EventSource 事件日志
支持 ETW，可以有多种派生类型进行区分。性能高效。EventListener 并不需要显式注册。

支持强类型编程模型：
1. 需要从 EventSource 派生出具体的 EventSource
2. 日志消息的内容可以通过自定义的数据类型来承载

由于 EventSource 具有向 ETW 日志系统发送日志的能力，可以利用一些工具来跨进程收集到这些消息。
* [PerfView](https://github.com/Microsoft/perfview)

### 4. 诊断日志 DiagnosticSource

DiagnosticSource 是进程内的日志方案，所以可以将日志内容以任何格式直接发送到订阅者，由订阅者自己决定对日志内容的处理。事件的触发和监听是同步执行的。

### 5. 内置的 Log Provider

Log Provider 负责提供输出日志的持久化，除了只有 Console 仅仅输出到控制台。

Microsoft Extensions 包含如下的日志提供器，作为运行时库的一部分:
* [Console](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Console/)
* [Debug](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Debug/)
* [EventSource](https://www.nuget.org/packages/Microsoft.Extensions.Logging.EventSource/)
* [EventLog](https://www.nuget.org/packages/Microsoft.Extensions.Logging.EventLog/)

在调用 CreateDefaultBuilder() 的时候, 添加了如下的 logging providers:
* Console
* Debug
* EventSource
* EventLog (Windows only)

清理默认的 logging provider 和增加的示例：

```csharp
static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddConsole();
        });
```

这里的 AddConsole() 就是来自 Microsoft.Extensions.Logging.Console 的一个扩展方法
    
```csharp
public static Microsoft.Extensions.Logging.ILoggingBuilder AddConsole (this Microsoft.Extensions.Logging.ILoggingBuilder builder);
```

### 6. 集成 Serilog
* [在 .NET 中集成 Serilog](https://www.cnblogs.com/haogj/p/16437590.html)

## Server

* [ASP.NET Core 中的 Request Feature](https://www.cnblogs.com/haogj/p/16344208.html)

## 处理管道

* [理解 ASP.NET Core 处理管道](https://www.cnblogs.com/haogj/p/13756143.html)

## 认证

* [理解 ASP.NET Core： 认证](https://www.cnblogs.com/haogj/p/13991648.html)
* [理解 ASP.NET Core：Cookie 认证](https://www.cnblogs.com/haogj/p/14040546.html)

## HttpClient

.NET Core 2.1 开始引入的 HttpClientFactory 改善了针对 HttpClient 的使用。

AddTransientHttpErrorPolicy() 方法，可以很方便地配置一个策略来处理下面这些典型的HTTP调用错误
* 网络错误（HttpRequestException 异常）
* HTTP状态码 5XX（服务器错误）
* HTTP状态码 408（请求超时）

技术资料

* [HttpClientFactory in ASP.NET Core 2.1 Part 1](https://www.cnblogs.com/haogj/p/13807222.html)
* [HttpClientFactory in ASP.NET Core 2.1 Part 2：定义命名和类型化的客户端](https://www.cnblogs.com/haogj/p/13807218.html)
* [HttpClientFactory in ASP.NET Core 2.1 Part 3: 对处理器使用对外请求中间件](https://www.cnblogs.com/haogj/p/13807210.html)
* [HttpClientFacotry Part 4: 集成 Polly 处理瞬时失效](https://www.cnblogs.com/haogj/p/13807208.html)
* [HttpClientFactory in ASP.NET Core 2.1 Part 5: 日志](https://www.cnblogs.com/haogj/p/13807204.html)
* [.NetCore HttpClient发送请求的时候为什么自动带上了一个RequestId头部？](https://www.cnblogs.com/haogj/p/13952211.html)

### NuGet

* [System.Net.Http](https://www.nuget.org/packages/System.Net.Http) 基础的 HttpClient 定义
* [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/), 提供注册到依赖注入容器的扩展方法，提供对 HttpClientFactory 模式的支持
* [System.Net.Http.Json](https://www.nuget.org/packages/System.Net.Http.Json)，提供对于 HttpClient 和 HttpContent 的扩展方法，通过 System.Text.Json 提供对于序列化和反序列化的支持
* [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) 提供 将 Polly 集成到 IHttpClientFactory。增加对于瞬时失败处理，以及诸如重试、断路器、超时、隔板隔离以及回落等流畅策略支持弹性访问。

## Polly

### 技术资料
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（上篇）](https://mp.weixin.qq.com/s/VfyrwARblQJgS7D2Q_Ny6A)
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（中篇）](https://www.cnblogs.com/willick/p/HttpClientFactory-Polly-2.html)
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（下篇）](https://www.cnblogs.com/willick/p/HttpClientFactory-Polly-3.html)
* [通过 IHttpClientFactory 和 Polly 策略实现使用指数退避算法的 HTTP 调用重试](https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/implement-resilient-applications/implement-http-call-retries-exponential-backoff-polly)


### NuGet
* [Polly](https://www.nuget.org/packages/Polly/) Polly 的核心包，大多数场景不需要直接引用，会通过间接方式引用它。
* [Polly.Extensions.Http](https://www.nuget.org/packages/Polly.Extensions.Http) Polly 自己的策略扩展包，一般也是通过间接方式使用


## Web API

* [使用 ASP.NET Core 5 Web API 创建可发现的 HTTP API](https://www.cnblogs.com/haogj/p/14494731.html)

### Carter

项目地址：https://github.com/CarterCommunity/Carter

Carter is a framework that is a thin layer of extension methods and functionality over ASP.NET Core allowing the code to be more explicit and most importantly more enjoyable.

For a better understanding, take a good look at the samples inside this repo. The samples demonstrate usages of elegant extensions around common ASP.NET Core types as shown below.
    
### Orleans
    
项目地址：https://github.com/dotnet/orleans

Orleans is a cross-platform framework for building robust, scalable distributed applications
Orleans builds on the developer productivity of .NET and brings it to the world of distributed applications, such as cloud services. Orleans scales from a single on-premises server to globally distributed, highly-available applications in the cloud.

Orleans takes familiar concepts like objects, interfaces, async/await, and try/catch and extends them to multi-server environments. As such, it helps developers experienced with single-server applications transition to building resilient, scalable cloud services and other distributed applications. For this reason, Orleans has often been referred to as "Distributed .NET".

### MediatR

项目地址：https://github.com/jbogard/MediatR
    
Simple mediator implementation in .NET

In-process messaging with no dependencies.

Supports request/response, commands, queries, notifications and events, synchronous and async with intelligent dispatching via C# generic variance.

Examples in the wiki.
    
### FluentValidation
    
项目地址：https://github.com/FluentValidation/FluentValidation
    
A validation library for .NET that uses a fluent interface and lambda expressions for building strongly-typed validation rules.

### YARP

Video: https://docs.microsoft.com/zh-cn/shows/on-net/yarp-the-net-reverse-proxy

源码地址：https://github.com/microsoft/reverse-proxy

YARP is a reverse proxy toolkit for building fast proxy servers in .NET using the infrastructure from ASP.NET and .NET. The key differentiator for YARP is that it's been designed to be easily customized and tweaked to match the specific needs of each deployment scenario.

### Autofac
    
官方站点：https://autofac.org/

https://github.com/autofac/Autofac
    
### PdfSharp
    
源码地址：https://github.com/empira/PDFsharp

A .NET library for processing PDF
    
### Pdfium
    
https://github.com/chromium/pdfium
    
### Pdfium.NET SDK
    
https://www.nuget.org/packages/Pdfium.Net.SDK
    
Pdfium.NET SDK it's a class library based on the PDFium project for viewing, text extracting, navigating and editing PDF files in your .NET projects. With the PDF Viewer control, you can display PDF files directly in your WinForms and WPF application without the need to install an external PDF viewer application on your end user's machine. This control supports zooming, scrolling, bookmarks, text search, continuous page layout and provides a ready-to-go toolbars, so you can quickly incorporate it into your application.

### Pdfium Viewer
    
https://www.nuget.org/packages/PdfiumViewer/
    
PDF viewer based on the PDFium project.

### Mongo DB driver

https://www.nuget.org/packages/MongoDB.Driver
    
### Redis

https://www.nuget.org/packages/StackExchange.Redis/

High performance Redis client, incorporating both synchronous and asynchronous usage.
