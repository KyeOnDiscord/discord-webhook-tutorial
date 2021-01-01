# Discord-Webhook-Tutorial
C# Discord Webhook Tutorial


For Discord Webhooks with Embeds go here: https://github.com/kyeondiscord/discord-webhook-tutorial-embed

Use these namespaces:
```csharp
using System.Net; //For webclient
using System.Collections.Specialized; //For NameValueCollection
```


Paste this method into your .cs file. 
```csharp
public static void sendDiscordWebhook(string URL, string profilepic, string username, string message)
        {
                NameValueCollection discordValues = new NameValueCollection();
                discordValues.Add("username", username);
                discordValues.Add("avatar_url", profilepic);
                discordValues.Add("content", message);
                new WebClient().UploadValues(URL, discordValues);
        }
```

<h3>How To Use</h3>
Lets use this Discord Webhook in an event (let's use a button click event)

```csharp
private void button1_Click(object sender, EventArgs e)
        {
            sendDiscordWebhook("https://discordapp.com/api/webhooks/749445508849860740/b_6Xv2hnhyqnWahXiAPefSv_s5cNXPZ8mg4sw4dnvrX5PUVaqjHY9Rqglfc9v5WFOLfM", "https://i.imgur.com/b2gkIWC.png", "John Doe", "Test Message");
        }
```
This button event would result in: <br>
![](https://i.imgur.com/EyWRUPj.png)
