using System.Collections.Generic;
using WebSite;

public class WebSiteImages_Model
{
    public Dictionary<string, ParserWebsite> parsers;

    public WebSiteImages_Model()
	{
		parsers = new Dictionary<string, ParserWebsite>();
	}
}
