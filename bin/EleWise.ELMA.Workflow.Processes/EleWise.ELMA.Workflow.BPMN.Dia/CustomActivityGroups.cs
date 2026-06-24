using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevComponents.AdvTree;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.CustomActivity;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

public static class CustomActivityGroups
{
	[Component(Order = 200)]
	public class CustomActivityPlugin : IBPMNToolboxNodeGroup, IToolboxNodeGroup
	{
		public static readonly Guid UID;

		private static CustomActivityPlugin Nad9G8WobVEjP0tlDYs;

		private ICustomActivityDTOManager CustomActivityManager => Locator.GetServiceNotNull<ICustomActivityDTOManager>();

		private ICustomActivityHeaderDTOManager CustomActivityHeaderManager => Locator.GetServiceNotNull<ICustomActivityHeaderDTOManager>();

		private ICustomActivityFolderDTOManager CustomActivityFolderManager => Locator.GetServiceNotNull<ICustomActivityFolderDTOManager>();

		public Guid PanelUid => PluginGroups.PluginsPanel.UID;

		public NodeCollection Nodes
		{
			get
			{
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected O, but got Unknown
				int num = 3;
				int num2 = num;
				CustomActivityFolderDTO folder = default(CustomActivityFolderDTO);
				Node val = default(Node);
				while (true)
				{
					switch (num2)
					{
					case 2:
						folder = CustomActivityFolderManager.LoadRootFolder(0L, true);
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						val = new Node();
						num2 = 2;
						break;
					default:
						return (NodeCollection)qdoCgaWxfKOgxIkE7Mt(val);
					case 1:
						CreateFolderNode(folder, (NodeCollection)qdoCgaWxfKOgxIkE7Mt(val));
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => (string)Kb22n0W8bqwZptuT8yh(fBt2VUWFdkdS8wCTN67(0x5A5DBA54 ^ 0x5A5DFDB2));

		private void CreateFolderNode(CustomActivityFolderDTO folder, NodeCollection nodes)
		{
			//Discarded unreachable code: IL_0057, IL_0066, IL_0071, IL_0190, IL_01c8, IL_01d7
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Expected O, but got Unknown
			//IL_0150: Expected O, but got Unknown
			int num = 4;
			int num2 = num;
			Bitmap folder2 = default(Bitmap);
			IEnumerator<CustomActivityFolderDTO> enumerator = default(IEnumerator<CustomActivityFolderDTO>);
			CustomActivityFolderDTO current = default(CustomActivityFolderDTO);
			Node val2 = default(Node);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					folder2 = Resources.folder;
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_00dd:
							int num3;
							if (!SmZAqQWqtm79yoY6Y1b(enumerator))
							{
								num3 = 3;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
								{
									num3 = 3;
								}
								goto IL_0075;
							}
							goto IL_00ba;
							IL_00ba:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
							{
								num3 = 0;
							}
							goto IL_0075;
							IL_0075:
							while (true)
							{
								switch (num3)
								{
								case 5:
									XCjpk1W2oxF9IgOngdc(nodes, val2);
									num3 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
									{
										num3 = 1;
									}
									continue;
								case 4:
									break;
								case 2:
									goto IL_00dd;
								case 1:
									CreateFolderNode(current, (NodeCollection)qdoCgaWxfKOgxIkE7Mt(val2));
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
									{
										num3 = 2;
									}
									continue;
								default:
								{
									Node val = new Node();
									zSWaBNWwXUNcaeuq8OC((object)val, current);
									DrDgXyWtLGnAKLmeOtG((object)val, current.Name);
									wohmtWWsFcTGX4cJueL((object)val, folder2);
									val2 = val;
									num3 = 5;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								case 3:
									goto end_IL_00dd;
								}
								break;
							}
							goto IL_00ba;
							continue;
							end_IL_00dd:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									JXfgkTWQfEVfeP4QJ4u(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
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
					}
					break;
				case 0:
					return;
				case 3:
					enumerator = folder.SubFolders.OrderBy(delegate(CustomActivityFolderDTO g)
					{
						//Discarded unreachable code: IL_003f, IL_004e
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							case 2:
								return "";
							default:
								return ((string)_003C_003Ec.P2sDoQiKYMuITNHut3t(g)).ToUpper();
							case 1:
								if (_003C_003Ec.P2sDoQiKYMuITNHut3t(g) != null)
								{
									num8 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
									{
										num8 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					}).GetEnumerator();
					num2 = 2;
					continue;
				case 1:
					break;
				}
				CreateCustomActivityNodes(folder.CustomActivitys.Where(delegate(CustomActivityHeaderDTO f)
				{
					//Discarded unreachable code: IL_002d, IL_003c
					int num5 = 2;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 2:
							if (_003C_003Ec.sYxYhliMxnNWagxn1ru(f) == 0L)
							{
								num6 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
								{
									num6 = 1;
								}
								break;
							}
							goto default;
						default:
							return !f.Deleted;
						case 1:
							return false;
						}
					}
				}), nodes);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
				{
					num2 = 0;
				}
			}
		}

		private void CreateCustomActivityNodes(IEnumerable<CustomActivityHeaderDTO> activitys, NodeCollection nodes)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			foreach (CustomActivityHeaderDTO item in activitys.ToList().OrderBy(delegate(CustomActivityHeaderDTO h)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return "";
					case 1:
						if (_003C_003Ec.hLLDlZia1H6ltgaceUQ(h) != null)
						{
							return (string)_003C_003Ec.RjTQNYiYjcVUEhCHhU2(h.Name);
						}
						num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			}))
			{
				_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
				CS_0024_003C_003E8__locals0.activity1 = item;
				Node val = new Node();
				val.set_Tag((object)item);
				val.set_Text(item.Name);
				val.set_Image(DiagramImageHelper.GenerateImage(typeof(CustomActivityShape), new Size(20, 20), delegate(NShape s)
				{
					//IL_0073: Unknown result type (might be due to invalid IL or missing references)
					//IL_007d: Expected O, but got Unknown
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
							_003C_003Ec__DisplayClass18_0.oZfaM6iNv9xvtM8H2ZW((BPMNRectangleShape)(object)s, (ShapeElementsMask)8);
							num2 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							_003C_003Ec__DisplayClass18_0.DIqySXicXIcygCC35qK(((NStyleableElement)(BPMNRectangleShape)(object)s).get_Style(), (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, _003C_003Ec__DisplayClass18_0.HAkJAKiTPOxfh4ajJSP(CS_0024_003C_003E8__locals0.activity1), _003C_003Ec__DisplayClass18_0.HAkJAKiTPOxfh4ajJSP(CS_0024_003C_003E8__locals0.activity1)));
							num2 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
							{
								num2 = 1;
							}
							break;
						}
					}
				}, ignoreCache: true));
				Node val2 = val;
				nodes.Add(val2);
			}
		}

