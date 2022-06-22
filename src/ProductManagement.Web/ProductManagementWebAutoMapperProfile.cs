using AutoMapper;
using ProductManagement.Products;
using ProductManagement.Web.PageModels;

namespace ProductManagement.Web;

public class ProductManagementWebAutoMapperProfile : Profile
{
    public ProductManagementWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();

    }
}
