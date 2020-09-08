using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace demo.Pages
{
    public class Index_Tests : demoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
