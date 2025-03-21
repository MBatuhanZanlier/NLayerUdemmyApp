﻿using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;


        public ProductServiceWithNoCaching(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _repository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetAllProductsWithCategory()
        {
            var product = await _repository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(product);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200,productsDto);
        }
    }
}
