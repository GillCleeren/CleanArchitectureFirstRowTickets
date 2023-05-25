using AutoMapper;
using FirstRowTickets.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using FirstRowTickets.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using FirstRowTickets.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using FirstRowTickets.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using FirstRowTickets.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using FirstRowTickets.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using FirstRowTickets.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using FirstRowTickets.TicketManagement.Domain.Entities;

namespace FirstRowTickets.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

        }
    }
}
