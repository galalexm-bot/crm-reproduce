using System.Collections.Generic;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

public class ReplacementTaskNotificationItem
{
	public IEntity Entity { get; set; }

	public List<Pair<string, IUser>> Properties { get; set; }

	public ReplacementTaskNotificationItem()
	{
		Properties = new List<Pair<string, IUser>>();
	}

	public ReplacementTaskNotificationItem(IEntity entity)
	{
		Properties = new List<Pair<string, IUser>>();
		Entity = entity;
	}
}
