using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class CodeAnalyzeTests
    {
        [Fact(DisplayName = "代码质量分析")]
        public void CodeAnalyze()
        {
            // NOTICE:
            //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
            //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatOpenAIClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Events",
                    IgnoreRequestModelTypes = (type) => !typeof(WechatOpenAIRequest).IsAssignableFrom(type),
                    IgnoreResponseModelTypes = (type) => !typeof(WechatOpenAIResponse).IsAssignableFrom(type),
                    IgnoreExecutingExtensionTypes = (type) => !type.Name.StartsWith(nameof(WechatOpenAIClient)),
                    IgnoreWebhookEventTypes = (_) => true,
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatChatbotClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Events",
                    IgnoreRequestModelTypes = (type) => !typeof(WechatChatbotRequest).IsAssignableFrom(type),
                    IgnoreResponseModelTypes = (type) => !typeof(WechatChatbotResponse).IsAssignableFrom(type),
                    IgnoreExecutingExtensionTypes = (type) => !type.Name.StartsWith(nameof(WechatChatbotClient)),
                    IgnoreWebhookEventTypes = (type) => !typeof(WechatChatbotEvent).IsAssignableFrom(type),
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatOpenAIClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Wechat.OpenAI/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "Models/OpenAI/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "Models/OpenAI/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "Events/OpenAI/",
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/OpenAI/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/OpenAI/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/OpenAI/",
                    IgnoreExecutingExtensionClassCodeFiles = (file) => !file.Name.StartsWith(nameof(WechatOpenAIClient)),
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatChatbotClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.OpenAI.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Wechat.OpenAI/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "Models/Chatbot/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "Models/Chatbot/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "Events/Chatbot/",
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/Chatbot/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/Chatbot/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/Chatbot/",
                    IgnoreExecutingExtensionClassCodeFiles = (file) => !file.Name.StartsWith(nameof(WechatChatbotClient)),
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }
    }
}
