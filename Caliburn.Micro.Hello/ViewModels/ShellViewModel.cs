using System.ComponentModel.Composition;
using System.Windows;

namespace Caliburn.Micro.Hello.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get
            {
                return !string.IsNullOrEmpty(this.Name);
            }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello, {0}!", this.Name));
        }

    }
}