		public CustomActivityPlugin()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			gVO9cJWV9e6okmJxpsG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static CustomActivityPlugin()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					gVO9cJWV9e6okmJxpsG();
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					UID = new Guid((string)fBt2VUWFdkdS8wCTN67(0x1CF99A4A ^ 0x1CF956BE));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object qdoCgaWxfKOgxIkE7Mt(object P_0)
		{
			return ((Node)P_0).get_Nodes();
		}

		internal static bool puilg3W3W05vAgiyilO()
		{
			return Nad9G8WobVEjP0tlDYs == null;
		}

		internal static CustomActivityPlugin IEap9uWh7chKaPXuw1A()
		{
			return Nad9G8WobVEjP0tlDYs;
		}

		internal static object fBt2VUWFdkdS8wCTN67(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Kb22n0W8bqwZptuT8yh(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void zSWaBNWwXUNcaeuq8OC(object P_0, object P_1)
		{
			((Node)P_0).set_Tag(P_1);
		}

		internal static void DrDgXyWtLGnAKLmeOtG(object P_0, object P_1)
		{
			((Node)P_0).set_Text((string)P_1);
		}

		internal static void wohmtWWsFcTGX4cJueL(object P_0, object P_1)
		{
			((Node)P_0).set_Image((Image)P_1);
		}

		internal static int XCjpk1W2oxF9IgOngdc(object P_0, object P_1)
		{
			return ((NodeCollection)P_0).Add((Node)P_1);
		}

		internal static bool SmZAqQWqtm79yoY6Y1b(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void JXfgkTWQfEVfeP4QJ4u(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static void gVO9cJWV9e6okmJxpsG()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}
}
