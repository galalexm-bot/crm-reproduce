using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading;
using Aspose.Email;
using Aspose.Email.Clients;
using Aspose.Email.Clients.Smtp;
using Aspose.Email.Mime;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messaging.Email.Exceptions;
using EleWise.ELMA.Messaging.Email.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Filter;

namespace EleWise.ELMA.Messaging.Email;

[Service(Type = ComponentType.Server)]
[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("EmailServicesApi", "SR.M('Сервис для работы с почтой: отправка, получение сообщений')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно отправлять сообщения по электронной почте.\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.Email;\r\n    /// \r\n    /// //Есть несколько вариантов отправки сообщения: \r\n    /// //1. SendMessage(to, subject, message, messageIsHtml, needFooter, headers, files) - не указываем отправителя, отправка идет одному получателю\r\n    /// service.SendMessage(to, subject, message, false , false, null, null);\r\n    /// \r\n    /// //2. SendMessage(from, to, subject, message, messageIsHtml, needFooter, headers, files) - указываем отправителя, отправка идет одному пользователю\r\n    /// service.SendMessage(from, to, subject, message, false , false, null, null);\r\n    /// \r\n    /// //3. SendMessage(to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately) - не указываем отправителя, отправка идет нескольким получателям\r\n    /// service.SendMessage(to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately);\r\n    /// \r\n    /// //4. SendMessage(from, to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately) - указываем отправителя, отправка идет нескольким получателям\r\n    /// service.SendMessage(from, to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately);\r\n    /// \r\n    /// //5. SendMessage(message, files) - указываем сообщение для отправки и прикриплённые файлы\r\n    /// service.SendMessage(message, files);\r\n    /// \r\n    /// //6. SendMessage(smtpSettings, message, files) - указываем настройки подключения к почтовомы сервису\r\n    /// service.SendMessage(smtpSettings, message, files);\r\n    /// </code>')")]
public class EmailSender
{
	private const string EmailServiceDescription = "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно отправлять сообщения по электронной почте.\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.Email;\r\n    /// \r\n    /// //Есть несколько вариантов отправки сообщения: \r\n    /// //1. SendMessage(to, subject, message, messageIsHtml, needFooter, headers, files) - не указываем отправителя, отправка идет одному получателю\r\n    /// service.SendMessage(to, subject, message, false , false, null, null);\r\n    /// \r\n    /// //2. SendMessage(from, to, subject, message, messageIsHtml, needFooter, headers, files) - указываем отправителя, отправка идет одному пользователю\r\n    /// service.SendMessage(from, to, subject, message, false , false, null, null);\r\n    /// \r\n    /// //3. SendMessage(to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately) - не указываем отправителя, отправка идет нескольким получателям\r\n    /// service.SendMessage(to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately);\r\n    /// \r\n    /// //4. SendMessage(from, to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately) - указываем отправителя, отправка идет нескольким получателям\r\n    /// service.SendMessage(from, to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately);\r\n    /// \r\n    /// //5. SendMessage(message, files) - указываем сообщение для отправки и прикриплённые файлы\r\n    /// service.SendMessage(message, files);\r\n    /// \r\n    /// //6. SendMessage(smtpSettings, message, files) - указываем настройки подключения к почтовомы сервису\r\n    /// service.SendMessage(smtpSettings, message, files);\r\n    /// </code>')";

	private ChannelMessageManager channelMessageManager;

	private readonly ConcurrentDictionary<SmtpClient, DateTime> sendStarts = new ConcurrentDictionary<SmtpClient, DateTime>();

	internal static int SizeTimeoutFactor = 28300;

	private EmailSettings settings;

	private const string MessagesLogName = "Messages";

	public static ILogger MessagesLog = Logger.GetLogger("Messages");

	private static ILog _messagesLog;

	private static Type _ownerType;

	private static MethodInfo _methodSendMessage;

	private static Type _smtpClientType;

	private static MethodInfo _methodSmtpClientSend;

	private static MethodInfo _methodSmtpClientForward;

	public IMimeMappingService MimeMappingService { get; set; }

	private ChannelMessageManager ChannelMessageManager => channelMessageManager ?? (channelMessageManager = ChannelMessageManager.Instance);

