using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class LifeCycleStatusChangerFormModel
{
	private List<ILifeCycleTransition> _items = new List<ILifeCycleTransition>();

	public ILifeCycleStatus CurrentStatus { get; set; }

	public Guid DocumentType { get; set; }

	[StringSettings(MultiLine = true)]
	public string Comment { get; set; }

	public string Popupid { get; set; }

	public IDocument Document { get; set; }

	public ILifeCycleStatus SelectedStatus { get; set; }

	public List<ILifeCycleTransition> Transitions
	{
		get
		{
			if (_items.Count == 0 && DocumentType != Guid.Empty)
			{
				_items = new List<ILifeCycleTransition>();
				bool flag = Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
				ILifeCycle lifeCycle = LifeCycleManager.Instance.LoadOrNull(DocumentType);
				if (lifeCycle != null)
				{
					_items = ((IEnumerable<ILifeCycleTransition>)lifeCycle.Transitions).ToList();
					if (!flag)
					{
						_items = _items.Where((ILifeCycleTransition t) => CurrentStatus == null || t.Start.Id == CurrentStatus.Id).ToList();
					}
				}
			}
			return _items;
		}
	}

	public void Init()
	{
		ILifeCycle lifeCycle = LifeCycleManager.Instance.LoadOrNull(DocumentType);
		if (lifeCycle != null)
		{
			bool hasFullAccess = Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
			ILifeCycleTransition lifeCycleTransition = ((IEnumerable<ILifeCycleTransition>)lifeCycle.Transitions).FirstOrDefault((ILifeCycleTransition t) => hasFullAccess || CurrentStatus == null || t.Start.Id == CurrentStatus.Id);
			if (lifeCycleTransition != null)
			{
				SelectedStatus = lifeCycleTransition.Finish;
			}
		}
	}
}
