using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICurated
{
    public class CScript_Article
    {
        public int Id;// 新闻的唯一标识
        public string Title;// 新闻标题
        public string MediaName; // 媒体名称
        public string Keywords; // 关键词，使用数组来存储多个关键词

        public DateTime NewsDate; // 新闻日期
        public DateTime DownloadDate; // 下载日期

        public string Author; // 作者
        public string Summary; // 新闻摘要
        public string LangType; //en-En, zh-CN

        /// <summary>
        /// an article can include many sections.
        /// but currently before V0.4, it will have only one section. 
        /// </summary>
        public List<CScript_ArticleSection> Sections = new List<CScript_ArticleSection>();

    }//class CScript_Article
}
