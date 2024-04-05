using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AICurated
{
    internal class CScriptMker_Article
    {

        public static CScript_Article GetEnglishArticle()
        {
            CScript_Article atl = new CScript_Article()
            {
                Title = "Saudi Arabian Grand Prix 2024: Max Verstappen wins as Oliver Bearman finishes seventh",
                MediaName = "BBC",
            };

            atl.Sections.Add(new CScript_ArticleSection()
            {
                LangType = "en-UK",
                 BgMediaPrompt = "C:\\Users\\User\\OneDrive\\MySpace\\AIStudio\\WhatsApp Image 2024-03-09 at 22.03.35_d5c32d39.jpg",
                   RptMediaUrl = "C:\\Users\\User\\OneDrive\\MySpace\\AIStudio\\WhatsApp Image 2024-03-09 at 22.03.26_51926628.jpg",
                   FullText = "Red Bull's Max Verstappen took a comfortable victory in the Saudi Arabian Grand Prix, " 
                   +"\nas Briton Oliver Bearman scored points on his debut in seventh for Ferrari."
                   + "\nVerstappen's win was his second in two races in 2024 and his ninth consecutive victory dating back to September."
                   + "\nLeading team - mate Sergio Perez to a Red Bull one - two,"
                   + "\nit continued the crushing superiority Verstappen has had over the Formula 1 field for nearly two years."
                   + "\nFerrari's Charles Leclerc came third."
            });

            return atl;
        }
    }
}
