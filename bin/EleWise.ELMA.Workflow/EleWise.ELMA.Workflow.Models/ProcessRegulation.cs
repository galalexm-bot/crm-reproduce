using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[Component]
[XmlExport]
public class ProcessRegulation : ISerializable, IXsiRoot
{
	public static readonly Guid SystemRegulationTemplateUid;

	[NonSerialized]
	[XmlIgnore]
	public WorkflowDiagram Diagram;

	[NonSerialized]
	[XmlIgnore]
	public Dictionary<Guid, long> ElementNumberDict;

	internal static ProcessRegulation HsIcixOdIZerUs9OaKtj;

	public List<RegulationNormativeRef> ExternalNormativeRefs { get; set; }

	public List<RegulationNormativeRef> InternalNormativeRefs { get; set; }

	public List<RegulationTerm> Terms { get; set; }

	public List<RegulationInputOutput> Inputs { get; set; }

	public List<RegulationInputOutput> Outputs { get; set; }

	public List<RegulationCondition> StartConditions { get; set; }

	public List<RegulationCondition> FinishConditions { get; set; }

	public List<RegulationResource> Resources { get; set; }

	public List<string> TypesResources { get; set; }

	public RegulationHeaderProperties HeaderProperties
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderProperties_003Ek__BackingField;
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
					_003CHeaderProperties_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
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

	public List<RegulationTemplateClass> GlobalTemplates { get; set; }

