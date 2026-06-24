using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public class CustomizableFormsViewEngine : WebFormViewEngine
{
	private CustomizableViewEngineHelper helper;

	public List<string> Master
	{
		get
		{
			return helper.Master;
		}
		set
		{
			helper.Master = value;
		}
	}

	public List<string> AreaMaster
	{
		get
		{
			return helper.AreaMaster;
		}
		set
		{
			helper.AreaMaster = value;
		}
	}

	public List<string> View
	{
		get
		{
			return helper.View;
		}
		set
		{
			helper.View = value;
		}
	}

	public List<string> AreaView
	{
		get
		{
			return helper.AreaView;
		}
		set
		{
			helper.AreaView = value;
		}
	}

	public CustomizableFormsViewEngine(string applicationPath)
		: this(applicationPath, "Custom")
	{
	}

	public CustomizableFormsViewEngine(string applicationPath, string customDirectoryName)
	{
		helper = new CustomizableViewEngineHelper(applicationPath, customDirectoryName);
	}

	public void ApplyRoutes()
	{
		helper.ApplyRoutes();
		((VirtualPathProviderViewEngine)this).set_MasterLocationFormats(Master.ToArray());
		((VirtualPathProviderViewEngine)this).set_AreaMasterLocationFormats(AreaMaster.ToArray());
		((VirtualPathProviderViewEngine)this).set_ViewLocationFormats(View.ToArray());
		((VirtualPathProviderViewEngine)this).set_PartialViewLocationFormats(((VirtualPathProviderViewEngine)this).get_ViewLocationFormats());
		((VirtualPathProviderViewEngine)this).set_AreaViewLocationFormats(AreaView.ToArray());
		((VirtualPathProviderViewEngine)this).set_AreaPartialViewLocationFormats(((VirtualPathProviderViewEngine)this).get_AreaViewLocationFormats());
	}

	protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
	{
		return ((VirtualPathProviderViewEngine)this).get_VirtualPathProvider().FileExists(virtualPath);
	}
}
