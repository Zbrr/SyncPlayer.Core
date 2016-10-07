using Dropbox.Api.Files;
using SyncPlayer.Dropbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox.Contracts
{
    public interface IDropboxDataStore
    {
        Task<MediaFile> GetFileUrlForStreamingAsync(string filePath);

        Task<SearchResult> SearchAsync(string searchTerm);
    }
}
