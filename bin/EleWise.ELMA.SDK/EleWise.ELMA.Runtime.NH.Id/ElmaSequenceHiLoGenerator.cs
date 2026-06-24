using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Dialect;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Mapping.ByCode;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Id;

public class ElmaSequenceHiLoGenerator : SequenceGenerator
{
	private class GeneratorDefInternal : IGeneratorDef
	{
		internal static object cqaWjyQY59Ao9jQacx5H;

		public string Class => LHUTJmQYLWKgQqWQdG66(typeof(ElmaSequenceHiLoGenerator).TypeHandle).AssemblyQualifiedName;

		public object Params => null;

		public Type DefaultReturnType => TypeOf<long>.Raw;

		public bool SupportedAsCollectionElementId => false;

		public GeneratorDefInternal()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ESbuNHQYUonMhfcOAc8u();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type LHUTJmQYLWKgQqWQdG66(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool MyPo4UQYjiR02kFmQNnD()
		{
			return cqaWjyQY59Ao9jQacx5H == null;
		}

		internal static GeneratorDefInternal NmThOoQYYRajNXAFTHXW()
		{
			return (GeneratorDefInternal)cqaWjyQY59Ao9jQacx5H;
		}

		internal static void ESbuNHQYUonMhfcOAc8u()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private IIdentifierGenerator idGenerator;

	private int maxLo;

	private int lo;

	private long hi;

	private Type returnClass;

	private readonly AsyncLock asyncLock;

	public const string IdGeneratorTypeParam = "id_gen_type";

	public const string Sequence = "sequence";

	public const string MaxLo = "max_lo";

	private static IGeneratorDef generatorDef;

	private static ElmaSequenceHiLoGenerator ifgovHWyPhFmQdEFvvJT;

	public static IGeneratorDef GeneratorDef
	{
		get
		{
			int num = 1;
			int num2 = num;
			IGeneratorDef obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = generatorDef;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (generatorDef = (IGeneratorDef)(object)new GeneratorDefInternal());
					break;
				}
				break;
			}
			return obj;
		}
	}

	[AsyncStateMachine(typeof(_003CGenerateAsync_003Ed__0))]
	public override Task<object> GenerateAsync(ISessionImplementor session, object obj, CancellationToken cancellationToken)
	{
		_003CGenerateAsync_003Ed__0 stateMachine = default(_003CGenerateAsync_003Ed__0);
		stateMachine._003C_003E4__this = this;
		stateMachine.session = session;
		stateMachine.obj = obj;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private Task<object> GenerateInternalAsync(ISessionImplementor session, object obj, CancellationToken cancellationToken)
	{
		if (idGenerator != null)
		{
			return idGenerator.GenerateAsync(session, obj, cancellationToken);
		}
		return ((SequenceGenerator)this).GenerateAsync(session, obj, cancellationToken);
	}

	public override void Configure(IType type, IDictionary<string, string> parms, Dialect dialect)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		((SequenceGenerator)this).Configure(type, parms, dialect);
		string @string = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5B066B), parms, "");
		if (!string.IsNullOrEmpty(@string))
		{
			idGenerator = (IIdentifierGenerator)Activator.CreateInstance(Type.GetType(@string, throwOnError: true));
			if (idGenerator is IConfigurable)
			{
				((IConfigurable)idGenerator).Configure(type, parms, dialect);
			}
		}
		maxLo = PropertiesHelper.GetInt32(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576025632), parms, 10);
		lo = maxLo + 1;
		returnClass = type.get_ReturnedClass();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public override object Generate(ISessionImplementor session, object obj)
	{
		int num = 8;
		int num2 = num;
		long num4 = default(long);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return KAWdmyWy3fdkN6Yey8Pn(num4, returnClass);
			case 3:
				num3 = Convert.ToInt64(GenerateInternal(session, obj));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				hi = num3 * maxLo;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				num4 = Convert.ToInt64(GenerateInternal(session, obj));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				num4 = Convert.ToInt64(GenerateInternal(session, obj));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return IdentifierGeneratorFactory.CreateNumber(hi + lo++, returnClass);
			default:
				if (num4 == 0L)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 8:
				if (maxLo > 1)
				{
					if (lo >= maxLo)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				}
				num2 = 7;
				break;
			case 6:
				lo = ((num3 == 0L) ? 1 : 0);
				num2 = 2;
				break;
			}
		}
	}

	private object GenerateInternal(ISessionImplementor session, object obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return U3NQU4Wypc0ecsUNeRKZ(idGenerator, session, obj);
			case 1:
				if (idGenerator == null)
				{
					return Ei8f5nWyaGpZG1GV8jJ3(this, session, obj);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ElmaSequenceHiLoGenerator()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		iFcXVcWyDWDIB8JIGZJ3();
		asyncLock = new AsyncLock();
		((SequenceGenerator)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object KAWdmyWy3fdkN6Yey8Pn(long P_0, Type P_1)
	{
		return IdentifierGeneratorFactory.CreateNumber(P_0, P_1);
	}

	internal static bool C0m10GWy1WIBqpgtiQCm()
	{
		return ifgovHWyPhFmQdEFvvJT == null;
	}

	internal static ElmaSequenceHiLoGenerator oLRjc3WyNqrd5D1OOcSy()
	{
		return ifgovHWyPhFmQdEFvvJT;
	}

	internal static object U3NQU4Wypc0ecsUNeRKZ(object P_0, object P_1, object P_2)
	{
		return ((IIdentifierGenerator)P_0).Generate((ISessionImplementor)P_1, P_2);
	}

	internal static object Ei8f5nWyaGpZG1GV8jJ3(object P_0, object P_1, object P_2)
	{
		return ((SequenceGenerator)P_0).Generate((ISessionImplementor)P_1, P_2);
	}

	internal static void iFcXVcWyDWDIB8JIGZJ3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
