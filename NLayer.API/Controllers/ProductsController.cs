using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBasController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;

        public ProductsController(IMapper mapper, IService<Product> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAll(); 
            var productsDtos= _mapper.Map<List<ProductDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Succsess(200, productsDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var products = await _service.GetByIdAsync(id);
            var productsDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Succsess(200, productsDtos));
        }
        [HttpPost] 
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var products = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Succsess(201, productsDtos));
        }
    }
}
