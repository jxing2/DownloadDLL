using Cn.Sagacloud.Proto;
using DotNetty.Buffers;
using DotNetty.Codecs.Protobuf;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskClient
{
    public class TaskNettyClient
    {
        private string ip;
        private int port;
        public TaskNettyClient(string ip, int port) {
            this.ip = ip;
            this.port = port;
        }
        public async Task RunClientAsync()
        {
            //ExampleHelper.SetConsoleLogger();
            var group = new MultithreadEventLoopGroup();
            try
            {
                Bootstrap bootstrap = new Bootstrap();
                bootstrap
                    .Group(group)
                    .Channel<TcpSocketChannel>()
                    .Option(ChannelOption.TcpNodelay, true)
                    .Handler(
                        new ActionChannelInitializer<ISocketChannel>(
                            channel =>
                            {
                                IChannelPipeline pipeline = channel.Pipeline;
                                pipeline.AddLast(new ProtobufVarint32LengthFieldPrepender());
                                pipeline.AddLast("encoder", new ProtobufEncoder());// LengthFieldPrepender(2));  "framing-enc"
                                pipeline.AddLast(new ProtobufVarint32FrameDecoder());
                                pipeline.AddLast("decoder", new ProtobufDecoder(Message.Parser));//LengthFieldBasedFrameDecoder(ushort.MaxValue, 0, 2, 0, 2)
                                pipeline.AddLast("simple", new SimpleHandler());

                            }));
                IChannel clientChannel = await bootstrap.ConnectAsync(new IPEndPoint(IPAddress.Parse(ip), port));

                for (; ; ) // (4)
                {
                    Message msg = new Message();
                    msg.Cmd = 1;
                    msg.ClassName = "HelloWorld";
                    msg.Content = "{\"msg\":\"hello \"}";
                    await clientChannel.WriteAndFlushAsync(msg); // (3)
                    break;
                }
                Console.ReadLine();
                Console.ReadLine();
                await clientChannel.CloseAsync();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await Task.WhenAll(group.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1)));
                //await group.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1));
            }

        }
    }
}
