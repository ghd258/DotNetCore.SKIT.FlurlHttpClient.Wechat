using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /batchimportskill/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class BatchImportSkillRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        public static class Types
        {
            public class Skill
            {
                /// <summary>
                /// 获取或设置技能名称。
                /// </summary>
                [XmlElement("skillname")]
                public string SkillName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置标准问题。
                /// </summary>
                [XmlElement("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置相似问题列表。
                /// </summary>
                [XmlElement("question", Type = typeof(string))]
                public IList<string> QuestionList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置机器人回答列表。
                /// </summary>
                [XmlElement("answer", Type = typeof(string))]
                public IList<string> AnswerList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [XmlElement("managerid")]
        public string ManagetId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置技能列表。
        /// </summary>
        [XmlElement("skill", Type = typeof(Types.Skill))]
        public IList<Types.Skill> SkillList { get; set; } = new List<Types.Skill>();
    }
}
