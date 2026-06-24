using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.DTO.Managers;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 390)]
public class RazorViewsExportExtension : IConfigExportExtension
{
	private class ViewNameItem
	{
		private bool? isViewNamePrefix;

		private ICollection<string> virtualPaths;

		private string place;

		private ViewItem viewItem;

		public string ViewName { get; private set; }

		public bool IsProperty { get; set; }

		public ICollection<string> VirtualPaths => virtualPaths ?? (virtualPaths = (from p in WebApplicationDTOManager.GetFilePlaces(ViewName, IsProperty)
			select p.VirtualPath).ToArray());

		public bool ServerExists { get; private set; }

		public bool ConfigurationExists { get; private set; }

		public string Place => place ?? GetPlace(viewItem);

		private ViewNameItem(string viewName)
		{
			ViewName = viewName;
		}

		public ViewNameItem(string viewName, ViewType viewType, string name = null, bool isTab = false)
			: this(viewName)
		{
			switch (viewType)
			{
			case ViewType.Create:
				place = (isTab ? SR.T("Форма создания (дополнительная вкладка)") : SR.T("Форма создания"));
				break;
			case ViewType.Edit:
				place = (isTab ? SR.T("Форма редактирования (дополнительная вкладка)") : SR.T("Форма редактирования"));
				break;
			case ViewType.Display:
				place = (isTab ? SR.T("Форма просмотра (дополнительная вкладка)") : SR.T("Форма просмотра"));
				break;
			default:
				place = name;
				break;
			}
		}

		public ViewNameItem(string viewName, ViewItem viewItem)
			: this(viewName)
		{
			this.viewItem = viewItem;
		}

		public bool IsViewNamePrefix(string viewNamePrefix)
		{
			bool? flag = isViewNamePrefix;
			if (!flag.HasValue)
			{
				bool? flag2 = (isViewNamePrefix = ViewName.StartsWith(viewNamePrefix));
				return flag2.Value;
			}
			return flag.GetValueOrDefault();
		}

