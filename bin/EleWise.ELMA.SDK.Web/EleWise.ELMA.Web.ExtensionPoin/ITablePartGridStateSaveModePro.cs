using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ITablePartGridStateSaveModeProvider
{
	GridStateSaveMode? GetGridStateSaveMode(Guid typeUid);
}
