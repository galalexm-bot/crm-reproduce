using System;
using System.Text.RegularExpressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Managers;

public class CommentManager : EntityManager<IComment, long>
{
	public new static CommentManager Instance => Locator.GetServiceNotNull<CommentManager>();

	public string ClearEmptyText(string textMessage)
	{
		if (string.IsNullOrWhiteSpace(textMessage))
		{
			return null;
		}
		return Regex.Replace(textMessage, "(?:\r?\n){3,}", Environment.NewLine + Environment.NewLine).Trim((Environment.NewLine + "\t ").ToCharArray());
	}
}
