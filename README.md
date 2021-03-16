# Important

Issues of this repository are tracked on https://github.com/ArcherTrister/AbpPro.Template.

Please create your issues on https://github.com/ArcherTrister/AbpPro.Template/issues.

运行项目需要配置
1. ABP Commercial NuGet Source 【重要】
2. AbpLicenseCode 【重要】
3. ABP-CLI 登录，还可以使用<font color="red">AbpLicense.bin</font>文件代替【目前应该是项目调试需要，好像跟发布无关】

因开源协议原因，无法提供相关配置，自行问度娘，如果需要可以考虑有偿提供，主要是<font color="red">AbpLicense.bin</font>文件，但仅保证本项目现有发布版本

当前项目发布最低版本为<font color="red">4.2.1</font>，理论上支持其以下版本


# Status
[![.NET Core](https://github.com/ArcherTrister/AbpPro.Template/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/ArcherTrister/AbpPro.Template/actions/workflows/dotnet-core.yml)

# 使用步骤

## 安装模板项目
### 若要从默认 NuGet 源安装模板包，使用
> dotnet new -i AbpPro.Template
### 若要从默认 NuGet 源安装特定版本的模板包
> dotnet new -i AbpPro.Template::{version}

## 创建项目
> dotnet new abpPro -n hello.demo -o "C:/Users/ArcherTrister/source/repos"

### Options
  * ==-n：== 解决方案的名称，常见的命名方式类似于 YourCompany.YourProject. 不过你可以使用自己喜欢的方式,如 YourProject (单级命名空间) 或 YourCompany.YourProduct.YourModule (三级命名空间).
  * ==-o：== 指定输出文件夹,默认是当前目录. 

## 卸载模板项目
> dotnet new -u AbpPro.Template

# License

[Apache](LICENSE).
