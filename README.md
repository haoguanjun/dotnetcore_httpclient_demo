# dotnetcore_httpclient_demo

## .NET 是什么？

* [一文搞清到底什么是 .NET?](https://www.cnblogs.com/haogj/p/9265031.html)

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

See: [Fake JSON Server 中文文档](https://www.cnblogs.com/haogj/p/16482959.html)

## 依赖注入

* [依赖注入在 dotnet core 中实现与使用：1 基本概念 ](https://www.cnblogs.com/haogj/p/11370314.html)
* [依赖注入在 dotnet core 中实现与使用：2 使用 Extensions DependencyInjection](https://www.cnblogs.com/haogj/p/11375019.html)
* [依赖注入在 dotnet core 中实现与使用：3 使用 Lazy<T> 延迟实例化](https://www.cnblogs.com/haogj/p/11450422.html)
* [依赖注入在 dotnet core 中实现与使用：4. 集成 Autofac ](https://www.cnblogs.com/haogj/p/13683730.html)
* [依赖注入在 dotnet core 中实现与使用：5. 使用支持 Unicode 的 HtmlEncoder](https://www.cnblogs.com/haogj/p/13785680.html)

## Configuration

* [ASP.NET Core: ConfigurationBuilder](https://www.cnblogs.com/haogj/p/13896680.html)

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

### 5. 集成 Serilog
* [在 .NET 中集成 Serilog](https://www.cnblogs.com/haogj/p/16437590.html)

## Server

* [ASP.NET Core 中的 Request Feature](https://www.cnblogs.com/haogj/p/16344208.html)

## 处理管道

* [理解 ASP.NET Core 处理管道](https://www.cnblogs.com/haogj/p/13756143.html)

## 认证

* [理解 ASP.NET Core： 认证](https://www.cnblogs.com/haogj/p/13991648.html)
* [理解 ASP.NET Core：Cookie 认证](https://www.cnblogs.com/haogj/p/14040546.html)

## HttpClient

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

* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（上篇）](https://mp.weixin.qq.com/s/VfyrwARblQJgS7D2Q_Ny6A)
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（中篇）](https://www.cnblogs.com/willick/p/HttpClientFactory-Polly-2.html)
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（下篇）](https://www.cnblogs.com/willick/p/HttpClientFactory-Polly-3.html)
* [通过 IHttpClientFactory 和 Polly 策略实现使用指数退避算法的 HTTP 调用重试](https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/implement-resilient-applications/implement-http-call-retries-exponential-backoff-polly)


## Web API

* [使用 ASP.NET Core 5 Web API 创建可发现的 HTTP API](https://www.cnblogs.com/haogj/p/14494731.html)