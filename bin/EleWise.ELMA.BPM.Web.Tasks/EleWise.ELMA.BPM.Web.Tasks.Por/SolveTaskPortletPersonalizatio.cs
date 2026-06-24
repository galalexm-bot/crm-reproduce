using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Serializable]
public class SolveTaskPortletPersonalization : TasksPortletPersonalization
{
	private bool openLinksInNewWindow = true;

	[OptionalField]
	private bool executionControl;

	[OptionalField]
	private bool debugMode;

	[OptionalField]
	private bool hideAttachmets;

	[OptionalField]
	private bool hideContextAttachments;

	[OptionalField]
	private bool hideActions;

	private List<TaskTypeOption> tasksQuickMode = new List<TaskTypeOption>();

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool OpenLinksInNewWindow
	{
		get
		{
			return openLinksInNewWindow;
		}
		set
		{
			openLinksInNewWindow = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual List<TaskTypeOption> TasksQuickMode
	{
		get
		{
			return tasksQuickMode;
		}
		set
		{
			tasksQuickMode = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ExecutionControl
	{
		get
		{
			return executionControl;
		}
		set
		{
			executionControl = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool DebugMode
	{
		get
		{
			return debugMode;
		}
		set
		{
			debugMode = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool HideAttachmets
	{
		get
		{
			return hideAttachmets;
		}
		set
		{
			hideAttachmets = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool HideContextAttachments
	{
		get
		{
			return hideContextAttachments;
		}
		set
		{
			hideContextAttachments = value;
		}
	}

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool HideActions
	{
		get
		{
			return hideActions;
		}
		set
		{
			hideActions = value;
		}
	}

	public void InitCompleteTaskOptions()
	{
		if (TasksQuickMode == null)
		{
			TasksQuickMode = new List<TaskTypeOption>();
		}
		IEnumerable<ISolveTaskQuickMode> solveTasks = ComponentManager.Current.GetExtensionPoints<ISolveTaskQuickMode>();
		TasksQuickMode.RemoveAll((TaskTypeOption o) => solveTasks.All((ISolveTaskQuickMode s) => s.TypeUid != o.TypeUid));
		List<TaskTypeOption> collection = (from o in solveTasks
			where TasksQuickMode.All((TaskTypeOption s) => s.TypeUid != o.TypeUid)
			select new TaskTypeOption
			{
				TypeUid = o.TypeUid
			}).ToList();
		TasksQuickMode.AddRange(collection);
	}

	public bool GetTaskQuickSettings(Guid taskUid)
	{
		return TasksQuickMode.FirstOrDefault((TaskTypeOption m) => m.TypeUid == taskUid)?.QuickMode ?? false;
	}

	protected override IDictionary<string, string> GetStorageValue(PropertyInfo property)
	{
		if (property.Name == "TasksQuickMode")
		{
			return new Dictionary<string, string> { 
			{
				property.Name,
				ClassSerializationHelper.SerializeObjectByJson(TasksQuickMode)
			} };
		}
		return base.GetStorageValue(property);
	}

	protected override void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
	{
		if (property.Name == "TasksQuickMode")
		{
			string text = values[property.Name];
			if (text == null)
			{
				return;
			}
			try
			{
				TasksQuickMode = ClassSerializationHelper.DeserializeObjectByJson<List<TaskTypeOption>>(text);
				return;
			}
			catch (SerializationException)
			{
			}
		}
		base.SetStorageValue(property, values);
	}
}
