using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Bytecode.Lightweight;
using NHibernate.Engine;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class EntityPropertyAccessor : IPropertyAccessor
{
	private static class ReflectionOptimizer
	{
		private static readonly Dictionary<Type, OpCode> typeToOpcode;

		private static object nxPN8UQ0EA4PP8S0vMBH;

		public static GetPropertyValueInvoker GenerateGetPropertyValueMethod(object propertyInfo)
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, IQuepbQ0CE7q95off9Vt(typeof(object).TypeHandle), new Type[1] { IQuepbQ0CE7q95off9Vt(typeof(object).TypeHandle) }, xlxtFJQ0vTHnP3QffmAJ(propertyInfo), skipVisibility: false);
			object obj = HrLt2dQ08EOP1wEpbOmW(dynamicMethod);
			adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ldarg_0);
			Y1VsqhQ0umFrsjVFli3N(obj, ((MemberInfo)propertyInfo).DeclaringType);
			qiRk8qQ0VupDw03H556t(obj, OpCodes.Callvirt, DfwLj5Q0I0nr3dCEmx6q(propertyInfo), null);
			EmitBoxIfNeeded(obj, ((PropertyInfo)propertyInfo).PropertyType);
			adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ret);
			return (GetPropertyValueInvoker)JRnf9SQ0Si9LCUuQNlrG(dynamicMethod, IQuepbQ0CE7q95off9Vt(typeof(GetPropertyValueInvoker).TypeHandle));
		}

		public static SetPropertyValueInvoker GenerateSetPropertyValueMethod(object propertyInfo)
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, new Type[2]
			{
				IQuepbQ0CE7q95off9Vt(typeof(object).TypeHandle),
				typeof(object)
			}, xlxtFJQ0vTHnP3QffmAJ(propertyInfo), skipVisibility: false);
			object obj = HrLt2dQ08EOP1wEpbOmW(dynamicMethod);
			adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ldarg_0);
			Y1VsqhQ0umFrsjVFli3N(obj, xlxtFJQ0vTHnP3QffmAJ(propertyInfo));
			adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ldarg_1);
			RCpMLjQ0R8JmUsAR3Z3n(obj, z2i30xQ0iWrRYQhEOCJU(propertyInfo));
			qiRk8qQ0VupDw03H556t(obj, OpCodes.Callvirt, vW8oc8Q0qEnC6ypVtfjc(propertyInfo), null);
			adrVmIQ0ZSAo56XmtVtT(obj, OpCodes.Ret);
			return (SetPropertyValueInvoker)dynamicMethod.CreateDelegate(IQuepbQ0CE7q95off9Vt(typeof(SetPropertyValueInvoker).TypeHandle));
		}

		private static void EmitCastToReference(object il, Type type)
		{
			//Discarded unreachable code: IL_005b
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					o5ndvMQ0KmwSRamvMq93(il, OpCodes.Unbox, type);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				default:
					o5ndvMQ0KmwSRamvMq93(il, OpCodes.Castclass, type);
					num2 = 3;
					break;
				case 1:
					if (!type.IsValueType)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 3:
					return;
				}
			}
		}

		private static void EmitBoxIfNeeded(object il, Type type)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (type.IsValueType)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 1:
					o5ndvMQ0KmwSRamvMq93(il, OpCodes.Box, type);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		private static void PreparePropertyForSet(object il, Type propertyType)
		{
			//Discarded unreachable code: IL_007d, IL_008c, IL_01d4, IL_0251, IL_0260
			int num = 1;
			int num2 = num;
			LocalBuilder localBuilder = default(LocalBuilder);
			OpCode value = default(OpCode);
			Label label = default(Label);
			Label label2 = default(Label);
			while (true)
			{
				switch (num2)
				{
				case 8:
					((ILGenerator)il).Emit(OpCodes.Unbox, propertyType);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 3;
					}
					break;
				case 20:
					((ILGenerator)il).Emit(OpCodes.Ldloca, localBuilder);
					num2 = 13;
					break;
				case 13:
					o5ndvMQ0KmwSRamvMq93(il, OpCodes.Initobj, propertyType);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 2;
					}
					break;
				case 21:
					return;
				case 3:
					if (!typeToOpcode.TryGetValue(propertyType, out value))
					{
						num2 = 19;
						break;
					}
					goto case 15;
				case 12:
					((ILGenerator)il).MarkLabel(label);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 8;
					}
					break;
				case 5:
				case 17:
					FT0mSaQ0Os7lFRKX2a3c(il, label2);
					num2 = 11;
					break;
				case 18:
					((ILGenerator)il).Emit(OpCodes.Castclass, propertyType);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 21;
					}
					break;
				case 14:
				case 19:
					o5ndvMQ0KmwSRamvMq93(il, OpCodes.Ldobj, propertyType);
					num2 = 5;
					break;
				case 22:
					localBuilder = (LocalBuilder)eOORfTQ0TfNbHUrrOXLF(il, propertyType);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 9;
					}
					break;
				case 1:
					if (!propertyType.IsValueType)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 16;
				case 2:
					FkV4DqQ0nKo9sLiRmhIe(il, OpCodes.Ldloc, localBuilder);
					num2 = 10;
					break;
				case 15:
					adrVmIQ0ZSAo56XmtVtT(il, value);
					num2 = 17;
					break;
				case 4:
					adrVmIQ0ZSAo56XmtVtT(il, OpCodes.Pop);
					num2 = 20;
					break;
				case 11:
					return;
				default:
					if (!(propertyType != typeof(object)))
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 18;
					}
					break;
				case 10:
					wQmoehQ0kA5sKXJF7Lpi(il, OpCodes.Br_S, label2);
					num2 = 12;
					break;
				case 6:
					label2 = ihmqedQ0XDoDlMiUis7l(il);
					num2 = 22;
					break;
				case 7:
					wQmoehQ0kA5sKXJF7Lpi(il, OpCodes.Brtrue_S, label);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 4;
					}
					break;
				case 16:
					label = ihmqedQ0XDoDlMiUis7l(il);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 6;
					}
					break;
				case 9:
					adrVmIQ0ZSAo56XmtVtT(il, OpCodes.Dup);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 6;
					}
					break;
				}
			}
		}

		static ReflectionOptimizer()
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
					typeToOpcode = new Dictionary<Type, OpCode>
					{
						[typeof(bool)] = OpCodes.Ldind_I1,
						[IQuepbQ0CE7q95off9Vt(typeof(sbyte).TypeHandle)] = OpCodes.Ldind_I1,
						[IQuepbQ0CE7q95off9Vt(typeof(byte).TypeHandle)] = OpCodes.Ldind_U1,
						[IQuepbQ0CE7q95off9Vt(typeof(char).TypeHandle)] = OpCodes.Ldind_U2,
						[typeof(short)] = OpCodes.Ldind_I2,
						[IQuepbQ0CE7q95off9Vt(typeof(ushort).TypeHandle)] = OpCodes.Ldind_U2,
						[IQuepbQ0CE7q95off9Vt(typeof(int).TypeHandle)] = OpCodes.Ldind_I4,
						[typeof(uint)] = OpCodes.Ldind_U4,
						[IQuepbQ0CE7q95off9Vt(typeof(long).TypeHandle)] = OpCodes.Ldind_I8,
						[IQuepbQ0CE7q95off9Vt(typeof(ulong).TypeHandle)] = OpCodes.Ldind_I8,
						[IQuepbQ0CE7q95off9Vt(typeof(float).TypeHandle)] = OpCodes.Ldind_R4,
						[IQuepbQ0CE7q95off9Vt(typeof(double).TypeHandle)] = OpCodes.Ldind_R8
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					syddh6Q02gWlKnNYMHrN();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static Type IQuepbQ0CE7q95off9Vt(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static Type xlxtFJQ0vTHnP3QffmAJ(object P_0)
		{
			return ((MemberInfo)P_0).DeclaringType;
		}

		internal static object HrLt2dQ08EOP1wEpbOmW(object P_0)
		{
			return ((DynamicMethod)P_0).GetILGenerator();
		}

		internal static void adrVmIQ0ZSAo56XmtVtT(object P_0, OpCode P_1)
		{
			((ILGenerator)P_0).Emit(P_1);
		}

		internal static void Y1VsqhQ0umFrsjVFli3N(object P_0, Type type)
		{
			EmitCastToReference(P_0, type);
		}

		internal static object DfwLj5Q0I0nr3dCEmx6q(object P_0)
		{
			return ((PropertyInfo)P_0).GetMethod;
		}

		internal static void qiRk8qQ0VupDw03H556t(object P_0, OpCode P_1, object P_2, object P_3)
		{
			((ILGenerator)P_0).EmitCall(P_1, (MethodInfo)P_2, (Type[])P_3);
		}

		internal static object JRnf9SQ0Si9LCUuQNlrG(object P_0, Type P_1)
		{
			return ((MethodInfo)P_0).CreateDelegate(P_1);
		}

		internal static bool J63w7SQ0fsvSRb5u4ja8()
		{
			return nxPN8UQ0EA4PP8S0vMBH == null;
		}

		internal static ReflectionOptimizer it5VSyQ0QiPZIXKUZ0Bw()
		{
			return (ReflectionOptimizer)nxPN8UQ0EA4PP8S0vMBH;
		}

		internal static Type z2i30xQ0iWrRYQhEOCJU(object P_0)
		{
			return ((PropertyInfo)P_0).PropertyType;
		}

		internal static void RCpMLjQ0R8JmUsAR3Z3n(object P_0, Type propertyType)
		{
			PreparePropertyForSet(P_0, propertyType);
		}

		internal static object vW8oc8Q0qEnC6ypVtfjc(object P_0)
		{
			return ((PropertyInfo)P_0).SetMethod;
		}

		internal static void o5ndvMQ0KmwSRamvMq93(object P_0, OpCode P_1, Type P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static Label ihmqedQ0XDoDlMiUis7l(object P_0)
		{
			return ((ILGenerator)P_0).DefineLabel();
		}

		internal static object eOORfTQ0TfNbHUrrOXLF(object P_0, Type P_1)
		{
			return ((ILGenerator)P_0).DeclareLocal(P_1);
		}

		internal static void wQmoehQ0kA5sKXJF7Lpi(object P_0, OpCode P_1, Label P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static void FkV4DqQ0nKo9sLiRmhIe(object P_0, OpCode P_1, object P_2)
		{
			((ILGenerator)P_0).Emit(P_1, (LocalBuilder)P_2);
		}

		internal static void FT0mSaQ0Os7lFRKX2a3c(object P_0, Label P_1)
		{
			((ILGenerator)P_0).MarkLabel(P_1);
		}

		internal static void syddh6Q02gWlKnNYMHrN()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	private sealed class ReflectionOptimizedBasicGetter : IGetter
	{
		private readonly object invoker;

		private static object q5CX8gQ0eh0V2TvnInfZ;

		public Type ReturnType { get; }

		public string PropertyName { get; }

		public MethodInfo Method => null;

		public ReflectionOptimizedBasicGetter(PropertyInfo propertyInfo)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			wKWloIQ0NAxZ5Uwr1pUj();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					PropertyName = (string)nd4pUNQ03VnZB8dMhedn(propertyInfo);
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num = 0;
					}
					break;
				case 3:
					return;
				case 2:
					ReturnType = propertyInfo.PropertyType;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					invoker = ReflectionOptimizer.GenerateGetPropertyValueMethod(propertyInfo);
					num = 3;
					break;
				}
			}
		}

		public object Get(object target)
		{
			return t34gnLQ0pDrEP4G0QxIf(invoker, target);
		}

		public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
		{
			return Get(owner);
		}

		internal static void wKWloIQ0NAxZ5Uwr1pUj()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object nd4pUNQ03VnZB8dMhedn(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static bool zj3klQQ0PpsVoxuQrqTE()
		{
			return q5CX8gQ0eh0V2TvnInfZ == null;
		}

		internal static ReflectionOptimizedBasicGetter z3xjkkQ01AgEiUF9F5Bm()
		{
			return (ReflectionOptimizedBasicGetter)q5CX8gQ0eh0V2TvnInfZ;
		}

		internal static object t34gnLQ0pDrEP4G0QxIf(object P_0, object P_1)
		{
			return ((GetPropertyValueInvoker)P_0).Invoke(P_1);
		}
	}

	[Serializable]
	private sealed class SoftDeletableGetter : IGetter
	{
		private readonly object runWithSoftDeletableService;

		private readonly object getter;

		private static object uvdVD7Q0a5y4g0p8UMt2;

		public Type ReturnType => N1lBgiQ045p6PuNj43N9(getter);

		public string PropertyName => (string)uFb72CQ06kKk7mJSLyim(getter);

		public MethodInfo Method => (MethodInfo)Wjve2yQ0HqfyuSXaDvqD(getter);

		public SoftDeletableGetter(RunWithSoftDeletableService runWithSoftDeletableService, IGetter getter)
		{
			//Discarded unreachable code: IL_002a
			LOdF44Q0wIid7q9VZ4k6();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
				{
					this.getter = getter;
					int num2 = 2;
					num = num2;
					continue;
				}
				}
				this.runWithSoftDeletableService = runWithSoftDeletableService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 0;
				}
			}
		}

		public object Get(object target)
		{
			//Discarded unreachable code: IL_0074, IL_00ad, IL_0117, IL_014b, IL_0183, IL_0192
			int num = 2;
			int num2 = num;
			object result = default(object);
			IDisposable disposable = default(IDisposable);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 2:
					disposable = (IDisposable)vZaDwnQ0ACONokBrYYAU();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					try
					{
						bool turned = prKZ0yQ07AGdOBqkbJkR(runWithSoftDeletableService);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								B3nK2iQ0xbFlxda9MOqB(runWithSoftDeletableService, true);
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										return result;
									case 0:
										return result;
									case 1:
										result = ((IGetter)getter).Get(target);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
										{
											num4 = 0;
										}
										break;
									}
								}
							}
							finally
							{
								((RunWithSoftDeletableService)runWithSoftDeletableService).Turned = turned;
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
						}
					}
					finally
					{
						if (disposable != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									pnXSaLQ00iWG0N7lPpoJ(disposable);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
			}
		}

		public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
		{
			//Discarded unreachable code: IL_0053, IL_008c, IL_00f8, IL_012c, IL_0164, IL_0173
			int num = 1;
			int num2 = num;
			object result = default(object);
			IDisposable disposable = default(IDisposable);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return result;
				case 1:
					disposable = ELMAContext.Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					bool turned = prKZ0yQ07AGdOBqkbJkR(runWithSoftDeletableService);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							B3nK2iQ0xbFlxda9MOqB(runWithSoftDeletableService, true);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									return result;
								case 0:
									return result;
								case 1:
									result = XxvjPJQ0mULQjNfTQZqM(getter, owner, mergeMap, session);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}
						finally
						{
							((RunWithSoftDeletableService)runWithSoftDeletableService).Turned = turned;
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								pnXSaLQ00iWG0N7lPpoJ(disposable);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			}
		}

		internal static void LOdF44Q0wIid7q9VZ4k6()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool srs65TQ0DaCaoScG5Buy()
		{
			return uvdVD7Q0a5y4g0p8UMt2 == null;
		}

		internal static SoftDeletableGetter C7Dk28Q0tWcyxYZcg6II()
		{
			return (SoftDeletableGetter)uvdVD7Q0a5y4g0p8UMt2;
		}

		internal static Type N1lBgiQ045p6PuNj43N9(object P_0)
		{
			return ((IGetter)P_0).get_ReturnType();
		}

		internal static object uFb72CQ06kKk7mJSLyim(object P_0)
		{
			return ((IGetter)P_0).get_PropertyName();
		}

		internal static object Wjve2yQ0HqfyuSXaDvqD(object P_0)
		{
			return ((IGetter)P_0).get_Method();
		}

		internal static object vZaDwnQ0ACONokBrYYAU()
		{
			return ELMAContext.Create();
		}

		internal static bool prKZ0yQ07AGdOBqkbJkR(object P_0)
		{
			return ((RunWithSoftDeletableService)P_0).Turned;
		}

		internal static void B3nK2iQ0xbFlxda9MOqB(object P_0, bool value)
		{
			((RunWithSoftDeletableService)P_0).Turned = value;
		}

		internal static void pnXSaLQ00iWG0N7lPpoJ(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static object XxvjPJQ0mULQjNfTQZqM(object P_0, object P_1, object P_2, object P_3)
		{
			return ((IGetter)P_0).GetForInsert(P_1, (IDictionary)P_2, (ISessionImplementor)P_3);
		}
	}

	[Serializable]
	private sealed class DateTimeGetter : IGetter
	{
		private readonly object getter;

		private static object U2P1JyQ0yyRhO7ru9EOg;

		public Type ReturnType => TypeOf<DateTime?>.Raw;

		public string PropertyName => (string)Kfh4nbQ0dqGbp7bGft36(getter);

		public MethodInfo Method => (MethodInfo)V8LCTJQ0l8LTOHJJhKRY(getter);

		public DateTimeGetter(IGetter getter)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			pXHaV6Q09MMpKdNFngS7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
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
				this.getter = getter;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 1;
				}
			}
		}

		public object Get(object target)
		{
			return GetResult((DateTime?)gQQ14sQ0rXX1MIs7kvm4(getter, target));
		}

		public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
		{
			return GetResult((DateTime?)cdP4tCQ0gDdd91pXZJIO(getter, owner, mergeMap, session));
		}

		private object GetResult(DateTime? value)
		{
			return (value == DateTime.MinValue) ? null : value;
		}

		internal static void pXHaV6Q09MMpKdNFngS7()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool zpkEdVQ0MTFowZBofZ9I()
		{
			return U2P1JyQ0yyRhO7ru9EOg == null;
		}

		internal static DateTimeGetter Y7GHqiQ0JCrsmHInBX80()
		{
			return (DateTimeGetter)U2P1JyQ0yyRhO7ru9EOg;
		}

		internal static object Kfh4nbQ0dqGbp7bGft36(object P_0)
		{
			return ((IGetter)P_0).get_PropertyName();
		}

		internal static object V8LCTJQ0l8LTOHJJhKRY(object P_0)
		{
			return ((IGetter)P_0).get_Method();
		}

		internal static object gQQ14sQ0rXX1MIs7kvm4(object P_0, object P_1)
		{
			return ((IGetter)P_0).Get(P_1);
		}

		internal static object cdP4tCQ0gDdd91pXZJIO(object P_0, object P_1, object P_2, object P_3)
		{
			return ((IGetter)P_0).GetForInsert(P_1, (IDictionary)P_2, (ISessionImplementor)P_3);
		}
	}

	[Serializable]
	private sealed class ReflectionOptimizedBasicSetter : ISetter
	{
		private readonly object invoker;

		internal static object YveVY9Q05jEaCSIS48Pc;

		public string PropertyName { get; }

		public MethodInfo Method => null;

		public ReflectionOptimizedBasicSetter(PropertyInfo propertyInfo)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			rHXE8lQ0Lxqr2igHjttx();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					invoker = TVPaaVQ0suaZ29HkG36N(propertyInfo);
					num = 2;
					continue;
				}
				PropertyName = (string)dulMOsQ0Ufn9VKwdCWVS(propertyInfo);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 1;
				}
			}
		}

		public void Set(object target, object value)
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
					UtxZDWQ0clHyhFS6sVn1(invoker, target, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void rHXE8lQ0Lxqr2igHjttx()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object dulMOsQ0Ufn9VKwdCWVS(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static object TVPaaVQ0suaZ29HkG36N(object P_0)
		{
			return ReflectionOptimizer.GenerateSetPropertyValueMethod(P_0);
		}

		internal static bool nbFyViQ0jBmcIjdnAfOE()
		{
			return YveVY9Q05jEaCSIS48Pc == null;
		}

		internal static ReflectionOptimizedBasicSetter ior7tVQ0YQVL5r4Jxqyc()
		{
			return (ReflectionOptimizedBasicSetter)YveVY9Q05jEaCSIS48Pc;
		}

		internal static void UtxZDWQ0clHyhFS6sVn1(object P_0, object P_1, object P_2)
		{
			((SetPropertyValueInvoker)P_0).Invoke(P_1, P_2);
		}
	}

	private readonly bool reflectionOptimize;

	private RunWithSoftDeletableService runWithSoftDeletableService;

	private static EntityPropertyAccessor XxD0mVW12aEXpldD8bo5;

	public bool CanAccessThroughReflectionOptimizer => false;

	public EntityPropertyAccessor()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(reflectionOptimize: true);
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

	public EntityPropertyAccessor(bool reflectionOptimize)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nxvfhRW115kiXGRXlUOd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
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
				this.reflectionOptimize = reflectionOptimize;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IGetter GetGetter(Type type, string propertyName)
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IGetter val = default(IGetter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 3;
					break;
				case 5:
					_003C_003Ec__DisplayClass7_.propertyName = propertyName;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 2;
					}
					break;
				case 7:
					if (txJiixW1pcGDj0iBN4hd(eLuoqWW13I1XNrAcsxfd(val.get_ReturnType()), TypeOf<DateTime>.Raw))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 6:
					_003C_003Ec__DisplayClass7_.type = type;
					num2 = 5;
					break;
				case 3:
					_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
					num2 = 6;
					break;
				case 1:
					return val;
				default:
					if (gxOHjhW1N7eH5UJApVWn(typeof(IEntity).TypeHandle).IsAssignableFrom(_003C_003Ec__DisplayClass7_.type))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 1;
				case 8:
					val = (IGetter)(object)new DateTimeGetter(val);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				{
					IGetter obj = Get(_003C_003Ec__DisplayClass7_.type, _003C_003Ec__DisplayClass7_.propertyName, delegate(PropertyInfo p)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if ((object)p != null)
								{
									return _003C_003Ec.tsvZtYQmEKQMaSRFegeG(p);
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num4 = 0;
								}
								break;
							default:
								return false;
							}
						}
					}, GetGetterInternal, _003C_003Ec__DisplayClass7_._003CGetGetter_003Eb__1);
					if (obj == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 3;
						}
						break;
					}
					val = obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 9:
					throw new PropertyNotFoundException(_003C_003Ec__DisplayClass7_.type, _003C_003Ec__DisplayClass7_.propertyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12460C56));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public ISetter GetSetter(Type type, string propertyName)
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass8_.type = type;
				num2 = 5;
				break;
			case 5:
				_003C_003Ec__DisplayClass8_.propertyName = propertyName;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
				num2 = 4;
				break;
			case 2:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				ISetter obj = Get(_003C_003Ec__DisplayClass8_.type, _003C_003Ec__DisplayClass8_.propertyName, delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_0036, IL_0045
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 2:
							return false;
						default:
							return _003C_003Ec.pxAKc0QmfCV88qErQeI9(p);
						case 1:
							if ((object)p != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				}, GetSetterInternal, _003C_003Ec__DisplayClass8_._003CGetSetter_003Eb__1);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return obj;
			}
			default:
				throw new PropertyNotFoundException(_003C_003Ec__DisplayClass8_.type, _003C_003Ec__DisplayClass8_.propertyName, (string)MBLH3aW1ajRH4FR0E9Ys(-1751176224 ^ -1751303454));
			}
		}
	}

	private IGetter GetGetterInternal(Type type, string propertyName)
	{
		//Discarded unreachable code: IL_005a
		int num = 5;
		int num2 = num;
		IGetter val = default(IGetter);
		RunWithSoftDeletableService runWithSoftDeletableService = default(RunWithSoftDeletableService);
		while (true)
		{
			RunWithSoftDeletableService obj;
			switch (num2)
			{
			case 4:
				if (val == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				val = (IGetter)w4i14rW1DpODdBLV2a4A(type, propertyName, true);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				runWithSoftDeletableService = (this.runWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				obj = this.runWithSoftDeletableService;
				if (obj != null)
				{
					goto IL_00de;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				obj = runWithSoftDeletableService;
				goto IL_00de;
			case 1:
				{
					return null;
				}
				IL_00de:
				return (IGetter)(object)new SoftDeletableGetter(obj, val);
			}
		}
	}

	private ISetter GetSetterInternal(Type type, string propertyName)
	{
		return (ISetter)bcsS5YW1tgRZmrvlM5KT(type, propertyName, true);
	}

	private IGetter GetterFactory(Type type, PropertyInfo propertyInfo, string propertyName)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		RunWithSoftDeletableService obj;
		RunWithSoftDeletableService runWithSoftDeletableService = default(RunWithSoftDeletableService);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = this.runWithSoftDeletableService;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				runWithSoftDeletableService = (this.runWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				obj = runWithSoftDeletableService;
				break;
			}
			break;
		}
		IGetter getter;
		if (!reflectionOptimize)
		{
			IGetter val = (IGetter)new BasicGetter(type, propertyInfo, propertyName);
			getter = val;
		}
		else
		{
			IGetter val = (IGetter)(object)new ReflectionOptimizedBasicGetter(propertyInfo);
			getter = val;
		}
		return (IGetter)(object)new SoftDeletableGetter(obj, getter);
	}

	private ISetter SetterFactory(Type type, PropertyInfo propertyInfo, string propertyName)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		ISetter result = default(ISetter);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 2:
				return result;
			case 1:
				if (reflectionOptimize)
				{
					result = (ISetter)(object)new ReflectionOptimizedBasicSetter(propertyInfo);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
				}
				break;
			default:
				result = (ISetter)new BasicSetter(type, propertyInfo, propertyName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private T Get<T>(Type type, string propertyName, Func<PropertyInfo, bool> check, Func<Type, string, T> resolver, Func<PropertyInfo, T> factory) where T : class
	{
		_003C_003Ec__DisplayClass13_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0<T>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.propertyName = propertyName;
		CS_0024_003C_003E8__locals0.check = check;
		CS_0024_003C_003E8__locals0.resolver = resolver;
		CS_0024_003C_003E8__locals0.factory = factory;
		if (type == typeof(object) || type == null)
		{
			return null;
		}
		if (type.IsInheritOrSame(TypeOf<IValueContainerObjectInternal>.Raw))
		{
			T val = CS_0024_003C_003E8__locals0.resolver(type, CS_0024_003C_003E8__locals0.propertyName);
			if (val != null)
			{
				return val;
			}
		}
		BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
		if (type.IsValueType)
		{
			bindingFlags |= BindingFlags.IgnoreCase;
		}
		PropertyInfo property = type.GetProperty(CS_0024_003C_003E8__locals0.propertyName, bindingFlags);
		if (property == null && !reflectionOptimize)
		{
			property = type.GetProperty(CS_0024_003C_003E8__locals0.propertyName, bindingFlags | BindingFlags.IgnoreCase);
		}
		if (CS_0024_003C_003E8__locals0.check(property))
		{
			return CS_0024_003C_003E8__locals0.factory(property);
		}
		return Get(type.BaseType, CS_0024_003C_003E8__locals0.propertyName, CS_0024_003C_003E8__locals0.check, CS_0024_003C_003E8__locals0.resolver, CS_0024_003C_003E8__locals0.factory) ?? (from i in type.GetInterfaces()
			select CS_0024_003C_003E8__locals0._003C_003E4__this.Get(i, CS_0024_003C_003E8__locals0.propertyName, CS_0024_003C_003E8__locals0.check, CS_0024_003C_003E8__locals0.resolver, CS_0024_003C_003E8__locals0.factory)).FirstOrDefault();
	}

	internal static bool pLsXRUW1eqwIGxbXEVgt()
	{
		return XxD0mVW12aEXpldD8bo5 == null;
	}

	internal static EntityPropertyAccessor JvBBuMW1P2ieiQBkuqw7()
	{
		return XxD0mVW12aEXpldD8bo5;
	}

	internal static void nxvfhRW115kiXGRXlUOd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type gxOHjhW1N7eH5UJApVWn(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type eLuoqWW13I1XNrAcsxfd(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool txJiixW1pcGDj0iBN4hd(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object MBLH3aW1ajRH4FR0E9Ys(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object w4i14rW1DpODdBLV2a4A(Type type, object P_1, bool declaredOnly)
	{
		return type.GetGetter((string)P_1, declaredOnly);
	}

	internal static object bcsS5YW1tgRZmrvlM5KT(Type type, object P_1, bool declaredOnly)
	{
		return type.GetSetter((string)P_1, declaredOnly);
	}
}
