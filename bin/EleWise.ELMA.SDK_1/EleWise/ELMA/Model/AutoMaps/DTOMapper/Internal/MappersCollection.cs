// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.MappersCollection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>Коллекция мапперов</summary>
  internal sealed class MappersCollection : 
    ICollection<IInternalMapperConfiguration>,
    IEnumerable<IInternalMapperConfiguration>,
    IEnumerable
  {
    private readonly ICollection<IInternalMapperConfiguration> mappers;
    private readonly ICollection<IInternalMapperConfiguration> moduleMappers;
    private readonly ICollection<IInternalMapperConfiguration> systemMappers;
    private static MappersCollection UMEP95hxKxBGvRRjX1Z2;

    /// <summary>Ctor</summary>
    public MappersCollection()
    {
      MappersCollection.bPRIvOhxkBAkIXC9Gdpt();
      // ISSUE: explicit constructor call
      this.\u002Ector((ICollection<IInternalMapperConfiguration>) Array.Empty<IInternalMapperConfiguration>(), (ICollection<IInternalMapperConfiguration>) Array.Empty<IInternalMapperConfiguration>());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleMappers">Мапперы модулей</param>
    /// <param name="systemMappers">Системные мапперы</param>
    public MappersCollection(
      ICollection<IInternalMapperConfiguration> moduleMappers,
      ICollection<IInternalMapperConfiguration> systemMappers)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.moduleMappers = moduleMappers;
      this.systemMappers = systemMappers;
      this.mappers = (ICollection<IInternalMapperConfiguration>) new ConcurrentHashSet<IInternalMapperConfiguration>();
    }

    /// <inheritdoc />
    public int Count => MappersCollection.VHTu24hxn1HRXCdNmoCB((object) this.mappers) + MappersCollection.VHTu24hxn1HRXCdNmoCB((object) this.moduleMappers) + this.systemMappers.Count;

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public IEnumerator<IInternalMapperConfiguration> GetEnumerator() => this.mappers.Concat<IInternalMapperConfiguration>((IEnumerable<IInternalMapperConfiguration>) this.moduleMappers).Concat<IInternalMapperConfiguration>((IEnumerable<IInternalMapperConfiguration>) this.systemMappers).GetEnumerator();

    /// <inheritdoc />
    public void Add(IInternalMapperConfiguration item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mappers.Add(item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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
    public void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MappersCollection.a3fftNhxOXWyjYqY47wQ((object) this.mappers);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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
    public bool Contains(IInternalMapperConfiguration item)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_9;
          case 3:
            if (this.mappers.Contains(item))
            {
              num = 2;
              continue;
            }
            if (!this.moduleMappers.Contains(item))
            {
              if (!this.systemMappers.Contains(item))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
                continue;
              }
              goto label_5;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            }
          case 4:
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      return true;
label_5:
      return true;
label_6:
      return false;
label_9:
      return true;
    }

    /// <inheritdoc />
    public void CopyTo(IInternalMapperConfiguration[] array, int arrayIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MappersCollection.B0NTk6hx27plKpv7PH7a((object) this.mappers, (object) array, arrayIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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
    public bool Remove(IInternalMapperConfiguration item) => this.mappers.Remove(item);

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    internal static void bPRIvOhxkBAkIXC9Gdpt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bAbsF4hxXJNGMxn1AKCM() => MappersCollection.UMEP95hxKxBGvRRjX1Z2 == null;

    internal static MappersCollection EOjYsIhxT1Opao3sX54l() => MappersCollection.UMEP95hxKxBGvRRjX1Z2;

    internal static int VHTu24hxn1HRXCdNmoCB([In] object obj0) => ((ICollection<IInternalMapperConfiguration>) obj0).Count;

    internal static void a3fftNhxOXWyjYqY47wQ([In] object obj0) => ((ICollection<IInternalMapperConfiguration>) obj0).Clear();

    internal static void B0NTk6hx27plKpv7PH7a([In] object obj0, [In] object obj1, [In] int obj2) => ((ICollection<IInternalMapperConfiguration>) obj0).CopyTo((IInternalMapperConfiguration[]) obj1, obj2);
  }
}
