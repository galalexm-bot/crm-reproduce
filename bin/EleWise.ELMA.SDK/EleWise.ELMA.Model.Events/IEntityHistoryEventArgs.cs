using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Model.Events;

[ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
public interface IEntityHistoryEventArgs : IAuditEventArgs, IAuditEventHolder, IExtendedPropertiesContainer
{
	DateTime ActionDate { get; set; }

	Guid UnitOfWorkUid { get; set; }

	IUser ActionAuthor { get; set; }

	byte[] GetAdditionalData();

	void SetAdditionalData(byte[] data);
}
