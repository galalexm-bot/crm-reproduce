using System;
using System.Web;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

[Service(Scope = ServiceScope.Application, EnableInterceptors = false, InjectProperties = false)]
public class HttpContextAccessor : IHttpContextAccessor
{
	private Func<HttpContextBase> getCurrentIfNull;

	private static HttpContextAccessor sL44E0BxXVH91eADn7Ax;

	public static HttpContextBase CurrentContext => (HttpContextBase)cOVYZlBxn0lkshkEwBx5(Locator.GetServiceNotNull<IHttpContextAccessor>());

	public HttpContextBase Current()
	{
		//Discarded unreachable code: IL_0054
		int num = 3;
		int num2 = num;
		HttpContext staticProperty = default(HttpContext);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return null;
			case 1:
				return getCurrentIfNull();
			case 3:
				staticProperty = GetStaticProperty();
				num2 = 2;
				break;
			case 2:
				if (staticProperty != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (getCurrentIfNull != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			default:
				return new HttpContextWrapper(staticProperty);
			}
		}
	}

	public void SetCurrentIfNull(Func<HttpContextBase> getFunc)
	{
		getCurrentIfNull = getFunc;
	}

	private static HttpContext GetStaticProperty()
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_007a, IL_009d, IL_00ac, IL_00d9, IL_00e8, IL_0113, IL_014b, IL_015a
		int num = 2;
		int num2 = num;
		HttpContext httpContext = default(HttpContext);
		HttpContext result = default(HttpContext);
		while (true)
		{
			switch (num2)
			{
			case 5:
				try
				{
					int num3;
					if (f5YammBx2VGibICy4ivU(httpContext) != null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num3 = 0;
						}
						goto IL_007e;
					}
					goto IL_00b7;
					IL_00b7:
					result = null;
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num3 = 0;
					}
					goto IL_007e;
					IL_007e:
					switch (num3)
					{
					case 1:
						break;
					default:
						return httpContext;
					case 0:
						return httpContext;
					case 3:
						return httpContext;
					case 2:
						return result;
					}
					goto IL_00b7;
				}
				catch (Exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							result = null;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
			default:
				return httpContext;
			case 3:
				return null;
			case 4:
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (httpContext != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 2:
				httpContext = (HttpContext)cgx1SVBxOk3OG23wwcgB();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public HttpContextAccessor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jS41CfBxeAOFst9uY1Zc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object cOVYZlBxn0lkshkEwBx5(object P_0)
	{
		return ((IHttpContextAccessor)P_0).Current();
	}

	internal static bool e2gSGWBxTEMtLCPfqFYx()
	{
		return sL44E0BxXVH91eADn7Ax == null;
	}

	internal static HttpContextAccessor P6MhL5Bxk9URGKBbYpqi()
	{
		return sL44E0BxXVH91eADn7Ax;
	}

	internal static object cgx1SVBxOk3OG23wwcgB()
	{
		return HttpContext.Current;
	}

	internal static object f5YammBx2VGibICy4ivU(object P_0)
	{
		return ((HttpContext)P_0).Request;
	}

	internal static void jS41CfBxeAOFst9uY1Zc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
