// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.MultiEdit.MultiEditService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.MultiEdit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.MultiEdit
{
  [Service]
  public class MultiEditService
  {
    private static MultiEditService mn7A9NBmK0KBGAi5dHRE;

    public ICacheService Cache
    {
      get => this.\u003CCache\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCache\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Пинг редактирования объекта и получение текущего редактора
    /// </summary>
    /// <param name="objectId">Id объекта</param>
    /// <param name="objectName">Имя объекта</param>
    /// <param name="parentObjectId">Id родителя объекта</param>
    /// <param name="parentObjectName">Имя родителя объекта</param>
    /// <param name="userId">Id пользователя</param>
    /// <param name="userName">Имя пользователя</param>
    /// <param name="sessionPrefix">Префикс сессии</param>
    /// <param name="sessionLifeTime">Время жизни сессии</param>
    /// <param name="editSessionUid">UID сессии</param>
    /// <param name="selfKick">Принудительное закрытие другой своей активной сессии</param>
    /// <param name="saveChanges">Флаг сохранения результатов предыдущей сессии</param>
    public MultiEditEditorStoreModel PingAndGetCurrentSoleEditor(
      long objectId,
      string objectName,
      long parentObjectId,
      string parentObjectName,
      long userId,
      string userName,
      string sessionPrefix,
      long sessionLifeTime,
      Guid editSessionUid,
      bool selfKick = false,
      bool saveChanges = false)
    {
      return this.PingAndGetCurrentSoleEditor(objectId.ToString(), objectName, parentObjectId, parentObjectName, userId, userName, sessionPrefix, sessionLifeTime, editSessionUid, selfKick, saveChanges);
    }

    /// <summary>
    /// Пинг редактирования объекта и получение текущего редактора
    /// </summary>
    /// <param name="objectUid">Uid объекта</param>
    /// <param name="objectName">Имя объекта</param>
    /// <param name="parentObjectId">Id родителя объекта</param>
    /// <param name="parentObjectName">Имя родителя объекта</param>
    /// <param name="userId">Id пользователя</param>
    /// <param name="userName">Имя пользователя</param>
    /// <param name="sessionPrefix">Префикс сессии</param>
    /// <param name="sessionLifeTime">Время жизни сессии</param>
    /// <param name="editSessionUid">UID сессии</param>
    /// <param name="selfKick">Принудительное закрытие другой своей активной сессии</param>
    /// <param name="saveChanges">Флаг сохранения результатов предыдущей сессии</param>
    public MultiEditEditorStoreModel PingAndGetCurrentSoleEditor(
      Guid objectUid,
      string objectName,
      long parentObjectId,
      string parentObjectName,
      long userId,
      string userName,
      string sessionPrefix,
      long sessionLifeTime,
      Guid editSessionUid,
      bool selfKick = false,
      bool saveChanges = false)
    {
      return this.PingAndGetCurrentSoleEditor(objectUid.ToString(), objectName, parentObjectId, parentObjectName, userId, userName, sessionPrefix, sessionLifeTime, editSessionUid, selfKick, saveChanges);
    }

    /// <summary>Завершение редактирования объекта</summary>
    /// <param name="objectId">Id объекта</param>
    /// <param name="objectName">Имя объекта</param>
    /// <param name="userId">Id пользователя, который редактирует</param>
    /// <param name="sessionPrefix">Префикс сессии</param>
    /// <returns>Успешное завершение</returns>
    public bool FinishObjectSoleEditSession(
      long objectId,
      string objectName,
      long userId,
      string sessionPrefix)
    {
      return this.FinishObjectSoleEditSession(objectId.ToString(), objectName, userId, sessionPrefix);
    }

    /// <summary>Завершение редактирования объекта</summary>
    /// <param name="objectUid">Uid объекта</param>
    /// <param name="objectName">Имя объекта</param>
    /// <param name="userId">Id пользователя, который редактирует</param>
    /// <param name="sessionPrefix">Префикс сессии</param>
    /// <returns>Успешное завершение</returns>
    public bool FinishObjectSoleEditSession(
      Guid objectUid,
      string objectName,
      long userId,
      string sessionPrefix)
    {
      return this.FinishObjectSoleEditSession(objectUid.ToString(), objectName, userId, sessionPrefix);
    }

    /// <summary>Пинг редактирования объекта</summary>
    /// <returns></returns>
    public MultiEditEditorStoreModel[] PingAndGetCurrentEditorsForObject(
      long objectId,
      string objectName,
      long parentObjectId,
      string parentObjectName,
      long userId,
      string userName,
      string sessionPrefix,
      long sessionLifeTime,
      Guid editSessionUid)
    {
      int num1 = 23;
      MultiEditEditorStoreModel[] array;
      while (true)
      {
        int num2 = num1;
        List<MultiEditEditorStoreModel> source1;
        MultiEditEditorStoreModel editorStoreModel1;
        string key;
        DateTime dateTime;
        MultiEditEditorStoreModel editorStoreModel2;
        int index;
        MultiEditEditorStoreModel[] editorStoreModelArray;
        TimeSpan cacheDuration;
        IEnumerator<MultiEditEditorStoreModel> enumerator;
        List<Guid> sessionsToDelete;
        long userId1;
        long objectId1;
        Guid editSessionUid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              this.Cache.Insert<List<MultiEditEditorStoreModel>>(key, source1, cacheDuration);
              num2 = 33;
              continue;
            case 2:
              goto label_4;
            case 3:
              source1.Add(editorStoreModel1);
              num2 = 5;
              continue;
            case 4:
              sessionsToDelete = new List<Guid>();
              num2 = 15;
              continue;
            case 6:
              editorStoreModel2 = editorStoreModelArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 25 : 4;
              continue;
            case 7:
              source1 = new List<MultiEditEditorStoreModel>()
              {
                editorStoreModel1
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 5 : 39;
              continue;
            case 8:
              editorStoreModel1 = source1.FirstOrDefault<MultiEditEditorStoreModel>((Func<MultiEditEditorStoreModel, bool>) (m =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (m.objectId == objectId1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    case 2:
                      if (m.userId == userId1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return MultiEditService.\u003C\u003Ec__DisplayClass8_0.KrxZD5QngNsOkiKPlpEW(m.editSessionUid, editSessionUid1);
label_5:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 27 : 25;
              continue;
            case 9:
            case 34:
              ++index;
              num2 = 19;
              continue;
            case 10:
              num2 = 4;
              continue;
            case 11:
              key = string.Format((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(-345420348 ^ -345399506), (object) sessionPrefix, (object) parentObjectId);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 14 : 29;
              continue;
            case 12:
              cacheDuration = MultiEditService.xuWlGaBmkWmaLYMDVLnF((double) sessionLifeTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 11 : 11;
              continue;
            case 13:
            case 32:
            case 37:
              editorStoreModel2.savedAfter = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 34 : 29;
              continue;
            case 14:
              try
              {
label_37:
                if (MultiEditService.mUtcRnBmeCVbp3Kc9a09((object) enumerator))
                  goto label_39;
                else
                  goto label_38;
label_34:
                MultiEditEditorStoreModel current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_39;
                    case 2:
                      dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
                      num4 = 5;
                      continue;
                    case 3:
                      goto label_37;
                    case 4:
                      goto label_6;
                    case 5:
                      if (MultiEditService.TjK9U9Bm2IECiO7gOuDC(dateTime.Subtract(current.lastActivityTime), cacheDuration))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_37;
                    default:
                      sessionsToDelete.Add(current.editSessionUid);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 3;
                      continue;
                  }
                }
label_38:
                num4 = 4;
                goto label_34;
label_39:
                current = enumerator.Current;
                num4 = 2;
                goto label_34;
              }
              finally
              {
                int num5;
                if (enumerator == null)
                  num5 = 2;
                else
                  goto label_45;
label_44:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_45:
                MultiEditService.qcCXjhBmPAE3Nn89Bcmt((object) enumerator);
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                {
                  num5 = 1;
                  goto label_44;
                }
                else
                  goto label_44;
              }
            case 15:
              List<MultiEditEditorStoreModel> source2 = source1;
              // ISSUE: reference to a compiler-generated field
              Func<MultiEditEditorStoreModel, bool> func = MultiEditService.\u003C\u003Ec.\u003C\u003E9__8_3;
              Func<MultiEditEditorStoreModel, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                MultiEditService.\u003C\u003Ec.\u003C\u003E9__8_3 = predicate = (Func<MultiEditEditorStoreModel, bool>) (m =>
                {
                  int num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        if (m.saveTime.HasValue)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_4;
                      case 2:
                        goto label_4;
                      default:
                        goto label_5;
                    }
                  }
label_4:
                  return !m.publishTime.HasValue;
label_5:
                  return false;
                });
              }
              else
                goto label_60;
label_59:
              enumerator = source2.Where<MultiEditEditorStoreModel>(predicate).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 14 : 4;
              continue;
label_60:
              predicate = func;
              goto label_59;
            case 16:
label_6:
              source1 = source1.Where<MultiEditEditorStoreModel>((Func<MultiEditEditorStoreModel, bool>) (w => !sessionsToDelete.Contains(w.editSessionUid))).ToList<MultiEditEditorStoreModel>();
              num2 = 8;
              continue;
            case 17:
              MultiEditEditorStoreModel editorStoreModel3 = new MultiEditEditorStoreModel();
              editorStoreModel3.editSessionUid = editSessionUid1;
              editorStoreModel3.userId = userId1;
              editorStoreModel3.userName = userName;
              editorStoreModel3.parentObjectId = parentObjectId;
              editorStoreModel3.parentObjectName = parentObjectName;
              editorStoreModel3.objectId = objectId1;
              editorStoreModel3.objectName = objectName;
              editorStoreModel3.openTime = MultiEditService.baynqFBmOdDpss30YnNI();
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              editorStoreModel3.openTimeStr = dateTime.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638492941));
              editorStoreModel3.saveTime = new DateTime?();
              editorStoreModel3.saveTimeStr = string.Empty;
              editorStoreModel3.savedAfter = false;
              editorStoreModel3.lastActivityTime = DateTime.Now;
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              editorStoreModel3.lastActivityTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(-1317790512 ^ -1317700046));
              editorStoreModel1 = editorStoreModel3;
              num2 = 3;
              continue;
            case 18:
              goto label_19;
            case 19:
            case 31:
              if (index >= editorStoreModelArray.Length)
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 20:
              editorStoreModel2.savedAfter = true;
              num2 = 9;
              continue;
            case 21:
              if (!MultiEditService.AbC5nqBm1R0TP02CqPGX(editorStoreModel2.saveTime.Value, editorStoreModel1.openTime))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 3 : 13;
                continue;
              }
              goto case 20;
            case 22:
              userId1 = userId;
              num2 = 40;
              continue;
            case 23:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 22 : 14;
              continue;
            case 24:
              editorStoreModel1.savedAfter = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 41 : 27;
              continue;
            case 25:
              if (!editorStoreModel2.saveTime.HasValue)
              {
                num2 = 32;
                continue;
              }
              goto case 21;
            case 26:
              editorStoreModel1.lastActivityTimeStr = editorStoreModel1.lastActivityTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(516838154 ^ 516895208));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
              continue;
            case 27:
              if (editorStoreModel1 == null)
              {
                num2 = 17;
                continue;
              }
              goto case 24;
            case 28:
              if (!this.Cache.TryGetValue<List<MultiEditEditorStoreModel>>(key, out source1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 29:
              goto label_32;
            case 30:
              index = 0;
              num2 = 31;
              continue;
            case 33:
            case 36:
              array = source1.Where<MultiEditEditorStoreModel>((Func<MultiEditEditorStoreModel, bool>) (m => m.userId != userId1)).ToArray<MultiEditEditorStoreModel>();
              num2 = 18;
              continue;
            case 35:
              editSessionUid1 = editSessionUid;
              num2 = 12;
              continue;
            case 38:
              editorStoreModel1 = (MultiEditEditorStoreModel) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 24 : 28;
              continue;
            case 39:
              this.Cache.Insert<List<MultiEditEditorStoreModel>>(key, source1, cacheDuration);
              num2 = 36;
              continue;
            case 40:
              objectId1 = objectId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 32 : 35;
              continue;
            case 41:
              editorStoreModel1.lastActivityTime = DateTime.Now;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 26 : 22;
              continue;
            default:
              MultiEditEditorStoreModel editorStoreModel4 = new MultiEditEditorStoreModel();
              editorStoreModel4.editSessionUid = editSessionUid1;
              editorStoreModel4.userId = userId1;
              editorStoreModel4.userName = userName;
              editorStoreModel4.parentObjectId = parentObjectId;
              editorStoreModel4.parentObjectName = parentObjectName;
              editorStoreModel4.objectId = objectId1;
              editorStoreModel4.objectName = objectName;
              editorStoreModel4.openTime = MultiEditService.baynqFBmOdDpss30YnNI();
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              editorStoreModel4.openTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(322893104 - -1992822529 ^ -1979291949));
              editorStoreModel4.saveTime = new DateTime?();
              editorStoreModel4.saveTimeStr = string.Empty;
              editorStoreModel4.savedAfter = false;
              editorStoreModel4.lastActivityTime = MultiEditService.baynqFBmOdDpss30YnNI();
              dateTime = DateTime.Now;
              editorStoreModel4.lastActivityTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(901793403 ^ 901850265));
              editorStoreModel1 = editorStoreModel4;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 7 : 4;
              continue;
          }
        }
