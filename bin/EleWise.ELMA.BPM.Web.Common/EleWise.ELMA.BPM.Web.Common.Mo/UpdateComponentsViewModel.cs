using System;
using System.Collections.Generic;
using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class UpdateComponentsViewModel
{
	public string PostAction { get; private set; }

	[Obsolete("Свойство утратило актуальность - не используйте его", true)]
	public string SoftUpdatePostAction { get; private set; }

	public IEnumerable<IStoreComponentInfo> Components { get; private set; }

	public string[] SelectedComponentIds { get; set; }

	public UpdateComponentsViewModel(string postAction, IEnumerable<IStoreComponentInfo> components)
	{
		PostAction = postAction;
		Components = components;
	}
}
