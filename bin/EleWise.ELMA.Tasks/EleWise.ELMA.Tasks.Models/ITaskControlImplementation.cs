using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

public interface ITaskControlImplementation : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	IUser ControlUser { get; set; }

	TaskControlType ControlType { get; set; }

	ISet<IUser> CurrentControllers { get; set; }

	bool UnderControl { get; set; }
}
