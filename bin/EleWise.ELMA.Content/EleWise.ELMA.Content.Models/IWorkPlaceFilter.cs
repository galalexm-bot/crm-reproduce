using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Content.Models;

[FilterFor(typeof(IWorkPlace))]
public interface IWorkPlaceFilter : IEntityFilter
{
	string Name { get; set; }

	ILeftMenu LeftMenu { get; set; }

	IWorkplacePages WorkplacePages { get; set; }

	IStartMenu StartMenu { get; set; }

	IWebToolbar Toolbar { get; set; }

	IWorkplaceColorScheme WorkplaceColorSchemes { get; set; }
}
