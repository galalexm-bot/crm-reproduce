using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Managers;

[ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
public interface IPeriodicalEntityManager
{
	void CreatingPeriodicEntities(IPeriodicalEntity template, bool continueFromLastDate);

	ICollection<IPeriodicalEntity> FindActive();

	long CountByTemplate(IPeriodicalEntity template, DateTime fromDate);

	IEntity CreateByTemplate(IPeriodicalEntity template, DateTime startTime, DateTime endTime);

	int GetForwardCreated();
}
