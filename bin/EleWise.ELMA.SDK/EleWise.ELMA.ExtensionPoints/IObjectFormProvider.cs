using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IObjectFormProvider
{
	bool Check(Guid typeUid, Guid subTypeUid);

	(object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model);

	FormViewItem GetFormByType(object obj, ViewType viewType);

	FormViewItem GetFormByUid(object obj, Guid formUid);

	void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments);
}
