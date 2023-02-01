﻿using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitofWork, IGenericRepository<Product> repository, IProductRepository productRepository, IMapper mapper) : base(unitofWork, repository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDTO<List<ProductWithCategoryDTO>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDTO>>(products);
            return CustomResponseDTO<List<ProductWithCategoryDTO>>.Success(200, productsDto);
        }
    }
}
