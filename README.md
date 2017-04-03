# RemoveTrFromHTML
Remove particular 'TR' by Id from email html template

In this example we will see that, How to remove particular Tr from email html template by regular expression. I did search lots for it but it was hard to find the answer for it. At last I found answer which is as below.

So by the use of below core we can remove particular row from html table.
1). Pass html file name from which you want to modify.
2). Pass Tr Id in regular expression.
3). See the result in StringBuilder variable after replace.

In my case 
file name("JobChunkEmailTemplate.html")
tr name ("GoogleAdwordsSectionId")




public void RemoveTrByIdFromHtml()
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
