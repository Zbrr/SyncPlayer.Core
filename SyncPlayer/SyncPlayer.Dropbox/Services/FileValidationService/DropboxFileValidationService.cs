using Dropbox.Api.Files;
using SyncPlayer.Common;
using SyncPlayer.Common.Contracts;
using SyncPlayer.Dropbox.Services.FileValidationService.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Dropbox.Services.FileValidationService
{
    public class DropboxFileValidationService : IFileValidationService<Metadata>
    {
        private readonly List<IFileValidationRule<Metadata>> rules;

        public DropboxFileValidationService()
        {
            //TODO: Use unity container to initialize set of rules 
            rules = new List<IFileValidationRule<Metadata>>()
            {
                new IsFileRule(),
                new IsAudioFileRule(),
                new IsNotDeletedRule(),
                new IsSearchedFileRule()
            };
        }

        public Metadata[] FilterFiles(Metadata[] filesMetadatas, ValidationData validationData)
        {
            return filesMetadatas.Where(p => IsValidFile(p, validationData)).ToArray();
        }

        public bool IsValidFile(Metadata file, ValidationData validationData)
        {
            return rules.Select(fileRule => fileRule.IsValidFile(file, validationData)).All(isValidFile => isValidFile);
        }
    }
}
