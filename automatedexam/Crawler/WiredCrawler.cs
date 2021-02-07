using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automatedexam.Crawler
{
    public class WiredCrawler
    {
        public static (string[],string[]) crawl(string crawlUri)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(crawlUri);
            var aLink1 = htmlDoc.DocumentNode.SelectNodes("//a")[36];
            var aLink2 = htmlDoc.DocumentNode.SelectNodes("//a")[40];
            var aLink3 = htmlDoc.DocumentNode.SelectNodes("//a")[44];
            var aLink4 = htmlDoc.DocumentNode.SelectNodes("//a")[48];
            var aLink5 = htmlDoc.DocumentNode.SelectNodes("//a")[52];
            string fLink1 = aLink1.GetAttributeValue("href", "blank");
            string fLink2 = aLink2.GetAttributeValue("href", "blank");
            string fLink3 = aLink3.GetAttributeValue("href", "blank");
            string fLink4 = aLink4.GetAttributeValue("href", "blank");
            string fLink5 = aLink5.GetAttributeValue("href", "blank");
            string crawlUri1 = @"https://www.wired.com" + fLink1;
            string crawlUri2 = @"https://www.wired.com" + fLink2;
            string crawlUri3 = @"https://www.wired.com" + fLink3;
            string crawlUri4 = @"https://www.wired.com" + fLink4;
            string crawlUri5 = @"https://www.wired.com" + fLink5;
            var htmlDoc1 = web.Load(crawlUri1);
            var htmlDoc2 = web.Load(crawlUri2);
            var htmlDoc3 = web.Load(crawlUri3);
            var htmlDoc4 = web.Load(crawlUri4);
            var htmlDoc5 = web.Load(crawlUri5);
            var titleLink1 = htmlDoc1.DocumentNode.SelectNodes("//h1")[0];
            var titleLink2 = htmlDoc2.DocumentNode.SelectNodes("//h1")[0];
            var titleLink3 = htmlDoc3.DocumentNode.SelectNodes("//h1")[0];
            var titleLink4 = htmlDoc4.DocumentNode.SelectNodes("//h1")[0];
            var titleLink5 = htmlDoc5.DocumentNode.SelectNodes("//h1")[0];
            var parLink1 = htmlDoc1.DocumentNode.SelectNodes("//p");
            var parLink2 = htmlDoc2.DocumentNode.SelectNodes("//p");
            var parLink3 = htmlDoc3.DocumentNode.SelectNodes("//p");
            var parLink4 = htmlDoc4.DocumentNode.SelectNodes("//p");
            var parLink5 = htmlDoc5.DocumentNode.SelectNodes("//p");
            HtmlNode[] titleLinks = { titleLink1, titleLink2, titleLink3, titleLink4, titleLink5 };
            HtmlNodeCollection[] parLinks = { parLink1, parLink2, parLink3, parLink4, parLink5 };
            string[] finalTitle = { "", "", "", "", "" };
            string[] finalArticle = {"","","","",""};
            for (int i = 0; i < 5; i++)
            {
                finalTitle[i] = titleLinks[i].InnerText;
                foreach (HtmlNode n in parLinks[i])
                {
                    finalArticle[i] += n.InnerText;
                }
            }
            

            
            //var testLink2 = htmlDoc.DocumentNode.SelectNodes("//a")[1];
            var link1 = aLink1.ChildNodes[0];
            var link2 = aLink2.ChildNodes[0];
            //Debug.WriteLine(link1.InnerText);
            return ( finalTitle, finalArticle);

        }
    }
}
