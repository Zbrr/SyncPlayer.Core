using Dropbox.Api.Files;
using SyncPlayer.Common;
using SyncPlayer.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox.Services.FileValidationService.Rules
{
    public class IsNotDeletedRule : IFileValidationRule<Metadata>
    {
        public bool IsValidFile(Metadata file, ValidationData validationData = null)
        {
            if (file == null)
            {
                return false;
            }

            return !file.IsDeleted;
        }
    }
}
