using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "DisplayName")]
[Uid("1db6a3f5-b1d5-433e-b80c-803c2b7213fd")]
public enum ProcessMetricTaskRepeatAction
{
	[Uid("3abbfef0-a872-4463-b306-df4e2ba3ec8d")]
	[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "P_Sum_DisplayName")]
	Sum,
	[Uid("60a59682-0b14-47ae-bfb2-6054d719b5e2")]
	[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "P_Average_DisplayName")]
	Average,
	[Uid("063213c7-8d46-4b2c-88b3-a280a4252ac3")]
	[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "P_Minimum_DisplayName")]
	Minimum,
	[Uid("96c4b39f-e75a-4ec6-a156-5670767f9a53")]
	[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "P_Maximum_DisplayName")]
	Maximum,
	[Uid("383e5867-b3ab-47fc-b652-375ace3149ee")]
	[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "P_First_DisplayName")]
	First,
	[DisplayName(typeof(__Resources_ProcessMetricTaskRepeatAction), "P_Last_DisplayName")]
	[Uid("bcd43bce-db6b-41d8-8465-5c9bd87b4594")]
	Last
}
