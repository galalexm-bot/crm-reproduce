using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Diagrams.Elements;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Validation;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class OrganizationModelManager : EntityManager<IOrganizationModel, int>
{
	private class DuplicateElement
	{
		public Guid Uid;

		public object Name;

		public Guid SubDiagram;

		internal static object tijrvrpwCF7dqHrBVb5K;

		public DuplicateElement()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ob0OtApwJhUPVoKgkEw4();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void ob0OtApwJhUPVoKgkEw4()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool S50W2ipwUrDpU0pkLtfE()
		{
			return tijrvrpwCF7dqHrBVb5K == null;
		}

		internal static DuplicateElement Q4jHRHpwodjmswbOxxLh()
		{
			return (DuplicateElement)tijrvrpwCF7dqHrBVb5K;
		}
	}

	private List<OrganizationValidationMessage> messages;

	private List<Guid> ListTreeElement;

	private static Regex regexN;

	internal static OrganizationModelManager LTUgfS4Lsnhcd9nJKWh;

	public new IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ICacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
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

	public new static OrganizationModelManager Instance => Locator.GetServiceNotNull<OrganizationModelManager>();

	public ICollection<OrganizationValidationMessage> Messages => messages;

	public bool HasErrors => messages.Count((OrganizationValidationMessage m) => _003C_003Ec.zhTZZdpw0IS4xTMEResK(m) == OrganizationValidationMessageType.Error) > 0;

	public bool HasWarning => messages.Count((OrganizationValidationMessage m) => _003C_003Ec.zhTZZdpw0IS4xTMEResK(m) == OrganizationValidationMessageType.Warning) > 0;

	private bool ValidateOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CValidateOnly_003Ek__BackingField;
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
					_003CValidateOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
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

	public virtual int CurrentVersion => (int)H4973yVamjRJqQ1xUJQ(this) - 1;

	private IOrganizationModel GetDraft()
	{
		int num = 2;
		int num2 = num;
		int? num3 = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (num3.HasValue)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 3:
				if (num3.Value < 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return LoadOrNull(num3.Value);
			case 2:
				num3 = ((ICriteria)gr8I3p4wU5BE2UroTRj(exZRNU4aJt48FyOMPuh(this, null), new IProjection[1] { (IProjection)vU5ycN4R06GAeZWM7Rx(Projections.Id()) })).UniqueResult<int?>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return null;
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public override void Save(IOrganizationModel obj)
	{
		//Discarded unreachable code: IL_01b0
		int num = 11;
		int num2 = num;
		IOrganizationModel organizationModel = default(IOrganizationModel);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return;
			case 11:
				organizationModel = GetDraft();
				num2 = 10;
				break;
			case 6:
			{
				IOrganizationModel organizationModel5 = organizationModel;
				EleWise.ELMA.Security.Models.IUser currentUser;
				nwi5XJ4vo2OoHUlfI3w(obj, currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
				nwi5XJ4vo2OoHUlfI3w(organizationModel5, currentUser);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
			case 4:
				K4Z0RS4C2f3v46TFZHu(organizationModel, null);
				num2 = 8;
				break;
			case 7:
			{
				IOrganizationModel organizationModel2 = organizationModel;
				EleWise.ELMA.Security.Models.IUser currentUser;
				nwi5XJ4vo2OoHUlfI3w(obj, currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
				organizationModel2.ChangeAuthor = currentUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 8:
				organizationModel.Diagram = (OrganizationDiagram)M0LM9J4UmptKegPog4c(obj);
				num2 = 5;
				break;
			case 2:
			{
				IOrganizationModel organizationModel4 = organizationModel;
				DateTime value;
				mord8o4PiGw2E9CyXIO(obj, value = XIrRbi42U1DdDpiuBMO());
				mord8o4PiGw2E9CyXIO(organizationModel4, value);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 5:
				organizationModel.SubDiagrams = (OrganizationSubDiagram)o30BfK4owa24SbeZMda(obj);
				num2 = 3;
				break;
			default:
				organizationModel = Create();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
				{
					num2 = 2;
				}
				break;
			case 10:
				if (organizationModel == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 12;
			case 12:
			{
				IOrganizationModel organizationModel3 = organizationModel;
				DateTime value;
				mord8o4PiGw2E9CyXIO(obj, value = XIrRbi42U1DdDpiuBMO());
				organizationModel3.ChangeDate = value;
				num2 = 7;
				break;
			}
			case 3:
				hrpM2G4JnYlXJtIf6YQ(base.Session, organizationModel);
				num2 = 9;
				break;
			}
		}
	}

	public virtual IOrganizationModel Load()
	{
		int num = 1;
		int num2 = num;
		IOrganizationModel draft = default(IOrganizationModel);
		IOrganizationModel organizationModel;
		while (true)
		{
			switch (num2)
			{
			case 1:
				draft = GetDraft();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				organizationModel = draft;
				if (organizationModel == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
			{
				InstanceOf<IOrganizationModel> instanceOf = new InstanceOf<IOrganizationModel>();
				eI1AuU4KOGmQQxD5SjU(instanceOf.New, new OrganizationDiagram());
				organizationModel = instanceOf.New;
				break;
			}
			}
			break;
		}
		return organizationModel;
	}

	public virtual IOrganizationModel LoadPublishedOrNull()
	{
		//Discarded unreachable code: IL_006b
		int num = 1;
		int num2 = num;
		int? num3 = default(int?);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!num3.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 2:
			case 4:
				return null;
			case 3:
				if (num3.Value > 1)
				{
					return LoadOrNull(num3.Value);
				}
				num2 = 4;
				break;
			case 1:
				num3 = ((ICriteria)gr8I3p4wU5BE2UroTRj(exZRNU4aJt48FyOMPuh(this, null), new IProjection[1] { (IProjection)NAExXf4hv9h1n7kfkM8(mw0I6x4tWA7oZFc7gdi()) })).UniqueResult<int?>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual ICollection<OrganizationVersionDTO> FindAllVersions()
	{
		return CreateCriteria().SetProjection((IProjection[])(object)new IProjection[4]
		{
			(IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x50A2A0A3 ^ 0x50A2B0B3)),
			(IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4177C82C ^ 0x41779336)),
			(IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46F7DF98 ^ 0x46F79500)),
			(IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-736288531 ^ -736256283))
		}).AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1642017152 ^ -1642013040))).List<object[]>()
			.Select(delegate(object[] i)
			{
				OrganizationVersionDTO obj = new OrganizationVersionDTO
				{
					Id = (int)i[0]
				};
				_003C_003Ec.eTKg5fpwqMfK9V3c3v0m(obj, (DateTime)i[1]);
				obj.CreationAuthor = (string)((i[2] is EleWise.ELMA.Security.Models.IUser) ? _003C_003Ec.oIIObrpwcXHkv87hprLy((EleWise.ELMA.Security.Models.IUser)i[2]) : string.Empty);
				_003C_003Ec.qC6SN9pwGVqjQJPoQOiv(obj, (string)i[3]);
				return obj;
			})
			.ToArray();
	}

	private void addSubElement(Element elementParent, OrganizationDiagram draftDiagram, OrganizationSubDiagram subDiagram)
	{
		//Discarded unreachable code: IL_002f, IL_00cd, IL_00dc, IL_0122, IL_0131, IL_025e, IL_0296, IL_02a5, IL_039c, IL_03d2, IL_0461, IL_0474, IL_0483
		int num = 1;
		int num2 = num;
		List<OrganizationSubDiagrams>.Enumerator enumerator = default(List<OrganizationSubDiagrams>.Enumerator);
		List<Element> list = default(List<Element>);
		IEnumerator<Element> enumerator2 = default(IEnumerator<Element>);
		OrganizationSubDiagrams current = default(OrganizationSubDiagrams);
		Element current2 = default(Element);
		Connector item = default(Connector);
		NestedStructureElement nestedStructureElement = default(NestedStructureElement);
		OrgConnectorElement orgConnectorElement = default(OrgConnectorElement);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = subDiagram.OrganizationSubDiagrams.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 10;
						goto IL_0041;
					}
					goto IL_0374;
					IL_0041:
					while (true)
					{
						switch (num3)
						{
						case 10:
							return;
						case 1:
							if (CxWs7A4GCeQbyjPiX92(list) <= 0)
							{
								num3 = 4;
								continue;
							}
							goto case 12;
						case 6:
							enumerator2 = ((ElementList)uLLsji4cIXYOGRkEf58(current.OrganizationSubDiagram)).GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
							{
								num3 = 11;
							}
							continue;
						case 11:
							try
							{
								while (true)
								{
									IL_01d3:
									int num6;
									if (!u0m6wM4M5GVFqBXpRuO(enumerator2))
									{
										int num5 = 5;
										num6 = num5;
										goto IL_00eb;
									}
									goto IL_0163;
									IL_00eb:
									while (true)
									{
										switch (num6)
										{
										case 3:
										case 6:
											C3Xopt40mvCPqgd4rCU(draftDiagram.Elements, current2);
											num6 = 9;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
											{
												num6 = 4;
											}
											continue;
										case 4:
											break;
										default:
											current2.InputConnectors.Add(item);
											num6 = 6;
											continue;
										case 1:
											if (nestedStructureElement != null)
											{
												num6 = 8;
												continue;
											}
											goto IL_01d3;
										case 8:
											addSubElement(nestedStructureElement, draftDiagram, subDiagram);
											num6 = 7;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
											{
												num6 = 3;
											}
											continue;
										case 7:
											goto IL_01d3;
										case 9:
											nestedStructureElement = current2 as NestedStructureElement;
											num6 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
											{
												num6 = 1;
											}
											continue;
										case 2:
											if (!ChIlBL4q5QBmlBbTNmv(iNA3SE4OpJM3FcyeNlK(current2), iNA3SE4OpJM3FcyeNlK(list[0])))
											{
												num6 = 3;
												continue;
											}
											goto default;
										case 5:
											goto end_IL_01d3;
										}
										break;
									}
									goto IL_0163;
									IL_0163:
									current2 = enumerator2.Current;
									num6 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
									{
										num6 = 2;
									}
									goto IL_00eb;
									continue;
									end_IL_01d3:
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									int num7 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										default:
											vf623m4s8PeyGiBC8as(enumerator2);
											num7 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
											{
												num7 = 0;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							break;
						case 2:
							if (!ChIlBL4q5QBmlBbTNmv(current.Id, iNA3SE4OpJM3FcyeNlK(elementParent)))
							{
								int num4 = 13;
								num3 = num4;
								continue;
							}
							goto case 9;
						case 8:
							elementParent.OutputConnectors.Add(item);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
							{
								num3 = 6;
							}
							continue;
						case 12:
						{
							OrgConnectorElement orgConnectorElement2 = new OrgConnectorElement();
							YOOZgn4FpfkOPIUxx9V(orgConnectorElement2, Guid.NewGuid());
							orgConnectorElement = orgConnectorElement2;
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
							{
								num3 = 3;
							}
							continue;
						}
						case 4:
						case 7:
						case 13:
							break;
						default:
						{
							Connector connector = new Connector();
							BfVgSf4EVgUEisv6lHY(connector, list[0]);
							piHrQV4DDdpyjRvsFxU(connector, elementParent);
							item = connector;
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						case 5:
							goto IL_0374;
						case 3:
							C3Xopt40mvCPqgd4rCU(draftDiagram.Elements, orgConnectorElement);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
							{
								num3 = 0;
							}
							continue;
						case 9:
							list = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current.OrganizationSubDiagram)).Where(delegate(Element e)
							{
								int num9 = 1;
								int num10 = num9;
								while (true)
								{
									switch (num10)
									{
									case 1:
										if (!(e is OrganizationElement))
										{
											return false;
										}
										num10 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
										{
											num10 = 0;
										}
										break;
									default:
										return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) == 0;
									}
								}
							}).ToList();
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					continue;
					IL_0374:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
					{
						num3 = 2;
					}
					goto IL_0041;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num8 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num8 = 0;
				}
				switch (num8)
				{
				case 0:
					break;
				}
			}
		}
	}

	[Transaction]
	public virtual int Validate(IOrganizationModel organizationModels)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				int result = sq2rJV4YvQAJ8ZwvWxw(this, organizationModels);
				ValidateOnly = false;
				return result;
			}
			case 1:
				ValidateOnly = true;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual int Publish(IOrganizationModel organizationModel)
	{
		//Discarded unreachable code: IL_004c, IL_007e, IL_0095, IL_00a4
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					num3 = PublishWarning(organizationModel);
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
				catch (OrganizationModelPublishWarning)
				{
					int num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
					{
						num5 = 0;
					}
					return num5 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
			default:
				return num3;
			case 2:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual int Publish(IOrganizationModel organizationModel, out OrganizationModelPublishWarning warning)
	{
		//Discarded unreachable code: IL_007d, IL_00b0, IL_00e9, IL_00f8
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				warning = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				num3 = 0;
				num2 = 2;
				break;
			default:
				return num3;
			case 1:
				try
				{
					num3 = PublishWarning(organizationModel);
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
				catch (OrganizationModelPublishWarning organizationModelPublishWarning)
				{
					int num5 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return num3;
						case 0:
							return num3;
						case 1:
							warning = organizationModelPublishWarning;
							num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				}
			}
		}
	}

	[Transaction]
	public virtual int Validate(IOrganizationModel organizationModel, out OrganizationModelPublishWarning warning)
	{
		//Discarded unreachable code: IL_006b, IL_00eb, IL_0124, IL_0133
		int num = 3;
		int num2 = num;
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				warning = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return result;
			case 3:
				result = 0;
				num2 = 2;
				continue;
			}
			try
			{
				ValidateOnly = true;
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						ValidateOnly = false;
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
						{
							num3 = 1;
						}
						break;
					default:
						result = Publish(organizationModel, out warning);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
						{
							num3 = 2;
						}
						break;
					case 1:
						return result;
					}
				}
			}
			catch (OrganizationModelPublishWarning organizationModelPublishWarning)
			{
				int num4 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						warning = organizationModelPublishWarning;
						num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
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
		}
	}

	private int PublishWarning(IOrganizationModel organizationModels)
	{
		//Discarded unreachable code: IL_02cb, IL_0332, IL_0341, IL_0495, IL_04a4, IL_052e, IL_053e, IL_0548, IL_05f9, IL_060c, IL_061b, IL_0746, IL_0755, IL_0760, IL_0784, IL_078e, IL_0873, IL_0882, IL_09bf, IL_09f7, IL_0a06, IL_0a75, IL_0ab5, IL_0ac4, IL_0ad0, IL_0b25, IL_0bc7, IL_0bd6, IL_0be7, IL_0bf6, IL_0c6d, IL_0c77, IL_0d3c, IL_0d4f, IL_0e1a, IL_0e97, IL_0ee2, IL_0ef1, IL_0f01, IL_0f21, IL_0f86, IL_1048, IL_1080, IL_10db, IL_111f, IL_1129, IL_120b, IL_121a, IL_124b, IL_1283, IL_1292, IL_1338, IL_140b, IL_1452, IL_14f3, IL_14fd, IL_155c, IL_15db, IL_15ef, IL_15fe, IL_1609, IL_167d, IL_168c, IL_16fc, IL_170f, IL_171e, IL_1812, IL_1821, IL_1832, IL_1841, IL_18fc, IL_190f, IL_191e, IL_194f, IL_1987, IL_1f18, IL_1f2b, IL_1f3e, IL_1f4d, IL_1fad, IL_1fbc, IL_1fc7, IL_2139, IL_2149, IL_2158, IL_2163, IL_22a1, IL_22b4, IL_22c3, IL_22d3, IL_22f8, IL_2375, IL_2384, IL_2427, IL_246f, IL_247e, IL_24cd, IL_259f, IL_2626, IL_2635, IL_266c, IL_267f, IL_268e, IL_2759, IL_2768, IL_2800, IL_2813, IL_2850, IL_292f, IL_293e, IL_2949, IL_29e5, IL_29f8, IL_2a07, IL_2a76, IL_2aa9, IL_2ab8, IL_2ac3, IL_2b83, IL_2b96, IL_2ba5, IL_2c19, IL_2c49, IL_2c68, IL_2c77, IL_2c94, IL_2ca3, IL_2db7, IL_2dc6, IL_2dd1, IL_2e18, IL_2e27, IL_300f, IL_3047, IL_3057, IL_3066, IL_3071, IL_3116, IL_31a1, IL_32aa, IL_32b4, IL_32e0, IL_32ea, IL_3315, IL_33d2, IL_33e5, IL_33f4, IL_3444, IL_3453, IL_34c7, IL_34ff, IL_3558, IL_3567, IL_35a9, IL_3609, IL_3618, IL_3623, IL_36bf, IL_36d2, IL_36e1, IL_3715, IL_3725, IL_3734, IL_373f, IL_37b3, IL_37c2, IL_3861, IL_38a1, IL_38b0, IL_38bc, IL_391c, IL_39be, IL_39cd, IL_39dc, IL_39ec, IL_39fb, IL_3ad3, IL_3ae2, IL_3aed, IL_3b27, IL_3b36, IL_3c64, IL_3c73, IL_3d0d, IL_3d1c, IL_3d82, IL_3da1, IL_3db0, IL_3ddd, IL_3dec, IL_3e45, IL_3e85, IL_3e94, IL_3ea0, IL_3eaf, IL_4063, IL_4072, IL_407d, IL_4120, IL_4130, IL_413f, IL_414a, IL_41c3, IL_41d2, IL_4297, IL_42a6, IL_4332, IL_433c, IL_4412, IL_4491, IL_44a4, IL_44b4, IL_4521, IL_4530, IL_46b5, IL_46c4, IL_4780, IL_478f, IL_47c5, IL_47d8, IL_47e7, IL_4941, IL_4954, IL_4963, IL_49bd, IL_49d0, IL_49df, IL_4aac, IL_4abb, IL_4ae4, IL_4be1, IL_4beb, IL_4c4c, IL_4ce7, IL_4d7b, IL_4d8a, IL_4e37, IL_4e41, IL_4fb4, IL_4fec, IL_5021, IL_5030, IL_50b0, IL_50c3, IL_5121, IL_5134, IL_5162, IL_5171
		int num = 73;
		List<Element> list4 = default(List<Element>);
		string text8 = default(string);
		List<Guid> list12 = default(List<Guid>);
		List<string> list13 = default(List<string>);
		IEnumerator<Element> enumerator = default(IEnumerator<Element>);
		OrganizationDiagram organizationDiagram = default(OrganizationDiagram);
		string text24 = default(string);
		IOrganizationModel organizationModel = default(IOrganizationModel);
		string text21 = default(string);
		List<OrganizationSubDiagrams>.Enumerator enumerator4 = default(List<OrganizationSubDiagrams>.Enumerator);
		OrganizationSubDiagrams current10 = default(OrganizationSubDiagrams);
		List<Element>.Enumerator enumerator3 = default(List<Element>.Enumerator);
		List<Element> list3 = default(List<Element>);
		List<OrganizationElement> list20 = default(List<OrganizationElement>);
		string text13 = default(string);
		List<Guid> list19 = default(List<Guid>);
		List<Element> list17 = default(List<Element>);
		Element current14 = default(Element);
		string text16 = default(string);
		string text14 = default(string);
		string text10 = default(string);
		string text12 = default(string);
		string text11 = default(string);
		IEnumerator<IGrouping<string, Element>> enumerator8 = default(IEnumerator<IGrouping<string, Element>>);
		List<DuplicateElement> list25 = default(List<DuplicateElement>);
		Element current15 = default(Element);
		List<DuplicateElement> list24 = default(List<DuplicateElement>);
		Dictionary<string, List<DuplicateElement>> dictionary = default(Dictionary<string, List<DuplicateElement>>);
		string text18 = default(string);
		string text15 = default(string);
		List<OrganizationElement> list21 = default(List<OrganizationElement>);
		DepartmentElement departmentElement = default(DepartmentElement);
		List<Connector>.Enumerator enumerator2 = default(List<Connector>.Enumerator);
		OrganizationElement organizationElement2 = default(OrganizationElement);
		string text17 = default(string);
		Guid[] itemUids = default(Guid[]);
		List<Element> list18 = default(List<Element>);
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_3 = default(_003C_003Ec__DisplayClass31_0);
		List<Element> list16 = default(List<Element>);
		OrganizationElement element3 = default(OrganizationElement);
		Element current11 = default(Element);
		List<Connector> list23 = default(List<Connector>);
		Connector current13 = default(Connector);
		OrganizationElement organizationElement3 = default(OrganizationElement);
		Connector current12 = default(Connector);
		List<string>.Enumerator enumerator5 = default(List<string>.Enumerator);
		string current4 = default(string);
		List<Guid> list9 = default(List<Guid>);
		string text4 = default(string);
		string text3 = default(string);
		List<IGrouping<string, string>>.Enumerator enumerator6 = default(List<IGrouping<string, string>>.Enumerator);
		int num13 = default(int);
		IGrouping<string, string> current5 = default(IGrouping<string, string>);
		List<DuplicateElement>.Enumerator enumerator7 = default(List<DuplicateElement>.Enumerator);
		_003C_003Ec__DisplayClass31_3 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_3);
		List<string> list8 = default(List<string>);
		List<OrganizationSubDiagrams> list11 = default(List<OrganizationSubDiagrams>);
		OrganizationSubDiagram organizationSubDiagram = default(OrganizationSubDiagram);
		Guid guid = default(Guid);
		OrganizationElement organizationElement = default(OrganizationElement);
		Element current = default(Element);
		Connector current2 = default(Connector);
		List<Connector> list2 = default(List<Connector>);
		int num9 = default(int);
		Connector current3 = default(Connector);
		Filter filter = default(Filter);
		string text = default(string);
		IEnumerator<IOrganizationItem> enumerator9 = default(IEnumerator<IOrganizationItem>);
		ICollection<IOrganizationItem> collection = default(ICollection<IOrganizationItem>);
		IOrganizationItem current16 = default(IOrganizationItem);
		List<IOrganizationItem> list14 = default(List<IOrganizationItem>);
		string text20 = default(string);
		Guid[] array = default(Guid[]);
		DepartmentElement departmentElement2 = default(DepartmentElement);
		List<OrganizationElement> list26 = default(List<OrganizationElement>);
		OrganizationElement organizationElement4 = default(OrganizationElement);
		List<Element> list7 = default(List<Element>);
		string text6 = default(string);
		Element current6 = default(Element);
		_003C_003Ec__DisplayClass31_1 _003C_003Ec__DisplayClass31_2 = default(_003C_003Ec__DisplayClass31_1);
		OrganizationElement element = default(OrganizationElement);
		List<Element> list = default(List<Element>);
		List<Element> list5 = default(List<Element>);
		List<DuplicateElement> list33 = default(List<DuplicateElement>);
		Element current20 = default(Element);
		List<DuplicateElement> list32 = default(List<DuplicateElement>);
		string text5 = default(string);
		List<OrganizationElement> list6 = default(List<OrganizationElement>);
		OrganizationElement element2 = default(OrganizationElement);
		string text19 = default(string);
		OrganizationSubDiagrams current19 = default(OrganizationSubDiagrams);
		string current17 = default(string);
		string text23 = default(string);
		string text22 = default(string);
		List<Guid> list29 = default(List<Guid>);
		List<string> list28 = default(List<string>);
		Guid guid2 = default(Guid);
		int num62 = default(int);
		IGrouping<string, string> current18 = default(IGrouping<string, string>);
		List<OrganizationSubDiagrams> list31 = default(List<OrganizationSubDiagrams>);
		_003C_003Ec__DisplayClass31_2 _003C_003Ec__DisplayClass31_4 = default(_003C_003Ec__DisplayClass31_2);
		string text2 = default(string);
		List<OrganizationElement> elementsStack = default(List<OrganizationElement>);
		string text9 = default(string);
		Element current7 = default(Element);
		List<Element> list15 = default(List<Element>);
		OrgConnectorElement orgConnectorElement = default(OrgConnectorElement);
		OrganizationSubDiagrams current8 = default(OrganizationSubDiagrams);
		Connector item = default(Connector);
		Element current9 = default(Element);
		NestedStructureElement nestedStructureElement = default(NestedStructureElement);
		string text7 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object message;
				switch (num2)
				{
				case 13:
					if (ValidateOnly)
					{
						num2 = 52;
						continue;
					}
					goto case 35;
				case 78:
					if (CxWs7A4GCeQbyjPiX92(list4) <= 0)
					{
						num2 = 62;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
						{
							num2 = 82;
						}
						continue;
					}
					goto case 68;
				case 51:
					if (ValidateOnly)
					{
						num2 = 84;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
						{
							num2 = 84;
						}
						continue;
					}
					goto case 110;
				case 77:
				case 112:
				{
					ICollection<OrganizationValidationMessage> collection7 = Messages;
					OrganizationValidationMessage obj = new OrganizationValidationMessage
					{
						Type = OrganizationValidationMessageType.Error
					};
					oFqtyr43BqZMfDqVpIy(obj, text8);
					oRcApG4yX38ovhdO5k6(obj, K5KdRuVAkDCv7eQpf2E(list12));
					collection7.Add(obj);
					num2 = 14;
					continue;
				}
				case 50:
				case 97:
					if (WobgbuVno6yETin3Pap(list13) > 0)
					{
						num2 = 20;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 102;
				case 43:
					enumerator = ((ElementList)uLLsji4cIXYOGRkEf58(organizationDiagram)).GetEnumerator();
					num2 = 57;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num2 = 41;
					}
					continue;
				case 8:
					dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), SR.T((string)VSJoWR4geFYnrKAMb4u(-192929954 ^ -192881156), text24));
					num2 = 62;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num2 = 9;
					}
					continue;
				case 111:
					K4Z0RS4C2f3v46TFZHu(organizationModel, text21);
					num2 = 92;
					continue;
				case 107:
					try
					{
						while (true)
						{
							int num30;
							if (!enumerator4.MoveNext())
							{
								num30 = 49;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
								{
									num30 = 5;
								}
								goto IL_0350;
							}
							goto IL_1415;
							IL_1415:
							current10 = enumerator4.Current;
							num30 = 60;
							goto IL_0350;
							IL_0350:
							while (true)
							{
								int num31;
								switch (num30)
								{
								case 54:
									enumerator3 = list3.GetEnumerator();
									num30 = 32;
									continue;
								case 47:
									if (tXVp0X4SovxlnPKviT1(list20) <= 0)
									{
										num30 = 16;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
										{
											num30 = 33;
										}
										continue;
									}
									goto case 39;
								case 48:
								{
									ICollection<OrganizationValidationMessage> collection9 = Messages;
									OrganizationValidationMessage organizationValidationMessage6 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage6, OrganizationValidationMessageType.Error);
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage6, text13);
									oRcApG4yX38ovhdO5k6(organizationValidationMessage6, K5KdRuVAkDCv7eQpf2E(list19));
									HKfjaH4b4ET5wOCOU2j(organizationValidationMessage6, current10.Id);
									collection9.Add(organizationValidationMessage6);
									num30 = 6;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
									{
										num30 = 6;
									}
									continue;
								}
								case 28:
									if (list17.Count <= 1)
									{
										num30 = 23;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
										{
											num30 = 11;
										}
										continue;
									}
									goto case 56;
								case 32:
									try
									{
										while (true)
										{
											int num46;
											if (!enumerator3.MoveNext())
											{
												num46 = 2;
												goto IL_054c;
											}
											goto IL_057c;
											IL_054c:
											while (true)
											{
												switch (num46)
												{
												case 3:
													goto IL_057c;
												case 1:
													VRCg5B4T13g0ehZL2PN(uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram), current14);
													num46 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
													{
														num46 = 0;
													}
													continue;
												case 2:
													goto end_IL_0566;
												}
												break;
											}
											continue;
											IL_057c:
											current14 = enumerator3.Current;
											num46 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
											{
												num46 = 1;
											}
											goto IL_054c;
											continue;
											end_IL_0566:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num47 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
										{
											num47 = 0;
										}
										switch (num47)
										{
										case 0:
											break;
										}
									}
									goto case 15;
								case 46:
									if (ValidateOnly)
									{
										num30 = 37;
										continue;
									}
									goto case 42;
								case 21:
									list19 = new List<Guid>();
									num30 = 62;
									continue;
								case 19:
									EleWise.ELMA.Logging.Logger.Log.Error(O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x4D3A45F ^ 0x4D366FD), new object[1] { text16 }));
									num30 = 17;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
									{
										num30 = 7;
									}
									continue;
								case 3:
									text14 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x38328F00 ^ 0x38324B00), new object[1] { text10 });
									num30 = 9;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
									{
										num30 = 24;
									}
									continue;
								case 59:
									text12 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(-566078848 ^ -566061314), new object[1] { text11 });
									num30 = 46;
									continue;
								case 13:
									qgWnkC4Q7Vy9N8NKVSb(current10.OrganizationSubDiagram);
									num30 = 4;
									continue;
								case 4:
									new List<Element>();
									num30 = 12;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
									{
										num30 = 12;
									}
									continue;
								case 41:
									try
									{
										while (true)
										{
											int num48;
											if (!enumerator8.MoveNext())
											{
												num48 = 2;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 != 0)
												{
													num48 = 1;
												}
												goto IL_0764;
											}
											goto IL_0a11;
											IL_0a11:
											enumerator = enumerator8.Current.GetEnumerator();
											num48 = 3;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
											{
												num48 = 0;
											}
											goto IL_0764;
											IL_0764:
											switch (num48)
											{
											case 3:
												try
												{
													while (true)
													{
														IL_0927:
														int num49;
														if (!u0m6wM4M5GVFqBXpRuO(enumerator))
														{
															num49 = 2;
															goto IL_0792;
														}
														goto IL_08b3;
														IL_0792:
														while (true)
														{
															switch (num49)
															{
															case 12:
																list25.Add(new DuplicateElement
																{
																	Uid = current15.Uid,
																	Name = current15.Name,
																	SubDiagram = current10.Id
																});
																num49 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
																{
																	num49 = 13;
																}
																continue;
															default:
																list24 = new List<DuplicateElement>();
																num49 = 9;
																continue;
															case 1:
																list13.Add((string)LyF55CVkjHRrJSmpFkK(g8Zcx44zxGCs9482XT8(current15)));
																num49 = 12;
																continue;
															case 13:
																dictionary[(string)LyF55CVkjHRrJSmpFkK(current15.Name)] = list25;
																num49 = 11;
																continue;
															case 4:
																if (nC52IsVpVSIH6v26DRy(list25) == 1)
																{
																	num49 = 1;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
																	{
																		num49 = 1;
																	}
																	continue;
																}
																goto case 12;
															case 6:
																break;
															case 7:
																if (!dictionary.ContainsKey((string)LyF55CVkjHRrJSmpFkK(g8Zcx44zxGCs9482XT8(current15))))
																{
																	num49 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
																	{
																		num49 = 0;
																	}
																	continue;
																}
																goto case 10;
															case 10:
																list25 = dictionary[(string)LyF55CVkjHRrJSmpFkK(g8Zcx44zxGCs9482XT8(current15))];
																num49 = 4;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
																{
																	num49 = 0;
																}
																continue;
															case 3:
															case 11:
																goto IL_0927;
															case 9:
																list24.Add(new DuplicateElement
																{
																	Uid = current15.Uid,
																	Name = g8Zcx44zxGCs9482XT8(current15),
																	SubDiagram = current10.Id
																});
																num49 = 5;
																continue;
															case 5:
																dictionary.Add(((string)g8Zcx44zxGCs9482XT8(current15)).ToUpper(), list24);
																num49 = 3;
																continue;
															case 2:
																goto end_IL_0927;
															}
															break;
														}
														goto IL_08b3;
														IL_08b3:
														current15 = enumerator.Current;
														num49 = 7;
														goto IL_0792;
														continue;
														end_IL_0927:
														break;
													}
												}
												finally
												{
													if (enumerator != null)
													{
														int num50 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
														{
															num50 = 0;
														}
														while (true)
														{
															switch (num50)
															{
															default:
																vf623m4s8PeyGiBC8as(enumerator);
																num50 = 1;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
																{
																	num50 = 0;
																}
																continue;
															case 1:
																break;
															}
															break;
														}
													}
												}
												continue;
											case 1:
												continue;
											case 2:
												goto end_IL_0a39;
											}
											goto IL_0a11;
											continue;
											end_IL_0a39:
											break;
										}
									}
									finally
									{
										int num51;
										if (enumerator8 == null)
										{
											num51 = 2;
											goto IL_0a79;
										}
										goto IL_0a8f;
										IL_0a79:
										switch (num51)
										{
										case 2:
											goto end_IL_0a64;
										case 1:
											goto end_IL_0a64;
										}
										goto IL_0a8f;
										IL_0a8f:
										vf623m4s8PeyGiBC8as(enumerator8);
										num51 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
										{
											num51 = 1;
										}
										goto IL_0a79;
										end_IL_0a64:;
									}
									goto case 31;
								case 5:
									if (ch3Fh1V5wVZXFNQsXdf(uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)) > 0)
									{
										num30 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
										{
											num30 = 1;
										}
										continue;
									}
									break;
								case 40:
									if (!ValidateOnly)
									{
										num30 = 34;
										continue;
									}
									goto case 48;
								case 35:
									ListTreeElement = new List<Guid>();
									num30 = 26;
									continue;
								case 50:
									text16 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x45F3B9A1 ^ 0x45F37855), new object[2] { current10.Name, text18 });
									num30 = 38;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
									{
										num30 = 33;
									}
									continue;
								case 39:
									text15 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x51BB29A6 ^ 0x51BBEB4A), new object[1] { current10.Name });
									num30 = 53;
									continue;
								case 45:
									try
									{
										while (true)
										{
											IL_0e24:
											int num34;
											if (!u0m6wM4M5GVFqBXpRuO(enumerator))
											{
												num34 = 15;
												goto IL_0c05;
											}
											goto IL_0df9;
											IL_0e9c:
											list21.AddRange(departmentElement.Composition);
											int num35 = 3;
											goto IL_0c01;
											IL_0df9:
											departmentElement = enumerator.Current as DepartmentElement;
											num35 = 16;
											goto IL_0c01;
											IL_0c01:
											num34 = num35;
											goto IL_0c05;
											IL_0c05:
											while (true)
											{
												List<OrganizationElement> list22;
												switch (num34)
												{
												case 18:
													try
													{
														while (true)
														{
															int num36;
															if (!enumerator2.MoveNext())
															{
																num36 = 4;
																goto IL_0c7b;
															}
															goto IL_0ce3;
															IL_0c7b:
															while (true)
															{
																switch (num36)
																{
																case 1:
																	if (organizationElement2 != null)
																	{
																		num36 = 3;
																		continue;
																	}
																	break;
																case 3:
																	list21.Add(organizationElement2);
																	num36 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
																	{
																		num36 = 0;
																	}
																	continue;
																case 2:
																	goto IL_0ce3;
																case 4:
																	goto end_IL_0c99;
																}
																break;
															}
															continue;
															IL_0ce3:
															organizationElement2 = ARmFji41vUugm3PhcXQ(enumerator2.Current) as OrganizationElement;
															num36 = 1;
															if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
															{
																num36 = 1;
															}
															goto IL_0c7b;
															continue;
															end_IL_0c99:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator2).Dispose();
														int num37 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
														{
															num37 = 0;
														}
														switch (num37)
														{
														case 0:
															break;
														}
													}
													goto case 20;
												case 12:
													list21 = new List<OrganizationElement>();
													num34 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
													{
														num34 = 0;
													}
													continue;
												case 1:
													if (tXVp0X4SovxlnPKviT1(departmentElement.Composition) <= 0)
													{
														num34 = 17;
														continue;
													}
													goto IL_0e9c;
												case 2:
													text17 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x3E79A885 ^ 0x3E796BF5), new object[2]
													{
														g8Zcx44zxGCs9482XT8(departmentElement),
														current10.Name
													});
													num34 = 5;
													continue;
												case 3:
												case 17:
												case 21:
													enumerator2 = departmentElement.OutputConnectors.GetEnumerator();
													num34 = 15;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
													{
														num34 = 18;
													}
													continue;
												case 7:
													break;
												case 9:
												case 10:
													goto IL_0e24;
												case 8:
												case 11:
												{
													ICollection<OrganizationValidationMessage> collection11 = Messages;
													OrganizationValidationMessage organizationValidationMessage8 = new OrganizationValidationMessage();
													EN9QAg4rdY2wmqrRmQB(organizationValidationMessage8, OrganizationValidationMessageType.Error);
													oFqtyr43BqZMfDqVpIy(organizationValidationMessage8, text17);
													organizationValidationMessage8.ItemUids = itemUids;
													HKfjaH4b4ET5wOCOU2j(organizationValidationMessage8, current10.Id);
													collection11.Add(organizationValidationMessage8);
													num34 = 9;
													continue;
												}
												case 16:
													if (departmentElement != null)
													{
														goto case 12;
													}
													goto IL_0e7f;
												case 13:
													list22 = new List<OrganizationElement>();
													goto IL_100d;
												case 6:
													goto IL_0e9c;
												case 5:
													if (ValidateOnly)
													{
														num34 = 11;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
														{
															num34 = 11;
														}
														continue;
													}
													goto case 19;
												case 20:
													if (departmentElement != null)
													{
														num34 = 14;
														continue;
													}
													goto case 13;
												default:
													if (departmentElement.Composition == null)
													{
														num34 = 21;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
														{
															num34 = 20;
														}
														continue;
													}
													goto case 1;
												case 4:
													itemUids = new Guid[1] { iNA3SE4OpJM3FcyeNlK(departmentElement) };
													num34 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
													{
														num34 = 2;
													}
													continue;
												case 19:
													dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(-1076846736 ^ -1076863534), new object[1] { text17 }));
													num34 = 6;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
													{
														num34 = 8;
													}
													continue;
												case 14:
													list22 = list21.Where(delegate(OrganizationElement e)
													{
														int num84 = 1;
														int num85 = num84;
														while (true)
														{
															switch (num85)
															{
															default:
																return _003C_003Ec.wLRN2tpwMIlKl13x8HrD((PositionElement)e);
															case 1:
																if (!(e is PositionElement))
																{
																	return false;
																}
																num85 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
																{
																	num85 = 0;
																}
																break;
															}
														}
													}).ToList();
													goto IL_100d;
												case 15:
													goto end_IL_0e24;
													IL_100d:
													if (tXVp0X4SovxlnPKviT1(list22) > 1)
													{
														num34 = 4;
														continue;
													}
													goto IL_0e24;
												}
												break;
											}
											goto IL_0df9;
											IL_0e7f:
											num35 = 10;
											goto IL_0c01;
											continue;
											end_IL_0e24:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num38 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
											{
												num38 = 0;
											}
											while (true)
											{
												switch (num38)
												{
												default:
													enumerator.Dispose();
													num38 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
													{
														num38 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 10;
								case 29:
									if (list18.Count <= 0)
									{
										num30 = 27;
										continue;
									}
									goto case 22;
								default:
									dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), SR.T((string)VSJoWR4geFYnrKAMb4u(-1757426405 ^ -1757474887), text14));
									num30 = 16;
									continue;
								case 36:
									dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), O01qg748hr8alYZRb5G(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738EF2D1), new object[1] { text15 }));
									num30 = 57;
									continue;
								case 2:
									try
									{
										while (true)
										{
											int num32;
											if (!enumerator.MoveNext())
											{
												num32 = 3;
												goto IL_112d;
											}
											goto IL_11ae;
											IL_112d:
											while (true)
											{
												switch (num32)
												{
												default:
													list19.Add(iNA3SE4OpJM3FcyeNlK(_003C_003Ec__DisplayClass31_3.subElement));
													num32 = 4;
													continue;
												case 5:
													_003C_003Ec__DisplayClass31_3.subElement = enumerator.Current;
													num32 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
													{
														num32 = 1;
													}
													continue;
												case 2:
												case 4:
													break;
												case 6:
													goto IL_11ae;
												case 1:
													if (ListTreeElement.Any(_003C_003Ec__DisplayClass31_3._003CPublishWarning_003Eb__24))
													{
														num32 = 2;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
														{
															num32 = 2;
														}
														continue;
													}
													goto default;
												case 3:
													goto end_IL_1198;
												}
												break;
											}
											continue;
											IL_11ae:
											_003C_003Ec__DisplayClass31_3 = new _003C_003Ec__DisplayClass31_0();
											num32 = 3;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
											{
												num32 = 5;
											}
											goto IL_112d;
											continue;
											end_IL_1198:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num33 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
											{
												num33 = 0;
											}
											while (true)
											{
												switch (num33)
												{
												default:
													enumerator.Dispose();
													num33 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
													{
														num33 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 61;
								case 42:
									dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), O01qg748hr8alYZRb5G(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417D437C), new object[1] { text12 }));
									num30 = 11;
									continue;
								case 60:
									if (current10 != null)
									{
										num30 = 58;
										continue;
									}
									break;
								case 34:
									dKE7k04fgEnwkY2EGyH(EleWise.ELMA.Logging.Logger.Log, SR.T((string)VSJoWR4geFYnrKAMb4u(0x32A45635 ^ 0x32A49497), text13));
									num30 = 48;
									continue;
								case 14:
									if (CxWs7A4GCeQbyjPiX92(list16) <= 0)
									{
										num30 = 52;
										continue;
									}
									goto case 55;
								case 26:
									FindDoubleTree(element3, current10.OrganizationSubDiagram);
									num31 = 8;
									goto IL_034c;
								case 53:
									if (ValidateOnly)
									{
										num30 = 11;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
										{
											num30 = 25;
										}
										continue;
									}
									goto case 36;
								case 61:
									text13 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x397B0322 ^ 0x397BC642));
									num31 = 40;
									goto IL_034c;
								case 6:
								case 9:
								case 51:
									break;
								case 12:
									enumerator = current10.OrganizationSubDiagram.Elements.GetEnumerator();
									num30 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
									{
										num30 = 7;
									}
									continue;
								case 18:
									goto IL_1415;
								case 27:
								case 43:
									if (HasErrors)
									{
										num30 = 9;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
										{
											num30 = 8;
										}
										continue;
									}
									goto case 5;
								case 58:
									if (current10.OrganizationSubDiagram == null)
									{
										num30 = 48;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
										{
											num30 = 51;
										}
										continue;
									}
									goto case 13;
								case 38:
									if (!ValidateOnly)
									{
										num30 = 19;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
										{
											num30 = 9;
										}
										continue;
									}
									goto case 17;
								case 30:
								case 33:
									enumerator = ((ElementList)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).GetEnumerator();
									num30 = 45;
									continue;
								case 24:
									if (!ValidateOnly)
									{
										num30 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
										{
											num30 = 0;
										}
										continue;
									}
									goto case 16;
								case 7:
									try
									{
										while (true)
										{
											int num39;
											if (!u0m6wM4M5GVFqBXpRuO(enumerator))
											{
												num39 = 3;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
												{
													num39 = 9;
												}
												goto IL_1501;
											}
											goto IL_1775;
											IL_1775:
											current11 = enumerator.Current;
											num39 = 2;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
											{
												num39 = 2;
											}
											goto IL_1501;
											IL_1501:
											while (true)
											{
												switch (num39)
												{
												case 14:
													list3.Add(current11);
													num39 = 18;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
													{
														num39 = 14;
													}
													continue;
												case 17:
													list23 = new List<Connector>();
													num39 = 5;
													continue;
												case 1:
												case 10:
													break;
												case 3:
												case 8:
													if (current11 is OrgArtifactGroupElement)
													{
														num39 = 16;
														continue;
													}
													goto case 4;
												case 11:
													try
													{
														while (true)
														{
															int num43;
															if (!enumerator2.MoveNext())
															{
																num43 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
																{
																	num43 = 3;
																}
																goto IL_160d;
															}
															goto IL_16bd;
															IL_16bd:
															current13 = enumerator2.Current;
															num43 = 2;
															goto IL_160d;
															IL_160d:
															while (true)
															{
																switch (num43)
																{
																case 4:
																	list23.Add(current13);
																	num43 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
																	{
																		num43 = 0;
																	}
																	continue;
																case 2:
																	if (!(current13 is OrgConnectorElementAnnotation))
																	{
																		num43 = 5;
																		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
																		{
																			num43 = 0;
																		}
																		continue;
																	}
																	goto case 4;
																case 1:
																	goto IL_16bd;
																case 3:
																	goto end_IL_162f;
																}
																break;
															}
															continue;
															end_IL_162f:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator2).Dispose();
														int num44 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c != 0)
														{
															num44 = 0;
														}
														switch (num44)
														{
														case 0:
															break;
														}
													}
													goto default;
												case 2:
													if (!(current11 is OrganizationAnnotationElement))
													{
														num39 = 8;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
														{
															num39 = 1;
														}
														continue;
													}
													goto case 6;
												case 15:
												case 18:
													organizationElement3 = current11 as OrganizationElement;
													num39 = 12;
													continue;
												default:
													enumerator2 = list23.GetEnumerator();
													num39 = 13;
													continue;
												case 7:
													goto IL_1775;
												case 12:
													if (organizationElement3 == null)
													{
														num39 = 10;
														continue;
													}
													goto case 17;
												case 5:
													enumerator2 = organizationElement3.OutputConnectors.GetEnumerator();
													num39 = 11;
													continue;
												case 4:
													if (!(current11 is OrgConnectorElementAnnotation))
													{
														num39 = 15;
														continue;
													}
													goto case 14;
												case 16:
													list3.Add(current11);
													num39 = 4;
													continue;
												case 6:
													list3.Add(current11);
													num39 = 3;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
													{
														num39 = 1;
													}
													continue;
												case 13:
													try
													{
														while (true)
														{
															IL_1881:
															int num40;
															if (!enumerator2.MoveNext())
															{
																num40 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
																{
																	num40 = 0;
																}
																goto IL_1850;
															}
															goto IL_186a;
															IL_186a:
															current12 = enumerator2.Current;
															int num41 = 2;
															num40 = num41;
															goto IL_1850;
															IL_1850:
															while (true)
															{
																switch (num40)
																{
																case 1:
																	goto IL_186a;
																case 3:
																	goto IL_1881;
																case 2:
																	organizationElement3.OutputConnectors.Remove(current12);
																	num40 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
																	{
																		num40 = 3;
																	}
																	continue;
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
														((IDisposable)enumerator2).Dispose();
														int num42 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
														{
															num42 = 0;
														}
														switch (num42)
														{
														case 0:
															break;
														}
													}
													break;
												case 9:
													goto end_IL_159a;
												}
												break;
											}
											continue;
											end_IL_159a:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num45 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 != 0)
											{
												num45 = 0;
											}
											while (true)
											{
												switch (num45)
												{
												default:
													vf623m4s8PeyGiBC8as(enumerator);
													num45 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
													{
														num45 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 54;
								case 15:
									list17 = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).Where(delegate(Element e)
									{
										//Discarded unreachable code: IL_003e, IL_004d
										int num80 = 1;
										int num81 = num80;
										while (true)
										{
											switch (num81)
											{
											case 2:
												return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) == 0;
											default:
												return false;
											case 1:
												if (!(e is OrganizationElement))
												{
													num81 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
													{
														num81 = 0;
													}
													break;
												}
												goto case 2;
											}
										}
									}).ToList();
									num30 = 28;
									continue;
								case 56:
									text18 = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712587919 ^ -1712590097), list17.Select((Element e) => (string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)));
									num30 = 50;
									continue;
								case 17:
								{
									ICollection<OrganizationValidationMessage> collection13 = Messages;
									OrganizationValidationMessage organizationValidationMessage10 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage10, OrganizationValidationMessageType.Error);
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage10, text16);
									oRcApG4yX38ovhdO5k6(organizationValidationMessage10, list17.Select((Element e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray());
									HKfjaH4b4ET5wOCOU2j(organizationValidationMessage10, current10.Id);
									collection13.Add(organizationValidationMessage10);
									num30 = 20;
									continue;
								}
								case 20:
								case 23:
									list20 = ((IEnumerable)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).OfType<OrganizationElement>().Where(delegate(OrganizationElement e)
									{
										int num86 = 1;
										int num87 = num86;
										while (true)
										{
											switch (num87)
											{
											default:
												return string.IsNullOrWhiteSpace(e.Name);
											case 1:
												if (e == null)
												{
													return false;
												}
												num87 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
												{
													num87 = 0;
												}
												break;
											}
										}
									}).ToList();
									num30 = 47;
									continue;
								case 25:
								case 57:
								{
									ICollection<OrganizationValidationMessage> collection10 = Messages;
									OrganizationValidationMessage organizationValidationMessage7 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage7, OrganizationValidationMessageType.Error);
									organizationValidationMessage7.Message = text15;
									oRcApG4yX38ovhdO5k6(organizationValidationMessage7, list20.Select((OrganizationElement e) => e.Uid).ToArray());
									organizationValidationMessage7.SubDiagram = current10.Id;
									collection10.Add(organizationValidationMessage7);
									num30 = 30;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
									{
										num30 = 19;
									}
									continue;
								}
								case 10:
									list16 = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).Where(delegate(Element e)
									{
										//Discarded unreachable code: IL_0063, IL_0072
										int num82 = 2;
										int num83 = num82;
										while (true)
										{
											switch (num83)
											{
											default:
												return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) > 1;
											case 1:
												return false;
											case 2:
												if (!(e is OrganizationElement))
												{
													num83 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
													{
														num83 = 1;
													}
													break;
												}
												goto default;
											}
										}
									}).ToList();
									num30 = 14;
									continue;
								case 55:
									text10 = string.Join((string)VSJoWR4geFYnrKAMb4u(0x2CFDCC80 ^ 0x2CFDC51E), list16.Select((Element e) => (string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)));
									num31 = 3;
									goto IL_034c;
								case 16:
								{
									ICollection<OrganizationValidationMessage> collection12 = Messages;
									OrganizationValidationMessage organizationValidationMessage9 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage9, OrganizationValidationMessageType.Error);
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage9, text14);
									organizationValidationMessage9.ItemUids = list16.Select((Element e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray();
									organizationValidationMessage9.SubDiagram = current10.Id;
									collection12.Add(organizationValidationMessage9);
									num30 = 18;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
									{
										num30 = 44;
									}
									continue;
								}
								case 44:
								case 52:
									enumerator8 = (from e in ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).Where((Element e) => e is OrganizationElement).ToList()
										group e by ((string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)).ToUpper()).GetEnumerator();
									num30 = 41;
									continue;
								case 31:
									list18 = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).Where(delegate(Element e)
									{
										//Discarded unreachable code: IL_002d, IL_003c
										int num78 = 1;
										int num79 = num78;
										while (true)
										{
											switch (num79)
											{
											case 1:
												if (!(e is NestedStructureElement))
												{
													num79 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
													{
														num79 = 0;
													}
													break;
												}
												goto case 2;
											case 2:
												return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.OutputConnectors) != 0;
											default:
												return false;
											}
										}
									}).ToList();
									num30 = 29;
									continue;
								case 22:
									text11 = string.Join((string)VSJoWR4geFYnrKAMb4u(0x2CFDCC80 ^ 0x2CFDC51E), list18.Select((Element e) => (string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)));
									num31 = 59;
									goto IL_034c;
								case 11:
								case 37:
								{
									ICollection<OrganizationValidationMessage> collection8 = Messages;
									OrganizationValidationMessage organizationValidationMessage5 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage5, OrganizationValidationMessageType.Error);
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage5, text12);
									oRcApG4yX38ovhdO5k6(organizationValidationMessage5, list18.Select((Element e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray());
									HKfjaH4b4ET5wOCOU2j(organizationValidationMessage5, current10.Id);
									collection8.Add(organizationValidationMessage5);
									num30 = 43;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
									{
										num30 = 8;
									}
									continue;
								}
								case 1:
									element3 = (OrganizationElement)current10.OrganizationSubDiagram.Elements.First(delegate(Element e)
									{
										int num88 = 1;
										int num89 = num88;
										while (true)
										{
											switch (num89)
											{
											default:
												return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) == 0;
											case 1:
												if (!(e is OrganizationElement))
												{
													return false;
												}
												num89 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
												{
													num89 = 0;
												}
												break;
											}
										}
									});
									num30 = 35;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
									{
										num30 = 20;
									}
									continue;
								case 8:
									if (ListTreeElement.Count != ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).Where((Element e) => e is OrganizationElement).Count())
									{
										num30 = 21;
										continue;
									}
									break;
								case 62:
									enumerator = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(current10.OrganizationSubDiagram)).Where((Element e) => e is OrganizationElement).GetEnumerator();
									num30 = 2;
									continue;
								case 49:
									goto end_IL_13b3;
									IL_034c:
									num30 = num31;
									continue;
								}
								break;
							}
							continue;
							end_IL_13b3:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num52 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
						{
							num52 = 0;
						}
						switch (num52)
						{
						case 0:
							break;
						}
					}
					goto case 18;
				case 87:
					if (ch3Fh1V5wVZXFNQsXdf(organizationDiagram.Elements) <= 0)
					{
						num2 = 7;
						continue;
					}
					goto case 60;
				case 32:
					organizationModel.Id = KXOb5TVHNwEK5iWlDpG(YRRDEwVjCH5ta0NjsY8(zVj0cPVLyCX36N9R6y1(this), organizationModel));
					num2 = 63;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
					{
						num2 = 54;
					}
					continue;
				case 54:
					try
					{
						while (true)
						{
							IL_272e:
							int num11;
							if (!enumerator5.MoveNext())
							{
								num11 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
								{
									num11 = 12;
								}
								goto IL_1fcb;
							}
							goto IL_20a1;
							IL_20a1:
							current4 = enumerator5.Current;
							num11 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
							{
								num11 = 6;
							}
							goto IL_1fcb;
							IL_1fcb:
							while (true)
							{
								switch (num11)
								{
								case 2:
									if (zTUY3SVXCyS0mcQYR4X(list9) >= 1)
									{
										num11 = 11;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
										{
											num11 = 8;
										}
										continue;
									}
									goto case 7;
								case 5:
								{
									ICollection<OrganizationValidationMessage> collection4 = Messages;
									OrganizationValidationMessage organizationValidationMessage2 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage2, OrganizationValidationMessageType.Warning);
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage2, O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(-731479136 ^ -731494028), new object[1] { text4 }));
									oRcApG4yX38ovhdO5k6(organizationValidationMessage2, list9.ToArray());
									collection4.Add(organizationValidationMessage2);
									num11 = 14;
									continue;
								}
								case 1:
								{
									ICollection<OrganizationValidationMessage> collection3 = Messages;
									OrganizationValidationMessage organizationValidationMessage2 = new OrganizationValidationMessage
									{
										Type = OrganizationValidationMessageType.Warning
									};
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage2, O01qg748hr8alYZRb5G(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x11C59687 ^ 0x11C55F43), new object[2] { text4, text3 }));
									oRcApG4yX38ovhdO5k6(organizationValidationMessage2, K5KdRuVAkDCv7eQpf2E(list9));
									collection3.Add(organizationValidationMessage2);
									num11 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
									{
										num11 = 10;
									}
									continue;
								}
								case 3:
									try
									{
										while (true)
										{
											int num12;
											if (!enumerator6.MoveNext())
											{
												num12 = 3;
												goto IL_2167;
											}
											goto IL_2262;
											IL_2167:
											while (true)
											{
												switch (num12)
												{
												case 4:
													break;
												case 5:
													text3 = (string)oWFJtEV7sWjUoYbT1sp(text3, VSJoWR4geFYnrKAMb4u(0x201ABE6B ^ 0x201AA4A5));
													num12 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
													{
														num12 = 0;
													}
													continue;
												case 6:
													num13++;
													num12 = 4;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
													{
														num12 = 4;
													}
													continue;
												case 2:
													if (num13 != 0)
													{
														num12 = 4;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
														{
															num12 = 5;
														}
														continue;
													}
													goto default;
												default:
													text3 = (string)yNoD2VV6yPHQbtoCVgI(text3, VSJoWR4geFYnrKAMb4u(0x62C4BCE8 ^ 0x62C47B32), current5.Key.ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1278809262 ^ -1278858104));
													num12 = 6;
													continue;
												case 1:
													goto IL_2262;
												case 3:
													goto end_IL_218d;
												}
												break;
											}
											continue;
											IL_2262:
											current5 = enumerator6.Current;
											num12 = 2;
											goto IL_2167;
											continue;
											end_IL_218d:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator6).Dispose();
										int num14 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
										{
											num14 = 0;
										}
										switch (num14)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								case 16:
									text3 = "";
									num11 = 15;
									continue;
								case 4:
									try
									{
										while (true)
										{
											IL_240c:
											int num15;
											if (!enumerator7.MoveNext())
											{
												num15 = 15;
												goto IL_2306;
											}
											goto IL_238f;
											IL_2306:
											while (true)
											{
												switch (num15)
												{
												case 22:
													break;
												case 3:
													if (ChIlBL4q5QBmlBbTNmv(_003C_003Ec__DisplayClass31_.duplicateElement.SubDiagram, Guid.Empty))
													{
														num15 = 12;
														continue;
													}
													goto default;
												case 12:
													list8.Add((string)CKjRwyVWQ6U6i24i52s(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x9D1442B ^ 0x9D183E3)));
													num15 = 4;
													continue;
												case 16:
													if (list11.Count() > 0)
													{
														num15 = 2;
														continue;
													}
													goto IL_240c;
												case 1:
												case 4:
												case 10:
												case 11:
												case 20:
													goto IL_240c;
												case 7:
													text4 = (string)_003C_003Ec__DisplayClass31_.duplicateElement.Name;
													num15 = 11;
													continue;
												default:
													if (organizationSubDiagram != null)
													{
														num15 = 4;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
														{
															num15 = 6;
														}
														continue;
													}
													goto IL_240c;
												case 17:
													if (ChIlBL4q5QBmlBbTNmv(guid, _003C_003Ec__DisplayClass31_.duplicateElement.SubDiagram))
													{
														num15 = 9;
														continue;
													}
													goto case 14;
												case 8:
												case 9:
													list9.Add(_003C_003Ec__DisplayClass31_.duplicateElement.Uid);
													num15 = 5;
													continue;
												case 6:
													if (organizationSubDiagram.OrganizationSubDiagrams == null)
													{
														num15 = 18;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
														{
															num15 = 20;
														}
														continue;
													}
													goto case 18;
												case 23:
													if (!ChIlBL4q5QBmlBbTNmv(Guid.Empty, _003C_003Ec__DisplayClass31_.duplicateElement.SubDiagram))
													{
														num15 = 19;
														continue;
													}
													goto case 21;
												case 18:
													list11 = organizationSubDiagram.OrganizationSubDiagrams.Where(_003C_003Ec__DisplayClass31_._003CPublishWarning_003Eb__40).ToList();
													num15 = 2;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
													{
														num15 = 16;
													}
													continue;
												case 13:
													_003C_003Ec__DisplayClass31_.duplicateElement = enumerator7.Current;
													num15 = 23;
													continue;
												case 21:
													if (zTUY3SVXCyS0mcQYR4X(list9) == 0)
													{
														num15 = 8;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
														{
															num15 = 0;
														}
														continue;
													}
													goto case 17;
												case 14:
												case 19:
													if (!(guid != _003C_003Ec__DisplayClass31_.duplicateElement.SubDiagram))
													{
														num15 = 1;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
														{
															num15 = 1;
														}
														continue;
													}
													goto case 3;
												case 5:
													guid = _003C_003Ec__DisplayClass31_.duplicateElement.SubDiagram;
													num15 = 7;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
													{
														num15 = 3;
													}
													continue;
												case 2:
													list8.Add(list11[0].Name);
													num15 = 10;
													continue;
												case 15:
													goto end_IL_240c;
												}
												break;
											}
											goto IL_238f;
											IL_238f:
											_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_3();
											int num16 = 13;
											num15 = num16;
											goto IL_2306;
											continue;
											end_IL_240c:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator7).Dispose();
										int num17 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
										{
											num17 = 0;
										}
										switch (num17)
										{
										case 0:
											break;
										}
									}
									goto case 2;
								case 11:
									if (list8.Count() < 1)
									{
										num11 = 9;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
										{
											num11 = 6;
										}
										continue;
									}
									goto case 16;
								case 7:
								case 9:
									if (zTUY3SVXCyS0mcQYR4X(list9) <= 1)
									{
										num11 = 13;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
										{
											num11 = 10;
										}
										continue;
									}
									goto case 5;
								case 6:
								{
									List<DuplicateElement> list10 = dictionary[current4];
									list9 = new List<Guid>();
									list8 = new List<string>();
									guid = default(Guid);
									text4 = "";
									enumerator7 = list10.GetEnumerator();
									num11 = 4;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
									{
										num11 = 4;
									}
									continue;
								}
								case 10:
								case 13:
								case 14:
									goto IL_272e;
								case 15:
									num13 = 0;
									num11 = 8;
									continue;
								case 8:
									enumerator6 = (from e in list8
										group e by e.ToString()).ToList().GetEnumerator();
									num11 = 3;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
									{
										num11 = 2;
									}
									continue;
								case 12:
									goto end_IL_272e;
								}
								break;
							}
							goto IL_20a1;
							continue;
							end_IL_272e:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
						int num18 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
						{
							num18 = 0;
						}
						switch (num18)
						{
						case 0:
							break;
						}
					}
					goto case 102;
				case 5:
					enumerator4 = organizationSubDiagram.OrganizationSubDiagrams.GetEnumerator();
					num2 = 107;
					continue;
				case 61:
					Mmxq0h4dA022utrei7W(messages);
					num2 = 21;
					continue;
				case 57:
					try
					{
						while (true)
						{
							IL_28e0:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 13;
								goto IL_285e;
							}
							goto IL_2912;
							IL_28f6:
							enumerator2 = organizationElement.OutputConnectors.GetEnumerator();
							int num4 = 17;
							goto IL_285a;
							IL_2912:
							current = enumerator.Current;
							num4 = 8;
							goto IL_285a;
							IL_285a:
							num3 = num4;
							goto IL_285e;
							IL_285e:
							while (true)
							{
								switch (num3)
								{
								case 14:
									if (organizationElement == null)
									{
										num3 = 19;
										continue;
									}
									goto case 9;
								case 18:
									goto IL_28e0;
								case 3:
									goto IL_28f6;
								case 7:
									goto IL_2912;
								case 11:
									try
									{
										while (true)
										{
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 3;
												goto IL_294d;
											}
											goto IL_2996;
											IL_294d:
											while (true)
											{
												switch (num5)
												{
												case 2:
													break;
												default:
													organizationElement.OutputConnectors.Remove(current2);
													num5 = 2;
													continue;
												case 1:
													goto IL_2996;
												case 3:
													goto end_IL_2967;
												}
												break;
											}
											continue;
											IL_2996:
											current2 = enumerator2.Current;
											num5 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
											{
												num5 = 0;
											}
											goto IL_294d;
											continue;
											end_IL_2967:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num6 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
										{
											num6 = 0;
										}
										switch (num6)
										{
										case 0:
											break;
										}
									}
									goto case 12;
								case 6:
									list3.Add(current);
									num3 = 16;
									continue;
								case 8:
									if (!(current is OrganizationAnnotationElement))
									{
										num3 = 10;
										continue;
									}
									goto case 6;
								case 1:
									enumerator2 = list2.GetEnumerator();
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
									{
										num3 = 11;
									}
									continue;
								case 12:
								case 19:
									num9++;
									num3 = 18;
									continue;
								case 5:
									list3.Add(current);
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
									{
										num3 = 0;
									}
									continue;
								case 17:
									try
									{
										while (true)
										{
											int num7;
											if (!enumerator2.MoveNext())
											{
												num7 = 2;
												goto IL_2ac7;
											}
											goto IL_2b34;
											IL_2ac7:
											while (true)
											{
												switch (num7)
												{
												case 3:
													list2.Add(current3);
													num7 = 2;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
													{
														num7 = 4;
													}
													continue;
												case 4:
													break;
												default:
													if (current3 is OrgConnectorElementAnnotation)
													{
														num7 = 3;
														continue;
													}
													break;
												case 1:
													goto IL_2b34;
												case 2:
													goto end_IL_2b08;
												}
												break;
											}
											continue;
											IL_2b34:
											current3 = enumerator2.Current;
											num7 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
											{
												num7 = 0;
											}
											goto IL_2ac7;
											continue;
											end_IL_2b08:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num8 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								case 2:
								case 4:
									if (current is OrgArtifactGroupElement)
									{
										num3 = 5;
										continue;
									}
									break;
								case 9:
									list2 = new List<Connector>();
									num3 = 3;
									continue;
								case 15:
									goto IL_2bd7;
								case 10:
								case 16:
									if (!(current is OrgConnectorElementAnnotation))
									{
										num3 = 2;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto IL_2bd7;
								case 13:
									goto end_IL_28e0;
								}
								break;
							}
							organizationElement = current as OrganizationElement;
							num4 = 14;
							goto IL_285a;
							IL_2bd7:
							list3.Add(current);
							num4 = 2;
							goto IL_285a;
							continue;
							end_IL_28e0:
							break;
						}
					}
					finally
					{
						int num10;
						if (enumerator == null)
						{
							num10 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
							{
								num10 = 1;
							}
							goto IL_2c4d;
						}
						goto IL_2c82;
						IL_2c82:
						vf623m4s8PeyGiBC8as(enumerator);
						num10 = 2;
						goto IL_2c4d;
						IL_2c4d:
						switch (num10)
						{
						case 1:
							goto end_IL_2c28;
						case 2:
							goto end_IL_2c28;
						}
						goto IL_2c82;
						end_IL_2c28:;
					}
					goto case 59;
				case 49:
					if (organizationSubDiagram == null)
					{
						num2 = 50;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 109;
				case 64:
					ValidateOnly = false;
					num2 = 41;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 != 0)
					{
						num2 = 10;
					}
					continue;
				case 93:
					xxVc9mVlWY1FLPoqZo6(filter, true);
					num2 = 103;
					continue;
				case 17:
					dKE7k04fgEnwkY2EGyH(EleWise.ELMA.Logging.Logger.Log, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A9A1A63 ^ 0x1A9AD8C1), text));
					num2 = 90;
					continue;
				case 86:
					enumerator9 = collection.GetEnumerator();
					num2 = 27;
					continue;
				case 65:
					qgWnkC4Q7Vy9N8NKVSb(organizationDiagram);
					num2 = 31;
					continue;
				case 72:
					organizationModel = Create();
					num2 = 106;
					continue;
				case 19:
					if (ValidateOnly)
					{
						num = 77;
						break;
					}
					goto case 36;
				case 30:
					if (HasErrors)
					{
						num2 = 33;
						continue;
					}
					goto case 87;
				case 37:
					filter = new Filter();
					num2 = 93;
					continue;
				case 27:
					try
					{
						while (true)
						{
							int num57;
							if (!enumerator9.MoveNext())
							{
								num57 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
								{
									num57 = 12;
								}
								goto IL_2dd5;
							}
							goto IL_2ee4;
							IL_2ee4:
							current16 = enumerator9.Current;
							num57 = 10;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
							{
								num57 = 7;
							}
							goto IL_2dd5;
							IL_2dd5:
							while (true)
							{
								switch (num57)
								{
								case 2:
								case 9:
									if (!list14.Contains(current16))
									{
										num57 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
										{
											num57 = 0;
										}
										continue;
									}
									break;
								case 1:
									x9sAf9Vm5UijpUDGZtl(current16, null);
									num57 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
									{
										num57 = 3;
									}
									continue;
								case 4:
									break;
								case 11:
									y4u8tUVxktqv2q7tGM9(CacheService, z6s2JoVZJvUvIpOiWig(VSJoWR4geFYnrKAMb4u(0xFD0849E ^ 0xFD04F58), current16.GetType().FullName, current16.Id));
									num57 = 9;
									continue;
								case 8:
									goto IL_2ee4;
								default:
									if (!tADNKvVBBlwQW9uqDUD(current16))
									{
										num57 = 5;
										continue;
									}
									break;
								case 10:
									if (current16 == null)
									{
										num57 = 2;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
										{
											num57 = 0;
										}
										continue;
									}
									goto case 11;
								case 5:
									bOWmYiVuJwdiBFBi8gZ(current16, null);
									num57 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
									{
										num57 = 1;
									}
									continue;
								case 6:
								{
									IOrganizationItem organizationItem = current16;
									organizationItem.Name = (string)yNoD2VV6yPHQbtoCVgI(HS182BVe1FXWaxxE4Fp(organizationItem), VSJoWR4geFYnrKAMb4u(-1429357207 ^ -1429390821), CKjRwyVWQ6U6i24i52s(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-208231202 ^ -208246602)), VSJoWR4geFYnrKAMb4u(-1757426405 ^ -1757459871));
									num57 = 7;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
									{
										num57 = 6;
									}
									continue;
								}
								case 7:
									current16.Delete();
									num57 = 4;
									continue;
								case 3:
									((ICollection<EleWise.ELMA.Security.Models.IUser>)current16.Users).Clear();
									num57 = 6;
									continue;
								case 12:
									goto end_IL_2e7c;
								}
								break;
							}
							continue;
							end_IL_2e7c:
							break;
						}
					}
					finally
					{
						if (enumerator9 != null)
						{
							int num58 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
							{
								num58 = 0;
							}
							while (true)
							{
								switch (num58)
								{
								default:
									enumerator9.Dispose();
									num58 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
									{
										num58 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 32;
				case 12:
					try
					{
						while (true)
						{
							int num53;
							if (!u0m6wM4M5GVFqBXpRuO(enumerator))
							{
								num53 = 19;
								goto IL_3075;
							}
							goto IL_32c2;
							IL_3075:
							while (true)
							{
								List<OrganizationElement> list27;
								switch (num53)
								{
								case 14:
									((ILogger)F1wfPp49ak1SaAbFkRJ()).Error(O01qg748hr8alYZRb5G(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C48C9C4 ^ 0x1C480B66), new object[1] { text20 }));
									num53 = 7;
									continue;
								case 7:
								case 11:
								{
									ICollection<OrganizationValidationMessage> collection14 = Messages;
									OrganizationValidationMessage organizationValidationMessage11 = new OrganizationValidationMessage();
									EN9QAg4rdY2wmqrRmQB(organizationValidationMessage11, OrganizationValidationMessageType.Error);
									oFqtyr43BqZMfDqVpIy(organizationValidationMessage11, text20);
									oRcApG4yX38ovhdO5k6(organizationValidationMessage11, array);
									collection14.Add(organizationValidationMessage11);
									num53 = 4;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
									{
										num53 = 3;
									}
									continue;
								}
								case 9:
									if (ValidateOnly)
									{
										num53 = 7;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
										{
											num53 = 11;
										}
										continue;
									}
									goto case 14;
								case 4:
								case 8:
								case 12:
									break;
								case 1:
								case 17:
									enumerator2 = departmentElement2.OutputConnectors.GetEnumerator();
									num53 = 21;
									continue;
								case 5:
									if (departmentElement2.Composition != null)
									{
										num53 = 6;
										continue;
									}
									goto case 1;
								case 13:
									if (departmentElement2 != null)
									{
										num53 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
										{
											num53 = 10;
										}
										continue;
									}
									goto case 3;
								case 18:
									list26.AddRange(departmentElement2.Composition);
									num53 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
									{
										num53 = 1;
									}
									continue;
								case 16:
									if (departmentElement2 == null)
									{
										num53 = 12;
										continue;
									}
									goto default;
								case 6:
									if (tXVp0X4SovxlnPKviT1(departmentElement2.Composition) <= 0)
									{
										num53 = 14;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
										{
											num53 = 17;
										}
										continue;
									}
									goto case 18;
								case 15:
									text20 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(-185816410 ^ -185831980), new object[1] { g8Zcx44zxGCs9482XT8(departmentElement2) });
									num53 = 6;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
									{
										num53 = 9;
									}
									continue;
								case 3:
									list27 = new List<OrganizationElement>();
									goto IL_348c;
								case 20:
									goto IL_32c2;
								case 21:
									try
									{
										while (true)
										{
											IL_3353:
											int num54;
											if (!enumerator2.MoveNext())
											{
												num54 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
												{
													num54 = 0;
												}
												goto IL_32ee;
											}
											goto IL_3379;
											IL_3379:
											organizationElement4 = enumerator2.Current.EndElement as OrganizationElement;
											num54 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
											{
												num54 = 1;
											}
											goto IL_32ee;
											IL_32ee:
											while (true)
											{
												switch (num54)
												{
												case 2:
													list26.Add(organizationElement4);
													num54 = 3;
													continue;
												case 1:
													if (organizationElement4 == null)
													{
														num54 = 1;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
														{
															num54 = 4;
														}
														continue;
													}
													goto case 2;
												case 3:
												case 4:
													goto IL_3353;
												case 5:
													goto IL_3379;
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
										((IDisposable)enumerator2).Dispose();
										int num55 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
										{
											num55 = 0;
										}
										switch (num55)
										{
										case 0:
											break;
										}
									}
									goto case 13;
								case 2:
									array = new Guid[1] { iNA3SE4OpJM3FcyeNlK(departmentElement2) };
									num53 = 15;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
									{
										num53 = 4;
									}
									continue;
								default:
									list26 = new List<OrganizationElement>();
									num53 = 5;
									continue;
								case 10:
									list27 = list26.Where(delegate(OrganizationElement e)
									{
										//Discarded unreachable code: IL_002d, IL_003c
										int num76 = 1;
										int num77 = num76;
										while (true)
										{
											switch (num77)
											{
											case 1:
												if (!(e is PositionElement))
												{
													num77 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
													{
														num77 = 0;
													}
													break;
												}
												goto case 2;
											case 2:
												return _003C_003Ec.wLRN2tpwMIlKl13x8HrD((PositionElement)e);
											default:
												return false;
											}
										}
									}).ToList();
									goto IL_348c;
								case 19:
									goto end_IL_3186;
									IL_348c:
									if (list27.Count <= 1)
									{
										num53 = 8;
										continue;
									}
									goto case 2;
								}
								break;
							}
							continue;
							IL_32c2:
							departmentElement2 = enumerator.Current as DepartmentElement;
							num53 = 16;
							goto IL_3075;
							continue;
							end_IL_3186:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num56 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
							{
								num56 = 1;
							}
							while (true)
							{
								switch (num56)
								{
								case 1:
									vf623m4s8PeyGiBC8as(enumerator);
									num56 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
									{
										num56 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 30;
				case 28:
					if (list7.Count == 0)
					{
						num2 = 3;
						continue;
					}
					goto case 75;
				case 110:
					dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(-1788380826 ^ -1788363836), new object[1] { text6 }));
					num2 = 70;
					continue;
				case 56:
					num9 = 0;
					num2 = 43;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 43;
					}
					continue;
				case 34:
					message = CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(0x3B1D6430 ^ 0x3B1DA8B0));
					goto IL_584a;
				case 59:
					enumerator3 = list3.GetEnumerator();
					num2 = 76;
					continue;
				case 15:
					text8 = (string)CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(0x4BBFF2C6 ^ 0x4BBF37A6));
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
					{
						num2 = 19;
					}
					continue;
				case 16:
					list13 = new List<string>();
					num2 = 26;
					continue;
				case 76:
					try
					{
						while (true)
						{
							IL_3664:
							int num21;
							if (!enumerator3.MoveNext())
							{
								num21 = 3;
								goto IL_3627;
							}
							goto IL_3641;
							IL_3627:
							while (true)
							{
								switch (num21)
								{
								case 2:
									goto IL_3664;
								case 1:
									VRCg5B4T13g0ehZL2PN(uLLsji4cIXYOGRkEf58(organizationDiagram), current6);
									num21 = 2;
									continue;
								case 3:
									goto end_IL_3664;
								}
								break;
							}
							goto IL_3641;
							IL_3641:
							current6 = enumerator3.Current;
							num21 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
							{
								num21 = 0;
							}
							goto IL_3627;
							continue;
							end_IL_3664:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num22 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 38:
					if (organizationSubDiagram != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 18;
				case 71:
					try
					{
						while (true)
						{
							IL_3815:
							int num19;
							if (!u0m6wM4M5GVFqBXpRuO(enumerator))
							{
								num19 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
								{
									num19 = 3;
								}
								goto IL_3743;
							}
							goto IL_3804;
							IL_3804:
							_003C_003Ec__DisplayClass31_2 = new _003C_003Ec__DisplayClass31_1();
							num19 = 2;
							goto IL_3743;
							IL_3743:
							while (true)
							{
								switch (num19)
								{
								case 2:
									_003C_003Ec__DisplayClass31_2.subElement = enumerator.Current;
									num19 = 3;
									continue;
								default:
									list12.Add(iNA3SE4OpJM3FcyeNlK(_003C_003Ec__DisplayClass31_2.subElement));
									num19 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
									{
										num19 = 5;
									}
									continue;
								case 3:
									if (ListTreeElement.Any(_003C_003Ec__DisplayClass31_2._003CPublishWarning_003Eb__36))
									{
										num19 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
										{
											num19 = 6;
										}
										continue;
									}
									goto default;
								case 1:
									break;
								case 5:
								case 6:
									goto IL_3815;
								case 4:
									goto end_IL_3815;
								}
								break;
							}
							goto IL_3804;
							continue;
							end_IL_3815:
							break;
						}
					}
					finally
					{
						int num20;
						if (enumerator == null)
						{
							num20 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
							{
								num20 = 0;
							}
							goto IL_3865;
						}
						goto IL_387b;
						IL_387b:
						vf623m4s8PeyGiBC8as(enumerator);
						num20 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
						{
							num20 = 1;
						}
						goto IL_3865;
						IL_3865:
						switch (num20)
						{
						default:
							goto end_IL_3840;
						case 2:
							break;
						case 0:
							goto end_IL_3840;
						case 1:
							goto end_IL_3840;
						}
						goto IL_387b;
						end_IL_3840:;
					}
					goto case 15;
				case 53:
					enumerator = ((ElementList)uLLsji4cIXYOGRkEf58(organizationDiagram)).GetEnumerator();
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
					{
						num2 = 12;
					}
					continue;
				case 47:
					element = (OrganizationElement)list7[0];
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
					{
						num2 = 1;
					}
					continue;
				case 21:
					list3 = new List<Element>();
					num2 = 56;
					continue;
				case 103:
					collection = ((AbstractNHEntityManager<IOrganizationItem, long>)B86CsiVNudO4tGeOLbW()).Find((IEntityFilter)filter, (FetchOptions)null);
					num2 = 29;
					continue;
				case 3:
					text = (string)CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(0x31C71464 ^ 0x31C7D22A));
					num2 = 23;
					continue;
				case 45:
					ValidateOnly = false;
					num2 = 96;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num2 = 83;
					}
					continue;
				case 99:
					if (CxWs7A4GCeQbyjPiX92(list) > 0)
					{
						num2 = 44;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 94;
				case 102:
					if (HasErrors)
					{
						num2 = 64;
						continue;
					}
					if (!ValidateOnly)
					{
						num2 = 37;
						continue;
					}
					goto case 63;
				case 31:
					organizationSubDiagram = ClassSerializationHelper.CloneObjectByXml(organizationModels.SubDiagrams);
					num2 = 61;
					continue;
				case 109:
					if (organizationSubDiagram.OrganizationSubDiagrams != null)
					{
						num2 = 25;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 50;
				case 25:
					enumerator3 = list5.GetEnumerator();
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
					{
						num2 = 6;
					}
					continue;
				case 42:
				case 90:
				{
					ICollection<OrganizationValidationMessage> collection18 = Messages;
					OrganizationValidationMessage organizationValidationMessage13 = new OrganizationValidationMessage();
					EN9QAg4rdY2wmqrRmQB(organizationValidationMessage13, OrganizationValidationMessageType.Error);
					oFqtyr43BqZMfDqVpIy(organizationValidationMessage13, text);
					collection18.Add(organizationValidationMessage13);
					num2 = 75;
					continue;
				}
				case 67:
					enumerator4 = organizationSubDiagram.OrganizationSubDiagrams.GetEnumerator();
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
					{
						num2 = 3;
					}
					continue;
				case 83:
					try
					{
						while (true)
						{
							int num69;
							if (!enumerator8.MoveNext())
							{
								num69 = 3;
								goto IL_3af1;
							}
							goto IL_3df7;
							IL_3af1:
							switch (num69)
							{
							case 1:
								break;
							case 2:
								try
								{
									while (true)
									{
										IL_3d46:
										int num70;
										if (!u0m6wM4M5GVFqBXpRuO(enumerator))
										{
											num70 = 7;
											goto IL_3b45;
										}
										goto IL_3bd2;
										IL_3b45:
										while (true)
										{
											switch (num70)
											{
											case 6:
												list33.Add(new DuplicateElement
												{
													Uid = iNA3SE4OpJM3FcyeNlK(current20),
													Name = g8Zcx44zxGCs9482XT8(current20),
													SubDiagram = Guid.Empty
												});
												num70 = 8;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
												{
													num70 = 2;
												}
												continue;
											case 8:
												dictionary.Add((string)LyF55CVkjHRrJSmpFkK(g8Zcx44zxGCs9482XT8(current20)), list33);
												num70 = 13;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
												{
													num70 = 13;
												}
												continue;
											case 12:
												list32.Add(new DuplicateElement
												{
													Uid = current20.Uid,
													Name = g8Zcx44zxGCs9482XT8(current20),
													SubDiagram = Guid.Empty
												});
												num70 = 8;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
												{
													num70 = 11;
												}
												continue;
											case 2:
												list32 = dictionary[(string)LyF55CVkjHRrJSmpFkK(current20.Name)];
												num70 = 3;
												continue;
											case 1:
											case 10:
												list33 = new List<DuplicateElement>();
												num70 = 6;
												continue;
											case 4:
												list13.Add((string)LyF55CVkjHRrJSmpFkK(current20.Name));
												num70 = 12;
												continue;
											case 3:
												if (list32.Count == 1)
												{
													num70 = 4;
													continue;
												}
												goto case 12;
											case 9:
												if (!dictionary.ContainsKey((string)LyF55CVkjHRrJSmpFkK(g8Zcx44zxGCs9482XT8(current20))))
												{
													int num71 = 10;
													num70 = num71;
													continue;
												}
												goto case 2;
											case 11:
												dictionary[(string)LyF55CVkjHRrJSmpFkK(g8Zcx44zxGCs9482XT8(current20))] = list32;
												num70 = 5;
												continue;
											case 5:
											case 13:
												goto IL_3d46;
											case 7:
												goto end_IL_3d46;
											}
											break;
										}
										goto IL_3bd2;
										IL_3bd2:
										current20 = enumerator.Current;
										num70 = 9;
										goto IL_3b45;
										continue;
										end_IL_3d46:
										break;
									}
								}
								finally
								{
									int num72;
									if (enumerator == null)
									{
										num72 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
										{
											num72 = 1;
										}
										goto IL_3d86;
									}
									goto IL_3dbb;
									IL_3dbb:
									vf623m4s8PeyGiBC8as(enumerator);
									num72 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
									{
										num72 = 1;
									}
									goto IL_3d86;
									IL_3d86:
									switch (num72)
									{
									case 1:
										goto end_IL_3d61;
									case 2:
										goto end_IL_3d61;
									}
									goto IL_3dbb;
									end_IL_3d61:;
								}
								break;
							default:
								goto IL_3df7;
							case 3:
								goto end_IL_3b0b;
							}
							continue;
							IL_3df7:
							enumerator = enumerator8.Current.GetEnumerator();
							num69 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
							{
								num69 = 1;
							}
							goto IL_3af1;
							continue;
							end_IL_3b0b:
							break;
						}
					}
					finally
					{
						int num73;
						if (enumerator8 == null)
						{
							num73 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
							{
								num73 = 0;
							}
							goto IL_3e49;
						}
						goto IL_3e5f;
						IL_3e5f:
						vf623m4s8PeyGiBC8as(enumerator8);
						num73 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
						{
							num73 = 2;
						}
						goto IL_3e49;
						IL_3e49:
						switch (num73)
						{
						case 1:
							goto end_IL_3e24;
						case 2:
							goto end_IL_3e24;
						}
						goto IL_3e5f;
						end_IL_3e24:;
					}
					goto case 66;
				case 20:
					if (organizationSubDiagram != null)
					{
						num2 = 52;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
						{
							num2 = 80;
						}
						continue;
					}
					goto case 91;
				case 36:
					dKE7k04fgEnwkY2EGyH(F1wfPp49ak1SaAbFkRJ(), O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x1869C442 ^ 0x186906E0), new object[1] { text8 }));
					num = 112;
					break;
				case 35:
					((ILogger)F1wfPp49ak1SaAbFkRJ()).Error(O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(-737960346 ^ -737977148), new object[1] { text5 }));
					num2 = 9;
					continue;
				case 106:
					eI1AuU4KOGmQQxD5SjU(organizationModel, M0LM9J4UmptKegPog4c(organizationModels));
					num2 = 58;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 81;
					}
					continue;
				case 100:
					if (list6.Count > 0)
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
						{
							num2 = 88;
						}
						continue;
					}
					goto case 53;
				case 10:
					FindDoubleTree(element2, organizationDiagram);
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
					{
						num2 = 108;
					}
					continue;
				case 95:
					if (!ValidateOnly)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 62;
				case 48:
					text24 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x40096392 ^ 0x4009A792), new object[1] { text19 });
					num2 = 95;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
					{
						num2 = 91;
					}
					continue;
				case 41:
					throw new OrganizationModelPublishException((string)CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(0x84482CB ^ 0x84449BB)))
					{
						mess = messages
					};
				case 11:
					try
					{
						while (true)
						{
							int num59;
							if (!enumerator4.MoveNext())
							{
								num59 = 3;
								goto IL_4081;
							}
							goto IL_496e;
							IL_4081:
							while (true)
							{
								switch (num59)
								{
								default:
									enumerator5 = list13.GetEnumerator();
									num59 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
									{
										num59 = 1;
									}
									continue;
								case 7:
									if (current19 == null)
									{
										num59 = 4;
										continue;
									}
									goto case 6;
								case 6:
									if (current19.OrganizationSubDiagram != null)
									{
										num59 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
										{
											num59 = 0;
										}
										continue;
									}
									break;
								case 2:
								case 4:
									break;
								case 1:
									try
									{
										while (true)
										{
											int num60;
											if (!enumerator5.MoveNext())
											{
												num60 = 5;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
												{
													num60 = 0;
												}
												goto IL_414e;
											}
											goto IL_4319;
											IL_4319:
											current17 = enumerator5.Current;
											num60 = 10;
											goto IL_414e;
											IL_414e:
											while (true)
											{
												switch (num60)
												{
												case 1:
												case 6:
													break;
												case 8:
												{
													ICollection<OrganizationValidationMessage> collection16 = Messages;
													OrganizationValidationMessage organizationValidationMessage2 = new OrganizationValidationMessage();
													EN9QAg4rdY2wmqrRmQB(organizationValidationMessage2, OrganizationValidationMessageType.Warning);
													oFqtyr43BqZMfDqVpIy(organizationValidationMessage2, SR.T((string)VSJoWR4geFYnrKAMb4u(0x8875F5C ^ 0x88798BC), current19.Name, text23, text22));
													oRcApG4yX38ovhdO5k6(organizationValidationMessage2, K5KdRuVAkDCv7eQpf2E(list29));
													HKfjaH4b4ET5wOCOU2j(organizationValidationMessage2, current19.Id);
													collection16.Add(organizationValidationMessage2);
													num60 = 1;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f != 0)
													{
														num60 = 1;
													}
													continue;
												}
												case 11:
													if (list28.Count() < 1)
													{
														num60 = 7;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
														{
															num60 = 1;
														}
														continue;
													}
													goto case 13;
												case 10:
												{
													List<DuplicateElement> list30 = dictionary[current17];
													list29 = new List<Guid>();
													list28 = new List<string>();
													guid2 = default(Guid);
													text23 = "";
													enumerator7 = list30.GetEnumerator();
													num60 = 4;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
													{
														num60 = 4;
													}
													continue;
												}
												case 13:
													text22 = "";
													num60 = 15;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
													{
														num60 = 5;
													}
													continue;
												case 12:
													goto IL_4319;
												case 3:
													try
													{
														while (true)
														{
															IL_441c:
															int num61;
															if (!enumerator6.MoveNext())
															{
																num61 = 5;
																goto IL_4340;
															}
															goto IL_43ab;
															IL_4340:
															while (true)
															{
																switch (num61)
																{
																default:
																	if (num62 == 0)
																	{
																		num61 = 3;
																		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
																		{
																			num61 = 1;
																		}
																		continue;
																	}
																	goto case 7;
																case 4:
																	num62++;
																	num61 = 1;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
																	{
																		num61 = 0;
																	}
																	continue;
																case 6:
																	break;
																case 2:
																case 3:
																	text22 = (string)yNoD2VV6yPHQbtoCVgI(text22, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580345321), current18.Key.ToString(), VSJoWR4geFYnrKAMb4u(-1195916818 ^ -1195964876));
																	num61 = 4;
																	continue;
																case 1:
																	goto IL_441c;
																case 7:
																	text22 = (string)oWFJtEV7sWjUoYbT1sp(text22, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46347DA6 ^ 0x46346768));
																	num61 = 2;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
																	{
																		num61 = 1;
																	}
																	continue;
																case 5:
																	goto end_IL_441c;
																}
																break;
															}
															goto IL_43ab;
															IL_43ab:
															current18 = enumerator6.Current;
															num61 = 0;
															if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
															{
																num61 = 0;
															}
															goto IL_4340;
															continue;
															end_IL_441c:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator6).Dispose();
														int num63 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
														{
															num63 = 0;
														}
														switch (num63)
														{
														case 0:
															break;
														}
													}
													goto case 8;
												case 4:
													try
													{
														while (true)
														{
															IL_473d:
															int num64;
															if (!enumerator7.MoveNext())
															{
																num64 = 19;
																goto IL_44c2;
															}
															goto IL_4668;
															IL_44c2:
															while (true)
															{
																switch (num64)
																{
																case 7:
																case 13:
																	list31 = organizationSubDiagram.OrganizationSubDiagrams.Where(_003C_003Ec__DisplayClass31_4._003CPublishWarning_003Eb__38).ToList();
																	num64 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
																	{
																		num64 = 0;
																	}
																	continue;
																case 6:
																	if (!ChIlBL4q5QBmlBbTNmv(_003C_003Ec__DisplayClass31_4.duplicateElement.SubDiagram, Guid.Empty))
																	{
																		num64 = 13;
																		continue;
																	}
																	goto case 2;
																case 8:
																case 16:
																	if (UsFHZLVitnydr0o4rxx(guid2, _003C_003Ec__DisplayClass31_4.duplicateElement.SubDiagram))
																	{
																		num64 = 6;
																		continue;
																	}
																	goto IL_473d;
																case 2:
																	list28.Add((string)CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(-1027693337 ^ -1027710161)));
																	num64 = 10;
																	continue;
																case 15:
																	_003C_003Ec__DisplayClass31_4.duplicateElement = enumerator7.Current;
																	num64 = 5;
																	continue;
																case 1:
																	guid2 = _003C_003Ec__DisplayClass31_4.duplicateElement.SubDiagram;
																	num64 = 17;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
																	{
																		num64 = 10;
																	}
																	continue;
																case 4:
																	list28.Add(list31[0].Name);
																	num64 = 12;
																	continue;
																case 9:
																	if (guid2 == _003C_003Ec__DisplayClass31_4.duplicateElement.SubDiagram)
																	{
																		num64 = 11;
																		continue;
																	}
																	goto case 8;
																case 18:
																	break;
																default:
																	if (list31.Count() > 0)
																	{
																		num64 = 0;
																		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
																		{
																			num64 = 4;
																		}
																		continue;
																	}
																	goto IL_473d;
																case 14:
																	if (zTUY3SVXCyS0mcQYR4X(list29) != 0)
																	{
																		num64 = 9;
																		continue;
																	}
																	goto case 11;
																case 11:
																	list29.Add(_003C_003Ec__DisplayClass31_4.duplicateElement.Uid);
																	num64 = 1;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
																	{
																		num64 = 0;
																	}
																	continue;
																case 5:
																	if (!(current19.Id == _003C_003Ec__DisplayClass31_4.duplicateElement.SubDiagram))
																	{
																		int num65 = 8;
																		num64 = num65;
																		continue;
																	}
																	goto case 14;
																case 3:
																case 10:
																case 12:
																	goto IL_473d;
																case 17:
																	text23 = (string)_003C_003Ec__DisplayClass31_4.duplicateElement.Name;
																	num64 = 3;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
																	{
																		num64 = 0;
																	}
																	continue;
																case 19:
																	goto end_IL_473d;
																}
																break;
															}
															goto IL_4668;
															IL_4668:
															_003C_003Ec__DisplayClass31_4 = new _003C_003Ec__DisplayClass31_2();
															num64 = 15;
															if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
															{
																num64 = 6;
															}
															goto IL_44c2;
															continue;
															end_IL_473d:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator7).Dispose();
														int num66 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
														{
															num66 = 0;
														}
														switch (num66)
														{
														case 0:
															break;
														}
													}
													goto default;
												case 2:
												{
													ICollection<OrganizationValidationMessage> collection15 = Messages;
													OrganizationValidationMessage organizationValidationMessage2 = new OrganizationValidationMessage
													{
														Type = OrganizationValidationMessageType.Warning
													};
													oFqtyr43BqZMfDqVpIy(organizationValidationMessage2, O01qg748hr8alYZRb5G(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D9E563), new object[2] { current19.Name, text23 }));
													oRcApG4yX38ovhdO5k6(organizationValidationMessage2, K5KdRuVAkDCv7eQpf2E(list29));
													HKfjaH4b4ET5wOCOU2j(organizationValidationMessage2, current19.Id);
													collection15.Add(organizationValidationMessage2);
													num60 = 6;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
													{
														num60 = 5;
													}
													continue;
												}
												case 15:
													num62 = 0;
													num60 = 9;
													continue;
												case 7:
												case 14:
													if (zTUY3SVXCyS0mcQYR4X(list29) > 1)
													{
														num60 = 2;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
														{
															num60 = 2;
														}
														continue;
													}
													break;
												default:
													if (zTUY3SVXCyS0mcQYR4X(list29) >= 1)
													{
														num60 = 11;
														continue;
													}
													goto case 7;
												case 9:
													enumerator6 = (from e in list28
														group e by e.ToString()).ToList().GetEnumerator();
													num60 = 3;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
													{
														num60 = 2;
													}
													continue;
												case 5:
													goto end_IL_4198;
												}
												break;
											}
											continue;
											end_IL_4198:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator5).Dispose();
										int num67 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
										{
											num67 = 0;
										}
										switch (num67)
										{
										case 0:
											break;
										}
									}
									break;
								case 5:
									goto IL_496e;
								case 3:
									goto end_IL_4105;
								}
								break;
							}
							continue;
							IL_496e:
							current19 = enumerator4.Current;
							num59 = 7;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
							{
								num59 = 7;
							}
							goto IL_4081;
							continue;
							end_IL_4105:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num68 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
						{
							num68 = 0;
						}
						switch (num68)
						{
						case 0:
							break;
						}
					}
					goto case 91;
				case 73:
					text21 = (string)lsHJiE4IP3gXOgoBAHS(organizationModels);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 72;
					}
					continue;
				case 46:
					EleWise.ELMA.Logging.Logger.Log.Error(O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0x1B47BFA1 ^ 0x1B477D03), new object[1] { text2 }));
					num2 = 40;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
					{
						num2 = 40;
					}
					continue;
				case 29:
					list14 = new List<IOrganizationItem>();
					num2 = 42;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
					{
						num2 = 47;
					}
					continue;
				case 85:
					ListTreeElement = new List<Guid>();
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					elementsStack = new List<OrganizationElement>();
					num2 = 69;
					continue;
				case 96:
					if (ValidateOnly)
					{
						num = 55;
						break;
					}
					goto case 34;
				case 22:
					list12 = new List<Guid>();
					num2 = 89;
					continue;
				case 91:
				case 104:
					enumerator5 = list13.GetEnumerator();
					num2 = 54;
					continue;
				case 105:
					organizationDiagram = ClassSerializationHelper.CloneObjectByXml((OrganizationDiagram)M0LM9J4UmptKegPog4c(organizationModels));
					num2 = 65;
					continue;
				case 26:
					dictionary = new Dictionary<string, List<DuplicateElement>>();
					num2 = 38;
					continue;
				case 39:
					text5 = SR.T((string)VSJoWR4geFYnrKAMb4u(0x2121ECF9 ^ 0x21212A4F), text9);
					num2 = 13;
					continue;
				case 63:
					if (HasWarning)
					{
						num = 45;
						break;
					}
					return organizationModel.Id;
				case 23:
					if (ValidateOnly)
					{
						num2 = 42;
						continue;
					}
					goto case 17;
				case 88:
					text2 = (string)CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(-2119527672 ^ -2119543776));
					num2 = 24;
					continue;
				case 24:
					if (ValidateOnly)
					{
						num2 = 58;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 46;
				case 6:
					try
					{
						while (true)
						{
							IL_4c20:
							int num23;
							if (!enumerator3.MoveNext())
							{
								num23 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
								{
									num23 = 0;
								}
								goto IL_4bef;
							}
							goto IL_4c0d;
							IL_4c0d:
							current7 = enumerator3.Current;
							num23 = 3;
							goto IL_4bef;
							IL_4bef:
							while (true)
							{
								switch (num23)
								{
								case 4:
									goto IL_4c0d;
								case 2:
									goto IL_4c20;
								case 1:
									try
									{
										while (true)
										{
											IL_4d3a:
											int num24;
											if (!enumerator4.MoveNext())
											{
												num24 = 3;
												goto IL_4c5a;
											}
											goto IL_4ca8;
											IL_4c5a:
											while (true)
											{
												int num25;
												switch (num24)
												{
												case 12:
													break;
												case 9:
													if (list15.Count <= 0)
													{
														num24 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
														{
															num24 = 1;
														}
														continue;
													}
													goto case 7;
												case 13:
													C3Xopt40mvCPqgd4rCU(uLLsji4cIXYOGRkEf58(organizationDiagram), orgConnectorElement);
													num24 = 14;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
													{
														num24 = 3;
													}
													continue;
												case 6:
													if (current8 == null)
													{
														num24 = 5;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
														{
															num24 = 8;
														}
														continue;
													}
													goto default;
												case 1:
												case 5:
												case 8:
												case 15:
													goto IL_4d3a;
												default:
													if (current8.OrganizationSubDiagram != null)
													{
														num24 = 2;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
														{
															num24 = 2;
														}
														continue;
													}
													goto IL_4d3a;
												case 16:
													current7.OutputConnectors.Add(item);
													num24 = 4;
													continue;
												case 7:
												{
													OrgConnectorElement orgConnectorElement2 = new OrgConnectorElement();
													YOOZgn4FpfkOPIUxx9V(orgConnectorElement2, Guid.NewGuid());
													orgConnectorElement = orgConnectorElement2;
													num25 = 13;
													goto IL_4c56;
												}
												case 4:
													enumerator = ((ElementList)uLLsji4cIXYOGRkEf58(current8.OrganizationSubDiagram)).GetEnumerator();
													num24 = 8;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
													{
														num24 = 10;
													}
													continue;
												case 14:
												{
													Connector obj2 = new Connector
													{
														EndElement = list15[0]
													};
													piHrQV4DDdpyjRvsFxU(obj2, current7);
													item = obj2;
													num24 = 9;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
													{
														num24 = 16;
													}
													continue;
												}
												case 10:
													try
													{
														while (true)
														{
															int num26;
															if (!u0m6wM4M5GVFqBXpRuO(enumerator))
															{
																num26 = 7;
																goto IL_4e45;
															}
															goto IL_4ee4;
															IL_4e45:
															while (true)
															{
																switch (num26)
																{
																case 5:
																	if (iNA3SE4OpJM3FcyeNlK(current9) == iNA3SE4OpJM3FcyeNlK(list15[0]))
																	{
																		num26 = 8;
																		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
																		{
																			num26 = 4;
																		}
																		continue;
																	}
																	goto case 2;
																case 6:
																	nestedStructureElement = current9 as NestedStructureElement;
																	num26 = 3;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
																	{
																		num26 = 2;
																	}
																	continue;
																case 4:
																	goto IL_4ee4;
																case 8:
																	current9.InputConnectors.Add(item);
																	num26 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
																	{
																		num26 = 2;
																	}
																	continue;
																case 2:
																	C3Xopt40mvCPqgd4rCU(uLLsji4cIXYOGRkEf58(organizationDiagram), current9);
																	num26 = 6;
																	continue;
																case 3:
																	if (nestedStructureElement != null)
																	{
																		num26 = 0;
																		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
																		{
																			num26 = 1;
																		}
																		continue;
																	}
																	break;
																case 1:
																	addSubElement(nestedStructureElement, organizationDiagram, organizationSubDiagram);
																	num26 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
																	{
																		num26 = 0;
																	}
																	continue;
																case 7:
																	goto end_IL_4eab;
																}
																break;
															}
															continue;
															IL_4ee4:
															current9 = enumerator.Current;
															num26 = 3;
															if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
															{
																num26 = 5;
															}
															goto IL_4e45;
															continue;
															end_IL_4eab:
															break;
														}
													}
													finally
													{
														if (enumerator != null)
														{
															int num27 = 1;
															if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
															{
																num27 = 1;
															}
															while (true)
															{
																switch (num27)
																{
																case 1:
																	enumerator.Dispose();
																	num27 = 0;
																	if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 != 0)
																	{
																		num27 = 0;
																	}
																	continue;
																case 0:
																	break;
																}
																break;
															}
														}
													}
													goto IL_4d3a;
												case 2:
													if (!ChIlBL4q5QBmlBbTNmv(current8.Id, iNA3SE4OpJM3FcyeNlK(current7)))
													{
														num25 = 15;
														goto IL_4c56;
													}
													goto case 11;
												case 11:
													list15 = current8.OrganizationSubDiagram.Elements.Where(delegate(Element e)
													{
														int num90 = 1;
														int num91 = num90;
														while (true)
														{
															switch (num91)
															{
															default:
																return e.InputConnectors.Count == 0;
															case 1:
																if (!(e is OrganizationElement))
																{
																	return false;
																}
																num91 = 0;
																if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
																{
																	num91 = 0;
																}
																break;
															}
														}
													}).ToList();
													num24 = 9;
													continue;
												case 3:
													goto end_IL_4d3a;
													IL_4c56:
													num24 = num25;
													continue;
												}
												break;
											}
											goto IL_4ca8;
											IL_4ca8:
											current8 = enumerator4.Current;
											num24 = 6;
											goto IL_4c5a;
											continue;
											end_IL_4d3a:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator4).Dispose();
										int num28 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
										{
											num28 = 0;
										}
										switch (num28)
										{
										case 0:
											break;
										}
									}
									goto IL_4c20;
								case 3:
									enumerator4 = organizationSubDiagram.OrganizationSubDiagrams.GetEnumerator();
									num23 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
									{
										num23 = 0;
									}
									continue;
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
						((IDisposable)enumerator3).Dispose();
						int num29 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
						{
							num29 = 0;
						}
						switch (num29)
						{
						case 0:
							break;
						}
					}
					goto case 50;
				case 69:
					SaveElement(element, null, null, collection, list14, elementsStack);
					num = 86;
					break;
				case 74:
					text6 = (string)O01qg748hr8alYZRb5G(VSJoWR4geFYnrKAMb4u(0xAEB118D ^ 0xAEBD5F3), new object[1] { text7 });
					num2 = 51;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
					{
						num2 = 0;
					}
					continue;
				case 75:
					if (CxWs7A4GCeQbyjPiX92(list7) <= 1)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 98;
				case 81:
					xelEcA44AJ7TMVsL8XK(organizationModel, o30BfK4owa24SbeZMda(organizationModels));
					num2 = 111;
					continue;
				case 80:
					if (organizationSubDiagram.OrganizationSubDiagrams == null)
					{
						num2 = 104;
						continue;
					}
					goto case 67;
				default:
					if (organizationSubDiagram.OrganizationSubDiagrams != null)
					{
						num2 = 5;
						continue;
					}
					goto case 18;
				case 92:
					organizationModel.CreationDate = (organizationModels.ChangeDate.HasValue ? organizationModels.ChangeDate.Value : rgwTad4V7u5HIG78jHN(organizationModels));
					num2 = 79;
					continue;
				case 79:
					nwi5XJ4vo2OoHUlfI3w(organizationModel, organizationModels.ChangeAuthor ?? organizationModels.CreationAuthor);
					num = 105;
					break;
				case 18:
					enumerator8 = (from e in ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(organizationDiagram)).Where((Element e) => e is OrganizationElement).ToList()
						group e by (string)_003C_003Ec.MuyGc7pwsriCagmv12Iu(_003C_003Ec.sknmggpwEhkAPwARu50H(e))).GetEnumerator();
					num = 83;
					break;
				case 66:
					list = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(organizationDiagram)).Where(delegate(Element e)
					{
						//Discarded unreachable code: IL_0063, IL_0072
						int num74 = 1;
						int num75 = num74;
						while (true)
						{
							switch (num75)
							{
							case 2:
								return e.OutputConnectors.Count != 0;
							default:
								return false;
							case 1:
								if (!(e is NestedStructureElement))
								{
									num75 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
									{
										num75 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					}).ToList();
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 99;
					}
					continue;
				case 44:
					text7 = string.Join((string)VSJoWR4geFYnrKAMb4u(-1712587919 ^ -1712590097), list.Select((Element e) => e.Name));
					num2 = 74;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num2 = 20;
					}
					continue;
				case 70:
				case 84:
				{
					ICollection<OrganizationValidationMessage> collection6 = Messages;
					OrganizationValidationMessage organizationValidationMessage4 = new OrganizationValidationMessage();
					EN9QAg4rdY2wmqrRmQB(organizationValidationMessage4, OrganizationValidationMessageType.Error);
					oFqtyr43BqZMfDqVpIy(organizationValidationMessage4, text6);
					oRcApG4yX38ovhdO5k6(organizationValidationMessage4, list.Select((Element e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray());
					collection6.Add(organizationValidationMessage4);
					num = 94;
					break;
				}
				case 94:
					list4 = organizationDiagram.Elements.Where(delegate(Element e)
					{
						int num98 = 1;
						int num99 = num98;
						while (true)
						{
							switch (num99)
							{
							case 1:
								if (!(e is OrganizationElement))
								{
									return false;
								}
								num99 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
								{
									num99 = 0;
								}
								break;
							default:
								return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) > 1;
							}
						}
					}).ToList();
					num2 = 78;
					continue;
				case 68:
					text19 = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37FE8EDE ^ 0x37FE8740), list4.Select((Element e) => (string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)));
					num2 = 48;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num2 = 14;
					}
					continue;
				case 62:
				{
					ICollection<OrganizationValidationMessage> collection17 = Messages;
					OrganizationValidationMessage organizationValidationMessage12 = new OrganizationValidationMessage();
					EN9QAg4rdY2wmqrRmQB(organizationValidationMessage12, OrganizationValidationMessageType.Error);
					oFqtyr43BqZMfDqVpIy(organizationValidationMessage12, text24);
					oRcApG4yX38ovhdO5k6(organizationValidationMessage12, list4.Select((Element e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray());
					collection17.Add(organizationValidationMessage12);
					num2 = 101;
					continue;
				}
				case 82:
				case 101:
					list7 = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(organizationDiagram)).Where(delegate(Element e)
					{
						//Discarded unreachable code: IL_0063, IL_0072
						int num94 = 2;
						int num95 = num94;
						while (true)
						{
							switch (num95)
							{
							case 2:
								if (!(e is OrganizationElement))
								{
									num95 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
									{
										num95 = 1;
									}
									break;
								}
								goto default;
							default:
								return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) == 0;
							case 1:
								return false;
							}
						}
					}).ToList();
					num2 = 28;
					continue;
				case 98:
					text9 = string.Join((string)VSJoWR4geFYnrKAMb4u(0x1B3723C5 ^ 0x1B372A5B), list7.Select((Element e) => (string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 39;
					}
					continue;
				case 9:
				case 52:
				{
					ICollection<OrganizationValidationMessage> collection5 = Messages;
					OrganizationValidationMessage organizationValidationMessage3 = new OrganizationValidationMessage();
					EN9QAg4rdY2wmqrRmQB(organizationValidationMessage3, OrganizationValidationMessageType.Error);
					oFqtyr43BqZMfDqVpIy(organizationValidationMessage3, text5);
					oRcApG4yX38ovhdO5k6(organizationValidationMessage3, list7.Select((Element e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray());
					collection5.Add(organizationValidationMessage3);
					num2 = 4;
					continue;
				}
				case 2:
				case 4:
					list6 = organizationDiagram.Elements.OfType<OrganizationElement>().Where(delegate(OrganizationElement e)
					{
						//Discarded unreachable code: IL_003b, IL_004a
						int num96 = 2;
						int num97 = num96;
						while (true)
						{
							switch (num97)
							{
							default:
								return _003C_003Ec.LRjl4jpwYMedREuiXu5S(_003C_003Ec.sknmggpwEhkAPwARu50H(e));
							case 1:
								return false;
							case 2:
								if (e == null)
								{
									num97 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
									{
										num97 = 1;
									}
									break;
								}
								goto default;
							}
						}
					}).ToList();
					num2 = 100;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
					{
						num2 = 38;
					}
					continue;
				case 40:
				case 58:
				{
					ICollection<OrganizationValidationMessage> collection2 = Messages;
					OrganizationValidationMessage organizationValidationMessage = new OrganizationValidationMessage();
					EN9QAg4rdY2wmqrRmQB(organizationValidationMessage, OrganizationValidationMessageType.Error);
					oFqtyr43BqZMfDqVpIy(organizationValidationMessage, text2);
					organizationValidationMessage.ItemUids = list6.Select((OrganizationElement e) => _003C_003Ec.OfPLJkpwDgAOIhTGJj08(e)).ToArray();
					collection2.Add(organizationValidationMessage);
					num2 = 53;
					continue;
				}
				case 60:
					element2 = (OrganizationElement)((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(organizationDiagram)).First(delegate(Element e)
					{
						int num92 = 1;
						int num93 = num92;
						while (true)
						{
							switch (num93)
							{
							default:
								return _003C_003Ec.phJaqJpwFewv44tWFYrA(e.InputConnectors) == 0;
							case 1:
								if (!(e is OrganizationElement))
								{
									return false;
								}
								num93 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
								{
									num93 = 0;
								}
								break;
							}
						}
					});
					num2 = 37;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
					{
						num2 = 85;
					}
					continue;
				case 108:
					if (zTUY3SVXCyS0mcQYR4X(ListTreeElement) != organizationDiagram.Elements.Where((Element e) => e is OrganizationElement).Count())
					{
						num2 = 22;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 7;
				case 89:
					enumerator = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(organizationDiagram)).Where((Element e) => e is OrganizationElement).GetEnumerator();
					num2 = 71;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
					{
						num2 = 64;
					}
					continue;
				case 7:
				case 14:
				case 33:
					list5 = ((IEnumerable<Element>)uLLsji4cIXYOGRkEf58(organizationDiagram)).Where((Element e) => e is NestedStructureElement).ToList();
					num2 = 30;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 49;
					}
					continue;
				case 55:
					{
						message = CKjRwyVWQ6U6i24i52s(VSJoWR4geFYnrKAMb4u(-185816410 ^ -185833918));
						goto IL_584a;
					}
					IL_584a:
					throw new OrganizationModelPublishWarning((string)message)
					{
						mess = messages
					};
				}
				break;
			}
		}
	}

	public void FindDoubleTree(OrganizationElement element, OrganizationDiagram TreeDraftDiagram)
	{
		//Discarded unreachable code: IL_00b2, IL_00bc, IL_0188, IL_019b, IL_01ab, IL_024f, IL_025e, IL_0295, IL_02a8, IL_02b7
		int num = 1;
		int num2 = num;
		List<OrganizationElement> list = default(List<OrganizationElement>);
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		List<OrganizationElement>.Enumerator enumerator2 = default(List<OrganizationElement>.Enumerator);
		OrganizationElement current = default(OrganizationElement);
		OrganizationElement organizationElement = default(OrganizationElement);
		while (true)
		{
			switch (num2)
			{
			default:
				list = new List<OrganizationElement>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				enumerator = element.OutputConnectors.GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return;
			case 1:
				ListTreeElement.Add(iNA3SE4OpJM3FcyeNlK(element));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator2.MoveNext())
						{
							num6 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
							{
								num6 = 1;
							}
							goto IL_00c0;
						}
						goto IL_0126;
						IL_0126:
						current = enumerator2.Current;
						num6 = 2;
						goto IL_00c0;
						IL_00c0:
						while (true)
						{
							switch (num6)
							{
							case 1:
								return;
							case 2:
								_ = current.EmployeeCount;
								num6 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
								{
									num6 = 0;
								}
								continue;
							case 4:
								break;
							case 3:
								goto IL_0126;
							default:
								FindDoubleTree(current, TreeDraftDiagram);
								num6 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
								{
									num6 = 3;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_01bd;
						}
						goto IL_022d;
						IL_01bd:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 3:
								break;
							default:
							{
								list.Add(organizationElement);
								int num4 = 3;
								num3 = num4;
								continue;
							}
							case 2:
								if (organizationElement == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto default;
							case 5:
								goto IL_022d;
							case 4:
								goto end_IL_01df;
							}
							break;
						}
						continue;
						IL_022d:
						organizationElement = ARmFji41vUugm3PhcXQ(enumerator.Current) as OrganizationElement;
						num3 = 2;
						goto IL_01bd;
						continue;
						end_IL_01df:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				break;
			case 6:
				break;
			}
			enumerator2 = list.GetEnumerator();
			num2 = 5;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
			{
				num2 = 0;
			}
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
				type = InterfaceActivator.TypeOf<IOrganizationModel>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			FQ7pcKVRy5vAVmgscOc(obj, VSJoWR4geFYnrKAMb4u(-2030777218 ^ -2030795182));
			iUe3X2VwB0ccPQ0C70O(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule = new ExportRule();
			SKqp1sV2BhW22aUsr67(exportRule, type);
			FQ7pcKVRy5vAVmgscOc(exportRule, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1687496463 ^ -1687546461));
			exportRule.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			FQ7pcKVRy5vAVmgscOc(obj2, VSJoWR4geFYnrKAMb4u(-177725793 ^ -177712121));
			iUe3X2VwB0ccPQ0C70O(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule exportRule2 = new ExportRule();
			SKqp1sV2BhW22aUsr67(exportRule2, type);
			exportRule2.PropertyName = (string)VSJoWR4geFYnrKAMb4u(0x65F93013 ^ 0x65F96B09);
			exportRule2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			SKqp1sV2BhW22aUsr67(exportRule3, type);
			FQ7pcKVRy5vAVmgscOc(exportRule3, VSJoWR4geFYnrKAMb4u(-1718905545 ^ -1718932673));
			exportRule3.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			SKqp1sV2BhW22aUsr67(exportRule4, type);
			FQ7pcKVRy5vAVmgscOc(exportRule4, VSJoWR4geFYnrKAMb4u(0xD946FDB ^ 0xD94A2B1));
			iUe3X2VwB0ccPQ0C70O(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			SKqp1sV2BhW22aUsr67(exportRule5, type);
			FQ7pcKVRy5vAVmgscOc(exportRule5, VSJoWR4geFYnrKAMb4u(0x6AA79E0 ^ 0x6AAB49C));
			iUe3X2VwB0ccPQ0C70O(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule exportRule6 = new ExportRule();
			SKqp1sV2BhW22aUsr67(exportRule6, type);
			exportRule6.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1973849202 ^ -1973847024);
			exportRule6.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule6);
			return exportRuleList;
		}
	}

	private IOrganizationItem SaveElement(OrganizationElement element, IOrganizationItem parentItem, DepartmentElement departmentElement, IEnumerable<IOrganizationItem> oldItems, List<IOrganizationItem> newItems, List<OrganizationElement> elementsStack)
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
		CS_0024_003C_003E8__locals0.element = element;
		int num = elementsStack.IndexOf(CS_0024_003C_003E8__locals0.element);
		if (num >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			List<Guid> list = new List<Guid>();
			for (int j = num; j < elementsStack.Count; j++)
			{
				stringBuilder.Append(elementsStack[j].Name);
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E783828));
				list.Add(elementsStack[j].Uid);
			}
			stringBuilder.Append(CS_0024_003C_003E8__locals0.element.Name);
			string text = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4177C82C ^ 0x417705B8), stringBuilder);
			if (!ValidateOnly)
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816872067), text));
			}
			Messages.Add(new OrganizationValidationMessage
			{
				Type = OrganizationValidationMessageType.Error,
				Message = text,
				ItemUids = list.ToArray()
			});
			if (HasErrors)
			{
				throw new OrganizationModelPublishException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1973849202 ^ -1973831426)))
				{
					mess = messages
				};
			}
		}
		elementsStack = new List<OrganizationElement>(elementsStack);
		elementsStack.Add(CS_0024_003C_003E8__locals0.element);
		IOrganizationItem organizationItem = oldItems.FirstOrDefault((IOrganizationItem i) => i.Uid == _003C_003Ec__DisplayClass38_0.VAaF7Gp2Xg6Am1rHIq2Z(CS_0024_003C_003E8__locals0.element));
		if (organizationItem == null)
		{
			InstanceOf<IOrganizationItem> instanceOf = new InstanceOf<IOrganizationItem>();
			instanceOf.New.Uid = CS_0024_003C_003E8__locals0.element.Uid;
			organizationItem = instanceOf.New;
		}
		string text2 = CS_0024_003C_003E8__locals0.element.Name;
		if (!string.IsNullOrEmpty(text2) && text2.Contains(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757478097)))
		{
			text2 = string.Format(text2, (departmentElement != null) ? departmentElement.Name : string.Empty);
		}
		organizationItem.Name = ((!string.IsNullOrEmpty(text2)) ? Regex.Replace(text2.Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730080614), ""), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1027693337 ^ -1027708199), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x201ABE6B ^ 0x201A9A91)).Trim() : text2);
		if (CS_0024_003C_003E8__locals0.element is DepartmentElement)
		{
			organizationItem.ItemType = OrganizationItemType.Department;
		}
		else if (CS_0024_003C_003E8__locals0.element is PositionElement)
		{
			organizationItem.ItemType = OrganizationItemType.Position;
		}
		else if (CS_0024_003C_003E8__locals0.element is EmployeeGroupElement)
		{
			organizationItem.ItemType = OrganizationItemType.EmployeeGroup;
		}
		else if (CS_0024_003C_003E8__locals0.element is NestedStructureElement)
		{
			organizationItem.ItemType = OrganizationItemType.NestedStructure;
		}
		organizationItem.ParentItem = parentItem;
		organizationItem.IsDeleted = false;
		organizationItem.HardDelete = false;
		organizationItem.Save();
		newItems.Add(organizationItem);
		DepartmentElement departmentElement2 = ((CS_0024_003C_003E8__locals0.element is DepartmentElement) ? ((DepartmentElement)CS_0024_003C_003E8__locals0.element) : departmentElement);
		List<OrganizationElement> list2 = new List<OrganizationElement>();
		if (CS_0024_003C_003E8__locals0.element.Composition != null && CS_0024_003C_003E8__locals0.element.Composition.Count > 0)
		{
			list2.AddRange(CS_0024_003C_003E8__locals0.element.Composition);
		}
		foreach (Connector outputConnector in CS_0024_003C_003E8__locals0.element.OutputConnectors)
		{
			if (outputConnector.EndElement is OrganizationElement item)
			{
				list2.Add(item);
			}
		}
		List<OrganizationElement> list3 = ((CS_0024_003C_003E8__locals0.element is DepartmentElement) ? list2.Where(delegate(OrganizationElement e)
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 1:
					if (!(e is PositionElement))
					{
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
						{
							num3 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return _003C_003Ec.wLRN2tpwMIlKl13x8HrD((PositionElement)e);
				default:
					return false;
				}
			}
		}).ToList() : new List<OrganizationElement>());
		if (list3.Count > 1)
		{
			string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47B63F), list3.Select((OrganizationElement e) => (string)_003C_003Ec.sknmggpwEhkAPwARu50H(e)));
			Guid[] itemUids = new Guid[1] { CS_0024_003C_003E8__locals0.element.Uid };
			string text3 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x84482CB ^ 0x84445B9), CS_0024_003C_003E8__locals0.element.Name);
			if (!ValidateOnly)
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-848444002 ^ -848492740), text3));
			}
			messages.Add(new OrganizationValidationMessage
			{
				Type = OrganizationValidationMessageType.Error,
				Message = text3,
				ItemUids = itemUids
			});
			throw new OrganizationModelPublishException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DF6D2E)))
			{
				mess = messages
			};
		}
		OrganizationElement organizationElement = list3.FirstOrDefault();
		IOrganizationItem parentItem2 = organizationItem;
		if (organizationElement != null)
		{
			parentItem2 = SaveElement(organizationElement, organizationItem, departmentElement2, oldItems, newItems, elementsStack);
			list2.Remove(organizationElement);
			elementsStack.Add(organizationElement);
		}
		foreach (OrganizationElement item2 in list2)
		{
			SaveElement(item2, parentItem2, departmentElement2, oldItems, newItems, elementsStack);
		}
		return organizationItem;
	}

	public OrganizationModelManager()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		messages = new List<OrganizationValidationMessage>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static OrganizationModelManager()
	{
		zD5kRlVP6mX9uCuXtMa();
	}

	internal static bool F5dVTk4jfQ3nKaf0YRc()
	{
		return LTUgfS4Lsnhcd9nJKWh == null;
	}

	internal static OrganizationModelManager jcZOFj4H244IqrCx6nF()
	{
		return LTUgfS4Lsnhcd9nJKWh;
	}

	internal static object exZRNU4aJt48FyOMPuh(object P_0, object P_1)
	{
		return ((EntityManager<IOrganizationModel, int>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object vU5ycN4R06GAeZWM7Rx(object P_0)
	{
		return Projections.Min((IProjection)P_0);
	}

	internal static object gr8I3p4wU5BE2UroTRj(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static DateTime XIrRbi42U1DdDpiuBMO()
	{
		return DateTime.Now;
	}

	internal static void mord8o4PiGw2E9CyXIO(object P_0, DateTime value)
	{
		((IOrganizationModel)P_0).CreationDate = value;
	}

	internal static void nwi5XJ4vo2OoHUlfI3w(object P_0, object P_1)
	{
		((IOrganizationModel)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void K4Z0RS4C2f3v46TFZHu(object P_0, object P_1)
	{
		((IOrganizationModel)P_0).Description = (string)P_1;
	}

	internal static object M0LM9J4UmptKegPog4c(object P_0)
	{
		return ((IOrganizationModel)P_0).Diagram;
	}

	internal static object o30BfK4owa24SbeZMda(object P_0)
	{
		return ((IOrganizationModel)P_0).SubDiagrams;
	}

	internal static void hrpM2G4JnYlXJtIf6YQ(object P_0, object P_1)
	{
		((ISession)P_0).SaveOrUpdate(P_1);
	}

	internal static void eI1AuU4KOGmQQxD5SjU(object P_0, object P_1)
	{
		((IOrganizationModel)P_0).Diagram = (OrganizationDiagram)P_1;
	}

	internal static object mw0I6x4tWA7oZFc7gdi()
	{
		return Projections.Id();
	}

	internal static object NAExXf4hv9h1n7kfkM8(object P_0)
	{
		return Projections.Max((IProjection)P_0);
	}

	internal static Guid iNA3SE4OpJM3FcyeNlK(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static bool ChIlBL4q5QBmlBbTNmv(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object uLLsji4cIXYOGRkEf58(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static int CxWs7A4GCeQbyjPiX92(object P_0)
	{
		return ((List<Element>)P_0).Count;
	}

	internal static void YOOZgn4FpfkOPIUxx9V(object P_0, Guid P_1)
	{
		((Element)P_0).Uid = P_1;
	}

	internal static void C3Xopt40mvCPqgd4rCU(object P_0, object P_1)
	{
		((ElementList)P_0).Add((Element)P_1);
	}

	internal static void BfVgSf4EVgUEisv6lHY(object P_0, object P_1)
	{
		((Connector)P_0).EndElement = (Element)P_1;
	}

	internal static void piHrQV4DDdpyjRvsFxU(object P_0, object P_1)
	{
		((Connector)P_0).StartElement = (Element)P_1;
	}

	internal static bool u0m6wM4M5GVFqBXpRuO(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void vf623m4s8PeyGiBC8as(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int sq2rJV4YvQAJ8ZwvWxw(object P_0, object P_1)
	{
		return ((OrganizationModelManager)P_0).Publish((IOrganizationModel)P_1);
	}

	internal static object lsHJiE4IP3gXOgoBAHS(object P_0)
	{
		return ((IOrganizationModel)P_0).Description;
	}

	internal static void xelEcA44AJ7TMVsL8XK(object P_0, object P_1)
	{
		((IOrganizationModel)P_0).SubDiagrams = (OrganizationSubDiagram)P_1;
	}

	internal static DateTime rgwTad4V7u5HIG78jHN(object P_0)
	{
		return ((IOrganizationModel)P_0).CreationDate;
	}

	internal static void qgWnkC4Q7Vy9N8NKVSb(object P_0)
	{
		((Diagram)P_0).LoadDiagram();
	}

	internal static void Mmxq0h4dA022utrei7W(object P_0)
	{
		((List<OrganizationValidationMessage>)P_0).Clear();
	}

	internal static bool VRCg5B4T13g0ehZL2PN(object P_0, object P_1)
	{
		return ((ElementList)P_0).Remove((Element)P_1);
	}

	internal static object VSJoWR4geFYnrKAMb4u(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object O01qg748hr8alYZRb5G(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void EN9QAg4rdY2wmqrRmQB(object P_0, OrganizationValidationMessageType value)
	{
		((OrganizationValidationMessage)P_0).Type = value;
	}

	internal static void oFqtyr43BqZMfDqVpIy(object P_0, object P_1)
	{
		((OrganizationValidationMessage)P_0).Message = (string)P_1;
	}

	internal static void oRcApG4yX38ovhdO5k6(object P_0, object P_1)
	{
		((OrganizationValidationMessage)P_0).ItemUids = (Guid[])P_1;
	}

	internal static void HKfjaH4b4ET5wOCOU2j(object P_0, Guid value)
	{
		((OrganizationValidationMessage)P_0).SubDiagram = value;
	}

	internal static int tXVp0X4SovxlnPKviT1(object P_0)
	{
		return ((List<OrganizationElement>)P_0).Count;
	}

	internal static object F1wfPp49ak1SaAbFkRJ()
	{
		return EleWise.ELMA.Logging.Logger.Log;
	}

	internal static void dKE7k04fgEnwkY2EGyH(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object ARmFji41vUugm3PhcXQ(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static object g8Zcx44zxGCs9482XT8(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object LyF55CVkjHRrJSmpFkK(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static int nC52IsVpVSIH6v26DRy(object P_0)
	{
		return ((List<DuplicateElement>)P_0).Count;
	}

	internal static int ch3Fh1V5wVZXFNQsXdf(object P_0)
	{
		return ((ElementList)P_0).Count;
	}

	internal static object K5KdRuVAkDCv7eQpf2E(object P_0)
	{
		return ((List<Guid>)P_0).ToArray();
	}

	internal static object CKjRwyVWQ6U6i24i52s(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int zTUY3SVXCyS0mcQYR4X(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static int WobgbuVno6yETin3Pap(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static bool UsFHZLVitnydr0o4rxx(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object oWFJtEV7sWjUoYbT1sp(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object yNoD2VV6yPHQbtoCVgI(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static void xxVc9mVlWY1FLPoqZo6(object P_0, bool P_1)
	{
		((Filter)P_0).DisableSoftDeletable = P_1;
	}

	internal static object B86CsiVNudO4tGeOLbW()
	{
		return OrganizationItemManager.Instance;
	}

	internal static object z6s2JoVZJvUvIpOiWig(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void y4u8tUVxktqv2q7tGM9(object P_0, object P_1)
	{
		((ICacheService)P_0).Remove((string)P_1);
	}

	internal static bool tADNKvVBBlwQW9uqDUD(object P_0)
	{
		return ((IOrganizationItem)P_0).IsDeleted;
	}

	internal static void bOWmYiVuJwdiBFBi8gZ(object P_0, object P_1)
	{
		((IOrganizationItem)P_0).ParentItem = (IOrganizationItem)P_1;
	}

	internal static void x9sAf9Vm5UijpUDGZtl(object P_0, object P_1)
	{
		((IOrganizationItem)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object HS182BVe1FXWaxxE4Fp(object P_0)
	{
		return ((IOrganizationItem)P_0).Name;
	}

	internal static object zVj0cPVLyCX36N9R6y1(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object YRRDEwVjCH5ta0NjsY8(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static int KXOb5TVHNwEK5iWlDpG(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static long H4973yVamjRJqQ1xUJQ(object P_0)
	{
		return ((AbstractNHEntityManager<IOrganizationModel, int>)P_0).Count();
	}

	internal static void FQ7pcKVRy5vAVmgscOc(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void iUe3X2VwB0ccPQ0C70O(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static void SKqp1sV2BhW22aUsr67(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void zD5kRlVP6mX9uCuXtMa()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
