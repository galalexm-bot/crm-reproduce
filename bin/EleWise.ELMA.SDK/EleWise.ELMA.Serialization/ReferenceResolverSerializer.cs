using System;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal static class ReferenceResolverSerializer
{
	internal const string IdRefPropertyName = "$id";

	internal const string RefPropertyName = "$ref";

	internal static ReferenceResolverSerializer JsfZqmB9CdSwu6qa1hRj;

	internal static IReferenceResolver CurrentResolver => DisposableCallContext.GetCurrent<IReferenceResolver>((string)YpVdyOB9ZvPken3lwCqL(-889460160 ^ -889550946));

	internal static IDisposable CreateResolver(bool needResolver)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!needResolver)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return DisposableCallContext.Create((string)YpVdyOB9ZvPken3lwCqL(-3333094 ^ -3388988), delegate(IReferenceResolver old)
				{
					int num3 = 1;
					int num4 = num3;
					object referenceResolver;
					while (true)
					{
						switch (num4)
						{
						case 1:
							referenceResolver = old;
							if (referenceResolver == null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						default:
							referenceResolver = new ReferenceResolver();
							break;
						}
						break;
					}
					return (IReferenceResolver)referenceResolver;
				});
			default:
				return (IDisposable)ldbx2gB9ud36nkMHKf1C();
			}
		}
	}

	internal static object YpVdyOB9ZvPken3lwCqL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool aoiYWDB9vEhbF56hvOv6()
	{
		return JsfZqmB9CdSwu6qa1hRj == null;
	}

	internal static ReferenceResolverSerializer WviUuGB98A5gYsNMGbtk()
	{
		return JsfZqmB9CdSwu6qa1hRj;
	}

	internal static object ldbx2gB9ud36nkMHKf1C()
	{
		return DisposableCallContext.CreateEmptyCallContext();
	}
}
