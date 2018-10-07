using System.Windows.Input;                 // ICommand
using Microsoft.Practices.Prism.Regions;    // INavigationAware
using SharedResources;
using SharedResources.Delegates;
using SharedResources.EventHandlers;

namespace NavigationBarModule.ViewModels
{
    /// <summary>
    /// The controls for navigation
    /// </summary>
    public class NavigationBarModuleViewModel : ObservableObject, INavigationAware
    {
        /// <summary>
        /// button press Commands
        /// </summary>
        //public ICommand NavigateToCharacter
        //{
        //    get { return new DelegateCommand(ToCharacter); }
        //}
        public ICommand NavigateToCombat
        {
            get { return new DelegateCommand(ToCombat); }
        }
        //public ICommand NavigateToGear
        //{
        //    get { return new DelegateCommand(ToGear); }
        //}        
        //public ICommand NavigateToSpells
        //{
        //    get { return new DelegateCommand(ToSpells); }
        //}
        //public ICommand NavigateToFeats
        //{
        //    get { return new DelegateCommand(ToFeats); }
        //}
        //public ICommand NavigateToSkills
        //{
        //    get { return new DelegateCommand(ToSkills); }
        //}
        //public ICommand NavigateToOptions
        //{
        //    get { return new DelegateCommand(ToOptions); }
        //}
        //public ICommand NavigateToCharacterCreation
        //{
        //    get { return new DelegateCommand(ToCharacterCreation); }
        //}
        
        /// <summary>
        /// This is the heart of our navigation. We 'navigate' by changing the views in the registered regions. 
        /// </summary>
        private void ToCombat()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(CombatModule.Views.CombatViewPrimary).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(CombatModule.Views.CombatViewAux).FullName);
        }
        
        private void ToSpells()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);         // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(SpellsModule.View.SpellsViewPrimary).FullName);
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(SpellsModule.View.SpellsViewAux).FullName);
        }
       
        private void ToOptions()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(System.Windows.Controls.UserControl).FullName);
            NavigationBarModule.regionManager.RequestNavigate("PrimaryContentRegion", typeof(OptionsModule.Views.OptionsViewPrimary).FullName);    // blank content for region
            NavigationBarModule.regionManager.RequestNavigate("AuxContentRegion", typeof(OptionsModule.Views.OptionsViewAux).FullName);        // blank content for region
        }


        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

    }
}
