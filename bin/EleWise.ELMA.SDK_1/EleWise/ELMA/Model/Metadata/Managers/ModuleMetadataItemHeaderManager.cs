// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.ModuleMetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер заголовков метаданных модулей</summary>
  internal class ModuleMetadataItemHeaderManager : EntityManager<ModuleMetadataItemHeader, long>
  {
    /// <summary>Уникальный идентификатор модуля КИ</summary>
    internal static Guid BuilderUiModuleUid;
    /// <summary>Идентификаторы метаданных модулей дизайнера</summary>
    internal static readonly ISet<Guid> DesignerModules;
    /// <summary>Имя пакета веб-дизайнера по дефолту</summary>
    internal static string WebDesignerPackageName;
    private static ModuleMetadataItemHeaderManager TjUbUdbziSrM4hcjtu1g;

    /// <summary>Экземпляр менеджера</summary>
    public static ModuleMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<ModuleMetadataItemHeaderManager>();

    /// <summary>Проверить идентификатор модуля</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="name">Идентификатор модуля</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateName(long headerId, string name, out string errorMessage) => this.ValidateName((ICriterion) ModuleMetadataItemHeaderManager.AVNM1ubzKmV0xXHXHNDp((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Id, (object) headerId), name, out errorMessage);

    /// <summary>Проверить идентификатор модуля</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="name">Идентификатор модуля</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage) => this.ValidateName((ICriterion) ModuleMetadataItemHeaderManager.AVNM1ubzKmV0xXHXHNDp((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), name, out errorMessage);

    /// <summary>Проверить отображаемое имя модуля</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="displayName">Отображаемое имя модуля</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateDisplayName(
      long headerId,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) ModuleMetadataItemHeaderManager.AVNM1ubzKmV0xXHXHNDp((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Id, (object) headerId), displayName, out errorMessage);
    }

    /// <summary>Проверить отображаемое имя модуля</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="displayName">Отображаемое имя модуля</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateDisplayName(
      Guid headerUid,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) ModuleMetadataItemHeaderManager.AVNM1ubzKmV0xXHXHNDp((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), displayName, out errorMessage);
    }

    /// <summary>
    /// Получить список всех опубликованных заголовков модулей
    /// </summary>
    /// <returns>Список всех опубликованных заголовков модулей</returns>
    public IEnumerable<ModuleMetadataItemHeader> GetAllPublished() => (IEnumerable<ModuleMetadataItemHeader>) this.CreateCriteria(new FetchOptions(0, 0)
    {
      FetchRelations = new List<string>()
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77798037),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979516546)
      }
    }, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(ModuleMetadataItemHeaderManager._Resources_PropertyNames.Published)).List<ModuleMetadataItemHeader>();

    /// <inheritdoc />
    public override void Delete(ModuleMetadataItemHeader obj)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              base.Delete(obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              ((ICriteria) ModuleMetadataItemHeaderManager.B5WZJ4bznTpTCkYUCQFe(ModuleMetadataItemHeaderManager.eTCja1bzXV4arygsEWTP((object) this.Session, InterfaceActivator.TypeOf<FunctionMetadataItemHeader>()), (object) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901826423), (object) obj.Uid))).List<FunctionMetadataItemHeader>().ForEach<FunctionMetadataItemHeader>((Action<FunctionMetadataItemHeader>) (h => ModuleMetadataItemHeaderManager.\u003C\u003Ec.YJZG7PCJkD8HZcEZTCwb((object) h)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
            case 3:
              IList<DataClassMetadataItemHeader> enumeration1 = ((ICriteria) ModuleMetadataItemHeaderManager.B5WZJ4bznTpTCkYUCQFe((object) this.Session.CreateCriteria(InterfaceActivator.TypeOf<DataClassMetadataItemHeader>()), ModuleMetadataItemHeaderManager.AVNM1ubzKmV0xXHXHNDp(ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1426456882 ^ 2009939514 ^ -583777800), (object) ModuleMetadataItemHeaderManager.IGDVMsbzk0junhH6KAoA((object) obj)))).List<DataClassMetadataItemHeader>();
              // ISSUE: reference to a compiler-generated field
              Action<DataClassMetadataItemHeader> action1 = ModuleMetadataItemHeaderManager.\u003C\u003Ec.\u003C\u003E9__7_1;
              Action<DataClassMetadataItemHeader> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ModuleMetadataItemHeaderManager.\u003C\u003Ec.\u003C\u003E9__7_1 = action2 = (Action<DataClassMetadataItemHeader>) (h => ModuleMetadataItemHeaderManager.\u003C\u003Ec.YJZG7PCJkD8HZcEZTCwb((object) h));
              }
              else
                goto label_13;
