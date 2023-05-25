using FirstRowTickets.TicketManagement.Application.Contracts;
using FirstRowTickets.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;

namespace FirstRowTickets.TicketManagement.Persistence.IntegrationTests
{
    public class FirstRowTicketsDbContextTests
    {
        private readonly FirstRowTicketsDbContext _FirstRowTicketsDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public FirstRowTicketsDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<FirstRowTicketsDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _FirstRowTicketsDbContext = new FirstRowTicketsDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var ev = new Event() {EventId = Guid.NewGuid(), Name = "Test event", Artist = "test artist", Description="Lorem ipusem", ImageUrl = "" };

            _FirstRowTicketsDbContext.Events.Add(ev);
            await _FirstRowTicketsDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
