using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Messages.Exceptions;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging.Email.Exceptions;
using EleWise.ELMA.Messaging.EmailFormat;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Notifications.Impl;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Messaging.Email;

[Component(Order = 100)]
public class EmailChannel : GroupingMessageChannel, IThreadPoolContainer
{
	private class CachedFile
	{
		private readonly string name;

		private readonly string contentType;

		private readonly byte[] content;

		private readonly Stream stream;

		public CachedFile(string id, bool needCache, IFileManager fileManager, ICacheFilesService cacheFilesService, IMimeMappingService mimeMappingService)
		{
			try
			{
				MessagesLog.Debug(SR.T("Создание кешируемого файла вложения"));
				BinaryFile binaryFile = fileManager.LoadFile(id);
				if (binaryFile == null || !(binaryFile.ContentLocation != null))
				{
					return;
				}
				name = binaryFile.Name;
				contentType = binaryFile.ContentType;
				if (needCache)
				{
					using (Stream stream = binaryFile.GetContent())
					{
						content = stream.ReadAllBytes();
						return;
					}
				}
				this.stream = binaryFile.GetContent();
			}
			catch (FileNotFoundException)
			{
				MessagesLog.Warn(SR.T("Файл не найден на диске. Производится поиск во временных файлах"));
				Guid uid = new Guid(id);
				string filePath = cacheFilesService.GetFilePath(uid);
				if (string.IsNullOrEmpty(filePath))
				{
					return;
				}
				name = cacheFilesService.GetFileName(uid);
				contentType = mimeMappingService.GetTypeByExtension(Path.GetExtension(name));
				if (needCache)
				{
					using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
					{
						content = fileStream.ReadAllBytes();
						return;
					}
				}
				this.stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			}
			catch (Exception exception)
			{
				MessagesLog.Error(SR.T("Не удалось создать кешируемый файл вложения"), exception);
			}
		}

		public Attachment GetAttachment()
		{
			try
			{
				return new Attachment(stream ?? MemoryHelper.GetMemoryStream(content, writable: false), name, contentType);
			}
			catch (Exception exception)
			{
				MessagesLog.Error(SR.T("Ошибка формирования вложения \"{0}\"", name), exception);
				return null;
			}
		}
	}

	private const string MessageChannelEmailEnabled = "MessageChannel.Email.Enabled";

	public static readonly Guid UID = new Guid("{DDDC2682-7518-4C0B-B40C-EFA59A4FD53B}");

	private static Type ownerType;

	private static MethodInfo methodSend;

	private static readonly ILogger MessagesLog = Logger.GetLogger("Messages");

	private readonly ThreadSubPool _pool;

	private readonly EmailSender sender;

	IThreadPool IThreadPoolContainer.Pool => _pool;

	public IFileManager FileManager { get; set; }

	public ICacheFilesService CacheFilesService { get; set; }

	public IMimeMappingService MimeMappingService { get; set; }

	public IFeatureFlagService FeatureFlagService { get; set; }

	public override Guid Uid => UID;

	public override string Name => "EMail";

	public override string DisplayName => SR.T("Электронная почта");

	private static Type OwnerType
	{
		get
		{
			Type result = ownerType ?? typeof(EmailChannel);
			ownerType = result;
			return result;
		}
	}

	private static MethodInfo MethodSend
	{
		get
		{
			MethodInfo result = methodSend ?? OwnerType.GetMethod("Send", new Type[2]
			{
				typeof(IMessage),
				typeof(IEnumerable<EleWise.ELMA.Security.IUser>)
			});
			methodSend = result;
			return result;
		}
	}

	public override bool Enabled => FeatureFlagService.Enabled("MessageChannel.Email.Enabled", defaultEnabled: true);

	private EmailSettings Settings
	{
		get
		{
			if (Locator.Initialized)
			{
				EmailSettingsModule service = Locator.GetService<EmailSettingsModule>();
				if (service != null)
				{
					return service.Settings;
				}
			}
			MessagesLog.Debug(SR.T("Менеджер служб не инициализирован"));
			return null;
		}
	}