	private EmailSettings Settings
	{
		get
		{
			if (settings == null && Locator.Initialized)
			{
				EmailSettingsModule service = Locator.GetService<EmailSettingsModule>();
				if (service != null)
				{
					settings = service.Settings;
				}
			}
			return settings;
		}
	}

	private string MessagesLogDirectoryName
	{
		get
		{
			ILoggerFactory service = Locator.GetService<ILoggerFactory>();
			if (service == null || service.GetType().Name != "Log4NetFactory")
			{
				return null;
			}
			_messagesLog = _messagesLog ?? LogManager.GetLogger("Messages");
			ILogger logger = ((ILoggerWrapper)_messagesLog).get_Logger();
			IAppenderAttachable val = (IAppenderAttachable)(object)((logger is IAppenderAttachable) ? logger : null);
			if (val != null)
			{
				AppenderCollection appenders = val.get_Appenders();
				Func<FileAppender, bool> predicate = (FileAppender appender) => ((AppenderSkeleton)appender).get_FilterHead() is LoggerMatchFilter && ((LoggerMatchFilter)((AppenderSkeleton)appender).get_FilterHead()).get_LoggerToMatch() == "Messages";
				FileAppender val2 = ((IEnumerable)appenders).OfType<FileAppender>().FirstOrDefault(predicate) ?? ((IEnumerable)appenders).OfType<FileAppender>().FirstOrDefault();
				if (val2 != null)
				{
					return Path.GetDirectoryName(val2.get_File());
				}
			}
			return null;
		}
	}

	private static Type OwnerType => _ownerType ?? (_ownerType = typeof(EmailSender));

	private static MethodInfo MethodSendMessage => _methodSendMessage ?? (_methodSendMessage = (MethodInfo)new StackTrace().GetFrame(1).GetMethod());

	private static Type SmtpClientType
	{
		get
		{
			Type obj = _smtpClientType ?? typeof(SmtpClient);
			_smtpClientType = obj;
			return obj;
		}
	}

	private static MethodInfo MethodSmtpClientSend
	{
		get
		{
			MethodInfo obj = _methodSmtpClientSend ?? SmtpClientType.GetMethod("Send", new Type[1] { typeof(MailMessage) });
			_methodSmtpClientSend = obj;
			return obj;
		}
	}

