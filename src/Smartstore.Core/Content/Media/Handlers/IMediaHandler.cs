﻿using System;
using System.Threading.Tasks;

namespace Smartstore.Core.Content.Media
{
    public interface IMediaHandler
    {
        int Order { get; }
        Task ExecuteAsync(MediaHandlerContext context);
    }
}