label_11:
              enumeration1.ForEach<DataClassMetadataItemHeader>(action2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 2;
              continue;
label_13:
              action2 = action1;
              goto label_11;
            case 4:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        IList<ComponentMetadataItemHeader> enumeration2 = ((ICriteria) ModuleMetadataItemHeaderManager.B5WZJ4bznTpTCkYUCQFe(ModuleMetadataItemHeaderManager.eTCja1bzXV4arygsEWTP((object) this.Session, InterfaceActivator.TypeOf<ComponentMetadataItemHeader>()), ModuleMetadataItemHeaderManager.AVNM1ubzKmV0xXHXHNDp(ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-2112703338 ^ -2112735846), (object) ModuleMetadataItemHeaderManager.IGDVMsbzk0junhH6KAoA((object) obj)))).List<ComponentMetadataItemHeader>();
        // ISSUE: reference to a compiler-generated field
        Action<ComponentMetadataItemHeader> action3 = ModuleMetadataItemHeaderManager.\u003C\u003Ec.\u003C\u003E9__7_0;
        Action<ComponentMetadataItemHeader> action4;
        if (action3 == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          ModuleMetadataItemHeaderManager.\u003C\u003Ec.\u003C\u003E9__7_0 = action4 = (Action<ComponentMetadataItemHeader>) (h => ModuleMetadataItemHeaderManager.\u003C\u003Ec.YJZG7PCJkD8HZcEZTCwb((object) h));
        }
        else
          goto label_14;
label_7:
        enumeration2.ForEach<ComponentMetadataItemHeader>(action4);
        num1 = 3;
        continue;
label_14:
        action4 = action3;
        goto label_7;
      }
label_9:
      return;
label_5:;
    }

    protected virtual bool ValidateName(
      ICriterion compareCriterion,
      string name,
      out string errorMessage)
    {
      int num = 10;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_12;
          case 3:
            goto label_10;
          case 4:
            errorMessage = (string) ModuleMetadataItemHeaderManager.g1O1e4bzesqeKHjJq42v(ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(222162814 ^ 222107618));
            num = 2;
            continue;
          case 5:
            if (ModuleMetadataItemHeaderManager.dskXLdbzOYn4AGh8ZTxn((object) name))
            {
              num = 6;
              continue;
            }
            if (ModuleMetadataItemHeaderManager.qX1aKrbz2giBGYPPqPwT((object) name))
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 6:
            errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488852847));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
            continue;
          case 7:
            goto label_8;
          case 8:
            if (ModuleMetadataItemHeaderManager.qXpqd1bztHNh1XgBejup(ModuleMetadataItemHeaderManager.oyEAUZbzDVlveuj76AM2(ModuleMetadataItemHeaderManager.sS8I6nbza7xx9juVas6B(ModuleMetadataItemHeaderManager.B5WZJ4bznTpTCkYUCQFe((object) ((ICriteria) ModuleMetadataItemHeaderManager.vtF25ebzPW5sADjofuI6((object) this, (object) null)).Add((ICriterion) ModuleMetadataItemHeaderManager.Og4AyJbz1XAh5L2b3U9C((object) compareCriterion)), ModuleMetadataItemHeaderManager.iHsmuwbz34LdTlaGPkwX(ModuleMetadataItemHeaderManager.BrXv75bzNPjQlbtb6RVp((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Name), (object) name)), (object) new IProjection[1]
            {
              (IProjection) ModuleMetadataItemHeaderManager.YW79labzpeomysiqaM2A((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Id)
            }))) > 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 9:
            errorMessage = (string) null;
            num = 5;
            continue;
          case 10:
            Contract.ArgumentNotNull((object) compareCriterion, (string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-2138160520 ^ -2138131634));
            num = 9;
            continue;
          default:
            errorMessage = (string) ModuleMetadataItemHeaderManager.g1O1e4bzesqeKHjJq42v((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124706036));
            num = 7;
            continue;
        }
      }
label_5:
      return false;
label_8:
      return false;
label_10:
      return true;
label_12:
      return false;
    }

    protected virtual bool ValidateDisplayName(
      ICriterion compareCriterion,
      string displayName,
      out string errorMessage)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            errorMessage = (string) ModuleMetadataItemHeaderManager.g1O1e4bzesqeKHjJq42v(ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(~-122002947 ^ 121990336));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 7;
            continue;
          case 2:
            goto label_8;
          case 3:
            if (string.IsNullOrEmpty(displayName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            if (ModuleMetadataItemHeaderManager.qXpqd1bztHNh1XgBejup(((ICriteria) ModuleMetadataItemHeaderManager.sS8I6nbza7xx9juVas6B(ModuleMetadataItemHeaderManager.B5WZJ4bznTpTCkYUCQFe(ModuleMetadataItemHeaderManager.B5WZJ4bznTpTCkYUCQFe(ModuleMetadataItemHeaderManager.vtF25ebzPW5sADjofuI6((object) this, (object) null), ModuleMetadataItemHeaderManager.Og4AyJbz1XAh5L2b3U9C((object) compareCriterion)), (object) ElmaRestrictions.InsensitiveLike((IProjection) Projections.Property(ModuleMetadataItemHeaderManager._Resources_PropertyNames.DisplayName), (object) displayName)), (object) new IProjection[1]
            {
              (IProjection) ModuleMetadataItemHeaderManager.YW79labzpeomysiqaM2A((object) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Id)
            })).UniqueResult()) > 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          case 4:
            goto label_10;
          case 5:
            errorMessage = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 3;
            continue;
          case 6:
            ModuleMetadataItemHeaderManager.Xr4h2ObzwAP1QHiQkXBQ((object) compareCriterion, ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-2138160520 ^ -2138131634));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 5 : 0;
            continue;
          case 7:
            goto label_7;
          default:
            errorMessage = EleWise.ELMA.SR.T((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1822890472 ^ -1822944068));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 4;
            continue;
        }
      }
