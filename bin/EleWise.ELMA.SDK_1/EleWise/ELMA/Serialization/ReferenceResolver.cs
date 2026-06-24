// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.ReferenceResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Резолвер ссылок на объекты по идентификаторам</summary>
  internal sealed class ReferenceResolver : IReferenceResolver
  {
    private int referenceCount;
    private readonly BidirectionalDictionary<string, object> mappings;
    private readonly IDictionary<Guid, ISet<object>> mappingsWithMetadata;
    private static ReferenceResolver JmW1uBB9o6CNRIWwLgS2;

    /// <inheritdoc />
    public object ResolveReference(string reference)
    {
      int num = 2;
      object second;
      ReferenceResolver referenceResolver;
      string reference1;
      while (true)
      {
        switch (num)
        {
          case 1:
            referenceResolver = this;
            num = 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
            continue;
          case 3:
            reference1 = reference;
            num = 4;
            continue;
          case 4:
            if (!this.mappings.TryGetByFirst(reference1, out second))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      return (object) (Func<object>) (() => referenceResolver.mappings.GetByFirst(reference1));
label_4:
      return second;
    }

    /// <inheritdoc />
    public void AddReference(string reference, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Set(reference, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public bool TryGetReference(object value, IMetadata metadata, out string reference)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ISet<object> objectSet1;
        ISet<object> objectSet2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              reference = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_23;
            case 3:
              if (this.TryGetByValue(value, metadata, out reference))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
                continue;
              }
              goto case 4;
            case 4:
              ++this.referenceCount;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 9 : 7;
              continue;
            case 5:
              goto label_8;
            case 6:
              this.mappingsWithMetadata[metadata.Uid] = objectSet2 = (ISet<object>) new HashSet<object>();
              num2 = 14;
              continue;
            case 7:
              objectSet1 = (ISet<object>) new HashSet<object>();
              num2 = 10;
              continue;
            case 8:
              goto label_22;
            case 9:
              reference = this.referenceCount.ToString();
              num2 = 12;
              continue;
            case 10:
              if (metadata != null)
              {
                num2 = 11;
                continue;
              }
              goto case 3;
            case 11:
              if (!this.mappingsWithMetadata.TryGetValue(ReferenceResolver.GIQf3vB9G0IkM4Jf10vS((object) metadata), out objectSet1))
              {
                num2 = 6;
                continue;
              }
              goto case 3;
            case 12:
              if (!this.mappings.TryGetBySecond(value, out string _))
              {
                num2 = 13;
                continue;
              }
              goto label_5;
            case 13:
              this.Set(reference, value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 8 : 15;
              continue;
            case 14:
              goto label_7;
            case 15:
              goto label_5;
            default:
              if (value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 7;
                continue;
              }
              goto label_8;
          }
        }
label_5:
        objectSet1.Add(value);
        num1 = 8;
        continue;
label_7:
        objectSet1 = objectSet2;
        num1 = 3;
      }
label_8:
      return false;
label_22:
      return false;
label_23:
      return true;
    }

    private void Set(string key, object value)
    {
      int num = 2;
      object second;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (second.Equals(value))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (this.mappings.TryGetByFirst(key, out second))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
              continue;
            }
            this.mappings.Set(key, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 0;
            continue;
          case 3:
            goto label_7;
          case 4:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_7:
      return;
label_2:
      return;
label_6:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) ReferenceResolver.uuLeAoB9E5h15ggfMrUN(-1886646897 ^ -1886559893), (object) key));
    }

    private bool TryGetByValue(object value, IMetadata metadata, out string key)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        ISet<object> objectSet;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_7;
            case 3:
              if (objectSet.Contains(value))
              {
                num2 = 8;
                continue;
              }
              goto label_3;
            case 4:
            case 9:
              goto label_16;
            case 5:
              if (this.mappings.TryGetBySecond(value, out key))
              {
                if (metadata == null)
                {
                  num2 = 9;
                  continue;
                }
                goto case 7;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 8 : 10;
                continue;
              }
            case 6:
              key = (string) null;
              num2 = 5;
              continue;
            case 7:
              if (!this.mappingsWithMetadata.TryGetValue(metadata.Uid, out objectSet))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 4;
                continue;
              }
              if (objectSet != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 8:
              goto label_4;
            case 10:
              goto label_13;
            default:
              goto label_10;
          }
        }
label_10:
        if (ReferenceResolver.uL0oICB9fBHKs3Zvd982((object) objectSet) != 0)
          num1 = 3;
        else
          goto label_7;
      }
label_3:
      return false;
label_4:
      return true;
label_7:
      return false;
label_13:
      return false;
label_16:
      return false;
    }

    public ReferenceResolver()
    {
      ReferenceResolver.FAmTteB9QZIMtINxNEnf();
      this.mappings = new BidirectionalDictionary<string, object>();
      this.mappingsWithMetadata = (IDictionary<Guid, ISet<object>>) new Dictionary<Guid, ISet<object>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AjDbkXB9bfS8kZyA228j() => ReferenceResolver.JmW1uBB9o6CNRIWwLgS2 == null;

    internal static ReferenceResolver twM4qOB9hTtwB81eOk7D() => ReferenceResolver.JmW1uBB9o6CNRIWwLgS2;

    internal static Guid GIQf3vB9G0IkM4Jf10vS([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object uuLeAoB9E5h15ggfMrUN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int uL0oICB9fBHKs3Zvd982([In] object obj0) => ((ICollection<object>) obj0).Count;

    internal static void FAmTteB9QZIMtINxNEnf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