	public Guid TemplateUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTemplateUid_003Ek__BackingField;
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
					_003CTemplateUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool UseGlobalTemplate
	{
		[CompilerGenerated]
		get
		{
			return _003CUseGlobalTemplate_003Ek__BackingField;
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
					_003CUseGlobalTemplate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RegulationPrintSettings PrintSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CPrintSettings_003Ek__BackingField;
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
					_003CPrintSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RegulationGenerationSettings GenerationSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CGenerationSettings_003Ek__BackingField;
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
					_003CGenerationSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
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

	public ProcessRegulation()
	{
		//Discarded unreachable code: IL_001a
		evnaOUOdeaG2bnW8wNQT();
		base._002Ector();
		int num = 7;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 11:
				PrintSettings = new RegulationPrintSettings();
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num = 0;
				}
				break;
			case 5:
				TemplateUid = SystemRegulationTemplateUid;
				num = 11;
				break;
			case 15:
				UseGlobalTemplate = true;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num = 1;
				}
				break;
			case 14:
				StartConditions = new List<RegulationCondition>();
				num2 = 6;
				goto IL_001f;
			case 13:
				Terms = new List<RegulationTerm>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 9:
				Resources = new List<RegulationResource>();
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num = 12;
				}
				break;
			case 6:
				FinishConditions = new List<RegulationCondition>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num = 9;
				}
				break;
			case 12:
				HeaderProperties = new RegulationHeaderProperties();
				num = 8;
				break;
			case 4:
				InternalNormativeRefs = new List<RegulationNormativeRef>();
				num2 = 13;
				goto IL_001f;
			case 8:
				GenerationSettings = new RegulationGenerationSettings();
				num = 10;
				break;
			default:
				Inputs = new List<RegulationInputOutput>();
				num = 2;
				break;
			case 10:
				GlobalTemplates = new List<RegulationTemplateClass>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num = 15;
				}
				break;
			case 2:
				Outputs = new List<RegulationInputOutput>();
				num = 14;
				break;
			case 7:
				ExternalNormativeRefs = new List<RegulationNormativeRef>();
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num = 4;
				}
				break;
			case 1:
				{
					TypesResources = new List<string>();
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num = 5;
					}
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	protected ProcessRegulation(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_00c8, IL_00d7, IL_00e2, IL_016c, IL_018b, IL_019a, IL_01c7
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 3;
		object obj = default(object);
		string xml = default(string);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			switch (num)
			{
			case 4:
				if (obj != null)
				{
					num = 2;
					continue;
				}
				return;
			case 1:
				obj = ClassSerializationHelper.DeserializeObjectByXml(GetType(), xml);
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num = 2;
				}
				continue;
			case 5:
				return;
			case 3:
				xml = (string)OQPaUGOdx6Jb6E474BVr(info, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638152958), YKdn08OdNF2ItFUlUXrh(typeof(string).TypeHandle));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
				{
					num = 1;
				}
				continue;
			case 2:
				enumerator = obj.GetType().GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_007c, IL_008b, IL_009b, IL_00aa
					int num4 = 4;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 4:
							if (!_003C_003Ec.rin1tKvYjwDS1HlPDpHA(p))
							{
								num5 = 3;
								break;
							}
							goto default;
						case 2:
							return AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null;
						case 1:
						case 3:
							return false;
						default:
							if (!_003C_003Ec.UIKyv1vYRANlPNl2LxFj(p))
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
								{
									num5 = 1;
								}
								break;
							}
							goto case 2;
						}
					}
				})
					.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num2;
					if (!XgKPV8Odhb5dxu7sQZJE(enumerator))
					{
						num2 = 2;
						goto IL_00e6;
					}
					goto IL_0143;
					IL_00e6:
					while (true)
					{
						switch (num2)
						{
						case 2:
							return;
						case 3:
							CsGOQtOd1LvUfs3sBvuT(current, this, xdgLNmOdSUMlZsnS0k3U(current, obj, null), null);
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
							{
								num2 = 1;
							}
							continue;
						case 1:
							break;
						default:
							goto IL_0143;
						}
						break;
					}
					continue;
					IL_0143:
					current = enumerator.Current;
					num2 = 3;
					goto IL_00e6;
				}
			}
			finally
			{
				int num3;
				if (enumerator == null)
				{
					num3 = 2;
					goto IL_0170;
				}
				goto IL_01a5;
				IL_0170:
				switch (num3)
				{
				case 2:
					goto end_IL_015b;
				case 1:
					goto end_IL_015b;
				}
				goto IL_01a5;
				IL_01a5:
				hFCxQmOdEUT4Kt67VUyE(enumerator);
				num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
				{
					num3 = 1;
				}
				goto IL_0170;
				end_IL_015b:;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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
				ink8NgOdzYKdwavvBx2S(info, L94fgfOdwbKm1kQyXw1L(0xF400DF8 ^ 0xF416238), G9EN20Od4iiFA2LasvkW(this, true));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ProcessRegulation Join(ProcessRegulation globalRegulation, ProcessRegulation regulation)
	{
		//Discarded unreachable code: IL_010d, IL_011c, IL_0196, IL_0246, IL_040d, IL_041c, IL_042b, IL_043a, IL_048d, IL_0532, IL_0541, IL_068c, IL_06cc
		int num = 33;
		ProcessRegulation processRegulation = default(ProcessRegulation);
		ProcessRegulation processRegulation2 = default(ProcessRegulation);
		ProcessRegulation processRegulation3 = default(ProcessRegulation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 33:
					if (globalRegulation != null)
					{
						num2 = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 47;
				case 34:
					processRegulation.Outputs.AddRange(processRegulation2.Outputs);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 1;
					}
					continue;
				case 41:
					processRegulation.InternalNormativeRefs.AddRange(processRegulation2.InternalNormativeRefs);
					num2 = 9;
					continue;
				case 27:
					processRegulation.StartConditions.AddRange(processRegulation2.StartConditions);
					num2 = 21;
					continue;
				case 2:
					processRegulation.Inputs.AddRange(processRegulation2.Inputs);
					num2 = 40;
					continue;
				case 55:
					((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation)).Uses.AddRange(((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation3)).Uses);
					num2 = 26;
					continue;
				case 8:
				case 40:
					if (processRegulation2.Outputs == null)
					{
						num2 = 10;
						continue;
					}
					goto case 34;
				case 1:
				case 10:
					if (processRegulation3.StartConditions != null)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 3;
				case 54:
					processRegulation.Resources.AddRange(processRegulation2.Resources);
					num2 = 52;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 42;
					}
					continue;
				case 9:
					if (processRegulation3.Terms != null)
					{
						num2 = 53;
						continue;
					}
					goto case 46;
				case 24:
					processRegulation.Terms.AddRange(processRegulation2.Terms);
					num2 = 55;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 57;
					}
					continue;
				case 13:
					processRegulation.FinishConditions.AddRange(processRegulation3.FinishConditions);
					num2 = 36;
					continue;
				case 14:
				case 36:
					if (processRegulation2.FinishConditions == null)
					{
						num2 = 44;
						continue;
					}
					goto case 18;
				case 35:
				case 44:
					if (processRegulation3.Resources != null)
					{
						num2 = 51;
						continue;
					}
					goto case 28;
				default:
					processRegulation.HeaderProperties.Uses.AddRange(((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation2)).Uses);
					num2 = 19;
					continue;
				case 49:
					((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation)).Coordinations.AddRange(((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation3)).Coordinations);
					num2 = 20;
					continue;
				case 15:
					return null;
				case 32:
					processRegulation3 = ClassSerializationHelper.CloneObjectByXml(globalRegulation);
					num2 = 16;
					continue;
				case 42:
					if (processRegulation3.ExternalNormativeRefs != null)
					{
						num2 = 7;
						continue;
					}
					goto case 38;
				case 57:
					if (processRegulation2.Inputs == null)
					{
						num2 = 8;
						continue;
					}
					goto case 2;
				case 6:
				case 50:
					return processRegulation;
				case 20:
				case 23:
					if (((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation2)).Coordinations == null)
					{
						num2 = 6;
						continue;
					}
					goto case 25;
				case 19:
				case 43:
					if (((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation3)).Coordinations == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 49;
				case 12:
					processRegulation = new ProcessRegulation();
					num2 = 42;
					continue;
				case 31:
					if (processRegulation3.InternalNormativeRefs == null)
					{
						num2 = 29;
						continue;
					}
					goto case 4;
				case 46:
					if (processRegulation2.Terms != null)
					{
						num2 = 24;
						continue;
					}
					goto case 57;
				case 4:
					processRegulation.InternalNormativeRefs.AddRange(processRegulation3.InternalNormativeRefs);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 4;
					}
					continue;
				case 38:
					if (processRegulation2.ExternalNormativeRefs != null)
					{
						num2 = 22;
						continue;
					}
					goto case 31;
				case 30:
					if (((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation3)).Uses != null)
					{
						num2 = 55;
						continue;
					}
					goto case 26;
				case 28:
					if (processRegulation2.Resources == null)
					{
						num2 = 45;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 54;
				case 47:
					if (regulation == null)
					{
						num = 15;
						break;
					}
					goto case 32;
				case 26:
					if (((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation2)).Uses == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto default;
				case 16:
					processRegulation2 = ClassSerializationHelper.CloneObjectByXml(regulation);
					num2 = 12;
					continue;
				case 25:
					((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation)).Coordinations.AddRange(((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation2)).Coordinations);
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 50;
					}
					continue;
				case 3:
					if (processRegulation2.StartConditions != null)
					{
						num2 = 27;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 21;
				case 21:
					if (processRegulation3.FinishConditions == null)
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 7:
					processRegulation.ExternalNormativeRefs.AddRange(processRegulation3.ExternalNormativeRefs);
					num2 = 38;
					continue;
				case 17:
					processRegulation.StartConditions.AddRange(processRegulation3.StartConditions);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					processRegulation.FinishConditions.AddRange(processRegulation2.FinishConditions);
					num = 35;
					break;
				case 51:
					processRegulation.Resources.AddRange(processRegulation3.Resources);
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					processRegulation.ExternalNormativeRefs.AddRange(processRegulation2.ExternalNormativeRefs);
					num2 = 31;
					continue;
				case 53:
					processRegulation.Terms.AddRange(processRegulation3.Terms);
					num2 = 46;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
				case 29:
					if (processRegulation2.InternalNormativeRefs != null)
					{
						num2 = 41;
						continue;
					}
					goto case 9;
				case 45:
				case 52:
					z5hEq7OuvDrcDpmpf76B(processRegulation.HeaderProperties, QUN4fKOuKyLaAuENYS5d(processRegulation2.HeaderProperties.City) ? E9n4hNOuO32KXNeN5X1D(UabJcyOuZR5b51CpXHan(processRegulation2)) : E9n4hNOuO32KXNeN5X1D(processRegulation3.HeaderProperties));
					num2 = 11;
					continue;
				case 11:
					iRCqy1Ou8YuRtAelytd9(UabJcyOuZR5b51CpXHan(processRegulation), ((StringBoolPair)QPSBZBOuYECEwRLv9h6E(UabJcyOuZR5b51CpXHan(processRegulation2))).Enable ? QPSBZBOuYECEwRLv9h6E(UabJcyOuZR5b51CpXHan(processRegulation2)) : processRegulation3.HeaderProperties.CompanyName);
					num2 = 56;
					continue;
				case 56:
					gGk3IeOuJNUxxQWoVleW(UabJcyOuZR5b51CpXHan(processRegulation), ((StringBoolPair)fXNRalOuskX5uylxDbB0(UabJcyOuZR5b51CpXHan(processRegulation2))).Enable ? processRegulation2.HeaderProperties.DirectorFIO : fXNRalOuskX5uylxDbB0(processRegulation3.HeaderProperties));
					num2 = 58;
					continue;
				case 58:
					BA6bUuOu0b9iviRUfGRT(processRegulation.HeaderProperties, QUN4fKOuKyLaAuENYS5d(kUTR5WOuldls6KKJvMvT(UabJcyOuZR5b51CpXHan(processRegulation2))) ? ((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation2)).DirectorJobName : kUTR5WOuldls6KKJvMvT(UabJcyOuZR5b51CpXHan(processRegulation3)));
					num2 = 48;
					continue;
				case 48:
					OB221nOumocn370kdNIo(processRegulation.HeaderProperties, ((StringBoolPair)ffaKEIOuyDkSZSvZQDoS(UabJcyOuZR5b51CpXHan(processRegulation2))).Enable ? ffaKEIOuyDkSZSvZQDoS(UabJcyOuZR5b51CpXHan(processRegulation2)) : ffaKEIOuyDkSZSvZQDoS(UabJcyOuZR5b51CpXHan(processRegulation3)));
					num2 = 37;
					continue;
				case 37:
					dLtxd2Ou5cBKAsHu2K9m(((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation)).DeveloperJob, QUN4fKOuKyLaAuENYS5d(v2fVbcOutGtVLTJK8Hq0(UabJcyOuZR5b51CpXHan(processRegulation2))) ? hafQ4UOubTt21KGuwE6J(v2fVbcOutGtVLTJK8Hq0(processRegulation2.HeaderProperties)) : ((StringBoolPair)v2fVbcOutGtVLTJK8Hq0(UabJcyOuZR5b51CpXHan(processRegulation3))).Name);
					num2 = 39;
					continue;
				case 39:
					dLtxd2Ou5cBKAsHu2K9m(hPhKgmOugE6IRMkHurxe(UabJcyOuZR5b51CpXHan(processRegulation)), QUN4fKOuKyLaAuENYS5d(hPhKgmOugE6IRMkHurxe(processRegulation2.HeaderProperties)) ? hafQ4UOubTt21KGuwE6J(hPhKgmOugE6IRMkHurxe(processRegulation2.HeaderProperties)) : ((RegulationHeaderProperties)UabJcyOuZR5b51CpXHan(processRegulation3)).CheckerJob.Name);
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 30;
					}
					continue;
				}
				break;
			}
		}
	}

	static ProcessRegulation()
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
			case 1:
				SystemRegulationTemplateUid = new Guid((string)L94fgfOdwbKm1kQyXw1L(0x6C7F14 ^ 0x6DA0CE));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool RlH0r8OdaJojSgH5C8if()
	{
		return HsIcixOdIZerUs9OaKtj == null;
	}

	internal static ProcessRegulation H4OqHFOdrdyu2KvTmfQa()
	{
		return HsIcixOdIZerUs9OaKtj;
	}

	internal static void evnaOUOdeaG2bnW8wNQT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type YKdn08OdNF2ItFUlUXrh(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object OQPaUGOdx6Jb6E474BVr(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static object xdgLNmOdSUMlZsnS0k3U(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void CsGOQtOd1LvUfs3sBvuT(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool XgKPV8Odhb5dxu7sQZJE(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void hFCxQmOdEUT4Kt67VUyE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object L94fgfOdwbKm1kQyXw1L(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object G9EN20Od4iiFA2LasvkW(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static void ink8NgOdzYKdwavvBx2S(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static bool QUN4fKOuKyLaAuENYS5d(object P_0)
	{
		return ((StringBoolPair)P_0).Enable;
	}

	internal static object E9n4hNOuO32KXNeN5X1D(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).City;
	}

	internal static object UabJcyOuZR5b51CpXHan(object P_0)
	{
		return ((ProcessRegulation)P_0).HeaderProperties;
	}

	internal static void z5hEq7OuvDrcDpmpf76B(object P_0, object P_1)
	{
		((RegulationHeaderProperties)P_0).City = (StringBoolPair)P_1;
	}

	internal static object QPSBZBOuYECEwRLv9h6E(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).CompanyName;
	}

	internal static void iRCqy1Ou8YuRtAelytd9(object P_0, object P_1)
	{
		((RegulationHeaderProperties)P_0).CompanyName = (StringBoolPair)P_1;
	}

	internal static object fXNRalOuskX5uylxDbB0(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).DirectorFIO;
	}

	internal static void gGk3IeOuJNUxxQWoVleW(object P_0, object P_1)
	{
		((RegulationHeaderProperties)P_0).DirectorFIO = (StringBoolPair)P_1;
	}

	internal static object kUTR5WOuldls6KKJvMvT(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).DirectorJobName;
	}

	internal static void BA6bUuOu0b9iviRUfGRT(object P_0, object P_1)
	{
		((RegulationHeaderProperties)P_0).DirectorJobName = (StringBoolPair)P_1;
	}

	internal static object ffaKEIOuyDkSZSvZQDoS(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).ChangesAccept;
	}

	internal static void OB221nOumocn370kdNIo(object P_0, object P_1)
	{
		((RegulationHeaderProperties)P_0).ChangesAccept = (StringBoolPair)P_1;
	}

	internal static object v2fVbcOutGtVLTJK8Hq0(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).DeveloperJob;
	}

	internal static object hafQ4UOubTt21KGuwE6J(object P_0)
	{
		return ((StringBoolPair)P_0).Name;
	}

	internal static void dLtxd2Ou5cBKAsHu2K9m(object P_0, object P_1)
	{
		((StringBoolPair)P_0).Name = (string)P_1;
	}

	internal static object hPhKgmOugE6IRMkHurxe(object P_0)
	{
		return ((RegulationHeaderProperties)P_0).CheckerJob;
	}
}
