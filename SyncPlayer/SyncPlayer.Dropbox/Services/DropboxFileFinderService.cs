using Dropbox.Api.Files;
using SyncPlayer.Common;
using SyncPlayer.Common.Contracts;
using SyncPlayer.Common.DTOs;
using SyncPlayer.Common.Enums;
using SyncPlayer.Dropbox.Contracts;
using SyncPlayer.Dropbox.Services.FileValidationService;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox.Services
{
    public class DropboxFileFinderService : IFileFinderService
    {
        private readonly IFileValidationService<Metadata> fileValidationService;
        private readonly IDropboxDataStore fileDropboxDataStore;
        private readonly AudioFileDtoBuilder dropboxAudioFileDtoBuilder;

        public DropboxFileFinderService()
        {
            //TODO: Use unity container to initialize services 
            fileValidationService = new DropboxFileValidationService();
            fileDropboxDataStore = new DropboxDataStore();
            dropboxAudioFileDtoBuilder = new DropboxAudioFileDtoBuilder();
        }

        public async Task<AudioFileDto[]> SearchAudioFileAsync(string searchTerm)
        {
            //TODO: We currently just return some dummye data, Dropbox and Youtube API's have problems supporting .net core atm.
            return await GetSomeDummyeData();

            //var searchResult = await fileDropboxDataStore.SearchAsync(searchTerm);

            //var files = searchResult.Matches.Select(p => p.Metadata).ToArray();

            //files = fileValidationService.FilterFiles(files, null);

            //var tasks = files.Select(async p => await BuildAndGetAudioFileDto(p)).ToArray();

            //await Task.WhenAll(tasks);

            //return tasks.Select(p => p.Result).ToArray();
        }

        private async Task<AudioFileDto> BuildAndGetAudioFileDto(Metadata metadata)
        {
            var mediaFile = await fileDropboxDataStore.GetFileUrlForStreamingAsync(metadata.PathLower);

            dropboxAudioFileDtoBuilder.BuildStandardAudioFile();
            dropboxAudioFileDtoBuilder.AddMetadataInformation(metadata);
            dropboxAudioFileDtoBuilder.AddStreamingDetails(mediaFile);

            return dropboxAudioFileDtoBuilder.GetAudioFileDto();
        }

        private async Task<AudioFileDto[]> GetSomeDummyeData()
        {
            return new AudioFileDto[] {
                new AudioFileDto() { Title = "File1", Description = "Description1", FileSource = AudioFileSource.Dropbox, Guid = Guid.NewGuid(), Url = "File1.mp3" },
                new AudioFileDto() { Title = "File2", Description = "Description2", FileSource = AudioFileSource.Dropbox, Guid = Guid.NewGuid(), Url = "File1.mp3" },
                new AudioFileDto() { Title = "File3", Description = "Description3", FileSource = AudioFileSource.Dropbox, Guid = Guid.NewGuid(), Url = "File1.mp3" },
                new AudioFileDto() { Title = "File4", Description = "Description4", FileSource = AudioFileSource.Dropbox, Guid = Guid.NewGuid(), Url = "File1.mp3" },
                new AudioFileDto() { Title = "File5", Description = "Description5", FileSource = AudioFileSource.Dropbox, Guid = Guid.NewGuid(), Url = "File1.mp3" }
            };
        }
    }
}