label_7:
      return false;
label_8:
      return true;
label_10:
      return false;
    }

    public ModuleMetadataItemHeaderManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ModuleMetadataItemHeaderManager()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ModuleMetadataItemHeaderManager.JOmM0kbz49kL1fcbEfLV();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              ModuleMetadataItemHeaderManager.WebDesignerPackageName = (string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(979449278 ^ 979511718);
              num2 = 4;
              continue;
            case 4:
              goto label_3;
            default:
              ModuleMetadataItemHeaderManager.BuilderUiModuleUid = new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-345420348 ^ -345357152));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 1;
              continue;
          }
        }
label_7:
        ModuleMetadataItemHeaderManager.DesignerModules = (ISet<Guid>) new HashSet<Guid>()
        {
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1598106783 - -968262081 ^ -629777262)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-787452571 ^ -787258215)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1253244298 - 1829393894 ^ -575951380)),
          ModuleMetadataItemHeaderManager.BuilderUiModuleUid,
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1204263869 ^ -1341583247 ^ 137526950)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(333888594 ^ 1075625116 ^ 1408829998)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1242972401 >> 4 ^ 77754147)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647845042)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1978478350 ^ -1978541258)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97903546)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195812023)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88055819)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(516838154 ^ 516775934)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1876063057 ^ -1876000273)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-345420348 ^ -345358264)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133109991)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1994213607 >> 4 ^ 124705450)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824455187)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1852837372 ^ -1853031240)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-87337865 ^ -87532673)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293881776)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-675505729 ^ -675310049)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105265138)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1255365154 ^ 596875508 ^ -1766052590)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1917998801 >> 2 ^ 479692080)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(272623989 ^ 272431525)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(516838154 ^ 516768278)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647843490)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-867826612 ^ -867887624)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1461825605 - 1531863589 ^ -70231008)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(~1767720452 ^ -1767789641)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1852837372 ^ -1853038436)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(~538519529 ^ -538588430)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1113862659 ^ 1114054963)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824450335)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(712480695 ^ 712279167)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1242972401 >> 4 ^ 77754395)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(95909607 + 343705423 ^ 439413334)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-420743386 ^ -420945014)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1120607109 - 305487170 ^ -1426287679)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1217523399 ^ -1217592195)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(~-306453669 ^ 306645300)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901993383)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108040650)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124699386)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(323422137 << 2 ^ 1293879332)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1142330761 ^ 1541959139 ^ 536735590)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011888039)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1199946765 ^ 1200008105)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1461625753 ^ 1461564521)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1052221104 - 768835541 ^ 283576039)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(979449278 ^ 979512630)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(901793403 ^ 901996207)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1426456882 ^ 2009939514 ^ -583542316)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(~541731958 ^ -541668635)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218556394)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099557037)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1710575414 ^ -1710642534)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1597012150 ^ 1597202986)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(1319452732 ^ 1319525076)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272429633)),
          new Guid((string) ModuleMetadataItemHeaderManager.FS84KubzTH5rP3C7P1RL(-1255365154 ^ 596875508 ^ -1766054230)),
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886448061))
        };
        num1 = 3;
      }
