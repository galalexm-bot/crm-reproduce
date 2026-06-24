using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CustomActivityHeaderManager : EntityManager<ICustomActivityHeader, long>
{
	private static CustomActivityHeaderManager fMNL8CDBku5DGDHhcXq;

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CustomActivityManager CustomActivityManager => Locator.GetServiceNotNull<CustomActivityManager>();

	public new static CustomActivityHeaderManager Instance => Locator.GetServiceNotNull<CustomActivityHeaderManager>();

	public string GenerateNewName(string oldName, Guid newGuid, string postfix = null, string split = " ")
	{
		//Discarded unreachable code: IL_00bd, IL_0189, IL_0198
		int num = 4;
		int num2 = num;
		long num3 = default(long);
		string text2 = default(string);
		string text = default(string);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IEnumerable<ICustomActivityHeader> enumerable = default(IEnumerable<ICustomActivityHeader>);
		while (true)
		{
			switch (num2)
			{
			case 6:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b != 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				text2 = text;
				num2 = 8;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a != 0)
				{
					num2 = 9;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
			case 7:
				if (enumerable != null)
				{
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 2;
			case 3:
				_003C_003Ec__DisplayClass8_.newGuid = newGuid;
				num2 = 12;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				num3 = 1L;
				num2 = 7;
				continue;
			case 14:
				if (num3 >= long.MaxValue)
				{
					num2 = 2;
					continue;
				}
				break;
			case 11:
				enumerable = LoadCustomActivityHeadersByName(text2, ignoreCase: true).Where(_003C_003Ec__DisplayClass8_._003CGenerateNewName_003Eb__1);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
				{
					num2 = 6;
				}
				continue;
			case 13:
				if (enumerable.Count() <= 0)
				{
					num2 = 10;
					continue;
				}
				goto case 14;
			case 9:
				enumerable = LoadCustomActivityHeadersByName(text2, ignoreCase: true).Where(_003C_003Ec__DisplayClass8_._003CGenerateNewName_003Eb__0);
				num2 = 5;
				continue;
			case 2:
			case 10:
				return text2;
			case 12:
				text = (string)C2Kl2gDubP6PEmqLAcW(vMfILkDeHj9N57q3Tui(-802458460 ^ -802479538), oldName, (postfix != null) ? WDQ60RDi9k5kL2nfXIv(split, postfix) : "");
				num2 = 8;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
				{
					num2 = 3;
				}
				continue;
			}
			text2 = string.Format((string)vMfILkDeHj9N57q3Tui(0x2772A0C0 ^ 0x2772F63A), (text.Length + XJZMrODlvGQ0gSRQ7aN(num3.ToString()) + 3 > 2000) ? MSwwEDDfRHihvl1IdGP(text, 1, 2000 - XJZMrODlvGQ0gSRQ7aN(num3.ToString()) - 3) : text, num3, split);
			num2 = 11;
		}
	}

	public IEnumerable<ICustomActivityHeader> LoadCustomActivityHeadersByName(string headerName)
	{
		return LoadCustomActivityHeadersByName(headerName, ignoreCase: false);
	}

	public IEnumerable<ICustomActivityHeader> LoadCustomActivityHeadersByName(string headerName, bool ignoreCase)
	{
		ICustomActivityHeaderFilter customActivityHeaderFilter = InterfaceActivator.Create<ICustomActivityHeaderFilter>();
		customActivityHeaderFilter.DisableSecurity = true;
		ICriteria obj = CreateCriteria(customActivityHeaderFilter);
		obj.Add((ICriterion)(object)(ignoreCase ? ElmaRestrictions.InsensitiveLike(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78FAF0B5 ^ 0x78FAA6C9), headerName) : ElmaRestrictions.Like(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680549150 ^ -680529250), headerName)));
		return obj.List<ICustomActivityHeader>();
	}

	public IEnumerable<ICustomActivityHeader> LoadRootCustomActivityHeader(bool? published = null)
	{
		ICriteria val = CreateCriteria();
		val.Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66914DC5 ^ 0x66911AD1)));
		switch (published)
		{
		case false:
			val.Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1661455645 ^ 0x63079A39)));
			break;
		case true:
			val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30486131)));
			break;
		}
		val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-79921577 ^ -79943315), (object)true)));
		return val.List<ICustomActivityHeader>();
	}

	public IEnumerable<ICustomActivityHeader> LoadPublishedCustomActivityHeaders()
	{
		return LoadPublishedCustomActivityHeaders(deletedIncluded: true);
	}

	public IEnumerable<ICustomActivityHeader> LoadPublishedCustomActivityHeaders(bool deletedIncluded)
	{
		ICriteria val = CreateCriteria();
		val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD795B3 ^ 0x5DD7C297)));
		if (!deletedIncluded)
		{
			val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275456087 ^ -275478381), (object)true)));
		}
		return val.List<ICustomActivityHeader>();
	}

	public virtual bool CheckCustomActivityName(long id, string name, out string errorMessage)
	{
		int num = 3;
		ICriteria val = default(ICriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (eR931pDJ92ptmM08MJ9(HplBtQDLSVSbWoDHXHw(name), string.Empty))
					{
						num2 = 9;
						break;
					}
					errorMessage = string.Empty;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (!string.IsNullOrEmpty(name))
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 4:
					VUEn1dD55nEK1gqhJge(val, Restrictions.Not((ICriterion)AQewklDg5of5adEmq4m(vMfILkDeHj9N57q3Tui(0x82E000E ^ 0x82E37F4), id)));
					num2 = 6;
					break;
				case 8:
					return false;
				case 1:
					if (id > 0)
					{
						num2 = 4;
						break;
					}
					goto case 6;
				default:
					val = (ICriteria)VUEn1dD55nEK1gqhJge(TfG0ydD7Fmo85OouSDA(this, null), ElmaRestrictions.InsensitiveLike((string)vMfILkDeHj9N57q3Tui(0x20C96B1E ^ 0x20C93D62), name));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					errorMessage = (string)OF0eeQDrkqV7SDV8A75(vMfILkDeHj9N57q3Tui(--47835757 ^ 0x2D9BDE1));
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
					{
						num2 = 8;
					}
					break;
				case 6:
					if (!CqX6BBD1IXEa8nJ2pH5(this, val))
					{
						return true;
					}
					num2 = 5;
					break;
				case 9:
					errorMessage = (string)OF0eeQDrkqV7SDV8A75(vMfILkDeHj9N57q3Tui(0x5B9A4287 ^ 0x5B9A15CB));
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
					{
						num2 = 6;
					}
					break;
				case 7:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public virtual bool CheckCustomActivityClassName(long id, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0100, IL_0320, IL_032f, IL_033f, IL_034e, IL_035e
		int num = 9;
		ICriteria val = default(ICriteria);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 8:
					errorMessage = (string)OF0eeQDrkqV7SDV8A75(vMfILkDeHj9N57q3Tui(-282877824 ^ -282855476));
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 13;
					}
					break;
				case 14:
					errorMessage = (string)OF0eeQDrkqV7SDV8A75(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-79921577 ^ -79944081));
					num2 = 15;
					break;
				default:
					return false;
				case 16:
					return true;
				case 15:
					return false;
				case 1:
					VUEn1dD55nEK1gqhJge(val, Restrictions.Not((ICriterion)AQewklDg5of5adEmq4m(vMfILkDeHj9N57q3Tui(0x20C96B1E ^ 0x20C95CE4), id)));
					num2 = 6;
					break;
				case 13:
					return false;
				case 18:
					val = (ICriteria)VUEn1dD55nEK1gqhJge(rNkA1eKXy8GK6NvFm4X(rNkA1eKXy8GK6NvFm4X(TfG0ydD7Fmo85OouSDA(this, null), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-416187968 ^ -416210868), vMfILkDeHj9N57q3Tui(-437373675 ^ -437359473)), vMfILkDeHj9N57q3Tui(0x68C900C0 ^ 0x68C95968), vMfILkDeHj9N57q3Tui(0x124714F0 ^ 0x12474D3C)), XC7oWMKogOJB6QUdp64(vMfILkDeHj9N57q3Tui(0xE6AF0C2 ^ 0xE6AA924), name));
					num2 = 17;
					break;
				case 12:
					return false;
				case 3:
					if (Uj1xxvKCVxQSAbnfA8d(name))
					{
						num2 = 4;
						break;
					}
					errorMessage = string.Empty;
					num2 = 18;
					break;
				case 19:
					return false;
				case 20:
					errorMessage = (string)OF0eeQDrkqV7SDV8A75(vMfILkDeHj9N57q3Tui(-275868378 ^ -275853524));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					errorMessage = SR.T((string)vMfILkDeHj9N57q3Tui(-474638327 ^ -474627775));
					num2 = 19;
					break;
				case 5:
					if (LbOR0RDIILQkmlfwlxF(text))
					{
						goto end_IL_0012;
					}
					if (!nsMoSmKEBjUqbCRxg5v(KTLCMADzmQTyCeufZwb(text, 0)))
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 11;
				case 6:
				case 10:
					if (!CqX6BBD1IXEa8nJ2pH5(this, val))
					{
						num2 = 16;
						break;
					}
					goto case 20;
				case 2:
					if (!eR931pDJ92ptmM08MJ9(HplBtQDLSVSbWoDHXHw(name), string.Empty))
					{
						text = (string)WnWctyDZvkMT9l7GvGU(name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x62463138 ^ 0x6246690A), "");
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
						{
							num2 = 7;
						}
					}
					break;
				case 11:
					errorMessage = (string)OF0eeQDrkqV7SDV8A75(vMfILkDeHj9N57q3Tui(-1164596236 ^ -1164577984));
					num2 = 12;
					break;
				case 17:
					if (id <= 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 1;
				case 9:
					if (LbOR0RDIILQkmlfwlxF(name))
					{
						num2 = 8;
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	public virtual bool CheckCustomActivityTableName(long id, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_00c0, IL_00cf, IL_00df, IL_0194, IL_01a3
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				errorMessage = (string)OF0eeQDrkqV7SDV8A75(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5B9A4287 ^ 0x5B9A1863));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				return false;
			case 10:
				errorMessage = string.Empty;
				num2 = 9;
				continue;
			case 4:
				if (!((string)HplBtQDLSVSbWoDHXHw(name)).Equals(string.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 6:
				if (string.IsNullOrEmpty(name))
				{
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 4;
			case 7:
				Contract.ServiceNotNull(TransformationProvider, (string)vMfILkDeHj9N57q3Tui(--230863782 ^ 0xDC2E912));
				num2 = 6;
				continue;
			case 3:
				return false;
			default:
				if (!((Dialect)xQOWivK3YEpNGE5khEF(TransformationProvider)).IsReservedWord(name))
				{
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 2;
			case 9:
				return true;
			case 5:
			case 8:
				break;
			}
			errorMessage = SR.T((string)vMfILkDeHj9N57q3Tui(-2125832759 ^ -2125854075));
			num2 = 3;
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<ICustomActivityHeader>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule, type);
			exportRule.PropertyName = (string)vMfILkDeHj9N57q3Tui(--192118127 ^ 0xB732657);
			exportRule.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule2, type);
			ehRdmLKxd25hbm1GvhC(exportRule2, vMfILkDeHj9N57q3Tui(-182059571 ^ -182081891));
			p6Es43KFTvuQF6Ho9Ub(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule3, type);
			ehRdmLKxd25hbm1GvhC(exportRule3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51B6C0BE ^ 0x51B69784));
			exportRule3.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule4, type);
			ehRdmLKxd25hbm1GvhC(exportRule4, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125832759 ^ -2125855675));
			p6Es43KFTvuQF6Ho9Ub(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule5, type);
			ehRdmLKxd25hbm1GvhC(exportRule5, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68C900C0 ^ 0x68C957D4));
			exportRule5.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule5);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			ehRdmLKxd25hbm1GvhC(obj, vMfILkDeHj9N57q3Tui(-92270799 ^ -92251827));
			obj.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj);
			ExportRule exportRule6 = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule6, type);
			exportRule6.PropertyName = (string)vMfILkDeHj9N57q3Tui(-2038986505 ^ -2038964269);
			p6Es43KFTvuQF6Ho9Ub(exportRule6, ExportRuleType.Export);
			exportRuleList.Add(exportRule6);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			ehRdmLKxd25hbm1GvhC(obj2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C9503E1 ^ 0x2C95588B));
			p6Es43KFTvuQF6Ho9Ub(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule exportRule7 = new ExportRule();
			DstOW0KhntvQouqpndJ(exportRule7, type);
			ehRdmLKxd25hbm1GvhC(exportRule7, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x82E000E ^ 0x82E53DC));
			p6Es43KFTvuQF6Ho9Ub(exportRule7, ExportRuleType.Export);
			exportRuleList.Add(exportRule7);
			return exportRuleList;
		}
	}

	public CustomActivityCommonStatistics GetCommonStatistics()
	{
		CustomActivityCommonStatistics customActivityCommonStatistics = new CustomActivityCommonStatistics();
		UMFJigKwTW4nA58JL2Q(customActivityCommonStatistics, ReturnCount(((ICriteria)VUEn1dD55nEK1gqhJge(TfG0ydD7Fmo85OouSDA(this, null), dTX1akK8uiu5Z6QxYRY(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1060279669 ^ 0x3F32C251)))).Add((ICriterion)AQewklDg5of5adEmq4m(vMfILkDeHj9N57q3Tui(0x2772A0C0 ^ 0x2772F7FA), false))));
		hQGATMKsdAT57DGx9fD(customActivityCommonStatistics, L5LbDAKtBiFNIGCU1Nk(this, VUEn1dD55nEK1gqhJge(TfG0ydD7Fmo85OouSDA(this, null), AQewklDg5of5adEmq4m(vMfILkDeHj9N57q3Tui(0x3F8E27D0 ^ 0x3F8E70EA), true))));
		hCw9OaKQNZ4re0lact0(customActivityCommonStatistics, L5LbDAKtBiFNIGCU1Nk(this, VUEn1dD55nEK1gqhJge(CreateCriteria().Add((ICriterion)PPDHh6KqwgmUNqRwpTd(AQewklDg5of5adEmq4m(vMfILkDeHj9N57q3Tui(-465190147 ^ -465200765), true), cHKRHpK20ZhZDlOtqU7(vMfILkDeHj9N57q3Tui(0x2772A0C0 ^ 0x2772F7E4)))), AQewklDg5of5adEmq4m(vMfILkDeHj9N57q3Tui(0xE6AF0C2 ^ 0xE6AA7F8), false))));
		return customActivityCommonStatistics;
	}

	public virtual IEnumerable<ICustomActivityHeader> FindDeleted()
	{
		return CreateDeletedCriteria().List<ICustomActivityHeader>();
	}

	protected virtual ICriteria CreateDeletedCriteria()
	{
		return (ICriteria)VUEn1dD55nEK1gqhJge(TfG0ydD7Fmo85OouSDA(this, null), AQewklDg5of5adEmq4m(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1683072034 ^ -1683092252), true));
	}

	public CustomActivityHeaderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EDCRxQKV4b7h4nagUcl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pyJPWSDWijD89mRaDcb()
	{
		return fMNL8CDBku5DGDHhcXq == null;
	}

	internal static CustomActivityHeaderManager YEItNNDHAVu3O5fy9Gg()
	{
		return fMNL8CDBku5DGDHhcXq;
	}

	internal static object vMfILkDeHj9N57q3Tui(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WDQ60RDi9k5kL2nfXIv(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object C2Kl2gDubP6PEmqLAcW(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static int XJZMrODlvGQ0gSRQ7aN(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object MSwwEDDfRHihvl1IdGP(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object HplBtQDLSVSbWoDHXHw(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool eR931pDJ92ptmM08MJ9(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object OF0eeQDrkqV7SDV8A75(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object TfG0ydD7Fmo85OouSDA(object P_0, object P_1)
	{
		return ((EntityManager<ICustomActivityHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object VUEn1dD55nEK1gqhJge(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object AQewklDg5of5adEmq4m(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static bool CqX6BBD1IXEa8nJ2pH5(object P_0, object P_1)
	{
		return ((EntityManager<ICustomActivityHeader, long>)P_0).ReturnExists((ICriteria)P_1);
	}

	internal static bool LbOR0RDIILQkmlfwlxF(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object WnWctyDZvkMT9l7GvGU(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static char KTLCMADzmQTyCeufZwb(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static bool nsMoSmKEBjUqbCRxg5v(char P_0)
	{
		return char.IsNumber(P_0);
	}

	internal static bool Uj1xxvKCVxQSAbnfA8d(object P_0)
	{
		return CSharpHelper.IsKeyword((string)P_0);
	}

	internal static object rNkA1eKXy8GK6NvFm4X(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object XC7oWMKogOJB6QUdp64(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((string)P_0, P_1);
	}

	internal static object xQOWivK3YEpNGE5khEF(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static void DstOW0KhntvQouqpndJ(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void ehRdmLKxd25hbm1GvhC(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void p6Es43KFTvuQF6Ho9Ub(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static object dTX1akK8uiu5Z6QxYRY(object P_0)
	{
		return Restrictions.IsNotNull((string)P_0);
	}

	internal static void UMFJigKwTW4nA58JL2Q(object P_0, long value)
	{
		((CustomActivityCommonStatistics)P_0).PublishedCount = value;
	}

	internal static long L5LbDAKtBiFNIGCU1Nk(object P_0, object P_1)
	{
		return ((EntityManager<ICustomActivityHeader, long>)P_0).ReturnCount((ICriteria)P_1);
	}

	internal static void hQGATMKsdAT57DGx9fD(object P_0, long value)
	{
		((CustomActivityCommonStatistics)P_0).DeletedCount = value;
	}

	internal static object cHKRHpK20ZhZDlOtqU7(object P_0)
	{
		return Restrictions.IsNull((string)P_0);
	}

	internal static object PPDHh6KqwgmUNqRwpTd(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static void hCw9OaKQNZ4re0lact0(object P_0, long value)
	{
		((CustomActivityCommonStatistics)P_0).DraftsCount = value;
	}

	internal static void EDCRxQKV4b7h4nagUcl()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
