using System;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models;

internal class FeedMessageInfoLoadSettings
{
	public IUser Recipient { get; set; }

	public int MaxCount { get; set; }

	public DateTime? ChangeDate { get; set; }

	public FeedMessageInfoLoadSettings()
	{
		MaxCount = 20;
	}
}
