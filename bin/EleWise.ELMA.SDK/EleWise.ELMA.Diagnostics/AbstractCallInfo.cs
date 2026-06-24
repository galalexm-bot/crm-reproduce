using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
public abstract class AbstractCallInfo : IDisposable, IWorkTreeElement, ISerializable
{
	private readonly List<IWorkTreeElement> workTree;

	private static IEnumerable<IMetricAggregator> _metricAggregators;

	private static AbstractCallInfo oUZPnCEB2AY2E4oQijbd;

	public long Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
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
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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

	public DateTime StartTime
	{
		[CompilerGenerated]
		get
		{
			return _003CStartTime_003Ek__BackingField;
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
					_003CStartTime_003Ek__BackingField = value;
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

	public DateTime EndTime
	{
		[CompilerGenerated]
		get
		{
			return _003CEndTime_003Ek__BackingField;
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
					_003CEndTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSpan TotalTime
	{
		[CompilerGenerated]
		get
		{
			return _003CTotalTime_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					_003CTotalTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSpan ClearTime
	{
		[CompilerGenerated]
		get
		{
			return _003CClearTime_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					_003CClearTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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

	public Stopwatch Stopwatch
	{
		[CompilerGenerated]
		get
		{
			return _003CStopwatch_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CStopwatch_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CallContextInfo ContextInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CContextInfo_003Ek__BackingField;
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
					_003CContextInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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

	public AbstractCallInfo ParentCall
	{
		[CompilerGenerated]
		get
		{
			return _003CParentCall_003Ek__BackingField;
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
					_003CParentCall_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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

	public IEnumerable<IWorkTreeElement> WorkTree => workTree.ToList();

	public bool IsPerfomed
	{
		[CompilerGenerated]
		get
		{
			return _003CIsPerfomed_003Ek__BackingField;
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
					_003CIsPerfomed_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			return _003CException_003Ek__BackingField;
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
					_003CException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract string CallType { get; }

	public abstract string Description { get; }

	protected AbstractCallInfo()
	{
		//Discarded unreachable code: IL_003a, IL_003f, IL_00e9, IL_00f8
		eqqfRpEB1PI4EiojVwiM();
		workTree = new List<IWorkTreeElement>();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				if (_metricAggregators != null)
				{
					num = 3;
					continue;
				}
				goto case 7;
			case 1:
				return;
			case 3:
				return;
			case 5:
				return;
			case 7:
				_metricAggregators = ComponentManager.Current.GetExtensionPoints<IMetricAggregator>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 1;
				}
				continue;
			default:
				if (!ComponentManager.Initialized)
				{
					num = 5;
					continue;
				}
				break;
			case 2:
				StartTime = tHxVomEBNid8BtXtPVfd();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 0;
				}
				continue;
			case 4:
				break;
			}
			if (ComponentManager.Current.Stage != ComponentManager.LifetimeStage.Initialized)
			{
				break;
			}
			num = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
			{
				num = 6;
			}
		}
	}

	public virtual void StartCall(CallContextInfo callContext)
	{
		//Discarded unreachable code: IL_00cf, IL_01d6, IL_01e5, IL_01f5
		int num = 16;
		int num2 = num;
		IEmptyCallInfo emptyCallInfo = default(IEmptyCallInfo);
		while (true)
		{
			switch (num2)
			{
			case 8:
				ParentCall = (AbstractCallInfo)JRr5UnEBptvpELFdquMX(callContext);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 5;
				}
				break;
			case 14:
				Stopwatch = Stopwatch.StartNew();
				num2 = 7;
				break;
			case 11:
				StartTime = tHxVomEBNid8BtXtPVfd();
				num2 = 14;
				break;
			case 16:
				emptyCallInfo = this as IEmptyCallInfo;
				num2 = 15;
				break;
			case 4:
				callContext.AddWorkTreeElement(this);
				num2 = 12;
				break;
			case 2:
				if (emptyCallInfo == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 18;
			case 18:
				if (!JiHIwYEB3tHOgliKwvLL(emptyCallInfo))
				{
					num2 = 10;
					break;
				}
				return;
			case 15:
				if (callContext != null)
				{
					num2 = 2;
					break;
				}
				return;
			default:
				irB82dEBt7AjBX7br1uw(this);
				num2 = 9;
				break;
			case 9:
				return;
			case 12:
			case 13:
				CX9LMEEBDrmbdLg2DBdr(callContext, this);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 11;
				}
				break;
			case 3:
				iSObGcEBaQH4houS7ofV(ParentCall, this);
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 11;
				}
				break;
			case 17:
				return;
			case 1:
			case 10:
				ContextInfo = callContext;
				num2 = 6;
				break;
			case 7:
				IsPerfomed = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (ParentCall != null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 6:
				Id = callContext.GetNewCallId();
				num2 = 8;
				break;
			}
		}
	}

	protected virtual void StopCall()
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					_metricAggregators.ForEach(delegate(IMetricAggregator ma)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								vpxeEwEB9MnwdWFBG3vn(ma, this, ContextInfo.Metrics);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					EndTime = tHxVomEBNid8BtXtPVfd();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					IsPerfomed = false;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					return;
				case 10:
					ClearTime = TotalTime;
					num2 = 8;
					continue;
				case 1:
					if (_metricAggregators != null)
					{
						num2 = 9;
						continue;
					}
					break;
				case 3:
					CX9LMEEBDrmbdLg2DBdr(ContextInfo, ParentCall);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					KstZ43EBw8uR3t7MMVfe(Stopwatch);
					num2 = 6;
					continue;
				case 4:
					TotalTime = CIGIj7EB4GRIlp7Gt36E(Stopwatch);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					workTree.ForEach(delegate(IWorkTreeElement a)
					{
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							default:
								return;
							case 1:
								ClearTime = aQVwgxEBJxaig5ulnLYO(ClearTime, LANS0CEBMmInQa2wL66X(a));
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num6 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			DiagnosticsManager.Helper.StopCallHelper(this);
			num = 5;
		}
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_0045, IL_0075, IL_00f0, IL_00ff
		int num = 1;
		int num2 = num;
		IEmptyCallInfo emptyCallInfo = default(IEmptyCallInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (emptyCallInfo == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			case 5:
				if (!JiHIwYEB3tHOgliKwvLL(emptyCallInfo))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 4:
				return;
			case 8:
				return;
			case 3:
			case 6:
				YmwUbMEB6UuuhfBBpaEs(this);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 7;
				}
				break;
			default:
				if (!IsPerfomed)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			case 7:
				return;
			case 1:
				emptyCallInfo = this as IEmptyCallInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_012e, IL_013d, IL_014d, IL_01d3
		int num = 17;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 9:
				info.AddValue((string)WDA9QiEBAJBCYmtuilLx(-1822890472 ^ -1822634266), StartTime);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 16:
				if (nOww3tEBHHmFVjiXkYpW(Name))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			case 12:
				return;
			case 5:
				info.AddValue((string)WDA9QiEBAJBCYmtuilLx(-1978478350 ^ -1978490062), Name);
				num2 = 14;
				break;
			case 13:
				info.AddValue((string)WDA9QiEBAJBCYmtuilLx(-951514650 ^ -951246720), Exception);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				JjPlEREBx6oVVqn60pSq(info, WDA9QiEBAJBCYmtuilLx(-1334993905 ^ -1335054891), RjoOoYEB7yO7pb4wUyY9(this));
				num2 = 11;
				break;
			case 8:
			case 18:
				if (Exception == null)
				{
					return;
				}
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 9;
				}
				break;
			default:
				JjPlEREBx6oVVqn60pSq(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210453787), TotalTime);
				num2 = 19;
				break;
			case 1:
				r1VcqXEBm8whPRLA7Ysp(info, WDA9QiEBAJBCYmtuilLx(-1459557599 ^ -1459305931), EndTime);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E22C7), Id);
				num2 = 16;
				break;
			case 10:
			case 11:
				if (!nOww3tEBHHmFVjiXkYpW(wgiNKhEB0xO0IpTBimZX(this)))
				{
					num2 = 4;
					break;
				}
				goto case 9;
			case 3:
				if (JpjP6aEByqYtUrjn2wXw(workTree) == 0)
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 18;
					}
					break;
				}
				goto case 2;
			case 15:
				GetObjectData(info, context);
				num2 = 3;
				break;
			case 2:
				info.AddValue((string)WDA9QiEBAJBCYmtuilLx(-1633514411 ^ -1633245945), WorkTree);
				num2 = 8;
				break;
			case 4:
				JjPlEREBx6oVVqn60pSq(info, WDA9QiEBAJBCYmtuilLx(--1333735954 ^ 0x4F7B1AF8), CallType);
				num2 = 9;
				break;
			case 19:
				info.AddValue((string)WDA9QiEBAJBCYmtuilLx(-606654180 ^ -606922720), ClearTime);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 15;
				}
				break;
			case 7:
			case 14:
				if (nOww3tEBHHmFVjiXkYpW(RjoOoYEB7yO7pb4wUyY9(this)))
				{
					num2 = 10;
					break;
				}
				goto case 6;
			}
		}
	}

	protected abstract void GetObjectData(SerializationInfo info, StreamingContext context);

	internal void AddWorkTreeElement(IWorkTreeElement call)
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
				workTree.Add(call);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void eqqfRpEB1PI4EiojVwiM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static DateTime tHxVomEBNid8BtXtPVfd()
	{
		return DateTime.UtcNow;
	}

	internal static bool G28irCEBeQIuIuK5rUqe()
	{
		return oUZPnCEB2AY2E4oQijbd == null;
	}

	internal static AbstractCallInfo VrScqREBPDjSPbxgmLwd()
	{
		return oUZPnCEB2AY2E4oQijbd;
	}

	internal static bool JiHIwYEB3tHOgliKwvLL(object P_0)
	{
		return ((IEmptyCallInfo)P_0).IsEmpty;
	}

	internal static object JRr5UnEBptvpELFdquMX(object P_0)
	{
		return ((CallContextInfo)P_0).CurrentCall;
	}

	internal static void iSObGcEBaQH4houS7ofV(object P_0, object P_1)
	{
		((AbstractCallInfo)P_0).AddWorkTreeElement((IWorkTreeElement)P_1);
	}

	internal static void CX9LMEEBDrmbdLg2DBdr(object P_0, object P_1)
	{
		((CallContextInfo)P_0).CurrentCall = (AbstractCallInfo)P_1;
	}

	internal static void irB82dEBt7AjBX7br1uw(object P_0)
	{
		DiagnosticsManager.Helper.StartCallHelper((AbstractCallInfo)P_0);
	}

	internal static void KstZ43EBw8uR3t7MMVfe(object P_0)
	{
		((Stopwatch)P_0).Stop();
	}

	internal static TimeSpan CIGIj7EB4GRIlp7Gt36E(object P_0)
	{
		return ((Stopwatch)P_0).Elapsed;
	}

	internal static void YmwUbMEB6UuuhfBBpaEs(object P_0)
	{
		((AbstractCallInfo)P_0).StopCall();
	}

	internal static bool nOww3tEBHHmFVjiXkYpW(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object WDA9QiEBAJBCYmtuilLx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RjoOoYEB7yO7pb4wUyY9(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}

	internal static void JjPlEREBx6oVVqn60pSq(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static object wgiNKhEB0xO0IpTBimZX(object P_0)
	{
		return ((AbstractCallInfo)P_0).CallType;
	}

	internal static void r1VcqXEBm8whPRLA7Ysp(object P_0, object P_1, DateTime P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static int JpjP6aEByqYtUrjn2wXw(object P_0)
	{
		return ((List<IWorkTreeElement>)P_0).Count;
	}

	internal static TimeSpan LANS0CEBMmInQa2wL66X(object P_0)
	{
		return ((IWorkTreeElement)P_0).TotalTime;
	}

	internal static TimeSpan aQVwgxEBJxaig5ulnLYO(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 - P_1;
	}

	internal static void vpxeEwEB9MnwdWFBG3vn(object P_0, object P_1, object P_2)
	{
		((IMetricAggregator)P_0).Add(P_1, (MetricsContainer)P_2);
	}
}
