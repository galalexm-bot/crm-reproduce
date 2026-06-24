using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html.Grids;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IReplacementTaskGridPropertySettings
{
	void RenderColumns<T>(DynamicColumnsBuilder<T> columnsBuilder, IReplacementTask replacementTask) where T : class, IEntity;
}
