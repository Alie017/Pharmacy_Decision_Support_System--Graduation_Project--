using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class ProductAppService: ApplicationService, IProductAppService
    {

        private readonly IRepository<Product, int> _ProductRepository;

        public ProductAppService(
            IRepository<Product, int> ProductRepository
        )
        {
            _ProductRepository = ProductRepository;

        }

        public async Task InsertProduct(ProductDto input)
        {
            Product product = new Product();

            product.Barcode = input.Barcode;
            product.Name = input.Name;
            product.Purchase = input.Purchase;
            product.Sales = input.Sales;
            _ProductRepository.Insert(product);

        }

        public async Task UpdateProduct(ProductDto input)
        {
            Product product = _ProductRepository.FirstOrDefault(input.Id);

            product.Barcode = input.Barcode;
            product.Name = input.Name;
            product.Purchase = input.Purchase;
            product.Sales = input.Sales;
        }

        public async Task<ProductDto> FindProduct(int id)
        {
            var result = _ProductRepository.FirstOrDefault(id);
            return ObjectMapper.Map<ProductDto>(result);
        }

        public async Task DeleteProduct(int id)
        {

            _ProductRepository.Delete(id);
        }

        public async Task<List<ProductDto>> GetListProduct()
        {

            var result = _ProductRepository.GetAll().ToList();
            return ObjectMapper.Map<List<ProductDto>>(result);
        }
    }
}

