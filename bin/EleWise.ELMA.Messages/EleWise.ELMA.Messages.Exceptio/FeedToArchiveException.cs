using System;

namespace EleWise.ELMA.Messages.Exceptions;

[Serializable]
public sealed class FeedToArchiveException : Exception
{
	public long UserId { get; set; }

	public FeedToArchiveException(long userId, Exception exception)
		: base(SR.T("Ошибка при архивировании ленты пользователя с Id = {0}", userId), exception)
	{
		UserId = userId;
	}
}
