using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html.Grids;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentPermissionsReplacementTaskGridPropertySettings : IReplacementTaskGridPropertySettings
{
	public void RenderColumns<T>(DynamicColumnsBuilder<T> columnsBuilder, IReplacementTask replacementTask) where T : class, IEntity
	{
		IReplacementTaskDocumentPermission replacement = replacementTask.Replacement as IReplacementTaskDocumentPermission;
		if (replacement == null || (!replacement.TaskDocumentsPermissions && !replacement.TaskDocumentsManagePermissions))
		{
			return;
		}
		HtmlHelper html = null;
		(InterfaceActivator.LoadMetadata<T>() as EntityMetadata).GetTitleProperty();
		_ = (EntityMetadata)InterfaceActivator.LoadMetadata<IReplacementTaskDocumentPermission>();
		Action<Expression<Func<IReplacementTaskDocumentPermission, object>>, int> action = delegate(Expression<Func<IReplacementTaskDocumentPermission, object>> expression, int index)
		{
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(expression);
			Guid propertyUid = propertyMetadata.Uid;
			string displayName = propertyMetadata.DisplayName;
			bool permission = (bool)replacement.GetPropertyValue(propertyUid);
			if (permission)
			{
				DynamicColumnBuilder<T, T> dynamicColumnBuilder = columnsBuilder.Insert(0, (Expression<Func<T, T>>)((T m) => null), (Func<bool>)null, (Func<int>)(() => index));
				html = (HtmlHelper)(((object)html) ?? ((object)(HtmlHelper)typeof(DynamicColumnBuilderBase).GetField("html", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).GetValue(dynamicColumnBuilder)));
				HtmlHelper html2 = html;
				dynamicColumnBuilder.Uid(propertyMetadata.Name).Header(displayName).Template(delegate(T m)
				{
					//IL_007e: Unknown result type (might be due to invalid IL or missing references)
					//IL_0084: Expected O, but got Unknown
					//IL_0085: Unknown result type (might be due to invalid IL or missing references)
					//IL_008b: Expected O, but got Unknown
					if (!bool.TryParse(replacementTask.GetAssignmentValue(new ReferenceOnEntity
					{
						Object = m
					}, propertyUid, (ReferenceOnEntity e, Guid p) => permission.ToString()), out var result))
					{
						result = permission;
					}
					HtmlHelper obj = html2;
					DocumentPermissionsReplacementTaskEditModel documentPermissionsReplacementTaskEditModel = new DocumentPermissionsReplacementTaskEditModel(propertyUid, replacementTask, m, result);
					ViewDataDictionary val = new ViewDataDictionary();
					TemplateInfo val2 = new TemplateInfo();
					val2.set_HtmlFieldPrefix(html2.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(string.Concat("grid.", propertyUid, ".", m.GetId())));
					val.set_TemplateInfo(val2);
					return PartialExtensions.Partial(obj, "Replacement/DocumentPermissionsReplacementTask", (object)documentPermissionsReplacementTaskEditModel, val);
				})
					.Sortable(sortable: false)
					.Width(50)
					.Required(required: true);
			}
		};
		action((IReplacementTaskDocumentPermission m) => m.TaskDocumentsPermissions, 2147483646);
		action((IReplacementTaskDocumentPermission m) => m.TaskDocumentsManagePermissions, int.MaxValue);
	}
}
