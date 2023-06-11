# Mail.dll

Mail.dll is a .NET IMAP component, POP3 component and SMTP component library. 

Includes an email and MIME parser. Allows sending, receiving and processing email messages in .NET applications. 
Includes SSL and TLS support along with OAuth and DKIM capabilities. Includes secure MIME (S/MIME) parser for processing encrypted and signed emails. 

Contains iCal, vCard and Outlook's msg files parsers. Decodes winmail.dat attachments.

## Getting started with Mail.dll

- [Online sample library](https://www.limilabs.com/mail/samples)
- [Technical Q&A forum](https://www.limilabs.com/qa)

### Download emails using IMAP

```cs
using(Imap imap = new Imap())
{
    imap.ConnectSSL("imap.server.com");  // or Connect for non SSL/TLS
    imap.UseBestLogin("user", "password");

    imap.SelectInbox();
    List<long> uids = imap.Search(Flag.Unseen);
    foreach (long uid in uids)
    {
        var eml = imap.GetMessageByUID(uid);

        IMail email = new MailBuilder().CreateFromEml(eml);

        string subject = email.Subject;
    }
    imap.Close();
}
```

### Download emails using POP3

```cs
using(Pop3 pop3 = new Pop3())
{
    pop3.ConnectSSL("pop3.server.com");  // or Connect for non SSL/TLS   
    pop3.UseBestLogin("user", "password");

    List<string> uids = pop3.GetAll();
    foreach (string uid in uids)
    {
        var eml = pop3.GetMessageByUID(uid);
        IMail email = new MailBuilder().CreateFromEml(eml);

        string subject = email.Subject;
    }
    pop3.Close();
} 
```

### Send emails using SMTP

```cs
MailBuilder builder = new MailBuilder();
builder.From.Add(new MailBox("from@example.com"));
builder.To.Add(new MailBox("to@example.com"));
builder.Subject = "Subject";
builder.Html = @"Html with an image: <img src=""cid:lena"" />";

var visual = builder.AddVisual(@"c:\lena.jpeg");
visual.ContentId = "lena";

var attachment = builder.AddAttachment(@"c:\tmp.doc");
attachment.SetFileName("document.doc", guessContentType: true);

IMail email = builder.Create();

using(Smtp smtp = new Smtp())
{
    smtp.Connect("smtp.server.com");  // or ConnectSSL for SSL
    smtp.UseBestLogin("user", "password");

    smtp.SendMessage(email);                      
    smtp.Close();    
}
```


