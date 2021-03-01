# Important

Issues of this repository are tracked on https://github.com/ArcherTrister/AbpPro.Template. Please create your issues on https://github.com/ArcherTrister/AbpPro.Template/issues.

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
