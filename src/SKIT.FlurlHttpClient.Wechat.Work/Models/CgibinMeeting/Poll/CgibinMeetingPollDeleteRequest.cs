namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/delete 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingPollDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置投票主题 ID。与字段 <see cref="PollId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_theme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_theme_id")]
        public string? PollThemeId { get; set; }

        /// <summary>
        /// 获取或设置投票 ID。与字段 <see cref="PollThemeId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_id")]
        public string? PollId { get; set; }

        /// <summary>
        /// 获取或设置操作者的 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("operator_userid")]
        public string OperatorUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置终端设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_id")]
        [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public int InstanceId { get; set; }
    }
}