label_19:
        editorStoreModelArray = array;
        num1 = 30;
        continue;
label_32:
        source1 = (List<MultiEditEditorStoreModel>) null;
        num1 = 38;
      }
label_4:
      return array;
    }

    public bool FinishMyObjectEditSession(
      long objectId,
      string objectName,
      long parentObjectId,
      string parentObjectName,
      long userId,
      string userName,
      string sessionPrefix,
      long sessionLifeTime,
      Guid editSessionUid)
    {
      int num1 = 18;
      while (true)
      {
        int num2 = num1;
        string key;
        List<MultiEditEditorStoreModel> source;
        MultiEditEditorStoreModel editorStoreModel1;
        List<MultiEditEditorStoreModel>.Enumerator enumerator;
        DateTime dateTime;
        TimeSpan cacheDuration;
        long userId1;
        long objectId1;
        Guid editSessionUid1;
        List<Guid> sessionsToDelete;
        while (true)
        {
          switch (num2)
          {
            case 1:
              MultiEditEditorStoreModel editorStoreModel2 = editorStoreModel1;
              dateTime = editorStoreModel1.saveTime.Value;
              string str = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(-1978478350 ^ -1978420720));
              editorStoreModel2.saveTimeStr = str;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            case 2:
            case 16:
              goto label_39;
            case 3:
            case 19:
              editorStoreModel1.saveTime = new DateTime?(MultiEditService.baynqFBmOdDpss30YnNI());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            case 4:
              source.Add(editorStoreModel1);
              num2 = 25;
              continue;
            case 5:
              editorStoreModel1 = (MultiEditEditorStoreModel) null;
              num2 = 27;
              continue;
            case 6:
              MultiEditService.NwE2jsBm3YjDjLM3Aahg((object) this.Cache, (object) key);
              num2 = 2;
              continue;
            case 7:
              source = (List<MultiEditEditorStoreModel>) null;
              num2 = 5;
              continue;
            case 8:
              if (source.Count > 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 15 : 0;
                continue;
              }
              goto case 6;
            case 9:
              goto label_21;
            case 10:
              cacheDuration = MultiEditService.xuWlGaBmkWmaLYMDVLnF((double) sessionLifeTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 21 : 18;
              continue;
            case 11:
              goto label_37;
            case 12:
              enumerator = source.GetEnumerator();
              num2 = 9;
              continue;
            case 13:
              MultiEditEditorStoreModel editorStoreModel3 = new MultiEditEditorStoreModel();
              editorStoreModel3.editSessionUid = editSessionUid1;
              editorStoreModel3.userId = userId1;
              editorStoreModel3.userName = userName;
              editorStoreModel3.parentObjectId = parentObjectId;
              editorStoreModel3.parentObjectName = parentObjectName;
              editorStoreModel3.objectId = objectId1;
              editorStoreModel3.objectName = objectName;
              editorStoreModel3.openTime = MultiEditService.baynqFBmOdDpss30YnNI();
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              editorStoreModel3.openTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(236071375 ^ 236145453));
              editorStoreModel3.saveTime = new DateTime?(DateTime.Now);
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              editorStoreModel3.saveTimeStr = dateTime.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751234302));
              editorStoreModel3.savedAfter = false;
              editorStoreModel3.lastActivityTime = DateTime.Now;
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              editorStoreModel3.lastActivityTimeStr = dateTime.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951555324));
              editorStoreModel1 = editorStoreModel3;
              num2 = 4;
              continue;
            case 14:
              editSessionUid1 = editSessionUid;
              num2 = 10;
              continue;
            case 15:
              this.Cache.Insert<List<MultiEditEditorStoreModel>>(key, source, cacheDuration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 16 : 16;
              continue;
            case 17:
              userId1 = userId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 22 : 22;
              continue;
            case 18:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 15 : 17;
              continue;
            case 20:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 22 : 23;
              continue;
            case 21:
              key = (string) MultiEditService.hhH8p9BmNPTqqPMm1rD3(MultiEditService.AS6opCBmnbTpJdcDxOs0(-1290212282 ^ -644262414 ^ 1786866526), (object) sessionPrefix, (object) parentObjectId);
              num2 = 7;
              continue;
            case 22:
              objectId1 = objectId;
              num2 = 14;
              continue;
            case 23:
              editorStoreModel1 = source.FirstOrDefault<MultiEditEditorStoreModel>((Func<MultiEditEditorStoreModel, bool>) (m =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (m.userId == userId1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    case 2:
                      goto label_2;
                    default:
                      if (m.objectId == objectId1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
                        continue;
                      }
                      goto label_3;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return MultiEditService.\u003C\u003Ec__DisplayClass9_0.Tjdm3kQOosNx3oUxVQRS(m.editSessionUid, editSessionUid1);
label_3:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 22 : 28;
              continue;
            case 24:
              editorStoreModel1.lastActivityTimeStr = editorStoreModel1.lastActivityTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(-87337865 ^ -87411051));
              num2 = 29;
              continue;
            case 25:
            case 29:
              sessionsToDelete = new List<Guid>();
              num2 = 12;
              continue;
            case 26:
              editorStoreModel1.lastActivityTime = DateTime.Now;
              num2 = 24;
              continue;
            case 27:
              if (this.Cache.TryGetValue<List<MultiEditEditorStoreModel>>(key, out source))
              {
                num2 = 20;
                continue;
              }
              goto label_39;
            case 28:
              if (editorStoreModel1 != null)
              {
                num2 = 3;
                continue;
              }
              goto case 13;
            default:
              editorStoreModel1.savedAfter = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 26 : 26;
              continue;
          }
        }
label_21:
        try
        {
label_23:
          if (enumerator.MoveNext())
            goto label_28;
          else
            goto label_24;
label_22:
          MultiEditEditorStoreModel current;
          int num4;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_37;
              case 2:
                goto label_28;
              case 3:
              case 4:
                goto label_23;
              case 5:
                dateTime = DateTime.Now;
                num4 = 6;
                continue;
              case 6:
                if (!MultiEditService.TjK9U9Bm2IECiO7gOuDC(dateTime.Subtract(current.lastActivityTime), cacheDuration))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 4;
                  continue;
                }
                break;
            }
            sessionsToDelete.Add(current.editSessionUid);
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 3 : 3;
          }
