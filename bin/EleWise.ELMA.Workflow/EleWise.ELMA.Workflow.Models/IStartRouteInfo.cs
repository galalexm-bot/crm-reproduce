using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Workflow.Models;

public interface IStartRouteInfo
{
	IProcessHeader ProcessHeader { get; set; }

	bool ContexVarSelector { get; set; }

	long ContexVarCount { get; set; }

	Guid ContextVar { get; set; }

	string ContextVarName { get; }

	string ContextVarSystemName { get; }

	RelationType ContextVarRelationType { get; }

	Guid ObjectType { get; set; }

	RelationType? RelationType { get; set; }

	List<long> Objects { get; set; }

	string Name { get; set; }

	List<IEntity<long>> ObjectList { get; }
}
