using System;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Exceptions;

[Serializable]
public class SendMessageException : Exception
{
	public IUser[] Users { get; set; }

	public Guid Channel { get; set; }

	public IMessage ProcessedMessage { get; set; }
}
