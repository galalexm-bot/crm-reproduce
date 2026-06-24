using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

public class ConditionTableEvaluator
{
	public class OperandValue
	{
		internal static OperandValue jR28bdC1lKWbZN8l4Q32;

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
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

		public PropertyMetadata PropertyMetadata
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyMetadata_003Ek__BackingField;
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
						_003CPropertyMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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

		public OperandValue()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			FYsedDC15DlPNEZWmsCo();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Ckxp9aC1rptvgpvFXxJI()
		{
			return jR28bdC1lKWbZN8l4Q32 == null;
		}

		internal static OperandValue EqK9FZC1gWA0leLZVFbV()
		{
			return jR28bdC1lKWbZN8l4Q32;
		}

		internal static void FYsedDC15DlPNEZWmsCo()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private ConditionTable condTable;

	private object obj;

	private Dictionary<string, object> additionalParams;

	private static ConditionTableEvaluator UYVDKqbRSb71AeweDSEo;

	public static bool CheckConditionTable(ConditionTable condTable, object obj)
	{
		return CheckConditionTable(condTable, obj, null);
	}

	public static bool CheckConditionTable(ConditionTable condTable, object obj, Dictionary<string, object> additionalParams)
	{
		return new ConditionTableEvaluator
		{
			condTable = condTable,
			obj = obj,
			additionalParams = additionalParams
		}.CheckConditionTable();
	}

