using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDefaultFilterCatalogExtension
{
	Guid EntityTypeUid { get; }

	IEntityFilter ModifyFilter(IEntityFilter filter);
}
