﻿using System.Net;

namespace NNanomsg.Protocols
{
    public class PullSocket : NanomsgSocketBase, IReceiveSocket, IConnectSocket, IBindSocket
    {
        public PullSocket() : base(Domain.SP, Protocol.PULL)
        {
        }

        #region Connect

        public NanomsgEndpoint Connect(string address)
        {
            return ConnectImpl(address);
        }

        public NanomsgEndpoint Connect(IPAddress address, int port)
        {
            return ConnectImpl(address, port);
        }

        #endregion Connect

        #region Bind

        public NanomsgEndpoint Bind(string address)
        {
            return BindImpl(address);
        }

        #endregion Bind

        #region Receive

        public byte[] Receive()
        {
            return ReceiveImpl();
        }

        public byte[] ReceiveImmediate()
        {
            return ReceiveImmediateImpl();
        }

        public NanomsgReadStream ReceiveStream()
        {
            return ReceiveStreamImpl();
        }

        public NanomsgReadStream ReceiveStreamImmediate()
        {
            return ReceiveStreamImmediateImpl();
        }

        #endregion Receive
    }
}