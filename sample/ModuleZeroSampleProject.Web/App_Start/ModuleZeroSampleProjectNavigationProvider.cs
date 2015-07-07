using Abp.Application.Navigation;
using Abp.Localization;
using ModuleZeroSampleProject.Navigation;

namespace ModuleZeroSampleProject.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class ModuleZeroSampleProjectNavigationProvider : NavigationProvider
    {
        private INavigationAppService _navigationAppService;

        public ModuleZeroSampleProjectNavigationProvider(INavigationAppService navigationAppService)
        {
            this._navigationAppService = navigationAppService;
        }

        public override void SetNavigation(INavigationProviderContext context)
        {
            var list = _navigationAppService.GetNavigations();

            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Questions",
                        new LocalizableString("Questions", ModuleZeroSampleProjectConsts.LocalizationSourceName),
                        url: "#/questions",
                        icon: "fa fa-question"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        new LocalizableString("Users", ModuleZeroSampleProjectConsts.LocalizationSourceName),
                        url: "#/users",
                        icon: "fa fa-users"
                        )
                ).AddItem(new MenuItemDefinition("TestMenuItem",
                        new LocalizableString("TestMenuItem", ModuleZeroSampleProjectConsts.LocalizationSourceName),
                        url: "#/users",
                        icon: "fa fa-users"));
        }
    }
}
