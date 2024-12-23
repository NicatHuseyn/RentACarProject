using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Delete;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommandReuqest>().ReverseMap();
        CreateMap<Brand,CreateBrandCommandResponse>().ReverseMap();


        CreateMap<Brand,GetListBrandQueryResponse>().ReverseMap();
        CreateMap<Paginate<Brand>,GetListResponse<GetListBrandQueryResponse>>().ReverseMap();

        CreateMap<Brand, GetByIdBrandQueryResponse>().ReverseMap();

        CreateMap<Brand,UpdateBrandCommandRequest>().ReverseMap();
        CreateMap<Brand,UpdateBrandCommandResponse>().ReverseMap();

        CreateMap<Brand,DeleteBrandCommandResponse>().ReverseMap();
        CreateMap<Brand,DeleteBrandCommandRequest>().ReverseMap();
    }
}
