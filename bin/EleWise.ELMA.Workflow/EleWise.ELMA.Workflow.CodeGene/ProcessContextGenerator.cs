using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.CodeGeneration;

public class ProcessContextGenerator : EntityGenerator
{
	internal const string PARENT_CONTEXT_PROPERTY = "ParentContext";

	private Dictionary<int, List<EntityPropertyMetadata>> propertiesByTables;

	private List<PropertyMetadata> parentProperties;

	private List<TablePartMetadata> parentTableParts;

	private bool parentContextPropertyWritten;

	private readonly List<ISyntaxNode> propertyStaticResources;

	private bool isCompositePart;

	internal static ProcessContextGenerator RZ0lJSO8tZPVRhnj0IEs;

	protected new ProcessContextGenerationParams generationParams
	{
		get
		{
			return (ProcessContextGenerationParams)base.generationParams;
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
					base.generationParams = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
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

	protected virtual bool IsWorkflowInstanceContext => metadata is IProcessContext;

	protected override bool NeedWriteTypeUidProperty => false;

	public ProcessContextGenerator()
	{
		//Discarded unreachable code: IL_006a, IL_006f
		eTsW6aO8g0D8fdbRhqv8();
		propertiesByTables = new Dictionary<int, List<EntityPropertyMetadata>>();
		parentProperties = new List<PropertyMetadata>();
		parentTableParts = new List<TablePartMetadata>();
		propertyStaticResources = new List<ISyntaxNode>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
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
			generationParams = new ProcessContextGenerationParams();
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
			{
				num = 1;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		if (generationParams.IsFullContext)
		{
			for (int i = 0; i <= metadata.LastTableNumber; i++)
			{
				propertiesByTables.Add(i, new List<EntityPropertyMetadata>());
			}
			foreach (EntityPropertyMetadata property in metadata.Properties)
			{
				if (!propertiesByTables.TryGetValue(property.TableNumber, out var value))
				{
					value = new List<EntityPropertyMetadata>();
					propertiesByTables.Add(property.TableNumber, value);
				}
				value.Add(property);
			}
			if (!propertiesByTables.ContainsKey(0))
			{
				propertiesByTables[0] = new List<EntityPropertyMetadata>();
			}
		}
		List<ISyntaxNode> list = base.GenerateMainFile().ToList();
		if (generationParams.IsFullContext && propertiesByTables.Count > 1)
		{
			list.AddRange(propertiesByTables.SelectMany((KeyValuePair<int, List<EntityPropertyMetadata>> pair) => WriteCompositePart(pair.Key, pair.Value, (pair.Key == 0) ? metadata.TableParts : new List<TablePartMetadata>())));
		}
		if (propertyStaticResources.Count > 0)
		{
			list.Add(GetStaticResourceType());
		}
		return list;
	}

	protected override ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (ISyntaxNode)F0a7yBO8Xp6p8EHgC1f6(this);
			case 3:
				rkMLumO8cd9dEBUlhv40(metadata, mfP3XUO8BFJN97SZqFrM(0x5BCD23A0 ^ 0x5BCCB634));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return (ISyntaxNode)PbdfNdO8uDYOGsRfdi8R(qHJfWFO8dqZnmTDRbnSD(typeof(WorkflowTablePartEntity).TypeHandle));
			case 4:
				return (ISyntaxNode)PbdfNdO8uDYOGsRfdi8R(qHJfWFO8dqZnmTDRbnSD(typeof(WorkflowInstanceContext).TypeHandle));
			case 2:
				if (!OwOe29O8Pctjg6nux6M6(generationParams))
				{
					if (metadata is IProcessContext)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return base.GetBaseInterfaces().If(IsWorkflowInstanceContext, (IEnumerable<ISyntaxNode> i) => i.Concat(typeof(IWorkflowInstanceContext).CreateTypeSyntax()));
	}

	protected override IMetadata GetMetadata(Guid uid)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00db, IL_00ea
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (wUiBE0O8H3HpvaVFImxd(generationParams) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return generationParams.ParentContext;
			default:
				return (IMetadata)jyYi5XO8LWKIlbNDvtK3(this, uid);
			case 4:
				if (!FcZO71O8n1Qat7QOxFac(uid, mTVeXMO8D7g3VWGtPVFh(metadata)))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 1:
				if (generationParams != null)
				{
					num2 = 5;
					break;
				}
				goto default;
			}
		}
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6, IL_01af, IL_01be, IL_01c9, IL_02cc, IL_02df, IL_030e, IL_031d, IL_0328, IL_0369, IL_0378, IL_0383, IL_044b, IL_045e, IL_046d, IL_04ca, IL_04dd, IL_04fd, IL_050c, IL_0588, IL_0597
		int num = 2;
		List<ISyntaxNode> list = default(List<ISyntaxNode>);
		List<EntityMetadata>.Enumerator enumerator2 = default(List<EntityMetadata>.Enumerator);
		Dictionary<int, List<EntityPropertyMetadata>>.KeyCollection.Enumerator enumerator = default(Dictionary<int, List<EntityPropertyMetadata>>.KeyCollection.Enumerator);
		int current2 = default(int);
		List<TablePartMetadata>.Enumerator enumerator3 = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (F87A5nO8WoeJLSftBI4B(propertiesByTables) > 1)
					{
						num = 18;
						break;
					}
					goto case 4;
				case 16:
					type.AddAttributes(list);
					num2 = 14;
					continue;
				case 7:
					if (HZIxAIO8qGLKPNVUYRSx(generationParams) != null)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 19;
				case 13:
				case 15:
					if (!(metadata is TablePartMetadata))
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 19:
				case 20:
					if (metadata is IProcessContext)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				default:
					enumerator2 = generationParams.ParentContextList.GetEnumerator();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					list.Add((ISyntaxNode)lSrBhaO86nC2a77dI6R1(qHJfWFO8dqZnmTDRbnSD(typeof(ProcessHeaderIdAttribute).TypeHandle), new object[1] { ((IEntity<long>)HZIxAIO8qGLKPNVUYRSx(generationParams)).Id }));
					num2 = 19;
					continue;
				case 10:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator.MoveNext())
							{
								num7 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
								{
									num7 = 0;
								}
								goto IL_01cd;
							}
							goto IL_020d;
							IL_020d:
							current2 = enumerator.Current;
							num7 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
							{
								num7 = 3;
							}
							goto IL_01cd;
							IL_01cd:
							while (true)
							{
								switch (num7)
								{
								case 1:
									goto IL_020d;
								case 3:
									list.Add((ISyntaxNode)lSrBhaO86nC2a77dI6R1(qHJfWFO8dqZnmTDRbnSD(typeof(CompositeEntityPartAttribute).TypeHandle), new object[2]
									{
										((string)CX5DrlO8RoD10HbrI8wr(Q8CLLvO8jvtEYFoDEAx2(metadata), mfP3XUO8BFJN97SZqFrM(--1436248540 ^ 0x559B2098), current2)).TypeOfExpression(),
										current2
									}));
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
									{
										num7 = 0;
									}
									continue;
								case 2:
									goto end_IL_01e7;
								}
								break;
							}
							continue;
							end_IL_01e7:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 14:
					return;
				case 3:
					if (generationParams.ParentContextList == null)
					{
						num = 4;
						break;
					}
					goto default;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
								{
									num3 = 3;
								}
								goto IL_032c;
							}
							goto IL_0346;
							IL_0346:
							enumerator3 = enumerator2.Current.TableParts.GetEnumerator();
							num3 = 2;
							goto IL_032c;
							IL_032c:
							switch (num3)
							{
							case 1:
								break;
							case 2:
								try
								{
									while (true)
									{
										int num4;
										if (!enumerator3.MoveNext())
										{
											num4 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
											{
												num4 = 1;
											}
											goto IL_0387;
										}
										goto IL_03c7;
										IL_03c7:
										current = enumerator3.Current;
										num4 = 2;
										goto IL_0387;
										IL_0387:
										while (true)
										{
											switch (num4)
											{
											case 3:
												break;
											default:
												goto IL_03c7;
											case 2:
												list.Add((ISyntaxNode)lSrBhaO86nC2a77dI6R1(qHJfWFO8dqZnmTDRbnSD(typeof(TablePartAttribute).TypeHandle), new object[1] { pFXdDGO8TAZDOglAqlbk(zvuy6fO83vpIp0MDdGSr(current)) }));
												num4 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
												{
													num4 = 3;
												}
												continue;
											case 1:
												goto end_IL_03a1;
											}
											break;
										}
										continue;
										end_IL_03a1:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								continue;
							default:
								continue;
							case 3:
								goto end_IL_0478;
							}
							goto IL_0346;
							continue;
							end_IL_0478:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 17:
					list = new List<ISyntaxNode>();
					num2 = 5;
					continue;
				case 18:
					enumerator = propertiesByTables.Keys.GetEnumerator();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					rkMLumO8cd9dEBUlhv40(metadata, mfP3XUO8BFJN97SZqFrM(-1716629332 ^ -1716533960));
					num2 = 9;
					continue;
				case 4:
				case 11:
					if (wHbDhOO8QETYMUZxu1Mg(list) <= 0)
					{
						return;
					}
					num = 16;
					break;
				case 2:
					bIgIIWO8fJNNqAJxsHiR(type, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF419850));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (!OwOe29O8Pctjg6nux6M6(generationParams))
					{
						num2 = 13;
						continue;
					}
					goto case 8;
				case 9:
					K6gYgWO89JdePvwuHAOW(this, type);
					num2 = 17;
					continue;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetMembers_003Ed__9))]
	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetMembers_003Ed__9(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected override Accessibility CtorAccessibility()
	{
		//Discarded unreachable code: IL_005b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (metadata is TablePartMetadata)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 1:
				if (!generationParams.IsFullContext)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return kjKFDxO8p1hcpw7pfLIR(this);
			case 2:
				return Accessibility.Protected;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CCtorParameters_003Ed__11))]
	protected override IEnumerable<ISyntaxNode> CtorParameters()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCtorParameters_003Ed__11(-2)
		{
			_003C_003E4__this = this
		};
	}

	[IteratorStateMachine(typeof(_003CBaseConstructorArgs_003Ed__12))]
	protected override IEnumerable<ISyntaxNode> BaseConstructorArgs()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBaseConstructorArgs_003Ed__12(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected override IEnumerable<ISyntaxNode> WriteTablePartClasses()
	{
		string name = metadata.Name;
		try
		{
			if (generationParams.IsFullContext && propertiesByTables.Count > 1)
			{
				metadata.Name += SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E8E4ED);
			}
			return base.WriteTablePartClasses().ToArray();
		}
		finally
		{
			metadata.Name = name;
		}
	}

	protected virtual IEnumerable<ISyntaxNode> WriteCompositePart(int tableNumber, List<EntityPropertyMetadata> properties, IEnumerable<TablePartMetadata> tableParts)
	{
		try
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			isCompositePart = true;
			ISyntaxNode propertyTypeReference = ((ITypeGenerationInfo)GetIdTypeDescriptor()).GetPropertyTypeReference(metadata, null, forFilter: false);
			ISyntaxNode baseType = typeof(Entity<>).CreateTypeSyntax(propertyTypeReference);
			CS_0024_003C_003E8__locals0.ctorStatements = new List<ISyntaxNode>();
			IEnumerable<ISyntaxNode> members = properties.SelectMany((EntityPropertyMetadata propertyMetadata) => CS_0024_003C_003E8__locals0._003C_003E4__this.WriteProperty(propertyMetadata, CS_0024_003C_003E8__locals0.ctorStatements)).Concat(tableParts.EmptyIfNull().SelectMany((TablePartMetadata tp) => CS_0024_003C_003E8__locals0._003C_003E4__this.WriteTablePartProperty(tp, CS_0024_003C_003E8__locals0.ctorStatements, writeAttributes: false))).ToArray()
				.Prepend(SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Public, DeclarationModifiers.None, null, CS_0024_003C_003E8__locals0.ctorStatements));
			ISyntaxNode syntaxNode = typeof(ICompositeWorkflowInstanceContext).CreateTypeSyntax();
			ISyntaxNode[] interfaceTypes = new ISyntaxNode[1] { syntaxNode };
			ISyntaxNode syntaxNode2 = (metadata.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197760124) + tableNumber).ClassDeclaration(Accessibility.Public, DeclarationModifiers.Partial, baseType, interfaceTypes, members);
			syntaxNode2.AddAttributes(typeof(MetadataTypeAttribute).CreateAttribute(typeof(EntityMetadata)), typeof(EntityAttribute).CreateAttribute(GetTableName(tableNumber)), typeof(CompositeRootEntityAttribute).CreateAttribute(metadata.Name.TypeOfExpression()));
			return Enumerable.Repeat(syntaxNode2, 1);
		}
		finally
		{
			isCompositePart = false;
		}
	}

	[IteratorStateMachine(typeof(_003CGetProperties_003Ed__17))]
	protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetProperties_003Ed__17(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__ctorStatements = ctorStatements
		};
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		Contract.ArgumentNotNull(ctorStatements, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790120392));
		Contract.ArgumentNotNull(propertyMetadata, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62817D72));
		Contract.CheckArgument(propertyMetadata is EntityPropertyMetadata, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x6143E13F));
		if (generationParams.IsFullContext)
		{
			return base.WriteProperty(propertyMetadata, ctorStatements, writeAttributes, propertyAction);
		}
		ISyntaxNode propertyTypeReference = ((ITypeGenerationInfo)GetPropertyTypeDescriptor(propertyMetadata)).GetPropertyTypeReference(metadata, propertyMetadata, forFilter: false);
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		List<ISyntaxNode> list2 = new List<ISyntaxNode>();
		if (!(metadata is TablePartMetadata) && propertyMetadata.Name == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EF58C9))
		{
			list2.Add(SyntaxGeneratorExtensions.Value.ValueEqualsExpression(SyntaxGeneratorExtensions.Null).IfStatement(new ISyntaxNode[1] { SyntaxGeneratorExtensions.ThrowStatement(typeof(InvalidOperationException).CreateTypeSyntax().ObjectCreationExpression(GetLocalizableExpression(SR.M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801788309)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111241679)))) }));
		}
		if (parentProperties.Contains(propertyMetadata))
		{
			list.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x350634C).IdentifierName().MemberAccessExpression(propertyMetadata.Name)
				.ReturnStatement());
			list2.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965251351).IdentifierName().MemberAccessExpression(propertyMetadata.Name)
				.AssignmentStatement(SyntaxGeneratorExtensions.Value));
		}
		else if (metadata is TablePartMetadata && propertyMetadata.Uid == ((TablePartMetadata)metadata).ParentPropertyUid)
		{
			list.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738B2C5A).GenericName(propertyTypeReference).InvocationExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD31CA9A).InvocationExpression(propertyMetadata.Uid.ToString().CreateSyntaxNode()))
				.ReturnStatement());
			list2.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483E340E).InvocationExpression(propertyMetadata.Uid.ToString().CreateSyntaxNode(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763704145).GenericName(propertyTypeReference).InvocationExpression(SyntaxGeneratorExtensions.Value)));
		}
		else
		{
			list.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865307436).InvocationExpression(propertyMetadata.Uid.ToString().CreateSyntaxNode()).CastExpression(propertyTypeReference)
				.ReturnStatement());
			list2.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980670888).InvocationExpression(propertyMetadata.Uid.ToString().CreateSyntaxNode(), SyntaxGeneratorExtensions.Value));
		}
		ISyntaxNode syntaxNode = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, DeclarationModifiers.Virtual, list, list2);
		WritePropertyComments(syntaxNode, propertyMetadata);
		WritePropertyAttributes(syntaxNode, propertyMetadata);
		propertyAction?.Invoke(syntaxNode);
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected ISyntaxNode WriteGetParentContextProperty()
	{
		//Discarded unreachable code: IL_0084
		int num = 3;
		int num2 = num;
		ISyntaxNode type = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 3:
				rkMLumO8cd9dEBUlhv40(generationParams.ParentContext, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028826833));
				num2 = 2;
				break;
			default:
				type = ((string)QTQXD8O8CKRCSGrFSR19(wUiBE0O8H3HpvaVFImxd(generationParams))).CreateTypeSyntax();
				num2 = 5;
				break;
			case 4:
				return null;
			case 1:
				parentContextPropertyWritten = true;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539957577).PropertyDeclaration(type, Accessibility.Public, DeclarationModifiers.None, new ISyntaxNode[3]
				{
					((ISyntaxNode)FuEWe4O8MZjMvQ9tJSCM(((string)mfP3XUO8BFJN97SZqFrM(-135674354 ^ -135684444)).IdentifierName(), SyntaxGeneratorExtensions.Null)).IfStatement(new ISyntaxNode[1] { (ISyntaxNode)C66l0cO8UDUcRV3LqguX(MIiVMEO8kQkfOmU8dffq(PbdfNdO8uDYOGsRfdi8R(qHJfWFO8dqZnmTDRbnSD(typeof(Exception).TypeHandle)), new ISyntaxNode[1] { mfP3XUO8BFJN97SZqFrM(--1436248540 ^ 0x559AFED4).CreateSyntaxNode() })) }),
					((ISyntaxNode)lJZQsUO8AQKn3GWggOw6(wbXUgKO8VHEix1tNMEfI(mfP3XUO8BFJN97SZqFrM(0x1C663DA1 ^ 0x1C66650B)), mfP3XUO8BFJN97SZqFrM(0x1927DA93 ^ 0x1926F1FF))).ValueEqualsExpression((ISyntaxNode)icVnBLO8GyupDDUuSCun()).IfStatement(new ISyntaxNode[1] { (ISyntaxNode)C66l0cO8UDUcRV3LqguX(((ISyntaxNode)PbdfNdO8uDYOGsRfdi8R(qHJfWFO8dqZnmTDRbnSD(typeof(Exception).TypeHandle))).ObjectCreationExpression((ISyntaxNode)vbZk4WO87JcgpVbU366d(mfP3XUO8BFJN97SZqFrM(-1303601216 ^ -1303574276)))) }),
					(ISyntaxNode)dlY537O82QdJvsTJ0OBa(((ISyntaxNode)lJZQsUO8AQKn3GWggOw6(((ISyntaxNode)wbXUgKO8VHEix1tNMEfI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398709535))).MemberAccessExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F71F2C)), mfP3XUO8BFJN97SZqFrM(0x7AC609FE ^ 0x7AC61966))).CastExpression(type))
				});
			case 2:
				if (!parentContextPropertyWritten)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	protected override IEnumerable<ISyntaxTrivia> Resources()
	{
		return base.Resources().If(!generationParams.IsFullContext && parentProperties.Count > 0, (IEnumerable<ISyntaxTrivia> m) => m.Concat(parentProperties.Where(delegate(PropertyMetadata p)
		{
			//Discarded unreachable code: IL_0074, IL_0083
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return !_003C_003Ec.xyikQaZwEgG2FFImuKer(_003C_003Ec.EuLKUhZwheCqEjxmUESO(p), _003C_003Ec.SRmhTtZww8FInjkhXSD2(--601115071 ^ 0x23D40FC3));
				default:
					return true;
				case 1:
					if (!_003C_003Ec.saD20wZw1GHLE9L06viR(p))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}).SelectMany((PropertyMetadata p) => PropertyResources(p))));
	}

	protected override IEnumerable<ISyntaxNode> WritePropertyLocalizationDisplayNameAttribute(PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		PropertyMetadataAdditionalAttribute propertyMetadataAdditionalAttribute = ((!isCompositePart && propertyMetadata.AdditionalAttributes != null) ? propertyMetadata.AdditionalAttributes.FirstOrDefault((PropertyMetadataAdditionalAttribute p) => (string)_003C_003Ec.kGZ0vKZw40R4RutDR5Hn(p) == ProcessContextDeletedPropertyAttribute.FullName) : null);
		if (propertyMetadataAdditionalAttribute != null)
		{
			long workflowVersion = (long)propertyMetadataAdditionalAttribute.Parameters.First().Value;
			string propertyResourceName = GetPropertyResourceName(propertyMetadata, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431965012), resourcePrefix);
			propertyStaticResources.Add(ResourceClassDeletedProperty(propertyResourceName, propertyMetadata.DisplayName, workflowVersion));
			return new ISyntaxNode[1] { TypeOf<DisplayNameAttribute>.Raw.CreateAttribute(GetResourcesClassName().TypeOfExpression(), propertyResourceName) };
		}
		return base.WritePropertyLocalizationDisplayNameAttribute(propertyMetadata, resourcePrefix);
	}

	[Obsolete("Метод устарел", true)]
	protected override EntityGenerator CreateTablePartGenerator()
	{
		return (EntityGenerator)InklxdO8oEsq6qBG48b4(this, null);
	}

	protected override EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart)
	{
		return new ProcessContextGenerator();
	}

	[IteratorStateMachine(typeof(_003CWriteTablePartProperties_003Ed__26))]
	protected override IEnumerable<ISyntaxNode> WriteTablePartProperties(List<ISyntaxNode> ctorStatements)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteTablePartProperties_003Ed__26(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__ctorStatements = ctorStatements
		};
	}

	[IteratorStateMachine(typeof(_003CWriteTablePartProperty_003Ed__27))]
	protected override IEnumerable<ISyntaxNode> WriteTablePartProperty(TablePartMetadata tablePart, List<ISyntaxNode> ctorStatements, bool writeAttributes = true)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteTablePartProperty_003Ed__27(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__tablePart = tablePart,
			_003C_003E3__ctorStatements = ctorStatements,
			_003C_003E3__writeAttributes = writeAttributes
		};
	}

	private ISyntaxNode GetStaticResourceType()
	{
		return GetResourcesClassName().ClassDeclaration(Accessibility.Internal, DeclarationModifiers.None, null, null, propertyStaticResources);
	}

	private string GetResourcesClassName()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)Auu50qO8Fjhjc5sOAJi3(mfP3XUO8BFJN97SZqFrM(-885093259 ^ -885056517), metadata.TypeName);
			case 1:
				Contract.NotNull(metadata, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB31F46));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string GetPropertyResourceName(PropertyMetadata propertyMetadata, string attributeName, string prefix = null)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = prefix;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = mfP3XUO8BFJN97SZqFrM(-1716458555 ^ -1716501475);
				break;
			}
			break;
		}
		return (string)obj + (string)Q8CLLvO8jvtEYFoDEAx2(propertyMetadata) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14375304) + attributeName;
	}

	private ISyntaxNode ResourceClassDeletedProperty(string propertyName, string propertyValue, long workflowVersion)
	{
		return propertyName.PropertyDeclaration((ISyntaxNode)PbdfNdO8uDYOGsRfdi8R(TypeOf<string>.Raw), Accessibility.Public, DeclarationModifiers.Static, new ISyntaxNode[1] { GetLocalizableExpressionDeletedProperty(propertyValue, workflowVersion).ReturnStatement() });
	}

	private ISyntaxNode GetLocalizableExpressionDeletedProperty(string text, long workflowVersion)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ISyntaxNode)eOpthTO8a15OqdqC9qF5(this, mb0ewUO8In4XkUdkv6a0(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111255261)), new object[2]
				{
					eOpthTO8a15OqdqC9qF5(this, text, Array.Empty<object>()),
					workflowVersion
				});
			case 1:
				aPII33O8ihQPWws2HGk7(text, mfP3XUO8BFJN97SZqFrM(-1716458555 ^ -1716421527));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void eTsW6aO8g0D8fdbRhqv8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool IT6IEiO8bPTgJ8Ai3uYV()
	{
		return RZ0lJSO8tZPVRhnj0IEs == null;
	}

	internal static ProcessContextGenerator UKJM8dO85XMPaP4tKhKg()
	{
		return RZ0lJSO8tZPVRhnj0IEs;
	}

	internal static object mfP3XUO8BFJN97SZqFrM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void rkMLumO8cd9dEBUlhv40(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static bool OwOe29O8Pctjg6nux6M6(object P_0)
	{
		return ((ProcessContextGenerationParams)P_0).IsFullContext;
	}

	internal static object F0a7yBO8Xp6p8EHgC1f6(object P_0)
	{
		return ((EntityGenerator)P_0).GetBaseClass();
	}

	internal static Type qHJfWFO8dqZnmTDRbnSD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object PbdfNdO8uDYOGsRfdi8R(Type P_0)
	{
		return P_0.CreateTypeSyntax();
	}

	internal static Guid mTVeXMO8D7g3VWGtPVFh(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool FcZO71O8n1Qat7QOxFac(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object wUiBE0O8H3HpvaVFImxd(object P_0)
	{
		return ((ProcessContextGenerationParams)P_0).ParentContext;
	}

	internal static object jyYi5XO8LWKIlbNDvtK3(object P_0, Guid P_1)
	{
		return ((CodeGenerator)P_0).GetMetadata(P_1);
	}

	internal static void bIgIIWO8fJNNqAJxsHiR(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void K6gYgWO89JdePvwuHAOW(object P_0, object P_1)
	{
		((EntityGenerator)P_0).WriteTypeAttributes((ISyntaxNode)P_1);
	}

	internal static int F87A5nO8WoeJLSftBI4B(object P_0)
	{
		return ((Dictionary<int, List<EntityPropertyMetadata>>)P_0).Count;
	}

	internal static object Q8CLLvO8jvtEYFoDEAx2(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object CX5DrlO8RoD10HbrI8wr(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object lSrBhaO86nC2a77dI6R1(Type P_0, object P_1)
	{
		return P_0.CreateAttribute((object[])P_1);
	}

	internal static object HZIxAIO8qGLKPNVUYRSx(object P_0)
	{
		return ((ProcessContextGenerationParams)P_0).ProcessHeader;
	}

	internal static object zvuy6fO83vpIp0MDdGSr(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static object pFXdDGO8TAZDOglAqlbk(object P_0)
	{
		return ((string)P_0).TypeOfExpression();
	}

	internal static int wHbDhOO8QETYMUZxu1Mg(object P_0)
	{
		return ((List<ISyntaxNode>)P_0).Count;
	}

	internal static Accessibility kjKFDxO8p1hcpw7pfLIR(object P_0)
	{
		return ((ClassGenerator)P_0).CtorAccessibility();
	}

	internal static object QTQXD8O8CKRCSGrFSR19(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object FuEWe4O8MZjMvQ9tJSCM(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).ValueEqualsExpression((ISyntaxNode)P_1);
	}

	internal static object MIiVMEO8kQkfOmU8dffq(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).ObjectCreationExpression((ISyntaxNode[])P_1);
	}

	internal static object C66l0cO8UDUcRV3LqguX(object P_0)
	{
		return SyntaxGeneratorExtensions.ThrowStatement((ISyntaxNode)P_0);
	}

	internal static object wbXUgKO8VHEix1tNMEfI(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static object lJZQsUO8AQKn3GWggOw6(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).MemberAccessExpression((string)P_1);
	}

	internal static object icVnBLO8GyupDDUuSCun()
	{
		return SyntaxGeneratorExtensions.Null;
	}

	internal static object vbZk4WO87JcgpVbU366d(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object dlY537O82QdJvsTJ0OBa(object P_0)
	{
		return ((ISyntaxNode)P_0).ReturnStatement();
	}

	internal static object InklxdO8oEsq6qBG48b4(object P_0, object P_1)
	{
		return ((EntityGenerator)P_0).CreateTablePartGenerator((TablePartMetadata)P_1);
	}

	internal static object Auu50qO8Fjhjc5sOAJi3(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void aPII33O8ihQPWws2HGk7(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object mb0ewUO8In4XkUdkv6a0(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object eOpthTO8a15OqdqC9qF5(object P_0, object P_1, object P_2)
	{
		return ((CodeGenerator)P_0).GetLocalizableExpression((string)P_1, (object[])P_2);
	}
}
