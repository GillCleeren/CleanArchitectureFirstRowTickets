using AutoMapper;
using FirstRowTickets.TicketManagement.Application.Contracts.Persistence;
using FirstRowTickets.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using FirstRowTickets.TicketManagement.Application.Profiles;
using FirstRowTickets.TicketManagement.Application.UnitTests.Mocks;
using FirstRowTickets.TicketManagement.Domain.Entities;
using Moq;
using Shouldly;

namespace FirstRowTickets.TicketManagement.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
