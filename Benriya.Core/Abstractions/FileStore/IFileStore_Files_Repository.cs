﻿using Benriya.Share.Models.FileStore;
using ExtCore.Data.Abstractions;

namespace Benriya.Core.Abstractions.FileStore
{
    public interface IFileStore_Files_Repository: IFileStore_Common<FileStore_Files>,IRepository
    {
        
    }
}