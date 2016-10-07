using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncPlayer.Common.Contracts
{
    public interface IFileValidationRule<in T>
    {
        bool IsValidFile(T file, ValidationData validationData = null);
    }
}
