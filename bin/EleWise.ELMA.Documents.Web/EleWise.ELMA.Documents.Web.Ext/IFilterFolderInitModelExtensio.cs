using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[Obsolete("Больше не используется")]
public interface IFilterFolderInitModelExtension
{
	void Init(FilterFolderModel model);
}
