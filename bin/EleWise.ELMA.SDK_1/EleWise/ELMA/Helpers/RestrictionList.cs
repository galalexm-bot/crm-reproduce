// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RestrictionList
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  internal class RestrictionList : List<Restriction>
  {
    internal bool nHibernate;
    private static RestrictionList Hv4B3Qhc2B8oVLybfrQH;

    internal bool CloneRecursive
    {
      get => this.\u003CCloneRecursive\u003Ek__BackingField;
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
              this.\u003CCloneRecursive\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    private bool IsType(object obj, RuleType ruleType)
    {
      int num1 = 2;
      RuleType ruleType1;
      object obj1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ruleType1 = ruleType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 5 : 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
            continue;
          case 3:
          case 4:
            goto label_5;
          case 5:
            obj1 = obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 6:
            obj1 = RestrictionList.Pc0s8NhcNGc8lkwCqT96(RestrictionList.LFU5g0hc16Gp47ZcumHs((object) (INHibernateProxy) obj1));
            num1 = 4;
            continue;
          default:
            if (!obj1.IsProxy())
            {
              num1 = 3;
              continue;
            }
            goto case 6;
        }
      }
label_5:
      return this.Any<Restriction>((Func<Restriction, bool>) (r =>
      {
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (!RestrictionList.\u003C\u003Ec__DisplayClass5_0.M5kdWDvM2QNEM7bXCGlK(r.ObjectType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (RestrictionList.\u003C\u003Ec__DisplayClass5_0.CrttEavMOka4OV3hIZqU((object) r) == ruleType1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 2;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return RestrictionList.\u003C\u003Ec__DisplayClass5_0.OZjAm0vMeFkxZt60PHw5((object) r).IsInstanceOfType(obj1);
label_5:
        return false;
      }));
    }

    public bool IsTypeIgnore(object obj) => this.IsType(obj, RuleType.Ignore);

    public bool IsTypeByRef(object obj) => this.IsType(obj, RuleType.CopyByRef);

    public bool IsTypeSaveRef(object obj) => this.IsType(obj, RuleType.SaveRef);

    public bool IsTypeClone(object obj) => this.IsType(obj, RuleType.Clone);

    public bool IsTypeAction(object obj) => this.IsType(obj, RuleType.Action);

    public CopyAction Action(object obj, object propertyValue)
    {
      int num1 = 1;
      Restriction restriction;
      object propertyValue1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            case 2:
              if (propertyValue1.IsProxy())
              {
                num2 = 7;
                continue;
              }
              goto label_3;
            case 3:
              goto label_3;
            case 4:
              if (restriction == null)
              {
                num2 = 5;
                continue;
              }
              goto label_5;
            case 5:
              goto label_6;
            case 6:
              goto label_5;
            case 7:
              propertyValue1 = ((ILazyInitializer) RestrictionList.LFU5g0hc16Gp47ZcumHs((object) (INHibernateProxy) propertyValue1)).GetImplementation();
              num2 = 3;
              continue;
            default:
              propertyValue1 = propertyValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
              continue;
          }
        }
label_3:
        restriction = this.FirstOrDefault<Restriction>((Func<Restriction, bool>) (r =>
        {
          int num3 = 2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (RestrictionList.\u003C\u003Ec__DisplayClass11_0.FcCoHsvMalhouU7f75Kr(r.ObjectType, (Type) null))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (RestrictionList.\u003C\u003Ec__DisplayClass11_0.NIhFjgvMpF40sjGlZjYb((object) r) == RuleType.Action)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                  continue;
                }
                goto label_7;
              default:
                goto label_6;
            }
          }
label_6:
          // ISSUE: reference to a compiler-generated method
          return RestrictionList.\u003C\u003Ec__DisplayClass11_0.UZof7FvMD1SBawnIPAiS((object) r).IsInstanceOfType(propertyValue1);
label_7:
          return false;
        }));
        num1 = 4;
      }
label_5:
      return restriction.Action(obj, propertyValue1);