	private CommonSettings CommonSettings
	{
		get
		{
			if (Locator.Initialized)
			{
				CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
				if (service != null)
				{
					return service.Settings;
				}
			}
			MessagesLog.Debug(SR.T("Менеджер служб не инициализирован"));
			return null;
		}
	}

	public EmailChannel(EmailSender sender)
	{
		Contract.ArgumentNotNull(sender, "sender");
		this.sender = sender;
		_pool = new ThreadSubPool("EmailChannel.PoolSize", 5);
	}

	private bool NotificationContains(Guid notificationFlowUid, Guid ObjectTypeUid, Guid ActionUid)
	{
		if (DefaultNotificationFlow.UID.Equals(notificationFlowUid))
		{
			return true;
		}
		return (from fo in ComponentManager.Current.GetExtensionPoints<INotificationFlow>().FirstOrDefault((INotificationFlow x) => x.Uid.Equals(notificationFlowUid)).FlowObjects
			where fo.Get().ContainsKey(ObjectTypeUid)
			select fo.Get().Values).Any((ICollection<Guid[]> fa) => fa.Any((Guid[] a) => a.Contains(ActionUid)));
	}

	public override void Send(IMessage message)
	{
		Contract.ArgumentNotNull(message, "message");
		EleWise.ELMA.Security.Models.IUser user = message.Recipient as EleWise.ELMA.Security.Models.IUser;
		EleWise.ELMA.Security.Models.IUser user2 = message.Author as EleWise.ELMA.Security.Models.IUser;
		if (user == null)
		{
			MessagesLog.Debug(SR.T("Получатель сообщения не указан"));
		}
		else if (string.IsNullOrEmpty(user.EMail))
		{
			MessagesLog.Debug(SR.T("Адрес электронной почты получателя {0} не задан", user.FullName));
		}
		else if (user2 != null && user2.Id == user.Id && !message.SendToAuthor)
		{
			MessagesLog.Debug(SR.T("Получатель {0} является автором сообщения, которому не нужно отправлять сообщение принудительно", user.FullName));
		}
		else
		{
			Send(message, new EleWise.ELMA.Security.Models.IUser[1] { user });
		}
	}

