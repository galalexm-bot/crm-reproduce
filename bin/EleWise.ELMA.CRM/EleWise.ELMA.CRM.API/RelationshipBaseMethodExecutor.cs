using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.CRM.API;

public abstract class RelationshipBaseMethodExecutor<T> : PublicServiceMethodExecutor where T : class, IRelationship
{
	private static class Names
	{
		public const string EntityId = "EntityId";

		public const string Comment = "Comment";
	}

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EntityId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор взаимоотношения")).Type(typeof(long));
	}).ItemWithDescriptor("Comment", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Комментарий")).Type(typeof(string)).Optional();
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public RelationshipBaseMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	protected virtual WebData GetResult()
	{
		return WebData.CreateFromObject(new
		{
			Result = true
		});
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("EntityId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор взаимоотношения"));
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора взаимоотношения, должен быть Int64"));
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Comment");
		string comment = ((webDataItem2 != null) ? webDataItem2.Value : "");
		DoCompleteAction(result, comment);
		return GetResult();
	}

	private static void DoCompleteAction(long entityId, string comment)
	{
		if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.ExecuteRelationshipPermission, EntityManager<T>.Instance.Load(entityId)))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет прав на выполнение взаимоотношения"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			RelationshipManager.Instance.Complete(entityId, comment);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}
