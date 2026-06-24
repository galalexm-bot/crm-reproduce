using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messaging.Email.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Messaging.Email.Web.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469" })]
public class EmailSettingsController : BPMController
{
	public EmailSettingsModule SettingsModule { get; set; }

	public EmailSettings Settings => SettingsModule.Settings;

	public EmailSender Sender { get; set; }

	[HttpGet]
	public ActionResult View()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	[HttpGet]
	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	public ActionResult SendTestMessage()
	{
		try
		{
			IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
			if (currentUser == null)
			{
				throw new InvalidOperationException(SR.T("Текущий пользователь не определен"));
			}
			if (string.IsNullOrEmpty(currentUser.EMail))
			{
				throw new InvalidOperationException(SR.T("Укажите свой E-mail"));
			}
			MailMessage mailMessage = Sender.CreateMessage(new MailAddress(currentUser.EMail, currentUser.FullName), SR.T("Тестовое письмо"), SR.T("Это тестовое сообщение по вашему запросу"), Settings.IsHtmlFooter, needFooter: true);
			List<LinkedResourceFile> list = null;
			if (mailMessage.IsBodyHtml)
			{
				FooterFileModel footerFileList = Settings.GetFooterFileList();
				if (footerFileList != null && footerFileList.FileInfo.Count > 0)
				{
					list = new List<LinkedResourceFile>();
					IMimeMappingService serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
					foreach (KeyValuePair<string, string> item in footerFileList.FileInfo)
					{
						list.Add(new LinkedResourceFile
						{
							FileName = item.Value,
							MediaType = serviceNotNull.GetTypeByExtension(Path.GetExtension(item.Value)),
							ContentId = item.Key
						});
					}
				}
			}
			long num = (long)Settings.MaxAttachmensSize * 1048576L;
			MailMessageFile mailMessageFile = ((Settings.MaxAttachmensSize == 0) ? null : new MailMessageFile
			{
				FileName = SR.T("Данные.dat"),
				MediaType = "application/octet-stream",
				FileBody = new byte[num]
			});
			SmtpSettings smtpSettings = new SmtpSettings(Settings)
			{
				Timeout = 1000,
				NecessarilySendFiles = true
			};
			Sender.SendMessage(smtpSettings, mailMessage, new MailMessageFile[1] { mailMessageFile }, list);
			double num2 = smtpSettings.SendTime.TotalMilliseconds / (double)(int)Math.Max(1000L, num / EmailSender.SizeTimeoutFactor);
			int? num3 = ((int)(num2 * 1.5) / 5 + 1) * 5;
			if (Settings.Timeout < num3)
			{
				Settings.Timeout = num3.Value;
				SettingsModule.SaveSettings();
			}
			else
			{
				num3 = null;
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = 1,
				message = SR.T("Письмо успешно отправлено"),
				timeout = num3
			});
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка при отправке тестового письма текущему пользователю"), ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = 0,
				message = GetErrorMessage(ex.Message)
			});
		}
	}

	public ActionResult AddTestMessageToQueue()
	{
		try
		{
			if (string.IsNullOrEmpty((base.AuthenticationService.GetCurrentUser<IUser>() ?? throw new InvalidOperationException(SR.T("Текущий пользователь не определен"))).EMail))
			{
				throw new InvalidOperationException(SR.T("Укажите свой E-mail"));
			}
			Sender.AddMessageToQueue(SR.T("Тестовое письмо"), SR.T("Это тестовое сообщение по вашему запросу"));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = 1,
				message = SR.T("Письмо успешно добавлено в очередь")
			});
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка при добавлении тестового письма в очередь отправки сообщений"), ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = 0,
				message = GetErrorMessage(ex.Message)
			});
		}
	}

	private string GetErrorMessage(string exceptionMessage)
	{
		return SR.T("Ошибка") + ": " + exceptionMessage + ". " + SR.T("Подробную информацию об ошибке можно найти в лог-файле Error.");
	}
}