label_24:
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
          goto label_22;
label_28:
          current = enumerator.Current;
          num4 = 5;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          {
            num4 = 5;
            goto label_22;
          }
          else
            goto label_22;
        }
        finally
        {
          enumerator.Dispose();
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
            num5 = 0;
          switch (num5)
          {
            default:
          }
        }
label_37:
        source = source.Where<MultiEditEditorStoreModel>((Func<MultiEditEditorStoreModel, bool>) (w => !sessionsToDelete.Contains(w.editSessionUid))).ToList<MultiEditEditorStoreModel>();
        num1 = 8;
      }
label_39:
      return true;
    }

    public bool PublishMyObjectEditSession(
      long objectId,
      string objectName,
      long parentObjectId,
      string parentObjectName,
      long userId,
      string userName,
      string sessionPrefix,
      long sessionLifeTime)
    {
      int num1 = 6;
      List<MultiEditEditorStoreModel> source;
      string key;
      Guid guid;
      TimeSpan cacheDuration;
      DateTime dateTime;
      MultiEditEditorStoreModel editorStoreModel1;
      List<MultiEditEditorStoreModel>.Enumerator enumerator;
      List<Guid> sessionsToDelete;
      while (true)
      {
        switch (num1)
        {
          case 1:
            source = (List<MultiEditEditorStoreModel>) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 14 : 1;
            continue;
          case 2:
            source = new List<MultiEditEditorStoreModel>()
            {
              editorStoreModel1
            };
            num1 = 10;
            continue;
          case 3:
            this.Cache.Insert<List<MultiEditEditorStoreModel>>(key, source, cacheDuration);
            num1 = 16;
            continue;
          case 4:
          case 8:
          case 16:
            goto label_13;
          case 5:
            key = (string) MultiEditService.hhH8p9BmNPTqqPMm1rD3(MultiEditService.AS6opCBmnbTpJdcDxOs0(-1839087379 - 334718690 ^ 2121173217), (object) sessionPrefix, (object) parentObjectId);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
          case 6:
            cacheDuration = MultiEditService.xuWlGaBmkWmaLYMDVLnF((double) sessionLifeTime);
            num1 = 5;
            continue;
          case 7:
            try
            {
label_27:
              if (enumerator.MoveNext())
                goto label_24;
              else
                goto label_28;
label_23:
              MultiEditEditorStoreModel current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    sessionsToDelete.Add(current.editSessionUid);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_2;
                  case 4:
                    goto label_24;
                  case 5:
                    if (!(dateTime.Subtract(current.lastActivityTime) > cacheDuration))
                    {
                      num2 = 3;
                      continue;
                    }
                    goto case 1;
                  case 6:
                    dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
                    num2 = 5;
                    continue;
                  default:
                    goto label_27;
                }
              }
label_24:
              current = enumerator.Current;
              num2 = 6;
              goto label_23;
label_28:
              num2 = 2;
              goto label_23;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 9:
            MultiEditService.NwE2jsBm3YjDjLM3Aahg((object) this.Cache, (object) key);
            num1 = 4;
            continue;
          case 10:
            this.Cache.Insert<List<MultiEditEditorStoreModel>>(key, source, cacheDuration);
            num1 = 8;
            continue;
          case 11:
            MultiEditEditorStoreModel editorStoreModel2 = new MultiEditEditorStoreModel();
            editorStoreModel2.editSessionUid = guid;
            editorStoreModel2.userId = userId;
            editorStoreModel2.userName = userName;
            editorStoreModel2.parentObjectId = parentObjectId;
            editorStoreModel2.parentObjectName = parentObjectName;
            editorStoreModel2.objectId = objectId;
            editorStoreModel2.objectName = objectName;
            editorStoreModel2.openTime = DateTime.Now;
            dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
            editorStoreModel2.openTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(-1598106783 - -968262081 ^ -629917760));
            editorStoreModel2.publishTime = new DateTime?(DateTime.Now);
            dateTime = DateTime.Now;
            editorStoreModel2.publishTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(901793403 ^ 901850265));
            editorStoreModel2.saveTime = new DateTime?();
            editorStoreModel2.saveTimeStr = string.Empty;
            editorStoreModel2.savedAfter = false;
            editorStoreModel2.lastActivityTime = DateTime.Now;
            dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
            editorStoreModel2.lastActivityTimeStr = dateTime.ToString((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(1669212571 ^ 1669286777));
            editorStoreModel1 = editorStoreModel2;
            num1 = 19;
            continue;
          case 12:
            if (MultiEditService.B9PJaaBmakCpfNbGQGlK((object) source) > 1)
            {
              num1 = 3;
              continue;
            }
            goto case 9;
          case 13:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 14:
            editorStoreModel1 = (MultiEditEditorStoreModel) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 15 : 12;
            continue;
          case 15:
            guid = MultiEditService.kcaT0HBmpDbNQDVkvwav();
            num1 = 11;
            continue;
          case 17:
label_2:
            source = source.Where<MultiEditEditorStoreModel>((Func<MultiEditEditorStoreModel, bool>) (w => !sessionsToDelete.Contains(w.editSessionUid))).ToList<MultiEditEditorStoreModel>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 12 : 0;
            continue;
          case 18:
            sessionsToDelete = new List<Guid>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 20 : 20;
            continue;
          case 19:
            if (!this.Cache.TryGetValue<List<MultiEditEditorStoreModel>>(key, out source))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
              continue;
            }
            goto case 13;
          case 20:
            enumerator = source.GetEnumerator();
            num1 = 7;
            continue;
          default:
            source.Add(editorStoreModel1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 18;
            continue;
        }
      }
