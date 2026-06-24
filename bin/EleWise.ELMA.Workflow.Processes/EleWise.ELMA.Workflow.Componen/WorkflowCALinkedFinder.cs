using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.CustomActivity;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class WorkflowCALinkedFinder : WorkflowLinkedFinderBase
{
	private static WorkflowCALinkedFinder YmOlCJNNYj1fbDGdLki;

	public WorkflowCALinkedFinder(ProcessHeaderManager processHeaderManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		lt5ktvNSGc5eCOIJ5ox();
		base._002Ector(processHeaderManager);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.context = context;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.resultObj = new FindLinkedObjectsResult();
		GetProcessDiagrams(objectsToSearch, CS_0024_003C_003E8__locals0.context).ForEach(delegate(WorkflowDiagram diagram)
		{
			//Discarded unreachable code: IL_002e, IL_0038, IL_0169, IL_01a1, IL_01b0
			int num = 2;
			int num2 = num;
			IEnumerator<CustomActivityElement> enumerator = default(IEnumerator<CustomActivityElement>);
			_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_1);
			ILinkedObject linkedObject = default(ILinkedObject);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!_003C_003Ec__DisplayClass1_0.kxIlPiBms9kUOdOtMEl(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 != 0)
								{
									num3 = 0;
								}
								goto IL_003c;
							}
							goto IL_00d2;
							IL_00d2:
							_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_1();
							num3 = 4;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
							{
								num3 = 4;
							}
							goto IL_003c;
							IL_003c:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									linkedObject = CS_0024_003C_003E8__locals0.context.AllObjects.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CFindLinkedObjects_003Eb__1);
									num3 = 6;
									continue;
								case 6:
									if (linkedObject != null)
									{
										num3 = 3;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
										{
											num3 = 5;
										}
										continue;
									}
									break;
								case 3:
									goto IL_00d2;
								case 4:
									_003C_003Ec__DisplayClass1_.element = enumerator.Current;
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									CS_0024_003C_003E8__locals0._003C_003E4__this.FillObj(CS_0024_003C_003E8__locals0.resultObj, CS_0024_003C_003E8__locals0.context, _003C_003Ec__DisplayClass1_0.sc0LjaBUqn3BcZKlGEV(linkedObject));
									num3 = 2;
									continue;
								case 1:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									_003C_003Ec__DisplayClass1_0.P5hygMBA6XZot5Yx8j2(enumerator);
									num4 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 0:
					return;
				case 2:
					enumerator = ((IEnumerable)_003C_003Ec__DisplayClass1_0.GZexbFBbbSp5ovoxosJ(diagram)).OfType<CustomActivityElement>().GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.resultObj;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		return null;
	}

	internal static void lt5ktvNSGc5eCOIJ5ox()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool xnGIQSNdOla522Cq4RP()
	{
		return YmOlCJNNYj1fbDGdLki == null;
	}

	internal static WorkflowCALinkedFinder obrtGJNjGUcRgve3sX6()
	{
		return YmOlCJNNYj1fbDGdLki;
	}
}