	private static MethodInfo MethodSmtpClientForward
	{
		get
		{
			MethodInfo obj = _methodSmtpClientForward ?? SmtpClientType.GetMethod("Forward", new Type[3]
			{
				typeof(string),
				typeof(MailAddressCollection),
				typeof(MailMessage)
			});
			_methodSmtpClientForward = obj;
			return obj;
		}
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(MailAddress to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, IEnumerable<MailMessageFile> files = null)
	{
		SendMessage(new MailAddress[1] { to }, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately: true);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(MailAddress from, MailAddress to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, IEnumerable<MailMessageFile> files = null)
	{
		SendMessage(from, new MailAddress[1] { to }, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately: true);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(IEnumerable<MailAddress> to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, IEnumerable<MailMessageFile> files = null, bool sendSeparately = false)
	{
		SendMessage(null, to, subject, message, messageIsHtml, needFooter, headers, files, sendSeparately);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(MailAddress from, IEnumerable<MailAddress> to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, IEnumerable<MailMessageFile> files = null, bool sendSeparately = false)
	{
		if (Settings == null)
		{
			return;
		}
		MailMessage mailMessage = CreateMessage(from, null, subject, message, messageIsHtml, needFooter, headers);
		List<LinkedResourceFile> list = null;
		if (needFooter && mailMessage.IsBodyHtml)
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
		if (sendSeparately)
		{
			foreach (MailAddress item2 in to)
			{
				mailMessage.To.Clear();
				mailMessage.To.Add(item2);
				SendMessage(mailMessage, files, list);
			}
			return;
		}
		foreach (MailAddress item3 in to)
		{
			mailMessage.To.Add(item3);
		}
		SendMessage(mailMessage, files, list);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(MailMessage message, IEnumerable<MailMessageFile> files = null, IEnumerable<LinkedResourceFile> linkedResource = null)
	{
		SendMessage(new SmtpSettings(Settings), message, files, linkedResource);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(SmtpSettings smtpSettings, MailMessage message, IEnumerable<MailMessageFile> files = null)
	{
		SendMessage(smtpSettings, message, files, null);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessage(SmtpSettings smtpSettings, MailMessage message, IEnumerable<MailMessageFile> files, IEnumerable<LinkedResourceFile> linkedResource)
	{
		foreach (MailMessageFile item2 in from f in files.EmptyIfNull()
			where f != null
			select f)
		{
			Attachment item = new Attachment(string.IsNullOrWhiteSpace(item2.FilePath) ? ((Stream)MemoryHelper.GetMemoryStream(item2.FileBody, writable: false)) : ((Stream)new FileStream(item2.FilePath, FileMode.Open, FileAccess.Read)), item2.FileName, item2.MediaType)
			{
				NameEncoding = message.SubjectEncoding
			};
			message.Attachments.Add(item);
		}
		SendMessages(smtpSettings, message);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessages(SmtpSettings smtpSettings, params MailMessage[] message)
	{
		SendMessages(smtpSettings, message.ToList(), needGroupingException: false);
	}

	[PublicApiNodeId("EmailServicesApi")]
	public void SendMessages(SmtpSettings smtpSettings, IEnumerable<MailMessage> messages)
	{
		SendMessages(smtpSettings, messages, needGroupingException: true);
	}

	public MailMessage CreateMessage(MailAddress to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, string emailFormatPrefix = null)
	{
		return CreateMessage(new MailAddress[1] { to }, subject, message, messageIsHtml, needFooter, headers, emailFormatPrefix);
	}

	public MailMessage CreateMessage(IEnumerable<MailAddress> to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, string emailFormatPrefix = null)
	{
		return CreateMessage(null, to, subject, message, messageIsHtml, needFooter, headers, emailFormatPrefix);
	}

	public MailMessage CreateMessage(MailAddress from, IEnumerable<MailAddress> to, string subject, string message, bool messageIsHtml = false, bool needFooter = false, IDictionary<string, string> headers = null, string emailFormatPrefix = null)
	{
		if (Settings == null)
		{
			return null;
		}
		string subjectPrefix = Settings.SubjectPrefix;
		if (string.IsNullOrWhiteSpace(subject))
		{
			subject = SR.T("[ELMA]{0} Тема не задана", emailFormatPrefix ?? "");
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.IsNullOrWhiteSpace(subjectPrefix) ? "" : subjectPrefix).Append(string.IsNullOrWhiteSpace(emailFormatPrefix) ? "" : $" {emailFormatPrefix}");
			subject = $"{stringBuilder.ToString()} {subject}";
		}
		subject = subject.Replace("\t", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty);
		if (needFooter)
		{
			string text = (string.IsNullOrWhiteSpace(Settings.BodyFooterSeparator) ? "\n\n" : ("\n\n" + SR.T(Settings.BodyFooterSeparator) + "\n"));
			if (messageIsHtml)
			{
				if (!string.IsNullOrEmpty(Settings.HtmlBodyFooter.ToString()))
				{
					FooterFileModel footerFileList = Settings.GetFooterFileList();
					message = message + text + ((footerFileList != null) ? footerFileList.HtmlFooter : Settings.HtmlBodyFooter.ToString());
				}
			}
			else if (!string.IsNullOrEmpty(Settings.BodyFooter))
			{
				message = message + text + SR.T(Settings.BodyFooter);
			}
		}
		MailMessage mailMessage = new MailMessage
		{
			Subject = subject,
			SubjectEncoding = null,
			Body = message,
			BodyEncoding = null,
			IsBodyHtml = messageIsHtml
		};
		if (from != null)
		{
			mailMessage.From = from;
		}
		foreach (MailAddress item in to.EmptyIfNull())
		{
			mailMessage.To.Add(item);
		}
		headers.Each(delegate(KeyValuePair<string, string> h)
		{
			mailMessage.Headers.Add(h.Key, h.Value);
		});
		return mailMessage;
	}

	internal void AddMessageToQueue(string subject, string message)
	{
		ChannelMessageManager.CreateTestMessage(subject, message, (long)Settings.MaxAttachmensSize * 1048576L);
	}

	private void SmtpClientOnConnect(object sender, EventArgs eventArgs)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		SaveSendStart((SmtpClient)sender);
	}

	private void SaveSendStart(SmtpClient smtpClient)
	{
		sendStarts.AddOrUpdate(smtpClient, (SmtpClient client) => DateTime.Now, (SmtpClient client, DateTime time) => DateTime.Now);
	}

	private DateTime RemoveSendStart(SmtpClient smtpClient)
	{
		sendStarts.TryRemove(smtpClient, out var value);
		return value;
	}

	private void SetTimeout(SmtpClient smtpClient, int sendTimeout, long attachmensSize = 0L)
	{
		((EmailClient)smtpClient).set_Timeout(sendTimeout * (int)Math.Max(1000L, attachmensSize / SizeTimeoutFactor));
	}

	private void LogMessage(MailMessage messageMail)
	{
		string text = LogMessageToFileIfTrace(messageMail);
		if (text == null)
		{
			MessagesLog.DebugFormat("Sending e-mail to {0} (subject: {1})", messageMail.get_To(), messageMail.get_Subject());
		}
		else
		{
			MessagesLog.DebugFormat("Sending e-mail to {0} (subject: {1}, file: {2})", messageMail.get_To(), messageMail.get_Subject(), text);
		}
	}

	private string LogMessageToFileIfTrace(MailMessage messageMail)
	{
		string result = null;
		string messagesLogDirectoryName;
		if (MessagesLog.IsEnabled(LogLevel.Trace) && !string.IsNullOrEmpty(messagesLogDirectoryName = MessagesLogDirectoryName))
		{
			try
			{
				MessagesLog.Log(LogLevel.Trace, messageMail);
				Directory.CreateDirectory(messagesLogDirectoryName);
				result = Thread.CurrentThread.ManagedThreadId + "_" + ((IEnumerable<MailAddress>)messageMail.get_To()).Select((MailAddress m) => m.get_Address()).FirstOrDefault();
				result = string.Join("_", result.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries));
				int num = 1;
				string text = null;
				Func<string, int, string> func = (string name, int idx) => Path.Combine(messagesLogDirectoryName, name + ((idx > 1) ? ("_" + idx) : "") + ".eml");
				while (File.Exists(text = func(result, num)))
				{
					num++;
				}
				result = text;
				messageMail.Save(result);
				return result;
			}
			catch (Exception exception)
			{
				MessagesLog.Debug(SR.T("Не удалось сохранить сообщение"), exception);
				return null;
			}
		}
		return result;
	}

	private MailMessage ConvertMessageToAsposeFormat(MailMessage message, long maxAttachmentsSize)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		MailMessage val = new MailMessage();
		val.set_Subject(message.Subject);
		val.set_SubjectEncoding((message.SubjectEncoding != null) ? EmailEncoding.GetEncoding(message.SubjectEncoding) : ((Settings != null) ? Settings.GetEmailEncoding() : null));
		val.set_IsBodyHtml(message.IsBodyHtml);
		val.set_BodyEncoding((message.BodyEncoding != null) ? EmailEncoding.GetEncoding(message.BodyEncoding) : ((Settings != null) ? Settings.GetEmailEncoding() : null));
		val.set_Priority((MailPriority)((message.Priority == MailPriority.High) ? 2 : ((message.Priority == MailPriority.Low) ? 1 : 0)));
		MailMessage val2 = val;
		bool flag = false;
		if (message.IsBodyHtml)
		{
			val2.set_HtmlBody(message.Body);
		}
		else
		{
			val2.set_Body(message.Body);
		}
		if (message.From != null)
		{
			val2.set_From(new MailAddress(message.From.Address, message.From.DisplayName));
		}
		else if (Settings != null && !string.IsNullOrWhiteSpace(Settings.SenderEMail))
		{
			val2.set_From(new MailAddress(Settings.SenderEMail, Settings.SenderName));
		}
		if (message.Sender != null)
		{
			val2.set_Sender(new MailAddress(message.Sender.Address, message.Sender.DisplayName));
		}
		Action<MailAddressCollection, IEnumerable<MailAddress>> action = delegate(MailAddressCollection cd, IEnumerable<MailAddress> cs)
		{
			cd.AddRange(cs.Where((MailAddress a) => a != null).Select((Func<MailAddress, MailAddress>)((MailAddress a) => new MailAddress(a.Address, a.DisplayName))));
		};
		action(val2.get_Bcc(), message.Bcc);
		action(val2.get_CC(), message.CC);
		action(val2.get_ReplyToList(), message.ReplyToList.Union(new MailAddress[1] { message.ReplyTo }));
		action(val2.get_To(), message.To);
		string[] allKeys = message.Headers.AllKeys;
		foreach (string text in allKeys)
		{
			val2.get_Headers().Add(text, message.Headers[text]);
		}
		if (message.AlternateViews.Any())
		{
			foreach (AlternateView alternateView in message.AlternateViews)
			{
				if (!alternateView.LinkedResources.Any())
				{
					continue;
				}
				foreach (LinkedResource linkedResource in alternateView.LinkedResources)
				{
					LinkedResourceCollection linkedResources = val2.get_LinkedResources();
					LinkedResource val3 = new LinkedResource(linkedResource.ContentStream);
					((AttachmentBase)val3).set_TransferEncoding((TransferEncoding)linkedResource.TransferEncoding);
					((AttachmentBase)val3).set_ContentId(linkedResource.ContentId);
					((Collection<LinkedResource>)(object)linkedResources).Add(val3);
				}
			}
		}
		long num = 0L;
		maxAttachmentsSize *= 1048576;
		foreach (Attachment attachment in message.Attachments)
		{
			Attachment val4 = new Attachment(attachment.ContentStream, attachment.Name, attachment.ContentType.MediaType);
			val4.set_NameEncoding((attachment.NameEncoding != null) ? EmailEncoding.GetEncoding(attachment.NameEncoding) : val2.get_SubjectEncoding());
			((AttachmentBase)val4).set_ContentId(attachment.ContentId);
			Attachment val5 = val4;
			((Collection<Attachment>)(object)val2.get_Attachments()).Add(val5);
			num += ((AttachmentBase)val5).get_ContentStream().Length;
		}
		if (num > maxAttachmentsSize)
		{
			((IEnumerable<Attachment>)val2.get_Attachments()).Each(delegate(Attachment a)
			{
				((AttachmentBase)a).Dispose();
			});
			((Collection<Attachment>)(object)val2.get_Attachments()).Clear();
			flag = true;
		}
		if (flag)
		{
			MessagesLog.DebugFormat(SR.T("Превышен максимальный размер вложений для письма: {0}. Письмо будет отправлено без вложений", val2.get_Subject()));
		}
		return val2;
	}

	private void SendMessages(SmtpSettings smtpSettings, IEnumerable<MailMessage> messages, bool needGroupingException)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Invalid comparison between Unknown and I4
		IDictionary<MailMessage, Exception> dictionary = new Dictionary<MailMessage, Exception>();
		IEnumerator<MailMessage> enumerator = messages.GetEnumerator();
		bool flag = enumerator.MoveNext();
		AddLinkedResourcesToMessages(messages);
		while (flag)
		{
			SmtpClient val = new SmtpClient(smtpSettings.Host, smtpSettings.Port, smtpSettings.NeedCredentials ? smtpSettings.UserName : null, smtpSettings.NeedCredentials ? smtpSettings.Password : null);
			try
			{
				try
				{
					switch (smtpSettings.SSLType)
					{
					case SSLType.SSL:
						((EmailClient)val).set_SecurityOptions((SecurityOptions)2);
						break;
					case SSLType.TLS:
						((EmailClient)val).set_SecurityOptions((SecurityOptions)1);
						break;
					default:
						((EmailClient)val).set_SecurityOptions((SecurityOptions)0);
						break;
					}
					((EmailClient)val).set_Timeout(smtpSettings.ConnectTimeout * 1000);
					((EmailClient)val).add_OnConnect((EventHandler)SmtpClientOnConnect);
					do
					{
						MailMessage current = enumerator.Current;
						MailMessage msg = ConvertMessageToAsposeFormat(current, smtpSettings.MaxAttachmensSize);
						using MethodCallInfo methodCallInfo = DiagnosticsManager.StartCall(() => new MethodCallInfo(SmtpClientType, MethodSmtpClientForward, new object[3]
						{
							msg.get_From().get_Address(),
							msg.get_To(),
							msg
						}));
						try
						{
							long attachmensSize = ((IEnumerable<Attachment>)msg.get_Attachments()).Sum((Attachment a) => (((AttachmentBase)a).get_ContentStream() == null) ? 0 : ((AttachmentBase)a).get_ContentStream().Length);
							SetTimeout(val, smtpSettings.Timeout, attachmensSize);
							SaveSendStart(val);
							val.Forward(((object)msg.get_From()).ToString(), msg.get_To(), msg);
							smtpSettings.SendTime = DateTime.Now - RemoveSendStart(val);
							((IEnumerable<Attachment>)msg.get_Attachments()).Each(delegate(Attachment a)
							{
								((AttachmentBase)a).get_ContentStream().Close();
							});
							flag = enumerator.MoveNext();
						}
						catch (Exception ex)
						{
							if (methodCallInfo != null)
							{
								methodCallInfo.Exception = ex;
							}
							MessagesLog.Error(ex, "Send e-mail failed\r\n", Environment.StackTrace);
							if (!smtpSettings.NecessarilySendFiles && ex is SmtpException && (int)((SmtpException)ex).get_StatusCode() == 552 && ((Collection<Attachment>)(object)msg.get_Attachments()).Count != 0)
							{
								((IEnumerable<Attachment>)msg.get_Attachments()).Each(delegate(Attachment a)
								{
									((AttachmentBase)a).Dispose();
								});
								((Collection<Attachment>)(object)msg.get_Attachments()).Clear();
								MessagesLog.DebugFormat("Clear attachments for message: From {0}; To {1}; Subject {2}", msg.get_From(), msg.get_To(), msg.get_Subject());
							}
							else
							{
								dictionary.Add(current, ex);
								flag = enumerator.MoveNext();
							}
							break;
						}
					}
					while (flag);
				}
				catch (Exception exception)
				{
					MessagesLog.Error(SR.T("Ошибка отправки сообщений"), exception);
				}
				finally
				{
					RemoveSendStart(val);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (dictionary.Count > 0)
		{
			throw needGroupingException ? new GroupingMailMessagesException(SR.T("Ошибка передачи блока сообщений"), dictionary) : dictionary.First().Value;
		}
	}

	private void AddLinkedResourcesToMessages(IEnumerable<MailMessage> messages)
	{
		foreach (MailMessage message in messages)
		{
			List<LinkedResourceFile> list = null;
			if (message.IsBodyHtml)
			{
				FooterFileModel footerFileList = Settings.GetFooterFileList();
				if (footerFileList != null && footerFileList.FileInfo.Count > 0)
				{
					list = new List<LinkedResourceFile>();
					foreach (KeyValuePair<string, string> item in footerFileList.FileInfo)
					{
						string typeByExtension = MimeMappingService.GetTypeByExtension(Path.GetExtension(item.Value));
						if (typeByExtension.StartsWith("image/"))
						{
							typeByExtension = "image/jpeg";
							using FileStream fileStream = new FileStream(item.Value, FileMode.Open, FileAccess.Read);
							string arg = MemoryHelper.ActionWithMemoryBuffer<byte, FileStream, string>((int)fileStream.Length, fileStream, GetBase64Action);
							string newValue = string.Format("data:{1};base64, {0}", arg, typeByExtension);
							message.Body = message.Body.Replace("cid:" + item.Key, newValue);
						}
						else
						{
							list.Add(new LinkedResourceFile
							{
								FileName = item.Value,
								MediaType = MimeMappingService.GetTypeByExtension(Path.GetExtension(item.Value)),
								ContentId = item.Key
							});
						}
					}
				}
			}
			foreach (LinkedResourceFile item2 in from r in list.EmptyIfNull()
				where r != null
				select r)
			{
				FileStream fileStream2 = ((!string.IsNullOrWhiteSpace(item2.FileName)) ? new FileStream(item2.FileName, FileMode.Open, FileAccess.Read) : null);
				if (fileStream2 != null)
				{
					LinkedResource linkedResource = new LinkedResource(fileStream2, item2.MediaType)
					{
						ContentId = item2.ContentId
					};
					AlternateView alternateView = new AlternateView(linkedResource.ContentStream)
					{
						TransferEncoding = linkedResource.TransferEncoding,
						ContentId = linkedResource.ContentId
					};
					alternateView.LinkedResources.Add(linkedResource);
					message.AlternateViews.Add(alternateView);
				}
			}
		}
	}

	private string GetBase64Action(byte[] bytes, int offset, int length, FileStream fileStream)
	{
		fileStream.Read(bytes, offset, length);
		return Convert.ToBase64String(bytes, offset, length);
	}
}
