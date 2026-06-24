using System;

namespace EleWise.ELMA.Tasks.Models;

[Obsolete("User IReplacementExtension instead", true)]
public interface ITaskControlReplacement
{
	[Obsolete("Свойство больше не используется", true)]
	bool RedirectControlTask { get; set; }
}
