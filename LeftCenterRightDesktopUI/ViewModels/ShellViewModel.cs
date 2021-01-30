using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRightDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private GameViewModel _game;
        public ShellViewModel(GameViewModel game)
        {
            _game = game;
            ActivateItem(_game);
        }
    }
}
