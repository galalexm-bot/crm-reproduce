using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Messages.Web.Models;

public class MessagesExpandedState
{
	public List<MessageExpandedItem> Items { get; set; }

	public bool this[long messageId]
	{
		get
		{
			return GetItem(messageId).Expanded;
		}
		set
		{
			GetItem(messageId).Expanded = value;
		}
	}

	public MessagesExpandedState()
	{
		Items = new List<MessageExpandedItem>();
	}

	public MessageExpandedItem GetItem(long messageId)
	{
		MessageExpandedItem messageExpandedItem = Items.FirstOrDefault((MessageExpandedItem i) => i.MessageId == messageId);
		if (messageExpandedItem == null)
		{
			messageExpandedItem = new MessageExpandedItem
			{
				MessageId = messageId
			};
			Items.Add(messageExpandedItem);
		}
		return messageExpandedItem;
	}
}
