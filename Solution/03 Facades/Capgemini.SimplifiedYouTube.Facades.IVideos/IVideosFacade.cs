using Capgemini.SimplifiedYouTube.Common.Protos.Videos;
using System;
using System.Collections.Generic;

namespace Capgemini.SimplifiedYouTube.Facades.IVideos
{
    public interface IVideosFacade
    {
        List<Video> GetAll();
    }
}
