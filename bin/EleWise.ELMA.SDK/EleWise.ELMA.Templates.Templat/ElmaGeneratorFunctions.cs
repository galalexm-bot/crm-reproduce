using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Functions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public static class ElmaGeneratorFunctions
{
	private static ElmaGeneratorFunctions KZ5ObCBp2lGoqtgSyNrt;

	public static FormatedValue SR(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_00ed, IL_0128, IL_015a, IL_0171, IL_0180, IL_018f, IL_01b5
		int num = 5;
		FormatedValue formatedValue = default(FormatedValue);
		object[] parameters = default(object[]);
		string text = default(string);
		int count = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 9:
					return new FormatedValue(EleWise.ELMA.SR.T((string)KVVGXYBp1csg86lbFVe8(formatedValue), parameters));
				case 10:
					text = (string)formatedValue.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (!(KVVGXYBp1csg86lbFVe8(formatedValue) is string))
					{
						num2 = 11;
						continue;
					}
					if (count <= 1)
					{
						num2 = 10;
						continue;
					}
					break;
				case 5:
					count = context.Parameters.Count;
					num2 = 4;
					continue;
				case 8:
					return new FormatedValue(okFppHBpp7AeS2Itep5L(text));
				case 6:
					if (formatedValue.Value != null)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				default:
					try
					{
						text = (string)TTH9i4Bp3Npudo2d9fo4(new TextTemplateGenerator(text), xslOBABpNhsQmRav1DTD(context));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 8;
				case 12:
					if (formatedValue == null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 1:
					obj = null;
					goto IL_01fd;
				case 4:
					if (count <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj = context.Parameters[0];
					goto IL_01fd;
				case 2:
				case 11:
					return formatedValue;
				case 7:
					break;
					IL_01fd:
					formatedValue = (FormatedValue)obj;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				parameters = context.Parameters.GetRange(1, count - 1).Select(delegate(FormatedValue p)
				{
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return null;
						case 1:
							if (p != null)
							{
								return _003C_003Ec.FoC3hxQKOZvyVQyvs8HO(p);
							}
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num6 = 0;
							}
							break;
						}
					}
				}).ToArray();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 9;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public static FormatedValue GetListItem(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_007c, IL_008b, IL_00d0, IL_00df, IL_00ef, IL_00fe, IL_01ac, IL_01bb, IL_01f1, IL_025c, IL_026b, IL_0276, IL_02a5, IL_02b4, IL_0357, IL_03b4
		int num = 18;
		int num2 = num;
		FormatedValue formatedValue2 = default(FormatedValue);
		int result2 = default(int);
		FormatedValue formatedValue = default(FormatedValue);
		int num4 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		FormatedValue result = default(FormatedValue);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return null;
			case 2:
			case 4:
			case 5:
			case 7:
			case 15:
				return null;
			case 11:
				if (formatedValue2 == null)
				{
					num2 = 2;
					break;
				}
				goto default;
			default:
				if (KVVGXYBp1csg86lbFVe8(formatedValue2) != null)
				{
					if (!int.TryParse(KVVGXYBp1csg86lbFVe8(formatedValue2).ToString(), out result2))
					{
						num2 = 16;
					}
					else if (hI1T2uBpDxmyYdXv6GtT((ICollection)formatedValue.Value) > result2)
					{
						num4 = 0;
						num2 = 3;
					}
					else
					{
						num2 = 10;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			case 1:
				return null;
			case 17:
				formatedValue = context.Parameters[0];
				num2 = 8;
				break;
			case 6:
				return null;
			case 3:
				enumerator = ((ICollection)KVVGXYBp1csg86lbFVe8(formatedValue)).GetEnumerator();
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 11;
				}
				break;
			case 16:
				return null;
			case 8:
				formatedValue2 = context.Parameters[1];
				num2 = 13;
				break;
			case 12:
				if (KVVGXYBp1csg86lbFVe8(formatedValue) == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 9:
				if (!(KVVGXYBp1csg86lbFVe8(formatedValue) is ICollection))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 11;
			case 18:
				if (goby3jBpa6vMhTPKAbVQ(context.Parameters) >= 2)
				{
					num2 = 17;
					break;
				}
				goto case 1;
			case 13:
				if (formatedValue == null)
				{
					num2 = 15;
					break;
				}
				goto case 12;
			case 14:
				try
				{
					while (true)
					{
						IL_0315:
						int num3;
						if (!gDJmtGBpw8xGL1nJtw95(enumerator))
						{
							num3 = 4;
							goto IL_027a;
						}
						goto IL_02df;
						IL_027a:
						while (true)
						{
							switch (num3)
							{
							case 5:
								return result;
							default:
								num4++;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								break;
							case 2:
								if (num4 == result2)
								{
									num3 = 6;
									continue;
								}
								goto default;
							case 1:
								goto IL_0315;
							case 6:
								result = new FormatedValue(value);
								num3 = 5;
								continue;
							case 4:
								goto end_IL_0315;
							}
							break;
						}
						goto IL_02df;
						IL_02df:
						value = qfEafeBptNbQK7MMaWoD(enumerator);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num3 = 0;
						}
						goto IL_027a;
						continue;
						end_IL_0315:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						case 1:
							ATZIgoBp4kJFYmSmOIeV(disposable);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
							{
								num5 = 0;
							}
							continue;
						case 2:
							if (disposable != null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num5 = 1;
								}
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 6;
			}
		}
	}

	public static FormatedValue SubString(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_00de, IL_00ed, IL_00fc, IL_01a4, IL_01e3, IL_01f2, IL_024b, IL_02e8, IL_02f7, IL_0322, IL_035a
		int num = 17;
		FormatedValue formatedValue3 = default(FormatedValue);
		FormatedValue result = default(FormatedValue);
		FormatedValue formatedValue = default(FormatedValue);
		FormatedValue formatedValue2 = default(FormatedValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (KVVGXYBp1csg86lbFVe8(formatedValue3) is int)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 14;
				case 3:
					if (KVVGXYBp1csg86lbFVe8(formatedValue3) == null)
					{
						num2 = 14;
						continue;
					}
					goto case 11;
				case 9:
					if (formatedValue3 == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 3;
				case 20:
					return result;
				case 16:
					formatedValue3 = context.Parameters[1];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					if (KVVGXYBp1csg86lbFVe8(formatedValue) != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 12;
				case 6:
					if (formatedValue2.Value == null)
					{
						num = 18;
						break;
					}
					goto case 13;
				case 14:
				case 15:
				case 18:
				case 19:
				case 21:
					return null;
				case 8:
					formatedValue = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					return null;
				case 17:
					formatedValue2 = context.Parameters[0];
					num2 = 16;
					continue;
				default:
					formatedValue = context.Parameters[2];
					num2 = 4;
					continue;
				case 7:
					if (!(KVVGXYBp1csg86lbFVe8(formatedValue) is int))
					{
						num2 = 12;
						continue;
					}
					goto IL_0190;
				case 1:
					if (formatedValue2 != null)
					{
						num2 = 6;
						continue;
					}
					goto case 14;
				case 4:
					if (formatedValue != null)
					{
						num2 = 10;
						continue;
					}
					goto case 12;
				case 5:
					try
					{
						int num3;
						if (formatedValue != null)
						{
							num3 = 2;
							goto IL_024f;
						}
						goto IL_0269;
						IL_024f:
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 3:
								return result;
							case 1:
								break;
							case 2:
								result = new FormatedValue(R7qvcqBp6yBan1oM68Hq((string)KVVGXYBp1csg86lbFVe8(formatedValue2), (int)KVVGXYBp1csg86lbFVe8(formatedValue3), (int)formatedValue.Value));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_0269;
						IL_0269:
						result = new FormatedValue(((string)formatedValue2.Value).Substring((int)KVVGXYBp1csg86lbFVe8(formatedValue3)));
						num3 = 3;
						goto IL_024f;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return result;
							}
							result = null;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num4 = 0;
							}
						}
					}
				case 13:
					if (!(formatedValue2.Value is string))
					{
						num2 = 19;
						continue;
					}
					goto case 9;
				case 2:
					{
						if (context.Parameters.Count == 3)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_0190;
					}
					IL_0190:
					num = 5;
					break;
				}
				break;
			}
		}
	}

	public static FormatedValue IsBaseObjectType(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_00dd, IL_0110, IL_0166, IL_0175
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (goby3jBpa6vMhTPKAbVQ(context.Parameters) != 2)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					flag = false;
					num2 = 3;
				}
				break;
			case 2:
				return new FormatedValue(flag);
			default:
				return null;
			case 3:
				try
				{
					Guid uid = YnUlVxBpHLGF3wQCokC7(KVVGXYBp1csg86lbFVe8(context.Parameters[0]).ToString());
					Guid uid2 = YnUlVxBpHLGF3wQCokC7(context.Parameters[1].Value.ToString());
					flag = MetadataLoader.IsBaseClass(uid, (ClassMetadata)MetadataLoader.LoadMetadata(uid2));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							wbGMllBpxJF5KmmAEQJX(rhcB2KBpAfpfkE1mBEwQ(), EleWise.ELMA.SR.T((string)XXoytnBp7Bh8QdHksNFg(-87337865 ^ -87420831)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 2;
			}
		}
	}

	public static FormatedValue FormatDateTime(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0045, IL_0093, IL_00a2
		int num = 5;
		int num2 = num;
		DateTime result = default(DateTime);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
			case 7:
				return new FormatedValue(result.ToString((string)context.Parameters[1].Value));
			case 4:
				if (context.Parameters[0] != null)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 6:
				if (context.Parameters[1] != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				result = DateTime.MinValue;
				num2 = 7;
				break;
			case 5:
				if (goby3jBpa6vMhTPKAbVQ(context.Parameters) >= 2)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 3:
				return null;
			default:
				obj = context.Parameters[0].Value;
				if (obj != null)
				{
					goto IL_0142;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				{
					obj = "";
					goto IL_0142;
				}
				IL_0142:
				if (DateTime.TryParse(obj.ToString(), out result))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static FormatedValue Caption(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00a9, IL_00b8, IL_00c8
		int num = 1;
		int num2 = num;
		MetadataBasedFormat metadataBasedFormat = default(MetadataBasedFormat);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 4:
				metadataBasedFormat = context.Parameters[0].Format as MetadataBasedFormat;
				num2 = 8;
				break;
			case 8:
				if (metadataBasedFormat != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 7:
				if (metadataBasedFormat.PropertyMetadata != null)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 1:
				if (context.Parameters.Count < 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				if (context.Parameters[0] != null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 6:
				return null;
			case 3:
				return new FormatedValue(NoHx1eBpm8j0cNtvcEBU(xA7eYCBp0utyoObtOd8k(metadataBasedFormat)));
			}
		}
	}

	internal static object KVVGXYBp1csg86lbFVe8(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object xslOBABpNhsQmRav1DTD(object P_0)
	{
		return ((FunctionEvaluationContext)P_0).DataSource;
	}

	internal static object TTH9i4Bp3Npudo2d9fo4(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate((IGeneratorDataSource)P_1);
	}

	internal static object okFppHBpp7AeS2Itep5L(object P_0)
	{
		return EleWise.ELMA.SR.T((string)P_0);
	}

	internal static bool Vtp866BpeKQaIalfFLr3()
	{
		return KZ5ObCBp2lGoqtgSyNrt == null;
	}

	internal static ElmaGeneratorFunctions Xoil0sBpPNbuppknU02p()
	{
		return KZ5ObCBp2lGoqtgSyNrt;
	}

	internal static int goby3jBpa6vMhTPKAbVQ(object P_0)
	{
		return ((List<FormatedValue>)P_0).Count;
	}

	internal static int hI1T2uBpDxmyYdXv6GtT(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static object qfEafeBptNbQK7MMaWoD(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool gDJmtGBpw8xGL1nJtw95(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void ATZIgoBp4kJFYmSmOIeV(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object R7qvcqBp6yBan1oM68Hq(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static Guid YnUlVxBpHLGF3wQCokC7(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static object rhcB2KBpAfpfkE1mBEwQ()
	{
		return Logger.Log;
	}

	internal static object XXoytnBp7Bh8QdHksNFg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void wbGMllBpxJF5KmmAEQJX(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object xA7eYCBp0utyoObtOd8k(object P_0)
	{
		return ((MetadataBasedFormat)P_0).PropertyMetadata;
	}

	internal static object NoHx1eBpm8j0cNtvcEBU(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}
}
