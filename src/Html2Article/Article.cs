using System;

namespace StanSoft
{
    /// <summary>
    /// 文章正文数据模型
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 正文文本
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 带标签正文
        /// </summary>
        public string ContentWithTags { get; set; }
        /// <summary>
        /// 文章发布时间
        /// </summary>
        public DateTime PublishDate { get; set; }
    }
}