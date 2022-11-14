﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using RealEstate.PresentationLayer.Models;

namespace RealEstate.PresentationLayer.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
           MimeMessage mimeMessage=new MimeMessage();
           
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin RealEstate", "adatugay@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
           
            MailboxAddress mailboxAddress = new MailboxAddress("User", p.ReceiverMail);
            mimeMessage.To.Add(mailboxAddress);

            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = p.Contect;
            mimeMessage.Body=bodybuilder.ToMessageBody();
            mimeMessage.Subject=p.Subject;

            SmtpClient smtpClient=new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("adatugay@gmail.com", "nfeozpeyzokfxgbw");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}
