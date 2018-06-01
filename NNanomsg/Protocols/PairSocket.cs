﻿using System.Net;

namespace NNanomsg.Protocols
{
    public class PairSocket : NanomsgSocketBase, ISendSocket, IReceiveSocket, IConnectSocket, IBindSocket
    {
        public PairSocket() : base(Domain.SP, Protocol.PAIR)
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

        #region Send

        public void Send(byte[] buffer)
        {
            SendImpl(buffer);
        }

        public bool SendImmediate(byte[] buffer)
        {
            return SendImmediateImpl(buffer);
        }

        public NanomsgWriteStream CreateSendStream()
        {
            return CreateSendStreamImpl();
        }

        public void SendStream(NanomsgWriteStream stream)
        {
            SendStreamImpl(stream);
        }

        public bool SendStreamImmediate(NanomsgWriteStream stream)
        {
            return SendStreamImmediateImpl(stream);
        }

        #endregion Send

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