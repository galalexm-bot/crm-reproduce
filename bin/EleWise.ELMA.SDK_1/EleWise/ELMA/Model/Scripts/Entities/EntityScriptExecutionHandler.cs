// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityScriptExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Scripts.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Выполнение скриптов сущностей</summary>
  [Component]
  internal sealed class EntityScriptExecutionHandler : IScriptExecutionHandler
  {
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private readonly IEntityScriptingService entityScriptingService;
    private readonly ViewModelDescriptor viewModelDescriptor;
    private readonly IEqlPropertiesService eqlPropertiesService;
    private readonly ISecurityService securityService;
    private static EntityScriptExecutionHandler dZLsXcbeC2r5MwH2chmp;

    /// <summary>Ctor</summary>
    /// <param name="metadataRuntimeService">Сервис метаданных в режиме Runtime</param>
    /// <param name="entityScriptingService">Сервис исполнения скриптов сущностей</param>
    /// <param name="viewModelDescriptor">Дескриптор ViewModel</param>
    /// <param name="eqlPropertiesService">Сервис для работы с свойствами объекта, вычисляемыми через EQL</param>
    /// <param name="securityService">Интерфейс проверки привилегий пользователя</param>
    public EntityScriptExecutionHandler(
      IMetadataRuntimeService metadataRuntimeService,
      IEntityScriptingService entityScriptingService,
      ViewModelDescriptor viewModelDescriptor,
      IEqlPropertiesService eqlPropertiesService,
      ISecurityService securityService)
    {
      EntityScriptExecutionHandler.w6jAIebeZ684FUVCuNAP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.securityService = securityService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            this.entityScriptingService = entityScriptingService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 5 : 4;
            continue;
          case 3:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 2;
            continue;
          case 4:
            this.eqlPropertiesService = eqlPropertiesService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
            continue;
          case 5:
            this.viewModelDescriptor = viewModelDescriptor;
            num = 4;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    /// <inheritdoc />
    public bool Check(ScriptExecutionParams parameters) => EntityScriptExecutionHandler.IZS14WbeI2NDr4wYfRqr(EntityScriptExecutionHandler.E6I9GnbeuPq8CyMK4U8V((object) parameters)) == EntityMetadata.UID;

    /// <inheritdoc />
    public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
    {
      int num1 = 40;
      IEnumerator<PropertyViewInfo> enumerator1;
      IEntity entity;
      object item;
      PropertyViewInfoContainer propertyContainer;
      DataClass viewModelContext;
      while (true)
      {
        int num2 = num1;
        string str1;
        string str2;
        string str3;
        EntityMetadata entityMetadata1;
        ScriptExecutionParams parameters1;
        Type entityType;
        while (true)
        {
          DataClassMetadata dataClassMetadata1;
          Assembly assembly;
          Type viewModelContextType;
          string name1;
          EntityMetadata entityMetadata2;
          EntityMetadata entityMetadata3;
          ScriptMethodInfo scriptMethodInfo;
          Dictionary<string, object> parameters2;
          Guid guid;
          string scriptName;
          List<Guid>.Enumerator enumerator2;
          PropertyMetadata propertyMetadata;
          object obj1;
          object obj2;
          EntityScriptExecutionHandler executionHandler;
          Type viewModelType;
          switch (num2)
          {
            case 1:
              if (!string.IsNullOrWhiteSpace(entityMetadata2.ScriptModuleTypeName))
              {
                obj1 = EntityScriptExecutionHandler.YjkXBSbeOkMWIQ2E5WKw((object) ((IEnumerable<string>) EntityScriptExecutionHandler.PxWjELbenwiKRDZr48Lb(EntityScriptExecutionHandler.l5vEAJbekrDThQ1aM9gr((object) entityMetadata2), (object) new char[1]
                {
                  ','
                })).First<string>());
                break;
              }
              goto label_14;
            case 2:
              name1 = str2 + (string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(372753449 ^ 372581563);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 13 : 34;
              continue;
            case 3:
              obj2 = EntityScriptExecutionHandler.sJuVPJbeTUgb3HNtnsHa((object) entityMetadata2);
              goto label_112;
            case 4:
              obj1 = (object) ((string) EntityScriptExecutionHandler.zZrv90beKZTNRZlONPyE((object) entityMetadata2) + (string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(-16752921 ^ -16597349) + (string) EntityScriptExecutionHandler.sJuVPJbeTUgb3HNtnsHa((object) entityMetadata2) + (string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(-1638402543 ^ -1638488817));
              break;
            case 5:
            case 52:
              scriptName = (string) EntityScriptExecutionHandler.N4L7Z1be6ebpUQkrtXjw((object) scriptMethodInfo);
              num2 = 41;
              continue;
            case 6:
              assembly = (Assembly) EntityScriptExecutionHandler.DXlKdjbeq86rgHLF2cNg((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199928971), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
              continue;
            case 7:
              EntityScriptExecutionHandler.wudbcDbe44WlK28cpVUW((object) scriptMethodInfo, guid);
              num2 = 5;
              continue;
            case 8:
            case 14:
            case 22:
            case 47:
              parameters2 = new Dictionary<string, object>();
              num2 = 45;
              continue;
            case 9:
            case 11:
            case 58:
              if (dataClassMetadata1 != null)
              {
                num2 = 6;
                continue;
              }
              goto label_20;
            case 10:
              dataClassMetadata1 = (DataClassMetadata) EntityScriptExecutionHandler.RMTrLAbeSBLE0MrPwiRp((object) entityMetadata2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 3 : 60;
              continue;
            case 12:
label_9:
              if (entity == null)
              {
                num2 = 35;
                continue;
              }
              goto case 55;
            case 13:
            case 15:
              if (entityMetadata3.ImplementedExtensionUids != null)
              {
                num2 = 51;
                continue;
              }
              goto case 49;
            case 16:
              obj2 = (object) entityMetadata1.Name;
              goto label_112;
            case 17:
              scriptMethodInfo = (ScriptMethodInfo) EntityScriptExecutionHandler.Ssu2QebeDH795uoexbLS(EntityScriptExecutionHandler.Wx30LibeNVorWTHWn1PD((object) parameters1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 17 : 48;
              continue;
            case 18:
              entity = (IEntity) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 63 : 61;
              continue;
            case 19:
              goto label_41;
            case 20:
              dataClassMetadata1 = entityMetadata3.ViewModelMetadata;
              num2 = 37;
              continue;
            case 21:
              viewModelContext = this.DeserializeViewModelContext(parameters1.Model, dataClassMetadata1, viewModelContextType) as DataClass;
              num2 = 61;
              continue;
            case 23:
              goto label_114;
            case 24:
              goto label_20;
            case 25:
              entityMetadata2 = (EntityMetadata) this.metadataRuntimeService.GetMetadata(guid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 10;
              continue;
            case 26:
              enumerator1 = propertyContainer.GetAll().GetEnumerator();
              num2 = 19;
              continue;
            case 27:
              executionHandler = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 18 : 18;
              continue;
            case 28:
              if (!((string) EntityScriptExecutionHandler.Wx30LibeNVorWTHWn1PD((object) parameters1) == (string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(--1418440330 ^ 1418422576)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 17 : 46;
                continue;
              }
              goto label_114;
            case 29:
              if (!((string) EntityScriptExecutionHandler.X6MOBbbewpuuhnnUkBha((object) scriptMethodInfo)).Contains((string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(1149433385 + 173655049 ^ 1323071892)))
              {
                num2 = 7;
                continue;
              }
              goto case 5;
            case 30:
            case 62:
              if (dataClassMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 15;
                continue;
              }
              goto case 9;
            case 31:
              if (EntityScriptExecutionHandler.RMTrLAbeSBLE0MrPwiRp((object) entityMetadata3) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 20;
                continue;
              }
              goto case 30;
            case 32:
              entity = viewModelContext.GetObject(EntityScriptExecutionHandler.MU94oBbep3dJlV0iDPrg((object) dataClassMetadata1), EntityScriptExecutionHandler.MU94oBbep3dJlV0iDPrg((object) propertyMetadata)) as IEntity;
              num2 = 8;
              continue;
            case 33:
              if (entityMetadata1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 11 : 16;
                continue;
              }
              goto case 3;
            case 34:
              viewModelType = assembly.GetType(name1);
              num2 = 57;
              continue;
            case 35:
            case 54:
              goto label_40;
            case 36:
              try
              {
label_61:
                if (enumerator2.MoveNext())
                  goto label_69;
                else
                  goto label_62;
label_60:
                Guid current;
                int num3;
                while (true)
                {
                  DataClassMetadata dataClassMetadata2;
                  switch (num3)
                  {
                    case 1:
                      entityMetadata1 = this.metadataRuntimeService.GetMetadata(current, false) as EntityMetadata;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 3;
                      continue;
                    case 2:
                      dataClassMetadata2 = (DataClassMetadata) null;
                      break;
                    case 3:
                      if (entityMetadata1 != null)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 2;
                    case 4:
                      dataClassMetadata2 = entityMetadata1.ViewModelMetadata;
                      break;
                    case 5:
                    case 8:
                      goto label_16;
                    case 6:
                      dataClassMetadata1 = (DataClassMetadata) EntityScriptExecutionHandler.RMTrLAbeSBLE0MrPwiRp((object) entityMetadata1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 9 : 5;
                      continue;
                    case 7:
                      goto label_69;
                    case 9:
                      entityMetadata2 = entityMetadata3;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 5 : 0;
                      continue;
                    default:
                      goto label_61;
                  }
                  if (dataClassMetadata2 != null)
                    num3 = 6;
                  else
                    goto label_61;
                }
label_62:
                num3 = 8;
                goto label_60;
label_69:
                current = enumerator2.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                {
                  num3 = 0;
                  goto label_60;
                }
                else
                  goto label_60;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 37:
              entityMetadata2 = entityMetadata3;
              num2 = 9;
              continue;
            case 38:
              entityMetadata3 = entityMetadata2;
              num2 = 62;
              continue;
            case 39:
              parameters1 = parameters;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 27 : 21;
              continue;
            case 40:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 39 : 28;
              continue;
            case 41:
              item = (object) null;
              num2 = 59;
              continue;
            case 42:
              guid = EntityScriptExecutionHandler.dT3wWebeVOBJrfBmh8h1(EntityScriptExecutionHandler.E6I9GnbeuPq8CyMK4U8V((object) parameters1));
              num2 = 53;
              continue;
            case 43:
              this.eqlPropertiesService.SetEqlComputedProperties(viewModelContext, dataClassMetadata1, ((IEnumerable<SerializedModel>) parameters1.AdditionalModels).Select<SerializedModel, SerializedModel>((Func<SerializedModel, SerializedModel>) (s =>
              {
                SerializedModel serializedModel = new SerializedModel();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                EntityScriptExecutionHandler.\u003C\u003Ec.AusFvPCpJ6alvjPG4D8u((object) serializedModel, EntityScriptExecutionHandler.\u003C\u003Ec.iSyVVQCpMqhq1mdevheF((object) s));
                // ISSUE: reference to a compiler-generated method
                serializedModel.Name = (string) EntityScriptExecutionHandler.\u003C\u003Ec.neX6oRCp9qGhb7qyR3Ye((object) s);
                return serializedModel;
              })).ToList<SerializedModel>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 28 : 22;
              continue;
            case 44:
              viewModelContextType = EntityScriptExecutionHandler.PUAAhfbeeKKtKEIF3sjN((object) assembly, (object) str1);
              num2 = 64;
              continue;
            case 45:
              propertyContainer = (PropertyViewInfoContainer) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 17 : 10;
              continue;
            case 46:
              List<PropertyMetadata> properties = dataClassMetadata1.Properties;
              // ISSUE: reference to a compiler-generated field
              Predicate<PropertyMetadata> predicate = EntityScriptExecutionHandler.\u003C\u003Ec.\u003C\u003E9__7_3;
              Predicate<PropertyMetadata> match;
              if (predicate == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                EntityScriptExecutionHandler.\u003C\u003Ec.\u003C\u003E9__7_3 = match = (Predicate<PropertyMetadata>) (a => EntityScriptExecutionHandler.\u003C\u003Ec.DILvFACplK3Lll1qyryR(EntityScriptExecutionHandler.\u003C\u003Ec.bHMJtTCpdQvhkjiYJTt8((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210743921)));
              }
              else
                goto label_118;
label_117:
              propertyMetadata = properties.Find(match);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 15 : 32;
              continue;
label_118:
              match = predicate;
              goto label_117;
            case 48:
              if (!EntityScriptExecutionHandler.sfq9AUbeihqNIP3L7Eo9(EntityScriptExecutionHandler.pIFbYYbet5mOjnGlCGmK((object) scriptMethodInfo), Guid.Empty))
              {
                num2 = 52;
                continue;
              }
              goto case 29;
            case 49:
label_16:
              if (EntityScriptExecutionHandler.sfq9AUbeihqNIP3L7Eo9(entityMetadata3.BaseClassUid, Guid.Empty))
              {
                num2 = 11;
                continue;
              }
              goto case 56;
            case 50:
              goto label_6;
            case 51:
              enumerator2 = entityMetadata3.ImplementedExtensionUids.GetEnumerator();
              num2 = 36;
              continue;
            case 53:
              entityType = this.metadataRuntimeService.GetTypeByUid(guid);
              num2 = 25;
              continue;
            case 55:
              if (propertyContainer != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 26 : 11;
                continue;
              }
              goto label_40;
            case 56:
              entityMetadata3 = (EntityMetadata) this.metadataRuntimeService.GetMetadata(EntityScriptExecutionHandler.qR5XKkbeRpAxGQYOEkYj((object) entityMetadata3));
              num2 = 31;
              continue;
            case 57:
              if (!(viewModelType != (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 19 : 22;
                continue;
              }
              goto case 33;
            case 59:
              try
              {
                this.entityScriptingService.ExecuteScript(entity, scriptName, parameters2, (Func<string, Type, object>) ((name, type) =>
                {
                  int num5 = 19;
                  // ISSUE: variable of a compiler-generated type
                  EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_1 cDisplayClass71;
                  while (true)
                  {
                    int num6 = num5;
                    // ISSUE: variable of a compiler-generated type
                    EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_2 cDisplayClass72;
                    string json;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          goto label_3;
                        case 2:
                          goto label_6;
                        case 3:
                          goto label_22;
                        case 5:
                          // ISSUE: reference to a compiler-generated field
                          cDisplayClass71.type = type;
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 7 : 4;
                          continue;
                        case 6:
                          goto label_11;
                        case 7:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (!EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_0.P1Yt0lCpNHmrXWLJQGuY((object) name, EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_0.M9B5SoCp1dmiSZvMwVUB(1021410165 ^ 1021432587)))
                            goto case 9;
                          else
                            goto label_18;
                        case 8:
                        case 11:
                          goto label_26;
                        case 9:
                          if (name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146528059))
                          {
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 16 : 6;
                            continue;
                          }
                          goto label_22;
                        case 10:
                          // ISSUE: reference to a compiler-generated field
                          cDisplayClass72.CS\u0024\u003C\u003E8__locals2 = cDisplayClass71;
                          num6 = 17;
                          continue;
                        case 12:
                          // ISSUE: reference to a compiler-generated method
                          if (!EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_0.wHKrHDCppgWBXKsPXwGI((object) json))
                          {
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass72.deserialized = new EntityJsonSerializer().DeserializeJson(json);
                            num6 = 14;
                            continue;
                          }
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
                          continue;
                        case 13:
                          // ISSUE: reference to a compiler-generated field
                          viewModelType = cDisplayClass71.type;
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                          continue;
                        case 14:
                          // ISSUE: reference to a compiler-generated method
                          executionHandler.securityService.RunWithElevatedPrivilegiesAndWithDeleted(new System.Action(cDisplayClass72.\u003CExecuteScript\u003Eb__4));
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 4 : 6;
                          continue;
                        case 15:
                          if (item == null)
                          {
                            num6 = 4;
                            continue;
                          }
                          goto case 13;
                        case 16:
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated method
                          if (!EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_0.XFNdArCpasV3TZiYKvU9(cDisplayClass71.type))
                          {
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 14 : 15;
                            continue;
                          }
                          goto label_6;
                        case 17:
                          // ISSUE: reference to a compiler-generated method
                          json = (string) EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_0.fdW3bKCp35ryhabMx4Ho((object) parameters1);
                          num6 = 12;
                          continue;
                        case 18:
                          // ISSUE: reference to a compiler-generated field
                          cDisplayClass71.CS\u0024\u003C\u003E8__locals1 = this;
                          num6 = 5;
                          continue;
                        case 19:
                          // ISSUE: object of a compiler-generated type is created
                          cDisplayClass71 = new EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_1();
                          num6 = 18;
                          continue;
                        default:
                          goto label_21;
                      }
                    }
label_18:
                    num5 = 8;
                    continue;
label_26:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass72 = new EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_2();
                    num5 = 10;
                  }
label_3:
                  return (object) null;
label_6:
                  // ISSUE: reference to a compiler-generated field
                  return EntityScriptExecutionHandler.ProcessLegacySignature(cDisplayClass71.type, (object) null, out propertyContainer);
label_11:
                  return item;
label_21:
                  // ISSUE: reference to a compiler-generated field
                  return EntityScriptExecutionHandler.ProcessV2Signature(cDisplayClass71.type, (object) null, viewModelType, (object) viewModelContext, out propertyContainer);
label_22:
                  return (object) null;
                }));
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    goto label_9;
                }
              }
              catch (Exception ex)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                  num8 = 0;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_103;
                    default:
                      ((ILogger) EntityScriptExecutionHandler.vLjRGhbeHBK8L8l7hA74()).Error((object) EleWise.ELMA.SR.T((string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(-244066886 - -48452443 ^ -195704385), (object) scriptName), ex);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_103:
                throw;
              }
            case 60:
              goto label_31;
            case 61:
              if (EntityScriptExecutionHandler.UWT8S3be1ylFNG7Ksg1n((object) viewModelContext, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 43 : 2;
                continue;
              }
              goto case 8;
            case 63:
              viewModelType = (Type) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            case 64:
              if (EntityScriptExecutionHandler.vf2vi1bePyl37SekLM73(viewModelContextType, (Type) null))
                goto case 21;
              else
                goto label_86;
            default:
              viewModelContext = (DataClass) null;
              num2 = 42;
              continue;
          }
          str2 = (string) obj1;
          num2 = 2;
          continue;
label_112:
          str3 = (string) obj2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 50 : 47;
        }
label_6:
        str1 = (string) EntityScriptExecutionHandler.Ybg2N0be25He7QUh9mx5((object) str2, EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(-1852837372 ^ -1852850726), (object) str3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345245200));
        num1 = 44;
        continue;
label_14:
        num1 = 4;
        continue;
label_20:
        EntityScriptExecutionHandler.KuXJ8MbeaSwr7ErTLOEU((object) this.securityService, (object) (System.Action) (() =>
        {
          int num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                entity = new EntityJsonSerializer().Deserialize((string) EntityScriptExecutionHandler.\u003C\u003Ec__DisplayClass7_0.KkAElwCpPMLhQKtNeNC4((object) parameters1), entityType, true) as IEntity;
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        num1 = 14;
        continue;
label_31:
        entityMetadata1 = (EntityMetadata) null;
        num1 = 38;
        continue;
label_86:
        num1 = 47;
      }
label_40:
      ScriptExecutionResult scriptExecutionResult1 = new ScriptExecutionResult();
      scriptExecutionResult1.Model = (object) viewModelContext;
      scriptExecutionResult1.Item = item;
      EntityScriptExecutionHandler.B9wSI0beyLlY7y6ibQ7x((object) scriptExecutionResult1, (object) propertyContainer);
      return scriptExecutionResult1;
label_41:
      try
      {
label_45:
        if (EntityScriptExecutionHandler.hUDML3be0wCqvPYROjVT((object) enumerator1))
          goto label_49;
        else
          goto label_46;
label_42:
        PropertyViewInfo current;
        TypeSettings typeSettings;
        int num10;
        while (true)
        {
          switch (num10)
          {
            case 1:
              EntityScriptExecutionHandler.r3VBC0bex4RREowiKJgw((object) current, (object) typeSettings);
              num10 = 4;
              continue;
            case 2:
              typeSettings = (TypeSettings) EntityScriptExecutionHandler.Fxc9OCbe7KcXqJ5v1mJm((object) entity, EntityScriptExecutionHandler.boRhECbeAdoPADLWP18N((object) current));
              num10 = 6;
              continue;
            case 3:
              goto label_49;
            case 4:
            case 5:
              goto label_45;
            case 6:
              if (typeSettings == null)
              {
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 5 : 3;
                continue;
              }
              goto case 1;
            default:
              goto label_40;
          }
        }
label_46:
        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
        goto label_42;
label_49:
        current = enumerator1.Current;
        num10 = 2;
        goto label_42;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
            num11 = 0;
          while (true)
          {
            switch (num11)
            {
              case 1:
                goto label_55;
              default:
                EntityScriptExecutionHandler.zrDNP1bem4oed9U8BfUB((object) enumerator1);
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_55:;
      }
label_114:
      ScriptExecutionResult scriptExecutionResult2 = new ScriptExecutionResult();
      EntityScriptExecutionHandler.j052GTbe3s1DHMB3dGRb((object) scriptExecutionResult2, (object) viewModelContext);
      return scriptExecutionResult2;
    }

    private object DeserializeViewModelContext(
      string model,
      DataClassMetadata viewModelContextMetadata,
      Type viewModelContextType)
    {
      int num1 = 2;
      ExpandoObject expandoObject;
      Type type;
      EntityScriptExecutionHandler executionHandler;
      IActionExecutionParamModel functionRequest;
      ClassMetadata requestMetadata;
      PropertyMetadata paramPropertyMetadata;
      Dictionary<string, object> dict;
      while (true)
      {
        switch (num1)
        {
          case 1:
            executionHandler = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 6;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
            continue;
          case 3:
            requestMetadata = new ClassMetadata();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 7 : 6;
            continue;
          case 4:
            dict = new Dictionary<string, object>()
            {
              {
                (string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(-1088304168 ^ -1088195926),
                (object) expandoObject
              }
            };
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 8 : 8;
            continue;
          case 5:
            functionRequest = (IActionExecutionParamModel) Activator.CreateInstance(type);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 3;
            continue;
          case 6:
            // ISSUE: type reference
            type = EntityScriptExecutionHandler.Gp0YxEbeMWyLbEekJt4x(__typeref (ActionExecutionParamModel<>)).MakeGenericType(viewModelContextType);
            num1 = 5;
            continue;
          case 7:
            PropertyMetadata propertyMetadata = new PropertyMetadata();
            propertyMetadata.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576053546);
            propertyMetadata.TypeUid = EntityScriptExecutionHandler.y65TL6beJVNIfpHNjocR((object) this.viewModelDescriptor);
            propertyMetadata.SubTypeUid = EntityScriptExecutionHandler.MU94oBbep3dJlV0iDPrg((object) viewModelContextMetadata);
            propertyMetadata.Settings = (TypeSettings) new DataClassSettings()
            {
              RelationType = RelationType.OneToOne
            };
            paramPropertyMetadata = propertyMetadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 8:
            EntityScriptExecutionHandler.KuXJ8MbeaSwr7ErTLOEU((object) this.securityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    executionHandler.viewModelDescriptor.Deserialize((object) functionRequest, requestMetadata, paramPropertyMetadata, (IDictionary<string, object>) dict);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 9;
            continue;
          case 9:
            goto label_5;
          default:
            expandoObject = new JsonSerializer().Deserialize<ExpandoObject>(model);
            num1 = 4;
            continue;
        }
      }
label_5:
      return functionRequest.Parameter;
    }

    /// <summary>Обработать сигнатуру легаси метода</summary>
    /// <example>
    /// <![CDATA[
    /// Пример сигнатуры:
    /// public virtual void TestOnChange (ITestObject entity, EleWise.ELMA.Model.Views.FormViewBuilder<ITestObject> form)
    /// ]]>
    /// </example>
    private static object ProcessLegacySignature(
      Type type,
      object form,
      out PropertyViewInfoContainer propertyContainer)
    {
      int num = 1;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            classMetadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) as ClassMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            propertyContainer = new PropertyViewInfoContainer(classMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:
      return EntityScriptExecutionHandler.uhxSNZbe9JGtFvTb62pt(type, (object) new object[3]
      {
        form,
        (object) classMetadata,
        (object) propertyContainer
      });
    }

    private static object ProcessV2Signature(
      Type type,
      object form,
      Type viewModelType,
      object viewModelContext,
      out PropertyViewInfoContainer propertyContainer)
    {
      int num1 = 7;
      object obj;
      ClassMetadata classMetadata;
      while (true)
      {
        int num2 = num1;
        Type baseType;
        Type type1;
        System.Reflection.PropertyInfo property;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertyContainer = new PropertyViewInfoContainer(classMetadata);
              num2 = 10;
              continue;
            case 2:
              if (obj == null)
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 4:
              goto label_6;
            case 5:
              type1 = EntityScriptExecutionHandler.vklIKCbe5tYVvIde0UNc((object) property);
              num2 = 9;
              continue;
            case 6:
              baseType = type.BaseType;
              num2 = 13;
              continue;
            case 7:
              propertyContainer = (PropertyViewInfoContainer) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 6 : 6;
              continue;
            case 8:
              property = type.GetProperty((string) EntityScriptExecutionHandler.hRZTpqbeX2sKkA4251Ed(-244066886 - -48452443 ^ -195597039), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
              num2 = 12;
              continue;
            case 9:
              obj = ((DataClass) viewModelContext).As(type1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
              continue;
            case 10:
              if (!EntityScriptExecutionHandler.FM6F1AbedCoJfIIofaUZ(type, viewModelType))
              {
                num2 = 8;
                continue;
              }
              goto label_21;
            case 11:
              if (EntityScriptExecutionHandler.CheckParameterType(baseType))
              {
                num2 = 14;
                continue;
              }
              goto label_13;
            case 12:
              goto label_23;
            case 13:
              if (EntityScriptExecutionHandler.FM6F1AbedCoJfIIofaUZ(baseType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 3 : 0;
                continue;
              }
              goto case 11;
            case 14:
              if (EntityScriptExecutionHandler.LgjVJcbelqtEwqRebb4w(viewModelContext, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                continue;
              }
              classMetadata = MetadataLoader.LoadMetadata(baseType.GetGenericArguments()[0]) as ClassMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
              continue;
            case 15:
              goto label_21;
            default:
              goto label_13;
          }
        }
label_23:
        if (EntityScriptExecutionHandler.xEFXVlbegr7bSoMRtsaX((object) property, (object) null))
          num1 = 5;
        else
          goto label_8;
      }
label_6:
      return (object) null;
label_7:
      return EntityScriptExecutionHandler.DWU3CcberL2FgDdqTpZL(type, obj, form, (object) classMetadata, (object) propertyContainer);
label_8:
      return (object) null;
label_13:
      return (object) null;
label_21:
      return EntityScriptExecutionHandler.DWU3CcberL2FgDdqTpZL(type, viewModelContext, form, (object) classMetadata, (object) propertyContainer);
    }

    private static bool CheckParameterType(Type parameterType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameterType.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return parameterType.GetGenericTypeDefinition() == EntityScriptExecutionHandler.Gp0YxEbeMWyLbEekJt4x(__typeref (FormViewBuilder<>));
label_3:
      return false;
    }

    private static object CreateViewModelInstance(
      Type viewModelType,
      object viewModelContext,
      object form,
      object formItemMetadata,
      object propertyContainer)
    {
      ConstructorInfo[] constructors = viewModelType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      // ISSUE: reference to a compiler-generated field
      Predicate<ConstructorInfo> predicate = EntityScriptExecutionHandler.\u003C\u003Ec.\u003C\u003E9__12_0;
      Predicate<ConstructorInfo> match;
      if (predicate == null)
      {
        // ISSUE: reference to a compiler-generated field
        EntityScriptExecutionHandler.\u003C\u003Ec.\u003C\u003E9__12_0 = match = (Predicate<ConstructorInfo>) (ctorInfo => ctorInfo.GetParameters().Length == 4);
      }
      else
        goto label_1;
label_3:
      return EntityScriptExecutionHandler.DWMGGAbejBq6JBdq7nl1((object) Array.Find<ConstructorInfo>(constructors, match), (object) new object[4]
      {
        viewModelContext,
        form,
        formItemMetadata,
        propertyContainer
      });
label_1:
      match = predicate;
      goto label_3;
    }

    internal static void w6jAIebeZ684FUVCuNAP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GmHx5LbevZ2gb5WBA09a() => EntityScriptExecutionHandler.dZLsXcbeC2r5MwH2chmp == null;

    internal static EntityScriptExecutionHandler A8J2UAbe8UNFnPJ7eZP7() => EntityScriptExecutionHandler.dZLsXcbeC2r5MwH2chmp;

    internal static object E6I9GnbeuPq8CyMK4U8V([In] object obj0) => (object) ((ScriptExecutionParams) obj0).ModelInfo;

    internal static Guid IZS14WbeI2NDr4wYfRqr([In] object obj0) => ((ModelInfo) obj0).TypeUid;

    internal static Guid dT3wWebeVOBJrfBmh8h1([In] object obj0) => ((ModelInfo) obj0).SubTypeUid;

    internal static object RMTrLAbeSBLE0MrPwiRp([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static bool sfq9AUbeihqNIP3L7Eo9([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid qR5XKkbeRpAxGQYOEkYj([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object DXlKdjbeq86rgHLF2cNg([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object zZrv90beKZTNRZlONPyE([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static object hRZTpqbeX2sKkA4251Ed(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sJuVPJbeTUgb3HNtnsHa([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object l5vEAJbekrDThQ1aM9gr([In] object obj0) => (object) ((ClassMetadata) obj0).ScriptModuleTypeName;

    internal static object PxWjELbenwiKRDZr48Lb([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object YjkXBSbeOkMWIQ2E5WKw([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object Ybg2N0be25He7QUh9mx5(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static Type PUAAhfbeeKKtKEIF3sjN([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static bool vf2vi1bePyl37SekLM73([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool UWT8S3be1ylFNG7Ksg1n([In] object obj0, [In] object obj1) => (DataClass) obj0 != (DataClass) obj1;

    internal static object Wx30LibeNVorWTHWn1PD([In] object obj0) => (object) ((ScriptExecutionParams) obj0).ScriptName;

    internal static void j052GTbe3s1DHMB3dGRb([In] object obj0, [In] object obj1) => ((ScriptExecutionResult) obj0).Model = obj1;

    internal static Guid MU94oBbep3dJlV0iDPrg([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void KuXJ8MbeaSwr7ErTLOEU([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegiesAndWithDeleted((System.Action) obj1);

    internal static object Ssu2QebeDH795uoexbLS([In] object obj0) => (object) ScriptMethodInfoHelper.Deserialize((string) obj0);

    internal static Guid pIFbYYbet5mOjnGlCGmK([In] object obj0) => ((ScriptMethodInfo) obj0).MetadataUid;

    internal static object X6MOBbbewpuuhnnUkBha([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static void wudbcDbe44WlK28cpVUW([In] object obj0, Guid value) => ((ScriptMethodInfo) obj0).MetadataUid = value;

    internal static object N4L7Z1be6ebpUQkrtXjw([In] object obj0) => (object) ScriptMethodInfoHelper.Serialize((ScriptMethodInfo) obj0);

    internal static object vLjRGhbeHBK8L8l7hA74() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static Guid boRhECbeAdoPADLWP18N([In] object obj0) => ((PropertyViewInfo) obj0).Uid;

    internal static object Fxc9OCbe7KcXqJ5v1mJm([In] object obj0, Guid propertyUid) => (object) ((IEntity) obj0).LoadPropertyInstanceSettings(propertyUid);

    internal static void r3VBC0bex4RREowiKJgw([In] object obj0, [In] object obj1) => ((PropertyViewInfo) obj0).Settings = (TypeSettings) obj1;

    internal static bool hUDML3be0wCqvPYROjVT([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void zrDNP1bem4oed9U8BfUB([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void B9wSI0beyLlY7y6ibQ7x([In] object obj0, [In] object obj1) => ((ScriptExecutionResult) obj0).PropertyContainer = (PropertyViewInfoContainer) obj1;

    internal static Type Gp0YxEbeMWyLbEekJt4x([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid y65TL6beJVNIfpHNjocR([In] object obj0) => ((TypeDescriptor) obj0).Uid;

    internal static object uhxSNZbe9JGtFvTb62pt([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

    internal static bool FM6F1AbedCoJfIIofaUZ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool LgjVJcbelqtEwqRebb4w([In] object obj0, [In] object obj1) => (DataClass) obj0 == (DataClass) obj1;

    internal static object DWU3CcberL2FgDdqTpZL(
      Type viewModelType,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return EntityScriptExecutionHandler.CreateViewModelInstance(viewModelType, obj1, obj2, obj3, obj4);
    }

    internal static bool xEFXVlbegr7bSoMRtsaX([In] object obj0, [In] object obj1) => (System.Reflection.PropertyInfo) obj0 != (System.Reflection.PropertyInfo) obj1;

    internal static Type vklIKCbe5tYVvIde0UNc([In] object obj0) => ((System.Reflection.PropertyInfo) obj0).PropertyType;

    internal static object DWMGGAbejBq6JBdq7nl1([In] object obj0, [In] object obj1) => ((ConstructorInfo) obj0).Invoke((object[]) obj1);
  }
}
