using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content.Models;

[FilterFor(typeof(IWorkplaceColorScheme))]
public interface IWorkplaceColorSchemeFilter : IEntityFilter
{
	ISet<IColorScheme> ColorSchemes { get; set; }
}
