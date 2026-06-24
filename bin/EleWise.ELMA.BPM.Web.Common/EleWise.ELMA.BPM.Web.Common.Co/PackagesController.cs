using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using NuGet;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469", "8DD067A9-9DDF-4FE7-9241-6989B59A6AEA" })]
public class PackagesController : BPMController
{
	private class DownloadResult : ActionResult
	{
		public string FileLocation { get; set; }

		public string FileName { get; set; }

		public string ContentType { get; set; }

		public override void ExecuteResult(ControllerContext context)
		{
			if (!string.IsNullOrEmpty(FileLocation))
			{
				context.get_HttpContext().Response.AddHeader("content-disposition", "attachment; filename=" + FileName);
				context.get_HttpContext().Response.ContentType = ContentType;
			}
			context.get_HttpContext().Response.TransmitFile(FileLocation);
		}
	}

	public PackageService Service { get; set; }

	[ContentItem(Name = "SR.M('Модули')", Image24 = "#modules.svg")]
	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	[PackagesAvailability]
	public ActionResult Index()
	{
		base.ActiveMenuItem = "components";
		return (ActionResult)(object)((Controller)this).View((object)CreateNewGridData());
	}

	[CustomGridAction]
	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] PackageFilter filter, [Bind(Prefix = "ActionInfo")] PackagesActionInfo actionsInfo)
	{
		PackagesGridData packagesGridData = CreateGridData(command, filter, actionsInfo);
		return (ActionResult)(object)((Controller)this).PartialView((object)packagesGridData);
	}

	[HttpPost]
	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult PerformActions([Bind(Prefix = "ActionInfo")] PackagesActionInfo actionsInfo)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		if (actionsInfo != null)
		{
			string[] source = ((actionsInfo.PackagesToInstall != null) ? actionsInfo.PackagesToInstall.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) : new string[0]);
			string[] source2 = ((actionsInfo.PackagesToUpdate != null) ? actionsInfo.PackagesToUpdate.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) : new string[0]);
			string[] source3 = ((actionsInfo.PackagesToDelete != null) ? actionsInfo.PackagesToDelete.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) : new string[0]);
			List<PackageOperationInfo> list = new List<PackageOperationInfo>();
			list.AddRange(source.Select((string id) => new PackageOperationInfo
			{
				Package = new PackageInfo(id),
				Type = PackageOperationType.Install
			}));
			list.AddRange(source2.Select((string id) => new PackageOperationInfo
			{
				Package = new PackageInfo(id),
				Type = PackageOperationType.Update
			}));
			list.AddRange(source3.Select((string id) => new PackageOperationInfo
			{
				Package = new PackageInfo(id),
				Type = PackageOperationType.Uninstall
			}));
			Service.ExecuteOperations(list.ToArray(), new PackageOperationOptions
			{
				UpdatingUid = actionsInfo.UpdatingUid
			});
		}
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
	public ActionResult InstallAllUpdates(Guid updatingUid)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Service.InstallAllUpdates(updatingUid);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult DesignerInstaller()
	{
		string applicationBaseUrl = Locator.GetServiceNotNull<CommonSettingsModule>().Settings.ApplicationBaseUrl;
		Uri uri = ((!string.IsNullOrEmpty(applicationBaseUrl)) ? new Uri(applicationBaseUrl, UriKind.RelativeOrAbsolute) : ((Controller)this).get_Request().Url);
		string text = ((Controller)this).get_Server().MapPath("~/App_Data/DesignerInstaller");
		int hashCode = uri.OriginalString.GetHashCode();
		string path = Service.GetDesignerInstallerFileName().Replace("-Installer-", "-Designer-");
		string text2 = Path.Combine(text, Path.ChangeExtension(path, "." + hashCode + ".exe"));
		if (!System.IO.File.Exists(text2))
		{
			Path.GetDirectoryName(text2);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text3 = text2 + ".tmp";
			if (System.IO.File.Exists(text3))
			{
				System.IO.File.Delete(text3);
			}
			using (Stream stream = Service.GetDesignerInstallerStream())
			{
				using FileStream destination = System.IO.File.OpenWrite(text3);
				stream.CopyTo(destination);
			}
			UriBuilder uriBuilder = new UriBuilder(uri.AbsoluteUri);
			uriBuilder.Path = "PackageServer";
			UriBuilder uriBuilder2 = new UriBuilder(uri.AbsoluteUri);
			uriBuilder2.Path = "";
			Service.WriteDesignerInstallerData(text3, new DesignerInstallerData
			{
				InstallationName = uri.Host,
				PackageManagerRepository = uriBuilder.Uri.AbsoluteUri,
				RemoteUrl = uriBuilder2.Uri.AbsoluteUri
			});
			if (System.IO.File.Exists(text2))
			{
				System.IO.File.Delete(text2);
			}
			System.IO.File.Move(text3, text2);
		}
		return (ActionResult)(object)new DownloadResult
		{
			FileLocation = text2,
			FileName = Path.ChangeExtension(path, "(" + uri.Host + ").exe"),
			ContentType = "application/x-msdownload"
		};
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id;size;useParent", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult Icon(string id, string version)
	{
		return (ActionResult)(object)GetImageResult(Service.GetPackageIconFileName(id, version) ?? ((Controller)this).get_Server().MapPath(((Controller)this).get_Url().Image("x16/blank.png")));
	}

	public ActionResult PackageInfo(string id, string version)
	{
		IPackage package = Service.GetPackage(id, version);
		return (ActionResult)(object)((Controller)this).PartialView((object)package);
	}

	private static FileStreamResult GetImageResult(string fileName)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		string text;
		switch (Path.GetExtension(fileName).ToLower())
		{
		case ".png":
			text = "image/png";
			break;
		case ".gif":
			text = "image/gif";
			break;
		case ".jpg":
		case ".jpeg":
			text = "image/jpeg";
			break;
		default:
			throw new InvalidOperationException("Unsupported image extension: " + Path.GetExtension(fileName));
		}
		return new FileStreamResult((Stream)System.IO.File.OpenRead(fileName), text);
	}

	private PackagesGridData CreateNewGridData()
	{
		return new PackagesGridData
		{
			ActionInfo = new PackagesActionInfo
			{
				UpdatingUid = Guid.NewGuid()
			},
			HasUpdates = (Service.Count(new PackageFilter
			{
				Level = PackageLevel.All,
				Status = PackageStatus.InstalledHasUpdate
			}) > 0)
		};
	}

	private PackagesGridData CreateGridData(GridCommand command, PackageFilter filter, PackagesActionInfo actionsInfo)
	{
		if (actionsInfo == null)
		{
			actionsInfo = new PackagesActionInfo();
		}
		PackagesGridData packagesGridData = new PackagesGridData();
		packagesGridData.Command = command;
		packagesGridData.ActionInfo = actionsInfo;
		packagesGridData.SetCount((GridData<PackageDescription> d, FetchOptions f) => Service.Count(filter));
		packagesGridData.SetDataSource((GridData<PackageDescription> d, FetchOptions f) => Service.Find(filter, f));
		return packagesGridData;
	}
}
