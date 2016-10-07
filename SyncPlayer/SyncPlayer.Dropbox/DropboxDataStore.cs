using Dropbox.Api.Files;
using SyncPlayer.Dropbox.Contracts;
using SyncPlayer.Dropbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox
{
    public class DropboxDataStore : IDropboxDataStore
    {
        private readonly DropboxClientWrapper dropboxClient;

        public DropboxDataStore()
        {
            dropboxClient = new DropboxClientWrapper();
        }

        public async Task<MediaFile> GetFileUrlForStreamingAsync(string filePath)
        {
            return await dropboxClient.GetFileUrlForStreaming(filePath);
        }

        public async Task<SearchResult> SearchAsync(string searchTerm)
        {
            return await dropboxClient.SearchAsync(searchTerm);
        }
    }
}
