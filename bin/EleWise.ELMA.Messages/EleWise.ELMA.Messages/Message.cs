using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messages;

[Component]
public class Message : IMessage, IMessageBase, ITransactionalMessage, IXsiRoot
{
	private IList<EleWise.ELMA.Security.Models.IUser> recipientsList;

	private EleWise.ELMA.Security.Models.IUser recipient;

	private bool needLoadRecipientsList;

	private bool needLoadRecipient;

	private long[] recipientsListToLoad;

	private long? recipientIdToLoad;

	private long? authorIdToLoad;

	private EleWise.ELMA.Security.Models.IUser author;

	private bool needLoadAuthor;

	private object originalRecipientValue;

	public string Channels { get; set; }

	[XmlIgnore]
	public EleWise.ELMA.Security.Models.IUser Recipient
	{
		get
		{
			if (needLoadRecipient)
			{
				needLoadRecipient = false;
				recipient = ((!recipientIdToLoad.HasValue) ? null : UserManager.Instance.Load(recipientIdToLoad.Value));
			}
			return recipient;
		}
		set
		{
			recipient = value;
			recipientIdToLoad = ((recipient != null) ? new long?(recipient.Id) : null);
			needLoadRecipient = false;
		}
	}

	[XmlIgnore]
	public EleWise.ELMA.Security.Models.IUser Author
	{
		get
		{
			if (needLoadAuthor)
			{
				needLoadAuthor = false;
				author = ((!authorIdToLoad.HasValue) ? null : UserManager.Instance.Load(authorIdToLoad.Value));
			}
			return author;
		}
		set
		{
			author = value;
			authorIdToLoad = ((author != null) ? new long?(author.Id) : null);
			needLoadAuthor = false;
		}
	}

	public long? AuthorId
	{
		get
		{
			return authorIdToLoad;
		}
		set
		{
			if (authorIdToLoad != value)
			{
				needLoadAuthor = true;
				authorIdToLoad = value;
			}
		}
	}

	public long? RecipientId
	{
		get
		{
			return recipientIdToLoad;
		}
		set
		{
			if (recipientIdToLoad != value)
			{
				needLoadRecipient = true;
				recipientIdToLoad = value;
			}
		}
	}

	[XmlIgnore]
	public EleWise.ELMA.Security.Models.IUser[] Recipients
	{
		get
		{
			if (needLoadRecipientsList)
			{
				needLoadRecipientsList = false;
				recipientsList = ((recipientsListToLoad == null) ? null : recipientsListToLoad.Select((long id) => UserManager.Instance.Load(id)).ToList());
			}
			if (recipientsList != null)
			{
				return recipientsList.ToArray();
			}
			return null;
		}
		set
		{
			recipientsList = value?.ToList();
			recipientsListToLoad = value?.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id).ToArray();
			needLoadRecipientsList = false;
		}
	}

	public long[] RecipientIds
	{
		get
		{
			return recipientsListToLoad;
		}
		set
		{
			if (recipientsListToLoad == null && value == null)
			{
				recipientsList = null;
				needLoadRecipientsList = false;
			}
			else if (value == null || recipientsListToLoad == null)
			{
				recipientsListToLoad = value;
				needLoadRecipientsList = true;
			}
			else if (object.Equals(value, recipientsListToLoad))
			{
				recipientsListToLoad = value;
				needLoadRecipientsList = true;
			}
		}
	}

	public Guid? ObjectUid { get; set; }

	public Guid? ActionUid { get; set; }

	public MessagePriority Priority { get; set; }

	[DefaultValue(null)]
	public string URL { get; set; }

	public string AuthorText { get; set; }

	public string Subject { get; set; }

	public string ShortMessageText { get; set; }

	public string ShortMessageHtml { get; set; }

	public string FullMessageText { get; set; }

	public string FullMessageHtml { get; set; }

	[DefaultValue(null)]
	public string ObjectId { get; set; }

	[DefaultValue(false)]
	public bool SendToAuthor { get; set; }

	[DefaultValue(null)]
	public string[] AttachmentIds { get; set; }

	[DefaultValue(false)]
	public bool AttachmentsBySingleFile { get; set; }

	[DefaultValue(null)]
	public MessageAttachment[] MessageAttachments { get; set; }

	[DefaultValue(false)]
	public bool Delayed { get; set; }

	[DefaultValue(null)]
	public CustomMessage[] CustomMessages { get; set; }

	[XmlIgnore]
	object IMessage.Recipient
	{
		get
		{
			object obj = Recipient;
			object recipients = Recipients;
			return originalRecipientValue ?? recipients ?? obj;
		}
		set
		{
			originalRecipientValue = value;
			if (value == null)
			{
				Recipient = null;
				Recipients = null;
				return;
			}
			EleWise.ELMA.Security.Models.IUser user = value as EleWise.ELMA.Security.Models.IUser;
			IEnumerable enumerable = value as IEnumerable;
			IUserGroup userGroup = value as IUserGroup;
			IOrganizationItem organizationItem = value as IOrganizationItem;
			if (user != null)
			{
				Recipient = user;
			}
			if (enumerable != null)
			{
				EleWise.ELMA.Security.Models.IUser[] array2 = (Recipients = enumerable.Cast<EleWise.ELMA.Security.Models.IUser>().ToArray());
			}
			if (userGroup != null)
			{
				Recipients = UserGroupManager.Instance.GetUsersByGroup(userGroup.Id).Select(UserManager.Instance.Load).ToArray();
			}
			if (organizationItem != null)
			{
				Recipients = UserManager.Instance.GetUsersByDepartament(organizationItem).ToArray();
			}
		}
	}

	[XmlIgnore]
	object IMessage.Author
	{
		get
		{
			return Author;
		}
		set
		{
			Author = (EleWise.ELMA.Security.Models.IUser)value;
		}
	}

	[XmlIgnore]
	int IMessage.Priority
	{
		get
		{
			return (int)Priority;
		}
		set
		{
			Priority = (MessagePriority)value;
		}
	}

	IEnumerable<EleWise.ELMA.Security.IUser> IMessage.GetRecipients()
	{
		List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
		if (Recipient != null)
		{
			list.Add(Recipient);
		}
		if (Recipients != null)
		{
			list.AddRange(Recipients);
		}
		return list;
	}

	IEnumerable<IMessage> IMessageBase.GetMessages()
	{
		return new IMessage[1] { this };
	}
}
