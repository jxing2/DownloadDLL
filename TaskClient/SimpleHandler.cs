using Cn.Sagacloud.Proto;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClient
{
    class SimpleHandler : ChannelHandlerAdapter
    {

        public override void ChannelActive(IChannelHandlerContext context) {
            Console.WriteLine("connected");
        }

        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            if (message is Message msg)
            {
                toString(msg);
                
            }
        }

        public override void ChannelReadComplete(IChannelHandlerContext context)
        {

            context.Flush();
        }

        public override void ExceptionCaught(IChannelHandlerContext context, Exception exception)
        {
            Console.WriteLine("Exception: " + exception);
            context.CloseAsync();
        }

        public void toString(Message msg) {
            Console.WriteLine("Received from server: cmd : " + msg.Cmd + ", className : " + msg.ClassName + ", content : " + msg.Content);
        }
    }
}
