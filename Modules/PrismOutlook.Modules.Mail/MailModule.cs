using PrismOutlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutlook.Core;
using PrismOutlook.Modules.Mail.Menus;

namespace PrismOutlook.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager regionManager;
        public MailModule(IRegionManager regionMgr)
        {
            regionManager = regionMgr;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion,typeof(ViewA));
            regionManager.RegisterViewWithRegion(RegionNames.RibbonRegion, typeof(HomeTab));
            regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}