label_13:
      return true;
    }

    private MultiEditEditorStoreModel PingAndGetCurrentSoleEditor(
      string objectId,
      string objectName,
      long parentObjectId,
      string parentObjectName,
      long userId,
      string userName,
      string sessionPrefix,
      long sessionLifeTime,
      Guid editSessionUid,
      bool selfKick,
      bool saveChanges)
    {
      int num1 = 22;
      MultiEditEditorStoreModel currentSoleEditor;
      while (true)
      {
        int num2 = num1;
        DateTime dateTime;
        TimeSpan cacheDuration;
        string key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              currentSoleEditor.lastActivityTime = dateTime;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 14 : 2;
              continue;
            case 2:
              dateTime = MultiEditService.baynqFBmOdDpss30YnNI();
              num2 = 17;
              continue;
            case 3:
              this.Cache.Insert<MultiEditEditorStoreModel>(key, currentSoleEditor, cacheDuration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 18;
              continue;
            case 4:
              currentSoleEditor.SaveChanges = selfKick & saveChanges;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 9 : 7;
              continue;
            case 5:
            case 19:
              if (currentSoleEditor != null)
              {
                num2 = 23;
                continue;
              }
              goto case 20;
            case 6:
              currentSoleEditor.openTime = dateTime;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 1;
              continue;
            case 7:
              if (!MultiEditService.TjK9U9Bm2IECiO7gOuDC(dateTime.Subtract(currentSoleEditor.lastActivityTime), cacheDuration))
              {
                num2 = 19;
                continue;
              }
              goto case 16;
            case 8:
            case 13:
            case 14:
              this.Cache.Insert<MultiEditEditorStoreModel>(key, currentSoleEditor, cacheDuration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 12;
              continue;
            case 9:
              if (!MultiEditService.Abo8Q4BmDgLgvGaYjmyq(currentSoleEditor.editSessionUid, editSessionUid))
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 10:
              currentSoleEditor.editSessionUid = editSessionUid;
              num2 = 6;
              continue;
            case 11:
              if (selfKick)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 4 : 10;
                continue;
              }
              goto case 4;
            case 12:
            case 18:
              goto label_26;
            case 15:
              currentSoleEditor = new MultiEditEditorStoreModel()
              {
                editSessionUid = editSessionUid,
                userId = userId,
                userName = userName,
                parentObjectId = parentObjectId,
                parentObjectName = parentObjectName,
                objectName = objectName,
                openTime = dateTime,
                lastActivityTime = dateTime
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 1;
              continue;
            case 16:
              currentSoleEditor = (MultiEditEditorStoreModel) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 5;
              continue;
            case 17:
              if (this.Cache.TryGetValue<MultiEditEditorStoreModel>(key, out currentSoleEditor))
                goto case 7;
              else
                goto label_16;
            case 20:
              currentSoleEditor = new MultiEditEditorStoreModel()
              {
                editSessionUid = editSessionUid,
                userId = userId,
                userName = userName,
                parentObjectId = parentObjectId,
                parentObjectName = parentObjectName,
                objectName = objectName,
                openTime = dateTime,
                lastActivityTime = dateTime
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 13 : 1;
              continue;
            case 21:
              key = (string) MultiEditService.hhH8p9BmNPTqqPMm1rD3(MultiEditService.AS6opCBmnbTpJdcDxOs0(-1217523399 ^ -1217477677), (object) sessionPrefix, (object) objectId);
              num2 = 2;
              continue;
            case 22:
              cacheDuration = MultiEditService.xuWlGaBmkWmaLYMDVLnF((double) sessionLifeTime);
              num2 = 21;
              continue;
            default:
              if (currentSoleEditor.userId == userId)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 4 : 11;
                continue;
              }
              goto case 8;
          }
        }
label_16:
        num1 = 15;
      }
label_26:
      return currentSoleEditor;
    }

    private bool FinishObjectSoleEditSession(
      string objectId,
      string objectName,
      long userId,
      string sessionPrefix)
    {
      int num = 2;
      string key;
      MultiEditEditorStoreModel editorStoreModel;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Cache.TryGetValue<MultiEditEditorStoreModel>(key, out editorStoreModel))
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 2:
            key = string.Format((string) MultiEditService.AS6opCBmnbTpJdcDxOs0(1917256330 ^ 1917309024), (object) sessionPrefix, (object) objectId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
          case 3:
            if (editorStoreModel.userId == userId)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 4:
            goto label_3;
          default:
            this.Cache.Remove(key);
            num = 4;
            continue;
        }
      }
