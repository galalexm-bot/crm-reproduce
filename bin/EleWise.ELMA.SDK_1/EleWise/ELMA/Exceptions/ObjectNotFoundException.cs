// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ObjectNotFoundException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка возникает, когда не найден какой-либо объект</summary>
  [Serializable]
  public class ObjectNotFoundException : SecurityException
  {
    private string objectName;
    private object objectId;
    private static ObjectNotFoundException DRDICOGjHujDg8N0AMm9;

    public ObjectNotFoundException()
    {
      ObjectNotFoundException.vQksfLGjxEHhBUXDnlmp();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) ObjectNotFoundException.I6l0OJGj0M4wFwEnTFUG());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ObjectNotFoundException(string objectName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) ObjectNotFoundException.UYmLw1GjyVYWJuDWyNXU(ObjectNotFoundException.aeLumlGjmfnKeX4OU9St(), (object) objectName));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.objectName = objectName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public ObjectNotFoundException(string objectName, string message)
    {
      ObjectNotFoundException.vQksfLGjxEHhBUXDnlmp();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.objectName = objectName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public ObjectNotFoundException(string objectName, object objectId)
    {
      ObjectNotFoundException.vQksfLGjxEHhBUXDnlmp();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) ObjectNotFoundException.UYmLw1GjyVYWJuDWyNXU(ObjectNotFoundException.aeLumlGjmfnKeX4OU9St(), ObjectNotFoundException.dontXcGjMJiK8LvGTTld((object) objectName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787399641), objectId)));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.objectName = objectName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.objectId = objectId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    public ObjectNotFoundException(string objectName, object objectId, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.objectName = objectName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.objectId = objectId;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    protected ObjectNotFoundException(SerializationInfo info, StreamingContext context)
    {
      ObjectNotFoundException.vQksfLGjxEHhBUXDnlmp();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Имя объекта</summary>
    public string ObjectName => this.objectName;

    /// <summary>Идентификатор объекта</summary>
    public object ObjectId => this.objectId;

    protected static string MessageNamedObjectNotFound => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309371772));

    protected static string MessageObjectNotFound => (string) ObjectNotFoundException.wIJd0vGj95K19kmHfwDF(ObjectNotFoundException.Qq0NHbGjJuC0752ONfwp(-630932142 - 1120244082 ^ -1751437176));

    internal static void vQksfLGjxEHhBUXDnlmp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object I6l0OJGj0M4wFwEnTFUG() => (object) ObjectNotFoundException.MessageObjectNotFound;

    internal static bool iLSnliGjALZlLjnRuDYK() => ObjectNotFoundException.DRDICOGjHujDg8N0AMm9 == null;

    internal static ObjectNotFoundException xQbS05Gj7kMUkP7iryhF() => ObjectNotFoundException.DRDICOGjHujDg8N0AMm9;

    internal static object aeLumlGjmfnKeX4OU9St() => (object) ObjectNotFoundException.MessageNamedObjectNotFound;

    internal static object UYmLw1GjyVYWJuDWyNXU([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object dontXcGjMJiK8LvGTTld([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static object Qq0NHbGjJuC0752ONfwp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wIJd0vGj95K19kmHfwDF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
