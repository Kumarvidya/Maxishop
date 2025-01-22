using Maxishop.Application.InputModels;
using Maxishop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.Services.Interface
{
    public interface IPaginationService<T,S>where T : class
    {
        PaginationVM<T> GetPagination(List<S> source, PaginationInputModels pagination);
    }
}
