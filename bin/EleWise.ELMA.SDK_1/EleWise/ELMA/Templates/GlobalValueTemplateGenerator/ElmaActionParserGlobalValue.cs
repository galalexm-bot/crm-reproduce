// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GlobalValueTemplateGenerator.ElmaActionParserGlobalValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator
{
  /// <summary>
  /// Получение значения по текстовому представлению содержимого для действий сущностей
  /// </summary>
  [Component]
  public class ElmaActionParserGlobalValue : ElmaParserGlobalValue
  {
    private IRuntimeApplication _provider;
    private IEnumerable<IMetadata> _metadataList;
    private Func<IMetadata, bool> _metadataFilter;
    private string _enumE;
    private string _enumA;
    private static ElmaActionParserGlobalValue m09d2qBNOmlvqthZiCKE;

    /// <summary>Поиск среди действий (actions) сущности</summary>
    /// <param name="entityGuid"></param>
    /// <returns></returns>
    private Guid FindEntity(Guid entityGuid)
    {
      int num1 = 1;
      IEnumerator<IMetadata> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator1 = this._metadataList.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return Guid.Empty;
label_5:
      Guid entity1;
      try
      {
label_18:
        if (enumerator1.MoveNext())
          goto label_11;
        else
          goto label_19;
label_8:
        IMetadata current1;
        int num2;
        while (true)
        {
          int num3;
          EntityMetadata entityMetadata;
          Guid entity2;
          List<EnumValueMetadata>.Enumerator enumerator2;
          switch (num2)
          {
            case 1:
              try
              {
label_40:
                if (enumerator2.MoveNext())
                  goto label_33;
                else
                  goto label_41;
label_30:
                EnumValueMetadata current2;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (this._provider == null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 8;
                    case 3:
                      if (ElmaActionParserGlobalValue.L5eV74BN1ygeMG6twHTj(ElmaActionParserGlobalValue.xoF9QwBNaQUp7JqE97WG((object) current2), (object) this._enumA))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
                        continue;
                      }
                      goto label_40;
                    case 4:
                      goto label_33;
                    case 5:
                      if (current2 != null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 3 : 3;
                        continue;
                      }
                      goto label_40;
                    case 6:
                      goto label_4;
                    case 7:
                      entity1 = ElmaActionParserGlobalValue.AtPpgWBN3f38yA70oYj0((object) current2);
                      num4 = 6;
                      continue;
                    case 8:
                      if (ElmaActionParserGlobalValue.det8xCBNDwDqyhYFDFq9((object) this._provider) == null)
                      {
                        num4 = 10;
                        continue;
                      }
                      goto case 7;
                    case 9:
                      goto label_25;
                    default:
                      goto label_40;
                  }
                }
label_33:
                current2 = enumerator2.Current;
                num4 = 5;
                goto label_30;
label_41:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 9;
                goto label_30;
              }
              finally
              {
                enumerator2.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 2:
              if (entityMetadata != null)
              {
                num3 = 10;
                break;
              }
              goto label_18;
            case 3:
              if (!ElmaActionParserGlobalValue.maaSxPBNNlQcVheXglUh(entityGuid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 7;
                continue;
              }
              goto case 12;
            case 4:
              goto label_11;
            case 5:
              if (((EnumMetadata) ElmaActionParserGlobalValue.vLfqeUBNpYAHTmGvFPOI((object) entityMetadata)).Values != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 18 : 11;
                continue;
              }
              goto default;
            case 6:
              if (ElmaActionParserGlobalValue.L5eV74BN1ygeMG6twHTj((object) entityMetadata.Name, (object) this._enumE))
              {
                num2 = 19;
                continue;
              }
              goto case 3;
            case 7:
            case 15:
            case 17:
              goto label_18;
            case 8:
              goto label_4;
            case 9:
            case 19:
              if (ElmaActionParserGlobalValue.vLfqeUBNpYAHTmGvFPOI((object) entityMetadata) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 3 : 5;
                continue;
              }
              goto default;
            case 10:
              if (this._metadataFilter(current1))
              {
                num3 = 14;
                break;
              }
              goto label_18;
            case 11:
              goto label_3;
            case 12:
              if (ElmaActionParserGlobalValue.Amb9DQBNPplwVpRiEAe0(ElmaActionParserGlobalValue.AtPpgWBN3f38yA70oYj0((object) entityMetadata), entityGuid))
              {
                num2 = 9;
                continue;
              }
              goto label_18;
            case 13:
              if (ElmaActionParserGlobalValue.maaSxPBNNlQcVheXglUh(entity2, Guid.Empty))
              {
                num2 = 20;
                continue;
              }
              goto label_18;
            case 14:
              if (ElmaActionParserGlobalValue.Amb9DQBNPplwVpRiEAe0(entityGuid, Guid.Empty))
              {
                num2 = 6;
                continue;
              }
              goto case 3;
            case 16:
              entity2 = this.FindEntity(ElmaActionParserGlobalValue.M6xx1wBNtH9F2WRDoWLK((object) entityMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 13 : 7;
              continue;
            case 18:
              enumerator2 = ((EnumMetadata) ElmaActionParserGlobalValue.vLfqeUBNpYAHTmGvFPOI((object) entityMetadata)).Values.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            case 20:
              entity1 = entity2;
              num2 = 8;
              continue;
            case 21:
              entityMetadata = current1 as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 0;
              continue;
            default:
label_25:
              if (!ElmaActionParserGlobalValue.maaSxPBNNlQcVheXglUh(entityMetadata.BaseClassUid, Guid.Empty))
              {
                num2 = 15;
                continue;
              }
              goto case 16;
          }
          num2 = num3;
        }
label_11:
        current1 = enumerator1.Current;
        num2 = 16;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        {
          num2 = 21;
          goto label_8;
        }
        else
          goto label_8;
label_19:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 11 : 5;
        goto label_8;
      }
      finally
      {
        int num6;
        if (enumerator1 == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
        else
          goto label_58;
label_57:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_58:
        ElmaActionParserGlobalValue.CwxdWoBNw8NvdP3eZ4qk((object) enumerator1);
        num6 = 2;
        goto label_57;
      }
label_4:
      return entity1;
    }

    public override FormatedValue Parse(string[] propertyNames)
    {
      int num1 = 15;
      string str;
      while (true)
      {
        int num2 = num1;
        string enumA;
        IMetadataService metadataService;
        Guid entity;
        while (true)
        {
          switch (num2)
          {
            case 2:
              enumA = this._enumA;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 36 : 31;
              continue;
            case 3:
              this._enumE = propertyNames[1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 6 : 0;
              continue;
            case 4:
              if (!ElmaActionParserGlobalValue.L5eV74BN1ygeMG6twHTj((object) enumA, ElmaActionParserGlobalValue.s34YoeBNHGuxwQgsviIs(1470998129 - 231418599 ^ 1239562406)))
              {
                num2 = 21;
                continue;
              }
              goto label_18;
            case 5:
            case 35:
              goto label_42;
            case 6:
              this._enumA = propertyNames[2];
              num2 = 17;
              continue;
            case 7:
            case 13:
              str = (string) ElmaActionParserGlobalValue.R6Nw4qBN7xZJ2WcPf6VC((object) this, DefaultEntityActions.CreateGuid);
              num2 = 32;
              continue;
            case 8:
            case 18:
            case 30:
              goto label_43;
            case 9:
              if ((string) ElmaActionParserGlobalValue.Xi2lpuBN6HGHEQyjbEfe((object) propertyNames[0]) == (string) ElmaActionParserGlobalValue.s34YoeBNHGuxwQgsviIs(333888594 ^ 1075625116 ^ 1408964922))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 22 : 3;
                continue;
              }
              goto label_43;
            case 10:
              if (!ElmaActionParserGlobalValue.maaSxPBNNlQcVheXglUh(entity, Guid.Empty))
              {
                num2 = 35;
                continue;
              }
              goto case 26;
            case 11:
              str = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
              continue;
            case 12:
              goto label_12;
            case 14:
              if (((IEnumerable<string>) propertyNames).Count<string>() == 3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 20 : 20;
                continue;
              }
              goto label_43;
            case 15:
              if (propertyNames != null)
              {
                num2 = 14;
                continue;
              }
              goto label_43;
            case 16:
              if (!ElmaActionParserGlobalValue.L5eV74BN1ygeMG6twHTj((object) enumA, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146558697)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
                continue;
              }
              goto case 31;
            case 17:
              if (this._provider != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 19 : 6;
                continue;
              }
              goto label_27;
            case 19:
              metadataService = (IMetadataService) ElmaActionParserGlobalValue.fFsBVLBNAYpFfQfYyOqZ();
              num2 = 37;
              continue;
            case 20:
              if (ElmaActionParserGlobalValue.JT5129BN4FF5VDGXOboO((object) propertyNames[0]))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 5 : 8;
                continue;
              }
              goto case 9;
            case 21:
              if (!ElmaActionParserGlobalValue.L5eV74BN1ygeMG6twHTj((object) enumA, ElmaActionParserGlobalValue.s34YoeBNHGuxwQgsviIs(-1217523399 ^ -1217440995)))
              {
                num2 = 16;
                continue;
              }
              goto case 25;
            case 22:
              if (ElmaActionParserGlobalValue.JT5129BN4FF5VDGXOboO((object) propertyNames[1]))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 30 : 16;
                continue;
              }
              goto case 27;
            case 24:
              entity = this.FindEntity(Guid.Empty);
              num2 = 10;
              continue;
            case 25:
              str = (string) ElmaActionParserGlobalValue.R6Nw4qBN7xZJ2WcPf6VC((object) this, DefaultEntityActions.UpdateGuid);
              num2 = 23;
              continue;
            case 26:
              str = (string) ElmaActionParserGlobalValue.R6Nw4qBN7xZJ2WcPf6VC((object) this, entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 5 : 3;
              continue;
            case 27:
              if (string.IsNullOrWhiteSpace(propertyNames[2]))
              {
                num2 = 18;
                continue;
              }
              goto case 3;
            case 29:
              goto label_25;
            case 31:
              str = (string) ElmaActionParserGlobalValue.R6Nw4qBN7xZJ2WcPf6VC((object) this, DefaultEntityActions.ViewGuid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
              continue;
            case 33:
              goto label_18;
            case 34:
              goto label_27;
            case 36:
              if (ElmaActionParserGlobalValue.L5eV74BN1ygeMG6twHTj((object) enumA, ElmaActionParserGlobalValue.s34YoeBNHGuxwQgsviIs(-441065788 ^ -2092910478 ^ 1727341762)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 7 : 4;
                continue;
              }
              goto case 4;
            case 37:
              if (metadataService != null)
              {
                this._metadataList = metadataService.GetMetadataList();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 4 : 11;
                continue;
              }
              goto label_47;
            default:
              if (!ElmaActionParserGlobalValue.jbfFd9BNxlDVrnJEdO0e((object) str, (object) ""))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 24;
                continue;
              }
              goto label_25;
          }
        }
label_18:
        str = (string) ElmaActionParserGlobalValue.R6Nw4qBN7xZJ2WcPf6VC((object) this, DefaultEntityActions.DeleteGuid);
        num1 = 28;
        continue;
label_47:
        num1 = 12;
      }
label_12:
      return (FormatedValue) null;
label_25:
      FormatedValue formatedValue1 = new FormatedValue();
      ElmaActionParserGlobalValue.MpehZdBN0tdxCPGH0YsV((object) formatedValue1, (object) str);
      return formatedValue1;
label_27:
      return (FormatedValue) null;
label_42:
      FormatedValue formatedValue2 = new FormatedValue();
      ElmaActionParserGlobalValue.MpehZdBN0tdxCPGH0YsV((object) formatedValue2, (object) str);
      return formatedValue2;
label_43:
      return (FormatedValue) null;
    }

    public ElmaActionParserGlobalValue()
    {
      ElmaActionParserGlobalValue.bUDjqDBNmux3VwGI9Pcb();
      this._provider = Locator.GetServiceNotNull<IRuntimeApplication>();
      // ISSUE: reference to a compiler-generated field
      Func<IMetadata, bool> func1 = ElmaActionParserGlobalValue.\u003C\u003Ec.\u003C\u003E9__7_0;
      Func<IMetadata, bool> func2;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        ElmaActionParserGlobalValue.\u003C\u003Ec.\u003C\u003E9__7_0 = func2 = (Func<IMetadata, bool>) (m => m is EntityMetadata);
      }
      else
        goto label_7;
label_3:
      this._metadataFilter = func2;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
        case 0:
          return;
        default:
          return;
      }
label_7:
      func2 = func1;
      goto label_3;
    }

    internal static bool Amb9DQBNPplwVpRiEAe0([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool L5eV74BN1ygeMG6twHTj([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool maaSxPBNNlQcVheXglUh([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid AtPpgWBN3f38yA70oYj0([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object vLfqeUBNpYAHTmGvFPOI([In] object obj0) => (object) ((EntityMetadata) obj0).Actions;

    internal static object xoF9QwBNaQUp7JqE97WG([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object det8xCBNDwDqyhYFDFq9([In] object obj0) => (object) ((IRuntimeApplication) obj0).MainProvider;

    internal static Guid M6xx1wBNtH9F2WRDoWLK([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static void CwxdWoBNw8NvdP3eZ4qk([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool toOgoNBN28eoheRFW227() => ElmaActionParserGlobalValue.m09d2qBNOmlvqthZiCKE == null;

    internal static ElmaActionParserGlobalValue JXnJZGBNeBX4UtqxUOYk() => ElmaActionParserGlobalValue.m09d2qBNOmlvqthZiCKE;

    internal static bool JT5129BN4FF5VDGXOboO([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Xi2lpuBN6HGHEQyjbEfe([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object s34YoeBNHGuxwQgsviIs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fFsBVLBNAYpFfQfYyOqZ() => (object) MetadataServiceContext.ServiceOrNull;

    internal static object R6Nw4qBN7xZJ2WcPf6VC([In] object obj0, Guid guid) => (object) ((ElmaParserGlobalValue) obj0).ParseGuid(guid);

    internal static bool jbfFd9BNxlDVrnJEdO0e([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void MpehZdBN0tdxCPGH0YsV([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Value = obj1;

    internal static void bUDjqDBNmux3VwGI9Pcb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
