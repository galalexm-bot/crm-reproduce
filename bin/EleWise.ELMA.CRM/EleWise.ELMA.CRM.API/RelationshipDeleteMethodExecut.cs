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

public abstract class RelationshipDeleteMethodExecutor<T> : PublicServiceMethodExecutor where T : class, IRelationship
{
	private static class Names
	{
		public const string EntityId = "EntityId";
	}

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EntityId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор взаимоотношения")).Type(typeof(long));
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public RelationshipDeleteMethodExecutor(WebData parameters)
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
		DoDeleteAction(result);
		return GetResult();
	}

	private static void DoDeleteAction(long entityId)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		T val = EntityManager<T>.Instance.Load(entityId);
		if (!serviceNotNull.HasPermission(CRMPermissionProvider.EditRelationshipPermission, val))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет прав на редактирование взаимоотношения"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			RelationshipManager.Instance.DeleteRelationship(val, out var _);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}
