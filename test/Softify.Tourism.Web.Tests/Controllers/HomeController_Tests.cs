using System.Threading.Tasks;
using Softify.Tourism.Models.TokenAuth;
using Softify.Tourism.Web.Controllers;
using Shouldly;
using Xunit;

namespace Softify.Tourism.Web.Tests.Controllers
{
    public class HomeController_Tests: TourismWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}