using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.IO;
namespace RemoveTrFromHtmlTemplate.HelperClass
{
    public static class RemoveTr
    {
        public static void RemoveTrTag()
        {
            string filePath = HttpContext.Current.Server.MapPath("~/JobChunkEmailTemplate.html");
            StringBuilder sbMailTemplate = new StringBuilder();

            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                sbMailTemplate.Append(reader.ReadToEnd());
            }

            string pattern = "<tr id=\"GoogleAdwordsSectionId\".+?</tr>";
            Regex r = new Regex(pattern, RegexOptions.Singleline);
            string result = r.Replace(sbMailTemplate.ToString(), "");
            sbMailTemplate.Replace(sbMailTemplate.ToString(), result);
        }
    }
}
