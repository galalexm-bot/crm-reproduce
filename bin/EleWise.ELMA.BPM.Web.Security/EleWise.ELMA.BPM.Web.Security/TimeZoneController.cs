using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class TimeZoneController : BPMController
{
	[NotNull]
	public ITimeZoneService TimeZoneService { get; set; }

	[NotNull]
	public IBLOBStore BLOBStore { get; set; }

	public JsonResult GetTimeZone(string currentIanaTimeZoneId, int currentTimeZoneOffset)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		try
		{
			TimeZoneModel currentUserTimeZone = TimeZoneService.CurrentUserTimeZone;
			TimeZoneModel timeZoneModel = TimeZoneMapper.GetTimeZoneByIanaTimeZoneId(currentIanaTimeZoneId, currentTimeZoneOffset);
			if (timeZoneModel == null)
			{
				timeZoneModel = TZ.TimeZones.FirstOrDefault((TimeZoneModel stz) => stz.Offset == currentTimeZoneOffset);
			}
			JsonResult val;
			if (!(timeZoneModel == null))
			{
				val = new JsonResult();
				val.set_Data((object)new
				{
					TargetTzId = timeZoneModel.TimeZoneId,
					TargetTzDisplayName = timeZoneModel.ToString(),
					UserTzDisplayName = currentUserTimeZone.ToString(),
					Error = false
				});
				val.set_JsonRequestBehavior((JsonRequestBehavior)0);
			}
			else
			{
				val = new JsonResult();
				val.set_Data((object)new
				{
					Error = true
				});
				val.set_JsonRequestBehavior((JsonRequestBehavior)0);
			}
			return val;
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка получения приоритетного часового пояса"), exception);
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				Error = true
			});
			val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return val2;
		}
	}

	[TransactionAction]
	public JsonResult ChangeTimeZone(string timeZoneId, long currentTimeZoneOffset, bool userDecision)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		TimeZoneModel timeZoneModel = TZ.TimeZones.FirstOrDefault((TimeZoneModel tz) => tz.TimeZoneId == timeZoneId && tz.Offset == currentTimeZoneOffset);
		if (userDecision)
		{
			try
			{
				if (timeZoneModel == null)
				{
					throw new Exception("TimeZone not found");
				}
				currentUser.TimeZoneData = timeZoneModel.ToJson();
				currentUser.Save();
				BLOBStore.Save($"BlockedUserTimeZoneOffset_{currentUser.Id}", ClassSerializationHelper.SerializeObject(timeZoneModel.ToJson()));
				JsonResult val = new JsonResult();
				val.set_Data((object)new
				{
					DisplayName = timeZoneModel.ToString(),
					Blocked = false,
					Error = false
				});
				val.set_JsonRequestBehavior((JsonRequestBehavior)0);
				return val;
			}
			catch (Exception exception)
			{
				EleWise.ELMA.Logging.Logger.Log.Error("Error user timezone setting", exception);
				JsonResult val2 = new JsonResult();
				val2.set_Data((object)new
				{
					Blocked = false,
					Error = true
				});
				val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
				return val2;
			}
		}
		BLOBStore.Save($"BlockedUserTimeZoneOffset_{currentUser.Id}", ClassSerializationHelper.SerializeObject(currentTimeZoneOffset));
		JsonResult val3 = new JsonResult();
		val3.set_Data((object)new
		{
			Blocked = true,
			Error = false
		});
		val3.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val3;
	}

	public JsonResult GetTimeZoneOffsets()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		if (base.AuthenticationService.GetCurrentUser() != null)
		{
			long? blockedTimeZoneOffset = TimeZoneService.GetBlockedTimeZoneOffset();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("ElmaUserTimeZoneOffset", TZ.ClientOffset.ToString());
			dictionary.Add("ElmaServerTimeZoneOffset", TZ.ServerOffset.ToString());
			dictionary.Add("ElmaRuntimeTimeZoneOffset", TZ.RuntimeOffset.ToString());
			if (blockedTimeZoneOffset.HasValue)
			{
				dictionary.Add("ElmaBlockedTimeZoneOffset", blockedTimeZoneOffset.Value.ToString());
			}
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				TimeZones = dictionary,
				Error = false
			});
			val.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return val;
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)new
		{
			Error = true
		});
		val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val2;
	}
}
