using AutoMapper;
using InvoiceManagementApp.Application.Common.Interfaces;
using InvoiceManagementApp.Application.Invoices.Queries;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.MediatorHandlers.InvoiceTests
{
   
    public class GetUserInvoicesQueryHandler
    {
        private readonly Mock<IApplicationDbContext> _mockDbContext;
        private readonly Mock<IMapper> _mockAutoMapper;

        public GetUserInvoicesQueryHandler()
        {

            _mockDbContext = new Mock<IApplicationDbContext>();
            _mockAutoMapper = new Mock<IMapper>();
        }

        [Fact]
        public async Task ReturnNullIfInvoicesAreNotPresent()
        {
            var request = new GetUserInvoicesQuery { User = "user_id123"};

            var handler = new InvoiceManagementApp.Application.Invoices.Handlers.GetUserInvoicesQueryHandler(_mockDbContext.Object, _mockAutoMapper.Object);

            var result = await handler.Handle(request, CancellationToken.None);

            Assert.Null(result);
        }
    }
}
