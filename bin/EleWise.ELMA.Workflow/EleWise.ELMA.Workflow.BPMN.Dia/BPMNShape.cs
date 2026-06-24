#define TRACE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
public abstract class BPMNShape : NCompositeShape, IBorderDecoratable, IDecoratableShape
{
	internal static BPMNShape LEZmKqOiEUtecYmHe3PS;

	public BPMNShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U0mZEBOizZGfWotsf4Xh();
		((NCompositeShape)this)._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				UpdateDecorators(null);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				((NShape)this).CreateShapeElements((ShapeElementsMask)8);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AddDecorator<TDecorator>(DecoratorPosition position = DecoratorPosition.Center) where TDecorator : BaseDecorator, new()
	{
		AddDecorator(typeof(TDecorator), position);
	}

	public void AddDecorator(Type decoratorType, DecoratorPosition position = DecoratorPosition.Center)
	{
		//Discarded unreachable code: IL_0067, IL_009c, IL_00ab, IL_00bb, IL_00ca, IL_0138, IL_0185, IL_0194
		int num = 2;
		BaseDecorator baseDecorator = default(BaseDecorator);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				default:
					baseDecorator = (BaseDecorator)Activator.CreateInstance(decoratorType);
					num2 = 5;
					continue;
				case 1:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								int num3 = 2;
								num4 = num3;
								goto IL_0079;
							}
							goto IL_00ef;
							IL_0079:
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
							case 3:
								break;
							case 4:
								goto IL_00ef;
							case 2:
								goto end_IL_00d5;
							}
							continue;
							IL_00ef:
							if (oE8MHxOIZIqcVqqIv5Nx(enumerator).GetType() == decoratorType)
							{
								return;
							}
							num4 = 3;
							goto IL_0079;
							continue;
							end_IL_00d5:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								disposable.Dispose();
								num5 = 2;
								continue;
							default:
								if (disposable != null)
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
									{
										num5 = 1;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
					}
					goto default;
				case 4:
					vJUWTUOIYgiFB5A87hvi(((NShape)this).get_Decorators(), baseDecorator);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					enumerator = (IEnumerator)evGIupOIOQ9lfJ2AhZpo(sBUfArOIKOpWwHxJSoVQ(this));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			FkxT0bOIvdAR164f7b7v(baseDecorator, position);
			num = 4;
		}
	}

	public void RemoveDecorator<TDecorator>() where TDecorator : BaseDecorator
	{
		RemoveDecorator(typeof(TDecorator));
	}

	public void RemoveDecorator(Type decoratorType)
	{
		//Discarded unreachable code: IL_003e, IL_004d, IL_00fa, IL_0109, IL_0164, IL_01a8, IL_01b7, IL_01e4, IL_01f4, IL_0203, IL_02ac, IL_02bf, IL_02ce
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		int num = 1;
		IEnumerator enumerator = default(IEnumerator);
		List<NDecorator> list = default(List<NDecorator>);
		object obj = default(object);
		List<NDecorator>.Enumerator enumerator2 = default(List<NDecorator>.Enumerator);
		NDecorator current = default(NDecorator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!APoQR7OIsOBEE86ZXc6h(enumerator))
							{
								num3 = 3;
								goto IL_0058;
							}
							goto IL_0114;
							IL_0137:
							list = new List<NDecorator>();
							num3 = 5;
							goto IL_0058;
							IL_0114:
							obj = oE8MHxOIZIqcVqqIv5Nx(enumerator);
							int num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
							{
								num4 = 1;
							}
							goto IL_005c;
							IL_0058:
							num4 = num3;
							goto IL_005c;
							IL_005c:
							while (true)
							{
								switch (num4)
								{
								case 1:
									if (XgC9cEOI83anKQcrrVhL(obj.GetType(), decoratorType))
									{
										num4 = 7;
										continue;
									}
									break;
								case 7:
									if (list != null)
									{
										num4 = 6;
										continue;
									}
									goto IL_0137;
								case 5:
								case 6:
									list.Add((NDecorator)obj);
									num4 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
									{
										num4 = 1;
									}
									continue;
								case 4:
									break;
								case 2:
									goto IL_0114;
								default:
									goto IL_0137;
								case 3:
									goto end_IL_00db;
								}
								break;
							}
							continue;
							end_IL_00db:
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
							default:
								goto end_IL_0168;
							case 2:
								if (disposable == null)
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
									{
										num5 = 0;
									}
									continue;
								}
								break;
							case 0:
								goto end_IL_0168;
							case 1:
								break;
							case 3:
								goto end_IL_0168;
							}
							PUiS8yOIJe7eR9DCVm2E(disposable);
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
							{
								num5 = 3;
							}
							continue;
							end_IL_0168:
							break;
						}
					}
					break;
				case 4:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 3;
								goto IL_0212;
							}
							goto IL_0269;
							IL_0212:
							while (true)
							{
								switch (num6)
								{
								case 2:
									LTB36YOIlix8cCKh5ZDx(((NShape)this).get_Decorators(), current);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									goto IL_0269;
								case 3:
									return;
								}
								break;
							}
							continue;
							IL_0269:
							current = enumerator2.Current;
							int num7 = 2;
							num6 = num7;
							goto IL_0212;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
				case 1:
					list = null;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					enumerator2 = list.GetEnumerator();
					num2 = 4;
					continue;
				default:
					enumerator = (IEnumerator)evGIupOIOQ9lfJ2AhZpo(sBUfArOIKOpWwHxJSoVQ(this));
					num2 = 6;
					continue;
				case 3:
					break;
				case 2:
					return;
				}
				break;
			}
			if (list != null)
			{
				num = 5;
				continue;
			}
			break;
		}
	}

	public void AddOrRemoveDecorator<TDecorator>(bool condition, DecoratorPosition position = DecoratorPosition.Center) where TDecorator : BaseDecorator, new()
	{
		AddOrRemoveDecorator(typeof(TDecorator), condition, position);
	}

	public void AddOrRemoveDecorator(Type decoratorType, bool condition, DecoratorPosition position = DecoratorPosition.Center)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				if (condition)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 0;
					}
					break;
				}
				RemoveDecorator(decoratorType);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				AddDecorator(decoratorType, position);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public abstract NModel GetBorderDecoratorModel(NRectangleF bounds);

	public virtual void UpdateDecorators(Element element)
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
				MdTbEWOI0UUCETqe5Op8(sBUfArOIKOpWwHxJSoVQ(this));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool CreateShapeElements(ShapeElementsMask shapeElements)
	{
		//Discarded unreachable code: IL_0047, IL_0091, IL_00a0, IL_0127, IL_0136, IL_0145, IL_01a7, IL_0256, IL_0265
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		NDiagramElementCompositeImpl val = default(NDiagramElementCompositeImpl);
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					int num3;
					if ((shapeElements & 8) == 0)
					{
						num3 = 9;
						goto IL_004b;
					}
					goto IL_007d;
					IL_004b:
					while (true)
					{
						switch (num3)
						{
						case 8:
							goto end_IL_004b;
						case 5:
						{
							object obj = obGlTBOImpnQO5q7YhxB(V9B3mpOIylouNLlpSIE8(this).GetField(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1599901164), BindingFlags.Instance | BindingFlags.NonPublic), this);
							val = (NDiagramElementCompositeImpl)((obj is NDiagramElementCompositeImpl) ? obj : null);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num3 = 0;
							}
							continue;
						}
						case 4:
							if (sBUfArOIKOpWwHxJSoVQ(this) != null)
							{
								num3 = 3;
								continue;
							}
							goto case 5;
						case 6:
							((NNodeCompositeImpl)val).InsertChild(num4, (INNode)(object)new PaintableDecoratorCollection());
							num3 = 7;
							continue;
						case 3:
							goto end_IL_004b;
						case 9:
							goto end_IL_004b;
						case 2:
							num4 = ((ArrayList)(object)val).Count - 1;
							num3 = 6;
							continue;
						case 1:
							if (val == null)
							{
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
								{
									num3 = 8;
								}
								continue;
							}
							goto case 2;
						case 7:
							goto end_IL_004b;
						}
						goto IL_007d;
						continue;
						end_IL_004b:
						break;
					}
					goto end_IL_0035;
					IL_007d:
					shapeElements = (ShapeElementsMask)(shapeElements ^ 8);
					num3 = 4;
					goto IL_004b;
					end_IL_0035:;
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 4:
							YtkZhIOIc8Fvjb3hac6a(this);
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
							{
								num5 = 0;
							}
							break;
						case 2:
							SytvodOIBF0ecu30vbF2(this);
							num5 = 4;
							break;
						default:
							snBSexOIg1BkB5Vn0T5H(uNQe9lOI5TAjDPYogUeg(LhGU2LOIt7OsOnrmKRn1(0x6871CA ^ 0x6A019C), XTruJhOIbVQyaugDJta3(ex)));
							num5 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
							{
								num5 = 2;
							}
							break;
						case 1:
							result = false;
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
							{
								num5 = 3;
							}
							break;
						case 3:
							return result;
						}
					}
				}
				goto default;
			case 5:
				YtkZhIOIc8Fvjb3hac6a(this);
				num2 = 4;
				break;
			case 2:
				((NDiagramElement)this).StartTransaction(NDR.TransactionCreateShapeElements);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return ((NShape)this).CreateShapeElements(shapeElements);
			default:
				((NDiagramElement)this).Commit();
				num2 = 5;
				break;
			case 4:
				if ((int)shapeElements == 0)
				{
					return true;
				}
				num2 = 3;
				break;
			}
		}
	}

	public void UpdateStyle(Color beginColor, Color endColor)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				ftFHsyOIuxH0BQe8ZqtM(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(2f, beginColor));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				((NStyle)T5ieq1OIPOK6pkmEOmWR(this)).set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, endColor, endColor));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				I9XvaiOIdKLBiGUYiToY(T5ieq1OIPOK6pkmEOmWR(this), (object)new NTextStyle(new NFontStyle(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514284824), 8f, FontStyle.Bold), DmIHfaOIXhtX3r8X2QDb(40, 84, 165)));
				num2 = 3;
				break;
			}
		}
	}

	internal static void U0mZEBOizZGfWotsf4Xh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool aZOJGROiwt9fuFq43dm3()
	{
		return LEZmKqOiEUtecYmHe3PS == null;
	}

	internal static BPMNShape MOx9OSOi4Rc3kHIswXU9()
	{
		return LEZmKqOiEUtecYmHe3PS;
	}

	internal static object sBUfArOIKOpWwHxJSoVQ(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static object evGIupOIOQ9lfJ2AhZpo(object P_0)
	{
		return ((NDiagramElementCollection)P_0).GetEnumerator();
	}

	internal static object oE8MHxOIZIqcVqqIv5Nx(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static void FkxT0bOIvdAR164f7b7v(object P_0, DecoratorPosition value)
	{
		((BaseDecorator)P_0).Position = value;
	}

	internal static void vJUWTUOIYgiFB5A87hvi(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool XgC9cEOI83anKQcrrVhL(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool APoQR7OIsOBEE86ZXc6h(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void PUiS8yOIJe7eR9DCVm2E(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void LTB36YOIlix8cCKh5ZDx(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).RemoveChild((INNode)P_1);
	}

	internal static void MdTbEWOI0UUCETqe5Op8(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static Type V9B3mpOIylouNLlpSIE8(object P_0)
	{
		return P_0.GetType();
	}

	internal static object obGlTBOImpnQO5q7YhxB(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object LhGU2LOIt7OsOnrmKRn1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XTruJhOIbVQyaugDJta3(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object uNQe9lOI5TAjDPYogUeg(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void snBSexOIg1BkB5Vn0T5H(object P_0)
	{
		Trace.WriteLine((string)P_0);
	}

	internal static void SytvodOIBF0ecu30vbF2(object P_0)
	{
		((NDiagramElement)P_0).Rollback();
	}

	internal static void YtkZhIOIc8Fvjb3hac6a(object P_0)
	{
		((NShape)P_0).UpdateElementReferences();
	}

	internal static object T5ieq1OIPOK6pkmEOmWR(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color DmIHfaOIXhtX3r8X2QDb(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void I9XvaiOIdKLBiGUYiToY(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static void ftFHsyOIuxH0BQe8ZqtM(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}
}
