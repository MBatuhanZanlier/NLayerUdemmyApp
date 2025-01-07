using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    { 
        private readonly ICategoryRepository _repository; 
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper,ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _repository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            var category= await _repository.GetSingleCategoryByWithProductAsync(categoryId); 

            var categoryDto=_mapper.Map<CategoryWithProductsDto>(category); 

            return  CustomResponseDto<CategoryWithProductsDto>.Success(200,categoryDto);
        }
    }
}
