using Dropbox.Api.Files;
using SyncPlayer.Common;
using SyncPlayer.Common.Enums;
using SyncPlayer.Dropbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox
{
    public class DropboxAudioFileDtoBuilder : AudioFileDtoBuilder
    {
        public override void AddStreamingDetails<T>(T mediaFile)
        {
            var data = mediaFile as MediaFile;

            if (data == null)
            {
                return;
            }

            AudioFileDto.Url = data.Url;
            AudioFileDto.Expires = data.Expires;
        }

        public override void AddMetadataInformation<T>(T metadata)
        {
            AudioFileDto.FileSource = AudioFileSource.Dropbox;

            var data = metadata as Metadata;

            if (data == null)
            {
                return;
            }

            AudioFileDto.Title = data.Name;
        }
    }
}
