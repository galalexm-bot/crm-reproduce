using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public class PermissionStereotype
{
	internal static PermissionStereotype xwvdHxBj65Ms4wj80aVr;

	public IEnumerable<Permission> Permissions { get; private set; }

	public GroupDescriptor DefaultAssignee
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultAssignee_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CDefaultAssignee_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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

	public PermissionStereotype(IEnumerable<Permission> permissions, GroupDescriptor defaultAssignee)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (permissions == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE003B3));
		}
		if (defaultAssignee == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313319E6));
		}
		Permissions = permissions;
		DefaultAssignee = defaultAssignee;
	}

	internal static bool QX7fFtBjH6kPgHFwk1tD()
	{
		return xwvdHxBj65Ms4wj80aVr == null;
	}

	internal static PermissionStereotype S6ACWNBjAJnYQTIefE6R()
	{
		return xwvdHxBj65Ms4wj80aVr;
	}
}
