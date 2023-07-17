using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IProductAppService
    {
        Task InsertProduct(ProductDto input);
        Task UpdateProduct(ProductDto input);
        Task<ProductDto> FindProduct(int id);
        Task DeleteProduct(int id);
        Task<List<ProductDto>> GetListProduct();



    }
}

