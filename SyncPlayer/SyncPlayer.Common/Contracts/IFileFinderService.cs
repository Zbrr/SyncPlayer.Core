using SyncPlayer.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Common.Contracts
{
    public interface IFileFinderService
    {
        Task<AudioFileDto[]> SearchAudioFileAsync(string searchTerm);
    }
}
