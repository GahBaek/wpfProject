using ConvMVVM2.Core.Attributes;
using ConvMVVM2.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {

        #region Private Property
        private readonly IRegionManager regionManager;
        private readonly IDialogService dialogService;
        #endregion

        #region Constructor
        public MainViewModel(IRegionManager regionManager,
                             IDialogService dialogService) { 
        
            this.regionManager = regionManager;
            this.dialogService = dialogService;
        
        }
        #endregion

        #region Public Property
        [Property]
        private string _Test = "There is no cow level";
        #endregion

        #region Command
        [RelayCommand]
        private void SettingView()
        {
            try
            {
                this.regionManager.Navigate("MainContent", "SettingView");

            }
            catch (Exception ex)
            {

            }

        }

        [RelayCommand]
        private void DashBoardView()
        {
            try
            {
                this.regionManager.Navigate("MainContent", "DashView");
            }
            catch (Exception ex)
            {

            }
        }


        [RelayCommand]
        private void DetailView()
        {
            try
            {

                this.dialogService.Show("CommonWindow", "DetailView", 500, 500, ResizeMode.NoResize, "DetailView");
                
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
