using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Db;

[Component(Order = 2)]
public class ControlOnSendedDbUpdateHandler : DbUpdateHandler
{
	private bool needRecreate;

	public override bool HasChanges => needRecreate;

	public override bool NeedRecreateConstraints => needRecreate;

	public override Guid ProviderUid => Guid.Empty;

	public override void Init()
	{
		base.Init();
		DbModelUpdater serviceNotNull = Locator.GetServiceNotNull<DbModelUpdater>();
		List<DocumentMetadata> source = serviceNotNull.CurrentMetadata.OfType<DocumentMetadata>().ToList();
		List<DocumentMetadata> list = serviceNotNull.PreviousMetadata.OfType<DocumentMetadata>().ToList();
		needRecreate = false;
		foreach (DocumentMetadata metadata in list)
		{
			DocumentMetadata documentMetadata = source.FirstOrDefault((DocumentMetadata c) => c.Uid == metadata.Uid);
			if (documentMetadata != null && documentMetadata.ControlOnSending != metadata.ControlOnSending)
			{
				needRecreate = true;
				break;
			}
		}
	}
}
