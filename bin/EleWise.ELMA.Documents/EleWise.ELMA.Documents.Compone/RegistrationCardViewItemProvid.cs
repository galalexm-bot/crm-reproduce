using System;
using System.Linq;
using EleWise.ELMA.Documents.Web.Components;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Components;

[Obsolete("Провайдер устарел и больше не используется")]
public class RegistrationCardViewItemProvider : DocumentObjectViewItemProvider
{
	public new static readonly Guid UID = new Guid("{C7E87AA0-7169-4178-8FF5-5499EB7DF249}");

	public override Guid ProviderUid => UID;

	public static string CreateViewItemId(IEntity entity, Guid actionGuid)
	{
		if (entity == null)
		{
			return null;
		}
		return string.Join(";", actionGuid, InterfaceActivator.UID(EntityHelper.GetType(entity)), entity.GetId());
	}

	public override ViewItem GetViewItem(string viewItemId)
	{
		if (string.IsNullOrEmpty(viewItemId))
		{
			return null;
		}
		string[] array = viewItemId.Split(new string[1] { ";" }, StringSplitOptions.None);
		if (array.Length < 2)
		{
			return null;
		}
		Guid guid = new Guid(array[0]);
		Guid uid = new Guid(array[1]);
		Guid result;
		return GetViewItem(base.MetadataRuntimeService.GetTypeByUid(uid), Guid.TryParse(array.Last(), out result) ? result : guid, (ClassMetadata metadata, FormViewItem form) => DocumentObjectViewItemProvider.TransformateStatic(metadata, form, ViewType.Custom, ItemType.Default));
	}

	public static FormViewItem GetViewItem(Type entityType, Guid actionGuid)
	{
		return EntityObjectViewItemProvider.GetViewItem(entityType, actionGuid, ItemType.Default, (ClassMetadata metadata, FormViewItem form) => DocumentObjectViewItemProvider.TransformateStatic(metadata, form, ViewType.Custom, ItemType.Default)) as FormViewItem;
	}

	private static FormViewItem GetViewItem(Type entityType, Guid actionGuid, Func<ClassMetadata, FormViewItem, FormViewItem> transformate)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
		FormViewItem arg = classMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == actionGuid);
		return transformate(classMetadata, arg);
	}
}
