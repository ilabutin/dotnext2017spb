﻿using System;
using System.Net;

namespace DotNext
{
  public class TcpClient : IContract, IDisposable
  {
    private readonly System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();

    public TcpClient()
    {
      client.ConnectAsync(IPAddress.Parse(Program.ServerIP), 17000).Wait();
    }

    public ReplyData GetReply(InputData data)
    {
      var networkStream = client.GetStream();
      networkStream.Send(data);
      var reply = networkStream.Receive<ReplyData>();
      return reply;
    }

    public void Dispose()
    {
      client.Dispose();
    }
  }
}
