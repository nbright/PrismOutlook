using PrismOutlook.Modules.Contacts.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutlook.Core;
using PrismOutlook.Modules.Contacts.Menus;

namespace PrismOutlook.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        IRegionManager regionManager;
        public ContactsModule(IRegionManager regionMgr)
        {
            regionManager = regionMgr;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}