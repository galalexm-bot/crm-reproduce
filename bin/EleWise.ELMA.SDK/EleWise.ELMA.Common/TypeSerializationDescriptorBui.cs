using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common;

public class TypeSerializationDescriptorBuilder
{
	private readonly TypeSerializationDescriptor descriptor;

	internal static TypeSerializationDescriptorBuilder KA7YBOfVA3NUWkh0Ijxg;

	public TypeSerializationDescriptor Descriptor => descriptor;

	public TypeSerializationDescriptorBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eJahdOfV0HAtNo5NCfSV();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				descriptor = new TypeSerializationDescriptor();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public TypeSerializationDescriptorBuilder(TypeSerializationDescriptor descriptor)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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
			this.descriptor = descriptor;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
			{
				num = 1;
			}
		}
	}

	public TypeSerializationDescriptorBuilder If(bool condition, Action<TypeSerializationDescriptorBuilder> builder)
	{
		if (condition)
		{
			builder(this);
		}
		return this;
	}

	public TypeSerializationDescriptorBuilder Description(string description)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				descriptor.Description = description;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public TypeSerializationDescriptorBuilder Type(Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				KjXyuqfVmT8YE1dJEhZA(descriptor, type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TypeSerializationDescriptorBuilder Type(string typeName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				descriptor.TypeName = typeName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TypeSerializationDescriptorBuilder IsArray(bool isArray = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				rSud15fVyfXWnS4MLNuk(descriptor, isArray);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public TypeSerializationDescriptorBuilder IsArray(Action<TypeSerializationDescriptorBuilder> builder)
	{
		descriptor.IsArray = true;
		ItemWithDescriptor(null, builder);
		return this;
	}

	public TypeSerializationDescriptorBuilder Optional(object defaultValue = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return this;
			case 1:
				c8fCv8fVMiKhs9rqnSGB(descriptor, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Ri8f3PfVJQOjSrNccQkx(descriptor, defaultValue);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public TypeSerializationDescriptorBuilder Obsolete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				PTPDlAfV9VoHFUEsnUDQ(descriptor, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TypeSerializationDescriptorBuilder Item(Action<TypeSerializationItemDescriptorBuilder> itemBuilder)
	{
		if (itemBuilder == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3644084));
		}
		TypeSerializationItemDescriptor item = new TypeSerializationItemDescriptor();
		itemBuilder(new TypeSerializationItemDescriptorBuilder(item));
		descriptor.Items.Add(item);
		return this;
	}

	public TypeSerializationDescriptorBuilder ItemWithDescriptor(string itemName, Action<TypeSerializationDescriptorBuilder> builder)
	{
		if (builder == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3635B211));
		}
		TypeSerializationItemDescriptor typeSerializationItemDescriptor = new TypeSerializationItemDescriptor
		{
			Name = itemName
		};
		builder(new TypeSerializationDescriptorBuilder(typeSerializationItemDescriptor.Descriptor));
		descriptor.Items.Add(typeSerializationItemDescriptor);
		return this;
	}

	public TypeSerializationDescriptorBuilder Item(TypeSerializationItemDescriptor item)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				descriptor.Items.Add(item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	internal static void eJahdOfV0HAtNo5NCfSV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zpi0JnfV7SJruRgoHSbl()
	{
		return KA7YBOfVA3NUWkh0Ijxg == null;
	}

	internal static TypeSerializationDescriptorBuilder x8ObOAfVxRBZ15ZHNXmw()
	{
		return KA7YBOfVA3NUWkh0Ijxg;
	}

	internal static void KjXyuqfVmT8YE1dJEhZA(object P_0, Type value)
	{
		((TypeSerializationDescriptor)P_0).Type = value;
	}

	internal static void rSud15fVyfXWnS4MLNuk(object P_0, bool value)
	{
		((TypeSerializationDescriptor)P_0).IsArray = value;
	}

	internal static void c8fCv8fVMiKhs9rqnSGB(object P_0, bool value)
	{
		((TypeSerializationDescriptor)P_0).IsOptional = value;
	}

	internal static void Ri8f3PfVJQOjSrNccQkx(object P_0, object P_1)
	{
		((TypeSerializationDescriptor)P_0).DefaultValue = P_1;
	}

	internal static void PTPDlAfV9VoHFUEsnUDQ(object P_0, bool value)
	{
		((TypeSerializationDescriptor)P_0).IsObsolete = value;
	}
}
