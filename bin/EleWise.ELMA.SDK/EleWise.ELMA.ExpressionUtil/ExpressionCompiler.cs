using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ExpressionUtil;

internal static class ExpressionCompiler
{
	private struct BlockInfo
	{
		public object VarExprs;

		public int[] VarIndexes;
	}

	[Flags]
	private enum ClosureStatus
	{
		ToBeCollected = 1,
		UserProvided = 2,
		HasClosure = 4,
		ShouldBeStaticMethod = 8
	}

	private struct ClosureInfo
	{
		public bool LastEmitIsAddress;

		private int[] _tryCatchFinallyInfos;

		public int CurrentTryCatchFinallyIndex;

		private LiveCountArray<BlockInfo> _blockStack;

		private KeyValuePair<LabelTarget, Label?>[] _labels;

		public ClosureStatus Status;

		public LiveCountArray<object> Constants;

		public ParameterExpression[] NonPassedParameters;

		public NestedLambdaInfo[] NestedLambdas;

		public LiveCountArray<int> ConstantUsage;

		private static object AIExvi8vCm5CtIgivpoW;

		public ClosureInfo(ClosureStatus status, object[] constValues = null)
		{
			ORpq0h8vZQU0lMk1BlpF();
			int num = 6;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
			{
				num = 4;
			}
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					LastEmitIsAddress = false;
					num = 5;
					break;
				case 9:
					return;
				case 8:
					NonPassedParameters = Tools.Empty<ParameterExpression>();
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num = 7;
					}
					break;
				case 5:
					CurrentTryCatchFinallyIndex = -1;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					_tryCatchFinallyInfos = null;
					num = 3;
					break;
				case 10:
					_blockStack = new LiveCountArray<BlockInfo>(Tools.Empty<BlockInfo>());
					num2 = 9;
					goto IL_0005;
				case 6:
					Status = status;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num = 0;
					}
					break;
				case 3:
					_labels = null;
					num = 10;
					break;
				case 7:
					NestedLambdas = Tools.Empty<NestedLambdaInfo>();
					num2 = 4;
					goto IL_0005;
				default:
					Constants = new LiveCountArray<object>(constValues ?? Tools.Empty<object>());
					num = 2;
					break;
				case 2:
					{
						ConstantUsage = new LiveCountArray<int>((constValues == null) ? Tools.Empty<int>() : new int[constValues.Length]);
						num = 8;
						break;
					}
					IL_0005:
					num = num2;
					break;
				}
			}
		}

		public void AddConstant(object value)
		{
			//Discarded unreachable code: IL_00cc
			int num = 7;
			object[] items = default(object[]);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 11:
						if (items[num3] == value)
						{
							num2 = 9;
							continue;
						}
						goto case 4;
					case 7:
						Status |= ClosureStatus.HasClosure;
						num2 = 6;
						continue;
					case 2:
						ConstantUsage.PushSlot(1);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 4;
						}
						continue;
					case 3:
						Constants.PushSlot(value);
						num2 = 2;
						continue;
					case 9:
						if (num3 == -1)
						{
							num2 = 3;
							continue;
						}
						ConstantUsage.Items[num3]++;
						num2 = 10;
						continue;
					case 6:
						break;
					case 10:
						return;
					default:
						if (num3 != -1)
						{
							num2 = 11;
							continue;
						}
						goto case 9;
					case 4:
						num3--;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						num3 = Constants.Count - 1;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						return;
					}
					break;
				}
				items = Constants.Items;
				num = 8;
			}
		}

		public void AddNonPassedParam(ParameterExpression expr)
		{
			//Discarded unreachable code: IL_0071, IL_0080, IL_0202, IL_029c
			int num = 18;
			ParameterExpression[] array = default(ParameterExpression[]);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 10:
						return;
					case 13:
						NonPassedParameters = new ParameterExpression[3]
						{
							NonPassedParameters[0],
							NonPassedParameters[1],
							expr
						};
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						return;
					case 12:
						goto end_IL_0012;
					case 15:
						NonPassedParameters = array;
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 10;
						}
						continue;
					case 3:
						return;
					case 7:
						num4 = 0;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
					case 9:
						if (NonPassedParameters[num4] != expr)
						{
							num4++;
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num2 = 5;
							}
						}
						else
						{
							num2 = 3;
						}
						continue;
					case 2:
						NonPassedParameters = new ParameterExpression[2]
						{
							NonPassedParameters[0],
							expr
						};
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						continue;
					case 11:
						return;
					case 16:
						Re0ZNv8vu8VoltRnhQRJ(NonPassedParameters, 0, array, 0, num3);
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 16;
						}
						continue;
					case 17:
						if (NonPassedParameters.Length != 0)
						{
							num2 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 8;
					case 18:
						Status |= ClosureStatus.HasClosure;
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 17;
						}
						continue;
					case 8:
						NonPassedParameters = new ParameterExpression[1] { expr };
						num2 = 4;
						continue;
					case 1:
					case 5:
						if (num4 < num3)
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						break;
					case 19:
						array[num3] = expr;
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 15;
						}
						continue;
					case 14:
						break;
					}
					if (NonPassedParameters.Length != 1)
					{
						if (NonPassedParameters.Length != 2)
						{
							array = new ParameterExpression[num3 + 1];
							num2 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num2 = 16;
							}
						}
						else
						{
							num2 = 13;
						}
					}
					else
					{
						num2 = 2;
					}
					continue;
					end_IL_0012:
					break;
				}
				num3 = NonPassedParameters.Length;
				num = 7;
			}
		}

		public void AddNestedLambda(NestedLambdaInfo nestedLambdaInfo)
		{
			int num = 11;
			int num2 = num;
			int num3 = default(int);
			NestedLambdaInfo[] array = default(NestedLambdaInfo[]);
			NestedLambdaInfo[] nestedLambdas = default(NestedLambdaInfo[]);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 11:
					Status |= ClosureStatus.HasClosure;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 10;
					}
					break;
				case 2:
					switch (num3)
					{
					default:
						array = new NestedLambdaInfo[num3 + 1];
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 4;
						}
						break;
					case 0:
						num2 = 5;
						break;
					case 1:
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 13;
						}
						break;
					case 2:
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 6;
						}
						break;
					}
					break;
				case 13:
					NestedLambdas = new NestedLambdaInfo[2]
					{
						nestedLambdas[0],
						nestedLambdaInfo
					};
					num2 = 12;
					break;
				case 3:
					num3 = nestedLambdas.Length;
					num2 = 2;
					break;
				case 5:
					NestedLambdas = new NestedLambdaInfo[1] { nestedLambdaInfo };
					num2 = 6;
					break;
				case 7:
					NestedLambdas = new NestedLambdaInfo[3]
					{
						nestedLambdas[0],
						nestedLambdas[1],
						nestedLambdaInfo
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					return;
				case 4:
					Re0ZNv8vu8VoltRnhQRJ(nestedLambdas, 0, array, 0, num3);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 8;
					}
					break;
				case 10:
					nestedLambdas = NestedLambdas;
					num2 = 3;
					break;
				case 8:
					array[num3] = nestedLambdaInfo;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					return;
				case 12:
					return;
				case 1:
					NestedLambdas = array;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 9;
					}
					break;
				}
			}
		}

		public void AddLabel(LabelTarget labelTarget)
		{
			//Discarded unreachable code: IL_0036, IL_0045
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 3:
					return;
				case 4:
					if (labelTarget == null)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 1:
					if (GetLabelIndex(labelTarget) != -1)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				default:
					_labels = _labels.WithLast(new KeyValuePair<LabelTarget, Label?>(labelTarget, null));
					num2 = 2;
					break;
				}
			}
		}

		public Label GetOrCreateLabel(LabelTarget labelTarget, ILGenerator il)
		{
			return GetOrCreateLabel(GetLabelIndex(labelTarget), il);
		}

		public Label GetOrCreateLabel(int index, ILGenerator il)
		{
			int num = 1;
			int num2 = num;
			KeyValuePair<LabelTarget, Label?> keyValuePair = default(KeyValuePair<LabelTarget, Label?>);
			Label? value = default(Label?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					keyValuePair = _labels[index];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return value.Value;
				default:
					value = keyValuePair.Value;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!value.HasValue)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				case 3:
				{
					KeyValuePair<LabelTarget, Label?>[] labels = _labels;
					LabelTarget key = keyValuePair.Key;
					value = of7DXT8vI7Rw4H3omHIp(il);
					labels[index] = new KeyValuePair<LabelTarget, Label?>(key, value);
					num2 = 4;
					break;
				}
				}
			}
		}

		public int GetLabelIndex(LabelTarget labelTarget)
		{
			//Discarded unreachable code: IL_0041, IL_0050, IL_0106, IL_0115
			int num = 5;
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						return -1;
					case 6:
						return num3;
					default:
						if (num3 < _labels.Length)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 7;
					case 4:
						num3 = 0;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						if (_labels != null)
						{
							goto end_IL_0012;
						}
						goto case 7;
					case 1:
					case 3:
						if (_labels[num3].Key != labelTarget)
						{
							num3++;
							num2 = 2;
							break;
						}
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 2;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
		}

		public void AddTryCatchFinallyInfo()
		{
			int num = 6;
			int[] tryCatchFinallyInfos = default(int[]);
			int[] array = default(int[]);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 9:
						Array.Copy(tryCatchFinallyInfos, array, num3);
						num2 = 2;
						continue;
					case 12:
						array = new int[num3 + 1];
						num2 = 9;
						continue;
					case 7:
						_tryCatchFinallyInfos = new int[3]
						{
							tryCatchFinallyInfos[0],
							tryCatchFinallyInfos[1],
							0
						};
						num2 = 11;
						continue;
					case 5:
						tryCatchFinallyInfos = _tryCatchFinallyInfos;
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 3;
						}
						continue;
					case 10:
						return;
					case 11:
						return;
					case 6:
						CurrentTryCatchFinallyIndex++;
						num2 = 5;
						continue;
					case 2:
						_tryCatchFinallyInfos = array;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						if (tryCatchFinallyInfos == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num2 = 0;
							}
						}
						else if (tryCatchFinallyInfos.Length != 1)
						{
							if (tryCatchFinallyInfos.Length == 2)
							{
								num2 = 7;
								continue;
							}
							num3 = tryCatchFinallyInfos.Length;
							num2 = 12;
						}
						else
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num2 = 4;
							}
						}
						continue;
					case 4:
						break;
					case 8:
						return;
					case 1:
						_tryCatchFinallyInfos = new int[1];
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 8;
						}
						continue;
					}
					break;
				}
				_tryCatchFinallyInfos = new int[2]
				{
					tryCatchFinallyInfos[0],
					0
				};
				num = 10;
			}
		}

		public void MarkAsContainsReturnGotoExpression()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (CurrentTryCatchFinallyIndex != -1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					_tryCatchFinallyInfos[CurrentTryCatchFinallyIndex] |= 1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		public void MarkReturnLabelIndex(int index)
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
					_tryCatchFinallyInfos[CurrentTryCatchFinallyIndex] |= index << 1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (CurrentTryCatchFinallyIndex != -1)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 0:
					return;
				}
			}
		}

		public bool TryCatchFinallyContainsReturnGotoExpression()
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return (_tryCatchFinallyInfos[++CurrentTryCatchFinallyIndex] & 1) != 0;
				default:
					return false;
				case 1:
					if (_tryCatchFinallyInfos == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		public object[] GetArrayOfConstantsAndNestedLambdas()
		{
			//Discarded unreachable code: IL_0131, IL_0140, IL_0150, IL_015f, IL_0202, IL_0211, IL_0221, IL_0274, IL_0283, IL_031d, IL_037d, IL_03d7, IL_0459, IL_04b3, IL_04c2
			int num = 36;
			NestedLambdaInfo nestedLambdaInfo = default(NestedLambdaInfo);
			NestedLambdaInfo[] nestedLambdas = default(NestedLambdaInfo[]);
			int num4 = default(int);
			object[] array2 = default(object[]);
			int num5 = default(int);
			NestedLambdaInfo nestedLambdaInfo2 = default(NestedLambdaInfo);
			int num6 = default(int);
			object[] array = default(object[]);
			int count = default(int);
			object[] items = default(object[]);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 16:
					case 40:
						nestedLambdaInfo = nestedLambdas[num4];
						num = 38;
						break;
					case 18:
					case 22:
						array2[num5] = new NestedLambdaWithConstantsAndNestedLambdas(nestedLambdaInfo2.Lambda, nestedLambdaInfo2.ClosureInfo.GetArrayOfConstantsAndNestedLambdas());
						num2 = 30;
						continue;
					case 25:
					case 37:
						num4++;
						num2 = 2;
						continue;
					case 28:
						num6++;
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 23;
						}
						continue;
					default:
						num5 = 0;
						num2 = 7;
						continue;
					case 6:
						return array2;
					case 14:
						array2[num5] = nestedLambdaInfo2.Lambda;
						num2 = 24;
						continue;
					case 5:
						nestedLambdaInfo2 = nestedLambdas[num5];
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 5;
						}
						continue;
					case 32:
						return array;
					case 4:
						if (nestedLambdas.Length != 0)
						{
							num2 = 8;
							continue;
						}
						goto case 11;
					case 34:
						if (count != 0)
						{
							items = Constants.Items;
							num2 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num2 = 27;
							}
						}
						else
						{
							num2 = 4;
						}
						continue;
					case 36:
						count = Constants.Count;
						num = 35;
						break;
					case 21:
						array[count + num4] = nestedLambdaInfo.Lambda;
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 37;
						}
						continue;
					case 27:
						if (nestedLambdas.Length != 0)
						{
							num2 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num2 = 13;
							}
							continue;
						}
						goto case 3;
					case 19:
						num6 = 0;
						num2 = 15;
						continue;
					case 24:
					case 30:
						num5++;
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 20;
						}
						continue;
					case 9:
						array = items;
						num = 29;
						break;
					case 10:
					case 26:
						array[num6] = items[num6];
						num2 = 28;
						continue;
					case 7:
					case 20:
						if (num5 >= nestedLambdas.Length)
						{
							num2 = 6;
							continue;
						}
						goto case 5;
					case 15:
					case 23:
						if (num6 < count)
						{
							num2 = 10;
							continue;
						}
						goto case 33;
					case 12:
					case 39:
						array[count + num4] = new NestedLambdaWithConstantsAndNestedLambdas(nestedLambdaInfo.Lambda, nestedLambdaInfo.ClosureInfo.GetArrayOfConstantsAndNestedLambdas());
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 25;
						}
						continue;
					case 1:
					case 2:
						if (num4 < nestedLambdas.Length)
						{
							num = 40;
							break;
						}
						goto case 32;
					case 38:
						if (nestedLambdaInfo.ClosureInfo.NonPassedParameters.Length != 0)
						{
							num2 = 39;
							continue;
						}
						goto case 21;
					case 35:
						nestedLambdas = NestedLambdas;
						num = 34;
						break;
					case 33:
						num4 = 0;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 1;
						}
						continue;
					case 31:
						array = new object[num3];
						num2 = 19;
						continue;
					case 11:
						return null;
					case 8:
						array2 = new object[nestedLambdas.Length];
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						continue;
					case 17:
						if (nestedLambdaInfo2.ClosureInfo.NonPassedParameters.Length != 0)
						{
							num2 = 22;
							continue;
						}
						goto case 14;
					case 3:
						return items;
					case 13:
						num3 = count + nestedLambdas.Length;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 9;
						}
						continue;
					case 29:
						if (num3 > items.Length)
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num2 = 31;
							}
							continue;
						}
						goto case 33;
					}
					break;
				}
			}
		}

		public void PushBlockWithVars(ParameterExpression blockVarExpr)
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
					_blockStack.PushSlot().VarExprs = blockVarExpr;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void PushBlockWithVars(ParameterExpression blockVarExpr, int varIndex)
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
				{
					ref BlockInfo reference = ref _blockStack.PushSlot();
					reference.VarExprs = blockVarExpr;
					reference.VarIndexes = new int[1] { varIndex };
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}

		public void PushBlockWithVars(IReadOnlyList<ParameterExpression> blockVarExprs, int[] localVarIndexes = null)
		{
			ref BlockInfo reference = ref _blockStack.PushSlot();
			reference.VarExprs = blockVarExprs;
			reference.VarIndexes = localVarIndexes;
		}

		public void PushBlockAndConstructLocalVars(IReadOnlyList<ParameterExpression> blockVarExprs, ILGenerator il)
		{
			int[] array = new int[blockVarExprs.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = il.GetNextLocalVarIndex(blockVarExprs[i].Type);
			}
			PushBlockWithVars(blockVarExprs, array);
		}

		public void PopBlock()
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
					_blockStack.Pop();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool IsLocalVar(object varParamExpr)
		{
			//Discarded unreachable code: IL_00d0, IL_00df, IL_0101, IL_01c2
			int num = 8;
			int num2 = num;
			object varExprs = default(object);
			int num4 = default(int);
			IReadOnlyList<ParameterExpression> readOnlyList = default(IReadOnlyList<ParameterExpression>);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 4:
					varExprs = _blockStack.Items[num4].VarExprs;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
				case 7:
					if (num4 <= -1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 4;
				case 13:
					if (varExprs == varParamExpr)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 3;
						}
						break;
					}
					if ((readOnlyList = varExprs as IReadOnlyList<ParameterExpression>) == null)
					{
						num2 = 10;
						break;
					}
					goto case 6;
				case 12:
					return true;
				case 3:
					return true;
				default:
					num4--;
					num2 = 2;
					break;
				case 5:
					if (readOnlyList[num3] != varParamExpr)
					{
						num3++;
						num2 = 11;
					}
					else
					{
						num2 = 12;
					}
					break;
				case 8:
					num4 = _blockStack.Count - 1;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 7;
					}
					break;
				case 6:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
				case 11:
					if (num3 >= KpSo4f8vVBWp2rJVPvJf(readOnlyList))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 9:
					return false;
				}
			}
		}

		public int GetDefinedLocalVarOrDefault(ParameterExpression varParamExpr)
		{
			//Discarded unreachable code: IL_00a1, IL_0114, IL_0123, IL_0155
			int num = 13;
			ref BlockInfo reference = default(ref BlockInfo);
			int num3 = default(int);
			int num4 = default(int);
			object varExprs = default(object);
			IReadOnlyList<ParameterExpression> readOnlyList = default(IReadOnlyList<ParameterExpression>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 8:
						return reference.VarIndexes[num3];
					case 13:
						num4 = _blockStack.Count - 1;
						num2 = 12;
						continue;
					case 2:
					case 12:
						if (num4 <= -1)
						{
							num2 = 10;
							continue;
						}
						break;
					case 10:
						return -1;
					case 6:
						num3 = 0;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 1;
						}
						continue;
					case 11:
						return reference.VarIndexes[0];
					case 14:
						num4--;
						num2 = 2;
						continue;
					case 5:
						if (varExprs != varParamExpr)
						{
							if ((readOnlyList = varExprs as IReadOnlyList<ParameterExpression>) != null)
							{
								num2 = 6;
								continue;
							}
							goto case 14;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 11;
						}
						continue;
					case 9:
						break;
					case 4:
					case 7:
						if (readOnlyList[num3] != varParamExpr)
						{
							num3++;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num2 = 0;
							}
						}
						else
						{
							num2 = 8;
						}
						continue;
					default:
						if (num3 < KpSo4f8vVBWp2rJVPvJf(readOnlyList))
						{
							num2 = 4;
							continue;
						}
						goto case 14;
					case 3:
						varExprs = reference.VarExprs;
						num2 = 5;
						continue;
					}
					break;
				}
				reference = ref _blockStack.Items[num4];
				num = 3;
			}
		}

		public bool IsTryReturnLabel(int index)
		{
			//Discarded unreachable code: IL_008f, IL_00cf, IL_010f
			int num = 3;
			int[] tryCatchFinallyInfos = default(int[]);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (tryCatchFinallyInfos == null)
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					default:
						if (num3 < tryCatchFinallyInfos.Length)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 7;
					case 3:
						goto end_IL_0012;
					case 1:
					case 6:
						if (tryCatchFinallyInfos[num3] >> 1 == index)
						{
							num2 = 9;
							continue;
						}
						num3++;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						continue;
					case 9:
						return true;
					case 7:
					case 8:
						return false;
					case 4:
						break;
					}
					num3 = 0;
					num2 = 5;
					continue;
					end_IL_0012:
					break;
				}
				tryCatchFinallyInfos = _tryCatchFinallyInfos;
				num = 2;
			}
		}

		internal static void ORpq0h8vZQU0lMk1BlpF()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool URmbJP8vvMH9Kle5UOwY()
		{
			return AIExvi8vCm5CtIgivpoW == null;
		}

		internal static object xWbDJK8v83NnrZssTgRm()
		{
			return AIExvi8vCm5CtIgivpoW;
		}

		internal static void Re0ZNv8vu8VoltRnhQRJ(object P_0, int P_1, object P_2, int P_3, int P_4)
		{
			Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
		}

		internal static Label of7DXT8vI7Rw4H3omHIp(object P_0)
		{
			return ((ILGenerator)P_0).DefineLabel();
		}

		internal static int KpSo4f8vVBWp2rJVPvJf(object P_0)
		{
			return ((IReadOnlyCollection<ParameterExpression>)P_0).Count;
		}
	}

	public class ArrayClosure
	{
		public readonly object[] ConstantsAndNestedLambdas;

		private static ArrayClosure V3lN0u8vSC8TkHvx0DsF;

		public ArrayClosure(object[] constantsAndNestedLambdas)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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
				ConstantsAndNestedLambdas = constantsAndNestedLambdas;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool fRLHr88vigSvGmIWtguD()
		{
			return V3lN0u8vSC8TkHvx0DsF == null;
		}

		internal static ArrayClosure x1tGtk8vRkqv2rU2XlAR()
		{
			return V3lN0u8vSC8TkHvx0DsF;
		}
	}

	public sealed class ArrayClosureWithNonPassedParams : ArrayClosure
	{
		public readonly object[] NonPassedParams;

		internal static ArrayClosureWithNonPassedParams uGupaD8vqWl2JETHW9V7;

		public ArrayClosureWithNonPassedParams(object[] constantsAndNestedLambdas, object[] nonPassedParams)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(constantsAndNestedLambdas);
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
					NonPassedParams = nonPassedParams;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static bool NbTO5P8vK76qQf2bsrlZ()
		{
			return uGupaD8vqWl2JETHW9V7 == null;
		}

		internal static ArrayClosureWithNonPassedParams MVQ89c8vXbExn57HYr0Q()
		{
			return uGupaD8vqWl2JETHW9V7;
		}
	}

	public sealed class NestedLambdaWithConstantsAndNestedLambdas
	{
		public static FieldInfo NestedLambdaField;

		public static FieldInfo ConstantsAndNestedLambdasField;

		public readonly object NestedLambda;

		public readonly object ConstantsAndNestedLambdas;

		internal static NestedLambdaWithConstantsAndNestedLambdas RjHRa08vT7qEBmvkbTg4;

		public NestedLambdaWithConstantsAndNestedLambdas(object nestedLambda, object constantsAndNestedLambdas)
		{
			//Discarded unreachable code: IL_001e
			mRsJ018vOZpwG5OKOCCN();
			base._002Ector();
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					ConstantsAndNestedLambdas = constantsAndNestedLambdas;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					NestedLambda = nestedLambda;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				}
			}
		}

		static NestedLambdaWithConstantsAndNestedLambdas()
		{
			int num = 3;
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
					ConstantsAndNestedLambdasField = (FieldInfo)mKpYPB8v1StVlGcAaIfc(T3E3um8veZt1UcADe8JJ(typeof(NestedLambdaWithConstantsAndNestedLambdas)), HbPjeE8vPyKKPi96MhV1(-420743386 ^ -420485228));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					mRsJ018vOZpwG5OKOCCN();
					num2 = 2;
					break;
				case 2:
					NestedLambdaField = (FieldInfo)mKpYPB8v1StVlGcAaIfc(T3E3um8veZt1UcADe8JJ(cwwuI08v2G7FrVGldgmm(typeof(NestedLambdaWithConstantsAndNestedLambdas).TypeHandle)), HbPjeE8vPyKKPi96MhV1(0x4EDCBA32 ^ 0x4ED9612A));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void mRsJ018vOZpwG5OKOCCN()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool UmHAL58vkvHbMQ9CY0rH()
		{
			return RjHRa08vT7qEBmvkbTg4 == null;
		}

		internal static NestedLambdaWithConstantsAndNestedLambdas yosSyZ8vnvfwUryMf9ix()
		{
			return RjHRa08vT7qEBmvkbTg4;
		}

		internal static Type cwwuI08v2G7FrVGldgmm(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object T3E3um8veZt1UcADe8JJ(Type P_0)
		{
			return P_0.GetTypeInfo();
		}

		internal static object HbPjeE8vPyKKPi96MhV1(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object mKpYPB8v1StVlGcAaIfc(object P_0, object P_1)
		{
			return ((TypeInfo)P_0).GetDeclaredField((string)P_1);
		}
	}

	private sealed class NestedLambdaInfo
	{
		public readonly object LambdaExpression;

		public ClosureInfo ClosureInfo;

		public object Lambda;

		public int UsageCountOrVarIndex;

		private static object M9Bxop8vNERju3IyK0F2;

		public NestedLambdaInfo(LambdaExpression lambdaExpression)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			FW5j8D8vaSVRCoV0rtXq();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 3:
					Lambda = null;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num = 0;
					}
					break;
				case 1:
					ClosureInfo = new ClosureInfo(ClosureStatus.ToBeCollected);
					num = 3;
					break;
				case 2:
					LambdaExpression = lambdaExpression;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void FW5j8D8vaSVRCoV0rtXq()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool oWEKFR8v31KisxF366XP()
		{
			return M9Bxop8vNERju3IyK0F2 == null;
		}

		internal static NestedLambdaInfo wdCpeh8vpYwmw4ijGPwZ()
		{
			return (NestedLambdaInfo)M9Bxop8vNERju3IyK0F2;
		}
	}

	internal static class CurryClosureFuncs
	{
		public static readonly MethodInfo[] Methods;

		internal static CurryClosureFuncs Ashgy48vDjss3HgQ7mES;

		public static Func<R> Curry<C, R>(Func<C, R> f, C c)
		{
			_003C_003Ec__DisplayClass1_0<C, R> _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0<C, R>();
			_003C_003Ec__DisplayClass1_.f = f;
			_003C_003Ec__DisplayClass1_.c = c;
			return () => _003C_003Ec__DisplayClass1_.f(_003C_003Ec__DisplayClass1_.c);
		}

		public static Func<T1, R> Curry<C, T1, R>(Func<C, T1, R> f, C c)
		{
			_003C_003Ec__DisplayClass2_0<C, T1, R> _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0<C, T1, R>();
			_003C_003Ec__DisplayClass2_.f = f;
			_003C_003Ec__DisplayClass2_.c = c;
			return (T1 t1) => _003C_003Ec__DisplayClass2_.f(_003C_003Ec__DisplayClass2_.c, t1);
		}

		public static Func<T1, T2, R> Curry<C, T1, T2, R>(Func<C, T1, T2, R> f, C c)
		{
			_003C_003Ec__DisplayClass3_0<C, T1, T2, R> _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0<C, T1, T2, R>();
			_003C_003Ec__DisplayClass3_.f = f;
			_003C_003Ec__DisplayClass3_.c = c;
			return (T1 t1, T2 t2) => _003C_003Ec__DisplayClass3_.f(_003C_003Ec__DisplayClass3_.c, t1, t2);
		}

		public static Func<T1, T2, T3, R> Curry<C, T1, T2, T3, R>(Func<C, T1, T2, T3, R> f, C c)
		{
			_003C_003Ec__DisplayClass4_0<C, T1, T2, T3, R> _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0<C, T1, T2, T3, R>();
			_003C_003Ec__DisplayClass4_.f = f;
			_003C_003Ec__DisplayClass4_.c = c;
			return (T1 t1, T2 t2, T3 t3) => _003C_003Ec__DisplayClass4_.f(_003C_003Ec__DisplayClass4_.c, t1, t2, t3);
		}

		public static Func<T1, T2, T3, T4, R> Curry<C, T1, T2, T3, T4, R>(Func<C, T1, T2, T3, T4, R> f, C c)
		{
			_003C_003Ec__DisplayClass5_0<C, T1, T2, T3, T4, R> _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0<C, T1, T2, T3, T4, R>();
			_003C_003Ec__DisplayClass5_.f = f;
			_003C_003Ec__DisplayClass5_.c = c;
			return (T1 t1, T2 t2, T3 t3, T4 t4) => _003C_003Ec__DisplayClass5_.f(_003C_003Ec__DisplayClass5_.c, t1, t2, t3, t4);
		}

		public static Func<T1, T2, T3, T4, T5, R> Curry<C, T1, T2, T3, T4, T5, R>(Func<C, T1, T2, T3, T4, T5, R> f, C c)
		{
			_003C_003Ec__DisplayClass6_0<C, T1, T2, T3, T4, T5, R> _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0<C, T1, T2, T3, T4, T5, R>();
			_003C_003Ec__DisplayClass6_.f = f;
			_003C_003Ec__DisplayClass6_.c = c;
			return (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => _003C_003Ec__DisplayClass6_.f(_003C_003Ec__DisplayClass6_.c, t1, t2, t3, t4, t5);
		}

		public static Func<T1, T2, T3, T4, T5, T6, R> Curry<C, T1, T2, T3, T4, T5, T6, R>(Func<C, T1, T2, T3, T4, T5, T6, R> f, C c)
		{
			_003C_003Ec__DisplayClass7_0<C, T1, T2, T3, T4, T5, T6, R> _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0<C, T1, T2, T3, T4, T5, T6, R>();
			_003C_003Ec__DisplayClass7_.f = f;
			_003C_003Ec__DisplayClass7_.c = c;
			return (T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => _003C_003Ec__DisplayClass7_.f(_003C_003Ec__DisplayClass7_.c, t1, t2, t3, t4, t5, t6);
		}

		static CurryClosureFuncs()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Methods = ((TypeInfo)Ed90rt8vHLd1JgAcMQKq(xLHGGw8v6Tcf73jW1Xxi(typeof(CurryClosureFuncs).TypeHandle))).DeclaredMethods.AsArray();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return;
				case 1:
					tlnsJT8v4P94voqGVeth();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void tlnsJT8v4P94voqGVeth()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static Type xLHGGw8v6Tcf73jW1Xxi(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object Ed90rt8vHLd1JgAcMQKq(Type P_0)
		{
			return P_0.GetTypeInfo();
		}

		internal static bool Dt74EW8vtVEGDcHkfO5D()
		{
			return Ashgy48vDjss3HgQ7mES == null;
		}

		internal static CurryClosureFuncs I4Guxq8vwAp35h9aQvSr()
		{
			return Ashgy48vDjss3HgQ7mES;
		}
	}

	internal static class CurryClosureActions
	{
		public static readonly MethodInfo[] Methods;

		internal static CurryClosureActions LbUF5Q8vAWeff57DbtNa;

		public static Action Curry<C>(Action<C> a, C c)
		{
			_003C_003Ec__DisplayClass1_0<C> _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0<C>();
			_003C_003Ec__DisplayClass1_.a = a;
			_003C_003Ec__DisplayClass1_.c = c;
			return delegate
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
						_003C_003Ec__DisplayClass1_.a(_003C_003Ec__DisplayClass1_.c);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			};
		}

		public static Action<T1> Curry<C, T1>(Action<C, T1> f, C c)
		{
			_003C_003Ec__DisplayClass2_0<C, T1> _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0<C, T1>();
			_003C_003Ec__DisplayClass2_.f = f;
			_003C_003Ec__DisplayClass2_.c = c;
			return delegate(T1 t1)
			{
				_003C_003Ec__DisplayClass2_.f(_003C_003Ec__DisplayClass2_.c, t1);
			};
		}

		public static Action<T1, T2> Curry<C, T1, T2>(Action<C, T1, T2> f, C c)
		{
			_003C_003Ec__DisplayClass3_0<C, T1, T2> _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0<C, T1, T2>();
			_003C_003Ec__DisplayClass3_.f = f;
			_003C_003Ec__DisplayClass3_.c = c;
			return delegate(T1 t1, T2 t2)
			{
				_003C_003Ec__DisplayClass3_.f(_003C_003Ec__DisplayClass3_.c, t1, t2);
			};
		}

		public static Action<T1, T2, T3> Curry<C, T1, T2, T3>(Action<C, T1, T2, T3> f, C c)
		{
			_003C_003Ec__DisplayClass4_0<C, T1, T2, T3> _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0<C, T1, T2, T3>();
			_003C_003Ec__DisplayClass4_.f = f;
			_003C_003Ec__DisplayClass4_.c = c;
			return delegate(T1 t1, T2 t2, T3 t3)
			{
				_003C_003Ec__DisplayClass4_.f(_003C_003Ec__DisplayClass4_.c, t1, t2, t3);
			};
		}

		public static Action<T1, T2, T3, T4> Curry<C, T1, T2, T3, T4>(Action<C, T1, T2, T3, T4> f, C c)
		{
			_003C_003Ec__DisplayClass5_0<C, T1, T2, T3, T4> _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0<C, T1, T2, T3, T4>();
			_003C_003Ec__DisplayClass5_.f = f;
			_003C_003Ec__DisplayClass5_.c = c;
			return delegate(T1 t1, T2 t2, T3 t3, T4 t4)
			{
				_003C_003Ec__DisplayClass5_.f(_003C_003Ec__DisplayClass5_.c, t1, t2, t3, t4);
			};
		}

		public static Action<T1, T2, T3, T4, T5> Curry<C, T1, T2, T3, T4, T5>(Action<C, T1, T2, T3, T4, T5> f, C c)
		{
			_003C_003Ec__DisplayClass6_0<C, T1, T2, T3, T4, T5> _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0<C, T1, T2, T3, T4, T5>();
			_003C_003Ec__DisplayClass6_.f = f;
			_003C_003Ec__DisplayClass6_.c = c;
			return delegate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				_003C_003Ec__DisplayClass6_.f(_003C_003Ec__DisplayClass6_.c, t1, t2, t3, t4, t5);
			};
		}

		public static Action<T1, T2, T3, T4, T5, T6> Curry<C, T1, T2, T3, T4, T5, T6>(Action<C, T1, T2, T3, T4, T5, T6> f, C c)
		{
			_003C_003Ec__DisplayClass7_0<C, T1, T2, T3, T4, T5, T6> _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0<C, T1, T2, T3, T4, T5, T6>();
			_003C_003Ec__DisplayClass7_.f = f;
			_003C_003Ec__DisplayClass7_.c = c;
			return delegate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				_003C_003Ec__DisplayClass7_.f(_003C_003Ec__DisplayClass7_.c, t1, t2, t3, t4, t5, t6);
			};
		}

		static CurryClosureActions()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					PVnFl58v0lT1Q1LWLLRO();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					Methods = ((TypeInfo)m9H5l08vmZvmfXrNrnvT(typeof(CurryClosureActions))).DeclaredMethods.AsArray();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void PVnFl58v0lT1Q1LWLLRO()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object m9H5l08vmZvmfXrNrnvT(Type P_0)
		{
			return P_0.GetTypeInfo();
		}

		internal static bool LXp2Wd8v7GahDPkHcg56()
		{
			return LbUF5Q8vAWeff57DbtNa == null;
		}

		internal static CurryClosureActions jNMSNE8vxBOHI6dUGnsX()
		{
			return LbUF5Q8vAWeff57DbtNa;
		}
	}

	[Flags]
	internal enum ParentFlags
	{
		Empty = 0,
		IgnoreResult = 2,
		Call = 4,
		MemberAccess = 8,
		Arithmetic = 0x10,
		Coalesce = 0x20,
		InstanceAccess = 0x40,
		DupMemberOwner = 0x80,
		TryCatch = 0x100,
		InstanceCall = 0x44
	}

	private static class EmittingVisitor
	{
		private static readonly object _getTypeFromHandleMethod;

		private static readonly object _objectEqualsMethod;

		private static readonly Lazy<ConstructorInfo> _decimalCtor;

		private static object KMULmi8v997Yn3cUEGre;

		public static bool TryEmit(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent, int byRefIndex = -1)
		{
			while (true)
			{
				closure.LastEmitIsAddress = false;
				switch (((Expression)expr).NodeType)
				{
				case ExpressionType.Parameter:
					if ((parent & ParentFlags.IgnoreResult) == 0)
					{
						return TryEmitParameter((ParameterExpression)expr, paramExprs, il, ref closure, parent, byRefIndex);
					}
					return true;
				case ExpressionType.Negate:
				case ExpressionType.UnaryPlus:
				case ExpressionType.NegateChecked:
				case ExpressionType.TypeAs:
				case ExpressionType.Decrement:
				case ExpressionType.Increment:
				case ExpressionType.Unbox:
				case ExpressionType.OnesComplement:
				case ExpressionType.IsTrue:
				case ExpressionType.IsFalse:
					return TryEmitSimpleUnaryExpression((UnaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Quote:
					return false;
				case ExpressionType.TypeIs:
					return TryEmitTypeIs((TypeBinaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Not:
					return TryEmitNot((UnaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Convert:
				case ExpressionType.ConvertChecked:
					return TryEmitConvert((UnaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.ArrayIndex:
				{
					BinaryExpression binaryExpression2 = (BinaryExpression)expr;
					if (TryEmit(binaryExpression2.Left, paramExprs, il, ref closure, parent) && TryEmit(binaryExpression2.Right, paramExprs, il, ref closure, parent))
					{
						return TryEmitArrayIndex(((Expression)expr).Type, il);
					}
					return false;
				}
				case ExpressionType.ArrayLength:
					return TryEmitArrayLength((UnaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Constant:
				{
					ConstantExpression constantExpression = (ConstantExpression)expr;
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						return true;
					}
					if (constantExpression.Value == null)
					{
						((ILGenerator)il).Emit(OpCodes.Ldnull);
						return true;
					}
					return TryEmitNotNullConstant(considerClosure: true, constantExpression.Type, constantExpression.Value, il, ref closure);
				}
				case ExpressionType.Call:
					return TryEmitMethodCall(expr, paramExprs, il, ref closure, parent);
				case ExpressionType.MemberAccess:
					return TryEmitMemberAccess((MemberExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.New:
					return TryEmitNew(expr, paramExprs, il, ref closure, parent);
				case ExpressionType.NewArrayInit:
				case ExpressionType.NewArrayBounds:
					return EmitNewArray((NewArrayExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.MemberInit:
					return EmitMemberInit((MemberInitExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Lambda:
					return TryEmitNestedLambda((LambdaExpression)expr, paramExprs, il, ref closure);
				case ExpressionType.Invoke:
					if (((InvocationExpression)expr).Expression is LambdaExpression lambdaExpression && lambdaExpression.Parameters.Count == 0)
					{
						expr = lambdaExpression.Body;
						break;
					}
					return TryEmitInvoke((InvocationExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Equal:
				case ExpressionType.GreaterThan:
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.LessThan:
				case ExpressionType.LessThanOrEqual:
				case ExpressionType.NotEqual:
				{
					BinaryExpression binaryExpression = (BinaryExpression)expr;
					return TryEmitComparison(binaryExpression.Left, binaryExpression.Right, binaryExpression.NodeType, paramExprs, il, ref closure, parent);
				}
				case ExpressionType.Add:
				case ExpressionType.AddChecked:
				case ExpressionType.And:
				case ExpressionType.Divide:
				case ExpressionType.ExclusiveOr:
				case ExpressionType.LeftShift:
				case ExpressionType.Modulo:
				case ExpressionType.Multiply:
				case ExpressionType.MultiplyChecked:
				case ExpressionType.Or:
				case ExpressionType.Power:
				case ExpressionType.RightShift:
				case ExpressionType.Subtract:
				case ExpressionType.SubtractChecked:
					return TryEmitArithmetic((BinaryExpression)expr, ((Expression)expr).NodeType, paramExprs, il, ref closure, parent);
				case ExpressionType.AndAlso:
				case ExpressionType.OrElse:
					return TryEmitLogicalOperator((BinaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Coalesce:
					return TryEmitCoalesceOperator((BinaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Conditional:
					return TryEmitConditional((ConditionalExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.PreIncrementAssign:
				case ExpressionType.PreDecrementAssign:
				case ExpressionType.PostIncrementAssign:
				case ExpressionType.PostDecrementAssign:
					return TryEmitIncDecAssign((UnaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Assign:
				case ExpressionType.AddAssign:
				case ExpressionType.AndAssign:
				case ExpressionType.DivideAssign:
				case ExpressionType.ExclusiveOrAssign:
				case ExpressionType.LeftShiftAssign:
				case ExpressionType.ModuloAssign:
				case ExpressionType.MultiplyAssign:
				case ExpressionType.OrAssign:
				case ExpressionType.PowerAssign:
				case ExpressionType.RightShiftAssign:
				case ExpressionType.SubtractAssign:
				case ExpressionType.AddAssignChecked:
				case ExpressionType.MultiplyAssignChecked:
				case ExpressionType.SubtractAssignChecked:
					return TryEmitAssign((BinaryExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Block:
				{
					BlockExpression blockExpression = (BlockExpression)expr;
					ReadOnlyCollection<ParameterExpression> variables = blockExpression.Variables;
					int count = variables.Count;
					if (count == 1)
					{
						closure.PushBlockWithVars(variables[0], ((ILGenerator)il).GetNextLocalVarIndex(variables[0].Type));
					}
					else if (count > 1)
					{
						closure.PushBlockAndConstructLocalVars(variables, (ILGenerator)il);
					}
					ReadOnlyCollection<Expression> expressions = blockExpression.Expressions;
					int num = expressions.Count;
					expr = expressions[num - 1];
					if (num > 1)
					{
						int num2 = num - 1;
						while (num2 != -1 && expressions[num2].NodeType != ExpressionType.Throw)
						{
							num2--;
						}
						if (num2 != -1 && num2 != num - 1)
						{
							expr = Expression.Throw(((UnaryExpression)expressions[num2]).Operand, blockExpression.Type);
							num = num2 + 1;
						}
					}
					if (num > 1)
					{
						for (int i = 0; i < num - 1; i++)
						{
							if (!TryEmit(expressions[i], paramExprs, il, ref closure, parent | ParentFlags.IgnoreResult))
							{
								return false;
							}
						}
					}
					if (count != 0)
					{
						if (!TryEmit(expr, paramExprs, il, ref closure, parent))
						{
							return false;
						}
						closure.PopBlock();
						return true;
					}
					break;
				}
				case ExpressionType.Loop:
					return TryEmitLoop((LoopExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Try:
					return TryEmitTryCatchFinallyBlock((TryExpression)expr, paramExprs, il, ref closure, parent | ParentFlags.TryCatch);
				case ExpressionType.Throw:
					if (!TryEmit(((UnaryExpression)expr).Operand, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult))
					{
						return false;
					}
					((ILGenerator)il).Emit(OpCodes.Throw);
					return true;
				case ExpressionType.Default:
					if (((Expression)expr).Type != typeof(void) && (parent & ParentFlags.IgnoreResult) == 0)
					{
						EmitDefault(((Expression)expr).Type, il);
					}
					return true;
				case ExpressionType.Index:
					return TryEmitIndex((IndexExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Goto:
					return TryEmitGoto((GotoExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Label:
					return TryEmitLabel((LabelExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Switch:
					return TryEmitSwitch((SwitchExpression)expr, paramExprs, il, ref closure, parent);
				case ExpressionType.Extension:
					expr = ((Expression)expr).Reduce();
					break;
				default:
					return false;
				}
			}
		}

		private static bool TryEmitNew(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			NewExpression newExpression = (NewExpression)expr;
			ReadOnlyCollection<Expression> arguments = newExpression.Arguments;
			if (arguments.Count != 0)
			{
				ParameterInfo[] parameters = newExpression.Constructor.GetParameters();
				for (int i = 0; i < parameters.Length; i++)
				{
					if (!TryEmit(arguments[i], paramExprs, il, ref closure, parent, parameters[i].ParameterType.IsByRef ? i : (-1)))
					{
						return false;
					}
				}
			}
			if (newExpression.Constructor != null)
			{
				((ILGenerator)il).Emit(OpCodes.Newobj, newExpression.Constructor);
			}
			else
			{
				if (!newExpression.Type.IsValueType())
				{
					return false;
				}
				EmitLoadLocalVariable(il, InitValueTypeVariable(il, newExpression.Type));
			}
			return true;
		}

		private static bool TryEmitArrayLength(object arrLengthExpr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			if (!TryEmit(((UnaryExpression)arrLengthExpr).Operand, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			if ((parent & ParentFlags.IgnoreResult) == 0)
			{
				((ILGenerator)il).Emit(OpCodes.Ldlen);
				((ILGenerator)il).Emit(OpCodes.Conv_I4);
			}
			return true;
		}

		private static bool TryEmitLoop(object loopExpr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Label label = ((ILGenerator)il).DefineLabel();
			((ILGenerator)il).MarkLabel(label);
			if (((LoopExpression)loopExpr).ContinueLabel != null)
			{
				((ILGenerator)il).MarkLabel(closure.GetOrCreateLabel(((LoopExpression)loopExpr).ContinueLabel, (ILGenerator)il));
			}
			if (!TryEmit(((LoopExpression)loopExpr).Body, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			((ILGenerator)il).Emit(OpCodes.Br, label);
			if (((LoopExpression)loopExpr).BreakLabel != null)
			{
				((ILGenerator)il).MarkLabel(closure.GetOrCreateLabel(((LoopExpression)loopExpr).BreakLabel, (ILGenerator)il));
			}
			return true;
		}

		private static bool TryEmitIndex(object indexExpr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			if (((IndexExpression)indexExpr).Object != null && !TryEmit(((IndexExpression)indexExpr).Object, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			ReadOnlyCollection<Expression> arguments = ((IndexExpression)indexExpr).Arguments;
			for (int i = 0; i < arguments.Count; i++)
			{
				if (!TryEmit(arguments[i], paramExprs, il, ref closure, parent, arguments[i].Type.IsByRef ? i : (-1)))
				{
					return false;
				}
			}
			PropertyInfo indexer = ((IndexExpression)indexExpr).Indexer;
			if (indexer != null)
			{
				return EmitMethodCall(il, indexer.DeclaringType.FindPropertyGetMethod(indexer.Name));
			}
			if (((IndexExpression)indexExpr).Arguments.Count == 1)
			{
				return TryEmitArrayIndex(((Expression)indexExpr).Type, il);
			}
			return EmitMethodCall(il, ((IndexExpression)indexExpr).Object?.Type.FindMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766039054)));
		}

		private static bool TryEmitLabel(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			int labelIndex = closure.GetLabelIndex(((LabelExpression)expr).Target);
			if (labelIndex == -1)
			{
				return false;
			}
			if (closure.IsTryReturnLabel(labelIndex))
			{
				return true;
			}
			Label orCreateLabel = closure.GetOrCreateLabel(labelIndex, (ILGenerator)il);
			((ILGenerator)il).MarkLabel(orCreateLabel);
			if (((LabelExpression)expr).DefaultValue != null)
			{
				return TryEmit(((LabelExpression)expr).DefaultValue, paramExprs, il, ref closure, parent);
			}
			return true;
		}

		private static bool TryEmitGoto(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			int labelIndex = closure.GetLabelIndex(((GotoExpression)expr).Target);
			if (labelIndex == -1)
			{
				if ((closure.Status & ClosureStatus.ToBeCollected) == 0)
				{
					return false;
				}
				throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -630157802));
			}
			if (((GotoExpression)expr).Value != null && !TryEmit(((GotoExpression)expr).Value, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult))
			{
				return false;
			}
			switch (((GotoExpression)expr).Kind)
			{
			case GotoExpressionKind.Break:
			case GotoExpressionKind.Continue:
				((ILGenerator)il).Emit(OpCodes.Br, closure.GetOrCreateLabel(labelIndex, (ILGenerator)il));
				return true;
			case GotoExpressionKind.Goto:
				if (((GotoExpression)expr).Value == null)
				{
					((ILGenerator)il).Emit(OpCodes.Br, closure.GetOrCreateLabel(labelIndex, (ILGenerator)il));
					return true;
				}
				goto case GotoExpressionKind.Return;
			case GotoExpressionKind.Return:
				if ((parent & ParentFlags.TryCatch) != 0)
				{
					closure.MarkReturnLabelIndex(labelIndex);
				}
				else
				{
					((ILGenerator)il).Emit(OpCodes.Ret, closure.GetOrCreateLabel(labelIndex, (ILGenerator)il));
				}
				return true;
			default:
				return false;
			}
		}

		private static bool TryEmitCoalesceOperator(object exprObj, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Label label = ((ILGenerator)il).DefineLabel();
			Label label2 = ((ILGenerator)il).DefineLabel();
			Expression left = ((BinaryExpression)exprObj).Left;
			Expression right = ((BinaryExpression)exprObj).Right;
			if (!TryEmit(left, paramExprs, il, ref closure, parent | ParentFlags.Coalesce))
			{
				return false;
			}
			Type type = left.Type;
			if (type.IsValueType())
			{
				int location = EmitStoreLocalVariableAndLoadItsAddress(il, type);
				((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableHasValueGetterMethod());
				((ILGenerator)il).Emit(OpCodes.Brfalse, label);
				EmitLoadLocalVariableAddress(il, location);
				((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableGetValueOrDefaultMethod());
				((ILGenerator)il).Emit(OpCodes.Br, label2);
				((ILGenerator)il).MarkLabel(label);
				if (!TryEmit(right, paramExprs, il, ref closure, parent | ParentFlags.Coalesce))
				{
					return false;
				}
				((ILGenerator)il).MarkLabel(label2);
				return true;
			}
			((ILGenerator)il).Emit(OpCodes.Dup);
			((ILGenerator)il).Emit(OpCodes.Ldnull);
			((ILGenerator)il).Emit(OpCodes.Ceq);
			((ILGenerator)il).Emit(OpCodes.Brfalse, label);
			((ILGenerator)il).Emit(OpCodes.Pop);
			if (!TryEmit(right, paramExprs, il, ref closure, parent | ParentFlags.Coalesce))
			{
				return false;
			}
			if (right.Type != ((Expression)exprObj).Type && right.Type.IsValueType())
			{
				((ILGenerator)il).Emit(OpCodes.Box, right.Type);
			}
			if (left.Type == ((Expression)exprObj).Type)
			{
				((ILGenerator)il).MarkLabel(label);
			}
			else
			{
				((ILGenerator)il).Emit(OpCodes.Br, label2);
				((ILGenerator)il).MarkLabel(label);
				((ILGenerator)il).Emit(OpCodes.Castclass, ((Expression)exprObj).Type);
				((ILGenerator)il).MarkLabel(label2);
			}
			return true;
		}

		private static void EmitDefault(Type type, object il)
		{
			//Discarded unreachable code: IL_00ad, IL_018b, IL_01cd, IL_022b, IL_023a, IL_027a, IL_0289, IL_0338, IL_0347
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 19:
						return;
					case 2:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(bool).TypeHandle)))
						{
							num2 = 15;
							continue;
						}
						goto case 16;
					case 15:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(byte).TypeHandle)))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 16;
					case 9:
						if (!(type == typeof(short)))
						{
							num2 = 23;
							continue;
						}
						goto case 16;
					case 26:
						((ILGenerator)il).Emit(OpCodes.Ldnull);
						num2 = 19;
						continue;
					case 4:
						return;
					case 25:
						EmitLoadLocalVariable(il, iZFBo28vLdpJZ0EgaTu9(il, type));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 7;
						}
						continue;
					case 3:
						if (((Type)GNKm9i8vrhrfeYTW9WQI(type)).IsValueType)
						{
							num2 = 2;
							continue;
						}
						goto case 26;
					case 10:
						((ILGenerator)il).Emit(OpCodes.Ldc_R4, 0f);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 5;
						}
						continue;
					case 24:
						if (fXH2wl8v53gf6fwkZ1cA(type, typeof(ulong)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						if (fXH2wl8v53gf6fwkZ1cA(type, typeof(float)))
						{
							num = 10;
							break;
						}
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(double).TypeHandle)))
						{
							num2 = 25;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num2 = 20;
							}
							continue;
						}
						goto case 12;
					case 1:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)))
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto case 16;
					case 7:
						return;
					case 17:
						if (fXH2wl8v53gf6fwkZ1cA(type, typeof(sbyte)))
						{
							num2 = 18;
							continue;
						}
						goto case 1;
					case 14:
						return;
					case 13:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)))
						{
							num2 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num2 = 19;
							}
							continue;
						}
						goto case 24;
					case 16:
					case 18:
					case 22:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_0);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 14;
						}
						continue;
					default:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_0);
						num = 11;
						break;
					case 23:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(ushort).TypeHandle)))
						{
							num2 = 13;
							continue;
						}
						goto case 16;
					case 12:
						knkv2X8vYB8jrNg6F4Ng(il, OpCodes.Ldc_R8, 0.0);
						num2 = 4;
						continue;
					case 20:
						return;
					case 11:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_I8);
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 20;
						}
						continue;
					case 5:
						return;
					case 8:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(uint).TypeHandle)))
						{
							num2 = 22;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 9;
					case 6:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(char).TypeHandle)))
						{
							num2 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 16;
					}
					break;
				}
			}
		}

		private static bool TryEmitTryCatchFinallyBlock(object tryExpr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			bool flag = closure.TryCatchFinallyContainsReturnGotoExpression();
			((ILGenerator)il).BeginExceptionBlock();
			if (!TryEmit(((TryExpression)tryExpr).Body, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			Type type = ((Expression)tryExpr).Type;
			bool flag2 = type != typeof(void) && (flag || !parent.IgnoresResult());
			int location = -1;
			if (flag2)
			{
				EmitStoreLocalVariable(il, location = ((ILGenerator)il).GetNextLocalVarIndex(type));
			}
			ReadOnlyCollection<CatchBlock> handlers = ((TryExpression)tryExpr).Handlers;
			for (int i = 0; i < handlers.Count; i++)
			{
				CatchBlock catchBlock = handlers[i];
				if (catchBlock.Filter != null)
				{
					return false;
				}
				((ILGenerator)il).BeginCatchBlock(catchBlock.Test);
				ParameterExpression variable = catchBlock.Variable;
				if (variable != null)
				{
					int nextLocalVarIndex = ((ILGenerator)il).GetNextLocalVarIndex(variable.Type);
					closure.PushBlockWithVars(variable, nextLocalVarIndex);
					EmitStoreLocalVariable(il, nextLocalVarIndex);
				}
				if (!TryEmit(catchBlock.Body, paramExprs, il, ref closure, parent))
				{
					return false;
				}
				if (variable != null)
				{
					closure.PopBlock();
				}
				if (flag2)
				{
					EmitStoreLocalVariable(il, location);
				}
			}
			Expression @finally = ((TryExpression)tryExpr).Finally;
			if (@finally != null)
			{
				((ILGenerator)il).BeginFinallyBlock();
				if (!TryEmit(@finally, paramExprs, il, ref closure, parent))
				{
					return false;
				}
			}
			((ILGenerator)il).EndExceptionBlock();
			if (flag2)
			{
				EmitLoadLocalVariable(il, location);
			}
			closure.CurrentTryCatchFinallyIndex--;
			return true;
		}

		private static bool TryEmitParameter(object paramExpr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent, int byRefIndex = -1)
		{
			Type type = ((Expression)paramExpr).Type;
			bool isByRef = ((ParameterExpression)paramExpr).IsByRef;
			int num = paramExprs.Count - 1;
			while (num != -1 && paramExprs[num] != paramExpr)
			{
				num--;
			}
			if (num != -1)
			{
				bool flag = byRefIndex != -1;
				closure.LastEmitIsAddress = (!isByRef && flag) || (!isByRef && type.IsValueType() && ((parent & ParentFlags.InstanceCall) == ParentFlags.InstanceCall || (parent & ParentFlags.MemberAccess) != 0));
				if ((closure.Status & ClosureStatus.ShouldBeStaticMethod) == 0)
				{
					num++;
				}
				if (closure.LastEmitIsAddress)
				{
					((ILGenerator)il).Emit(OpCodes.Ldarga_S, (byte)num);
				}
				else
				{
					switch (num)
					{
					case 0:
						((ILGenerator)il).Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						((ILGenerator)il).Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						((ILGenerator)il).Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						((ILGenerator)il).Emit(OpCodes.Ldarg_3);
						break;
					default:
						((ILGenerator)il).Emit(OpCodes.Ldarg_S, (byte)num);
						break;
					}
				}
				if (isByRef)
				{
					if (type.IsValueType())
					{
						if (((parent & ParentFlags.Call) != 0 && !flag) || (parent & ParentFlags.Arithmetic) != 0)
						{
							EmitValueTypeDereference(il, type);
						}
					}
					else if (((parent & ParentFlags.Call) != 0 && !flag) || (parent & (ParentFlags.MemberAccess | ParentFlags.Coalesce)) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Ldind_Ref);
					}
				}
				return true;
			}
			int definedLocalVarOrDefault = closure.GetDefinedLocalVarOrDefault((ParameterExpression)paramExpr);
			if (definedLocalVarOrDefault != -1)
			{
				if (byRefIndex != -1 || (type.IsValueType() && (parent & (ParentFlags.MemberAccess | ParentFlags.InstanceAccess)) != 0))
				{
					EmitLoadLocalVariableAddress(il, definedLocalVarOrDefault);
				}
				else
				{
					EmitLoadLocalVariable(il, definedLocalVarOrDefault);
				}
				return true;
			}
			if (isByRef)
			{
				EmitLoadLocalVariableAddress(il, byRefIndex);
				return true;
			}
			ParameterExpression[] nonPassedParameters = closure.NonPassedParameters;
			int num2 = nonPassedParameters.Length - 1;
			while (num2 != -1 && nonPassedParameters[num2] != paramExpr)
			{
				num2--;
			}
			if (num2 == -1)
			{
				return false;
			}
			((ILGenerator)il).Emit(OpCodes.Ldarg_0);
			((ILGenerator)il).Emit(OpCodes.Ldfld, ArrayClosureWithNonPassedParamsField);
			EmitLoadConstantInt(il, num2);
			((ILGenerator)il).Emit(OpCodes.Ldelem_Ref);
			if (type.IsValueType())
			{
				((ILGenerator)il).Emit(OpCodes.Unbox_Any, type);
			}
			return true;
		}

		private static void EmitValueTypeDereference(object il, Type type)
		{
			//Discarded unreachable code: IL_009e, IL_00ad, IL_0132, IL_0161, IL_0247, IL_0256, IL_0266, IL_03cd, IL_03fc, IL_040b
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 16:
						return;
					case 6:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_U1);
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 20;
						}
						continue;
					case 9:
						return;
					case 11:
						return;
					case 17:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(byte).TypeHandle)))
						{
							num2 = 6;
							continue;
						}
						if (!(type == typeof(ushort)))
						{
							if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(uint).TypeHandle)))
							{
								num2 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num2 = 2;
								}
								continue;
							}
							goto case 26;
						}
						num2 = 28;
						continue;
					case 12:
						return;
					case 22:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(UIntPtr).TypeHandle)))
						{
							num2 = 17;
							continue;
						}
						goto case 14;
					case 0:
						return;
					case 13:
						return;
					case 3:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)))
						{
							if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(short).TypeHandle)))
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 2;
						}
						num = 8;
						break;
					case 23:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I);
						num = 12;
						break;
					case 8:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I8);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 0;
						}
						continue;
					case 15:
						return;
					case 19:
						if (fXH2wl8v53gf6fwkZ1cA(type, typeof(double)))
						{
							num2 = 25;
							continue;
						}
						if (!fXH2wl8v53gf6fwkZ1cA(type, typeof(IntPtr)))
						{
							num2 = 22;
							continue;
						}
						goto case 23;
					case 21:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_R4);
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 15;
						}
						continue;
					case 10:
						return;
					case 18:
						J2osBm8vUaIa3b3WwLmF(il, OpCodes.Ldobj, type);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 16;
						}
						continue;
					case 2:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I2);
						num2 = 27;
						continue;
					case 27:
						return;
					case 1:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(sbyte).TypeHandle)))
						{
							num2 = 29;
							continue;
						}
						goto case 7;
					case 5:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I4);
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						continue;
					case 28:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_U2);
						num2 = 9;
						continue;
					case 26:
						((ILGenerator)il).Emit(OpCodes.Ldind_U4);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 10;
						}
						continue;
					case 25:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_R8);
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 24;
						}
						continue;
					case 4:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 5;
					case 7:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I1);
						num = 30;
						break;
					case 30:
						return;
					case 29:
						if (!(type == U4TPVi8vg9UgNc6Skdyl(typeof(float).TypeHandle)))
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 19;
							}
							continue;
						}
						goto case 21;
					case 20:
						return;
					case 14:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 11;
						}
						continue;
					case 24:
						return;
					}
					break;
				}
			}
		}

		private static bool TryEmitSimpleUnaryExpression(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Type type = ((Expression)expr).Type;
			if (type == typeof(decimal))
			{
				return false;
			}
			if (!TryEmit(((UnaryExpression)expr).Operand, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			if ((parent & ParentFlags.IgnoreResult) != 0)
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			else if (((Expression)expr).NodeType == ExpressionType.TypeAs)
			{
				((ILGenerator)il).Emit(OpCodes.Isinst, type);
			}
			else if (((Expression)expr).NodeType == ExpressionType.IsFalse)
			{
				Label label = ((ILGenerator)il).DefineLabel();
				Label label2 = ((ILGenerator)il).DefineLabel();
				((ILGenerator)il).Emit(OpCodes.Brfalse, label);
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
				((ILGenerator)il).Emit(OpCodes.Br, label2);
				((ILGenerator)il).MarkLabel(label);
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
				((ILGenerator)il).MarkLabel(label2);
			}
			else if (((Expression)expr).NodeType == ExpressionType.Increment)
			{
				if (!TryEmitNumberOne(il, type))
				{
					return false;
				}
				((ILGenerator)il).Emit(OpCodes.Add);
			}
			else if (((Expression)expr).NodeType == ExpressionType.Decrement)
			{
				if (!TryEmitNumberOne(il, type))
				{
					return false;
				}
				((ILGenerator)il).Emit(OpCodes.Sub);
			}
			else if (((Expression)expr).NodeType == ExpressionType.Negate || ((Expression)expr).NodeType == ExpressionType.NegateChecked)
			{
				((ILGenerator)il).Emit(OpCodes.Neg);
			}
			else if (((Expression)expr).NodeType == ExpressionType.OnesComplement)
			{
				((ILGenerator)il).Emit(OpCodes.Not);
			}
			else if (((Expression)expr).NodeType == ExpressionType.Unbox)
			{
				((ILGenerator)il).Emit(OpCodes.Unbox_Any, type);
			}
			else if (((Expression)expr).NodeType != ExpressionType.IsTrue)
			{
				_ = ((Expression)expr).NodeType;
				_ = 29;
			}
			return true;
		}

		private static bool TryEmitTypeIs(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			if (!TryEmit(((TypeBinaryExpression)expr).Expression, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			if ((parent & ParentFlags.IgnoreResult) != 0)
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			else
			{
				((ILGenerator)il).Emit(OpCodes.Isinst, ((TypeBinaryExpression)expr).TypeOperand);
				((ILGenerator)il).Emit(OpCodes.Ldnull);
				((ILGenerator)il).Emit(OpCodes.Cgt_Un);
			}
			return true;
		}

		private static bool TryEmitNot(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			if (!TryEmit(((UnaryExpression)expr).Operand, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			if ((parent & ParentFlags.IgnoreResult) > ParentFlags.Empty)
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			else if (((Expression)expr).Type == typeof(bool))
			{
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
				((ILGenerator)il).Emit(OpCodes.Ceq);
			}
			else
			{
				((ILGenerator)il).Emit(OpCodes.Not);
			}
			return true;
		}

		private static bool TryEmitConvert(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Expression operand = ((UnaryExpression)expr).Operand;
			MethodInfo method = ((UnaryExpression)expr).Method;
			if (method != null && method.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575832876) && method.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410923993))
			{
				if (!TryEmit(operand, paramExprs, il, ref closure, (parent & ~ParentFlags.IgnoreResult) | ParentFlags.InstanceCall))
				{
					return false;
				}
				((ILGenerator)il).Emit(method.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, method);
				if ((parent & ParentFlags.IgnoreResult) != 0 && method.ReturnType != typeof(void))
				{
					((ILGenerator)il).Emit(OpCodes.Pop);
				}
				return true;
			}
			Type type = operand.Type;
			bool flag = type.IsNullable();
			Type underlyingType = Nullable.GetUnderlyingType(type);
			Type type2 = ((Expression)expr).Type;
			if (flag && type2 == underlyingType)
			{
				if (!TryEmit(operand, paramExprs, il, ref closure, (parent & ~ParentFlags.IgnoreResult) | ParentFlags.InstanceAccess))
				{
					return false;
				}
				if (!closure.LastEmitIsAddress)
				{
					EmitStoreLocalVariableAndLoadItsAddress(il, type);
				}
				((ILGenerator)il).Emit(OpCodes.Call, type.FindValueGetterMethod());
				if ((parent & ParentFlags.IgnoreResult) != 0)
				{
					((ILGenerator)il).Emit(OpCodes.Pop);
				}
				return true;
			}
			if (!TryEmit(operand, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult & ~ParentFlags.InstanceAccess))
			{
				return false;
			}
			bool flag2 = type2.IsNullable();
			Type underlyingType2 = Nullable.GetUnderlyingType(type2);
			if (flag2 && type == underlyingType2)
			{
				((ILGenerator)il).Emit(OpCodes.Newobj, type2.GetTypeInfo().DeclaredConstructors.GetFirst());
				return true;
			}
			if (type == type2 || type2 == typeof(object))
			{
				if (type2 == typeof(object) && type.IsValueType())
				{
					((ILGenerator)il).Emit(OpCodes.Box, type);
				}
				if (parent.IgnoresResult())
				{
					((ILGenerator)il).Emit(OpCodes.Pop);
				}
				return true;
			}
			if (!flag && !type.IsPrimitive())
			{
				Type targetType = (flag2 ? underlyingType2 : type2);
				MethodInfo methodInfo = method ?? type.FindConvertOperator(type, targetType);
				if (methodInfo != null)
				{
					((ILGenerator)il).Emit(OpCodes.Call, methodInfo);
					if (flag2)
					{
						((ILGenerator)il).Emit(OpCodes.Newobj, type2.GetTypeInfo().DeclaredConstructors.GetFirst());
					}
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Pop);
					}
					return true;
				}
			}
			else if (!flag2)
			{
				Type type3 = (flag ? underlyingType : type);
				MethodInfo methodInfo2 = method ?? type3.FindConvertOperator(type3, type2);
				if (methodInfo2 != null)
				{
					if (flag)
					{
						EmitStoreLocalVariableAndLoadItsAddress(il, type);
						((ILGenerator)il).Emit(OpCodes.Call, type.FindValueGetterMethod());
					}
					((ILGenerator)il).Emit(OpCodes.Call, methodInfo2);
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Pop);
					}
					return true;
				}
			}
			if (!flag2 && !type2.IsPrimitive())
			{
				Type sourceType = (flag ? underlyingType : type);
				MethodInfo methodInfo3 = method ?? type2.FindConvertOperator(sourceType, type2);
				if (methodInfo3 != null)
				{
					if (flag)
					{
						EmitStoreLocalVariableAndLoadItsAddress(il, type);
						((ILGenerator)il).Emit(OpCodes.Call, type.FindValueGetterMethod());
					}
					((ILGenerator)il).Emit(OpCodes.Call, methodInfo3);
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Pop);
					}
					return true;
				}
			}
			else if (!flag)
			{
				Type type4 = (flag2 ? underlyingType2 : type2);
				MethodInfo methodInfo4 = method ?? type4.FindConvertOperator(type, type4);
				if (methodInfo4 != null)
				{
					((ILGenerator)il).Emit(OpCodes.Call, methodInfo4);
					if (flag2)
					{
						((ILGenerator)il).Emit(OpCodes.Newobj, type2.GetTypeInfo().DeclaredConstructors.GetFirst());
					}
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Pop);
					}
					return true;
				}
			}
			if (type == typeof(object) && type2.IsValueType())
			{
				((ILGenerator)il).Emit(OpCodes.Unbox_Any, type2);
			}
			else if (flag2)
			{
				if (!flag)
				{
					if (!TryEmitValueConvert(underlyingType2, il, isChecked: false))
					{
						return false;
					}
					((ILGenerator)il).Emit(OpCodes.Newobj, type2.GetTypeInfo().DeclaredConstructors.GetFirst());
				}
				else
				{
					int location = EmitStoreLocalVariableAndLoadItsAddress(il, type);
					((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableHasValueGetterMethod());
					Label label = ((ILGenerator)il).DefineLabel();
					((ILGenerator)il).Emit(OpCodes.Brtrue_S, label);
					EmitLoadLocalVariable(il, InitValueTypeVariable(il, type2));
					Label label2 = ((ILGenerator)il).DefineLabel();
					((ILGenerator)il).Emit(OpCodes.Br_S, label2);
					((ILGenerator)il).MarkLabel(label);
					EmitLoadLocalVariableAddress(il, location);
					((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableGetValueOrDefaultMethod());
					if (!TryEmitValueConvert(underlyingType2, il, ((Expression)expr).NodeType == ExpressionType.ConvertChecked))
					{
						MethodInfo methodInfo5 = method ?? underlyingType2.FindConvertOperator(underlyingType, underlyingType2);
						if (methodInfo5 == null)
						{
							return false;
						}
						((ILGenerator)il).Emit(OpCodes.Call, methodInfo5);
					}
					((ILGenerator)il).Emit(OpCodes.Newobj, type2.GetTypeInfo().DeclaredConstructors.GetFirst());
					((ILGenerator)il).MarkLabel(label2);
				}
			}
			else
			{
				if (type2.GetTypeInfo().IsEnum)
				{
					type2 = Enum.GetUnderlyingType(type2);
				}
				if (flag)
				{
					EmitStoreLocalVariableAndLoadItsAddress(il, type);
					((ILGenerator)il).Emit(OpCodes.Call, type.FindValueGetterMethod());
				}
				if (!TryEmitValueConvert(type2, il, ((Expression)expr).NodeType == ExpressionType.ConvertChecked))
				{
					((ILGenerator)il).Emit(OpCodes.Castclass, type2);
				}
			}
			if ((parent & ParentFlags.IgnoreResult) != 0)
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			return true;
		}

		private static bool TryEmitValueConvert(Type targetType, object il, bool isChecked)
		{
			//Discarded unreachable code: IL_00ad, IL_00db, IL_0128, IL_0137, IL_0147, IL_0156, IL_0165, IL_0175, IL_021e, IL_024c, IL_025b, IL_028e, IL_029d, IL_031d, IL_032c, IL_033c, IL_034b, IL_035b
			int num = 8;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 24:
						if (fXH2wl8v53gf6fwkZ1cA(targetType, typeof(uint)))
						{
							num2 = 17;
							continue;
						}
						goto case 19;
					case 12:
					case 16:
						if (!fXH2wl8v53gf6fwkZ1cA(targetType, typeof(byte)))
						{
							num2 = 30;
							continue;
						}
						goto case 26;
					case 13:
						if (!fXH2wl8v53gf6fwkZ1cA(targetType, U4TPVi8vg9UgNc6Skdyl(typeof(ushort).TypeHandle)))
						{
							num2 = 27;
							continue;
						}
						goto case 28;
					case 9:
					case 25:
						if (fXH2wl8v53gf6fwkZ1cA(targetType, U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)))
						{
							num2 = 29;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 6;
					case 5:
						return false;
					default:
						return true;
					case 21:
					case 30:
						if (fXH2wl8v53gf6fwkZ1cA(targetType, U4TPVi8vg9UgNc6Skdyl(typeof(short).TypeHandle)))
						{
							num = 11;
							break;
						}
						goto case 13;
					case 15:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_R4);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 3;
						}
						continue;
					case 27:
						if (!(targetType == U4TPVi8vg9UgNc6Skdyl(typeof(char).TypeHandle)))
						{
							num2 = 25;
							continue;
						}
						goto case 28;
					case 8:
						if (fXH2wl8v53gf6fwkZ1cA(targetType, U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)))
						{
							num2 = 7;
							continue;
						}
						goto case 22;
					case 19:
						if (!fXH2wl8v53gf6fwkZ1cA(targetType, U4TPVi8vg9UgNc6Skdyl(typeof(sbyte).TypeHandle)))
						{
							num = 12;
							break;
						}
						goto case 1;
					case 22:
						if (fXH2wl8v53gf6fwkZ1cA(targetType, U4TPVi8vg9UgNc6Skdyl(typeof(float).TypeHandle)))
						{
							num = 15;
							break;
						}
						goto case 24;
					case 23:
						if (targetType == typeof(double))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					case 6:
						if (targetType == U4TPVi8vg9UgNc6Skdyl(typeof(ulong).TypeHandle))
						{
							num2 = 14;
							continue;
						}
						goto case 23;
					case 2:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_R8);
						num2 = 18;
						continue;
					case 7:
						pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_I4 : OpCodes.Conv_I4);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 34;
						}
						continue;
					case 17:
						pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_U4 : OpCodes.Conv_U4);
						num2 = 33;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 22;
						}
						continue;
					case 1:
						pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_I1 : OpCodes.Conv_I1);
						num2 = 20;
						continue;
					case 26:
						pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_U1 : OpCodes.Conv_U1);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					case 11:
						((ILGenerator)il).Emit(isChecked ? OpCodes.Conv_Ovf_I2 : OpCodes.Conv_I2);
						num2 = 4;
						continue;
					case 28:
						pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_U2 : OpCodes.Conv_U2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 10;
						}
						continue;
					case 29:
						pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_I8 : OpCodes.Conv_I8);
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 17;
						}
						continue;
					case 14:
						((ILGenerator)il).Emit(isChecked ? OpCodes.Conv_Ovf_U8 : OpCodes.Conv_U8);
						num2 = 32;
						continue;
					}
					break;
				}
			}
		}

		private static bool TryEmitNotNullConstant(bool considerClosure, Type exprType, object constantValue, object il, ref ClosureInfo closure)
		{
			//Discarded unreachable code: IL_013d, IL_0173, IL_02aa, IL_02b9, IL_02c8, IL_02fd, IL_0377, IL_0386, IL_03de, IL_03ed, IL_0469, IL_0478, IL_04b2
			int num = 18;
			int num4 = default(int);
			int num3 = default(int);
			Type type2 = default(Type);
			object[] items = default(object[]);
			Type type = default(Type);
			string text = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 27:
						if (num4 == -1)
						{
							num2 = 30;
							continue;
						}
						num3 = closure.ConstantUsage.Items[num4] - 1;
						num2 = 36;
						continue;
					case 36:
						if (num3 <= 0)
						{
							num2 = 26;
							continue;
						}
						goto case 7;
					case 11:
						J2osBm8vUaIa3b3WwLmF(il, OpCodes.Ldtoken, type2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					case 30:
						return false;
					case 28:
					case 29:
						if (num4 != -1)
						{
							num2 = 37;
							continue;
						}
						goto case 27;
					case 37:
						if (items[num4] == constantValue)
						{
							num2 = 27;
							continue;
						}
						goto case 34;
					case 18:
						type = constantValue.GetType();
						num2 = 17;
						continue;
					case 15:
						if (fXH2wl8v53gf6fwkZ1cA(exprType, U4TPVi8vg9UgNc6Skdyl(typeof(object).TypeHandle)))
						{
							num2 = 13;
							continue;
						}
						goto case 23;
					case 38:
						EmitLoadConstantInt(il, num4);
						num2 = 10;
						continue;
					case 7:
						sAHEtL8vcqrjhyn5Thl8(il, num3);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 8;
						}
						continue;
					case 32:
						return false;
					case 2:
					case 6:
					case 8:
						if (aiU5Py88bf4bvp4KvZlA(Y3ZBnF88oFL48nB4EbDT(exprType), null))
						{
							num2 = 9;
							continue;
						}
						goto case 15;
					case 1:
						cr9PXh88BxyHDixSqTcC(il, OpCodes.Call, _getTypeFromHandleMethod);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 3;
						}
						continue;
					case 12:
						if (!FmvXlm8vsuRxLNJZHiE0(constantValue, type.GetTypeInfo()))
						{
							num2 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num2 = 22;
							}
							continue;
						}
						goto case 33;
					case 9:
						EeScqP88h5wEXIWJQdtf(il, OpCodes.Newobj, ((TypeInfo)GNKm9i8vrhrfeYTW9WQI(exprType)).DeclaredConstructors.GetFirst());
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 13;
						}
						continue;
					case 23:
					case 31:
						return true;
					case 21:
						J2osBm8vUaIa3b3WwLmF(il, OpCodes.Box, constantValue.GetType());
						num2 = 31;
						continue;
					case 17:
						if (!considerClosure)
						{
							num2 = 5;
							continue;
						}
						goto case 12;
					case 10:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldelem_Ref);
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 5;
						}
						continue;
					case 39:
						UviTP688Flh13scInDsp(il, OpCodes.Ldstr, text);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 0;
						}
						continue;
					case 13:
						if (PjFnO38vzkxjGZ63tFdS(type))
						{
							num2 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num2 = 18;
							}
							continue;
						}
						goto case 23;
					case 24:
						break;
					case 33:
						items = closure.Constants.Items;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 4;
						}
						continue;
					case 34:
						num4--;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 28;
						}
						continue;
					case 3:
						return true;
					case 19:
						if (((Type)GNKm9i8vrhrfeYTW9WQI(type)).IsEnum)
						{
							num2 = 14;
							continue;
						}
						goto case 35;
					case 4:
						num4 = closure.Constants.Count - 1;
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 15;
						}
						continue;
					case 25:
						if (!PjFnO38vzkxjGZ63tFdS(exprType))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num2 = 6;
							}
							continue;
						}
						break;
					default:
						return true;
					case 5:
					case 16:
					case 22:
						if ((text = constantValue as string) == null)
						{
							if ((object)(type2 = constantValue as Type) == null)
							{
								num2 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
								{
									num2 = 5;
								}
								continue;
							}
							goto case 11;
						}
						num2 = 39;
						continue;
					case 20:
					case 26:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_0);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 38;
						}
						continue;
					case 35:
						if (!fokGig88WnZPreE4vi54(il, constantValue, type))
						{
							num2 = 32;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num2 = 19;
							}
							continue;
						}
						goto case 2;
					case 14:
						type = Enum.GetUnderlyingType(type);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					break;
				}
				J2osBm8vUaIa3b3WwLmF(il, OpCodes.Unbox_Any, exprType);
				num = 2;
			}
		}

		private static bool TryEmitNumberConstant(object il, object constantValue, Type constValueType)
		{
			//Discarded unreachable code: IL_00f1, IL_0100, IL_018a, IL_0199, IL_01a8, IL_021c, IL_022b, IL_0337, IL_0346, IL_0356, IL_0365, IL_0374, IL_0384, IL_03fc, IL_040b, IL_041a, IL_043f, IL_044e, IL_04bb, IL_04ca, IL_04d9, IL_058e, IL_059d, IL_05ac, IL_05bc, IL_05cb, IL_0601, IL_0610, IL_0620, IL_0645
			int num = 45;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 37:
						if (!fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(ushort).TypeHandle)))
						{
							num2 = 26;
							continue;
						}
						goto case 9;
					case 39:
						cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, (long)constantValue);
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 29;
						}
						continue;
					case 24:
						EmitLoadConstantInt(il, (sbyte)constantValue);
						num = 42;
						break;
					case 34:
						W7pcad88fNEKh1EdX85b((decimal)constantValue, il);
						num2 = 14;
						continue;
					case 9:
						xSvlU588GkZCQcYNHxR9(il, (ushort)constantValue);
						num2 = 40;
						continue;
					case 22:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(decimal).TypeHandle)))
						{
							num2 = 34;
							continue;
						}
						goto case 20;
					case 36:
						if (constValueType == U4TPVi8vg9UgNc6Skdyl(typeof(uint).TypeHandle))
						{
							num2 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 28;
					case 16:
					case 46:
						if (!fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(byte).TypeHandle)))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					case 33:
						((ILGenerator)il).Emit(OpCodes.Ldc_R4, (float)constantValue);
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 8;
						}
						continue;
					case 30:
						cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, (long)((UIntPtr)constantValue).ToUInt64());
						num2 = 5;
						continue;
					case 38:
						cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, ((IntPtr)constantValue).ToInt64());
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 3;
						}
						continue;
					case 15:
						knkv2X8vYB8jrNg6F4Ng(il, OpCodes.Ldc_R8, (double)constantValue);
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 41;
						}
						continue;
					case 21:
					case 23:
						if (!fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(IntPtr).TypeHandle)))
						{
							num2 = 31;
							continue;
						}
						goto case 38;
					case 35:
						cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, (long)(ulong)constantValue);
						num2 = 3;
						continue;
					case 4:
						if (!fXH2wl8v53gf6fwkZ1cA(constValueType, typeof(bool)))
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
							{
								num2 = 21;
							}
							continue;
						}
						goto case 7;
					case 45:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)))
						{
							num2 = 44;
							continue;
						}
						goto case 27;
					case 44:
						xSvlU588GkZCQcYNHxR9(il, (int)constantValue);
						num2 = 18;
						continue;
					case 28:
						if (!(constValueType == U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)))
						{
							num2 = 51;
							continue;
						}
						goto case 39;
					case 1:
					case 31:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(UIntPtr).TypeHandle)))
						{
							num2 = 30;
							continue;
						}
						goto case 22;
					case 43:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(float).TypeHandle)))
						{
							num2 = 33;
							continue;
						}
						goto case 49;
					case 10:
					case 26:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(sbyte).TypeHandle)))
						{
							num = 24;
							break;
						}
						goto case 36;
					case 12:
						xSvlU588GkZCQcYNHxR9(il, (char)constantValue);
						num2 = 48;
						continue;
					case 27:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, typeof(char)))
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num2 = 12;
							}
							continue;
						}
						goto case 50;
					case 50:
						if (!(constValueType == U4TPVi8vg9UgNc6Skdyl(typeof(short).TypeHandle)))
						{
							num2 = 46;
							continue;
						}
						goto case 47;
					case 32:
					case 51:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(ulong).TypeHandle)))
						{
							num2 = 35;
							continue;
						}
						goto case 43;
					case 47:
						xSvlU588GkZCQcYNHxR9(il, (short)constantValue);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 17;
						}
						continue;
					default:
						xSvlU588GkZCQcYNHxR9(il, (byte)constantValue);
						num2 = 25;
						continue;
					case 20:
						return false;
					case 3:
					case 5:
					case 6:
					case 8:
					case 11:
					case 14:
					case 17:
					case 18:
					case 19:
					case 25:
					case 29:
					case 40:
					case 41:
					case 42:
					case 48:
						return true;
					case 13:
						xSvlU588GkZCQcYNHxR9(il, (int)(uint)constantValue);
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 19;
						}
						continue;
					case 49:
						if (fXH2wl8v53gf6fwkZ1cA(constValueType, U4TPVi8vg9UgNc6Skdyl(typeof(double).TypeHandle)))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 4;
					case 7:
						((ILGenerator)il).Emit(((bool)constantValue) ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
						num2 = 8;
						continue;
					}
					break;
				}
			}
		}

		internal static bool TryEmitNumberOne(object il, Type type)
		{
			//Discarded unreachable code: IL_0099, IL_00a8, IL_00b8, IL_00cb, IL_00da, IL_013c, IL_014b, IL_0189, IL_01bd, IL_01cc, IL_02b4, IL_02f2, IL_034f, IL_03cb, IL_03da, IL_03ea
			int num = 14;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 14:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)))
						{
							num2 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num2 = 13;
							}
							continue;
						}
						goto case 5;
					case 6:
					case 9:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(double).TypeHandle)))
						{
							num = 3;
							break;
						}
						goto case 27;
					case 29:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(byte).TypeHandle)))
						{
							num2 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num2 = 28;
							}
							continue;
						}
						goto case 19;
					case 13:
					case 15:
					case 22:
					case 28:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_1);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 2;
						}
						continue;
					case 17:
						wCQlP088QNaoX0PDRj9h(il, OpCodes.Ldc_R4, 1f);
						num = 21;
						break;
					case 10:
					case 20:
					case 25:
						cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, 1L);
						num = 16;
						break;
					case 5:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(char).TypeHandle)))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 13;
					case 24:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(uint).TypeHandle)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 13;
					case 3:
					case 12:
						return false;
					case 7:
					case 16:
					case 21:
					case 23:
						return true;
					case 27:
						knkv2X8vYB8jrNg6F4Ng(il, OpCodes.Ldc_R8, 1.0);
						num2 = 23;
						continue;
					case 19:
						if (type == U4TPVi8vg9UgNc6Skdyl(typeof(ushort).TypeHandle))
						{
							num2 = 22;
							continue;
						}
						goto case 2;
					case 11:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(float).TypeHandle)))
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 17;
					case 2:
						if (!(type == U4TPVi8vg9UgNc6Skdyl(typeof(sbyte).TypeHandle)))
						{
							num2 = 24;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 13;
					case 26:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(UIntPtr).TypeHandle)))
						{
							num2 = 25;
							continue;
						}
						goto case 11;
					case 1:
						if (!fXH2wl8v53gf6fwkZ1cA(type, typeof(short)))
						{
							num2 = 29;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num2 = 11;
							}
							continue;
						}
						goto case 13;
					default:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)))
						{
							num2 = 20;
							continue;
						}
						goto case 4;
					case 4:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(ulong).TypeHandle)))
						{
							num2 = 10;
							continue;
						}
						goto case 18;
					case 18:
						if (!(type == U4TPVi8vg9UgNc6Skdyl(typeof(IntPtr).TypeHandle)))
						{
							num2 = 26;
							continue;
						}
						goto case 10;
					}
					break;
				}
			}
		}

		internal static void EmitLoadConstantsAndNestedLambdasIntoVars(object il, ref ClosureInfo closure)
		{
			//Discarded unreachable code: IL_0126, IL_01d1, IL_01e0, IL_0223, IL_0266, IL_0275
			int num = 16;
			int num4 = default(int);
			NestedLambdaInfo nestedLambdaInfo = default(NestedLambdaInfo);
			int num3 = default(int);
			int count = default(int);
			int num5 = default(int);
			int[] items2 = default(int[]);
			Type type = default(Type);
			NestedLambdaInfo[] nestedLambdas = default(NestedLambdaInfo[]);
			object[] items = default(object[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 21:
						xSvlU588GkZCQcYNHxR9(il, num4);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 28;
						}
						continue;
					default:
						nestedLambdaInfo.UsageCountOrVarIndex = num3 + 1;
						num = 22;
						break;
					case 10:
						xSvlU588GkZCQcYNHxR9(il, count + num5);
						num2 = 14;
						continue;
					case 31:
						if (items2[num4] <= 1)
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num2 = 11;
							}
							continue;
						}
						goto case 3;
					case 28:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldelem_Ref);
						num2 = 9;
						continue;
					case 6:
					case 23:
						if (num4 >= count)
						{
							num2 = 25;
							continue;
						}
						goto case 31;
					case 16:
						((ILGenerator)il).Emit(OpCodes.Ldarg_0);
						num2 = 15;
						continue;
					case 5:
					case 35:
						num3 = ((ILGenerator)il).GetNextLocalVarIndex(type);
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 13;
						}
						continue;
					case 13:
					case 34:
						if (num5 >= nestedLambdas.Length)
						{
							num2 = 33;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num2 = 19;
							}
							continue;
						}
						goto case 29;
					case 9:
						type = items[num4].GetType();
						num2 = 27;
						continue;
					case 24:
						EmitStoreLocalVariable(il, num3);
						num2 = 26;
						continue;
					case 29:
						nestedLambdaInfo = nestedLambdas[num5];
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 0;
						}
						continue;
					case 32:
						items2 = closure.ConstantUsage.Items;
						num2 = 7;
						continue;
					case 8:
						num5 = 0;
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 34;
						}
						continue;
					case 14:
						((ILGenerator)il).Emit(OpCodes.Ldelem_Ref);
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 14;
						}
						continue;
					case 15:
						sRdP0O88C2XPgBIGfmr9(il, OpCodes.Ldfld, ArrayClosureArrayField);
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 20;
						}
						continue;
					case 27:
						if (!PjFnO38vzkxjGZ63tFdS(type))
						{
							num = 5;
							break;
						}
						goto case 30;
					case 33:
						return;
					case 12:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_0);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 4;
						}
						continue;
					case 7:
						num4 = 0;
						num2 = 6;
						continue;
					case 25:
						nestedLambdas = closure.NestedLambdas;
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 8;
						}
						continue;
					case 19:
						count = closure.Constants.Count;
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 32;
						}
						continue;
					case 18:
						items2[num4] = num3 + 1;
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 1;
						}
						continue;
					case 11:
					case 26:
						num4++;
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 23;
						}
						continue;
					case 17:
						num3 = biffFd88v5EVI03AcKVJ(il, nestedLambdaInfo.Lambda.GetType());
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						((ILGenerator)il).Emit(OpCodes.Ldloc_0);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 21;
						}
						continue;
					case 4:
						if (nestedLambdaInfo.UsageCountOrVarIndex > 1)
						{
							num2 = 12;
							continue;
						}
						goto case 1;
					case 1:
						num5++;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 13;
						}
						continue;
					case 20:
						EmitStoreLocalVariable(il, biffFd88v5EVI03AcKVJ(il, typeof(object[])));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 30:
						J2osBm8vUaIa3b3WwLmF(il, OpCodes.Unbox_Any, type);
						num2 = 35;
						continue;
					case 22:
						n5iKim888ZeKefyA2HBg(il, num3);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						items = closure.Constants.Items;
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					break;
				}
			}
		}

		private static void EmitDecimalConstant(decimal value, object il)
		{
			//Discarded unreachable code: IL_027b, IL_02b6
			int num = 21;
			byte i = default(byte);
			int[] bits = default(int[]);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 16:
						if (value <= new decimal(long.MaxValue))
						{
							num2 = 4;
							continue;
						}
						goto IL_00c7;
					case 20:
						if (!fqmiM488Il8d7HP1lXaU(value, -2147483648m))
						{
							num2 = 15;
							continue;
						}
						goto case 17;
					case 9:
						return;
					case 6:
						xSvlU588GkZCQcYNHxR9(il, BQ35wh88VnygI3LvNAkj(value));
						num2 = 3;
						continue;
					case 3:
						EeScqP88h5wEXIWJQdtf(il, OpCodes.Newobj, w6M2Rh88SoDltf7X7pW3(U4TPVi8vg9UgNc6Skdyl(typeof(decimal).TypeHandle), U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)));
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 25;
						}
						continue;
					case 24:
						((ILGenerator)il).Emit(OpCodes.Ldsfld, (FieldInfo)m3LAa488ReLmpwmaDB7T(GNKm9i8vrhrfeYTW9WQI(U4TPVi8vg9UgNc6Skdyl(typeof(decimal).TypeHandle)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1871152019)));
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 5;
						}
						continue;
					case 23:
						EeScqP88h5wEXIWJQdtf(il, OpCodes.Newobj, w6M2Rh88SoDltf7X7pW3(U4TPVi8vg9UgNc6Skdyl(typeof(decimal).TypeHandle), U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)));
						num2 = 9;
						continue;
					default:
						xSvlU588GkZCQcYNHxR9(il, i);
						num2 = 18;
						continue;
					case 4:
						cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, oVcLfh88iS6O3DRXOoA1(value));
						num2 = 23;
						continue;
					case 21:
						if (e7eD7j88uPJ67KFlpEWt(xafoql88ZtB6XHGZK6dR(value, 1m), 0m))
						{
							num2 = 20;
							continue;
						}
						goto IL_00c7;
					case 25:
						return;
					case 15:
						if (value >= new decimal(long.MinValue))
						{
							num2 = 16;
							continue;
						}
						goto IL_00c7;
					case 14:
						i = (byte)((uint)(bits[3] >> 16) & 0x7Fu);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 2;
						}
						continue;
					case 11:
						return;
					case 5:
						flag = (bits[3] & 0x80000000u) != 0;
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 14;
						}
						continue;
					case 2:
						EmitLoadConstantInt(il, bits[0]);
						num = 7;
						break;
					case 13:
						return;
					case 22:
						if (!e7eD7j88uPJ67KFlpEWt(value, decimal.MaxValue))
						{
							bits = decimal.GetBits(value);
							num2 = 5;
						}
						else
						{
							num2 = 12;
						}
						continue;
					case 10:
						((ILGenerator)il).Emit(OpCodes.Newobj, _decimalCtor.Value);
						num = 8;
						break;
					case 1:
						xSvlU588GkZCQcYNHxR9(il, bits[2]);
						num = 19;
						break;
					case 12:
						sRdP0O88C2XPgBIGfmr9(il, OpCodes.Ldsfld, m3LAa488ReLmpwmaDB7T(GNKm9i8vrhrfeYTW9WQI(typeof(decimal)), Fn0VLG88qZFRYO4uCytV(-672123589 ^ -671859883)));
						num2 = 11;
						continue;
					case 8:
						return;
					case 7:
						xSvlU588GkZCQcYNHxR9(il, bits[1]);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 1;
						}
						continue;
					case 18:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_U1);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 10;
						}
						continue;
					case 17:
						if (value <= 2147483647m)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 15;
					case 19:
						{
							pO5qbK8vj7kF4Bx0nVcJ(il, flag ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						IL_00c7:
						if (!e7eD7j88uPJ67KFlpEWt(value, decimal.MinValue))
						{
							num2 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 22;
							}
							continue;
						}
						goto case 24;
					}
					break;
				}
			}
		}

		private static int InitValueTypeVariable(object il, Type exprType)
		{
			int num = 2;
			int num2 = num;
			int nextLocalVarIndex = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					zd5dF088K7mOoR6NMGKO(il, nextLocalVarIndex);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					nextLocalVarIndex = ((ILGenerator)il).GetNextLocalVarIndex(exprType);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return nextLocalVarIndex;
				default:
					((ILGenerator)il).Emit(OpCodes.Initobj, exprType);
					num2 = 3;
					break;
				}
			}
		}

		private static bool EmitNewArray(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Type type = ((Expression)expr).Type;
			ReadOnlyCollection<Expression> expressions = ((NewArrayExpression)expr).Expressions;
			Type elementType = type.GetElementType();
			if (elementType == null)
			{
				return false;
			}
			if (type.GetArrayRank() == 1)
			{
				EmitLoadConstantInt(il, expressions.Count);
				((ILGenerator)il).Emit(OpCodes.Newarr, elementType);
				bool flag = elementType.IsValueType();
				int i = 0;
				for (int count = expressions.Count; i < count; i++)
				{
					((ILGenerator)il).Emit(OpCodes.Dup);
					EmitLoadConstantInt(il, i);
					if (flag)
					{
						((ILGenerator)il).Emit(OpCodes.Ldelema, elementType);
					}
					if (!TryEmit(expressions[i], paramExprs, il, ref closure, parent))
					{
						return false;
					}
					if (flag)
					{
						((ILGenerator)il).Emit(OpCodes.Stobj, elementType);
					}
					else
					{
						((ILGenerator)il).Emit(OpCodes.Stelem_Ref);
					}
				}
				return true;
			}
			for (int j = 0; j < expressions.Count; j++)
			{
				if (!TryEmit(expressions[j], paramExprs, il, ref closure, parent, j))
				{
					return false;
				}
			}
			((ILGenerator)il).Emit(OpCodes.Newobj, type.GetTypeInfo().DeclaredConstructors.GetFirst());
			return true;
		}

		private static bool TryEmitArrayIndex(Type exprType, object il)
		{
			//Discarded unreachable code: IL_0073, IL_0084, IL_0093
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!PjFnO38vzkxjGZ63tFdS(exprType))
					{
						num2 = 4;
						continue;
					}
					break;
				case 1:
				case 4:
					pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldelem_Ref);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return true;
				case 3:
					break;
				}
				J2osBm8vUaIa3b3WwLmF(il, OpCodes.Ldelem, exprType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
			}
		}

		private static bool EmitMemberInit(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			int num = -1;
			if (((Expression)expr).Type.IsValueType())
			{
				num = ((ILGenerator)il).GetNextLocalVarIndex(((Expression)expr).Type);
			}
			NewExpression newExpression = ((MemberInitExpression)expr).NewExpression;
			ReadOnlyCollection<Expression> arguments = newExpression.Arguments;
			for (int i = 0; i < arguments.Count; i++)
			{
				if (!TryEmit(arguments[i], paramExprs, il, ref closure, parent, i))
				{
					return false;
				}
			}
			ConstructorInfo constructor = newExpression.Constructor;
			if (constructor != null)
			{
				((ILGenerator)il).Emit(OpCodes.Newobj, constructor);
			}
			else
			{
				if (!newExpression.Type.IsValueType())
				{
					return false;
				}
				if (num == -1)
				{
					num = ((ILGenerator)il).GetNextLocalVarIndex(((Expression)expr).Type);
				}
				EmitLoadLocalVariableAddress(il, num);
				((ILGenerator)il).Emit(OpCodes.Initobj, newExpression.Type);
			}
			ReadOnlyCollection<MemberBinding> bindings = ((MemberInitExpression)expr).Bindings;
			for (int j = 0; j < bindings.Count; j++)
			{
				MemberBinding memberBinding = bindings[j];
				if (memberBinding.BindingType != 0)
				{
					return false;
				}
				if (num != -1)
				{
					EmitLoadLocalVariableAddress(il, num);
				}
				else
				{
					((ILGenerator)il).Emit(OpCodes.Dup);
				}
				if (!TryEmit(((MemberAssignment)memberBinding).Expression, paramExprs, il, ref closure, parent) || !EmitMemberAssign(il, memberBinding.Member))
				{
					return false;
				}
			}
			if (num != -1)
			{
				EmitLoadLocalVariable(il, num);
			}
			return true;
		}

		private static bool EmitMemberAssign(object il, object member)
		{
			//Discarded unreachable code: IL_00aa
			int num = 7;
			int num2 = num;
			PropertyInfo propertyInfo = default(PropertyInfo);
			FieldInfo fieldInfo = default(FieldInfo);
			MethodInfo methodInfo = default(MethodInfo);
			while (true)
			{
				switch (num2)
				{
				case 7:
					if ((object)(propertyInfo = member as PropertyInfo) == null)
					{
						num2 = 6;
						break;
					}
					goto case 3;
				case 4:
					return true;
				case 6:
					if ((object)(fieldInfo = member as FieldInfo) != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 5;
						}
						break;
					}
					return false;
				case 2:
					if (methodInfo == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						cr9PXh88BxyHDixSqTcC(il, wl8EMB88kTNmCG4OyVv6(methodInfo) ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						num2 = 4;
					}
					break;
				case 3:
					methodInfo = (MethodInfo)fBt6Va88T9YSt8ARF6Or(Nc9dVJ88XPZkULo3u0Bi(propertyInfo), propertyInfo.Name);
					num2 = 2;
					break;
				default:
					return true;
				case 1:
					return false;
				case 5:
					((ILGenerator)il).Emit(deLCCA88neVcu5oRhSLo(fieldInfo) ? OpCodes.Stsfld : OpCodes.Stfld, fieldInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private static bool TryEmitIncDecAssign(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Expression operand = ((UnaryExpression)expr).Operand;
			bool flag = false;
			int num = -1;
			bool flag2 = operand.NodeType == ExpressionType.Parameter;
			bool flag3 = (parent & ParentFlags.IgnoreResult) == 0;
			int num2;
			MemberExpression memberExpression;
			if (flag2)
			{
				num2 = closure.GetDefinedLocalVarOrDefault((ParameterExpression)operand);
				if (num2 != -1)
				{
					EmitLoadLocalVariable(il, num2);
					flag = true;
				}
				else
				{
					num = paramExprs.Count - 1;
					while (num != -1 && paramExprs[num] != operand)
					{
						num--;
					}
					if (num == -1)
					{
						return false;
					}
					((ILGenerator)il).Emit(OpCodes.Ldarg, num + 1);
				}
				memberExpression = null;
			}
			else
			{
				if (operand.NodeType != ExpressionType.MemberAccess)
				{
					return false;
				}
				memberExpression = (MemberExpression)operand;
				if (!TryEmitMemberAccess(memberExpression, paramExprs, il, ref closure, parent | ParentFlags.DupMemberOwner))
				{
					return false;
				}
				flag = memberExpression.Expression != null && (flag3 || memberExpression.Member is PropertyInfo);
				num2 = (flag ? ((ILGenerator)il).GetNextLocalVarIndex(operand.Type) : (-1));
			}
			switch (((Expression)expr).NodeType)
			{
			case ExpressionType.PreIncrementAssign:
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
				((ILGenerator)il).Emit(OpCodes.Add);
				StoreIncDecValue(il, flag3, flag2, num2);
				break;
			case ExpressionType.PostIncrementAssign:
				StoreIncDecValue(il, flag3, flag2, num2);
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
				((ILGenerator)il).Emit(OpCodes.Add);
				break;
			case ExpressionType.PreDecrementAssign:
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
				((ILGenerator)il).Emit(OpCodes.Sub);
				StoreIncDecValue(il, flag3, flag2, num2);
				break;
			case ExpressionType.PostDecrementAssign:
				StoreIncDecValue(il, flag3, flag2, num2);
				((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
				((ILGenerator)il).Emit(OpCodes.Sub);
				break;
			}
			if (flag2 && num != -1)
			{
				((ILGenerator)il).Emit(OpCodes.Starg_S, num + 1);
			}
			else if (flag2 || (flag && !flag3))
			{
				EmitStoreLocalVariable(il, num2);
			}
			if (flag2)
			{
				return true;
			}
			if (flag && !flag3)
			{
				EmitLoadLocalVariable(il, num2);
			}
			if (!EmitMemberAssign(il, memberExpression.Member))
			{
				return false;
			}
			if (flag && flag3)
			{
				EmitLoadLocalVariable(il, num2);
			}
			return true;
		}

		private static void StoreIncDecValue(object il, bool usesResult, bool isVar, int localVarIndex)
		{
			//Discarded unreachable code: IL_00a0, IL_00d0, IL_00df
			int num = 8;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return;
					case 7:
						if (isVar)
						{
							goto end_IL_0012;
						}
						goto case 1;
					case 1:
						if (localVarIndex == -1)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num2 = 0;
							}
							break;
						}
						n5iKim888ZeKefyA2HBg(il, localVarIndex);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 5;
						}
						break;
					default:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Dup);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 4;
						}
						break;
					case 3:
						return;
					case 8:
						if (!usesResult)
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 7;
						}
						break;
					case 5:
						sAHEtL8vcqrjhyn5Thl8(il, localVarIndex);
						num2 = 3;
						break;
					case 6:
						return;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}

		private static bool TryEmitAssign(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Expression left = ((BinaryExpression)expr).Left;
			Expression right = ((BinaryExpression)expr).Right;
			ExpressionType nodeType = ((BinaryExpression)expr).Left.NodeType;
			ExpressionType nodeType2 = ((Expression)expr).NodeType;
			ParentFlags parentFlags = parent & ~ParentFlags.IgnoreResult;
			switch (nodeType)
			{
			case ExpressionType.Parameter:
			{
				ParameterExpression parameterExpression = (ParameterExpression)left;
				int num = paramExprs.Count - 1;
				while (num != -1 && paramExprs[num] != parameterExpression)
				{
					num--;
				}
				ExpressionType expressionType = nodeType2;
				switch (nodeType2)
				{
				case ExpressionType.AddAssign:
					expressionType = ExpressionType.Add;
					break;
				case ExpressionType.AddAssignChecked:
					expressionType = ExpressionType.AddChecked;
					break;
				case ExpressionType.SubtractAssign:
					expressionType = ExpressionType.Subtract;
					break;
				case ExpressionType.SubtractAssignChecked:
					expressionType = ExpressionType.SubtractChecked;
					break;
				case ExpressionType.MultiplyAssign:
					expressionType = ExpressionType.Multiply;
					break;
				case ExpressionType.MultiplyAssignChecked:
					expressionType = ExpressionType.MultiplyChecked;
					break;
				case ExpressionType.DivideAssign:
					expressionType = ExpressionType.Divide;
					break;
				case ExpressionType.ModuloAssign:
					expressionType = ExpressionType.Modulo;
					break;
				case ExpressionType.PowerAssign:
					expressionType = ExpressionType.Power;
					break;
				case ExpressionType.AndAssign:
					expressionType = ExpressionType.And;
					break;
				case ExpressionType.OrAssign:
					expressionType = ExpressionType.Or;
					break;
				case ExpressionType.ExclusiveOrAssign:
					expressionType = ExpressionType.ExclusiveOr;
					break;
				case ExpressionType.LeftShiftAssign:
					expressionType = ExpressionType.LeftShift;
					break;
				case ExpressionType.RightShiftAssign:
					expressionType = ExpressionType.RightShift;
					break;
				}
				if (num != -1)
				{
					if ((closure.Status & ClosureStatus.ShouldBeStaticMethod) == 0)
					{
						num++;
					}
					if (parameterExpression.IsByRef)
					{
						switch (num)
						{
						case 0:
							((ILGenerator)il).Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							((ILGenerator)il).Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							((ILGenerator)il).Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							((ILGenerator)il).Emit(OpCodes.Ldarg_3);
							break;
						default:
							((ILGenerator)il).Emit(OpCodes.Ldarg_S, (byte)num);
							break;
						}
					}
					if (expressionType == nodeType2)
					{
						if (!TryEmit(right, paramExprs, il, ref closure, parentFlags))
						{
							return false;
						}
					}
					else if (!TryEmitArithmetic(expr, expressionType, paramExprs, il, ref closure, parent))
					{
						return false;
					}
					if ((parent & ParentFlags.IgnoreResult) == 0)
					{
						((ILGenerator)il).Emit(OpCodes.Dup);
					}
					if (parameterExpression.IsByRef)
					{
						EmitByRefStore(il, parameterExpression.Type);
					}
					else
					{
						((ILGenerator)il).Emit(OpCodes.Starg_S, num);
					}
					return true;
				}
				if (expressionType != nodeType2)
				{
					int definedLocalVarOrDefault = closure.GetDefinedLocalVarOrDefault(parameterExpression);
					if (definedLocalVarOrDefault != -1)
					{
						if (!TryEmitArithmetic(expr, expressionType, paramExprs, il, ref closure, parent))
						{
							return false;
						}
						EmitStoreLocalVariable(il, definedLocalVarOrDefault);
						return true;
					}
				}
				int definedLocalVarOrDefault2 = closure.GetDefinedLocalVarOrDefault(parameterExpression);
				if (definedLocalVarOrDefault2 != -1)
				{
					if (!TryEmit(right, paramExprs, il, ref closure, parentFlags))
					{
						return false;
					}
					ParameterExpression obj = right as ParameterExpression;
					if (obj != null && obj.IsByRef)
					{
						((ILGenerator)il).Emit(OpCodes.Ldind_I4);
					}
					if ((parent & ParentFlags.IgnoreResult) == 0)
					{
						((ILGenerator)il).Emit(OpCodes.Dup);
					}
					EmitStoreLocalVariable(il, definedLocalVarOrDefault2);
					return true;
				}
				ParameterExpression[] nonPassedParameters = closure.NonPassedParameters;
				int num2 = nonPassedParameters.Length - 1;
				while (num2 != -1 && nonPassedParameters[num2] != parameterExpression)
				{
					num2--;
				}
				if (num2 == -1)
				{
					return false;
				}
				((ILGenerator)il).Emit(OpCodes.Ldarg_0);
				if ((parent & ParentFlags.IgnoreResult) == 0)
				{
					if (!TryEmit(right, paramExprs, il, ref closure, parentFlags))
					{
						return false;
					}
					int nextLocalVarIndex2 = ((ILGenerator)il).GetNextLocalVarIndex(((Expression)expr).Type);
					EmitStoreLocalVariable(il, nextLocalVarIndex2);
					((ILGenerator)il).Emit(OpCodes.Ldfld, ArrayClosureWithNonPassedParamsField);
					EmitLoadConstantInt(il, num2);
					EmitLoadLocalVariable(il, nextLocalVarIndex2);
					if (((Expression)expr).Type.IsValueType())
					{
						((ILGenerator)il).Emit(OpCodes.Box, ((Expression)expr).Type);
					}
					((ILGenerator)il).Emit(OpCodes.Stelem_Ref);
					EmitLoadLocalVariable(il, nextLocalVarIndex2);
				}
				else
				{
					((ILGenerator)il).Emit(OpCodes.Ldfld, ArrayClosureWithNonPassedParamsField);
					EmitLoadConstantInt(il, num2);
					if (!TryEmit(right, paramExprs, il, ref closure, parentFlags))
					{
						return false;
					}
					if (((Expression)expr).Type.IsValueType())
					{
						((ILGenerator)il).Emit(OpCodes.Box, ((Expression)expr).Type);
					}
					((ILGenerator)il).Emit(OpCodes.Stelem_Ref);
				}
				return true;
			}
			case ExpressionType.MemberAccess:
			{
				bool flag = right.NodeType == ExpressionType.Try;
				int location = -1;
				if (flag)
				{
					location = ((ILGenerator)il).GetNextLocalVarIndex(right.Type);
					if (!TryEmit(right, paramExprs, il, ref closure, ParentFlags.Empty))
					{
						return false;
					}
					EmitStoreLocalVariable(il, location);
				}
				MemberExpression memberExpression = (MemberExpression)left;
				Expression expression = memberExpression.Expression;
				if (expression != null && !TryEmit(expression, paramExprs, il, ref closure, parentFlags | ParentFlags.MemberAccess | ParentFlags.InstanceAccess))
				{
					return false;
				}
				if (flag)
				{
					EmitLoadLocalVariable(il, location);
				}
				else if (!TryEmit(right, paramExprs, il, ref closure, ParentFlags.Empty))
				{
					return false;
				}
				MemberInfo member = memberExpression.Member;
				if ((parent & ParentFlags.IgnoreResult) != 0)
				{
					return EmitMemberAssign(il, member);
				}
				((ILGenerator)il).Emit(OpCodes.Dup);
				int nextLocalVarIndex3 = ((ILGenerator)il).GetNextLocalVarIndex(((Expression)expr).Type);
				EmitStoreLocalVariable(il, nextLocalVarIndex3);
				if (!EmitMemberAssign(il, member))
				{
					return false;
				}
				EmitLoadLocalVariable(il, nextLocalVarIndex3);
				return true;
			}
			case ExpressionType.Index:
			{
				IndexExpression indexExpression = (IndexExpression)left;
				Expression @object = indexExpression.Object;
				if (@object != null && !TryEmit(@object, paramExprs, il, ref closure, parentFlags))
				{
					return false;
				}
				ReadOnlyCollection<Expression> arguments = indexExpression.Arguments;
				for (int i = 0; i < arguments.Count; i++)
				{
					if (!TryEmit(arguments[i], paramExprs, il, ref closure, parentFlags, i))
					{
						return false;
					}
				}
				if (!TryEmit(right, paramExprs, il, ref closure, parentFlags))
				{
					return false;
				}
				if ((parent & ParentFlags.IgnoreResult) != 0)
				{
					return TryEmitIndexAssign(indexExpression, @object?.Type, ((Expression)expr).Type, il);
				}
				int nextLocalVarIndex = ((ILGenerator)il).GetNextLocalVarIndex(((Expression)expr).Type);
				((ILGenerator)il).Emit(OpCodes.Dup);
				EmitStoreLocalVariable(il, nextLocalVarIndex);
				if (!TryEmitIndexAssign(indexExpression, @object?.Type, ((Expression)expr).Type, il))
				{
					return false;
				}
				EmitLoadLocalVariable(il, nextLocalVarIndex);
				return true;
			}
			default:
				return false;
			}
		}

		private static void EmitByRefStore(object il, Type type)
		{
			//Discarded unreachable code: IL_00dd, IL_01cb, IL_01da, IL_01e9, IL_02f5, IL_0359, IL_0368
			int num = 17;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						return;
					case 18:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(double).TypeHandle)))
						{
							num2 = 15;
							continue;
						}
						if (type == typeof(object))
						{
							num2 = 4;
							continue;
						}
						if (!(type == U4TPVi8vg9UgNc6Skdyl(typeof(IntPtr).TypeHandle)))
						{
							num2 = 8;
							continue;
						}
						goto case 25;
					case 7:
						return;
					case 4:
						break;
					case 2:
						return;
					case 9:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(long).TypeHandle)))
						{
							num2 = 24;
							continue;
						}
						goto case 19;
					case 15:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_R8);
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 11;
						}
						continue;
					case 22:
						return;
					case 21:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(byte).TypeHandle)))
						{
							num2 = 11;
							continue;
						}
						goto case 14;
					case 10:
						((ILGenerator)il).Emit(OpCodes.Stind_R4);
						num2 = 5;
						continue;
					case 26:
						return;
					case 19:
						((ILGenerator)il).Emit(OpCodes.Stind_I8);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						return;
					case 24:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(ulong).TypeHandle)))
						{
							if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(float).TypeHandle)))
							{
								num2 = 18;
								continue;
							}
							goto case 10;
						}
						num2 = 19;
						continue;
					case 17:
						if (fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(int).TypeHandle)))
						{
							num2 = 16;
							continue;
						}
						goto case 13;
					case 23:
						return;
					default:
						if (!(type == U4TPVi8vg9UgNc6Skdyl(typeof(ushort).TypeHandle)))
						{
							num2 = 9;
							continue;
						}
						goto case 6;
					case 25:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I);
						num2 = 7;
						continue;
					case 6:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I2);
						num2 = 2;
						continue;
					case 20:
						return;
					case 11:
						if (!fXH2wl8v53gf6fwkZ1cA(type, typeof(short)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 6;
					case 12:
					case 16:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I4);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 22;
						}
						continue;
					case 14:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I1);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 20;
						}
						continue;
					case 3:
						return;
					case 8:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(UIntPtr).TypeHandle)))
						{
							J2osBm8vUaIa3b3WwLmF(il, OpCodes.Stobj, type);
							num2 = 3;
							continue;
						}
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 9;
						}
						continue;
					case 13:
						if (!fXH2wl8v53gf6fwkZ1cA(type, U4TPVi8vg9UgNc6Skdyl(typeof(uint).TypeHandle)))
						{
							num2 = 21;
							continue;
						}
						goto case 12;
					}
					break;
				}
				pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_Ref);
				num = 23;
			}
		}

		private static bool TryEmitIndexAssign(object indexExpr, Type instType, Type elementType, object il)
		{
			//Discarded unreachable code: IL_00db, IL_00ea
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return EmitMemberAssign(il, JBBhye88OM33sBK79Znn(indexExpr));
				case 4:
					if (!(((IndexExpression)indexExpr).Indexer != null))
					{
						if (((IndexExpression)indexExpr).Arguments.Count != 1)
						{
							return EmitMethodCall(il, ((object)instType != null) ? uoSAA2882sdDqJKDnujY(instType, Fn0VLG88qZFRYO4uCytV(0x57A5235E ^ 0x57A4AC2A)) : null);
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 3;
					}
					break;
				case 6:
					J2osBm8vUaIa3b3WwLmF(il, OpCodes.Stelem, elementType);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 2;
					}
					break;
				default:
					pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stelem_Ref);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					if (PjFnO38vzkxjGZ63tFdS(elementType))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				case 2:
				case 5:
					return true;
				}
			}
		}

		private static bool TryEmitMethodCall(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			ParentFlags parentFlags = (parent & ~ParentFlags.IgnoreResult) | ParentFlags.Call;
			MethodCallExpression methodCallExpression = (MethodCallExpression)expr;
			Expression @object = methodCallExpression.Object;
			MethodInfo method = methodCallExpression.Method;
			ParameterInfo[] parameters = method.GetParameters();
			bool flag = false;
			if (@object != null)
			{
				if (!TryEmit(@object, paramExprs, il, ref closure, parentFlags | ParentFlags.InstanceAccess))
				{
					return false;
				}
				flag = @object.Type.IsValueType();
				if (flag && @object.NodeType != ExpressionType.Parameter && !closure.LastEmitIsAddress)
				{
					EmitStoreLocalVariableAndLoadItsAddress(il, @object.Type);
				}
			}
			ReadOnlyCollection<Expression> arguments = methodCallExpression.Arguments;
			for (int i = 0; i < parameters.Length; i++)
			{
				if (!TryEmit(arguments[i], paramExprs, il, ref closure, parentFlags, parameters[i].ParameterType.IsByRef ? i : (-1)))
				{
					return false;
				}
			}
			if (flag && method.IsVirtual)
			{
				((ILGenerator)il).Emit(OpCodes.Constrained, @object.Type);
			}
			((ILGenerator)il).Emit(method.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, method);
			if (parent.IgnoresResult() && method.ReturnType != typeof(void))
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			closure.LastEmitIsAddress = false;
			return true;
		}

		private static bool TryEmitMemberAccess(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			if (((MemberExpression)expr).Member is PropertyInfo propertyInfo)
			{
				Expression expression = ((MemberExpression)expr).Expression;
				if (expression != null)
				{
					if (!TryEmit(expression, paramExprs, il, ref closure, ~(ParentFlags.IgnoreResult | ParentFlags.DupMemberOwner) & (parent | ParentFlags.Call | ParentFlags.MemberAccess | ParentFlags.InstanceAccess)))
					{
						return false;
					}
					if ((parent & ParentFlags.DupMemberOwner) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Dup);
					}
					if (!closure.LastEmitIsAddress && expression.NodeType != ExpressionType.Parameter && expression.Type.IsValueType())
					{
						EmitStoreLocalVariableAndLoadItsAddress(il, expression.Type);
					}
				}
				closure.LastEmitIsAddress = false;
				MethodInfo methodInfo = propertyInfo.DeclaringType.FindPropertyGetMethod(propertyInfo.Name);
				if (methodInfo == null)
				{
					return false;
				}
				((ILGenerator)il).Emit(methodInfo.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				return true;
			}
			if (((MemberExpression)expr).Member is FieldInfo fieldInfo)
			{
				Expression expression2 = ((MemberExpression)expr).Expression;
				if (expression2 != null)
				{
					if (!TryEmit(expression2, paramExprs, il, ref closure, ~(ParentFlags.IgnoreResult | ParentFlags.DupMemberOwner) & (parent | ParentFlags.MemberAccess | ParentFlags.InstanceAccess)))
					{
						return false;
					}
					if ((parent & ParentFlags.DupMemberOwner) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Dup);
					}
					closure.LastEmitIsAddress = fieldInfo.FieldType.IsValueType() && (parent & ParentFlags.InstanceAccess) != 0;
					((ILGenerator)il).Emit(closure.LastEmitIsAddress ? OpCodes.Ldflda : OpCodes.Ldfld, fieldInfo);
				}
				else if (fieldInfo.IsLiteral)
				{
					object value = fieldInfo.GetValue(null);
					if (value != null)
					{
						return TryEmitNotNullConstant(considerClosure: false, fieldInfo.FieldType, value, il, ref closure);
					}
					((ILGenerator)il).Emit(OpCodes.Ldnull);
				}
				else
				{
					((ILGenerator)il).Emit(OpCodes.Ldsfld, fieldInfo);
				}
				return true;
			}
			return false;
		}

		private static bool TryEmitNestedLambda(object lambdaExpr, IReadOnlyList<ParameterExpression> outerParamExprs, object il, ref ClosureInfo closure)
		{
			NestedLambdaInfo[] nestedLambdas = closure.NestedLambdas;
			int num = nestedLambdas.Length - 1;
			while (num != -1 && nestedLambdas[num].LambdaExpression != lambdaExpr)
			{
				num--;
			}
			if (num == -1)
			{
				return false;
			}
			NestedLambdaInfo nestedLambdaInfo = closure.NestedLambdas[num];
			object lambda = nestedLambdaInfo.Lambda;
			int i = num + closure.Constants.Count;
			int num2 = nestedLambdaInfo.UsageCountOrVarIndex - 1;
			if (num2 > 0)
			{
				EmitLoadLocalVariable(il, num2);
			}
			else
			{
				((ILGenerator)il).Emit(OpCodes.Ldloc_0);
				EmitLoadConstantInt(il, i);
				((ILGenerator)il).Emit(OpCodes.Ldelem_Ref);
			}
			ParameterExpression[] nonPassedParameters = nestedLambdaInfo.ClosureInfo.NonPassedParameters;
			if (nonPassedParameters.Length == 0)
			{
				return true;
			}
			if (num2 > 0)
			{
				((ILGenerator)il).Emit(OpCodes.Ldfld, NestedLambdaWithConstantsAndNestedLambdas.NestedLambdaField);
				EmitLoadLocalVariable(il, num2);
				((ILGenerator)il).Emit(OpCodes.Ldfld, NestedLambdaWithConstantsAndNestedLambdas.ConstantsAndNestedLambdasField);
			}
			else
			{
				int nextLocalVarIndex = ((ILGenerator)il).GetNextLocalVarIndex(typeof(NestedLambdaWithConstantsAndNestedLambdas));
				EmitStoreLocalVariable(il, nextLocalVarIndex);
				EmitLoadLocalVariable(il, nextLocalVarIndex);
				((ILGenerator)il).Emit(OpCodes.Ldfld, NestedLambdaWithConstantsAndNestedLambdas.NestedLambdaField);
				EmitLoadLocalVariable(il, nextLocalVarIndex);
				((ILGenerator)il).Emit(OpCodes.Ldfld, NestedLambdaWithConstantsAndNestedLambdas.ConstantsAndNestedLambdasField);
			}
			EmitLoadConstantInt(il, nonPassedParameters.Length);
			((ILGenerator)il).Emit(OpCodes.Newarr, typeof(object));
			ParameterExpression[] nonPassedParameters2 = closure.NonPassedParameters;
			for (int j = 0; j < nonPassedParameters.Length; j++)
			{
				ParameterExpression parameterExpression = nonPassedParameters[j];
				((ILGenerator)il).Emit(OpCodes.Dup);
				EmitLoadConstantInt(il, j);
				int num3 = outerParamExprs.Count - 1;
				while (num3 != -1 && outerParamExprs[num3] != parameterExpression)
				{
					num3--;
				}
				if (num3 != -1)
				{
					switch (num3)
					{
					case 0:
						((ILGenerator)il).Emit(OpCodes.Ldarg_1);
						break;
					case 1:
						((ILGenerator)il).Emit(OpCodes.Ldarg_2);
						break;
					case 2:
						((ILGenerator)il).Emit(OpCodes.Ldarg_3);
						break;
					default:
						((ILGenerator)il).Emit(OpCodes.Ldarg_S, (byte)(1 + num3));
						break;
					}
					if (parameterExpression.Type.IsValueType())
					{
						((ILGenerator)il).Emit(OpCodes.Box, parameterExpression.Type);
					}
				}
				else
				{
					if (nonPassedParameters2.Length == 0)
					{
						return false;
					}
					int definedLocalVarOrDefault = closure.GetDefinedLocalVarOrDefault(parameterExpression);
					if (definedLocalVarOrDefault != -1)
					{
						EmitLoadLocalVariable(il, definedLocalVarOrDefault);
					}
					else
					{
						int num4 = nonPassedParameters2.Length - 1;
						while (num4 != -1 && nonPassedParameters2[num4] != parameterExpression)
						{
							num4--;
						}
						if (num4 == -1)
						{
							return false;
						}
						((ILGenerator)il).Emit(OpCodes.Ldarg_0);
						((ILGenerator)il).Emit(OpCodes.Ldfld, ArrayClosureWithNonPassedParamsField);
						EmitLoadConstantInt(il, num4);
						((ILGenerator)il).Emit(OpCodes.Ldelem_Ref);
					}
				}
				((ILGenerator)il).Emit(OpCodes.Stelem_Ref);
			}
			((ILGenerator)il).Emit(OpCodes.Newobj, ArrayClosureWithNonPassedParamsConstructor);
			Type[] genericTypeArguments = lambda.GetType().GetTypeInfo().GenericTypeArguments;
			MethodInfo meth = ((((LambdaExpression)nestedLambdaInfo.LambdaExpression).ReturnType == typeof(void)) ? CurryClosureActions.Methods[genericTypeArguments.Length - 1].MakeGenericMethod(genericTypeArguments) : CurryClosureFuncs.Methods[genericTypeArguments.Length - 2].MakeGenericMethod(genericTypeArguments));
			((ILGenerator)il).Emit(OpCodes.Call, meth);
			return true;
		}

		private static bool TryEmitInvoke(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Expression expression = ((InvocationExpression)expr).Expression;
			if (!TryEmit(expression, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult))
			{
				return false;
			}
			ReadOnlyCollection<Expression> arguments = ((InvocationExpression)expr).Arguments;
			if (arguments.Count != 0)
			{
				ParentFlags parent2 = parent & ~ParentFlags.IgnoreResult & ~ParentFlags.InstanceAccess;
				for (int i = 0; i < arguments.Count; i++)
				{
					if (!TryEmit(arguments[i], paramExprs, il, ref closure, parent2, arguments[i].Type.IsByRef ? i : (-1)))
					{
						return false;
					}
				}
			}
			MethodInfo methodInfo = expression.Type.FindDelegateInvokeMethod();
			((ILGenerator)il).Emit(OpCodes.Call, methodInfo);
			if ((parent & ParentFlags.IgnoreResult) != 0 && methodInfo.ReturnType != typeof(void))
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			return true;
		}

		private static bool TryEmitSwitch(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Label label = ((ILGenerator)il).DefineLabel();
			Label[] array = new Label[((SwitchExpression)expr).Cases.Count];
			for (int i = 0; i < ((SwitchExpression)expr).Cases.Count; i++)
			{
				SwitchCase switchCase = ((SwitchExpression)expr).Cases[i];
				array[i] = ((ILGenerator)il).DefineLabel();
				foreach (Expression testValue in switchCase.TestValues)
				{
					if (!TryEmitComparison(((SwitchExpression)expr).SwitchValue, testValue, ExpressionType.Equal, paramExprs, il, ref closure, parent))
					{
						return false;
					}
					((ILGenerator)il).Emit(OpCodes.Brtrue, array[i]);
				}
			}
			if (((SwitchExpression)expr).DefaultBody != null)
			{
				if (!TryEmit(((SwitchExpression)expr).DefaultBody, paramExprs, il, ref closure, parent))
				{
					return false;
				}
				((ILGenerator)il).Emit(OpCodes.Br, label);
			}
			for (int j = 0; j < ((SwitchExpression)expr).Cases.Count; j++)
			{
				SwitchCase switchCase2 = ((SwitchExpression)expr).Cases[j];
				((ILGenerator)il).MarkLabel(array[j]);
				if (!TryEmit(switchCase2.Body, paramExprs, il, ref closure, parent))
				{
					return false;
				}
				if (j != ((SwitchExpression)expr).Cases.Count - 1)
				{
					((ILGenerator)il).Emit(OpCodes.Br, label);
				}
			}
			((ILGenerator)il).MarkLabel(label);
			return true;
		}

		private static bool TryEmitComparison(object exprLeft, object exprRight, ExpressionType expressionType, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Type type = ((Expression)exprLeft).Type;
			bool flag = type.IsNullable();
			Type type2 = ((Expression)exprRight).Type;
			if (exprRight is ConstantExpression constantExpression && constantExpression.Value == null && ((Expression)exprRight).Type == typeof(object))
			{
				type2 = type;
			}
			int location = -1;
			int location2 = -1;
			if (!TryEmit(exprLeft, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult & ~ParentFlags.InstanceAccess))
			{
				return false;
			}
			if (flag)
			{
				location = EmitStoreLocalVariableAndLoadItsAddress(il, type);
				((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableGetValueOrDefaultMethod());
				type = Nullable.GetUnderlyingType(type);
			}
			if (!TryEmit(exprRight, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult & ~ParentFlags.InstanceAccess))
			{
				return false;
			}
			if (type != type2 && type.IsClass() && type2.IsClass() && (type == typeof(object) || type2 == typeof(object)))
			{
				switch (expressionType)
				{
				case ExpressionType.Equal:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						((ILGenerator)il).Emit(OpCodes.Pop);
					}
					break;
				case ExpressionType.NotEqual:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
					((ILGenerator)il).Emit(OpCodes.Ceq);
					break;
				default:
					return false;
				}
				if ((parent & ParentFlags.IgnoreResult) != 0)
				{
					((ILGenerator)il).Emit(OpCodes.Pop);
				}
				return true;
			}
			if (type2.IsNullable())
			{
				location2 = EmitStoreLocalVariableAndLoadItsAddress(il, type2);
				((ILGenerator)il).Emit(OpCodes.Call, type2.FindNullableGetValueOrDefaultMethod());
				type2 = Nullable.GetUnderlyingType(type2);
			}
			TypeInfo typeInfo = type.GetTypeInfo();
			if (!typeInfo.IsPrimitive && !typeInfo.IsEnum)
			{
				string text = expressionType switch
				{
					ExpressionType.LessThanOrEqual => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x834AF96), 
					ExpressionType.LessThan => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978201282), 
					ExpressionType.GreaterThanOrEqual => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489056211), 
					ExpressionType.GreaterThan => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766137538), 
					ExpressionType.NotEqual => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A64E98A), 
					ExpressionType.Equal => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867968994), 
					_ => null, 
				};
				if (text == null)
				{
					return false;
				}
				MethodInfo[] array = typeInfo.DeclaredMethods.AsArray();
				foreach (MethodInfo methodInfo in array)
				{
					if (methodInfo.IsSpecialName && methodInfo.IsStatic && methodInfo.Name == text && IsComparisonOperatorSignature(type, methodInfo.GetParameters()))
					{
						((ILGenerator)il).Emit(OpCodes.Call, methodInfo);
						return true;
					}
				}
				if (expressionType != ExpressionType.Equal && expressionType != ExpressionType.NotEqual)
				{
					return false;
				}
				((ILGenerator)il).Emit(OpCodes.Call, (MethodInfo)_objectEqualsMethod);
				if (expressionType == ExpressionType.NotEqual)
				{
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
					((ILGenerator)il).Emit(OpCodes.Ceq);
				}
				if (!flag)
				{
					if ((parent & ParentFlags.IgnoreResult) > ParentFlags.Empty)
					{
						((ILGenerator)il).Emit(OpCodes.Pop);
					}
					return true;
				}
			}
			else
			{
				switch (expressionType)
				{
				case ExpressionType.Equal:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					break;
				case ExpressionType.NotEqual:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
					((ILGenerator)il).Emit(OpCodes.Ceq);
					break;
				case ExpressionType.LessThan:
					((ILGenerator)il).Emit(OpCodes.Clt);
					break;
				case ExpressionType.GreaterThan:
					((ILGenerator)il).Emit(OpCodes.Cgt);
					break;
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.LessThanOrEqual:
				{
					Label label = ((ILGenerator)il).DefineLabel();
					if (type2 == typeof(uint) || type2 == typeof(ulong) || type2 == typeof(ushort) || type2 == typeof(byte))
					{
						((ILGenerator)il).Emit((expressionType == ExpressionType.GreaterThanOrEqual) ? OpCodes.Bge_Un_S : OpCodes.Ble_Un_S, label);
					}
					else
					{
						((ILGenerator)il).Emit((expressionType == ExpressionType.GreaterThanOrEqual) ? OpCodes.Bge_S : OpCodes.Ble_S, label);
					}
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
					Label label2 = ((ILGenerator)il).DefineLabel();
					((ILGenerator)il).Emit(OpCodes.Br_S, label2);
					((ILGenerator)il).MarkLabel(label);
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
					((ILGenerator)il).MarkLabel(label2);
					break;
				}
				default:
					return false;
				}
			}
			if (flag)
			{
				MethodInfo meth = ((Expression)exprLeft).Type.FindNullableHasValueGetterMethod();
				EmitLoadLocalVariableAddress(il, location);
				((ILGenerator)il).Emit(OpCodes.Call, meth);
				EmitLoadLocalVariableAddress(il, location2);
				((ILGenerator)il).Emit(OpCodes.Call, meth);
				switch (expressionType)
				{
				case ExpressionType.Equal:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.And);
					break;
				case ExpressionType.NotEqual:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.Or);
					break;
				case ExpressionType.GreaterThan:
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.LessThan:
				case ExpressionType.LessThanOrEqual:
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_1);
					((ILGenerator)il).Emit(OpCodes.Ceq);
					((ILGenerator)il).Emit(OpCodes.And);
					break;
				default:
					return false;
				}
			}
			if ((parent & ParentFlags.IgnoreResult) > ParentFlags.Empty)
			{
				((ILGenerator)il).Emit(OpCodes.Pop);
			}
			return true;
		}

		private static bool IsComparisonOperatorSignature(Type t, object pars)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (((Array)pars).Length == 2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_005a;
				case 2:
					return fXH2wl8v53gf6fwkZ1cA(otgWhy88e6vv3pdqxkCd(((object[])pars)[1]), t);
				default:
					{
						if (fXH2wl8v53gf6fwkZ1cA(((ParameterInfo)((object[])pars)[0]).ParameterType, t))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_005a;
					}
					IL_005a:
					return false;
				}
			}
		}

		private static bool TryEmitArithmetic(object expr, ExpressionType exprNodeType, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			ParentFlags parentFlags = (parent & ~ParentFlags.IgnoreResult & ~ParentFlags.InstanceCall) | ParentFlags.Arithmetic;
			Label label = default(Label);
			Expression left = ((BinaryExpression)expr).Left;
			Type type = left.Type;
			bool flag = type.IsNullable();
			if (flag)
			{
				label = ((ILGenerator)il).DefineLabel();
				if (!TryEmit(left, paramExprs, il, ref closure, parentFlags | ParentFlags.InstanceCall))
				{
					return false;
				}
				if (!closure.LastEmitIsAddress)
				{
					EmitStoreLocalVariableAndLoadItsAddress(il, type);
				}
				((ILGenerator)il).Emit(OpCodes.Dup);
				((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableHasValueGetterMethod());
				((ILGenerator)il).Emit(OpCodes.Brfalse, label);
				((ILGenerator)il).Emit(OpCodes.Call, type.FindNullableGetValueOrDefaultMethod());
			}
			else if (!TryEmit(left, paramExprs, il, ref closure, parentFlags))
			{
				return false;
			}
			Label label2 = default(Label);
			Expression right = ((BinaryExpression)expr).Right;
			Type type2 = right.Type;
			bool flag2 = type2.IsNullable();
			if (flag2)
			{
				label2 = ((ILGenerator)il).DefineLabel();
				if (!TryEmit(right, paramExprs, il, ref closure, parentFlags | ParentFlags.InstanceCall))
				{
					return false;
				}
				if (!closure.LastEmitIsAddress)
				{
					EmitStoreLocalVariableAndLoadItsAddress(il, type2);
				}
				((ILGenerator)il).Emit(OpCodes.Dup);
				((ILGenerator)il).Emit(OpCodes.Call, type2.FindNullableHasValueGetterMethod());
				((ILGenerator)il).Emit(OpCodes.Brfalse, label2);
				((ILGenerator)il).Emit(OpCodes.Call, type2.FindNullableGetValueOrDefaultMethod());
			}
			else if (!TryEmit(right, paramExprs, il, ref closure, parentFlags))
			{
				return false;
			}
			Type type3 = ((Expression)expr).Type;
			if (!TryEmitArithmeticOperation(expr, exprNodeType, type3, il))
			{
				return false;
			}
			if (flag || flag2)
			{
				Label label3 = ((ILGenerator)il).DefineLabel();
				((ILGenerator)il).Emit(OpCodes.Br, label3);
				if (flag2)
				{
					((ILGenerator)il).MarkLabel(label2);
				}
				((ILGenerator)il).Emit(OpCodes.Pop);
				if (flag)
				{
					((ILGenerator)il).MarkLabel(label);
				}
				((ILGenerator)il).Emit(OpCodes.Pop);
				if (type3.IsNullable())
				{
					Label label4 = ((ILGenerator)il).DefineLabel();
					int location = InitValueTypeVariable(il, type3);
					EmitLoadLocalVariable(il, location);
					((ILGenerator)il).Emit(OpCodes.Br_S, label4);
					((ILGenerator)il).MarkLabel(label3);
					((ILGenerator)il).Emit(OpCodes.Newobj, type3.GetTypeInfo().DeclaredConstructors.GetFirst());
					((ILGenerator)il).MarkLabel(label4);
				}
				else
				{
					((ILGenerator)il).Emit(OpCodes.Ldc_I4_0);
					((ILGenerator)il).MarkLabel(label3);
				}
			}
			return true;
		}

		private static bool TryEmitArithmeticOperation(object expr, ExpressionType exprNodeType, Type exprType, object il)
		{
			//Discarded unreachable code: IL_0185, IL_023b, IL_024a, IL_0259, IL_029d, IL_02ac, IL_0317, IL_0376, IL_039b, IL_03a9, IL_0417, IL_04d9, IL_04e8, IL_04f7, IL_0507, IL_05e9, IL_06b4, IL_06e5, IL_06f4, IL_0776, IL_07bd, IL_07dd, IL_0844, IL_098b, IL_09d9, IL_0a86
			int num = 24;
			int num3 = default(int);
			MethodInfo methodInfo = default(MethodInfo);
			Type type = default(Type);
			MethodInfo methodInfo2 = default(MethodInfo);
			MethodInfo[] array = default(MethodInfo[]);
			int num4 = default(int);
			MethodInfo methodInfo3 = default(MethodInfo);
			MethodInfo[] array2 = default(MethodInfo[]);
			string text = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 46:
					case 50:
					case 51:
					case 71:
						num3++;
						num = 36;
						break;
					case 37:
					case 53:
					case 54:
						if (!(methodInfo == null))
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 11;
					case 57:
						if (exprNodeType != ExpressionType.Multiply)
						{
							num2 = 52;
							continue;
						}
						obj = Fn0VLG88qZFRYO4uCytV(0x26FFCB59 ^ 0x26FA17C7);
						goto IL_0abb;
					case 43:
					case 59:
						type = U4TPVi8vg9UgNc6Skdyl(typeof(object).TypeHandle);
						num2 = 14;
						continue;
					case 8:
						switch (exprNodeType)
						{
						case ExpressionType.Modulo:
							goto IL_035c;
						case ExpressionType.Multiply:
							goto IL_08d3;
						case ExpressionType.MultiplyChecked:
							goto IL_0b7a;
						}
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 2;
						}
						continue;
					case 18:
					case 67:
						if (cqpyYd88wuAuE70gaROo(methodInfo, null))
						{
							num2 = 12;
							continue;
						}
						goto case 37;
					case 70:
						return true;
					case 40:
						if (!(otgWhy88e6vv3pdqxkCd(((object[])ld8c6R88DVMhn1v9af95(methodInfo2))[0]) == type))
						{
							num2 = 45;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num2 = 50;
							}
							continue;
						}
						goto case 61;
					case 78:
						return true;
					case 74:
						if (exprNodeType != ExpressionType.Divide)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num2 = 7;
							}
							continue;
						}
						obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138158725);
						goto IL_0abb;
					case 52:
						if (exprNodeType != ExpressionType.MultiplyChecked)
						{
							num2 = 74;
							continue;
						}
						obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E9D026);
						goto IL_0abb;
					case 28:
					case 36:
						if (num3 >= array.Length)
						{
							num2 = 53;
							continue;
						}
						goto case 44;
					case 35:
						return true;
					case 20:
						num3 = 0;
						num2 = 28;
						continue;
					case 33:
						return true;
					case 56:
						if (!R9kTwj88PSmNdg9VwAeW(exprType))
						{
							num2 = 15;
							continue;
						}
						goto IL_0545;
					case 65:
						obj = null;
						goto IL_0abb;
					case 75:
						return true;
					case 16:
					case 31:
					case 49:
						goto IL_03a2;
					case 26:
						switch (exprNodeType)
						{
						case ExpressionType.SubtractAssign:
							break;
						case ExpressionType.AndAssign:
							goto IL_02b9;
						case ExpressionType.OrAssign:
							goto IL_0338;
						case ExpressionType.ModuloAssign:
							goto IL_035c;
						case ExpressionType.PowerAssign:
							goto IL_03a2;
						default:
							goto IL_03f4;
						case ExpressionType.DivideAssign:
							goto IL_065f;
						case ExpressionType.LeftShiftAssign:
							goto IL_0800;
						case ExpressionType.RightShiftAssign:
							goto IL_084b;
						case ExpressionType.MultiplyAssign:
							goto IL_08d3;
						case ExpressionType.AddAssign:
							goto IL_093b;
						case ExpressionType.ExclusiveOrAssign:
							goto IL_09bf;
						case ExpressionType.AddAssignChecked:
							goto IL_0b0d;
						case ExpressionType.SubtractAssignChecked:
							goto IL_0b4e;
						case ExpressionType.MultiplyAssignChecked:
							goto IL_0b7a;
						}
						goto IL_0221;
					case 14:
						array = typeof(string).GetTypeInfo().DeclaredMethods.AsArray();
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 16;
						}
						continue;
					case 2:
						type = U4TPVi8vg9UgNc6Skdyl(typeof(string).TypeHandle);
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 21;
						}
						continue;
					case 62:
						if (exprNodeType != ExpressionType.Subtract)
						{
							num2 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num2 = 11;
							}
							continue;
						}
						obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16416161);
						goto IL_0abb;
					case 55:
						if (methodInfo2.GetParameters().Length == 2)
						{
							num2 = 40;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
							{
								num2 = 25;
							}
							continue;
						}
						goto case 46;
					case 77:
						exprType = Y3ZBnF88oFL48nB4EbDT(exprType);
						num2 = 56;
						continue;
					case 17:
						if (exprNodeType == ExpressionType.SubtractChecked)
						{
							obj = Fn0VLG88qZFRYO4uCytV(0x57A5235E ^ 0x57A0FFE6);
							goto IL_0abb;
						}
						num2 = 57;
						continue;
					case 45:
						num4++;
						num2 = 67;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 25;
						}
						continue;
					case 38:
						return true;
					case 7:
						if (exprNodeType != ExpressionType.Modulo)
						{
							num2 = 65;
							continue;
						}
						obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606933648);
						goto IL_0abb;
					case 42:
						if (fXH2wl8v53gf6fwkZ1cA(exprType, U4TPVi8vg9UgNc6Skdyl(typeof(string).TypeHandle)))
						{
							num = 2;
							break;
						}
						goto case 19;
					case 15:
						methodInfo = null;
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 42;
						}
						continue;
					case 63:
						if (!n6g7oS88aQ3OpAmxEDgB(gsLJHN88pa2A268EfMbs(methodInfo2), Fn0VLG88qZFRYO4uCytV(0x34185E55 ^ 0x34184707)))
						{
							num2 = 46;
							continue;
						}
						goto case 55;
					case 25:
						methodInfo = methodInfo3;
						num = 45;
						break;
					case 61:
						methodInfo = methodInfo2;
						num2 = 37;
						continue;
					case 1:
						methodInfo3 = array2[num4];
						num2 = 72;
						continue;
					case 13:
						if (aiU5Py88bf4bvp4KvZlA(((Expression)HG4E25881F3PGheegRQI(expr)).Type, U4TPVi8vg9UgNc6Skdyl(typeof(string).TypeHandle)))
						{
							num2 = 43;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num2 = 18;
							}
							continue;
						}
						goto case 14;
					case 39:
						return true;
					case 72:
						if (C53Pi688tdxbqC7lWMQv(methodInfo3))
						{
							num2 = 32;
							continue;
						}
						goto case 45;
					case 23:
						if (exprType.IsNullable())
						{
							num2 = 77;
							continue;
						}
						goto case 56;
					case 10:
						if (exprNodeType != ExpressionType.LeftShift)
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto IL_0800;
					case 24:
						if (!R9kTwj88PSmNdg9VwAeW(exprType))
						{
							num2 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 23;
							}
							continue;
						}
						goto IL_0545;
					case 66:
						return true;
					case 9:
						if (n6g7oS88aQ3OpAmxEDgB(gsLJHN88pa2A268EfMbs(methodInfo3), text))
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num2 = 25;
							}
							continue;
						}
						goto case 45;
					case 47:
						switch (exprNodeType)
						{
						case ExpressionType.And:
							break;
						default:
							goto IL_07f4;
						case ExpressionType.Add:
							goto IL_093b;
						case ExpressionType.AddChecked:
							goto IL_0b0d;
						}
						goto IL_02b9;
					case 30:
						return true;
					case 29:
						if (!methodInfo2.IsStatic)
						{
							num = 71;
							break;
						}
						goto case 63;
					case 60:
						return true;
					case 69:
						array2 = ((TypeInfo)GNKm9i8vrhrfeYTW9WQI(exprType)).DeclaredMethods.AsArray();
						num2 = 48;
						continue;
					case 44:
						methodInfo2 = array[num3];
						num2 = 29;
						continue;
					case 76:
						if (exprNodeType != ExpressionType.ExclusiveOr)
						{
							num2 = 31;
							continue;
						}
						goto IL_09bf;
					case 34:
						if (exprNodeType != ExpressionType.Divide)
						{
							num2 = 43;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num2 = 76;
							}
							continue;
						}
						goto IL_065f;
					case 68:
						return true;
					case 64:
					case 79:
						if (exprNodeType > ExpressionType.MultiplyChecked)
						{
							num2 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num2 = 41;
							}
							continue;
						}
						goto case 10;
					default:
						if (exprNodeType == ExpressionType.AddChecked)
						{
							obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E7A752);
							goto IL_0abb;
						}
						num2 = 62;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 60;
						}
						continue;
					case 6:
						goto IL_093b;
					case 32:
						if (methodInfo3.IsStatic)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 45;
					case 48:
						num4 = 0;
						num2 = 18;
						continue;
					case 19:
						if (exprNodeType != 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						obj = Fn0VLG88qZFRYO4uCytV(0x3A5D5EF ^ 0x3A00937);
						goto IL_0abb;
					case 27:
						return true;
					case 5:
					case 41:
						switch (exprNodeType)
						{
						case ExpressionType.Subtract:
							break;
						case ExpressionType.Or:
							goto IL_0338;
						case ExpressionType.OrElse:
						case ExpressionType.Parameter:
						case ExpressionType.Quote:
							goto IL_03a2;
						case ExpressionType.Power:
							goto IL_0726;
						case ExpressionType.RightShift:
							goto IL_084b;
						default:
							goto IL_0a0c;
						case ExpressionType.SubtractChecked:
							goto IL_0b4e;
						}
						goto IL_0221;
					case 21:
						if (XTROpG88NXfDY02TA2TM(HG4E25881F3PGheegRQI(expr)) != XTROpG88NXfDY02TA2TM(vGqfcq883GxgYQw8sWuO(expr)))
						{
							num2 = 59;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 13;
					case 58:
						if (text != null)
						{
							num2 = 67;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num2 = 69;
							}
							continue;
						}
						goto case 37;
					case 12:
						if (num4 >= array2.Length)
						{
							num2 = 54;
							continue;
						}
						goto case 1;
					case 11:
						return false;
					case 4:
						cr9PXh88BxyHDixSqTcC(il, methodInfo.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						num2 = 38;
						continue;
					case 22:
						return true;
					case 3:
						return true;
					case 73:
						{
							return true;
						}
						IL_0b7a:
						pO5qbK8vj7kF4Bx0nVcJ(il, vfkSi3884O8weMQFqJZm(exprType) ? OpCodes.Mul_Ovf_Un : OpCodes.Mul_Ovf);
						num2 = 39;
						continue;
						IL_0abb:
						text = (string)obj;
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 58;
						}
						continue;
						IL_0a0c:
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 7;
						}
						continue;
						IL_0b4e:
						pO5qbK8vj7kF4Bx0nVcJ(il, vfkSi3884O8weMQFqJZm(exprType) ? OpCodes.Sub_Ovf_Un : OpCodes.Sub_Ovf);
						num2 = 68;
						continue;
						IL_0726:
						cr9PXh88BxyHDixSqTcC(il, OpCodes.Call, uoSAA2882sdDqJKDnujY(U4TPVi8vg9UgNc6Skdyl(typeof(Math).TypeHandle), Fn0VLG88qZFRYO4uCytV(0x3A5D5EF ^ 0x3A0091D)));
						num2 = 75;
						continue;
						IL_084b:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Shr);
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 66;
						}
						continue;
						IL_09bf:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Xor);
						num2 = 30;
						continue;
						IL_08d3:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Mul);
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 73;
						}
						continue;
						IL_0800:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Shl);
						num2 = 60;
						continue;
						IL_065f:
						((ILGenerator)il).Emit(OpCodes.Div);
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 33;
						}
						continue;
						IL_03f4:
						num = 49;
						break;
						IL_0338:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Or);
						num2 = 27;
						continue;
						IL_0221:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Sub);
						num2 = 3;
						continue;
						IL_03a2:
						return false;
						IL_0545:
						if (exprNodeType > ExpressionType.ExclusiveOr)
						{
							num2 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num2 = 64;
							}
							continue;
						}
						goto case 47;
						IL_035c:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Rem);
						num2 = 78;
						continue;
						IL_0b0d:
						pO5qbK8vj7kF4Bx0nVcJ(il, vfkSi3884O8weMQFqJZm(exprType) ? OpCodes.Add_Ovf_Un : OpCodes.Add_Ovf);
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 70;
						}
						continue;
						IL_093b:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Add);
						num2 = 22;
						continue;
						IL_07f4:
						num2 = 34;
						continue;
						IL_02b9:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.And);
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 20;
						}
						continue;
					}
					break;
				}
			}
		}

		private static bool TryEmitLogicalOperator(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			if (!TryEmit(((BinaryExpression)expr).Left, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			Label label = ((ILGenerator)il).DefineLabel();
			((ILGenerator)il).Emit((((Expression)expr).NodeType == ExpressionType.AndAlso) ? OpCodes.Brfalse : OpCodes.Brtrue, label);
			if (!TryEmit(((BinaryExpression)expr).Right, paramExprs, il, ref closure, parent))
			{
				return false;
			}
			Label label2 = ((ILGenerator)il).DefineLabel();
			((ILGenerator)il).Emit(OpCodes.Br, label2);
			((ILGenerator)il).MarkLabel(label);
			((ILGenerator)il).Emit((((Expression)expr).NodeType == ExpressionType.AndAlso) ? OpCodes.Ldc_I4_0 : OpCodes.Ldc_I4_1);
			((ILGenerator)il).MarkLabel(label2);
			return true;
		}

		private static bool TryEmitConditional(object expr, IReadOnlyList<ParameterExpression> paramExprs, object il, ref ClosureInfo closure, ParentFlags parent)
		{
			Expression expression = TryReduceCondition(((ConditionalExpression)expr).Test);
			bool flag = false;
			if (expression is BinaryExpression binaryExpression && (binaryExpression.NodeType == ExpressionType.Equal || binaryExpression.NodeType == ExpressionType.NotEqual || (!binaryExpression.Left.Type.IsNullable() && !binaryExpression.Right.Type.IsNullable())))
			{
				if (binaryExpression.Right is ConstantExpression constantExpression && constantExpression.Value == null)
				{
					if (binaryExpression.Left.Type.IsNullable())
					{
						parent |= ParentFlags.MemberAccess;
					}
					flag = TryEmit(binaryExpression.Left, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult);
				}
				else if (binaryExpression.Left is ConstantExpression constantExpression2 && constantExpression2.Value == null)
				{
					if (binaryExpression.Right.Type.IsNullable())
					{
						parent |= ParentFlags.MemberAccess;
					}
					flag = TryEmit(binaryExpression.Right, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult);
				}
			}
			if (!flag && !TryEmit(expression, paramExprs, il, ref closure, parent & ~ParentFlags.IgnoreResult))
			{
				return false;
			}
			Label label = ((ILGenerator)il).DefineLabel();
			((ILGenerator)il).Emit((flag && expression.NodeType == ExpressionType.Equal) ? OpCodes.Brtrue : OpCodes.Brfalse, label);
			if (!TryEmit(((ConditionalExpression)expr).IfTrue, paramExprs, il, ref closure, parent & ParentFlags.IgnoreResult))
			{
				return false;
			}
			Expression ifFalse = ((ConditionalExpression)expr).IfFalse;
			if (ifFalse.NodeType == ExpressionType.Default && ifFalse.Type == typeof(void))
			{
				((ILGenerator)il).MarkLabel(label);
				return true;
			}
			Label label2 = ((ILGenerator)il).DefineLabel();
			((ILGenerator)il).Emit(OpCodes.Br, label2);
			((ILGenerator)il).MarkLabel(label);
			if (!TryEmit(ifFalse, paramExprs, il, ref closure, parent & ParentFlags.IgnoreResult))
			{
				return false;
			}
			((ILGenerator)il).MarkLabel(label2);
			return true;
		}

		private static Expression TryReduceCondition(object testExpr)
		{
			//Discarded unreachable code: IL_00a4, IL_00b4, IL_00be, IL_00cd, IL_0147, IL_0156, IL_0280, IL_028f, IL_029f, IL_0304, IL_0314
			int num = 5;
			bool flag2 = default(bool);
			object obj = default(object);
			BinaryExpression binaryExpression = default(BinaryExpression);
			ConstantExpression constantExpression2 = default(ConstantExpression);
			ConstantExpression constantExpression4 = default(ConstantExpression);
			bool flag3 = default(bool);
			ConstantExpression constantExpression = default(ConstantExpression);
			bool flag4 = default(bool);
			ConstantExpression constantExpression3 = default(ConstantExpression);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 16:
						flag2 = (bool)obj;
						num2 = 18;
						continue;
					case 27:
						num3 = 0;
						goto IL_03c4;
					case 11:
						return (Expression)jLpj7J88AETGFMXf5kR6(HG4E25881F3PGheegRQI(binaryExpression));
					case 3:
						if ((obj = constantExpression2.Value) is bool)
						{
							num2 = 16;
							continue;
						}
						goto case 2;
					case 5:
						if ((binaryExpression = testExpr as BinaryExpression) != null)
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 8;
					case 4:
						if (Y0Yi9m8863JbP6luaq0W(binaryExpression) != ExpressionType.OrElse)
						{
							num2 = 6;
							continue;
						}
						goto case 9;
					case 18:
						if (flag2)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num2 = 0;
							}
							continue;
						}
						return (Expression)HG4E25881F3PGheegRQI(binaryExpression);
					case 9:
						if ((constantExpression4 = HG4E25881F3PGheegRQI(binaryExpression) as ConstantExpression) != null)
						{
							num2 = 7;
							continue;
						}
						goto IL_0395;
					case 7:
						if ((obj = xVh8Zv88HC6mNl7BAaL0(constantExpression4)) is bool)
						{
							num2 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num2 = 21;
							}
							continue;
						}
						goto IL_0395;
					case 15:
						if (Y0Yi9m8863JbP6luaq0W(binaryExpression) == ExpressionType.And)
						{
							num2 = 19;
							continue;
						}
						goto case 8;
					case 1:
						if (flag3)
						{
							num = 8;
							break;
						}
						goto case 11;
					case 17:
						return (Expression)jLpj7J88AETGFMXf5kR6(HG4E25881F3PGheegRQI(binaryExpression));
					case 8:
					case 10:
						return (Expression)testExpr;
					default:
						return (Expression)jLpj7J88AETGFMXf5kR6(binaryExpression.Right);
					case 2:
						if ((constantExpression = binaryExpression.Right as ConstantExpression) == null)
						{
							num = 20;
							break;
						}
						goto case 14;
					case 21:
						flag4 = (bool)obj;
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 22;
						}
						continue;
					case 26:
						if (flag4)
						{
							num2 = 25;
							continue;
						}
						goto case 23;
					case 24:
						flag3 = (bool)obj;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						continue;
					case 14:
						if (!((obj = xVh8Zv88HC6mNl7BAaL0(constantExpression)) is bool))
						{
							num = 27;
							break;
						}
						goto case 13;
					case 22:
						num3 = 1;
						goto IL_03c4;
					case 12:
						if (!((obj = xVh8Zv88HC6mNl7BAaL0(constantExpression3)) is bool))
						{
							num2 = 10;
							continue;
						}
						goto case 24;
					case 6:
						if (Y0Yi9m8863JbP6luaq0W(binaryExpression) != ExpressionType.Or)
						{
							if (Y0Yi9m8863JbP6luaq0W(binaryExpression) != ExpressionType.AndAlso)
							{
								num2 = 15;
								continue;
							}
							goto case 19;
						}
						num2 = 9;
						continue;
					case 13:
						flag = (bool)obj;
						num2 = 22;
						continue;
					case 19:
						if ((constantExpression2 = HG4E25881F3PGheegRQI(binaryExpression) as ConstantExpression) == null)
						{
							num2 = 2;
							continue;
						}
						goto case 3;
					case 23:
						return (Expression)jLpj7J88AETGFMXf5kR6(vGqfcq883GxgYQw8sWuO(binaryExpression));
					case 25:
						return (Expression)HG4E25881F3PGheegRQI(binaryExpression);
					case 20:
						{
							num3 = 0;
							goto IL_03c4;
						}
						IL_03c4:
						if (((uint)num3 & (flag ? 1u : 0u)) != 0)
						{
							num2 = 17;
							continue;
						}
						goto case 8;
						IL_0395:
						if ((constantExpression3 = vGqfcq883GxgYQw8sWuO(binaryExpression) as ConstantExpression) != null)
						{
							num2 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 8;
					}
					break;
				}
			}
		}

		private static bool EmitMethodCall(object il, object method, ParentFlags parent = ParentFlags.Empty)
		{
			//Discarded unreachable code: IL_0043, IL_00a8, IL_00b7
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 7:
					return true;
				case 6:
					if ((parent & ParentFlags.IgnoreResult) != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				case 1:
					if (!(ecKKQm8877KnuCCgvTdn(method) != U4TPVi8vg9UgNc6Skdyl(typeof(void).TypeHandle)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto default;
				default:
					pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Pop);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					if (!cqpyYd88wuAuE70gaROo(method, null))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 2:
					return false;
				case 3:
					cr9PXh88BxyHDixSqTcC(il, wl8EMB88kTNmCG4OyVv6(method) ? OpCodes.Callvirt : OpCodes.Call, method);
					num2 = 6;
					break;
				}
			}
		}

		private static void EmitLoadConstantInt(object il, int i)
		{
			//Discarded unreachable code: IL_00b9, IL_01a6, IL_01ff, IL_020e
			int num = 2;
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
						return;
					case 3:
						return;
					case 7:
						return;
					case 6:
						return;
					case 13:
						H9Mvr888xXRCxpXMtDAi(il, OpCodes.Ldc_I4_S, (sbyte)i);
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 5;
						}
						break;
					case 11:
						return;
					case 4:
						return;
					case 1:
						if (i <= -129)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num2 = 12;
							}
							break;
						}
						goto case 10;
					case 0:
						return;
					case 18:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_M1);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 11;
						}
						break;
					case 2:
						switch (i)
						{
						case 1:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_1);
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num2 = 16;
							}
							goto end_IL_0012;
						case 6:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_6);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num2 = 0;
							}
							goto end_IL_0012;
						case 8:
							goto end_IL_0012_2;
						case 4:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_4);
							num2 = 17;
							goto end_IL_0012;
						case 0:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_0);
							num2 = 14;
							goto end_IL_0012;
						case 7:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_7);
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num2 = 6;
							}
							goto end_IL_0012;
						case -1:
							break;
						default:
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num2 = 1;
							}
							goto end_IL_0012;
						case 3:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_3);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num2 = 6;
							}
							goto end_IL_0012;
						case 5:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_5);
							num2 = 3;
							goto end_IL_0012;
						case 2:
							pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_2);
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
							{
								num2 = 0;
							}
							goto end_IL_0012;
						}
						goto case 18;
					case 10:
						if (i >= 128)
						{
							num2 = 8;
							break;
						}
						goto case 13;
					case 9:
						return;
					case 8:
					case 12:
						SXGK2j880HQ732F9TT4x(il, OpCodes.Ldc_I4, i);
						num2 = 15;
						break;
					case 5:
						return;
					case 17:
						return;
					case 16:
						return;
					case 15:
						return;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_0012_2:
					break;
				}
				pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_8);
				num = 4;
			}
		}

		private static void EmitLoadLocalVariableAddress(object il, int location)
		{
			//Discarded unreachable code: IL_0081
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (location >= 256)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 4:
					((ILGenerator)il).Emit(OpCodes.Ldloca_S, (byte)location);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					((ILGenerator)il).Emit(OpCodes.Ldloca, location);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}

		private static void EmitLoadLocalVariable(object il, int location)
		{
			//Discarded unreachable code: IL_014d, IL_015c
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						return;
					case 6:
						return;
					case 5:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_1);
						num2 = 11;
						continue;
					case 8:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_3);
						num2 = 7;
						continue;
					case 10:
						w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloc_S, (byte)location);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 9;
						}
						continue;
					case 1:
						if (location != 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					case 7:
						return;
					case 12:
						return;
					case 11:
						return;
					case 2:
						((ILGenerator)il).Emit(OpCodes.Ldloc_0);
						num2 = 12;
						continue;
					case 3:
						return;
					case 4:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_2);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					if (location == 1)
					{
						num2 = 5;
					}
					else if (location != 2)
					{
						if (location == 3)
						{
							num2 = 8;
							continue;
						}
						if (location < 256)
						{
							break;
						}
						((ILGenerator)il).Emit(OpCodes.Ldloc, location);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 3;
						}
					}
				}
				num = 10;
			}
		}

		private static void EmitStoreLocalVariable(object il, int location)
		{
			//Discarded unreachable code: IL_008d, IL_009c
			int num = 8;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 7:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_0);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 1;
						}
						break;
					case 2:
						return;
					case 11:
						return;
					case 10:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_1);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 2;
						}
						break;
					case 12:
						return;
					case 5:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_3);
						num2 = 6;
						break;
					case 8:
						if (location == 0)
						{
							goto end_IL_0012;
						}
						if (location != 1)
						{
							if (location == 2)
							{
								num2 = 3;
								break;
							}
							if (location == 3)
							{
								num2 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num2 = 3;
								}
								break;
							}
							if (location >= 256)
							{
								num2 = 9;
								break;
							}
							goto case 4;
						}
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						w0Y04p88mj7xKRBHeHnB(il, OpCodes.Stloc_S, (byte)location);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_2);
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 2;
						}
						break;
					case 0:
						return;
					case 9:
						((ILGenerator)il).Emit(OpCodes.Stloc, location);
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 1;
						}
						break;
					case 6:
						return;
					case 1:
						return;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 7;
			}
		}

		private static int EmitStoreLocalVariableAndLoadItsAddress(object il, Type type)
		{
			//Discarded unreachable code: IL_00ab, IL_00d4, IL_00e3, IL_0119, IL_0128, IL_0138, IL_0147, IL_0157, IL_0195, IL_01a4, IL_02ac, IL_02bb
			int num = 9;
			int nextLocalVarIndex = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						if (nextLocalVarIndex == 3)
						{
							num2 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num2 = 13;
							}
							continue;
						}
						goto case 3;
					case 23:
						w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, 3);
						num = 12;
						break;
					case 3:
						if (nextLocalVarIndex >= 256)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 18;
					case 2:
						w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, 1);
						num = 22;
						break;
					case 16:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_1);
						num2 = 2;
						continue;
					case 7:
						((ILGenerator)il).Emit(OpCodes.Ldloca_S, (byte)0);
						num2 = 19;
						continue;
					case 17:
					case 21:
						if (nextLocalVarIndex == 1)
						{
							num2 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
							{
								num2 = 16;
							}
							continue;
						}
						goto case 25;
					default:
						SXGK2j880HQ732F9TT4x(il, OpCodes.Stloc, nextLocalVarIndex);
						num2 = 4;
						continue;
					case 13:
						((ILGenerator)il).Emit(OpCodes.Stloc_3);
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 18;
						}
						continue;
					case 18:
						((ILGenerator)il).Emit(OpCodes.Stloc_S, (byte)nextLocalVarIndex);
						num2 = 11;
						continue;
					case 8:
						if (nextLocalVarIndex != 0)
						{
							num2 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
							{
								num2 = 21;
							}
							continue;
						}
						goto case 6;
					case 24:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, 2);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 10;
						}
						continue;
					case 9:
						nextLocalVarIndex = ((ILGenerator)il).GetNextLocalVarIndex(type);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 5;
						}
						continue;
					case 10:
					case 12:
					case 15:
					case 19:
					case 20:
					case 22:
						return nextLocalVarIndex;
					case 25:
						if (nextLocalVarIndex == 2)
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num2 = 24;
							}
							continue;
						}
						goto case 5;
					case 11:
						w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, (byte)nextLocalVarIndex);
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 4;
						}
						continue;
					case 4:
						SXGK2j880HQ732F9TT4x(il, OpCodes.Ldloca, nextLocalVarIndex);
						num2 = 20;
						continue;
					case 6:
						pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_0);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				}
			}
		}

		static EmittingVisitor()
		{
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_decimalCtor = new Lazy<ConstructorInfo>(delegate
					{
						//Discarded unreachable code: IL_0033, IL_0042, IL_004d, IL_0078, IL_0087, IL_0118, IL_0150, IL_015f
						int num3 = 2;
						int num4 = num3;
						IEnumerator<ConstructorInfo> enumerator = default(IEnumerator<ConstructorInfo>);
						ConstructorInfo result = default(ConstructorInfo);
						ConstructorInfo current = default(ConstructorInfo);
						while (true)
						{
							switch (num4)
							{
							default:
								return null;
							case 1:
								try
								{
									while (true)
									{
										int num5;
										if (!_003C_003Ec.exjDw8ZOtOVleXT9U3X5(enumerator))
										{
											num5 = 5;
											goto IL_0051;
										}
										goto IL_00b6;
										IL_0051:
										while (true)
										{
											switch (num5)
											{
											case 3:
												return result;
											case 2:
												result = current;
												num5 = 3;
												continue;
											case 1:
												goto IL_00b6;
											case 4:
												if (current.GetParameters().Length == 5)
												{
													num5 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
													{
														num5 = 0;
													}
													continue;
												}
												break;
											case 5:
												goto end_IL_0092;
											}
											break;
										}
										continue;
										IL_00b6:
										current = enumerator.Current;
										num5 = 4;
										goto IL_0051;
										continue;
										end_IL_0092:
										break;
									}
								}
								finally
								{
									if (enumerator != null)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												_003C_003Ec.eit1wvZOwEaG5UfHcZjY(enumerator);
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
												{
													num6 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto default;
							case 2:
								enumerator = typeof(decimal).GetTypeInfo().DeclaredConstructors.GetEnumerator();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num4 = 1;
								}
								break;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 4:
					kuP2yh88ytbBD3rvZgIa();
					num2 = 3;
					break;
				case 3:
					_getTypeFromHandleMethod = GBShgY88Mvw21FLi6O4B(new Func<RuntimeTypeHandle, Type>(Type.GetTypeFromHandle));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					_objectEqualsMethod = GBShgY88Mvw21FLi6O4B(new Func<object, object, bool>(object.Equals));
					num2 = 2;
					break;
				}
			}
		}

		internal static object GNKm9i8vrhrfeYTW9WQI(Type P_0)
		{
			return P_0.GetTypeInfo();
		}

		internal static Type U4TPVi8vg9UgNc6Skdyl(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool fXH2wl8v53gf6fwkZ1cA(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static void pO5qbK8vj7kF4Bx0nVcJ(object P_0, OpCode P_1)
		{
			((ILGenerator)P_0).Emit(P_1);
		}

		internal static void knkv2X8vYB8jrNg6F4Ng(object P_0, OpCode P_1, double P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static int iZFBo28vLdpJZ0EgaTu9(object P_0, Type exprType)
		{
			return InitValueTypeVariable(P_0, exprType);
		}

		internal static bool v09wKt8vdkMs9RK4cdbw()
		{
			return KMULmi8v997Yn3cUEGre == null;
		}

		internal static EmittingVisitor RsWPEa8vljDaDYU1WWXW()
		{
			return (EmittingVisitor)KMULmi8v997Yn3cUEGre;
		}

		internal static void J2osBm8vUaIa3b3WwLmF(object P_0, OpCode P_1, Type P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static bool FmvXlm8vsuRxLNJZHiE0(object P_0, object P_1)
		{
			return IsClosureBoundConstant(P_0, (TypeInfo)P_1);
		}

		internal static void sAHEtL8vcqrjhyn5Thl8(object P_0, int location)
		{
			EmitLoadLocalVariable(P_0, location);
		}

		internal static bool PjFnO38vzkxjGZ63tFdS(Type type)
		{
			return type.IsValueType();
		}

		internal static void UviTP688Flh13scInDsp(object P_0, OpCode P_1, object P_2)
		{
			((ILGenerator)P_0).Emit(P_1, (string)P_2);
		}

		internal static void cr9PXh88BxyHDixSqTcC(object P_0, OpCode P_1, object P_2)
		{
			((ILGenerator)P_0).Emit(P_1, (MethodInfo)P_2);
		}

		internal static bool fokGig88WnZPreE4vi54(object P_0, object P_1, Type constValueType)
		{
			return TryEmitNumberConstant(P_0, P_1, constValueType);
		}

		internal static Type Y3ZBnF88oFL48nB4EbDT(Type P_0)
		{
			return Nullable.GetUnderlyingType(P_0);
		}

		internal static bool aiU5Py88bf4bvp4KvZlA(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static void EeScqP88h5wEXIWJQdtf(object P_0, OpCode P_1, object P_2)
		{
			((ILGenerator)P_0).Emit(P_1, (ConstructorInfo)P_2);
		}

		internal static void xSvlU588GkZCQcYNHxR9(object P_0, int i)
		{
			EmitLoadConstantInt(P_0, i);
		}

		internal static void cM3sss88EePhWUr2IKkE(object P_0, OpCode P_1, long P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static void W7pcad88fNEKh1EdX85b(decimal value, object P_1)
		{
			EmitDecimalConstant(value, P_1);
		}

		internal static void wCQlP088QNaoX0PDRj9h(object P_0, OpCode P_1, float P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static void sRdP0O88C2XPgBIGfmr9(object P_0, OpCode P_1, object P_2)
		{
			((ILGenerator)P_0).Emit(P_1, (FieldInfo)P_2);
		}

		internal static int biffFd88v5EVI03AcKVJ(object P_0, Type t)
		{
			return ((ILGenerator)P_0).GetNextLocalVarIndex(t);
		}

		internal static void n5iKim888ZeKefyA2HBg(object P_0, int location)
		{
			EmitStoreLocalVariable(P_0, location);
		}

		internal static decimal xafoql88ZtB6XHGZK6dR(decimal P_0, decimal P_1)
		{
			return P_0 % P_1;
		}

		internal static bool e7eD7j88uPJ67KFlpEWt(decimal P_0, decimal P_1)
		{
			return P_0 == P_1;
		}

		internal static bool fqmiM488Il8d7HP1lXaU(decimal P_0, decimal P_1)
		{
			return P_0 >= P_1;
		}

		internal static int BQ35wh88VnygI3LvNAkj(decimal P_0)
		{
			return decimal.ToInt32(P_0);
		}

		internal static object w6M2Rh88SoDltf7X7pW3(Type type, Type paramType)
		{
			return type.FindSingleParamConstructor(paramType);
		}

		internal static long oVcLfh88iS6O3DRXOoA1(decimal P_0)
		{
			return decimal.ToInt64(P_0);
		}

		internal static object m3LAa488ReLmpwmaDB7T(object P_0, object P_1)
		{
			return ((TypeInfo)P_0).GetDeclaredField((string)P_1);
		}

		internal static object Fn0VLG88qZFRYO4uCytV(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void zd5dF088K7mOoR6NMGKO(object P_0, int location)
		{
			EmitLoadLocalVariableAddress(P_0, location);
		}

		internal static Type Nc9dVJ88XPZkULo3u0Bi(object P_0)
		{
			return ((MemberInfo)P_0).DeclaringType;
		}

		internal static object fBt6Va88T9YSt8ARF6Or(Type propHolderType, object P_1)
		{
			return propHolderType.FindPropertySetMethod((string)P_1);
		}

		internal static bool wl8EMB88kTNmCG4OyVv6(object P_0)
		{
			return ((MethodBase)P_0).IsVirtual;
		}

		internal static bool deLCCA88neVcu5oRhSLo(object P_0)
		{
			return ((FieldInfo)P_0).IsStatic;
		}

		internal static object JBBhye88OM33sBK79Znn(object P_0)
		{
			return ((IndexExpression)P_0).Indexer;
		}

		internal static object uoSAA2882sdDqJKDnujY(Type type, object P_1)
		{
			return type.FindMethod((string)P_1);
		}

		internal static Type otgWhy88e6vv3pdqxkCd(object P_0)
		{
			return ((ParameterInfo)P_0).ParameterType;
		}

		internal static bool R9kTwj88PSmNdg9VwAeW(Type type)
		{
			return type.IsPrimitive();
		}

		internal static object HG4E25881F3PGheegRQI(object P_0)
		{
			return ((BinaryExpression)P_0).Left;
		}

		internal static Type XTROpG88NXfDY02TA2TM(object P_0)
		{
			return ((Expression)P_0).Type;
		}

		internal static object vGqfcq883GxgYQw8sWuO(object P_0)
		{
			return ((BinaryExpression)P_0).Right;
		}

		internal static object gsLJHN88pa2A268EfMbs(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static bool n6g7oS88aQ3OpAmxEDgB(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object ld8c6R88DVMhn1v9af95(object P_0)
		{
			return ((MethodBase)P_0).GetParameters();
		}

		internal static bool C53Pi688tdxbqC7lWMQv(object P_0)
		{
			return ((MethodBase)P_0).IsSpecialName;
		}

		internal static bool cqpyYd88wuAuE70gaROo(object P_0, object P_1)
		{
			return (MethodInfo)P_0 == (MethodInfo)P_1;
		}

		internal static bool vfkSi3884O8weMQFqJZm(Type type)
		{
			return type.IsUnsigned();
		}

		internal static ExpressionType Y0Yi9m8863JbP6luaq0W(object P_0)
		{
			return ((Expression)P_0).NodeType;
		}

		internal static object xVh8Zv88HC6mNl7BAaL0(object P_0)
		{
			return ((ConstantExpression)P_0).Value;
		}

		internal static object jLpj7J88AETGFMXf5kR6(object P_0)
		{
			return TryReduceCondition(P_0);
		}

		internal static Type ecKKQm8877KnuCCgvTdn(object P_0)
		{
			return ((MethodInfo)P_0).ReturnType;
		}

		internal static void H9Mvr888xXRCxpXMtDAi(object P_0, OpCode P_1, sbyte P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static void SXGK2j880HQ732F9TT4x(object P_0, OpCode P_1, int P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static void w0Y04p88mj7xKRBHeHnB(object P_0, OpCode P_1, byte P_2)
		{
			((ILGenerator)P_0).Emit(P_1, P_2);
		}

		internal static void kuP2yh88ytbBD3rvZgIa()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object GBShgY88Mvw21FLi6O4B(object P_0)
		{
			return ((Delegate)P_0).Method;
		}
	}

	private static readonly Type[] _closureAsASingleParamType;

	private static readonly Type[][] _closureTypePlusParamTypesPool;

	public static readonly ArrayClosure EmptyArrayClosure;

	public static FieldInfo ArrayClosureArrayField;

	public static FieldInfo ArrayClosureWithNonPassedParamsField;

	public static ConstructorInfo ArrayClosureWithNonPassedParamsConstructor;

	internal static ExpressionCompiler CN5P1LGlJTFMqrvxeopG;

	public static TDelegate CompileFast<TDelegate>(this LambdaExpression lambdaExpr, bool ifFastFailedReturnNull = false) where TDelegate : class
	{
		return (TDelegate)(TryCompileBoundToFirstClosureParam((typeof(TDelegate) == typeof(Delegate)) ? lambdaExpr.Type : typeof(TDelegate), lambdaExpr.Body, lambdaExpr.Parameters, GetClosureTypeToParamTypes(lambdaExpr.Parameters), lambdaExpr.ReturnType) ?? (ifFastFailedReturnNull ? null : lambdaExpr.CompileSys()));
	}

	public static bool CompileFastToIL(this LambdaExpression lambdaExpr, ILGenerator il, bool ifFastFailedReturnNull = false)
	{
		//Discarded unreachable code: IL_003e, IL_006c
		int num = 2;
		int num2 = num;
		ClosureInfo closure = default(ClosureInfo);
		ParentFlags parent = default(ParentFlags);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 3:
				num3 = 0;
				break;
			case 1:
				if (lambdaExpr.ReturnType == JkmB0yGllAfHfTkdILLI(typeof(void).TypeHandle))
				{
					num2 = 5;
					continue;
				}
				goto case 3;
			case 6:
				if (!EmittingVisitor.TryEmit(WbynNKGlrTj29YWqJQaj(lambdaExpr), lambdaExpr.Parameters, il, ref closure, parent))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					oYYXJrGlgD1jeK8CT6Df(il, OpCodes.Ret);
					num2 = 4;
				}
				continue;
			case 4:
				return true;
			case 2:
				closure = new ClosureInfo(ClosureStatus.ShouldBeStaticMethod);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				return false;
			case 5:
				num3 = 2;
				break;
			}
			parent = (ParentFlags)num3;
			num2 = 6;
		}
	}

	public static Delegate CompileFast(this LambdaExpression lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					if (ifFastFailedReturnNull)
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					obj = (Delegate)TryCompileBoundToFirstClosureParam(suwSTaGl5Sj3Xtn547vC(lambdaExpr), (Expression)WbynNKGlrTj29YWqJQaj(lambdaExpr), lambdaExpr.Parameters, GetClosureTypeToParamTypes(lambdaExpr.Parameters), SNk1duGlj46D25gVxGVD(lambdaExpr));
					if (obj != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return (Delegate)AUcGUTGlY4agyWHYGUQq(lambdaExpr);
				case 3:
					obj = null;
					break;
				}
				return (Delegate)obj;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static TDelegate CompileSys<TDelegate>(this Expression<TDelegate> lambdaExpr) where TDelegate : class
	{
		return lambdaExpr.Compile();
	}

	public static Delegate CompileSys(this LambdaExpression lambdaExpr)
	{
		return (Delegate)Uj0Tc3GlLQB0qwWS8Fqv(lambdaExpr);
	}

	public static TDelegate CompileFast<TDelegate>(this Expression<TDelegate> lambdaExpr, bool ifFastFailedReturnNull = false) where TDelegate : class
	{
		return ((LambdaExpression)lambdaExpr).CompileFast<TDelegate>(ifFastFailedReturnNull);
	}

	public static Func<R> CompileFast<R>(this Expression<Func<R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<R>)TryCompileBoundToFirstClosureParam(typeof(Func<R>), lambdaExpr.Body, lambdaExpr.Parameters, _closureAsASingleParamType, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<R>)obj;
	}

	public static Func<T1, R> CompileFast<T1, R>(this Expression<Func<T1, R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<T1, R>)TryCompileBoundToFirstClosureParam(typeof(Func<T1, R>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[2]
		{
			typeof(ArrayClosure),
			typeof(T1)
		}, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<T1, R>)obj;
	}

	public static Func<T1, T2, R> CompileFast<T1, T2, R>(this Expression<Func<T1, T2, R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<T1, T2, R>)TryCompileBoundToFirstClosureParam(typeof(Func<T1, T2, R>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[3]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2)
		}, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<T1, T2, R>)obj;
	}

	public static Func<T1, T2, T3, R> CompileFast<T1, T2, T3, R>(this Expression<Func<T1, T2, T3, R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<T1, T2, T3, R>)TryCompileBoundToFirstClosureParam(typeof(Func<T1, T2, T3, R>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[4]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3)
		}, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<T1, T2, T3, R>)obj;
	}

	public static Func<T1, T2, T3, T4, R> CompileFast<T1, T2, T3, T4, R>(this Expression<Func<T1, T2, T3, T4, R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<T1, T2, T3, T4, R>)TryCompileBoundToFirstClosureParam(typeof(Func<T1, T2, T3, T4, R>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[5]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4)
		}, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<T1, T2, T3, T4, R>)obj;
	}

	public static Func<T1, T2, T3, T4, T5, R> CompileFast<T1, T2, T3, T4, T5, R>(this Expression<Func<T1, T2, T3, T4, T5, R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<T1, T2, T3, T4, T5, R>)TryCompileBoundToFirstClosureParam(typeof(Func<T1, T2, T3, T4, T5, R>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[6]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4),
			typeof(T5)
		}, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<T1, T2, T3, T4, T5, R>)obj;
	}

	public static Func<T1, T2, T3, T4, T5, T6, R> CompileFast<T1, T2, T3, T4, T5, T6, R>(this Expression<Func<T1, T2, T3, T4, T5, T6, R>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Func<T1, T2, T3, T4, T5, T6, R>)TryCompileBoundToFirstClosureParam(typeof(Func<T1, T2, T3, T4, T5, T6, R>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[7]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4),
			typeof(T5),
			typeof(T6)
		}, typeof(R));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Func<T1, T2, T3, T4, T5, T6, R>)obj;
	}

	public static Action CompileFast(this Expression<Action> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action)TryCompileBoundToFirstClosureParam(typeof(Action), lambdaExpr.Body, lambdaExpr.Parameters, _closureAsASingleParamType, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action)obj;
	}

	public static Action<T1> CompileFast<T1>(this Expression<Action<T1>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action<T1>)TryCompileBoundToFirstClosureParam(typeof(Action<T1>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[2]
		{
			typeof(ArrayClosure),
			typeof(T1)
		}, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action<T1>)obj;
	}

	public static Action<T1, T2> CompileFast<T1, T2>(this Expression<Action<T1, T2>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action<T1, T2>)TryCompileBoundToFirstClosureParam(typeof(Action<T1, T2>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[3]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2)
		}, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action<T1, T2>)obj;
	}

	public static Action<T1, T2, T3> CompileFast<T1, T2, T3>(this Expression<Action<T1, T2, T3>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action<T1, T2, T3>)TryCompileBoundToFirstClosureParam(typeof(Action<T1, T2, T3>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[4]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3)
		}, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action<T1, T2, T3>)obj;
	}

	public static Action<T1, T2, T3, T4> CompileFast<T1, T2, T3, T4>(this Expression<Action<T1, T2, T3, T4>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action<T1, T2, T3, T4>)TryCompileBoundToFirstClosureParam(typeof(Action<T1, T2, T3, T4>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[5]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4)
		}, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action<T1, T2, T3, T4>)obj;
	}

	public static Action<T1, T2, T3, T4, T5> CompileFast<T1, T2, T3, T4, T5>(this Expression<Action<T1, T2, T3, T4, T5>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action<T1, T2, T3, T4, T5>)TryCompileBoundToFirstClosureParam(typeof(Action<T1, T2, T3, T4, T5>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[6]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4),
			typeof(T5)
		}, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action<T1, T2, T3, T4, T5>)obj;
	}

	public static Action<T1, T2, T3, T4, T5, T6> CompileFast<T1, T2, T3, T4, T5, T6>(this Expression<Action<T1, T2, T3, T4, T5, T6>> lambdaExpr, bool ifFastFailedReturnNull = false)
	{
		object obj = (Action<T1, T2, T3, T4, T5, T6>)TryCompileBoundToFirstClosureParam(typeof(Action<T1, T2, T3, T4, T5, T6>), lambdaExpr.Body, lambdaExpr.Parameters, new Type[7]
		{
			typeof(ArrayClosure),
			typeof(T1),
			typeof(T2),
			typeof(T3),
			typeof(T4),
			typeof(T5),
			typeof(T6)
		}, typeof(void));
		if (obj == null)
		{
			if (!ifFastFailedReturnNull)
			{
				return lambdaExpr.CompileSys();
			}
			obj = null;
		}
		return (Action<T1, T2, T3, T4, T5, T6>)obj;
	}

	public static TDelegate TryCompile<TDelegate>(this LambdaExpression lambdaExpr) where TDelegate : class
	{
		return (TDelegate)TryCompileBoundToFirstClosureParam((typeof(TDelegate) == typeof(Delegate)) ? lambdaExpr.Type : typeof(TDelegate), lambdaExpr.Body, lambdaExpr.Parameters, GetClosureTypeToParamTypes(lambdaExpr.Parameters), lambdaExpr.ReturnType);
	}

	public static TDelegate TryCompileWithPreCreatedClosure<TDelegate>(this LambdaExpression lambdaExpr, params ConstantExpression[] closureConstantsExprs) where TDelegate : class
	{
		object[] array = new object[closureConstantsExprs.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = closureConstantsExprs[i].Value;
		}
		ClosureInfo closure = new ClosureInfo(ClosureStatus.UserProvided | ClosureStatus.HasClosure, array);
		Type[] closureTypeToParamTypes = GetClosureTypeToParamTypes(lambdaExpr.Parameters);
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, lambdaExpr.ReturnType, closureTypeToParamTypes, typeof(ExpressionCompiler), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		EmittingVisitor.EmitLoadConstantsAndNestedLambdasIntoVars(iLGenerator, ref closure);
		ParentFlags parent = ((lambdaExpr.ReturnType == typeof(void)) ? ParentFlags.IgnoreResult : ParentFlags.Empty);
		if (!EmittingVisitor.TryEmit(lambdaExpr.Body, lambdaExpr.Parameters, iLGenerator, ref closure, parent))
		{
			return null;
		}
		iLGenerator.Emit(OpCodes.Ret);
		Type delegateType = ((typeof(TDelegate) != typeof(Delegate)) ? typeof(TDelegate) : lambdaExpr.Type);
		TDelegate result = (TDelegate)(object)dynamicMethod.CreateDelegate(delegateType, new ArrayClosure(array));
		ReturnClosureTypeToParamTypesToPool(closureTypeToParamTypes);
		return result;
	}

	public static TDelegate TryCompileWithoutClosure<TDelegate>(this LambdaExpression lambdaExpr) where TDelegate : class
	{
		ClosureInfo closure = new ClosureInfo(ClosureStatus.UserProvided);
		Type[] closureTypeToParamTypes = GetClosureTypeToParamTypes(lambdaExpr.Parameters);
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, lambdaExpr.ReturnType, closureTypeToParamTypes, typeof(ArrayClosure), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		ParentFlags parent = ((lambdaExpr.ReturnType == typeof(void)) ? ParentFlags.IgnoreResult : ParentFlags.Empty);
		if (!EmittingVisitor.TryEmit(lambdaExpr.Body, lambdaExpr.Parameters, iLGenerator, ref closure, parent))
		{
			return null;
		}
		iLGenerator.Emit(OpCodes.Ret);
		Type delegateType = ((typeof(TDelegate) != typeof(Delegate)) ? typeof(TDelegate) : lambdaExpr.Type);
		TDelegate result = (TDelegate)(object)dynamicMethod.CreateDelegate(delegateType, EmptyArrayClosure);
		ReturnClosureTypeToParamTypesToPool(closureTypeToParamTypes);
		return result;
	}

	[Obsolete("Not used - candidate for removal")]
	public static TDelegate TryCompile<TDelegate>(Expression bodyExpr, IReadOnlyList<ParameterExpression> paramExprs, Type[] paramTypes, Type returnType) where TDelegate : class
	{
		return (TDelegate)TryCompile(typeof(TDelegate), bodyExpr, paramExprs, paramTypes, returnType);
	}

	[Obsolete("Not used - candidate for removal")]
	public static object TryCompile(Type delegateType, Expression bodyExpr, IReadOnlyList<ParameterExpression> paramExprs, Type[] paramTypes, Type returnType)
	{
		return TryCompileBoundToFirstClosureParam((delegateType != typeof(Delegate)) ? delegateType : Tools.GetFuncOrActionType(paramTypes, returnType), bodyExpr, paramExprs, GetClosureTypeToParamTypes(paramExprs), returnType);
	}

	internal static object TryCompileBoundToFirstClosureParam(Type delegateType, Expression bodyExpr, IReadOnlyList<ParameterExpression> paramExprs, Type[] closurePlusParamTypes, Type returnType)
	{
		ClosureInfo closure = new ClosureInfo(ClosureStatus.ToBeCollected);
		if (!TryCollectBoundConstants(ref closure, bodyExpr, paramExprs, isNestedLambda: false, ref closure))
		{
			return null;
		}
		NestedLambdaInfo[] nestedLambdas = closure.NestedLambdas;
		if (nestedLambdas.Length != 0)
		{
			for (int i = 0; i < nestedLambdas.Length; i++)
			{
				if (!TryCompileNestedLambda(ref closure, i))
				{
					return null;
				}
			}
		}
		ArrayClosure arrayClosure = (((closure.Status & ClosureStatus.HasClosure) == 0) ? EmptyArrayClosure : new ArrayClosure(closure.GetArrayOfConstantsAndNestedLambdas()));
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, returnType, closurePlusParamTypes, typeof(ArrayClosure), skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (arrayClosure.ConstantsAndNestedLambdas != null)
		{
			EmittingVisitor.EmitLoadConstantsAndNestedLambdasIntoVars(iLGenerator, ref closure);
		}
		ParentFlags parent = ((returnType == typeof(void)) ? ParentFlags.IgnoreResult : ParentFlags.Empty);
		if (!EmittingVisitor.TryEmit(bodyExpr, paramExprs, iLGenerator, ref closure, parent))
		{
			return null;
		}
		iLGenerator.Emit(OpCodes.Ret);
		Delegate result = dynamicMethod.CreateDelegate(delegateType, arrayClosure);
		ReturnClosureTypeToParamTypesToPool(closurePlusParamTypes);
		return result;
	}

	private static Type[] PrependClosureTypeToParamTypes(IReadOnlyList<ParameterExpression> paramExprs)
	{
		int count = paramExprs.Count;
		Type[] array = new Type[count + 1];
		array[0] = typeof(ArrayClosure);
		for (int i = 0; i < count; i++)
		{
			ParameterExpression parameterExpression = paramExprs[i];
			array[i + 1] = (parameterExpression.IsByRef ? parameterExpression.Type.MakeByRefType() : parameterExpression.Type);
		}
		return array;
	}

	private static Type[] GetClosureTypeToParamTypes(IReadOnlyList<ParameterExpression> paramExprs)
	{
		int count = paramExprs.Count;
		if (count == 0)
		{
			return _closureAsASingleParamType;
		}
		if (count < _closureTypePlusParamTypesPool.Length)
		{
			Type[] array = Interlocked.Exchange(ref _closureTypePlusParamTypesPool[count], null);
			if (array != null)
			{
				for (int i = 0; i < paramExprs.Count; i++)
				{
					ParameterExpression parameterExpression = paramExprs[i];
					array[i + 1] = (parameterExpression.IsByRef ? parameterExpression.Type.MakeByRefType() : parameterExpression.Type);
				}
				return array;
			}
		}
		return PrependClosureTypeToParamTypes(paramExprs);
	}

	private static void ReturnClosureTypeToParamTypesToPool(object closurePlusParamTypes)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_0091
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				if (num3 >= _closureTypePlusParamTypesPool.Length)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 6:
				Interlocked.Exchange(ref _closureTypePlusParamTypesPool[num3], (Type[])closurePlusParamTypes);
				num2 = 5;
				break;
			case 4:
				return;
			case 5:
				return;
			case 1:
				num3 = ((Array)closurePlusParamTypes).Length - 1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 == 0)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public static bool IsClosureBoundConstant(object value, TypeInfo type)
	{
		//Discarded unreachable code: IL_00c6, IL_00d5, IL_00e5
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (type.IsPrimitive)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 3:
					if (!type.IsEnum)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 6:
					return !(value is decimal);
				default:
					return false;
				case 1:
					if (!(value is string))
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 2:
					if (value is Type)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 5:
					if (value is Delegate)
					{
						return true;
					}
					num = 4;
					break;
				}
				break;
			}
		}
	}

	private static bool TryCollectBoundConstants(ref ClosureInfo closure, object expr, IReadOnlyList<ParameterExpression> paramExprs, bool isNestedLambda, ref ClosureInfo rootClosure)
	{
		while (expr != null)
		{
			switch (((Expression)expr).NodeType)
			{
			case ExpressionType.Constant:
			{
				object value = ((ConstantExpression)expr).Value;
				if (value != null && IsClosureBoundConstant(value, value.GetType().GetTypeInfo()))
				{
					closure.AddConstant(value);
				}
				return true;
			}
			case ExpressionType.Quote:
				return false;
			case ExpressionType.Parameter:
			{
				int num2 = paramExprs.Count - 1;
				while (num2 != -1 && paramExprs[num2] != expr)
				{
					num2--;
				}
				if (num2 == -1 && !closure.IsLocalVar(expr))
				{
					if (!isNestedLambda)
					{
						return false;
					}
					closure.AddNonPassedParam((ParameterExpression)expr);
				}
				return true;
			}
			case ExpressionType.Call:
			{
				MethodCallExpression methodCallExpression = (MethodCallExpression)expr;
				Expression @object = methodCallExpression.Object;
				ReadOnlyCollection<Expression> arguments3 = methodCallExpression.Arguments;
				int count = arguments3.Count;
				if (count == 0)
				{
					if (@object != null)
					{
						expr = @object;
						continue;
					}
					return true;
				}
				if (@object != null && !TryCollectBoundConstants(ref closure, methodCallExpression.Object, paramExprs, isNestedLambda, ref rootClosure))
				{
					return false;
				}
				for (int l = 0; l < count - 1; l++)
				{
					if (!TryCollectBoundConstants(ref closure, arguments3[l], paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				expr = arguments3[count - 1];
				continue;
			}
			case ExpressionType.MemberAccess:
			{
				Expression expression = ((MemberExpression)expr).Expression;
				if (expression == null)
				{
					return true;
				}
				expr = expression;
				continue;
			}
			case ExpressionType.New:
			{
				_ = (NewExpression)expr;
				ReadOnlyCollection<Expression> arguments = ((NewExpression)expr).Arguments;
				int num = arguments.Count - 1;
				if (num == -1)
				{
					return true;
				}
				for (int i = 0; i < num; i++)
				{
					if (!TryCollectBoundConstants(ref closure, arguments[i], paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				expr = arguments[num];
				continue;
			}
			case ExpressionType.NewArrayInit:
			case ExpressionType.NewArrayBounds:
			{
				ReadOnlyCollection<Expression> expressions2 = ((NewArrayExpression)expr).Expressions;
				int count2 = expressions2.Count;
				if (count2 == 0)
				{
					return true;
				}
				for (int num3 = 0; num3 < count2 - 1; num3++)
				{
					if (!TryCollectBoundConstants(ref closure, expressions2[num3], paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				expr = expressions2[count2 - 1];
				continue;
			}
			case ExpressionType.MemberInit:
				return TryCollectMemberInitExprConstants(ref closure, (MemberInitExpression)expr, paramExprs, isNestedLambda, ref rootClosure);
			case ExpressionType.Lambda:
			{
				LambdaExpression lambdaExpression = (LambdaExpression)expr;
				NestedLambdaInfo[] nestedLambdas = rootClosure.NestedLambdas;
				if (nestedLambdas.Length != 0)
				{
					NestedLambdaInfo[] foundInLambdas;
					NestedLambdaInfo nestedLambdaInfo = FindAlreadyCollectedNestedLambdaInfo(nestedLambdas, lambdaExpression, out foundInLambdas);
					if (nestedLambdaInfo != null)
					{
						if (foundInLambdas == closure.NestedLambdas)
						{
							nestedLambdaInfo.UsageCountOrVarIndex++;
						}
						else
						{
							closure.AddNestedLambda(nestedLambdaInfo);
							ParameterExpression[] nonPassedParameters = nestedLambdaInfo.ClosureInfo.NonPassedParameters;
							if (nonPassedParameters.Length != 0)
							{
								PropagateNonPassedParamsToOuterLambda(ref closure, paramExprs, lambdaExpression.Parameters, nonPassedParameters);
							}
						}
						return true;
					}
				}
				NestedLambdaInfo nestedLambdaInfo2 = new NestedLambdaInfo(lambdaExpression);
				if (!TryCollectBoundConstants(ref nestedLambdaInfo2.ClosureInfo, lambdaExpression.Body, lambdaExpression.Parameters, isNestedLambda: true, ref rootClosure))
				{
					return false;
				}
				closure.AddNestedLambda(nestedLambdaInfo2);
				ParameterExpression[] nonPassedParameters2 = nestedLambdaInfo2.ClosureInfo.NonPassedParameters;
				if (nonPassedParameters2.Length != 0)
				{
					PropagateNonPassedParamsToOuterLambda(ref closure, paramExprs, lambdaExpression.Parameters, nonPassedParameters2);
				}
				return true;
			}
			case ExpressionType.Invoke:
			{
				InvocationExpression invocationExpression = (InvocationExpression)expr;
				ReadOnlyCollection<Expression> arguments4 = invocationExpression.Arguments;
				int count3 = arguments4.Count;
				if (count3 == 0)
				{
					expr = (invocationExpression.Expression as LambdaExpression)?.Body ?? invocationExpression.Expression;
					continue;
				}
				if (!TryCollectBoundConstants(ref closure, invocationExpression.Expression, paramExprs, isNestedLambda, ref rootClosure))
				{
					return false;
				}
				for (int num4 = 0; num4 < arguments4.Count - 1; num4++)
				{
					if (!TryCollectBoundConstants(ref closure, arguments4[num4], paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				expr = arguments4[count3 - 1];
				continue;
			}
			case ExpressionType.Conditional:
			{
				ConditionalExpression conditionalExpression = (ConditionalExpression)expr;
				if (!TryCollectBoundConstants(ref closure, conditionalExpression.Test, paramExprs, isNestedLambda, ref rootClosure) || !TryCollectBoundConstants(ref closure, conditionalExpression.IfFalse, paramExprs, isNestedLambda, ref rootClosure))
				{
					return false;
				}
				expr = conditionalExpression.IfTrue;
				continue;
			}
			case ExpressionType.Block:
			{
				BlockExpression obj = (BlockExpression)expr;
				ReadOnlyCollection<ParameterExpression> variables = obj.Variables;
				ReadOnlyCollection<Expression> expressions = obj.Expressions;
				if (variables.Count == 0)
				{
					for (int m = 0; m < expressions.Count - 1; m++)
					{
						if (!TryCollectBoundConstants(ref closure, expressions[m], paramExprs, isNestedLambda, ref rootClosure))
						{
							return false;
						}
					}
					expr = expressions[expressions.Count - 1];
					continue;
				}
				if (variables.Count == 1)
				{
					closure.PushBlockWithVars(variables[0]);
				}
				else
				{
					closure.PushBlockWithVars(variables);
				}
				for (int n = 0; n < expressions.Count; n++)
				{
					if (!TryCollectBoundConstants(ref closure, expressions[n], paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				closure.PopBlock();
				return true;
			}
			case ExpressionType.Loop:
			{
				LoopExpression loopExpression = (LoopExpression)expr;
				closure.AddLabel(loopExpression.BreakLabel);
				closure.AddLabel(loopExpression.ContinueLabel);
				expr = loopExpression.Body;
				continue;
			}
			case ExpressionType.Index:
			{
				IndexExpression indexExpression = (IndexExpression)expr;
				ReadOnlyCollection<Expression> arguments2 = indexExpression.Arguments;
				for (int j = 0; j < arguments2.Count; j++)
				{
					if (!TryCollectBoundConstants(ref closure, arguments2[j], paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				if (indexExpression.Object == null)
				{
					return true;
				}
				expr = indexExpression.Object;
				continue;
			}
			case ExpressionType.Try:
				return TryCollectTryExprConstants(ref closure, (TryExpression)expr, paramExprs, isNestedLambda, ref rootClosure);
			case ExpressionType.Label:
			{
				LabelExpression labelExpression = (LabelExpression)expr;
				Expression defaultValue = labelExpression.DefaultValue;
				closure.AddLabel(labelExpression.Target);
				if (defaultValue == null)
				{
					return true;
				}
				expr = defaultValue;
				continue;
			}
			case ExpressionType.Goto:
			{
				GotoExpression gotoExpression = (GotoExpression)expr;
				if (gotoExpression.Kind == GotoExpressionKind.Return)
				{
					closure.MarkAsContainsReturnGotoExpression();
				}
				if (gotoExpression.Value == null)
				{
					return true;
				}
				expr = gotoExpression.Value;
				continue;
			}
			case ExpressionType.Switch:
			{
				SwitchExpression switchExpression = (SwitchExpression)expr;
				if (!TryCollectBoundConstants(ref closure, switchExpression.SwitchValue, paramExprs, isNestedLambda, ref rootClosure) || (switchExpression.DefaultBody != null && !TryCollectBoundConstants(ref closure, switchExpression.DefaultBody, paramExprs, isNestedLambda, ref rootClosure)))
				{
					return false;
				}
				ReadOnlyCollection<SwitchCase> cases = switchExpression.Cases;
				for (int k = 0; k < cases.Count - 1; k++)
				{
					if (!TryCollectBoundConstants(ref closure, cases[k].Body, paramExprs, isNestedLambda, ref rootClosure))
					{
						return false;
					}
				}
				expr = cases[cases.Count - 1].Body;
				continue;
			}
			case ExpressionType.Extension:
				expr = ((Expression)expr).Reduce();
				continue;
			case ExpressionType.Default:
				return true;
			}
			if (expr is UnaryExpression unaryExpression)
			{
				expr = unaryExpression.Operand;
			}
			else if (expr is BinaryExpression binaryExpression)
			{
				if (!TryCollectBoundConstants(ref closure, binaryExpression.Left, paramExprs, isNestedLambda, ref rootClosure))
				{
					return false;
				}
				expr = binaryExpression.Right;
			}
			else
			{
				if (!(expr is TypeBinaryExpression typeBinaryExpression))
				{
					return false;
				}
				expr = typeBinaryExpression.Expression;
			}
		}
		return false;
	}

	private static void PropagateNonPassedParamsToOuterLambda(ref ClosureInfo closure, IReadOnlyList<ParameterExpression> paramExprs, IReadOnlyList<ParameterExpression> nestedLambdaParamExprs, object nestedNonPassedParams)
	{
		for (int i = 0; i < ((Array)nestedNonPassedParams).Length; i++)
		{
			ParameterExpression parameterExpression = (ParameterExpression)((object[])nestedNonPassedParams)[i];
			bool flag = false;
			if (nestedLambdaParamExprs.Count != 0)
			{
				int num = 0;
				while (!flag && num < nestedLambdaParamExprs.Count)
				{
					flag = nestedLambdaParamExprs[num] == parameterExpression;
					num++;
				}
			}
			bool flag2 = false;
			if (paramExprs.Count != 0)
			{
				int num2 = 0;
				while (!flag2 && num2 < paramExprs.Count)
				{
					flag2 = paramExprs[num2] == parameterExpression;
					num2++;
				}
			}
			if (!flag && !flag2)
			{
				closure.AddNonPassedParam(parameterExpression);
			}
		}
	}

	private static NestedLambdaInfo FindAlreadyCollectedNestedLambdaInfo(object nestedLambdas, object nestedLambdaExpr, out NestedLambdaInfo[] foundInLambdas)
	{
		//Discarded unreachable code: IL_00e4, IL_0155
		int num = 10;
		NestedLambdaInfo[] nestedLambdas2 = default(NestedLambdaInfo[]);
		NestedLambdaInfo nestedLambdaInfo = default(NestedLambdaInfo);
		NestedLambdaInfo nestedLambdaInfo2 = default(NestedLambdaInfo);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (nestedLambdas2.Length != 0)
					{
						num2 = 8;
						break;
					}
					goto IL_0086;
				case 13:
					foundInLambdas = (NestedLambdaInfo[])nestedLambdas;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return nestedLambdaInfo;
				default:
					return nestedLambdaInfo2;
				case 12:
					foundInLambdas = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 3;
					}
					break;
				case 10:
					num3 = 0;
					num2 = 9;
					break;
				case 6:
				case 9:
					if (num3 < ((Array)nestedLambdas).Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 12;
				case 8:
					nestedLambdaInfo = FindAlreadyCollectedNestedLambdaInfo(nestedLambdas2, nestedLambdaExpr, out foundInLambdas);
					num2 = 7;
					break;
				case 3:
					return null;
				case 1:
				case 4:
					nestedLambdaInfo2 = (NestedLambdaInfo)((object[])nestedLambdas)[num3];
					num2 = 5;
					break;
				case 5:
					if (nestedLambdaInfo2.LambdaExpression != nestedLambdaExpr)
					{
						goto end_IL_0012;
					}
					num2 = 13;
					break;
				case 7:
					{
						if (nestedLambdaInfo != null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto IL_0086;
					}
					IL_0086:
					num3++;
					num2 = 6;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			nestedLambdas2 = nestedLambdaInfo2.ClosureInfo.NestedLambdas;
			num = 11;
		}
	}

	private static bool TryCompileNestedLambda(ref ClosureInfo outerClosureInfo, int nestedLambdaIndex)
	{
		//Discarded unreachable code: IL_00c2, IL_00cc, IL_00db, IL_00ea, IL_014a, IL_0159, IL_0169, IL_0178, IL_028d, IL_02f2, IL_0301, IL_036e, IL_037d, IL_0425, IL_0434, IL_04a3
		int num = 37;
		NestedLambdaInfo nestedLambdaInfo = default(NestedLambdaInfo);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		LambdaExpression lambdaExpression = default(LambdaExpression);
		ArrayClosure arrayClosure = default(ArrayClosure);
		ReadOnlyCollection<ParameterExpression> parameters = default(ReadOnlyCollection<ParameterExpression>);
		ref ClosureInfo closureInfo = default(ref ClosureInfo);
		NestedLambdaInfo[] nestedLambdas = default(NestedLambdaInfo[]);
		Type type = default(Type);
		ILGenerator iLGenerator = default(ILGenerator);
		ParentFlags parent = default(ParentFlags);
		int num4 = default(int);
		Type[] closureTypeToParamTypes = default(Type[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 23:
					num3 = 0;
					break;
				case 30:
					nestedLambdaInfo.Lambda = VUchioGlsMVMhBVbeM0b(dynamicMethod, suwSTaGl5Sj3Xtn547vC(lambdaExpression), arrayClosure);
					num2 = 18;
					continue;
				case 29:
					parameters = lambdaExpression.Parameters;
					num2 = 13;
					continue;
				case 6:
					if ((closureInfo.Status & ClosureStatus.HasClosure) == 0)
					{
						goto end_IL_0012;
					}
					goto case 32;
				case 12:
					if (nestedLambdas.Length != 0)
					{
						num2 = 26;
						continue;
					}
					goto case 34;
				case 9:
					if (TIEdetGlUCPNlyvbTK1j(type, JkmB0yGllAfHfTkdILLI(typeof(void).TypeHandle)))
					{
						num2 = 33;
						continue;
					}
					goto case 23;
				case 36:
					if (nestedLambdaInfo.Lambda == null)
					{
						num2 = 14;
						continue;
					}
					goto case 1;
				case 28:
					if (!EmittingVisitor.TryEmit(WbynNKGlrTj29YWqJQaj(lambdaExpression), parameters, iLGenerator, ref closureInfo, parent))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						oYYXJrGlgD1jeK8CT6Df(iLGenerator, OpCodes.Ret);
						num2 = 31;
					}
					continue;
				case 1:
					return true;
				case 14:
					lambdaExpression = (LambdaExpression)nestedLambdaInfo.LambdaExpression;
					num2 = 27;
					continue;
				case 38:
					return false;
				default:
					num4++;
					num2 = 15;
					continue;
				case 37:
					nestedLambdaInfo = outerClosureInfo.NestedLambdas[nestedLambdaIndex];
					num2 = 36;
					continue;
				case 3:
				case 19:
					if (TryCompileNestedLambda(ref closureInfo, num4))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 38;
				case 20:
					iLGenerator = dynamicMethod.GetILGenerator();
					num2 = 21;
					continue;
				case 5:
					closureTypeToParamTypes = GetClosureTypeToParamTypes(parameters);
					num2 = 35;
					continue;
				case 18:
				case 22:
					V1cnsXGlzsIBMCcn7h0d(closureTypeToParamTypes);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 4;
					}
					continue;
				case 27:
					closureInfo = ref nestedLambdaInfo.ClosureInfo;
					num2 = 29;
					continue;
				case 34:
					arrayClosure = null;
					num2 = 7;
					continue;
				case 31:
					if (arrayClosure == null)
					{
						num2 = 16;
						continue;
					}
					goto case 30;
				case 35:
					dynamicMethod = new DynamicMethod(string.Empty, type, closureTypeToParamTypes, typeof(ArrayClosure), skipVisibility: true);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					arrayClosure = EmptyArrayClosure;
					num2 = 10;
					continue;
				case 7:
					if (closureInfo.NonPassedParameters.Length != 0)
					{
						num2 = 17;
						continue;
					}
					goto case 6;
				case 25:
					EmittingVisitor.EmitLoadConstantsAndNestedLambdasIntoVars(iLGenerator, ref closureInfo);
					num2 = 9;
					continue;
				case 8:
				case 10:
				case 17:
					type = SNk1duGlj46D25gVxGVD(lambdaExpression);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 4;
					}
					continue;
				case 15:
				case 24:
					if (num4 < nestedLambdas.Length)
					{
						num2 = 3;
						continue;
					}
					goto case 34;
				case 21:
					if ((closureInfo.Status & ClosureStatus.HasClosure) != 0)
					{
						num2 = 25;
						continue;
					}
					goto case 9;
				case 32:
					arrayClosure = new ArrayClosure(closureInfo.GetArrayOfConstantsAndNestedLambdas());
					num2 = 8;
					continue;
				case 26:
					num4 = 0;
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
				case 39:
					nestedLambdaInfo.Lambda = dynamicMethod.CreateDelegate(CIK6yQGlc3HZ1kSGyZ0k(closureTypeToParamTypes, type), null);
					num2 = 22;
					continue;
				case 4:
					return true;
				case 13:
					nestedLambdas = closureInfo.NestedLambdas;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 12;
					}
					continue;
				case 2:
					return false;
				case 33:
					num3 = 2;
					break;
				}
				parent = (ParentFlags)num3;
				num2 = 28;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	private static bool TryCollectMemberInitExprConstants(ref ClosureInfo closure, object expr, IReadOnlyList<ParameterExpression> paramExprs, bool isNestedLambda, ref ClosureInfo rootClosure)
	{
		NewExpression newExpression = ((MemberInitExpression)expr).NewExpression;
		if (!TryCollectBoundConstants(ref closure, newExpression, paramExprs, isNestedLambda, ref rootClosure))
		{
			return false;
		}
		ReadOnlyCollection<MemberBinding> bindings = ((MemberInitExpression)expr).Bindings;
		for (int i = 0; i < bindings.Count; i++)
		{
			MemberBinding memberBinding = bindings[i];
			if (memberBinding.BindingType == MemberBindingType.Assignment && !TryCollectBoundConstants(ref closure, ((MemberAssignment)memberBinding).Expression, paramExprs, isNestedLambda, ref rootClosure))
			{
				return false;
			}
		}
		return true;
	}

	private static bool TryCollectTryExprConstants(ref ClosureInfo closure, object tryExpr, IReadOnlyList<ParameterExpression> paramExprs, bool isNestedLambda, ref ClosureInfo rootClosure)
	{
		closure.AddTryCatchFinallyInfo();
		if (!TryCollectBoundConstants(ref closure, ((TryExpression)tryExpr).Body, paramExprs, isNestedLambda, ref rootClosure))
		{
			return false;
		}
		ReadOnlyCollection<CatchBlock> handlers = ((TryExpression)tryExpr).Handlers;
		for (int i = 0; i < handlers.Count; i++)
		{
			CatchBlock catchBlock = handlers[i];
			ParameterExpression variable = catchBlock.Variable;
			if (variable != null)
			{
				closure.PushBlockWithVars(variable);
				if (!TryCollectBoundConstants(ref closure, variable, paramExprs, isNestedLambda, ref rootClosure))
				{
					return false;
				}
			}
			if (catchBlock.Filter != null && !TryCollectBoundConstants(ref closure, catchBlock.Filter, paramExprs, isNestedLambda, ref rootClosure))
			{
				return false;
			}
			if (!TryCollectBoundConstants(ref closure, catchBlock.Body, paramExprs, isNestedLambda, ref rootClosure))
			{
				return false;
			}
			if (variable != null)
			{
				closure.PopBlock();
			}
		}
		if (((TryExpression)tryExpr).Finally != null && !TryCollectBoundConstants(ref closure, ((TryExpression)tryExpr).Finally, paramExprs, isNestedLambda, ref rootClosure))
		{
			return false;
		}
		closure.CurrentTryCatchFinallyIndex--;
		return true;
	}

	internal static bool IgnoresResult(this ParentFlags parent)
	{
		return (parent & ParentFlags.IgnoreResult) != 0;
	}

	static ExpressionCompiler()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 1:
				_closureAsASingleParamType = new Type[1] { JkmB0yGllAfHfTkdILLI(typeof(ArrayClosure).TypeHandle) };
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				EmptyArrayClosure = new ArrayClosure(null);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 5;
				}
				break;
			default:
				_closureTypePlusParamTypesPool = new Type[8][];
				num2 = 4;
				break;
			case 5:
				ArrayClosureWithNonPassedParamsField = ((TypeInfo)RUnPnOGrBm5dO31UT9WK(JkmB0yGllAfHfTkdILLI(typeof(ArrayClosureWithNonPassedParams).TypeHandle))).GetDeclaredField((string)lcDfKhGro1Jpx3ARkfWp(0x638095EB ^ 0x63848503));
				num2 = 3;
				break;
			case 7:
				ArrayClosureArrayField = (FieldInfo)aJBMSUGrWdcGC9dFKsPr(RUnPnOGrBm5dO31UT9WK(JkmB0yGllAfHfTkdILLI(typeof(ArrayClosure).TypeHandle)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398921234));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				cSn8ASGrFr0ZgSE1Gu9t();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				ArrayClosureWithNonPassedParamsConstructor = JkmB0yGllAfHfTkdILLI(typeof(ArrayClosureWithNonPassedParams).TypeHandle).GetTypeInfo().DeclaredConstructors.GetFirst();
				num2 = 6;
				break;
			}
		}
	}

	internal static Type JkmB0yGllAfHfTkdILLI(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object WbynNKGlrTj29YWqJQaj(object P_0)
	{
		return ((LambdaExpression)P_0).Body;
	}

	internal static void oYYXJrGlgD1jeK8CT6Df(object P_0, OpCode P_1)
	{
		((ILGenerator)P_0).Emit(P_1);
	}

	internal static bool naCC8JGl99t669pq4DhV()
	{
		return CN5P1LGlJTFMqrvxeopG == null;
	}

	internal static ExpressionCompiler EP97QHGld3fjQ02buIP6()
	{
		return CN5P1LGlJTFMqrvxeopG;
	}

	internal static Type suwSTaGl5Sj3Xtn547vC(object P_0)
	{
		return ((Expression)P_0).Type;
	}

	internal static Type SNk1duGlj46D25gVxGVD(object P_0)
	{
		return ((LambdaExpression)P_0).ReturnType;
	}

	internal static object AUcGUTGlY4agyWHYGUQq(object P_0)
	{
		return ((LambdaExpression)P_0).CompileSys();
	}

	internal static object Uj0Tc3GlLQB0qwWS8Fqv(object P_0)
	{
		return ((LambdaExpression)P_0).Compile();
	}

	internal static bool TIEdetGlUCPNlyvbTK1j(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object VUchioGlsMVMhBVbeM0b(object P_0, Type P_1, object P_2)
	{
		return ((MethodInfo)P_0).CreateDelegate(P_1, P_2);
	}

	internal static Type CIK6yQGlc3HZ1kSGyZ0k(object P_0, Type returnType)
	{
		return Tools.GetFuncOrActionType((Type[])P_0, returnType);
	}

	internal static void V1cnsXGlzsIBMCcn7h0d(object P_0)
	{
		ReturnClosureTypeToParamTypesToPool(P_0);
	}

	internal static void cSn8ASGrFr0ZgSE1Gu9t()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object RUnPnOGrBm5dO31UT9WK(Type P_0)
	{
		return P_0.GetTypeInfo();
	}

	internal static object aJBMSUGrWdcGC9dFKsPr(object P_0, object P_1)
	{
		return ((TypeInfo)P_0).GetDeclaredField((string)P_1);
	}

	internal static object lcDfKhGro1Jpx3ARkfWp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
