﻿using Maxishop.Application.DTO.Product;
using Maxishop.Application.InputModels;
using Maxishop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.Services.Interface
{
    public interface IProductService
    {
        Task<PaginationVM<ProductDto>> GetPagination(PaginationInputModels pagination);
        Task<ProductDto> GetByIdAsync(int id);
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<IEnumerable<ProductDto>> GetAllByFilterAsync(int? categoryId, int? brandId);
        Task<ProductDto> CreateAsync(CreateProductDto createProductDto);
        Task UpdateAsync(UpdateProductDto updateProductDto);
        Task DeleteAsync(int id);
    }
}
