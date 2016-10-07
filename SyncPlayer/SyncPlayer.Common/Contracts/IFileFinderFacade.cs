using SyncPlayer.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Common.Contracts
{
    public interface IFileFinderFacade
    {
        IEnumerable<IFileFinderService> FileFinderServices { get; set; }

        Task<AudioFileDto[]> FindAudioFileAsync(string name);
    }
}
