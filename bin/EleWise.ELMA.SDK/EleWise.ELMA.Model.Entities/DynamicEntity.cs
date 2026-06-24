using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
public class DynamicEntity : DynamicObject, ISerializable, ICustomTypeDescriptor
{
	[Serializable]
	public class ValueHolder
	{
		private dynamic value;

		private static ValueHolder yK3muECzIXr9yl6KRani;

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool Loaded
		{
			[CompilerGenerated]
			get
			{
				return _003CLoaded_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003CLoaded_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public dynamic Value
		{
			get
			{
				return value;
			}
			set
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					default:
						this.value = value;
						num2 = 3;
						continue;
					case 1:
						_003C_003Eo__16._003C_003Ep__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, BaKitdCzRFkqxwRQdZbc(typeof(ValueHolder).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 4;
						}
						continue;
					case 2:
						if (_003C_003Eo__16._003C_003Ep__1 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 4:
						break;
					}
					Func<CallSite, object, bool> target = _003C_003Eo__16._003C_003Ep__1.Target;
					CallSite<Func<CallSite, object, bool>> _003C_003Ep__ = _003C_003Eo__16._003C_003Ep__1;
					if (_003C_003Eo__16._003C_003Ep__0 == null)
					{
						_003C_003Eo__16._003C_003Ep__0 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(ValueHolder), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							(CSharpArgumentInfo)qYpEj5CzqT9t7I8KRatd(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (!target(_003C_003Ep__, _003C_003Eo__16._003C_003Ep__0.Target(_003C_003Eo__16._003C_003Ep__0, (object)this.value, (object)value)))
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
				}
			}
		}

		public ValueHolder()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			cpbj08Czio1wgTqoCl0p();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				Loaded = true;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 1;
				}
			}
		}

		internal static void cpbj08Czio1wgTqoCl0p()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool rNsCFvCzVcGj9LAt7yfL()
		{
			return yK3muECzIXr9yl6KRani == null;
		}

		internal static ValueHolder kQdPkOCzS8uUFGu9MvGY()
		{
			return yK3muECzIXr9yl6KRani;
		}

		internal static Type BaKitdCzRFkqxwRQdZbc(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object qYpEj5CzqT9t7I8KRatd(CSharpArgumentInfoFlags P_0, object P_1)
		{
			return CSharpArgumentInfo.Create(P_0, (string)P_1);
		}
	}

	private class DynamicPropDescriptor : PropertyDescriptor
	{
		internal static object MirrL7CzKpjrtTxGy3CZ;

		public override Type ComponentType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override bool IsReadOnly => false;

		public override Type PropertyType => L7w6FXCz2Q1keZC485yx(typeof(object).TypeHandle);

