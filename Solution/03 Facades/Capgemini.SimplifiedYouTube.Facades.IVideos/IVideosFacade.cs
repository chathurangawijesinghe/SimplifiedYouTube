using System;
using System.Collections.Generic;

namespace Capgemini.SimplifiedYouTube.Facades.IVideos
{
    public interface IVideosFacade
    {
        List<GetAllVideoDto> GetAll();

        bool Insert(InsertVideoDto video);
    }
}
