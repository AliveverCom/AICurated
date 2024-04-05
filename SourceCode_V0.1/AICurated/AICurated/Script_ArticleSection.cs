using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICurated
{
    public class CScript_ArticleSection
    {
        public string BgMediaUrl; // 背景图文件地址
        public string BgMediaPrompt; // 背景图文件prompt

        public string RptMediaUrl; // reporter image url
        public string RptMediaPrompt; // reporter image prompt

        public string FullText; // 新闻正文

        public string LangType; //zh-CN, in future, each mybe use different language.
    }
}
