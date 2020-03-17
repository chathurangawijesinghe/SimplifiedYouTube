using AutoMapper;
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
        public List<IVideos.GetAllVideoDto> GetAll()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Common.Protos.Videos.Videos.VideosClient(channel);
            var reply = client.GetAll(
                              new GetAllRequest { Id = "1" });

            List<GetAllVideoDto> results = new List<GetAllVideoDto>();
            foreach (var video in reply.Videos)
            {
                GetAllVideoDto result = new GetAllVideoDto();
                result.Id = video.Id;
                result.Name = video.Name;
                result.Description = video.Description;
                result.FileName = video.FileName;
                results.Add(result);
            }

            return results;
        }

        public bool Insert(InsertVideoDto video)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Common.Protos.Videos.Videos.VideosClient(channel);
            var reply = client.Insert(
                              new InsertRequest { Name = video.Name, 
                                  Description = video.Description, 
                                  FileName = video.File.FileName   });
            return reply.Response;
        }
    }
}
