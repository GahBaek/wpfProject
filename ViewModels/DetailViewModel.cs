using ConvMVVM2.Core.Attributes;
using ConvMVVM2.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay.ViewModels
{
    public partial class DetailViewModel : ViewModelBase
    {

        #region Constructor
        public DetailViewModel() { }
        #endregion

        #region Property
        [Property]
        private string _TestString = "";
        #endregion

        #region Command
        [RelayCommand]
        private void Test()
        {

            this.TestString = Random.Shared.NextDouble().ToString();
        }
        #endregion

    }
}