label_6:
      return CopyAction.Default;
    }

    private bool IsProperty(string propertyName, Type objectType, RuleType ruleType)
    {
      int num1 = 4;
      RuleType ruleType1;
      string propertyName1;
      Type objectType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            propertyName1 = propertyName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            ruleType1 = ruleType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 1;
            continue;
          default:
            objectType1 = objectType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      return this.Any<Restriction>((Func<Restriction, bool>) (r =>
      {
        int num2 = 5;
        while (true)
        {
          int num3 = num2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (RestrictionList.\u003C\u003Ec__DisplayClass12_0.fKPBImvM0GO3rL3n5eZG(RestrictionList.\u003C\u003Ec__DisplayClass12_0.bIwcjCvMxbgIgi7IiIXC((object) r), (Type) null))
                {
                  num3 = 2;
                  continue;
                }
                goto label_5;
              case 2:
                goto label_6;
              case 3:
                goto label_7;
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!RestrictionList.\u003C\u003Ec__DisplayClass12_0.C13MkrvM7gSXwLlgTKNc(RestrictionList.\u003C\u003Ec__DisplayClass12_0.IGDJR3vMAX3EZjEu6cTa((object) r), (object) propertyName1))
                {
                  num3 = 3;
                  continue;
                }
                goto case 1;
              case 5:
                goto label_8;
              default:
                goto label_5;
            }
          }
label_8:
          // ISSUE: reference to a compiler-generated method
          if (RestrictionList.\u003C\u003Ec__DisplayClass12_0.KXM02svMHRdBsuWDeCVM((object) r) == ruleType1)
            num2 = 4;
          else
            goto label_7;
        }
label_5:
        return r.ParentType.IsAssignableFrom(objectType1);
label_6:
        return true;
label_7:
        return false;
      }));
    }

    private bool IsProperty(
      string propertyName,
      Type objectType,
      CollectionUpdateMode collectionUpdateMode)
    {
      int num1 = 2;
      CollectionUpdateMode collectionUpdateMode1;
      string propertyName1;
      Type objectType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            collectionUpdateMode1 = collectionUpdateMode;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            objectType1 = objectType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 0;
            continue;
          default:
            propertyName1 = propertyName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 3 : 4;
            continue;
        }
      }
label_3:
      return this.Any<Restriction>((Func<Restriction, bool>) (r =>
      {
        int num2 = 2;
        while (true)
        {
          int num3 = num2;
          CollectionUpdateMode? collectionUpdateMode2;
          CollectionUpdateMode collectionUpdateMode3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                collectionUpdateMode3 = collectionUpdateMode1;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 4;
                continue;
              case 2:
                collectionUpdateMode2 = r.CollectionUpdateMode;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                continue;
              case 3:
                goto label_7;
              case 4:
                if (collectionUpdateMode2.GetValueOrDefault() == collectionUpdateMode3 & collectionUpdateMode2.HasValue)
                {
                  num3 = 7;
                  continue;
                }
                goto label_13;
              case 5:
                goto label_12;
              case 6:
                goto label_11;
              case 7:
                if (!(r.PropertyName == propertyName1))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              default:
                goto label_13;
            }
          }
label_7:
          // ISSUE: reference to a compiler-generated method
          if (RestrictionList.\u003C\u003Ec__DisplayClass13_0.Hf8aA6vM9JM30w3fAsn2((object) r) == (Type) null)
            num2 = 5;
          else
            break;
        }
label_11:
        return r.ParentType.IsAssignableFrom(objectType1);
label_12:
        return true;
label_13:
        return false;
      }));
    }

    public bool IsPropertyIgnore(PropertyInfo propertyInfo, Type objectType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_14;
          case 2:
            if (!this.nHibernate)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
              continue;
            }
            goto case 9;
          case 4:
            if (RestrictionList.OwQoD0hcaV9IFypeHMFM(RestrictionList.Bwng9Ahc3HTmnGkG0qS4((object) propertyInfo), typeof (Guid)))
            {
              num = 7;
              continue;
            }
            goto label_14;
          case 5:
            if ((string) RestrictionList.PxX05MhcD7mbTiPJkn66((object) propertyInfo) == (string) RestrictionList.w8gxpIhctlmKjgoc2RwJ(92412609 - 1050237057 ^ -957856994))
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 6:
          case 8:
            goto label_15;
          case 7:
            if ((string) RestrictionList.PxX05MhcD7mbTiPJkn66((object) propertyInfo) == (string) RestrictionList.w8gxpIhctlmKjgoc2RwJ(44884861 ^ 44862703))
            {
              num = 6;
              continue;
            }
            goto label_14;
          case 9:
            // ISSUE: type reference
            if (!(RestrictionList.Bwng9Ahc3HTmnGkG0qS4((object) propertyInfo) == RestrictionList.pn88bnhcpKubyABYBpnq(__typeref (long))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          default:
            // ISSUE: type reference
            if (RestrictionList.OwQoD0hcaV9IFypeHMFM(propertyInfo.PropertyType, RestrictionList.pn88bnhcpKubyABYBpnq(__typeref (int))))
            {
              num = 5;
              continue;
            }
            goto case 4;
        }
      }
