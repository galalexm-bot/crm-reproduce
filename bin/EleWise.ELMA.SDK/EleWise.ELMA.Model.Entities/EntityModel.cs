using System;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

public class EntityModel<T> where T : class
{
	private static object Mlkgd9hZHSMUMoDjGEmX;

	public T Entity { get; set; }

	public EntityModel(T model)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Entity = model;
	}

	public EntityModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected virtual EntityModel<TFor> CopyAs<TFor>() where TFor : class
	{
		return new EntityModel<TFor>(Entity as TFor);
	}

	public EntityModel<TFor> As<TFor>() where TFor : class
	{
		return CopyAs<TFor>();
	}

	public TMd Metadata<TMd>() where TMd : class, IMetadata
	{
		return EntityHelper.Metadata<TMd>(Entity as IEntity);
	}

	protected EntityMetadata GetSuperMD()
	{
		//Discarded unreachable code: IL_009e, IL_00ef
		int num = 2;
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IMetadata metadata2;
				switch (num2)
				{
				case 4:
					break;
				case 1:
					entityMetadata = Metadata<EntityMetadata>();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (entityMetadata.Type != EntityMetadataType.InterfaceImplementation)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					metadata2 = _003C_003Ec__DisplayClass9_.metadataRuntimeService.GetMetadata(entityMetadata.ImplementationUid, loadImplementation: false);
					goto IL_010d;
				case 7:
					metadata2 = metadata;
					goto IL_010d;
				case 2:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass9_.metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return entityMetadata.ImplementedExtensionUids.Where((Guid uid) => uid.IsConfigMetadata()).Select(_003C_003Ec__DisplayClass9_._003CGetSuperMD_003Eb__1).FirstOrDefault();
				case 5:
					{
						return entityMetadata;
					}
					IL_010d:
					if (!metadata2.IsSystem())
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				}
				break;
			}
			metadata = entityMetadata;
			num = 7;
		}
	}

	public bool HasCustomFormViews(ViewType viewType, bool? inTab = null)
	{
		return EntityHelper.HasCustomFormViews(Entity as IEntity, viewType, inTab);
	}

	public FormView GetCustomFormView(ViewType viewType, bool? inTab = null)
	{
		return EntityHelper.GetCustomFormView(Entity as IEntity, viewType, inTab);
	}

	public virtual bool CheckAction<TManager>([NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		return CheckActionWithResult(expression);
	}

	public virtual ActionCheckResult CheckActionWithResult<TManager>([NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630FE65));
		}
		return Locator.GetServiceNotNull<ActionDispatcherService>().CheckActionWithResult(expression, Entity.CastAsRealType().GetType());
	}

	internal static bool jSX9dkhZAcffnFtvUfVt()
	{
		return Mlkgd9hZHSMUMoDjGEmX == null;
	}

	internal static object CP3rWnhZ7ydYjpZvLpdq()
	{
		return Mlkgd9hZHSMUMoDjGEmX;
	}
}