	public override void Send(IMessage message, IEnumerable<EleWise.ELMA.Security.IUser> recipients)
	{
		Contract.ArgumentNotNull(message, "message");
		Contract.ArgumentNotNull(recipients, "recipients");
		if (Settings == null || !Settings.Enabled)
		{
			MessagesLog.Debug(SR.T("Оповещения по электронной почте отключены"));
			return;
		}
		using MethodCallInfo methodCallInfo = DiagnosticsManager.StartCall(delegate
		{
			Type type = OwnerType;
			MethodInfo method = MethodSend;
			object[] arguments = new IMessage[1] { message };
			return new MethodCallInfo(type, method, arguments);
		});
		Dictionary<MailMessage, EleWise.ELMA.Security.IUser> dictionary = new Dictionary<MailMessage, EleWise.ELMA.Security.IUser>();
		EleWise.ELMA.Security.IUser[] array = recipients.Where((EleWise.ELMA.Security.IUser u) => u != null && !string.IsNullOrWhiteSpace(u.EMail)).ToArray();
		int recipientCount = array.Length;
		try
		{
			ISecurityService securityService = Locator.GetServiceNotNull<ISecurityService>();
			EleWise.ELMA.Security.Models.IUser systemUser = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
			long parentObjectId = 0L;
			Guid parentObjectUid = Guid.Empty;
			securityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
			{
				securityService.RunByUser(systemUser, delegate
				{
					long actionObjectId = ((message.ObjectId != null) ? long.Parse(message.ObjectId) : 0);
					Guid actionObjectUid = message.ObjectUid ?? Guid.Empty;
					Guid actionUid = message.ActionUid ?? Guid.Empty;
					FeedModel feedMessage = new FeedModel
					{
						ActionObjectId = actionObjectId,
						ActionObjectUid = actionObjectUid,
						ActionUid = actionUid,
						IsParent = true,
						Parent = null
					};
					(from p in ComponentManager.Current.GetExtensionPoints<IFeedMessageUpdateProvider>()
						where p.CanUpdateMessage(actionUid, actionObjectUid, actionObjectId)
						select p.GetMessageUpdater(actionUid, actionObjectUid, actionObjectId)).ForEach(delegate(IFeedMessageUpdater u)
					{
						u.UpdateMessage(feedMessage);
					});
					if (feedMessage.ParentObjectId.HasValue)
					{
						parentObjectId = feedMessage.ParentObjectId.Value;
					}
					if (feedMessage.ParentObjectUid.HasValue)
					{
						parentObjectUid = feedMessage.ParentObjectUid.Value;
					}
				});
			});
			List<MailMessage> list = new List<MailMessage>();
			CachedFile[] array2 = null;
			if (message.AttachmentIds != null && message.AttachmentIds.Any())
			{
				array2 = message.AttachmentIds.Select(delegate(string id)
				{
					try
					{
						return new CachedFile(id, recipientCount > 1, FileManager, CacheFilesService, MimeMappingService);
					}
					catch (Exception exception3)
					{
						MessagesLog.Error(SR.T("Не удалось создать кэшируемый файл с идентификатором '{0}'", id), exception3);
						return null;
					}
				}).ToArray();
			}
			EleWise.ELMA.Security.IUser[] array3 = array;
			foreach (EleWise.ELMA.Security.IUser user in array3)
			{
				byte[] array4 = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull($"UserNotificationSettings_{user.GetId()}");
				NotificationFlowSettings[] source = new NotificationFlowSettings[0];
				if (array4 != null)
				{
					source = ClassSerializationHelper.DeserializeObject(array4) as NotificationFlowSettings[];
				}
				IEnumerable<NotificationFlowSettings> source2 = source.Where((NotificationFlowSettings uns) => uns.ChannelUid == UID);
				NotificationFlowSettings notificationFlowSettings = ((message.ObjectUid.HasValue && message.ActionUid.HasValue) ? source2.FirstOrDefault((NotificationFlowSettings s) => NotificationContains(s.NotificationFlowUid, message.ObjectUid.Value, message.ActionUid.Value)) : null);
				string formatName = ((notificationFlowSettings != null) ? (notificationFlowSettings.Name ?? " ") : " ");
				if (formatName.Equals("None"))
				{
					MessagesLog.Debug(SR.T("Для текущего потока сообщений у пользователя {0} выбран формат \"Не оповещать\"", user.FullName));
					continue;
				}
				MailAddress to;
				try
				{
					to = new MailAddress(user.EMail, user.FullName);
				}
				catch (FormatException exception)
				{
					MessagesLog.Warn(SR.T("Неверный адрес электронной почты для пользователя {0} ({1}): {2}", user.UserName, user.FullName, user.EMail), exception);
					continue;
				}
				catch (Exception exception2)
				{
					MessagesLog.Error(SR.T("Невозможно создать сообщение для пользователя {0} ({1}): {2}", user.UserName, user.FullName, user.EMail), exception2);
					continue;
				}
				string text = null;
				string text2 = null;
				if (!string.IsNullOrEmpty(message.URL))
				{
					CommonSettings commonSettings = CommonSettings;
					text2 = ((commonSettings != null) ? commonSettings.ApplicationBaseUrl : "");
					if (!text2.EndsWith("/"))
					{
						text2 += "/";
					}
					text = text2 + (message.URL.StartsWith("/") ? message.URL.Substring(1) : message.URL);
				}
				string text3 = "";
				bool flag = Settings.IsHtmlFooter;
				bool needFooter = true;
				string emailFormatPrefix = "";
				if (!string.IsNullOrEmpty(formatName) && message.CustomMessages != null && message.CustomMessages.Any())
				{
					CustomMessage customMessage = message.CustomMessages.FirstOrDefault((CustomMessage cm) => cm.Key.Second == formatName);
					if (customMessage != null)
					{
						text3 = AddDownloadIcon(customMessage.Content, "<a href='{#BaseUrl#}SDK.Action/BinaryFiles/Download", "<img src='{#BaseUrl#}Content/Images/x16/attach.png' /> ").FormatWithBaseUrl(text2);
						flag = true;
						needFooter = false;
						if (notificationFlowSettings != null && !string.IsNullOrEmpty(notificationFlowSettings.Name))
						{
							emailFormatPrefix = Locator.GetServiceNotNull<EmailFormatSettingsModule>().GetPrefix(notificationFlowSettings.Name);
						}
					}
				}
				if (string.IsNullOrEmpty(text3))
				{
					if (Settings != null && Settings.IncludeHeaderInBody)
					{
						text3 = message.Subject + "\n----\n\n";
						if (message.Author != null || !string.IsNullOrWhiteSpace(message.AuthorText))
						{
							text3 += SR.T("Автор: {0}\n", string.IsNullOrWhiteSpace(message.AuthorText) ? ((EleWise.ELMA.Security.Models.IUser)message.Author).GetShortName() : message.AuthorText);
						}
						if (!string.IsNullOrEmpty(text))
						{
							text3 = text3 + "URL: " + text + "\n";
						}
					}
					text3 = ((!flag) ? (text3 + message.FullMessageText.FormatWithBaseUrl(text2)) : (ElmaGeneratorFormatProvider.FormatTextToLink(ElmaGeneratorFormatProvider.FormatTextTagBracket(text3), wrap: true, contextVarEnabled: true).Nl2Br() + message.FullMessageHtml.FormatWithBaseUrl(text2)));
				}
				MailMessage mailMessage = sender.CreateMessage(to, message.Subject, text3, flag, needFooter, null, emailFormatPrefix);
				IMemoryCacheService serviceNotNull = Locator.GetServiceNotNull<IMemoryCacheService>();
				string result = string.Empty;
				if (!serviceNotNull.TryGetValue<string>(Settings.SenderEMail, out result))
				{
					result = new MailAddress(Settings.SenderEMail).Host;
					serviceNotNull.Insert(Settings.SenderEMail, result);
				}
				mailMessage.Headers.Add("References", $"<{parentObjectUid:N}_{parentObjectId}@{result}>");
				if (array2 != null)
				{
					CachedFile[] array5 = array2;
					foreach (CachedFile cachedFile in array5)
					{
						if (cachedFile != null)
						{
							Attachment attachment = cachedFile.GetAttachment();
							if (attachment != null)
							{
								mailMessage.Attachments.Add(attachment);
							}
						}
					}
				}
				list.Add(mailMessage);
				dictionary.Add(mailMessage, user);
			}
			sender.SendMessages(new SmtpSettings(Settings), list);
		}
		catch (Exception ex)
		{
			if (methodCallInfo != null)
			{
				methodCallInfo.Exception = ex;
			}
			MessagesLog.Error(SR.T("Ошибка отправки сообщения"), ex);
			GroupingUserMailMessagesException ex2 = new GroupingUserMailMessagesException();
			if (ex is GroupingMailMessagesException)
			{
				foreach (KeyValuePair<MailMessage, Exception> exception4 in (ex as GroupingMailMessagesException).Exceptions)
				{
					KeyValuePair<MailMessage, Exception> except1 = exception4;
					if (dictionary.ContainsKey(except1.Key))
					{
						EleWise.ELMA.Security.IUser value = dictionary.First((KeyValuePair<MailMessage, EleWise.ELMA.Security.IUser> v) => v.Key == except1.Key).Value;
						ex2.Exceptions.Add(value, except1.Value);
					}
				}
			}
			else
			{
				ex2.Exceptions.Add(dictionary.First().Value, ex);
			}
			throw ex2;
		}
	}

	private string AddDownloadIcon(string source, string find, string add)
	{
		for (int num = source.IndexOf(find, 0); num >= 0; num = source.IndexOf(find, num + 1))
		{
			int num2 = source.IndexOf(">", num + 1);
			if (num2 >= 0)
			{
				source = source.Insert(num2 + 1, add);
			}
		}
		return source;
	}
}
