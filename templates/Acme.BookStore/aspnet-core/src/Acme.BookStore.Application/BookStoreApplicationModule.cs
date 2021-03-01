using Volo.Abp.Account;
using Volo.Abp.AuditLogging;
using Volo.Abp.AutoMapper;
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
        typeof(BookStoreDomainModule),
        typeof(BookStoreApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    [DependsOn(typeof(LanguageManagementApplicationModule))]
    [DependsOn(typeof(AbpAuditLoggingApplicationModule))]
    [DependsOn(typeof(FileManagementApplicationModule))]
    [DependsOn(typeof(TextTemplateManagementApplicationModule))]
    [DependsOn(typeof(AbpIdentityServerApplicationModule))]
    [DependsOn(typeof(AbpAccountPublicApplicationModule))]
    [DependsOn(typeof(AbpAccountAdminApplicationModule))]
    [DependsOn(typeof(SaasHostApplicationModule))]
    //[DependsOn(typeof(SaasTenantApplicationModule))]
    [DependsOn(typeof(LeptonThemeManagementApplicationModule))]
    public class BookStoreApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BookStoreApplicationModule>();
            });
        }
    }
}
