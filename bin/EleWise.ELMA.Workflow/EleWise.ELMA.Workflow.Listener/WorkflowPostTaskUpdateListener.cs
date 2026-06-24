using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using EleWise.ELMA.Workflow.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowPostTaskUpdateListener : PostFlushEventListener
{
	internal class OldTaskState
	{
		private static OldTaskState WASNcAZATiq3MLrmTKgB;

		public object[] OldState
		{
			[CompilerGenerated]
			get
			{
				return _003COldState_003Ek__BackingField;
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
						_003COldState_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string[] PropertyNames
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyNames_003Ek__BackingField;
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
						_003CPropertyNames_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool IsFilled
		{
			[CompilerGenerated]
			get
			{
				return _003CIsFilled_003Ek__BackingField;
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
						_003CIsFilled_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
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

		public Dictionary<string, IEnumerable> OldCollectionState { get; set; }

		public OldTaskState()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TExmQgZACMSijl4IyAhK();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
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
				OldCollectionState = new Dictionary<string, IEnumerable>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool wsqOFPZAQ5ZfNxsmog8p()
		{
			return WASNcAZATiq3MLrmTKgB == null;
		}

		internal static OldTaskState KOOM6uZApRvKoEstfypY()
		{
			return WASNcAZATiq3MLrmTKgB;
		}

		internal static void TExmQgZACMSijl4IyAhK()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal const string WorkflowTaskUpdateListenerContextVarName = "WorkflowTaskUpdateListener";

	private static WorkflowPostTaskUpdateListener juKQDO3zPY4J9JQwI6r;

	public IWorkflowScriptingService ScriptingService
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptingService_003Ek__BackingField;
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
					_003CScriptingService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private bool IsIEnumerableT(Type propertyType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Hja0LOTv24WTRBxqUoF(propertyType.GetGenericTypeDefinition(), OMpoctTZfnFsI2FrUF0(typeof(IEnumerable<>).TypeHandle));
			case 1:
				if (!propertyType.IsGenericType)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Type CheckPropertyType(Type propertyType)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_00e6
		int num = 7;
		Type @interface = default(Type);
		Type[] genericArguments = default(Type[]);
		Type[] genericArguments2 = default(Type[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (!(@interface != null))
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 6:
					genericArguments = propertyType.GetGenericArguments();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (genericArguments2.Any())
					{
						num2 = 11;
						continue;
					}
					goto case 5;
				case 9:
					break;
				case 11:
					return genericArguments2[0];
				case 5:
					return null;
				case 8:
					@interface = propertyType.GetInterface(OMpoctTZfnFsI2FrUF0(typeof(IEnumerable<>).TypeHandle).FullName);
					num2 = 10;
					continue;
				case 3:
					return genericArguments[0];
				case 1:
					if (!propertyType.IsGenericType)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				default:
					if (genericArguments.Length == 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 4:
					if (propertyType.IsArray)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 7:
					if (IsIEnumerableT(propertyType))
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				}
				break;
			}
			genericArguments2 = @interface.GetGenericArguments();
			num = 2;
		}
	}

	private void GenerateCollectionBySnapshot(IEnumerable snapshot, string collectionPropertyName, Type taskType, IWorkflowTaskBase oldTask)
	{
		//Discarded unreachable code: IL_0132, IL_01cd, IL_01dc, IL_01e7, IL_02d3, IL_02e2, IL_02ee, IL_02fd, IL_030d
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		int num = 4;
		Type type = default(Type);
		PropertyInfo propertyInfo = default(PropertyInfo);
		ISet val = default(ISet);
		Type type2 = default(Type);
		IEnumerator enumerator = default(IEnumerator);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 14:
					if (!Hja0LOTv24WTRBxqUoF(type.GetGenericTypeDefinition(), OMpoctTZfnFsI2FrUF0(typeof(ISet<>).TypeHandle)))
					{
						num = 13;
						break;
					}
					goto case 12;
				case 4:
					propertyInfo = (PropertyInfo)yrVhDwTY2IkfmHJubqA(taskType, collectionPropertyName);
					num2 = 3;
					continue;
				case 2:
					val = (ISet)W2XNclTsdeI0NPi2Xh5(type.GetGenericTypeDefinition().MakeGenericType(type2));
					num2 = 7;
					continue;
				case 6:
					type2 = CheckPropertyType(type);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					val = null;
					num2 = 9;
					continue;
				case 10:
					return;
				case 7:
				case 8:
				case 13:
					if (val != null)
					{
						mU9ZHATJVEZ2FTdUStS(val);
						num = 5;
						break;
					}
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					if (type.IsInterface)
					{
						num2 = 14;
						continue;
					}
					goto case 2;
				case 12:
					val = (ISet)Activator.CreateInstance(OMpoctTZfnFsI2FrUF0(typeof(HashedSet<>).TypeHandle).MakeGenericType(type.GetGenericArguments()));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 8;
					}
					continue;
				case 15:
					gh28u8TbH2rfVaJWowo(propertyInfo, oldTask, val, null);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					type = SsCPZST8N54DA4JB9np(propertyInfo);
					num2 = 6;
					continue;
				case 11:
					try
					{
						while (true)
						{
							IL_0219:
							int num3;
							if (!gnJpfQTmq9KGSJU4Uib(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
								{
									num3 = 0;
								}
								goto IL_01eb;
							}
							goto IL_023f;
							IL_023f:
							obj = blmkPjT0tcWh14BvFd8(enumerator);
							num3 = 3;
							goto IL_01eb;
							IL_01eb:
							while (true)
							{
								switch (num3)
								{
								case 3:
									iWjE5wTyjBS6TRnc87j(val, obj);
									num3 = 2;
									continue;
								case 2:
									goto IL_0219;
								case 1:
									goto IL_023f;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 3:
							{
								JUhmoTTt8uItGmX6xl9(disposable);
								int num5 = 2;
								num4 = num5;
								continue;
							}
							case 1:
								if (disposable == null)
								{
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 3;
							case 0:
								break;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 15;
				case 5:
					enumerator = (IEnumerator)Dx4yf8TlWlmE0kSt7XX(snapshot);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private IWorkflowTaskBase GenerateTaskByState(OldTaskState oldTaskState, IWorkflowTaskBase task)
	{
		//Discarded unreachable code: IL_014c, IL_015b, IL_01b4, IL_01be, IL_0288, IL_029b, IL_02aa, IL_02b9, IL_0356, IL_0365
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		Type type = default(Type);
		Dictionary<string, IEnumerable>.Enumerator enumerator = default(Dictionary<string, IEnumerable>.Enumerator);
		int num3 = default(int);
		object[] array = default(object[]);
		string[] propertyNames = default(string[]);
		KeyValuePair<string, IEnumerable> current = default(KeyValuePair<string, IEnumerable>);
		while (true)
		{
			switch (num2)
			{
			case 10:
				_003C_003Ec__DisplayClass9_.oldTask = InterfaceActivator.Create(type) as IWorkflowTaskBase;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
			case 15:
				((IEnumerable<PropertyInfo>)w0EnnuTByfeUk5uBB2e(type)).Where(_003C_003Ec__DisplayClass9_._003CGenerateTaskByState_003Eb__0).ForEach(_003C_003Ec__DisplayClass9_._003CGenerateTaskByState_003Eb__1);
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 14;
				}
				break;
			case 14:
			case 16:
				enumerator = _003C_003Ec__DisplayClass9_.oldStateCollections.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				num3 = 0;
				num2 = 8;
				break;
			case 4:
				_003C_003Ec__DisplayClass9_.task = task;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				array = (object[])Xb4Wi2T5qDBr7iJIZdE(oldTaskState);
				num2 = 18;
				break;
			case 17:
				num3++;
				num2 = 19;
				break;
			case 11:
			case 12:
				gh28u8TbH2rfVaJWowo(yrVhDwTY2IkfmHJubqA(type, propertyNames[num3]), _003C_003Ec__DisplayClass9_.oldTask, array[num3], null);
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 15;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
							{
								num4 = 1;
							}
							goto IL_01c2;
						}
						goto IL_0239;
						IL_0239:
						current = enumerator.Current;
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num4 = 2;
						}
						goto IL_01c2;
						IL_01c2:
						while (true)
						{
							switch (num4)
							{
							case 2:
								GenerateCollectionBySnapshot(current.Value, current.Key, type, _003C_003Ec__DisplayClass9_.oldTask);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
								{
									num4 = 0;
								}
								continue;
							case 3:
								goto IL_0239;
							case 1:
								goto end_IL_01dc;
							}
							break;
						}
						continue;
						end_IL_01dc:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 8:
			case 19:
				if (num3 < propertyNames.Length)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 14;
			case 18:
				propertyNames = oldTaskState.PropertyNames;
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				if (!WQGeyWTgQjsv8xHWoeO(oldTaskState))
				{
					num2 = 7;
					break;
				}
				goto case 13;
			case 6:
				return _003C_003Ec__DisplayClass9_.oldTask;
			default:
				type = _003C_003Ec__DisplayClass9_.task.GetType();
				num2 = 10;
				break;
			case 5:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 4;
				break;
			case 9:
				_003C_003Ec__DisplayClass9_.oldStateCollections = oldTaskState.OldCollectionState;
				num2 = 3;
				break;
			}
		}
	}

	private void OnTaskUpdate(IWorkflowTaskBase task)
	{
		//Discarded unreachable code: IL_0102, IL_0147, IL_0156, IL_01b6, IL_01f9
		int num = 6;
		Dictionary<string, OldTaskState> value = default(Dictionary<string, OldTaskState>);
		string key = default(string);
		long id = default(long);
		IProcessScriptBase processScriptBase = default(IProcessScriptBase);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		OldTaskState value2 = default(OldTaskState);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					return;
				case 3:
				case 4:
				case 12:
					value.Remove(key);
					num2 = 8;
					continue;
				default:
					if (ScriptingService != null)
					{
						num2 = 10;
						continue;
					}
					goto case 9;
				case 11:
					key = id.ToString();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					tF8NR5TdZAONI88VVdU(processScriptBase, workflowTaskBase, task, ((IWorkflowInstance)tW7476TPS1fVnpK6GCi(task.WorkflowBookmark)).Context);
					num = 12;
					break;
				case 9:
					obj = null;
					goto IL_021e;
				case 7:
					if (processScriptBase.GetType().GetMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17868289)).DeclaringType.IsGenericType)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				case 1:
					if (value.TryGetValue(key, out value2))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 6:
					if (task != null)
					{
						if (!ContextVars.TryGetValue<Dictionary<string, OldTaskState>>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB279B4), out value))
						{
							num = 14;
							break;
						}
						id = task.Id;
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 11;
						}
						continue;
					}
					num2 = 5;
					continue;
				case 2:
					workflowTaskBase = GenerateTaskByState(value2, task);
					num2 = 15;
					continue;
				case 8:
					return;
				case 14:
					return;
				case 13:
					if (processScriptBase == null)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 10:
					{
						obj = l3Plf8TXU4w5HRABuKj(ScriptingService, tW7476TPS1fVnpK6GCi(YpPZamTcC3QYkWAugIb(task))) as IProcessScriptBase;
						goto IL_021e;
					}
					IL_021e:
					processScriptBase = (IProcessScriptBase)obj;
					num = 13;
					break;
				}
				break;
			}
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
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
				OnTaskUpdate(JUiY2GTuOVF7ZafMkHK(@event) as IWorkflowTaskBase);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
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
				OnTaskUpdate(gb3RUwTDnKid56AcL8l(@event) as IWorkflowTaskBase);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WorkflowPostTaskUpdateListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		H3L03wTnTJgSYleUgie();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FemN1gTKQhLMlDwIHUy()
	{
		return juKQDO3zPY4J9JQwI6r == null;
	}

	internal static WorkflowPostTaskUpdateListener zl8RxTTOe14fXGT2ykB()
	{
		return juKQDO3zPY4J9JQwI6r;
	}

	internal static Type OMpoctTZfnFsI2FrUF0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool Hja0LOTv24WTRBxqUoF(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object yrVhDwTY2IkfmHJubqA(Type P_0, object P_1)
	{
		return P_0.GetReflectionProperty((string)P_1);
	}

	internal static Type SsCPZST8N54DA4JB9np(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object W2XNclTsdeI0NPi2Xh5(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void mU9ZHATJVEZ2FTdUStS(object P_0)
	{
		((ISet)P_0).Clear();
	}

	internal static object Dx4yf8TlWlmE0kSt7XX(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object blmkPjT0tcWh14BvFd8(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool iWjE5wTyjBS6TRnc87j(object P_0, object P_1)
	{
		return ((ISet)P_0).Add(P_1);
	}

	internal static bool gnJpfQTmq9KGSJU4Uib(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void JUhmoTTt8uItGmX6xl9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void gh28u8TbH2rfVaJWowo(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object Xb4Wi2T5qDBr7iJIZdE(object P_0)
	{
		return ((OldTaskState)P_0).OldState;
	}

	internal static bool WQGeyWTgQjsv8xHWoeO(object P_0)
	{
		return ((OldTaskState)P_0).IsFilled;
	}

	internal static object w0EnnuTByfeUk5uBB2e(Type P_0)
	{
		return P_0.GetReflectionProperties();
	}

	internal static object YpPZamTcC3QYkWAugIb(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object tW7476TPS1fVnpK6GCi(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object l3Plf8TXU4w5HRABuKj(object P_0, object P_1)
	{
		return ((IWorkflowScriptingService)P_0).GetScriptInstance((IWorkflowInstance)P_1);
	}

	internal static void tF8NR5TdZAONI88VVdU(object P_0, object P_1, object P_2, object P_3)
	{
		((IProcessScriptBase)P_0).OnTaskUpdate((ITaskBase)P_1, (ITaskBase)P_2, P_3);
	}

	internal static object JUiY2GTuOVF7ZafMkHK(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_AffectedOwnerOrNull();
	}

	internal static object gb3RUwTDnKid56AcL8l(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void H3L03wTnTJgSYleUgie()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
