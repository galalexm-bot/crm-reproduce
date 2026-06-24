using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Components;
using EleWise.ELMA.Content.ExtensionPoints;
using EleWise.ELMA.Content.Helpers;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(Order = int.MaxValue)]
public class WorkPlaceViewEngineOtherVirtualPaths : IViewEngineOtherVirtualPaths
{
	private WorkPlaceVirtualPathProvider workPlaceVirtualPathProvider;

	public WorkPlaceViewEngineOtherVirtualPaths(WorkPlaceVirtualPathProvider workPlaceVirtualPathProvider)
	{
		this.workPlaceVirtualPathProvider = workPlaceVirtualPathProvider;
	}

	public string OtherExistsVirtualPath(ControllerContext controllerContext, IEnumerable<string> virtualPaths)
	{
		WorkPlaceTypeService.FakeController fakeController = controllerContext.get_Controller() as WorkPlaceTypeService.FakeController;
		IWorkPlace workPlace = null;
		IWorkPlaceType workPlaceType;
		if (fakeController != null)
		{
			workPlaceType = WorkPlaceManager.Instance.GetWorkPlaceType(fakeController.WorkPlaceTypeUid);
		}
		else
		{
			workPlace = WorkPlaceExtensions.GetCurrentWorkPlace();
			workPlaceType = workPlace.GetWorkPlaceType();
		}
		if (workPlace == null && (workPlaceType == null || workPlaceType.Uid == StandardWorkPlaceType.Uid))
		{
			return null;
		}
		string[] array = virtualPaths.Where((string p) => !string.IsNullOrEmpty(p) && (p.StartsWith("~") || p.StartsWith("/"))).ToArray();
		if (fakeController != null && array.Length != 1)
		{
			return null;
		}
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (workPlaceType == null || workPlaceType.Uid != StandardWorkPlaceType.Uid)
			{
				string text2;
				if (workPlace != null)
				{
					text2 = text.Insert(text.StartsWith("~") ? 1 : 0, string.Format("/{0}/{1}/{2}/{3}", "WorkPlaces", workPlace.Id, "WorkPlaceTypes", workPlaceType.Folder));
					if (workPlaceVirtualPathProvider.FileExists(text2))
					{
						return text2;
					}
				}
				text2 = text.Insert(text.StartsWith("~") ? 1 : 0, string.Format("/{0}/{1}", "WorkPlaceTypes", workPlaceType.Folder));
				if (fakeController != null || workPlaceVirtualPathProvider.FileExists(text2))
				{
					return text2;
				}
			}
			if (workPlace != null)
			{
				string text2 = text.Insert(text.StartsWith("~") ? 1 : 0, string.Format("/{0}/{1}", "WorkPlaces", workPlace.Id));
				if (workPlaceVirtualPathProvider.FileExists(text2))
				{
					return text2;
				}
			}
		}
		return null;
	}
}
