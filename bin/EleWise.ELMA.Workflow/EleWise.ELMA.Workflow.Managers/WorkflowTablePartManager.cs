using System;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowTablePartManager<T> : WorkflowBaseManager<T>, ITablePartManager, IEntityManager where T : WorkflowTablePartEntity
{
	internal static object UAyKNK9ixbs67ftj6tb;

	public override void Save(T obj)
	{
		Entity<long> entity = null;
		foreach (Entity<long> compositeEntity in obj.GetCompositeEntities())
		{
			if (entity == null)
			{
				entity = compositeEntity;
			}
			else if (compositeEntity.Id <= 0 && entity != null)
			{
				compositeEntity.Id = entity.Id;
			}
			GetPartialManager(compositeEntity).Save(compositeEntity);
		}
	}

	public override T LoadOrNull(long id)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.id = id;
		IContextBoundVariableService serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
		string name = typeof(T).AssemblyQualifiedName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716495013) + CS_0024_003C_003E8__locals0.id;
		return serviceNotNull.GetOrAdd(name, delegate
		{
			ConstructorInfo constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(long) }, null);
			if (constructor == null)
			{
				throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3617BB95) + typeof(T).FullName);
			}
			T val = (T)constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals0.id });
			PropertyInfo reflectionProperty = typeof(T).GetReflectionProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716644144));
			if (reflectionProperty != null)
			{
				Guid? guid = (Guid?)reflectionProperty.GetValue(val, null);
				if (!guid.HasValue || guid.Value == Guid.Empty)
				{
					reflectionProperty.SetValue(val, Guid.NewGuid(), null);
				}
			}
			return val;
		});
	}

	public virtual void PutToContextCache(IEntity entity)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (entity == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IContextBoundVariableService serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
				string name = typeof(T).AssemblyQualifiedName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122724927) + entity.GetId();
				serviceNotNull.Set(name, entity);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716591096));
			case 2:
				return;
			}
		}
	}

	public WorkflowTablePartManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool wRlQ0M9Ife2h4ebiMH4()
	{
		return UAyKNK9ixbs67ftj6tb == null;
	}

	internal static object AjekbE9aMRLN9G6ort8()
	{
		return UAyKNK9ixbs67ftj6tb;
	}
}
