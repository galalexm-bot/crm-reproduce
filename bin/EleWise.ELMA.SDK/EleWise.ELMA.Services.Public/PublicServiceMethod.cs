using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Public;

public sealed class PublicServiceMethod : IPublicServiceMethod
{
	private Guid serviceUid;

	private string name;

	private string description;

	private Func<WebData, PublicServiceMethodExecutor> executorFactory;

	private TypeSerializationDescriptor parametersDescriptor;

	private TypeSerializationDescriptor resultDescriptor;

	private readonly Version version;

	internal static PublicServiceMethod pLKI7bBmv5Pxs24CHV7R;

	public Guid ServiceUid
	{
		get
		{
			return serviceUid;
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
					serviceUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public string Name
	{
		get
		{
			return name;
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
				case 0:
					return;
				case 1:
					name = value;
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

	public string Description
	{
		get
		{
			return description;
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
				case 0:
					return;
				case 1:
					description = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Version Version => version;

	public TypeSerializationDescriptor ParametersDescriptor
	{
		get
		{
			return parametersDescriptor;
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
				case 0:
					return;
				case 1:
					parametersDescriptor = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TypeSerializationDescriptor ResultDescriptor
	{
		get
		{
			return resultDescriptor;
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
					resultDescriptor = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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

	public Func<WebData, PublicServiceMethodExecutor> ExecutorFactory
	{
		get
		{
			return executorFactory;
		}
		set
		{
			executorFactory = value;
		}
	}

	public PublicServiceMethod(Guid serviceUid, [NotNull] string name, [NotNull] string description, [NotNull] Version apiVersion, [NotNull] Func<WebData, PublicServiceMethodExecutor> executorFactory)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281845586));
		}
		if (string.IsNullOrWhiteSpace(description))
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672049361));
		}
		if (apiVersion == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105142836));
		}
		if (executorFactory == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858944025));
		}
		this.serviceUid = serviceUid;
		this.name = name;
		this.description = description;
		this.executorFactory = executorFactory;
		version = apiVersion;
		parametersDescriptor = new TypeSerializationDescriptor();
		resultDescriptor = new TypeSerializationDescriptor();
	}

	WebData IPublicServiceMethod.Execute(WebData parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ExecutorFactory == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return ExecutorFactory(parameters).Execute();
			default:
				throw new NotImplementedException((string)ChlCkHBmu7urNTeaOIbC(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867736028)));
			}
		}
	}

	internal static bool om1K7GBm89OnKymxRsFo()
	{
		return pLKI7bBmv5Pxs24CHV7R == null;
	}

	internal static PublicServiceMethod mUyjihBmZhtjSeSm4IB5()
	{
		return pLKI7bBmv5Pxs24CHV7R;
	}

	internal static object ChlCkHBmu7urNTeaOIbC(object P_0)
	{
		return SR.T((string)P_0);
	}
}
