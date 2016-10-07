using SyncPlayer.Common.Contracts;
using SyncPlayer.Common.DTOs;
using SyncPlayer.Common.Enums;
using SyncPlayer.Dropbox.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SyncPlayer.Domain
{
    public class FileFinderFacade : IFileFinderFacade
    {
        public IEnumerable<IFileFinderService> FileFinderServices { get; set; }

        public FileFinderFacade()
        {
            FileFinderServices = new List<IFileFinderService>()
            {
                new DropboxFileFinderService()
            };
        }

        public async Task<AudioFileDto[]> FindAudioFileAsync(string name)
        {
            var audioFiles = new List<AudioFileDto>();

            foreach (var audioSource in FileFinderServices)
            {
                var files = await audioSource.SearchAudioFileAsync(name);

                audioFiles.AddRange(files);
            }

            return audioFiles.ToArray();
        }
    }
}
