﻿namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatOpenAIClient"/> 时使用的配置项。
    /// </summary>
    public class WechatOpenAIClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微微信智能对话 API 域名。
        /// <para>默认值：<see cref="WechatOpenAIEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatOpenAIEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信智能对话 ClientId。
        /// </summary>
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信智能对话 ClientKey。
        /// </summary>
        public string ClientKey { get; set; } = default!;
    }
}