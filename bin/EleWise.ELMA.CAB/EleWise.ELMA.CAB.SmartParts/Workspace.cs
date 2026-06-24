using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.SmartParts;

public abstract class Workspace<TSmartPart, TSmartPartInfo> : IWorkspace where TSmartPartInfo : ISmartPartInfo, new()
{
	private readonly List<TSmartPart> smartParts = new List<TSmartPart>();

	private object activeSmartPart;

	private WorkItem workItem;

	[ServiceDependency]
	public WorkItem WorkItem
	{
		set
		{
			workItem = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public object ActiveSmartPart => activeSmartPart;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ReadOnlyCollection<object> SmartParts => new ReadOnlyCollection<object>(smartParts.ConvertAll((Converter<TSmartPart, object>)((TSmartPart smartPart) => smartPart)));

	protected ICollection<TSmartPart> InnerSmartParts => smartParts;

	public event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;

	public event EventHandler<WorkspaceEventArgs> SmartPartActivated;

	public void Activate(object smartPart)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		ThrowIfUnsupportedSP(smartPart);
		ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);
		if (activeSmartPart != smartPart)
		{
			OnActivate((TSmartPart)smartPart);
			activeSmartPart = smartPart;
			RaiseSmartPartActivated(smartPart);
		}
	}

	public void ApplySmartPartInfo(object smartPart, ISmartPartInfo smartPartInfo)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		Guard.ArgumentNotNull(smartPartInfo, "smartPartInfo");
		ThrowIfUnsupportedSP(smartPart);
		ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);
		TSmartPartInfo supportedSPI = GetSupportedSPI(smartPartInfo);
		OnApplySmartPartInfo((TSmartPart)smartPart, supportedSPI);
	}

	public void Show(object smartPart, ISmartPartInfo smartPartInfo)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		Guard.ArgumentNotNull(smartPartInfo, "smartPartInfo");
		ThrowIfUnsupportedSP(smartPart);
		TSmartPartInfo supportedSPI = GetSupportedSPI(smartPartInfo);
		TSmartPart val = (TSmartPart)smartPart;
		if (smartParts.Contains(val))
		{
			ApplySmartPartInfo(smartPart, smartPartInfo);
			Activate(smartPart);
		}
		else
		{
			smartParts.Add(val);
			OnShow(val, supportedSPI);
		}
	}

	public void Show(object smartPart)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		ThrowIfUnsupportedSP(smartPart);
		TSmartPart val = (TSmartPart)smartPart;
		if (smartParts.Contains(val))
		{
			Activate(smartPart);
			return;
		}
		ISmartPartInfo smartPartInfo = null;
		ISmartPartInfoProvider smartPartInfoProvider = smartPart as ISmartPartInfoProvider;
		if (workItem != null)
		{
			smartPartInfo = workItem.GetSmartPartInfo<TSmartPartInfo>(smartPart);
			if (smartPartInfo == null && smartPartInfoProvider != null)
			{
				smartPartInfo = smartPartInfoProvider.GetSmartPartInfo(typeof(TSmartPartInfo));
			}
			if (smartPartInfo == null)
			{
				smartPartInfo = workItem.GetSmartPartInfo<SmartPartInfo>(smartPart);
			}
			if (smartPartInfo == null && smartPartInfoProvider != null)
			{
				smartPartInfo = smartPartInfoProvider.GetSmartPartInfo(typeof(SmartPartInfo));
			}
		}
		else if (smartPartInfoProvider != null)
		{
			smartPartInfo = smartPartInfoProvider.GetSmartPartInfo(typeof(TSmartPartInfo)) ?? smartPartInfoProvider.GetSmartPartInfo(typeof(SmartPartInfo));
		}
		if (smartPartInfo == null)
		{
			smartPartInfo = CreateDefaultSmartPartInfo(val);
		}
		Show(val, smartPartInfo);
	}

	public void Hide(object smartPart)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		ThrowIfUnsupportedSP(smartPart);
		ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);
		if (activeSmartPart == smartPart)
		{
			activeSmartPart = null;
		}
		OnHide((TSmartPart)smartPart);
	}

	public void Close(object smartPart)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		ThrowIfUnsupportedSP(smartPart);
		ThrowIfSmartPartNotShownPreviously((TSmartPart)smartPart);
		WorkspaceCancelEventArgs workspaceCancelEventArgs = RaiseSmartPartClosing(smartPart);
		if (!workspaceCancelEventArgs.Cancel)
		{
			CloseInternal((TSmartPart)smartPart);
		}
	}

	private TSmartPartInfo GetSupportedSPI(ISmartPartInfo smartPartInfo)
	{
		__ContractsRuntime.Requires<ArgumentNullException>(smartPartInfo != null, null, "smartPartInfo != null");
		return (!typeof(TSmartPartInfo).IsAssignableFrom(smartPartInfo.GetType())) ? ConvertFrom(smartPartInfo) : ((TSmartPartInfo)smartPartInfo);
	}

	private static void ThrowIfUnsupportedSP(object smartPart)
	{
		__ContractsRuntime.Requires<ArgumentNullException>(smartPart != null, null, "smartPart != null");
		if (!typeof(TSmartPart).IsAssignableFrom(smartPart.GetType()))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.UnsupportedSmartPartType, new object[2]
			{
				smartPart.GetType(),
				typeof(TSmartPart)
			}), "smartPart");
		}
	}

	private void ThrowIfSmartPartNotShownPreviously(TSmartPart smartPart)
	{
		if (!smartParts.Contains(smartPart))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.SmartPartNotInWorkspace, new object[2] { smartPart, this }));
		}
	}

	protected void RaiseSmartPartActivated(object smartPart)
	{
		EventHandler<WorkspaceEventArgs> smartPartActivated = this.SmartPartActivated;
		if (smartPartActivated != null)
		{
			WorkspaceEventArgs e = new WorkspaceEventArgs(smartPart);
			smartPartActivated(this, e);
		}
	}

	protected WorkspaceCancelEventArgs RaiseSmartPartClosing(object smartPart)
	{
		WorkspaceCancelEventArgs workspaceCancelEventArgs = new WorkspaceCancelEventArgs(smartPart);
		RaiseSmartPartClosing(workspaceCancelEventArgs);
		return workspaceCancelEventArgs;
	}

	protected void RaiseSmartPartClosing(WorkspaceCancelEventArgs e)
	{
		this.SmartPartClosing?.Invoke(this, e);
	}

	protected abstract void OnActivate(TSmartPart smartPart);

	protected abstract void OnApplySmartPartInfo(TSmartPart smartPart, TSmartPartInfo smartPartInfo);

	protected abstract void OnShow(TSmartPart smartPart, TSmartPartInfo smartPartInfo);

	protected abstract void OnHide(TSmartPart smartPart);

	protected abstract void OnClose(TSmartPart smartPart);

	protected virtual TSmartPartInfo ConvertFrom(ISmartPartInfo source)
	{
		return SmartPartInfo.ConvertTo<TSmartPartInfo>(source);
	}

	protected virtual TSmartPartInfo CreateDefaultSmartPartInfo(TSmartPart forSmartPart)
	{
		return new TSmartPartInfo();
	}

	protected void CloseInternal(TSmartPart smartPart)
	{
		OnClose(smartPart);
		if (activeSmartPart != null && activeSmartPart.Equals(smartPart))
		{
			activeSmartPart = null;
		}
		smartParts.Remove(smartPart);
	}

	protected void SetActiveSmartPart(object value)
	{
		if (value != null)
		{
			ThrowIfUnsupportedSP(value);
			ThrowIfSmartPartNotShownPreviously((TSmartPart)value);
		}
		activeSmartPart = value;
	}
}
