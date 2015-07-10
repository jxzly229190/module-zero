using ModuleZeroSampleProject.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Abp;

namespace ModuleZeroSampleProject.Tests.Navigations
{
    public class NavigationAppService_Tests : SampleProjectTestBase
    {
        private readonly INavigationAppService _navigationAppService;

        public NavigationAppService_Tests()
        {
            _navigationAppService = LocalIocManager.Resolve<INavigationAppService>();
        }

        [Fact]
        public void ShouldGetNavigations()
        {
            var list = _navigationAppService.GetNavigations();

            Assert.NotNull(list);

            Assert.True(list.Items.Count == 2);


            //Assert.True(list.Items[0].Name.Equals("question"));

        }
    }
}
