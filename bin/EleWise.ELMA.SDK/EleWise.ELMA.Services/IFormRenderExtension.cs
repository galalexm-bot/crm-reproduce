using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Services;

[ExtensionPoint(ComponentType.All)]
public interface IFormRenderExtension
{
	bool Check(IEntity<long> entity);

	bool CanRenderRuntimeVersion2(IEntity<long> entity, Guid formUid);
}