label_3:;
    }

    internal static object AVNM1ubzKmV0xXHXHNDp([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static bool PdHWunbzRwrW5tU0nN8i() => ModuleMetadataItemHeaderManager.TjUbUdbziSrM4hcjtu1g == null;

    internal static ModuleMetadataItemHeaderManager kEeE50bzq0rXIMpt4IgP() => ModuleMetadataItemHeaderManager.TjUbUdbziSrM4hcjtu1g;

    internal static object eTCja1bzXV4arygsEWTP([In] object obj0, [In] Type obj1) => (object) ((ISession) obj0).CreateCriteria(obj1);

    internal static object FS84KubzTH5rP3C7P1RL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid IGDVMsbzk0junhH6KAoA([In] object obj0) => ((ModuleMetadataItemHeader) obj0).Uid;

    internal static object B5WZJ4bznTpTCkYUCQFe([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static bool dskXLdbzOYn4AGh8ZTxn([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool qX1aKrbz2giBGYPPqPwT([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object g1O1e4bzesqeKHjJq42v([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object vtF25ebzPW5sADjofuI6([In] object obj0, [In] object obj1) => (object) ((EntityManager<ModuleMetadataItemHeader, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object Og4AyJbz1XAh5L2b3U9C([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object BrXv75bzNPjQlbtb6RVp([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object iHsmuwbz34LdTlaGPkwX([In] object obj0, [In] object obj1) => (object) ElmaRestrictions.InsensitiveLike((IProjection) obj0, obj1);

    internal static object YW79labzpeomysiqaM2A([In] object obj0) => (object) Projections.Count((string) obj0);

    internal static object sS8I6nbza7xx9juVas6B([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static object oyEAUZbzDVlveuj76AM2([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static long qXpqd1bztHNh1XgBejup([In] object obj0) => Convert.ToInt64(obj0);

    internal static void Xr4h2ObzwAP1QHiQkXBQ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void JOmM0kbz49kL1fcbEfLV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class _Resources_PropertyNames
    {
      public static readonly string Id;
      public static readonly string Uid;
      public static readonly string Name;
      public static readonly string DisplayName;
      public static readonly string CreationDate;
      public static readonly string CreationAuthorId;
      public static readonly string Draft;
      public static readonly string Published;
      internal static ModuleMetadataItemHeaderManager._Resources_PropertyNames k4eKqWCJV5tAgYrqPjCA;

      static _Resources_PropertyNames()
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_3;
              case 1:
                goto label_9;
              case 2:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.Published = (string) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Yh928jCJRUTitmm0b4ZJ(-1290212282 ^ -644262414 ^ 1787021102);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              case 3:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.Draft = (string) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Yh928jCJRUTitmm0b4ZJ(1232639661 >> 3 ^ 154124073);
                num2 = 2;
                continue;
              case 4:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.CreationAuthorId = (string) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Yh928jCJRUTitmm0b4ZJ(1574260816 ^ 1574414002);
                num2 = 3;
                continue;
              case 5:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.CreationDate = (string) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Yh928jCJRUTitmm0b4ZJ(1669212571 ^ 1669299253);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 4;
                continue;
              case 6:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.Id = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638434993);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                continue;
              case 7:
                TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
                num2 = 6;
                continue;
              case 8:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29233501);
                num2 = 9;
                continue;
              case 9:
                ModuleMetadataItemHeaderManager._Resources_PropertyNames.DisplayName = (string) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Yh928jCJRUTitmm0b4ZJ(-1710575414 ^ -1710733698);
                num2 = 5;
                continue;
              default:
                goto label_13;
            }
          }
label_9:
          ModuleMetadataItemHeaderManager._Resources_PropertyNames.Uid = (string) ModuleMetadataItemHeaderManager._Resources_PropertyNames.Yh928jCJRUTitmm0b4ZJ(-35995181 ^ -36000191);
          num1 = 8;
        }
label_3:
        return;
label_13:;
      }

      internal static object Yh928jCJRUTitmm0b4ZJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool pCC5tXCJSVXRIJASdFVS() => ModuleMetadataItemHeaderManager._Resources_PropertyNames.k4eKqWCJV5tAgYrqPjCA == null;

      internal static ModuleMetadataItemHeaderManager._Resources_PropertyNames mVPBmuCJifppBSiYty11() => ModuleMetadataItemHeaderManager._Resources_PropertyNames.k4eKqWCJV5tAgYrqPjCA;
    }
  }
}
