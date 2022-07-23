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

## Host

* [理解 ASP.NET Core: Host](https://www.cnblogs.com/haogj/p/13885461.html)
* [理解 ASP.NET Core: 实现 Application_Start 和 Application_End](https://www.cnblogs.com/haogj/p/13969359.html)

## 处理管道

* [理解 ASP.NET Core 处理管道](https://www.cnblogs.com/haogj/p/13756143.html)

## 认证

* [理解 ASP.NET Core： 认证](https://www.cnblogs.com/haogj/p/13991648.html)

## HttpClient

* [HttpClientFactory in ASP.NET Core 2.1 Part 1](https://www.cnblogs.com/haogj/p/13807222.html)
* [HttpClientFactory in ASP.NET Core 2.1 Part 2：定义命名和类型化的客户端](https://www.cnblogs.com/haogj/p/13807218.html)
* [HttpClientFactory in ASP.NET Core 2.1 Part 3: 对处理器使用对外请求中间件](https://www.cnblogs.com/haogj/p/13807210.html)
* [HttpClientFacotry Part 4: 集成 Polly 处理瞬时失效](https://www.cnblogs.com/haogj/p/13807208.html)
* [HttpClientFactory in ASP.NET Core 2.1 Part 5: 日志](https://www.cnblogs.com/haogj/p/13807204.html)
* [.NetCore HttpClient发送请求的时候为什么自动带上了一个RequestId头部？](https://www.cnblogs.com/haogj/p/13952211.html)

## Polly

* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（上篇）](https://mp.weixin.qq.com/s/VfyrwARblQJgS7D2Q_Ny6A)
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（中篇）](https://www.cnblogs.com/willick/p/HttpClientFactory-Polly-2.html)
* [在 .NET Core 中结合 HttpClientFactory 使用 Polly（下篇）](https://www.cnblogs.com/willick/p/HttpClientFactory-Polly-3.html)
* [通过 IHttpClientFactory 和 Polly 策略实现使用指数退避算法的 HTTP 调用重试](https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/implement-resilient-applications/implement-http-call-retries-exponential-backoff-polly)
