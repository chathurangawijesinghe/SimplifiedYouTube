using Capgemini.SimplifiedYouTube.Common.Protos.Videos;
using Capgemini.SimplifiedYouTube.Facades.IVideos;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capgemini.SimplifiedYouTube.Facades.Videos
{
    public class VideosFacade : IVideosFacade
    {
        public List<Video> GetAll()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Common.Protos.Videos.Videos.VideosClient(channel);
            var reply = client.GetAll(
                              new GetAllRequest { Id = "1" });

            return reply.Videos.ToList();
        }
    }
}
