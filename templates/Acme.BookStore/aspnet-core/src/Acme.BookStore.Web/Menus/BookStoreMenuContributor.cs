using Acme.BookStore.Localization;
using Acme.BookStore.MultiTenancy;

using System.Threading.Tasks;

using Volo.Abp.UI.Navigation;
using Volo.Saas.Host.Navigation;

namespace Acme.BookStore.Web.Menus
{
    public class BookStoreMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
#pragma warning disable CS0162 // 检测到无法访问的代码
                var administration = context.Menu.GetAdministration();
#pragma warning restore CS0162 // 检测到无法访问的代码
                administration.TryRemoveMenuItem(SaasHostMenuNames.GroupName);
            }

            var l = context.GetLocalizer<BookStoreResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(BookStoreMenus.Home, l["Menu:Home"], "~/"));

            await Task.CompletedTask;
        }
    }
}
