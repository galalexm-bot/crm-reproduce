using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ITaskAttachmetSpecifiedExtension
{
	string Name { get; }

	IEnumerable<long> AttachmentsIds(ITaskBase task);

	IEnumerable<IEntity<long>> GetAttachments(IEnumerable<long> ids);

	void SaveAttachments(ITaskBase task);
}