label_14:
      return this.IsProperty(propertyInfo.Name, objectType, RuleType.Ignore);
label_15:
      return true;
    }

    public bool IsPropertyByRef(PropertyInfo propertyInfo, Type objectType) => this.IsProperty((string) RestrictionList.PxX05MhcD7mbTiPJkn66((object) propertyInfo), objectType, RuleType.CopyByRef);

    public bool IsPropertySaveRef(PropertyInfo propertyInfo, Type objectType) => this.IsProperty((string) RestrictionList.PxX05MhcD7mbTiPJkn66((object) propertyInfo), objectType, RuleType.SaveRef);

    public bool IsPropertyClone(PropertyInfo propertyInfo, Type objectType) => this.IsProperty((string) RestrictionList.PxX05MhcD7mbTiPJkn66((object) propertyInfo), objectType, RuleType.Clone);

    public bool IsPropertyAction(PropertyInfo propertyInfo, Type objectType) => this.IsProperty((string) RestrictionList.PxX05MhcD7mbTiPJkn66((object) propertyInfo), objectType, RuleType.Action);

    public CopyAction PropertyAction(
      string propertyName,
      Type objectType,
      object obj,
      object propertyValue)
    {
      int num1 = 5;
      Restriction restriction;
      string propertyName1;
      Type objectType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            objectType1 = objectType;
            num1 = 3;
            continue;
          case 2:
            goto label_6;
          case 3:
            restriction = this.FirstOrDefault<Restriction>((Func<Restriction, bool>) (r =>
            {
              int num2 = 4;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (RestrictionList.\u003C\u003Ec__DisplayClass19_0.Sg3O6pvMLOOuJnmZo287(r.ParentType, (Type) null))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_6;
                  case 2:
                    goto label_6;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (RestrictionList.\u003C\u003Ec__DisplayClass19_0.pweTywvMY9frPvt6HB0N(RestrictionList.\u003C\u003Ec__DisplayClass19_0.qurV8qvMjHZjws5qXHfU((object) r), (object) propertyName1))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_8;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    if (RestrictionList.\u003C\u003Ec__DisplayClass19_0.K5V7uxvM5bkx2guUFYBS((object) r) == RuleType.Action)
                    {
                      num2 = 3;
                      continue;
                    }
                    goto label_8;
                  default:
                    goto label_7;
                }
              }
label_6:
              // ISSUE: reference to a compiler-generated method
              return RestrictionList.\u003C\u003Ec__DisplayClass19_0.yR2gAsvMUDaWn3FNs0qs((object) r).IsAssignableFrom(objectType1);
label_7:
              return true;
label_8:
              return false;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 4:
            propertyName1 = propertyName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 4;
            continue;
          default:
            if (restriction != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return restriction.Action(obj, propertyValue);
label_7:
      return CopyAction.Default;
    }

    public bool IsAllPropertiesIgnore(Type objectType) => this.IsProperty((string) null, objectType, RuleType.Ignore);

    public bool IsAllPropertiesByRef(Type objectType) => this.IsProperty((string) null, objectType, RuleType.CopyByRef);

    public bool IsAllPropertiesSaveRef(Type objectType) => this.IsProperty((string) null, objectType, RuleType.SaveRef);

    public bool IsAllPropertiesClone(Type objectType) => this.IsProperty((string) null, objectType, RuleType.Clone);

    public bool IsAllPropertiesAction(Type objectType) => this.IsProperty((string) null, objectType, RuleType.Action);

    public CollectionUpdateMode GetCollectionUpdateMode(PropertyInfo propertyInfo)
    {
      int num1 = 2;
      CollectionUpdateMode? collectionUpdateMode1;
      Restriction matchingCollectionRule;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (matchingCollectionRule != null)
            {
              num1 = 6;
              continue;
            }
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated field
            Func<Restriction, bool> func = RestrictionList.\u003C\u003Ec.\u003C\u003E9__25_0;
            Func<Restriction, bool> f;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              RestrictionList.\u003C\u003Ec.\u003C\u003E9__25_0 = f = (Func<Restriction, bool>) (r =>
              {
                int num2 = 1;
                CollectionUpdateMode? collectionUpdateMode2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      collectionUpdateMode2 = r.CollectionUpdateMode;
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return collectionUpdateMode2.HasValue;
              });
            }
            else
              goto label_13;
label_12:
            matchingCollectionRule = this.GetMatchingCollectionRule(f, propertyInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
label_13:
            f = func;
            goto label_12;
          case 3:
            if (!collectionUpdateMode1.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 4:
            collectionUpdateMode1 = matchingCollectionRule.CollectionUpdateMode;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 5 : 4;
            continue;
          case 5:
            goto label_2;
          case 6:
            collectionUpdateMode1 = matchingCollectionRule.CollectionUpdateMode;
            num1 = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return collectionUpdateMode1.Value;
label_3:
      return CollectionUpdateMode.Match;
    }

    public Comparer GetComparer(PropertyInfo propertyInfo)
    {
      int num = 1;
      Restriction matchingCollectionRule;
      while (true)
      {
        switch (num)
        {
          case 1:
            matchingCollectionRule = this.GetMatchingCollectionRule((Func<Restriction, bool>) (r => r.CompareFunction != null), propertyInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            if (matchingCollectionRule.CompareFunction == null)
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 3:
          case 4:
            // ISSUE: type reference
            if (!((IEnumerable<object>) RestrictionList.LTqFp9hcwpxrvfGXai0F((object) propertyInfo, RestrictionList.pn88bnhcpKubyABYBpnq(__typeref (TablePartPropertyAttribute)), false)).Any<object>())
            {
              num = 5;
              continue;
            }
            goto label_7;
          case 5:
            goto label_6;
          default:
            if (matchingCollectionRule == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 3;
              continue;
            }
            goto case 2;
        }
      }
label_6:
      return (Comparer) null;
label_7:
      return (Comparer) new BlockComparer();
label_8:
      return new Comparer(matchingCollectionRule.CompareFunction);
    }

    private Restriction GetMatchingCollectionRule(
      Func<Restriction, bool> f,
      PropertyInfo propertyInfo)
    {
      // ISSUE: reference to a compiler-generated method
      List<Restriction> list = this.Where<Restriction>(f).Where<Restriction>((Func<Restriction, bool>) (r => RestrictionList.\u003C\u003Ec.rWyi8rvJBkeDrDurQdiA((object) r) == RuleType.Collection)).ToList<Restriction>();
      return list.FirstOrDefault<Restriction>((Func<Restriction, bool>) (r => r.PropertyName == propertyInfo.Name)) ?? list.FirstOrDefault<Restriction>((Func<Restriction, bool>) (r =>
      {
        int num = 2;
        Type c;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_4;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (!RestrictionList.\u003C\u003Ec__DisplayClass27_0.zpMhFEvJf0qcDIlV7cmc(r.ObjectType, (Type) null))
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                c = RestrictionList.\u003C\u003Ec__DisplayClass27_0.IbA5hevJCmnXmMKugwAt(RestrictionList.\u003C\u003Ec__DisplayClass27_0.QTeMRsvJQwmU7uRyeueR((object) propertyInfo));
                num = 3;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (!RestrictionList.\u003C\u003Ec__DisplayClass27_0.VlnFJnvJvddBwimhqJ22(c, (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 4:
              goto label_6;
            default:
              goto label_7;
          }
        }
label_4:
        return false;
label_6:
        // ISSUE: reference to a compiler-generated method
        return RestrictionList.\u003C\u003Ec__DisplayClass27_0.TpxL7GvJ89H8LQTvjhpi((object) r).IsAssignableFrom(c);
label_7:
        return false;
      })) ?? list.FirstOrDefault<Restriction>((Func<Restriction, bool>) (r =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (RestrictionList.\u003C\u003Ec.tLgdfXvJWIfcYACqH1V8((object) r) != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return RestrictionList.\u003C\u003Ec.bYHwsUvJo0UpAJrZDwjE(r.ObjectType, (Type) null);
label_3:
        return false;
      }));
    }

    public RestrictionList()
    {
      RestrictionList.GkITUFhc40ct8q0e282E();
      this.nHibernate = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool P6GlPghcesVA9XWpyeOk() => RestrictionList.Hv4B3Qhc2B8oVLybfrQH == null;

    internal static RestrictionList W74JmehcPwpaGhwfOBRp() => RestrictionList.Hv4B3Qhc2B8oVLybfrQH;

    internal static object LFU5g0hc16Gp47ZcumHs([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static object Pc0s8NhcNGc8lkwCqT96([In] object obj0) => ((ILazyInitializer) obj0).GetImplementation();

    internal static Type Bwng9Ahc3HTmnGkG0qS4([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type pn88bnhcpKubyABYBpnq([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool OwQoD0hcaV9IFypeHMFM([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object PxX05MhcD7mbTiPJkn66([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object w8gxpIhctlmKjgoc2RwJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object LTqFp9hcwpxrvfGXai0F([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static void GkITUFhc40ct8q0e282E() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
