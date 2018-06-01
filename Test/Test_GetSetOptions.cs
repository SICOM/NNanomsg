﻿using NNanomsg;
using System.Diagnostics;

namespace Test
{
    internal class Test_GetSetOptions
    {
        public static void Execute()
        {
            const string inprocAddress = "inproc://getsetoption_test";

            int v;
            byte[] bs;

            var s = NN.Socket(Domain.SP, Protocol.REP);
            var rc = NN.SetSockOpt(s, SocketOption.RCVTIMEO, 5000);
            Debug.Assert(rc >= 0);
            rc = NN.GetSockOpt(s, SocketOption.RCVTIMEO, out v);
            Debug.Assert(rc >= 0);

            NN.Bind(s, inprocAddress);
            NN.Recv(s, out bs, SendRecvFlags.NONE);

            // setting the rcvtimeo works as expected.
        }
    }
}