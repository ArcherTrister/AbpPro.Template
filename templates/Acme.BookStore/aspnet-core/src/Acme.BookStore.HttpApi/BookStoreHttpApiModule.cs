using Localization.Resources.AbpUi;
using Acme.BookStore.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.LanguageManagement;
using Volo.Abp.AuditLogging;
using Volo.FileManagement;
using Volo.Abp.TextTemplateManagement;
using Volo.Abp.IdentityServer;
using Volo.Saas.Host;
using Volo.Abp.LeptonTheme;

namespace Acme.BookStore
{
    [DependsOn(
        typeof(BookStoreApplicationContractsModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule)
        )]
    [DependsOn(typeof(LanguageManagementHttpApiModule))]
    [DependsOn(typeof(AbpAuditLoggingHttpApiModule))]
    [DependsOn(typeof(FileManagementHttpApiModule))]
    [DependsOn(typeof(TextTemplateManagementHttpApiModule))]
    [DependsOn(typeof(AbpIdentityServerHttpApiModule))]
    [DependsOn(typeof(AbpAccountPublicHttpApiModule))]
    [DependsOn(typeof(AbpAccountAdminHttpApiModule))]
    [DependsOn(typeof(SaasHostHttpApiModule))]
    //[DependsOn(typeof(SaasTenantHttpApiModule))]
    [DependsOn(typeof(LeptonThemeManagementHttpApiModule))]
    public class BookStoreHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BookStoreResource>()
                    .AddBaseTypes(
                        typeof(AbpUiResource)
                    );
            });
        }
    }
}
