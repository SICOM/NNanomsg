﻿namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test_MsgPack.Execute();
            Test_WriteStream.Execute();
            Test_PubSub.Execute();
            Test_WCF.Execute();
            Test_Stream.Execute();
            Test_SocketObject.Execute();
            Test_Pair.Execute();
            Test_PushPull.Execute();
            Test_Listener.Execute();
            Test_Symbol.Execute();
            Test_ReqRep.Execute();
            Test_GetSetOptions.Execute();
        }
    }
}