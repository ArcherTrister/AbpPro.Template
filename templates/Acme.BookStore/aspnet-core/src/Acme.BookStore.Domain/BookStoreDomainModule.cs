using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Acme.BookStore.MultiTenancy;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Emailing;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;
using Volo.Abp.SettingManagement;
using Volo.Abp.LanguageManagement;
using Volo.Abp.Localization;
using Volo.Abp.PermissionManagement;
using Volo.FileManagement;
using Volo.Abp.BlobStoring.Database;
using Volo.Abp.TextTemplateManagement;
using Volo.Saas;
using Volo.Abp.LeptonTheme.Management;

namespace Acme.BookStore
{
    [DependsOn(
        typeof(BookStoreDomainSharedModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpBackgroundJobsDomainModule),
        typeof(AbpFeatureManagementDomainModule),
        typeof(AbpIdentityDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpIdentityServerDomainModule),
        typeof(AbpPermissionManagementDomainIdentityServerModule),
        typeof(AbpSettingManagementDomainModule),
        typeof(AbpEmailingModule)
    )]
    [DependsOn(typeof(LanguageManagementDomainModule))]
    [DependsOn(typeof(AbpPermissionManagementDomainModule))]
    [DependsOn(typeof(BlobStoringDatabaseDomainModule))]
    [DependsOn(typeof(FileManagementDomainModule))]
    [DependsOn(typeof(TextTemplateManagementDomainModule))]
    [DependsOn(typeof(SaasDomainModule))]
    [DependsOn(typeof(LeptonThemeManagementDomainModule))]
    public class BookStoreDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = MultiTenancyConsts.IsEnabled;
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("ar", "ar", "العربية", "ar"));
                options.Languages.Add(new LanguageInfo("cs", "cs", "Čeština", "cs"));
                options.Languages.Add(new LanguageInfo("en", "en", "English", "en"));
                options.Languages.Add(new LanguageInfo("en-GB", "en-GB", "English (UK)", "en"));
                options.Languages.Add(new LanguageInfo("hu", "hu", "Magyar", "hu"));
                options.Languages.Add(new LanguageInfo("fr", "fr", "Français", "fr"));
                options.Languages.Add(new LanguageInfo("pt-BR", "pt-BR", "Português", "pt"));
                options.Languages.Add(new LanguageInfo("ru", "ru", "Русский", "ry"));
                options.Languages.Add(new LanguageInfo("tr", "tr", "Türkçe", "tr"));
                options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文", "cn"));
                options.Languages.Add(new LanguageInfo("zh-Hant", "zh-Hant", "繁體中文", "cn"));
                options.Languages.Add(new LanguageInfo("de-DE", "de-DE", "Deutsch", "de"));
                options.Languages.Add(new LanguageInfo("es", "es", "Español", "es"));
            });

#if DEBUG
            context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
        }
    }
}
