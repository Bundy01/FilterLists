﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.SharedKernel.Apis.Contracts.Directory;
using Refit;

namespace FilterLists.SharedKernel.Apis.Clients
{
    public interface IDirectoryApi
    {
        [Get("/lists")]
        Task<IEnumerable<ListVm>> GetListsAsync(CancellationToken cancellationToken);

        [Get("/lists/{id}")]
        Task<ListDetailsVm> GetListDetailsAsync(int id, CancellationToken cancellationToken);
    }
}
