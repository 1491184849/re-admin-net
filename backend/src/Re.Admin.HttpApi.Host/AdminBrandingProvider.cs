using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Re.Admin;

[Dependency(ReplaceServices = true)]
public class AdminBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Admin";
}
