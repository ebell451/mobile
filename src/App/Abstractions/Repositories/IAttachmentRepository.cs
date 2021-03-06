﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.App.Models.Data;

namespace Bit.App.Abstractions
{
    public interface IAttachmentRepository : IRepository<AttachmentData, string>
    {
        Task<IEnumerable<AttachmentData>> GetAllByCipherIdAsync(string cipherId);
        Task<IEnumerable<AttachmentData>> GetAllByUserIdAsync(string userId);
    }
}