label_3:
      return true;
    }

    public MultiEditService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QA0jTwBmXI44SjlDmMxA() => MultiEditService.mn7A9NBmK0KBGAi5dHRE == null;

    internal static MultiEditService IYODAsBmT5BsxCh8ZV6X() => MultiEditService.mn7A9NBmK0KBGAi5dHRE;

    internal static TimeSpan xuWlGaBmkWmaLYMDVLnF([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static object AS6opCBmnbTpJdcDxOs0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime baynqFBmOdDpss30YnNI() => DateTime.Now;

    internal static bool TjK9U9Bm2IECiO7gOuDC([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 > obj1;

    internal static bool mUtcRnBmeCVbp3Kc9a09([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void qcCXjhBmPAE3Nn89Bcmt([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool AbC5nqBm1R0TP02CqPGX([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static object hhH8p9BmNPTqqPMm1rD3([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void NwE2jsBm3YjDjLM3Aahg([In] object obj0, [In] object obj1) => ((ICacheService) obj0).Remove((string) obj1);

    internal static Guid kcaT0HBmpDbNQDVkvwav() => Guid.NewGuid();

    internal static int B9PJaaBmakCpfNbGQGlK([In] object obj0) => ((List<MultiEditEditorStoreModel>) obj0).Count;

    internal static bool Abo8Q4BmDgLgvGaYjmyq([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
