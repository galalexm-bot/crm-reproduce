// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ObjectIsDeletedException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  [Serializable]
  public class ObjectIsDeletedException : Exception
  {
    private static ObjectIsDeletedException EIH1BjGjCAXnKR2WNWRn;

    /// <summary>Ctor</summary>
    public ObjectIsDeletedException()
    {
      ObjectIsDeletedException.sEoKpIGjZfD9cyZEHZ41();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="message"></param>
    public ObjectIsDeletedException(string message)
    {
      ObjectIsDeletedException.sEoKpIGjZfD9cyZEHZ41();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected ObjectIsDeletedException(SerializationInfo info, StreamingContext context)
    {
      ObjectIsDeletedException.sEoKpIGjZfD9cyZEHZ41();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор объекта</summary>
    public object ObjectId
    {
      get => this.\u003CObjectId\u003Ek__BackingField;
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
              this.\u003CObjectId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Тип объекта</summary>
    public Guid ObjectType
    {
      get => this.\u003CObjectType\u003Ek__BackingField;
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
              this.\u003CObjectType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    internal static void sEoKpIGjZfD9cyZEHZ41() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool l9ihikGjvgKbu7eElR9V() => ObjectIsDeletedException.EIH1BjGjCAXnKR2WNWRn == null;

    internal static ObjectIsDeletedException uxa5iZGj8JW9riDqNy1r() => ObjectIsDeletedException.EIH1BjGjCAXnKR2WNWRn;
  }
}
