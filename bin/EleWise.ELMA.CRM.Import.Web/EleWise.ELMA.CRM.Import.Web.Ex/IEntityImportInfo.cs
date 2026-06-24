using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Import.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityImportInfo
{
	Type Type { get; }
}
