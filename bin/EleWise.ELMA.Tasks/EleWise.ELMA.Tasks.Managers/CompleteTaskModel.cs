using System;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Tasks.Managers;

public struct CompleteTaskModel
{
	public ICommentActionModel actionModel;

	public bool alertCoexecuters;

	public DateTime? startDate;

	public long? worklogMinutes;
}
