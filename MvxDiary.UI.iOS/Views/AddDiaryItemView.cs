using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvxDiary.Core.ViewModels;

namespace MvxDiary.UI.iOS.Views
{
    public partial class AddDiaryItemView : MvxViewController<AddDiaryItemViewModel>
    {
        public AddDiaryItemView() : base("AddDiaryItemView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(DateLabel).To((AddDiaryItemViewModel vm) => vm.Date).Apply();
            this.CreateBinding(TitleEdit).To((AddDiaryItemViewModel vm) => vm.Title).Apply();
            this.CreateBinding(DescriptionEdit).To((AddDiaryItemViewModel vm) => vm.Description).Apply();
        }
    }
}