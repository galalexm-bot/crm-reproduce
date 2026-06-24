using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class FilterDocumentGridStateProvider : FilterGridStateProvider
{
	public new static Guid UID = new Guid("{B8EF1E6C-D4B9-4C67-ADFB-61ECE4FB80A9}");

	public override Guid Uid => UID;

	protected override IFilterBase CreateNew()
	{
		return InterfaceActivator.Create<IFilterDocumentFolder>();
	}

	protected override IFilterBase LoadFilterByUid(Guid uid)
	{
		return FilterDocumentFolderManager.Instance.Load(uid);
	}
}
