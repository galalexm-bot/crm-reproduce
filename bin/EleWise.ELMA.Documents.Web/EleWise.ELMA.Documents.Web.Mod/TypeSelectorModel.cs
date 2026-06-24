using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class TypeSelectorModel
{
	private Lazy<List<ClassMetadata>> _lastTypes;

	public long? FolderId { get; set; }

	public long? LinkedDocument { get; set; }

	public string PopupId { get; set; }

	public string Parameters { get; set; }

	[RequiredField]
	public Guid Uid { get; set; }

	public List<ClassMetadata> LastTypes
	{
		get
		{
			if (_lastTypes == null || !_lastTypes.IsValueCreated)
			{
				ICreateHistoryService historyService = Locator.GetService<ICreateHistoryService>();
				_lastTypes = new Lazy<List<ClassMetadata>>(() => historyService.Get());
			}
			return _lastTypes.Value;
		}
	}
}
