﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/auth 接口的请求。</para>
    /// </summary>
    public class SnsAuthRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置网页授权接口调用凭证（注意与全局 AccessToken 相区分）。
        /// </summary>
        public override string? AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        public string OpenId { get; set; } = string.Empty;
    }
}