		public DynamicPropDescriptor(string name)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			LM1wm6CzknoLS9gatcTC();
			base._002Ector(name, null);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override object GetValue(object component)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 1;
			int num2 = num;
			DynamicEntity dynamicEntity = default(DynamicEntity);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return null;
				case 2:
					return TtJJEjCzORNtS9ht5lK1(dynamicEntity, D4YqZtCznU2Vw3bEK2p6(this));
				case 1:
					dynamicEntity = component as DynamicEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (dynamicEntity != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
			int num = 1;
			int num2 = num;
			DynamicEntity dynamicEntity = default(DynamicEntity);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					irIJApCzeIVCMcNPE4k4(dynamicEntity, D4YqZtCznU2Vw3bEK2p6(this), value);
					num2 = 3;
					continue;
				case 1:
					dynamicEntity = component as DynamicEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (dynamicEntity == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
			}
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		internal static void LM1wm6CzknoLS9gatcTC()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool fAQMfQCzXZJ4JEgtc1GX()
		{
			return MirrL7CzKpjrtTxGy3CZ == null;
		}

		internal static DynamicPropDescriptor HAv6brCzT0hq18uhNulY()
		{
			return (DynamicPropDescriptor)MirrL7CzKpjrtTxGy3CZ;
		}

		internal static object D4YqZtCznU2Vw3bEK2p6(object P_0)
		{
			return ((MemberDescriptor)P_0).Name;
		}

		internal static object TtJJEjCzORNtS9ht5lK1(object P_0, object P_1)
		{
			return ((DynamicEntity)P_0)[(string)P_1];
		}

		internal static Type L7w6FXCz2Q1keZC485yx(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void irIJApCzeIVCMcNPE4k4(object P_0, object P_1, object P_2)
		{
			((DynamicEntity)P_0)[(string)P_1] = P_2;
		}
	}

	private object entity;

	private Guid typeUid;

	private Dictionary<Guid, ValueHolder> valuesByUid;

	private Dictionary<string, ValueHolder> valuesByName;

	private Dictionary<Guid, PropertyInfo> propsByUid;

	private static DynamicEntity iicl1BhuBWJTshLVFfCL;

	public virtual object Id
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return this[(string)vKDRMmhuhjXKT4KpubRJ(-234299632 ^ -234332594)];
				case 1:
					LoadEntityIfNeeded();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					this[(string)vKDRMmhuhjXKT4KpubRJ(0x2ACE37D ^ 0x2AC6223)] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					LoadEntityIfNeeded();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual object this[string name]
	{
		get
		{
			return SafeGetHolder(name).Value;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					SafeGetHolder(name).Value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual object this[Guid uid]
	{
		get
		{
			return SafeGetHolder(uid).Value;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					SafeGetHolder(uid).Value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public object Entity
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return entity;
				case 1:
					LoadEntityIfNeeded();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual bool UseLazyLoadProperty => false;

	public DynamicEntity()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		yobhM8hubL6DYoIcmkLl();
		valuesByUid = new Dictionary<Guid, ValueHolder>();
		valuesByName = new Dictionary<string, ValueHolder>();
		propsByUid = new Dictionary<Guid, PropertyInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DynamicEntity(Guid typeUid)
	{
		//Discarded unreachable code: IL_005a, IL_005f
		yobhM8hubL6DYoIcmkLl();
		valuesByUid = new Dictionary<Guid, ValueHolder>();
		valuesByName = new Dictionary<string, ValueHolder>();
		propsByUid = new Dictionary<Guid, PropertyInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.typeUid = typeUid;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num = 0;
			}
		}
	}

	public DynamicEntity(EntityMetadata metadata, object entity)
	{
		//Discarded unreachable code: IL_005a, IL_005f
		yobhM8hubL6DYoIcmkLl();
		valuesByUid = new Dictionary<Guid, ValueHolder>();
		valuesByName = new Dictionary<string, ValueHolder>();
		propsByUid = new Dictionary<Guid, PropertyInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				mht3ighuEdXFHHPqoQ9e(this, metadata, entity);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 3;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(entity, (string)vKDRMmhuhjXKT4KpubRJ(0x307E9FD1 ^ 0x307E3375));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 0;
				}
				break;
			case 2:
				n38tWuhuGGophCSK93xR(metadata, vKDRMmhuhjXKT4KpubRJ(0x17ADCCD8 ^ 0x17AD85E6));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public virtual void SaveToEntity(EntityMetadata metadata, object entity)
	{
		//Discarded unreachable code: IL_0055, IL_00aa, IL_0163, IL_0195, IL_029f, IL_02b2, IL_02c1
		int num = 2;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		ValueHolder value = default(ValueHolder);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = metadata.Properties.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num3 = 3;
							}
							goto IL_0063;
						}
						goto IL_016d;
						IL_016d:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num3 = 0;
						}
						goto IL_0063;
						IL_0063:
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (_003C_003Eo__4._003C_003Ep__0 == null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 9;
							case 11:
								if (SlsTcPhu86N8Qhhh7Q1y(value))
								{
									num3 = 2;
									continue;
								}
								break;
							case 5:
							case 7:
							case 10:
							case 13:
								break;
							case 4:
								if (!valuesByName.TryGetValue(current.Name, out value))
								{
									num3 = 10;
									continue;
								}
								goto case 11;
							case 12:
								if (!YVuxFbhuvEg21GuVtrdq(propertyInfo, null))
								{
									num3 = 13;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 4;
							case 3:
								goto IL_016d;
							case 6:
								propertyInfo = (PropertyInfo)MsvXhvhuCtTUOoXU0BCM(entity.GetType(), c2AwVUhuQMxkugFsvsQu(current), BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
								num3 = 12;
								continue;
							default:
								if (!(Kuy0UBhufwZKQFPA09Vr(current) != EntityDescriptor.UID))
								{
									num3 = 5;
									continue;
								}
								goto case 6;
							case 9:
								_003C_003Eo__4._003C_003Ep__0.Target(_003C_003Eo__4._003C_003Ep__0, propertyInfo, entity, (object)value.Value, null);
								num3 = 7;
								continue;
							case 1:
							{
								_003C_003Eo__4._003C_003Ep__0 = CallSite<Action<CallSite, PropertyInfo, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, (string)vKDRMmhuhjXKT4KpubRJ(-951514650 ^ -951432390), null, DQ6UnPhuZ55Zasm7RplH(typeof(DynamicEntity).TypeHandle), new CSharpArgumentInfo[4]
								{
									(CSharpArgumentInfo)xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									(CSharpArgumentInfo)xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									(CSharpArgumentInfo)xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags.Constant, null)
								}));
								int num4 = 9;
								num3 = num4;
								continue;
							}
							case 8:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 0:
				return;
			}
		}
	}

	protected virtual void LoadEntityIfNeeded()
	{
	}

	protected virtual void Init(EntityMetadata metadata, object entity)
	{
		//Discarded unreachable code: IL_00b6, IL_00db, IL_00ea, IL_00f5, IL_0163, IL_0355, IL_0368, IL_0377
		int num = 8;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		ValueHolder valueHolder2 = default(ValueHolder);
		PropertyInfo reflectionProperty = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!aJyxu4huVE7rmprerX42(entity.GetType().GetInterface(DQ6UnPhuZ55Zasm7RplH(typeof(IEntity<>).TypeHandle).FullName), null))
					{
						num2 = 3;
						continue;
					}
					break;
				case 8:
					n38tWuhuGGophCSK93xR(metadata, vKDRMmhuhjXKT4KpubRJ(-475857671 ^ -475875897));
					num2 = 7;
					continue;
				case 1:
					return;
				case 3:
				case 6:
					enumerator = metadata.Properties.GetEnumerator();
					num2 = 2;
					continue;
				case 4:
					goto end_IL_0012;
				case 2:
					try
					{
						while (true)
						{
							IL_0230:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 7;
								goto IL_00f9;
							}
							goto IL_013b;
							IL_00f9:
							while (true)
							{
								switch (num3)
								{
								case 7:
									return;
								case 9:
								{
									ValueHolder valueHolder = new ValueHolder();
									gRZTyOhuiCIghn01S4QK(valueHolder, current.Uid);
									rWGgNchuReHXZu3vvAoV(valueHolder, current.Name);
									valueHolder2 = valueHolder;
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num3 = 4;
									}
									continue;
								}
								case 2:
									if (lOYVPShuSgEF3K4JNC9o(Kuy0UBhufwZKQFPA09Vr(current), EntityDescriptor.UID))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
										{
											num3 = 12;
										}
										continue;
									}
									goto IL_0230;
								case 4:
									valueHolder2.Value = reflectionProperty.GetValue(entity, null);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
									{
										num3 = 1;
									}
									continue;
								case 11:
									valuesByUid[DSQERghuX87su12e3cm9(valueHolder2)] = valueHolder2;
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									goto IL_0230;
								case 12:
									reflectionProperty = entity.GetType().GetReflectionProperty((string)c2AwVUhuQMxkugFsvsQu(current), BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
									num3 = 13;
									continue;
								case 6:
									valuesByName[(string)kALQDvhuTD2N8XQOLRGD(valueHolder2)] = valueHolder2;
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num3 = 10;
									}
									continue;
								case 5:
									eRxIFNhuKGQ6EIxPCb9y(valueHolder2, !IJxm0ihuqMToJ3sZD9Lb(this));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num3 = 11;
									}
									continue;
								case 3:
								case 8:
									propsByUid[current.Uid] = reflectionProperty;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
									{
										num3 = 1;
									}
									continue;
								case 10:
									if (!valueHolder2.Loaded)
									{
										num3 = 8;
										continue;
									}
									goto case 4;
								case 13:
									if (YVuxFbhuvEg21GuVtrdq(reflectionProperty, null))
									{
										num3 = 9;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
										{
											num3 = 7;
										}
										continue;
									}
									goto IL_0230;
								}
								break;
							}
							goto IL_013b;
							IL_013b:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num3 = 1;
							}
							goto IL_00f9;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 7:
					Contract.ArgumentNotNull(entity, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5986E5));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					typeUid = XAM2ZIhuIEg576w3nn7M(metadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					break;
				}
				Dictionary<string, ValueHolder> dictionary = valuesByName;
				object key = vKDRMmhuhjXKT4KpubRJ(--1360331293 ^ 0x51158343);
				ValueHolder valueHolder3 = new ValueHolder
				{
					Name = (string)vKDRMmhuhjXKT4KpubRJ(0x48A7E34A ^ 0x48A76214)
				};
				if (_003C_003Eo__19._003C_003Ep__0 == null)
				{
					_003C_003Eo__19._003C_003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, (string)vKDRMmhuhjXKT4KpubRJ(0x7EC153F ^ 0x7EC9461), DQ6UnPhuZ55Zasm7RplH(typeof(DynamicEntity).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
				}
				valueHolder3.Value = _003C_003Eo__19._003C_003Ep__0.Target(_003C_003Eo__19._003C_003Ep__0, entity);
				dictionary[(string)key] = valueHolder3;
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			this.entity = entity;
			num = 5;
		}
	}

	private ValueHolder GetHolder(Guid uid)
	{
		int num = 2;
		ValueHolder value = default(ValueHolder);
		PropertyInfo value2 = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					eRxIFNhuKGQ6EIxPCb9y(value, true);
					num2 = 5;
					continue;
				case 5:
					value.Value = value2.GetValue(entity, null);
					num2 = 4;
					continue;
				case 6:
					return null;
				case 2:
					qqsRuJhukwHrjnptLNAK(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (propsByUid.TryGetValue(DSQERghuX87su12e3cm9(value), out value2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 4:
					return value;
				case 3:
					if (!value.Loaded)
					{
						num = 7;
						break;
					}
					goto case 4;
				case 1:
					if (valuesByUid.TryGetValue(uid, out value))
					{
						if (value != null)
						{
							num = 3;
							break;
						}
						goto case 4;
					}
					num = 6;
					break;
				}
				break;
			}
		}
	}

	private ValueHolder SafeGetHolder(Guid uid)
	{
		return GetHolder(uid) ?? throw new Exception((string)HUvB82hunIaMuxfI8tFW(SR.T((string)vKDRMmhuhjXKT4KpubRJ(-2112703338 ^ -2112752026)), uid));
	}

	private ValueHolder GetHolder(string name)
	{
		int num = 5;
		ValueHolder value = default(ValueHolder);
		PropertyInfo value2 = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					value.Loaded = true;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					qqsRuJhukwHrjnptLNAK(this);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					if (!SlsTcPhu86N8Qhhh7Q1y(value))
					{
						num = 3;
						break;
					}
					goto case 6;
				case 2:
					value.Value = tiRQJJhuORrG2jRsG9Gs(value2, entity, null);
					num2 = 6;
					continue;
				case 4:
					if (!valuesByName.TryGetValue(name, out value))
					{
						num = 7;
						break;
					}
					if (value != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 6:
					return value;
				case 7:
					return null;
				case 3:
					if (propsByUid.TryGetValue(value.Uid, out value2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	private ValueHolder SafeGetHolder(string name)
	{
		return GetHolder(name) ?? throw new Exception((string)HUvB82hunIaMuxfI8tFW(ywV5AJhu2hZF8EEMFL3I(vKDRMmhuhjXKT4KpubRJ(-1870892489 ^ -1870712451)), name));
	}

	public DynamicEntity(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_005a, IL_008e, IL_0163, IL_0172, IL_017d, IL_0261, IL_0297, IL_02aa
		yobhM8hubL6DYoIcmkLl();
		valuesByUid = new Dictionary<Guid, ValueHolder>();
		valuesByName = new Dictionary<string, ValueHolder>();
		propsByUid = new Dictionary<Guid, PropertyInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		List<ValueHolder> list = default(List<ValueHolder>);
		List<ValueHolder>.Enumerator enumerator = default(List<ValueHolder>.Enumerator);
		ValueHolder current = default(ValueHolder);
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 6:
				return;
			default:
				typeUid = (Guid)fp4152hue4V2QB8Lqfpl(info, vKDRMmhuhjXKT4KpubRJ(0x34A6D230 ^ 0x34A48B30), DQ6UnPhuZ55Zasm7RplH(typeof(Guid).TypeHandle));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 0;
				}
				break;
			case 3:
				if (list == null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 4;
			case 1:
				list = (List<ValueHolder>)fp4152hue4V2QB8Lqfpl(info, vKDRMmhuhjXKT4KpubRJ(0x307E9FD1 ^ 0x307FE829), DQ6UnPhuZ55Zasm7RplH(typeof(List<ValueHolder>).TypeHandle));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num = 2;
				}
				break;
			case 4:
			{
				enumerator = list.GetEnumerator();
				int num4 = 5;
				num = num4;
				break;
			}
			case 5:
				try
				{
					while (true)
					{
						int num2;
						if (!enumerator.MoveNext())
						{
							num2 = 6;
							goto IL_0181;
						}
						goto IL_01eb;
						IL_0181:
						while (true)
						{
							switch (num2)
							{
							case 6:
								return;
							case 5:
								break;
							case 1:
							case 2:
								valuesByName[(string)kALQDvhuTD2N8XQOLRGD(current)] = current;
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num2 = 5;
								}
								continue;
							default:
								goto IL_01eb;
							case 3:
								if (!lOYVPShuSgEF3K4JNC9o(DSQERghuX87su12e3cm9(current), Guid.Empty))
								{
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
									{
										num2 = 2;
									}
									continue;
								}
								goto case 4;
							case 4:
								valuesByUid[current.Uid] = current;
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num2 = 1;
								}
								continue;
							}
							break;
						}
						continue;
						IL_01eb:
						current = enumerator.Current;
						num2 = 3;
						goto IL_0181;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				l1rEyKhuPbc7QJ0mSXkA(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217435967), new List<ValueHolder>(valuesByName.Values));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				l1rEyKhuPbc7QJ0mSXkA(info, vKDRMmhuhjXKT4KpubRJ(-1638402543 ^ -1638551791), typeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool TrySetMember(SetMemberBinder binder, object value)
	{
		int num = 3;
		int num2 = num;
		ValueHolder holder = default(ValueHolder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				holder = GetHolder((string)UnQHYChu1jqp3tPsmbiD(binder));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return true;
			case 2:
				if (holder == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				holder.Value = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return USdK71huNpBGqEkOFUTm(this, binder, value);
			}
		}
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		int num = 2;
		int num2 = num;
		ValueHolder holder = default(ValueHolder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return true;
			case 2:
				holder = GetHolder((string)L8Fvw7hu3R6fEf2kVIvj(binder));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return base.TryGetMember(binder, out result);
			case 1:
				if (holder != null)
				{
					result = holder.Value;
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetDynamicMemberNames()
	{
		return valuesByName.Keys;
	}

	public AttributeCollection GetAttributes()
	{
		return null;
	}

	public string GetClassName()
	{
		return null;
	}

	public string GetComponentName()
	{
		return null;
	}

	public TypeConverter GetConverter()
	{
		return null;
	}

	public EventDescriptor GetDefaultEvent()
	{
		return null;
	}

	public PropertyDescriptor GetDefaultProperty()
	{
		return null;
	}

	public object GetEditor(Type editorBaseType)
	{
		return null;
	}

	public EventDescriptorCollection GetEvents(Attribute[] attributes)
	{
		return null;
	}

	public EventDescriptorCollection GetEvents()
	{
		return null;
	}

	public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_00f7, IL_010a, IL_0119
		int num = 2;
		int num2 = num;
		Dictionary<string, ValueHolder>.KeyCollection.Enumerator enumerator = default(Dictionary<string, ValueHolder>.KeyCollection.Enumerator);
		List<PropertyDescriptor> list = default(List<PropertyDescriptor>);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						IL_008d:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0050;
						}
						goto IL_006a;
						IL_0050:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_008d;
							case 3:
								list.Add(new DynamicPropDescriptor(current));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								goto end_IL_008d;
							}
							break;
						}
						goto IL_006a;
						IL_006a:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num3 = 0;
						}
						goto IL_0050;
						continue;
						end_IL_008d:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 2:
				list = new List<PropertyDescriptor>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				enumerator = valuesByName.Keys.GetEnumerator();
				num2 = 3;
				continue;
			}
			break;
		}
		return new PropertyDescriptorCollection((PropertyDescriptor[])iDfIsMhupPjeHvN0Aawv(list));
	}

	public PropertyDescriptorCollection GetProperties()
	{
		return GetProperties(null);
	}

	public object GetPropertyOwner(PropertyDescriptor pd)
	{
		return null;
	}

	public virtual void Save()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Id = IUOHQXhuDh3tpo969IaL(LYiRZrhuaDS1sy3Ew2Fk(typeUid), this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void Delete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				WTXfIIhutVqspiH9sdqZ(LYiRZrhuaDS1sy3Ew2Fk(typeUid), this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void yobhM8hubL6DYoIcmkLl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nA9RxXhuWJBmpth3xtyT()
	{
		return iicl1BhuBWJTshLVFfCL == null;
	}

	internal static DynamicEntity hC67BAhuoujmVfH1YqHC()
	{
		return iicl1BhuBWJTshLVFfCL;
	}

	internal static object vKDRMmhuhjXKT4KpubRJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void n38tWuhuGGophCSK93xR(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void mht3ighuEdXFHHPqoQ9e(object P_0, object P_1, object P_2)
	{
		((DynamicEntity)P_0).Init((EntityMetadata)P_1, P_2);
	}

	internal static Guid Kuy0UBhufwZKQFPA09Vr(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object c2AwVUhuQMxkugFsvsQu(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object MsvXhvhuCtTUOoXU0BCM(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperty((string)P_1, bindingAttr);
	}

	internal static bool YVuxFbhuvEg21GuVtrdq(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static bool SlsTcPhu86N8Qhhh7Q1y(object P_0)
	{
		return ((ValueHolder)P_0).Loaded;
	}

	internal static Type DQ6UnPhuZ55Zasm7RplH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags P_0, object P_1)
	{
		return CSharpArgumentInfo.Create(P_0, (string)P_1);
	}

	internal static Guid XAM2ZIhuIEg576w3nn7M(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool aJyxu4huVE7rmprerX42(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool lOYVPShuSgEF3K4JNC9o(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void gRZTyOhuiCIghn01S4QK(object P_0, Guid value)
	{
		((ValueHolder)P_0).Uid = value;
	}

	internal static void rWGgNchuReHXZu3vvAoV(object P_0, object P_1)
	{
		((ValueHolder)P_0).Name = (string)P_1;
	}

	internal static bool IJxm0ihuqMToJ3sZD9Lb(object P_0)
	{
		return ((DynamicEntity)P_0).UseLazyLoadProperty;
	}

	internal static void eRxIFNhuKGQ6EIxPCb9y(object P_0, bool value)
	{
		((ValueHolder)P_0).Loaded = value;
	}

	internal static Guid DSQERghuX87su12e3cm9(object P_0)
	{
		return ((ValueHolder)P_0).Uid;
	}

	internal static object kALQDvhuTD2N8XQOLRGD(object P_0)
	{
		return ((ValueHolder)P_0).Name;
	}

	internal static void qqsRuJhukwHrjnptLNAK(object P_0)
	{
		((DynamicEntity)P_0).LoadEntityIfNeeded();
	}

	internal static object HUvB82hunIaMuxfI8tFW(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object tiRQJJhuORrG2jRsG9Gs(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object ywV5AJhu2hZF8EEMFL3I(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object fp4152hue4V2QB8Lqfpl(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void l1rEyKhuPbc7QJ0mSXkA(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static object UnQHYChu1jqp3tPsmbiD(object P_0)
	{
		return ((SetMemberBinder)P_0).Name;
	}

	internal static bool USdK71huNpBGqEkOFUTm(object P_0, object P_1, object P_2)
	{
		return ((DynamicObject)P_0).TrySetMember((SetMemberBinder)P_1, P_2);
	}

	internal static object L8Fvw7hu3R6fEf2kVIvj(object P_0)
	{
		return ((GetMemberBinder)P_0).Name;
	}

	internal static object iDfIsMhupPjeHvN0Aawv(object P_0)
	{
		return ((List<PropertyDescriptor>)P_0).ToArray();
	}

	internal static object LYiRZrhuaDS1sy3Ew2Fk(Guid typeUid)
	{
		return DynamicEntityManager.Typed(typeUid);
	}

	internal static object IUOHQXhuDh3tpo969IaL(object P_0, object P_1)
	{
		return ((TypedDynamicEntityManager)P_0).Save((DynamicEntity)P_1);
	}

	internal static void WTXfIIhutVqspiH9sdqZ(object P_0, object P_1)
	{
		((TypedDynamicEntityManager)P_0).Delete((DynamicEntity)P_1);
	}
}
