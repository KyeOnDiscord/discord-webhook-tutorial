using System;
using System.Net;
using System.Collections.Specialized;
public class Program
{
	public static void sendDiscordWebhook(string URL, string profilepic, string username, string message)
        {
            using (WebClient web = new WebClient())
            {
                NameValueCollection discordValues = new NameValueCollection();
                discordValues.Clear();
                discordValues.Add("username", username);
                discordValues.Add("avatar_url", profilepic);
                discordValues.Add("content", message);
                web.UploadValues(URL, discordValues);
            }
        }
	
	public static void Main()
	{
		sendDiscordWebhook("https://discordapp.com/api/webhooks/749445508849860740/b_6Xv2hnhyqnWahXiAPefSv_s5cNXPZ8mg4sw4dnvrX5PUVaqjHY9Rqglfc9v5WFOLfM", "https://i.imgur.com/b2gkIWC.png", "John Doe", "Test Message");
	}
}