	private ConditionTableEvaluator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AJuBo9bRqDgGetjYFClp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private bool CheckConditionTable()
	{
		//Discarded unreachable code: IL_00a9, IL_01db, IL_01ea, IL_01fa, IL_0209, IL_023c, IL_024b, IL_025c, IL_0266, IL_028e, IL_0298, IL_033c, IL_034f, IL_035e, IL_03e7, IL_03fa, IL_0409, IL_0460, IL_04c2, IL_0526
		int num = 11;
		List<bool> list2 = default(List<bool>);
		bool flag = default(bool);
		int num3 = default(int);
		bool flag3 = default(bool);
		ConditionTable.Relation relation = default(ConditionTable.Relation);
		bool flag2 = default(bool);
		List<List<bool>>.Enumerator enumerator = default(List<List<bool>>.Enumerator);
		bool flag4 = default(bool);
		List<bool>.Enumerator enumerator2 = default(List<bool>.Enumerator);
		bool current2 = default(bool);
		List<List<bool>> list = default(List<List<bool>>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					list2.Add(!flag);
					num2 = 12;
					continue;
				case 5:
				case 22:
					flag = CheckItem(condTable.Items[num3]);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					list2 = new List<bool>();
					num2 = 13;
					continue;
				case 28:
					if (vAacdsbRX1gy6i69WFmN(list2) > 0)
					{
						num2 = 18;
						continue;
					}
					goto case 27;
				case 14:
					return flag3;
				case 6:
					goto IL_0128;
				case 1:
					list2.Add(flag);
					num2 = 24;
					continue;
				case 26:
				case 30:
					relation = condTable.Items[num3].Relation;
					num2 = 20;
					continue;
				case 7:
					list2 = new List<bool>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					list2.Add(flag);
					num2 = 29;
					continue;
				case 3:
					if (!flag2)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 1;
				case 23:
					list2.Add(!flag);
					num2 = 4;
					continue;
				case 4:
				case 8:
				case 12:
				case 24:
				case 29:
				case 32:
					flag2 = false;
					num2 = 17;
					continue;
				case 31:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
								{
									num4 = 0;
								}
								goto IL_026a;
							}
							goto IL_03a0;
							IL_03a0:
							List<bool> current = enumerator.Current;
							flag4 = true;
							enumerator2 = current.GetEnumerator();
							num4 = 2;
							goto IL_026a;
							IL_026a:
							while (true)
							{
								switch (num4)
								{
								default:
									return flag3;
								case 0:
									return flag3;
								case 2:
									try
									{
										while (true)
										{
											IL_02ea:
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
												{
													num5 = 0;
												}
												goto IL_029c;
											}
											goto IL_02c7;
											IL_02c7:
											current2 = enumerator2.Current;
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
											{
												num5 = 0;
											}
											goto IL_029c;
											IL_029c:
											while (true)
											{
												switch (num5)
												{
												default:
													flag4 = flag4 && current2;
													num5 = 3;
													continue;
												case 2:
													break;
												case 3:
													goto IL_02ea;
												case 1:
													goto end_IL_02ea;
												}
												break;
											}
											goto IL_02c7;
											continue;
											end_IL_02ea:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
										{
											num6 = 0;
										}
										switch (num6)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								case 4:
									break;
								case 1:
									flag3 = flag3 || flag4;
									num4 = 4;
									continue;
								case 3:
									goto IL_03a0;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
				case 17:
					num3++;
					num = 33;
					break;
				case 15:
					goto IL_0427;
				case 27:
					flag3 = false;
					num = 16;
					break;
				case 20:
					switch (relation)
					{
					case ConditionTable.Relation.AndNot:
						break;
					case ConditionTable.Relation.OrNot:
						goto IL_0128;
					case ConditionTable.Relation.And:
						goto IL_0427;
					default:
						goto IL_0481;
					case ConditionTable.Relation.Or:
						goto IL_0574;
					}
					goto case 21;
				case 10:
					list = new List<List<bool>>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					num3 = 0;
					num = 19;
					break;
				case 9:
					list2 = new List<bool>();
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 16;
					}
					continue;
				case 11:
					flag2 = true;
					num2 = 10;
					continue;
				case 18:
					list.Add(list2);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 2;
					}
					continue;
				case 19:
				case 33:
					if (num3 < RuYJw0bRKlvWfxnpgYB1(condTable.Items))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 28;
				case 16:
					enumerator = list.GetEnumerator();
					num2 = 31;
					continue;
				case 25:
					goto IL_0574;
					IL_0128:
					list.Add(list2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 9;
					}
					continue;
					IL_0574:
					list.Add(list2);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					continue;
					IL_0481:
					num2 = 32;
					continue;
					IL_0427:
					list2.Add(flag);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	private OperandValue CalcOperand(ConditionTable.Operand op)
	{
		//Discarded unreachable code: IL_0100, IL_0225, IL_0234
		int num = 5;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ClassMetadata classMetadata = default(ClassMetadata);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		object value = default(object);
		ConditionTable.OperandType operandType = default(ConditionTable.OperandType);
		IConditionOperandEvaluator conditionOperandEvaluator = default(IConditionOperandEvaluator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				case 9:
					propertyMetadata = classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CCalcOperand_003Eb__0);
					num2 = 8;
					continue;
				case 3:
					if (this.obj == null)
					{
						num2 = 10;
						continue;
					}
					classMetadata = MetadataLoader.LoadMetadata(this.obj.GetType()) as ClassMetadata;
					num2 = 14;
					continue;
				case 12:
				{
					OperandValue obj = new OperandValue
					{
						Value = value
					};
					c7i5XcbRk871wIRLLlbb(obj, propertyMetadata);
					return obj;
				}
				case 5:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 4;
					continue;
				default:
					operandType = b7l706bRTu863VCqnDYb(_003C_003Ec__DisplayClass8_.op);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass8_.op = op;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (propertyMetadata != null)
					{
						value = this.obj.GetType().InvokeMember(propertyMetadata.Name, BindingFlags.GetProperty, null, this.obj, null);
						num2 = 12;
						continue;
					}
					goto end_IL_0012;
				case 7:
					return null;
				case 14:
					if (classMetadata != null)
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 1:
					switch (operandType)
					{
					case ConditionTable.OperandType.Property:
						break;
					case ConditionTable.OperandType.Value:
					{
						OperandValue operandValue = new OperandValue();
						ia885JbROV0sFVxamGpf(operandValue, vOHVEGbRnU2L6nhx2iiC(_003C_003Ec__DisplayClass8_.op));
						return operandValue;
					}
					case ConditionTable.OperandType.CustomType:
						goto IL_00c2;
					default:
						goto IL_01c3;
					case ConditionTable.OperandType.GatewayVar:
						goto end_IL_0012_2;
					}
					goto case 3;
				case 11:
					if (conditionOperandEvaluator != null)
					{
						num2 = 13;
						continue;
					}
					break;
				case 10:
					return null;
				case 13:
					return conditionOperandEvaluator.Evaluate(_003C_003Ec__DisplayClass8_.op, this.obj, additionalParams);
				case 6:
					break;
					IL_01c3:
					num2 = 6;
					continue;
					IL_00c2:
					conditionOperandEvaluator = ((ComponentManager)oj5qaNbR2VpAkSK0NRmG()).GetExtensionPoints<IConditionOperandEvaluator>().FirstOrDefault(_003C_003Ec__DisplayClass8_._003CCalcOperand_003Eb__1);
					num2 = 11;
					continue;
					end_IL_0012_2:
					break;
				}
				return null;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	private static bool TryConvertOperands(object ov1, object ov2, out object v1, out object v2, out ITypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_024e, IL_025d, IL_02a2, IL_02b1, IL_031a, IL_0362, IL_0371, IL_0381, IL_03cd, IL_03dc, IL_041b, IL_0453, IL_0462, IL_0471, IL_04af, IL_04be, IL_0500, IL_0558, IL_0567, IL_0593, IL_05a2, IL_05b1, IL_05ec, IL_05fb, IL_0675, IL_0691, IL_06b5, IL_06c4, IL_06d3, IL_06f5, IL_071a, IL_0761, IL_07d4, IL_07e3, IL_07f3, IL_0802, IL_0812, IL_0821, IL_08a2, IL_08f2, IL_0901, IL_0972, IL_0a3d, IL_0a4c, IL_0a5c, IL_0a6b, IL_0a7b, IL_0a8a, IL_0d5e, IL_0d8c, IL_0dd6, IL_0de8, IL_0df7
		int num = 5;
		bool result = default(bool);
		TypeConverter converter = default(TypeConverter);
		TimeSpan result2 = default(TimeSpan);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		IConvertableTypeDescriptor convertableTypeDescriptor = default(IConvertableTypeDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (JjuDn5bRPfA5iTMRKUkm(ov1) == null)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 15:
					if (typeDescriptor != null)
					{
						num2 = 12;
						break;
					}
					goto IL_0d6a;
				case 1:
					try
					{
						int num3;
						if (v2 == null)
						{
							num3 = 16;
							goto IL_009d;
						}
						goto IL_050a;
						IL_0932:
						result = true;
						num3 = 40;
						goto IL_009d;
						IL_050a:
						converter = System.ComponentModel.TypeDescriptor.GetConverter(v2.GetType());
						int num4 = 96;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num4 = 47;
						}
						goto IL_00a1;
						IL_08b8:
						num3 = 15;
						goto IL_009d;
						IL_00a1:
						while (true)
						{
							switch (num4)
							{
							case 57:
							case 64:
								if (v1 is bool)
								{
									num4 = 59;
									continue;
								}
								goto case 1;
							case 41:
								v2 = (long)v2;
								num4 = 26;
								continue;
							case 44:
								if (!dWTLhCbRDHdHJvOgChW6(converter, v1.GetType()))
								{
									num4 = 24;
									continue;
								}
								goto case 86;
							case 9:
								result = false;
								num4 = 28;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num4 = 2;
								}
								continue;
							case 1:
								if (v1 is TimeSpan)
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 9;
							case 43:
							case 68:
								if (v1 is double)
								{
									num4 = 23;
									continue;
								}
								goto case 97;
							case 96:
								if (converter != null)
								{
									num4 = 44;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
									{
										num4 = 37;
									}
									continue;
								}
								goto IL_0ae7;
							case 66:
								v2 = result2.Ticks;
								num4 = 13;
								continue;
							case 79:
								typeDescriptor = (ITypeDescriptor)zxoXXabR3kaXDSinGsi6(Locator.GetServiceNotNull<IMetadataRuntimeService>(), ((OperandValue)ov2).PropertyMetadata.TypeUid, ((PropertyMetadata)JjuDn5bRPfA5iTMRKUkm(ov2)).SubTypeUid);
								num4 = 95;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num4 = 35;
								}
								continue;
							case 12:
								v2 = Me2nKDbR4674ucY55CfL(v1.GetType(), enumValueMetadata.Uid);
								num4 = 37;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num4 = 4;
								}
								continue;
							case 76:
								TimeSpan.TryParse(v2.ToString(), out result2);
								num4 = 66;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
								{
									num4 = 5;
								}
								continue;
							case 69:
								result = false;
								num4 = 93;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num4 = 17;
								}
								continue;
							case 19:
								break;
							case 48:
							case 87:
								if (!(v1 is short))
								{
									num4 = 74;
									continue;
								}
								goto case 4;
							case 5:
							case 13:
							case 26:
							case 27:
							case 29:
							case 39:
							case 58:
							case 75:
							case 82:
							case 88:
							case 91:
								result = true;
								num4 = 43;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num4 = 51;
								}
								continue;
							case 63:
								goto IL_050a;
							default:
								if (v2 == null)
								{
									num4 = 94;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num4 = 32;
									}
									continue;
								}
								goto case 21;
							case 6:
								result = true;
								num4 = 17;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num4 = 22;
								}
								continue;
							case 14:
								v2 = K1RB9FbRwKPlch7UGAs7(convertableTypeDescriptor, v2, JjuDn5bRPfA5iTMRKUkm(ov1));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num4 = 0;
								}
								continue;
							case 54:
								v2 = ModelHelper.GetEnumDefaultValue(v1.GetType());
								num4 = 31;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num4 = 22;
								}
								continue;
							case 81:
								if (v2 is EnumBase)
								{
									num4 = 20;
									continue;
								}
								goto case 25;
							case 52:
								if (enumValueMetadata != null)
								{
									num4 = 12;
									continue;
								}
								goto case 69;
							case 17:
								if (XVDimZbRp81dDcBVrB6p(typeDescriptor))
								{
									goto IL_0662;
								}
								goto case 15;
							case 31:
								result = true;
								num4 = 85;
								continue;
							case 20:
								goto IL_069f;
							case 25:
								enumValueMetadata = v2 as EnumValueMetadata;
								num4 = 52;
								continue;
							case 32:
							case 56:
								if (!(v1 is long))
								{
									num4 = 50;
									continue;
								}
								goto case 49;
							case 21:
								result = true;
								num4 = 61;
								continue;
							case 65:
							case 72:
							case 94:
								if (!v1.GetType().IsEnum)
								{
									num4 = 34;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
									{
										num4 = 27;
									}
									continue;
								}
								goto case 90;
							case 8:
							case 80:
								goto IL_076b;
							case 77:
								if (convertableTypeDescriptor == null)
								{
									num4 = 65;
									continue;
								}
								goto case 14;
							case 33:
							case 45:
								if (!(v1 is byte))
								{
									num4 = 87;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num4 = 73;
									}
									continue;
								}
								goto IL_0b95;
							case 18:
							case 35:
								if (v2 is long)
								{
									num4 = 41;
									continue;
								}
								goto case 10;
							case 97:
								if (!(v1 is float))
								{
									num4 = 39;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
									{
										num4 = 47;
									}
									continue;
								}
								goto case 42;
							case 53:
								if (JjuDn5bRPfA5iTMRKUkm(ov2) != null)
								{
									num4 = 79;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
									{
										num4 = 18;
									}
									continue;
								}
								goto case 83;
							case 60:
							case 74:
								if (!(v1 is int))
								{
									num4 = 32;
									continue;
								}
								goto case 62;
							case 90:
								if (v2 != null)
								{
									num4 = 30;
									continue;
								}
								goto case 54;
							case 83:
							case 95:
								if (typeDescriptor != null)
								{
									goto case 17;
								}
								goto IL_08b8;
							case 92:
								if (((PropertyMetadata)JjuDn5bRPfA5iTMRKUkm(ov2)).Nullable)
								{
									num4 = 6;
									continue;
								}
								goto case 15;
							case 37:
								result = true;
								num4 = 38;
								continue;
							case 73:
								if (!(v2 is TimeSpan))
								{
									num4 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num4 = 35;
									}
									continue;
								}
								goto case 67;
							case 78:
								goto IL_0932;
							case 34:
								if (!(v1 is EnumBase))
								{
									num4 = 68;
									continue;
								}
								goto case 90;
							case 16:
								if (ov2 != null)
								{
									goto case 53;
								}
								goto IL_095f;
							case 86:
								v2 = Ii4o5lbRtdefCVYG6LFs(converter, v2, v1.GetType());
								num4 = 19;
								continue;
							case 47:
							case 84:
								if (!(v1 is decimal))
								{
									num4 = 43;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num4 = 45;
									}
									continue;
								}
								goto IL_0b63;
							case 15:
							case 55:
								v2 = v1.GetType().DefaultValue();
								num4 = 78;
								continue;
							case 3:
								v1 = ((TimeSpan)v1).Ticks;
								num4 = 73;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num4 = 9;
								}
								continue;
							case 67:
								v2 = ((TimeSpan)v2).Ticks;
								num4 = 75;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num4 = 24;
								}
								continue;
							case 10:
								if (v2 == null)
								{
									num4 = 80;
									continue;
								}
								goto case 76;
							case 2:
							case 30:
								if (!v2.GetType().IsEnum)
								{
									num4 = 81;
									continue;
								}
								goto IL_069f;
							case 50:
							case 71:
								if (!(v1 is DateTime))
								{
									num4 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num4 = 64;
									}
									continue;
								}
								goto case 46;
							case 24:
							case 89:
								goto IL_0ae7;
							case 23:
								goto IL_0aff;
							case 42:
								v2 = ((v2 != null) ? ONub5rbR6sRWi3vt8txV(v2) : 0f);
								num4 = 84;
								continue;
							case 11:
								goto IL_0b63;
							case 36:
								goto IL_0b95;
							case 4:
								v2 = ((v2 != null) ? RrK94HbRALYod1D5yFMa(v2) : 0);
								num4 = 71;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num4 = 91;
								}
								continue;
							case 62:
								v2 = ((v2 != null) ? Convert.ToInt32(v2) : 0);
								num4 = 39;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num4 = 6;
								}
								continue;
							case 49:
								v2 = ((v2 != null) ? Convert.ToInt64(v2) : 0);
								num4 = 5;
								continue;
							case 46:
								v2 = ((v2 != null) ? pVMRRHbRxEvcrMiyrU8r(v2) : B9hyy8bR7txlmHWoag2Q(0.0));
								num4 = 88;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 60;
								}
								continue;
							case 59:
								v2 = v2 != null && p3yJGabR0vrk2xiFZKgM(v2);
								num4 = 58;
								continue;
							case 7:
								return result;
							case 22:
								return result;
							case 28:
								return result;
							case 38:
								return result;
							case 40:
								return result;
							case 51:
								return result;
							case 61:
								return result;
							case 70:
								return result;
							case 85:
								return result;
							case 93:
								return result;
							}
							break;
						}
						result = true;
						num3 = 70;
						goto IL_009d;
						IL_0b63:
						v2 = ((v2 != null) ? Convert.ToDecimal(v2) : 0m);
						num3 = 33;
						goto IL_009d;
						IL_0ae7:
						convertableTypeDescriptor = typeDescriptor as IConvertableTypeDescriptor;
						num3 = 77;
						goto IL_009d;
						IL_0aff:
						v2 = ((v2 != null) ? Convert.ToDouble(v2) : 0.0);
						num3 = 97;
						goto IL_009d;
						IL_0662:
						num3 = 92;
						goto IL_009d;
						IL_069f:
						result = true;
						num3 = 7;
						goto IL_009d;
						IL_0b95:
						v2 = ((v2 != null) ? X2A67xbRHQIBkNQYFAK7(v2) : 0);
						num3 = 82;
						goto IL_009d;
						IL_076b:
						v2 = 0L;
						num3 = 27;
						goto IL_009d;
						IL_009d:
						num4 = num3;
						goto IL_00a1;
						IL_095f:
						num3 = 83;
						goto IL_009d;
					}
					catch (Exception exception)
					{
						int num5 = 2;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 2:
								((ILogger)STLG7BbRm0jviJOIkUlX()).Error(EDHEXIbRMKbUOGr6L98f(NPuuBJbRypa1Ucusxunk(0x34185E55 ^ 0x341AE1ED), v1, v2), exception);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num6 = 0;
								}
								break;
							case 1:
								result = false;
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num6 = 0;
								}
								break;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
				case 13:
					return true;
				case 11:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					typeDescriptor = (ITypeDescriptor)zxoXXabR3kaXDSinGsi6(Locator.GetServiceNotNull<IMetadataRuntimeService>(), qPydErbR1cg1UituwUmY(((OperandValue)ov1).PropertyMetadata), NBsYfUbRN7EweqDOMqbX(JjuDn5bRPfA5iTMRKUkm(ov1)));
					num2 = 2;
					break;
				case 3:
					typeDescriptor = null;
					num2 = 10;
					break;
				case 8:
					return result;
				case 6:
					if (rAwZvjbRamPrS6fsnD6N(JjuDn5bRPfA5iTMRKUkm(ov1)))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 13;
						}
						break;
					}
					goto IL_0d6a;
				case 2:
				case 9:
				case 14:
					if (v1 != null)
					{
						num2 = 11;
						break;
					}
					goto case 15;
				case 12:
					if (XVDimZbRp81dDcBVrB6p(typeDescriptor))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0d6a;
				case 10:
					if (ov1 == null)
					{
						num2 = 14;
						break;
					}
					goto default;
				case 5:
					v1 = ((ov1 != null) ? m9CvkbbReAKPF0pFdRFk(ov1) : null);
					num2 = 4;
					break;
				case 4:
					{
						v2 = ((ov2 != null) ? m9CvkbbReAKPF0pFdRFk(ov2) : null);
						num2 = 3;
						break;
					}
					IL_0d6a:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	private void ConvertOperandsToString(ref object v1, ref object v2)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (v1 is string)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
			case 3:
				if (!(v2 is string))
				{
					num2 = 4;
					break;
				}
				return;
			case 5:
				return;
			default:
				v1 = ((v1 != null) ? v1.ToString() : string.Empty);
				num2 = 3;
				break;
			case 4:
				v2 = ((v2 != null) ? v2.ToString() : string.Empty);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private bool CheckItem(ConditionTable.Item el)
	{
		//Discarded unreachable code: IL_00de, IL_0165, IL_0174, IL_01cd, IL_01dc, IL_0295, IL_02a4, IL_0321, IL_0386, IL_0395, IL_045c, IL_046b, IL_0661
		int num = 21;
		object v = default(object);
		IEqualityTypeDescriptor equalityTypeDescriptor = default(IEqualityTypeDescriptor);
		object v2 = default(object);
		ConditionTable.Operation operation = default(ConditionTable.Operation);
		OperandValue operandValue = default(OperandValue);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		OperandValue operandValue2 = default(OperandValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (v != null)
					{
						num2 = 40;
						break;
					}
					goto case 14;
				case 15:
					return equalityTypeDescriptor.IsValuesEquals(v2, v);
				case 37:
					operation = Ehr0iIbRdjTRr02nvGgK(el);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 27;
					}
					break;
				case 38:
					return BAsIYabRL6qZVgsiKLQ7((string)v2, (string)v, StringComparison.CurrentCultureIgnoreCase);
				case 39:
					return tqWRQGbRUWe7TuWewwCw((IComparable)v2, v) >= 0;
				case 14:
				case 17:
				case 19:
				case 27:
				case 32:
				case 36:
					return false;
				case 29:
					return OWe4rfbRrbUWLGKNjYkX(eRRpn7bRjxf3Ndg7cZ7u((string)v2), eRRpn7bRjxf3Ndg7cZ7u((string)v));
				case 24:
					return OSbbXJbR5HW1A7Ow1CQp((string)v2, (string)v, StringComparison.CurrentCultureIgnoreCase);
				case 30:
					return i14iXAbRg2utZk10UhBo((string)v2, (string)v);
				case 18:
					return tqWRQGbRUWe7TuWewwCw((IComparable)v2, v) > 0;
				case 34:
					return tqWRQGbRUWe7TuWewwCw((IComparable)v2, v) <= 0;
				case 40:
					return !v2.Equals(v);
				case 9:
					goto IL_030b;
				default:
					if (v is IComparable)
					{
						num2 = 18;
						break;
					}
					goto case 14;
				case 13:
					return !OSbbXJbR5HW1A7Ow1CQp((string)v2, (string)v, StringComparison.CurrentCultureIgnoreCase);
				case 21:
					operandValue = CalcOperand((ConditionTable.Operand)vcPjv6bRJHvIUKBL7Br3(el));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 20;
					}
					break;
				case 4:
					return !OWe4rfbRrbUWLGKNjYkX((string)v2, (string)v);
				case 1:
				case 12:
				case 31:
					equalityTypeDescriptor = typeDescriptor as IEqualityTypeDescriptor;
					num2 = 37;
					break;
				case 3:
					return ((string)v2).StartsWith((string)v);
				case 42:
					return BhOrf3bRY0rMq4Kk43X4((string)v2, (string)v, StringComparison.CurrentCultureIgnoreCase);
				case 5:
					return OWe4rfbRrbUWLGKNjYkX((string)v2, (string)v);
				case 16:
					return !OWe4rfbRrbUWLGKNjYkX(eRRpn7bRjxf3Ndg7cZ7u((string)v2), eRRpn7bRjxf3Ndg7cZ7u((string)v));
				case 2:
					return v2.Equals(v);
				case 6:
					return tqWRQGbRUWe7TuWewwCw((IComparable)v2, v) < 0;
				case 22:
					if (TryConvertOperands(operandValue, operandValue2, out v2, out v, out typeDescriptor))
					{
						num2 = 12;
						break;
					}
					goto case 25;
				case 41:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					return !LFJSvjbRlLWFAceXuO36(equalityTypeDescriptor, v2, v);
				case 20:
					operandValue2 = CalcOperand((ConditionTable.Operand)cGmPjtbR9XrshY5Ws2RH(el));
					num2 = 22;
					break;
				case 35:
					switch (operation)
					{
					case ConditionTable.Operation.NotContainIC:
						break;
					case ConditionTable.Operation.EndWithIC:
						goto IL_01b4;
					case ConditionTable.Operation.NotEqualIC:
						goto IL_01fc;
					case ConditionTable.Operation.StartWith:
						goto IL_0234;
					case ConditionTable.Operation.MoreOrEqual:
						goto IL_026a;
					case ConditionTable.Operation.More:
						goto IL_02c4;
					case ConditionTable.Operation.Contain:
						goto IL_02f7;
					case ConditionTable.Operation.Equal:
						goto IL_030b;
					case ConditionTable.Operation.ContainIC:
						goto IL_035d;
					case ConditionTable.Operation.EqualIC:
						goto IL_03df;
					case ConditionTable.Operation.NotContain:
						goto IL_041a;
					case ConditionTable.Operation.StartWithIC:
						goto IL_0443;
					case ConditionTable.Operation.EndWith:
						goto IL_048a;
					case ConditionTable.Operation.Less:
						goto IL_04bf;
					case ConditionTable.Operation.LessOrEqual:
						goto IL_0506;
					default:
						goto IL_05fd;
					case ConditionTable.Operation.NotEqual:
						goto IL_066d;
					}
					ConvertOperandsToString(ref v2, ref v);
					num2 = 16;
					break;
				case 25:
					if (TryConvertOperands(operandValue2, operandValue, out v, out v2, out typeDescriptor))
					{
						num2 = 31;
						break;
					}
					goto case 41;
				case 33:
					if (v is IComparable)
					{
						num2 = 34;
						break;
					}
					goto case 14;
				case 23:
					if (v != null)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 32;
						}
						break;
					}
					goto case 11;
				case 11:
					return true;
				case 26:
					if (v != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_04df;
				case 10:
					if (!(v is IComparable))
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 39;
				case 28:
					{
						if (v is IComparable)
						{
							num2 = 6;
							break;
						}
						goto case 14;
					}
					IL_066d:
					if (equalityTypeDescriptor == null)
					{
						if (v2 != null)
						{
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 6;
							}
							break;
						}
						goto case 14;
					}
					num2 = 8;
					break;
					IL_05fd:
					num2 = 17;
					break;
					IL_0506:
					if (!(v2 is IComparable))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 27;
						}
						break;
					}
					goto case 33;
					IL_04bf:
					if (v2 is IComparable)
					{
						num2 = 28;
						break;
					}
					goto case 14;
					IL_030b:
					if (equalityTypeDescriptor == null)
					{
						if (v2 != null)
						{
							num2 = 26;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num2 = 7;
							}
							break;
						}
						goto IL_04df;
					}
					num2 = 15;
					break;
					IL_048a:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 30;
					break;
					IL_0443:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 38;
					break;
					IL_041a:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 4;
					break;
					IL_03df:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 24;
					break;
					IL_035d:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 29;
					}
					break;
					IL_02f7:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 5;
					break;
					IL_02c4:
					if (v2 is IComparable)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 14;
					IL_026a:
					if (!(v2 is IComparable))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 19;
						}
						break;
					}
					goto case 10;
					IL_04df:
					if (v2 != null)
					{
						goto end_IL_0012;
					}
					goto case 23;
					IL_0234:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					break;
					IL_01fc:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 13;
					}
					break;
					IL_01b4:
					ConvertOperandsToString(ref v2, ref v);
					num2 = 42;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	internal static bool I0ASuebRiEHcSoj3A2ku()
	{
		return UYVDKqbRSb71AeweDSEo == null;
	}

	internal static ConditionTableEvaluator Vj3rDgbRRvJb9QBxp8Wo()
	{
		return UYVDKqbRSb71AeweDSEo;
	}

	internal static void AJuBo9bRqDgGetjYFClp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static int RuYJw0bRKlvWfxnpgYB1(object P_0)
	{
		return ((List<ConditionTable.Item>)P_0).Count;
	}

	internal static int vAacdsbRX1gy6i69WFmN(object P_0)
	{
		return ((List<bool>)P_0).Count;
	}

	internal static ConditionTable.OperandType b7l706bRTu863VCqnDYb(object P_0)
	{
		return ((ConditionTable.Operand)P_0).Type;
	}

	internal static void c7i5XcbRk871wIRLLlbb(object P_0, object P_1)
	{
		((OperandValue)P_0).PropertyMetadata = (PropertyMetadata)P_1;
	}

	internal static object vOHVEGbRnU2L6nhx2iiC(object P_0)
	{
		return ((ConditionTable.Operand)P_0).Value;
	}

	internal static void ia885JbROV0sFVxamGpf(object P_0, object P_1)
	{
		((OperandValue)P_0).Value = P_1;
	}

	internal static object oj5qaNbR2VpAkSK0NRmG()
	{
		return ComponentManager.Current;
	}

	internal static object m9CvkbbReAKPF0pFdRFk(object P_0)
	{
		return ((OperandValue)P_0).Value;
	}

	internal static object JjuDn5bRPfA5iTMRKUkm(object P_0)
	{
		return ((OperandValue)P_0).PropertyMetadata;
	}

	internal static Guid qPydErbR1cg1UituwUmY(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid NBsYfUbRN7EweqDOMqbX(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object zxoXXabR3kaXDSinGsi6(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool XVDimZbRp81dDcBVrB6p(object P_0)
	{
		return ((ITypeDescriptor)P_0).CanBeNullable;
	}

	internal static bool rAwZvjbRamPrS6fsnD6N(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool dWTLhCbRDHdHJvOgChW6(object P_0, Type P_1)
	{
		return ((TypeConverter)P_0).CanConvertTo(P_1);
	}

	internal static object Ii4o5lbRtdefCVYG6LFs(object P_0, object P_1, Type P_2)
	{
		return ((TypeConverter)P_0).ConvertTo(P_1, P_2);
	}

	internal static object K1RB9FbRwKPlch7UGAs7(object P_0, object P_1, object P_2)
	{
		return ((IConvertableTypeDescriptor)P_0).ConvertFrom(P_1, (PropertyMetadata)P_2);
	}

	internal static object Me2nKDbR4674ucY55CfL(Type enumType, Guid uid)
	{
		return ModelHelper.GetEnumValue(enumType, uid);
	}

	internal static float ONub5rbR6sRWi3vt8txV(object P_0)
	{
		return Convert.ToSingle(P_0);
	}

	internal static byte X2A67xbRHQIBkNQYFAK7(object P_0)
	{
		return Convert.ToByte(P_0);
	}

	internal static short RrK94HbRALYod1D5yFMa(object P_0)
	{
		return Convert.ToInt16(P_0);
	}

	internal static DateTime B9hyy8bR7txlmHWoag2Q(double P_0)
	{
		return DateTime.FromOADate(P_0);
	}

	internal static DateTime pVMRRHbRxEvcrMiyrU8r(object P_0)
	{
		return Convert.ToDateTime(P_0);
	}

	internal static bool p3yJGabR0vrk2xiFZKgM(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	internal static object STLG7BbRm0jviJOIkUlX()
	{
		return Logger.Log;
	}

	internal static object NPuuBJbRypa1Ucusxunk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object EDHEXIbRMKbUOGr6L98f(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object vcPjv6bRJHvIUKBL7Br3(object P_0)
	{
		return ((ConditionTable.Item)P_0).Operand1;
	}

	internal static object cGmPjtbR9XrshY5Ws2RH(object P_0)
	{
		return ((ConditionTable.Item)P_0).Operand2;
	}

	internal static ConditionTable.Operation Ehr0iIbRdjTRr02nvGgK(object P_0)
	{
		return ((ConditionTable.Item)P_0).Operation;
	}

	internal static bool LFJSvjbRlLWFAceXuO36(object P_0, object P_1, object P_2)
	{
		return ((IEqualityTypeDescriptor)P_0).IsValuesEquals(P_1, P_2);
	}

	internal static bool OWe4rfbRrbUWLGKNjYkX(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool i14iXAbRg2utZk10UhBo(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static bool OSbbXJbR5HW1A7Ow1CQp(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object eRRpn7bRjxf3Ndg7cZ7u(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static bool BhOrf3bRY0rMq4Kk43X4(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	internal static bool BAsIYabRL6qZVgsiKLQ7(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	internal static int tqWRQGbRUWe7TuWewwCw(object P_0, object P_1)
	{
		return ((IComparable)P_0).CompareTo(P_1);
	}
}
