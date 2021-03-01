using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.AuditLogging;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.LanguageManagement;
using Volo.Abp.LeptonTheme.Management;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TextTemplateManagement;
using Volo.FileManagement;
using Volo.Saas.Host;

namespace Acme.BookStore
{
    [DependsOn(
        typeof(BookStoreApplicationContractsModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
    )]
    [DependsOn(typeof(LanguageManagementHttpApiClientModule))]
    [DependsOn(typeof(AbpAuditLoggingHttpApiClientModule))]
    [DependsOn(typeof(FileManagementHttpApiClientModule))]
    [DependsOn(typeof(TextTemplateManagementHttpApiClientModule))]
    [DependsOn(typeof(AbpIdentityServerHttpApiClientModule))]
    [DependsOn(typeof(AbpAccountPublicHttpApiClientModule))]
    [DependsOn(typeof(AbpAccountAdminHttpApiClientModule))]
    [DependsOn(typeof(SaasHostHttpApiClientModule))]
    //[DependsOn(typeof(SaasTenantHttpApiClientModule))]
    [DependsOn(typeof(LeptonThemeManagementHttpApiClientModule))]
    public class BookStoreHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BookStoreApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
