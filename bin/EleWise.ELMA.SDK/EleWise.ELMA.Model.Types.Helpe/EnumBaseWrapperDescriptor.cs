using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1100)]
public class EnumBaseWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static EnumBaseWrapperDescriptor qnU5uNbotSxx5KIJUZJ7;

	public IMetadataRuntimeService MetadataRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataRuntimeService_003Ek__BackingField;
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
				case 1:
					_003CMetadataRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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

	public Type OriginalType => NRKjh5bo6sqwiH1CFPAZ(typeof(EnumBase).TypeHandle);

	public Type WrapperType => NRKjh5bo6sqwiH1CFPAZ(typeof(EnumBaseWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj is EnumBase)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return new EnumBaseWrapper((EnumBase)obj);
			}
		}
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_00ca, IL_00fc, IL_0134
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					obj = EnumMetadata.Load(MetadataRuntimeService.GetTypeByUid(_003C_003Ec__DisplayClass9_.enumBaseWrapper.TypeUid)).Values.Select((EnumValueMetadata v) => _003C_003Ec.uKT8uPCk6fWcKHRYOHBO(v)).FirstOrDefault(_003C_003Ec__DisplayClass9_._003CGetObject_003Eb__1);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => obj, 
						_ => obj, 
					};
				}
				catch (TypeNotFoundException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return obj;
						}
						obj = null;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num4 = 1;
						}
					}
				}
			case 3:
				return obj;
			default:
				_003C_003Ec__DisplayClass9_.enumBaseWrapper = (EnumBaseWrapper)wrapper;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public bool TestType(Type type)
	{
		return NRKjh5bo6sqwiH1CFPAZ(typeof(EnumBase).TypeHandle).IsAssignableFrom(type);
	}

	public EnumBaseWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YLTuYnboHhCjCU3ckrFG();
		base._002Ector();
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

	internal static bool RHpDGKbowUA7smMTNK5O()
	{
		return qnU5uNbotSxx5KIJUZJ7 == null;
	}

	internal static EnumBaseWrapperDescriptor aXvcwnbo4X4l8ID1kBnt()
	{
		return qnU5uNbotSxx5KIJUZJ7;
	}

	internal static Type NRKjh5bo6sqwiH1CFPAZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void YLTuYnboHhCjCU3ckrFG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
