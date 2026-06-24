using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models;

public interface IPeriodicalEntity : IEntity, IIdentified
{
	Periodicity Period { get; set; }

	DateTime? UntilDate { get; set; }

	int ForwardCreated { get; set; }

	DateTime? LastPeriodDate { get; set; }

	bool Closed { get; set; }

	DateTime StartDate { get; set; }

	DateTime EndDate { get; set; }

	IUser CreationAuthor { get; set; }
}
