﻿using Foundation;

namespace Insane.Notifications.iOS.Extensions
{
	public static class NSDictionaryExtensions
	{
        // Provided by by Erlend :)
	    public static string GetJsonFromDictionary(this NSDictionary dict)
	    {
	        if (dict == null) return null;

	        NSError err;
	        var jsonData = NSJsonSerialization.Serialize(dict, NSJsonWritingOptions.PrettyPrinted,
	            out err);
	        if (err != null)
	            return null;
	        var strData = jsonData.ToString();
	        var notificationJson = "{" + strData.TrimStart('{').TrimEnd('}') + "}";
	        return notificationJson;
	    }
	}
}