		public bool IsBad(string viewNamePrefix, List<string> viewVirtualPaths)
		{
			ServerExists = VirtualPaths.Select(WebApplicationDTOManager.GetServerPath).Any(File.Exists);
			ConfigurationExists = VirtualPaths.Select(WebApplicationDTOManager.GetConfigurationPath).Any(File.Exists);
			if (!ServerExists)
			{
				if (ConfigurationExists)
				{
					if (!IsViewNamePrefix(viewNamePrefix))
					{
						return !VirtualPaths.All((string vp) => viewVirtualPaths.Contains(vp, StringComparer.InvariantCultureIgnoreCase));
					}
					return false;
				}
				return true;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj is ViewNameItem viewNameItem && ViewName.Equals(viewNameItem.ViewName, StringComparison.InvariantCultureIgnoreCase))
			{
				return IsProperty == viewNameItem.IsProperty;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (((ViewName != null) ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(ViewName) : 0) * 397) ^ IsProperty.GetHashCode();
		}

		private string GetPlace(ViewItem viewItem)
		{
			if (!(viewItem is FormViewItem))
			{
				return ((viewItem.Parent != null) ? (GetPlace(viewItem.Parent) + " -> ") : "") + viewItem.Name;
			}
			return ((FormViewItem)viewItem).DisplayName;
		}
	}

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			RazorViewsExportConsts.ExportExtensionUid,
			new RazorViewsExportSetting()
		} };
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		RazorViewsExportSetting razorViewsExportSetting = parameters.Parameters[RazorViewsExportConsts.ExportExtensionUid] as RazorViewsExportSetting;
		List<string> viewVirtualPaths = ((razorViewsExportSetting != null && razorViewsExportSetting.ExportViews && razorViewsExportSetting.ViewVirtualPaths != null) ? razorViewsExportSetting.ViewVirtualPaths : new List<string>());
		parameters.WriteComponentFileActions.Add(delegate(IExportImportFileService filesService, string fileName)
		{
			string deployFolderName = null;
			Func<string> getDeployFolderName = () => deployFolderName ?? (deployFolderName = filesService.CreateDeployFolderName(fileName, "WebApplication"));
			List<DeployLogMessage> messages = new List<DeployLogMessage>();
			List<string> instance = (from vp in viewVirtualPaths.Union(parameters.FormExportData.SelectMany(delegate(FormExportData formExportData)
				{
					ViewNameItem[] source = (from viewName in (from f in formExportData.FormViews.EmptyIfNull()
							where f != null
							select f).SelectMany((FormView f) => new ViewNameItem[2]
						{
							f.CanUseCommonRazorView ? new ViewNameItem(f.RazorCommonViewName, f.ViewType, f.Name) : null,
							f.CanUseTabRazorView ? new ViewNameItem(f.RazorTabViewName, f.ViewType, null, isTab: true) : null
						}).Concat((from f in formExportData.FormViews.EmptyIfNull().Concat(formExportData.FormViewItems.EmptyIfNull())
							where f != null
							select f).SelectMany((FormView f) => from i in f.GetAllItems(ignoreHide: false)
							select (!(i is ICustomViewItem)) ? ((!(i is TabViewItem)) ? ((!(i is PropertyViewItem)) ? null : new ViewNameItem(((PropertyViewItem)i).CustomViewName, i)
							{
								IsProperty = true
							}) : new ViewNameItem(((TabViewItem)i).CaptionViewName, i)) : new ViewNameItem(((ICustomViewItem)i).CustomViewName, i))).Concat((from t in formExportData.FormViewItemTransformations.EmptyIfNull()
							where t.First != null && t.Second != null
							select t).SelectMany((Pair<FormViewItemTransformation, FormViewItem> t) => (from c in t.First.Items.OfType<ViewItemTransformationChange>()
							select new
							{
								ViewItem = t.Second.FindItem(c.Uid),
								Transformation = c
							} into i
							where (i.ViewItem is ICustomViewItem && i.Transformation.PropertyName == "CustomViewName") || (i.ViewItem is TabViewItem && i.Transformation.PropertyName == "CaptionViewName") || (i.ViewItem is PropertyViewItem && i.Transformation.PropertyName == "CustomViewName")
							select new ViewNameItem((string)i.Transformation.Value, i.ViewItem)
							{
								IsProperty = (i.ViewItem is PropertyViewItem)
							}).Concat(from a in t.First.Items.OfType<ViewItemTransformationAdd>()
							select t.Second.FindItem(a.Item.Uid) into item
							select (!(item is ICustomViewItem)) ? ((!(item is TabViewItem)) ? ((!(item is PropertyViewItem)) ? null : new ViewNameItem(((PropertyViewItem)item).CustomViewName, item)
							{
								IsProperty = true
							}) : new ViewNameItem(((TabViewItem)item).CaptionViewName, item)) : new ViewNameItem(((ICustomViewItem)item).CustomViewName, item))))
						where viewName != null && !string.IsNullOrWhiteSpace(viewName.ViewName)
						select viewName).ToArray();
					ViewNameItem[] source2 = source.Where((ViewNameItem i) => i.IsBad(formExportData.ViewNamePrefix, viewVirtualPaths)).ToArray();
					if (source2.Any())
					{
						messages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T("При экспорте форм сущности \"{0}\" часть представлений не выгружено, поскольку их имена не соответствуют правилам.", formExportData.EntityName), endProcess: true));
						Logger.Log.Error(SR.T("При экспорте форм сущности \"{0}\" указаны представления, имена которых не соответствуют правилам:{1}", formExportData.EntityName, string.Concat(from i in source2
							group i by i.ViewName into p
							select string.Concat("\r\n    ", p.Key, p.Select((ViewNameItem i) => !i.ServerExists && !i.ConfigurationExists).First() ? (" (" + SR.T("представление отсутствует в файловой системе") + ")") : "", ":", string.Concat(p.Select((ViewNameItem i) => "\r\n        " + i.Place))))));
					}
					return (from i in source.Distinct()
						where i.IsViewNamePrefix(formExportData.ViewNamePrefix)
						select i).SelectMany((ViewNameItem i) => i.VirtualPaths);
				}), StringComparer.InvariantCultureIgnoreCase)
				where !string.IsNullOrWhiteSpace(vp)
				select vp).ToList();
			if (messages.Count > 0)
			{
				parameters.Messages.AddRange(messages);
			}
			else
			{
				instance.Each(delegate(string vp)
				{
					string configurationPath = WebApplicationDTOManager.GetConfigurationPath(vp);
					if (configurationPath != null)
					{
						FileInfo fileInfo = new FileInfo(configurationPath);
						if (fileInfo.Exists)
						{
							string text = vp.Replace('/', '\\');
							if (text.StartsWith("~"))
							{
								text = text.Substring(1);
							}
							if (text.StartsWith("\\"))
							{
								text = text.Substring(1);
							}
							string text2 = Path.Combine(getDeployFolderName(), text);
							string directoryName = Path.GetDirectoryName(text2);
							if (!Directory.Exists(directoryName))
							{
								Directory.CreateDirectory(directoryName);
							}
							fileInfo.CopyTo(text2);
						}
					}
				});
			}
		});
	}
}
