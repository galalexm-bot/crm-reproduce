using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

[Serializable]
public class WorkflowDiagramNHType : WorkflowProcessXmlSerializableType<WorkflowDiagram>
{
	private static ConcurrentDictionary<string, Type> diagramTypes;

	internal static WorkflowDiagramNHType mKWTu7JLp4OOl9URRWf;

	public override Expression<Func<IWorkflowProcess, WorkflowDiagram>> PropertyGetter
	{
		get
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F86F6D));
			return Expression.Lambda<Func<IWorkflowProcess, WorkflowDiagram>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression });
		}
	}

	protected override void SaveObjectToStream(Stream stream, WorkflowDiagram obj)
	{
		//Discarded unreachable code: IL_0078, IL_00d5, IL_010d, IL_012c, IL_013b, IL_0179, IL_01b1, IL_01c0
		int num = 2;
		int num2 = num;
		StreamWriter streamWriter = default(StreamWriter);
		XmlWriter xmlWriter = default(XmlWriter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				streamWriter = new StreamWriter(stream);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					yItxUbJjTyRf3oryCqi(streamWriter, AHW2cwJWQHPjiEGnuU4(obj.GetType()));
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							xmlWriter = (XmlWriter)EGRnpiJRIiNE0GMMDR2(streamWriter);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						try
						{
							aOoxObJ6MsbSSDsYrK1(obj, xmlWriter, true);
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
							return;
						}
						finally
						{
							int num5;
							if (xmlWriter == null)
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
								{
									num5 = 0;
								}
								goto IL_0111;
							}
							goto IL_0146;
							IL_0146:
							OOrLa7JqLITER5baWmt(xmlWriter);
							num5 = 2;
							goto IL_0111;
							IL_0111:
							switch (num5)
							{
							default:
								goto end_IL_00ec;
							case 0:
								goto end_IL_00ec;
							case 1:
								break;
							case 2:
								goto end_IL_00ec;
							}
							goto IL_0146;
							end_IL_00ec:;
						}
					}
				}
				finally
				{
					if (streamWriter != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								OOrLa7JqLITER5baWmt(streamWriter);
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
								{
									num6 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	protected override WorkflowDiagram LoadObjectFromStream(Stream stream)
	{
		//Discarded unreachable code: IL_006e, IL_012c, IL_0164, IL_01a4, IL_01b3, IL_01e0, IL_0220, IL_022f, IL_023b, IL_024a
		int num = 2;
		int num2 = num;
		StreamReader streamReader = default(StreamReader);
		XmlReader xmlReader = default(XmlReader);
		Type orAdd = default(Type);
		WorkflowDiagram result = default(WorkflowDiagram);
		while (true)
		{
			switch (num2)
			{
			case 2:
				streamReader = new StreamReader(stream);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					string key = (string)CuY83HJ3BfrI8GOTLWP(streamReader);
					int num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							QVgA8UJThUXHqZ0BZLf(streamReader);
							num3 = 2;
							continue;
						case 2:
							xmlReader = XmlReader.Create(streamReader);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							orAdd = diagramTypes.GetOrAdd(key, delegate(string name)
							{
								int num7 = 2;
								int num8 = num7;
								_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
								while (true)
								{
									switch (num8)
									{
									case 1:
										_003C_003Ec__DisplayClass4_.name = name;
										num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
										{
											num8 = 0;
										}
										break;
									case 2:
										_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
										num8 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
										{
											num8 = 0;
										}
										break;
									default:
									{
										Type type = ((IEnumerable<Type>)_003C_003Ec.xsVxoiZ9JGiLh5GyDSWi(_003C_003Ec.JhNfU4Z9sF5ZW2ZCcPno())).Where((Type t) => typeof(WorkflowDiagram).IsAssignableFrom(t)).FirstOrDefault(_003C_003Ec__DisplayClass4_._003CLoadObjectFromStream_003Eb__2);
										if (_003C_003Ec.Wd3KKhZ9lG4yQk9GMQ2w(type, null))
										{
											throw new Exception((string)_003C_003Ec.sAfabUZ9yJL12Z2lw9Vl(_003C_003Ec.zJ3fxSZ90M227xeXMMjI(-763667953 ^ -763784297), _003C_003Ec__DisplayClass4_.name));
										}
										return type;
									}
									}
								}
							});
							num3 = 3;
							continue;
						}
						try
						{
							WorkflowDiagram obj = (WorkflowDiagram)ClassSerializationHelper.DeserializeObjectByXml(orAdd, xmlReader);
							G5uVFLJQre6eh5QlUoA(obj);
							result = obj;
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => result, 
								_ => result, 
							};
						}
						finally
						{
							int num5;
							if (xmlReader == null)
							{
								num5 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
								{
									num5 = 0;
								}
								goto IL_0168;
							}
							goto IL_017e;
							IL_017e:
							OOrLa7JqLITER5baWmt(xmlReader);
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
							{
								num5 = 0;
							}
							goto IL_0168;
							IL_0168:
							switch (num5)
							{
							default:
								goto end_IL_0143;
							case 1:
								break;
							case 2:
								goto end_IL_0143;
							case 0:
								goto end_IL_0143;
							}
							goto IL_017e;
							end_IL_0143:;
						}
					}
				}
				finally
				{
					int num6;
					if (streamReader == null)
					{
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
						{
							num6 = 0;
						}
						goto IL_01e4;
					}
					goto IL_01fa;
					IL_01fa:
					OOrLa7JqLITER5baWmt(streamReader);
					num6 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num6 = 1;
					}
					goto IL_01e4;
					IL_01e4:
					switch (num6)
					{
					default:
						goto end_IL_01bf;
					case 2:
						break;
					case 0:
						goto end_IL_01bf;
					case 1:
						goto end_IL_01bf;
					}
					goto IL_01fa;
					end_IL_01bf:;
				}
			default:
				return result;
			}
		}
	}

	public override object Assemble(object cached, ISessionImplementor session, object owner)
	{
		object obj = base.Assemble(cached, session, owner);
		if (obj is WorkflowDiagram workflowDiagram && !workflowDiagram.DiagramLoaded)
		{
			G5uVFLJQre6eh5QlUoA(workflowDiagram);
		}
		return obj;
	}

	public WorkflowDiagramNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Y5YXPCJpraWqrAR7sRi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowDiagramNHType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				diagramTypes = new ConcurrentDictionary<string, Type>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object AHW2cwJWQHPjiEGnuU4(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void yItxUbJjTyRf3oryCqi(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static object EGRnpiJRIiNE0GMMDR2(object P_0)
	{
		return XmlWriter.Create((TextWriter)P_0);
	}

	internal static void aOoxObJ6MsbSSDsYrK1(object P_0, object P_1, bool P_2)
	{
		ClassSerializationHelper.SerializeObjectByXml(P_0, (XmlWriter)P_1, P_2);
	}

	internal static void OOrLa7JqLITER5baWmt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool xdBSvjJf73BAYYprWEk()
	{
		return mKWTu7JLp4OOl9URRWf == null;
	}

	internal static WorkflowDiagramNHType HgKpPUJ9UiJ1JSWIPuS()
	{
		return mKWTu7JLp4OOl9URRWf;
	}

	internal static object CuY83HJ3BfrI8GOTLWP(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static void QVgA8UJThUXHqZ0BZLf(object P_0)
	{
		((StreamReader)P_0).CheckAndCorrectInternalBOMSymbols();
	}

	internal static void G5uVFLJQre6eh5QlUoA(object P_0)
	{
		((Diagram)P_0).LoadDiagram();
	}

	internal static void Y5YXPCJpraWqrAR7sRi()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
