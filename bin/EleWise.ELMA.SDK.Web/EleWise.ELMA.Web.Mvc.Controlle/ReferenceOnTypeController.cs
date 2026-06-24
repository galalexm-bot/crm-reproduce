using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[Themed]
public class ReferenceOnTypeController : BaseController
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public JsonResult Select(string text, Guid? filterUid = null)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		try
		{
			IEnumerable<ReferenceOnTypeAutocompleteModel> data = (from t in MetadataRuntimeService.GetTypeDescriptors()
				where t.Visible && t.ParentUid == Guid.Empty
				select t into desc
				orderby desc.Name
				select desc).SelectMany((ITypeDescriptor descriptor) => TypeDescriptorItems(descriptor, text, 0L, useForEntity: false, Enumerable.Empty<IInput>()));
			JsonResult val = new JsonResult();
			val.set_Data((object)data);
			return val;
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			string message = ex.Message;
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				error = message
			});
			return val2;
		}
	}

	public JsonResult SelectReferencesWithInputs(string text, Guid? filterUid = null)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		try
		{
			HtmlHelper htmlHelper = GetHtmlHelper();
			IEnumerable<IInput> inputs = ModelExtensions.GetInputExtensions(htmlHelper);
			IEnumerable<ReferenceOnTypeAutocompleteModel> data = (from t in MetadataRuntimeService.GetTypeDescriptors()
				where t.Visible && t.ParentUid == Guid.Empty
				select t into desc
				orderby desc.Name
				select desc).SelectMany((ITypeDescriptor descriptor) => TypeDescriptorItems(descriptor, text, 0L, useForEntity: true, inputs));
			JsonResult val = new JsonResult();
			val.set_Data((object)data);
			return val;
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			string message = ex.Message;
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				error = message
			});
			return val2;
		}
	}

	private bool CanShow(ITypeDescriptor descriptor)
	{
		if (!descriptor.IsCLRTypeDescriptor())
		{
			return true;
		}
		return (descriptor as IRuntimeTypeDescriptor)?.IsRuntimeType ?? false;
	}

	private IEnumerable<ReferenceOnTypeAutocompleteModel> TypeDescriptorItems(ITypeDescriptor descriptor, string text, long level, bool useForEntity, IEnumerable<IInput> inputs)
	{
		if (!CanShow(descriptor))
		{
			return Enumerable.Empty<ReferenceOnTypeAutocompleteModel>();
		}
		List<ReferenceOnTypeAutocompleteModel> list = new List<ReferenceOnTypeAutocompleteModel>();
		if (descriptor != null && descriptor.Name != null)
		{
			if (!string.IsNullOrWhiteSpace(text) && !descriptor.IsGroup)
			{
				if (useForEntity && (!descriptor.UseForEntity || !inputs.Any((IInput a) => a.TypeUid == descriptor.Uid)))
				{
					return list;
				}
				string name = descriptor.Name;
				if (name != null && name.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					list.Add(SetAutocompleteData(descriptor, ((Controller)this).get_Url(), level));
				}
			}
			else
			{
				if (!descriptor.IsGroup && useForEntity && (!descriptor.UseForEntity || !inputs.Any((IInput a) => a.TypeUid == descriptor.Uid)))
				{
					return list;
				}
				list.Add(SetAutocompleteData(descriptor, ((Controller)this).get_Url(), level));
			}
			IEnumerable<ITypeDescriptor> subTypes = descriptor.GetSubTypes(null);
			level++;
			if (subTypes != null)
			{
				ITypeDescriptor[] array = (from desc in subTypes
					where desc.IsGroup
					orderby desc.Name
					select desc).ToArray();
				foreach (ITypeDescriptor descriptor2 in array)
				{
					IEnumerable<ReferenceOnTypeAutocompleteModel> enumerable = TypeDescriptorItems(descriptor2, text, level, useForEntity, inputs);
					if (enumerable.Any((ReferenceOnTypeAutocompleteModel r) => !r.VirtualItem))
					{
						list.AddRange(enumerable);
					}
				}
				array = (from desc in subTypes
					where !desc.IsGroup
					select desc into item
					orderby item.Name
					select item).ToArray();
				foreach (ITypeDescriptor descriptor3 in array)
				{
					IEnumerable<ReferenceOnTypeAutocompleteModel> enumerable2 = TypeDescriptorItems(descriptor3, text, level, useForEntity, inputs);
					if (enumerable2.Any((ReferenceOnTypeAutocompleteModel r) => !r.VirtualItem))
					{
						list.AddRange(enumerable2);
					}
				}
			}
		}
		return list;
	}

	private ReferenceOnTypeAutocompleteModel SetAutocompleteData(ITypeDescriptor descriptor, UrlHelper url, long level)
	{
		string name = descriptor.Name;
		bool virtualItem = descriptor.IsGroup || descriptor.ParentUid == Guid.Empty;
		return new ReferenceOnTypeAutocompleteModel
		{
			EntityUrl = url.Action("TypeDescriptor", "ServiceHelp", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				typeUid = descriptor.Uid,
				subTypeUid = descriptor.SubTypeUid
			}),
			Value = descriptor.GetTypeAndSubTypeWithDelimeterString(),
			Text = name,
			ViewText = name,
			VirtualItem = virtualItem,
			Parent = ((descriptor.ParentUid != Guid.Empty) ? descriptor.ParentUid.ToString() : null),
			Level = level
		};
	}
}
