using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Models.Toolbar;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class ToolbarController : BPMController
{
	public static string SR_CustomizeToolbar => SR.T("Панель инструментов");

	public ContentActionRegistry ContentActionRegistry { get; set; }

	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		return (ActionResult)(object)((Controller)this).PartialView("Grid", (object)WebToolbarManager.Instance.CreateGridData(command));
	}

	public ActionResult Delete(IWebToolbar toolbar)
	{
		WebToolbarManager.Instance.Delete(toolbar);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			delete = true
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	public ActionResult Buttons()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Portal", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		});
	}

	[HttpPost]
	public ActionResult Buttons(string virtualPath, string data, bool enableEdit = false, bool createCopy = false)
	{
		if (!WorkPlaceExtensions.CustomizerEnabled)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Portal", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content"
			});
		}
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(data);
		if (toolbarTreeItem == null)
		{
			base.Notifier.Error(SR.T("Нет информации о настраиваемой панели инструментов. Перейдите на нужную страницу и нажмите на кнопку «{0}»", SR_CustomizeToolbar));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Portal", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content"
			});
		}
		ToolbarTreeItem toolbarTreeItem2 = toolbarTreeItem;
		ToolbarTreeItemTransformation toolbarTransformation = WorkPlaceExtensions.GetToolbarTransformation(virtualPath, toolbarTreeItem.Uid);
		if (toolbarTransformation != null)
		{
			toolbarTreeItem2 = CloneHelperBuilder.Create(toolbarTreeItem2).Restrictions(delegate(RestrictionsBuilder<ToolbarTreeItem> r)
			{
				r.Rule().ForPropertyName((ToolbarTreeItem i) => i.Items).Clone();
			}).Clone();
			toolbarTransformation.Apply(toolbarTreeItem2);
		}
		IWorkPlace currentWorkPlace = WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true);
		if (createCopy && currentWorkPlace.Toolbar != null)
		{
			currentWorkPlace.Toolbar = CloneHelperBuilder.Create(currentWorkPlace.Toolbar).Clone();
			currentWorkPlace.Toolbar.Name = SR.T("Toolbar ({0})", currentWorkPlace.Name);
			currentWorkPlace.Save();
		}
		IWebToolbar toolbar = currentWorkPlace.Toolbar;
		WorkPlaceManager instance = WorkPlaceManager.Instance;
		InstanceOf<IWorkPlaceFilter> instanceOf = new InstanceOf<IWorkPlaceFilter>();
		instanceOf.New.Toolbar = toolbar;
		instanceOf.New.Query = ((toolbar == null) ? "Toolbar is null" : null);
		IWorkPlace[] array = instance.Find(instanceOf.New, null).ToArray();
		bool readOnly = !enableEdit && currentWorkPlace.Toolbar != null && array.Length > 1;
		ToolbarTreeModel toolbarTreeModel = new ToolbarTreeModel
		{
			Id = toolbarTreeItem.Uid,
			Children = BuildTreeNodes(toolbarTreeItem2, isChangeable: true, readOnly),
			ShowExpandCollapseButtons = true,
			Root = toolbarTreeItem,
			ChangedRoot = toolbarTreeItem2,
			VirtualPath = virtualPath,
			UrlReferrer = ((((Controller)this).get_Request().UrlReferrer != null) ? ((Controller)this).get_Request().UrlReferrer.PathAndQuery : "/"),
			Toolbar = toolbar,
			ReadOnly = readOnly,
			WorkPlace = currentWorkPlace,
			WorkPlaces = array
		};
		return (ActionResult)(object)((Controller)this).View((object)toolbarTreeModel);
	}

	private List<TreeMenuNode> BuildTreeNodes(ToolbarTreeItem toolbarItem, bool isChangeable, bool readOnly)
	{
		if (toolbarItem.Items == null)
		{
			return new List<TreeMenuNode>();
		}
		return ((IEnumerable<ToolbarTreeItem>)toolbarItem.Items).Select((Func<ToolbarTreeItem, TreeMenuNode>)delegate(ToolbarTreeItem item)
		{
			bool flag = item.Uid == "MoreButtonToolbarGroup" || item.Uid == "more_btn";
			TreeToolbarNode treeToolbarNode = new TreeToolbarNode
			{
				id = item.Uid,
				text = ((item.TypeUid == ActionItemTypeToolbarGroup.Guid) ? SR.T("Группа") : ((item.TypeUid == ActionItemTypeToolbarItemSeparator.Guid) ? SR.T("Разделитель") : item.Text)),
				ReadOnly = (readOnly || flag),
				Visible = item.Visible,
				PosibleHidden = item.PosibleHidden,
				IsChangeable = (isChangeable && item.IsUidSet && !flag),
				IsGroup = (item.TypeUid == ActionItemTypeToolbarGroup.Guid),
				IsFirstLevel = (toolbarItem.TypeUid == ActionItemTypeToolbarGroup.Guid),
				ActionTypeProviderId = item.ActionTypeProviderId,
				ActionId = item.ActionId,
				icon = item.IconUrl,
				expanded = true,
				children = BuildTreeNodes(item, isChangeable && item.IsUidSet, readOnly),
				HtmlAttributes = new Dictionary<string, object> { 
				{
					"isGroup",
					(item.TypeUid == ActionItemTypeToolbarGroup.Guid) ? 1 : 0
				} }
			};
			if (!treeToolbarNode.IsChangeable)
			{
				treeToolbarNode.HtmlClass = new List<string> { "not-changeable" };
				if (flag)
				{
					treeToolbarNode.HtmlClass.Add("readonly-item");
				}
			}
			return treeToolbarNode;
		}).ToList();
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Save(string data_Root, string data_ChangedRoot, string data_VirtualPath, string data_UrlReferrer, long data_Toolbar, long data_WorkPlace)
	{
		ToolbarTreeItem originalItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(data_Root);
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(data_ChangedRoot);
		ToolbarTreeItemTransformation transformation = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.CreateTransformation(toolbarTreeItem, originalItem);
		IWebToolbar webToolbar = ((data_Toolbar > 0) ? WebToolbarManager.Instance.LoadOrNull(data_Toolbar) : null);
		if (webToolbar == null)
		{
			IWorkPlace workPlace = WorkPlaceManager.Instance.Load(data_WorkPlace);
			webToolbar = workPlace.Toolbar;
			if (webToolbar == null)
			{
				InstanceOf<IWebToolbar> instanceOf = new InstanceOf<IWebToolbar>();
				instanceOf.New.Name = SR.T("Toolbar ({0})", workPlace.Name);
				webToolbar = instanceOf.New;
				webToolbar.Save();
				workPlace.Toolbar = webToolbar;
				workPlace.Save();
			}
		}
		WorkPlaceExtensions.SetToolbarTransformation(webToolbar, data_VirtualPath, toolbarTreeItem.Uid, transformation);
		base.Notifier.Information(SR.T("Настройка для toolbar-а успешно сохранена для данной страницы."));
		return (ActionResult)(object)((Controller)this).Redirect(data_UrlReferrer);
	}

	public ActionResult CreateItem(string parentId)
	{
		ToolbarItemModel toolbarItemModel = new ToolbarItemModel
		{
			IsNew = true,
			ParentId = parentId,
			ToolbarItem = new ToolbarTreeItem
			{
				Uid = Guid.NewGuid().ToString()
			}
		};
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)toolbarItemModel);
	}

	public ActionResult EditItem(string id, string changedRoot)
	{
		ToolbarTreeItem viewItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(changedRoot);
		ToolbarTreeItem toolbarTreeItem = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(viewItem, id);
		ToolbarItemModel toolbarItemModel = new ToolbarItemModel(toolbarTreeItem ?? new ToolbarTreeItem
		{
			Uid = Guid.NewGuid().ToString()
		}, ContentActionRegistry, toolbarTreeItem?.ActionTypeProviderId, toolbarTreeItem?.ActionId)
		{
			IsNew = (toolbarTreeItem == null)
		};
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)toolbarItemModel);
	}

	private void CreateGroup(ToolbarTreeItem root)
	{
		root.Items.Add(new ToolbarTreeItem
		{
			Uid = Guid.NewGuid().ToString(),
			TypeUid = ActionItemTypeToolbarGroup.Guid
		});
	}

	public ActionResult SaveButton(ToolbarItemModel model, string changedRoot)
	{
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(changedRoot);
		ToolbarTreeItem toolbarTreeItem2 = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(toolbarTreeItem, model.ToolbarItem.Uid);
		if (toolbarTreeItem2 == null)
		{
			ToolbarTreeItem toolbarTreeItem3 = (string.IsNullOrWhiteSpace(model.ParentId) ? null : Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(toolbarTreeItem, model.ParentId));
			if (toolbarTreeItem3 == null)
			{
				toolbarTreeItem.Items = toolbarTreeItem.Items ?? new List<ToolbarTreeItem>();
				if (toolbarTreeItem.Items.Count == 0)
				{
					CreateGroup(toolbarTreeItem);
				}
				toolbarTreeItem3 = toolbarTreeItem.Items.Last();
			}
			toolbarTreeItem3.Items = toolbarTreeItem3.Items ?? new List<ToolbarTreeItem>();
			toolbarTreeItem3.Items.Add(toolbarTreeItem2 = model.ToolbarItem);
			toolbarTreeItem2.TypeUid = ActionItemTypeToolbarItem.Guid;
		}
		else
		{
			toolbarTreeItem2.Text = model.ToolbarItem.Text;
			toolbarTreeItem2.ToolTip = model.ToolbarItem.ToolTip;
			toolbarTreeItem2.ToolTipHeader = model.ToolbarItem.ToolTipHeader;
			toolbarTreeItem2.IconUrl = model.ToolbarItem.IconUrl;
		}
		toolbarTreeItem2.ActionTypeProviderId = model.Link.ActionTypeProviderId;
		toolbarTreeItem2.ActionId = model.Link.ActionId;
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Элемент сохранен"),
			tree = new ToolbarTreeModel
			{
				Id = toolbarTreeItem.Uid,
				Children = BuildTreeNodes(toolbarTreeItem, isChangeable: true, readOnly: false)
			}.ToTreeViewItemList(),
			changedRoot = ClassSerializationHelper.SerializeObjectByJson(toolbarTreeItem)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult CreateGroup(string changedRoot)
	{
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(changedRoot);
		toolbarTreeItem.Items = toolbarTreeItem.Items ?? new List<ToolbarTreeItem>();
		CreateGroup(toolbarTreeItem);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Группа добавлена"),
			tree = new ToolbarTreeModel
			{
				Id = toolbarTreeItem.Uid,
				Children = BuildTreeNodes(toolbarTreeItem, isChangeable: true, readOnly: false)
			}.ToTreeViewItemList(),
			changedRoot = ClassSerializationHelper.SerializeObjectByJson(toolbarTreeItem)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult NodeDrop(string target, string destination, string position, string changedRoot)
	{
		if (string.IsNullOrEmpty(position))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Неизвестное действие")
			}, (JsonRequestBehavior)0);
		}
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(changedRoot);
		ToolbarTreeItem container;
		ToolbarTreeItem toolbarTreeItem2 = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(toolbarTreeItem, target, out container);
		if (toolbarTreeItem2 == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не найдены элементы toolbar-а target" + target)
			}, (JsonRequestBehavior)0);
		}
		ToolbarTreeItem container2;
		ToolbarTreeItem toolbarTreeItem3 = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(toolbarTreeItem, destination, out container2);
		if (toolbarTreeItem3 == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не найдены элементы toolbar-а destinationNode")
			}, (JsonRequestBehavior)0);
		}
		switch (position)
		{
		case "over":
			container.Items.Remove(toolbarTreeItem2);
			toolbarTreeItem3.Items = toolbarTreeItem3.Items ?? new List<ToolbarTreeItem>();
			toolbarTreeItem3.Items.Add(toolbarTreeItem2);
			break;
		case "before":
		{
			container.Items.Remove(toolbarTreeItem2);
			int num = container2.Items.IndexOf(toolbarTreeItem3);
			container2.Items.Insert(num, toolbarTreeItem2);
			break;
		}
		case "after":
		{
			container.Items.Remove(toolbarTreeItem2);
			int num = container2.Items.IndexOf(toolbarTreeItem3);
			container2.Items.Insert(num + 1, toolbarTreeItem2);
			break;
		}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Элемент перемещен"),
			tree = new ToolbarTreeModel
			{
				Id = toolbarTreeItem.Uid,
				Children = BuildTreeNodes(toolbarTreeItem, isChangeable: true, readOnly: false)
			}.ToTreeViewItemList(),
			changedRoot = ClassSerializationHelper.SerializeObjectByJson(toolbarTreeItem)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult HideItem(string id, string root, string changedRoot)
	{
		ToolbarTreeItem viewItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(root);
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(changedRoot);
		ToolbarTreeItem container;
		ToolbarTreeItem toolbarTreeItem2 = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(toolbarTreeItem, id, out container);
		if (toolbarTreeItem2 == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не найден элемент toolbar-а " + id)
			}, (JsonRequestBehavior)0);
		}
		if (Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(viewItem, id) != null)
		{
			toolbarTreeItem2.Visible = false;
		}
		else
		{
			container.Items.Remove(toolbarTreeItem2);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Элемент удален"),
			tree = new ToolbarTreeModel
			{
				Id = toolbarTreeItem.Uid,
				Children = BuildTreeNodes(toolbarTreeItem, isChangeable: true, readOnly: false)
			}.ToTreeViewItemList(),
			changedRoot = ClassSerializationHelper.SerializeObjectByJson(toolbarTreeItem)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult UnhideItem(string id, string changedRoot)
	{
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(changedRoot);
		ToolbarTreeItem toolbarTreeItem2 = Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, string>.Instance.FindItem(toolbarTreeItem, id);
		if (toolbarTreeItem2 == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не найден элемент toolbar-а " + id)
			}, (JsonRequestBehavior)0);
		}
		toolbarTreeItem2.Visible = true;
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Элемент возращен"),
			tree = new ToolbarTreeModel
			{
				Id = toolbarTreeItem.Uid,
				Children = BuildTreeNodes(toolbarTreeItem, isChangeable: true, readOnly: false)
			}.ToTreeViewItemList(),
			changedRoot = ClassSerializationHelper.SerializeObjectByJson(toolbarTreeItem)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult Reset(string root)
	{
		ToolbarTreeItem toolbarTreeItem = ClassSerializationHelper.DeserializeObjectByJson<ToolbarTreeItem>(root);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Изменения сброшены"),
			tree = new ToolbarTreeModel
			{
				Id = toolbarTreeItem.Uid,
				Children = BuildTreeNodes(toolbarTreeItem, isChangeable: true, readOnly: false)
			}.ToTreeViewItemList(),
			changedRoot = ClassSerializationHelper.SerializeObjectByJson(toolbarTreeItem)
		}, (JsonRequestBehavior)0);
	}
}
