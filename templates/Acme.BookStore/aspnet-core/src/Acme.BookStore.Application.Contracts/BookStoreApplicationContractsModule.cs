using Volo.Abp.Account;
using Volo.Abp.AuditLogging;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.LanguageManagement;
using Volo.Abp.LeptonTheme.Management;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TextTemplateManagement;
using Volo.FileManagement;
using Volo.Saas.Host;

namespace Acme.BookStore
{
    [DependsOn(
        typeof(BookStoreDomainSharedModule),
        typeof(AbpFeatureManagementApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpObjectExtendingModule)
    )]
    [DependsOn(typeof(LanguageManagementApplicationContractsModule))]
    [DependsOn(typeof(AbpAuditLoggingApplicationContractsModule))]
    [DependsOn(typeof(FileManagementApplicationContractsModule))]
    [DependsOn(typeof(TextTemplateManagementApplicationContractsModule))]
    [DependsOn(typeof(AbpIdentityServerApplicationContractsModule))]
    [DependsOn(typeof(AbpAccountPublicApplicationContractsModule))]
    [DependsOn(typeof(AbpAccountAdminApplicationContractsModule))]
    [DependsOn(typeof(SaasHostApplicationContractsModule))]
    //[DependsOn(typeof(SaasTenantApplicationContractsModule))]
    [DependsOn(typeof(LeptonThemeManagementApplicationContractsModule))]
    public class BookStoreApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            BookStoreDtoExtensions.Configure();
        }
    }
}
