﻿using System;
using System.Runtime.Serialization;

namespace DotNext
{
  [Serializable]
  [DataContract]
  public class ReplyData
  {
    [DataMember]
    public long Size;
  }
}
