using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Components.GridStateSaveModeProviders;

[Component(Order = int.MaxValue)]
internal class DefaultGridStateSaveModeProvider : ITablePartGridStateSaveModeProvider
{
	public GridStateSaveMode? GetGridStateSaveMode(Guid typeUid)
	{
		return GridStateSaveMode.SaveInSessionAndDb;
	}
}
