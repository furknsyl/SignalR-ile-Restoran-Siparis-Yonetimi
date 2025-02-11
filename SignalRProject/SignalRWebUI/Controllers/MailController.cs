using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignalRWebUI.Dtos.MailDtos;
using MailKit.Net.Smtp;

namespace SignalRWebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CreateMailDto createMailDto)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("SignalR Rezervasyon", "fsoylu500@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDto.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = createMailDto.Body;

            mimeMessage.Subject = createMailDto.Subject;

            // Dosya ekleme kısmı
            if (createMailDto.Attachment != null && createMailDto.Attachment.Length > 0)
            {

                // Dosya içeriğini kudum
                byte[] fileBytes;
                using (var ms = new MemoryStream())
                {
                    createMailDto.Attachment.CopyTo(ms);
                    fileBytes = ms.ToArray();
                }

                // MimePart örneği
                var attachmentPart = new MimePart
                {
                    Content = new MimeContent(new MemoryStream(fileBytes)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = createMailDto.Attachment.FileName
                };

                // MessageBody'ye ekledim
                bodyBuilder.Attachments.Add(attachmentPart);

            }
            //doğrulama sonrası topunu body'de topladım
            mimeMessage.Body = bodyBuilder.ToMessageBody();


            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("fsoylu500@gmail.com", "mqgj ufbm oulk hxso");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Index", "Category");
        }
    }
}
