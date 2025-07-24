using Syncfusion.Maui.Toolkit.BottomSheet;
using System.Diagnostics;

namespace SyncFusion_Bottom_Sheet
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            bottomSheet.StateChanged += BottomSheet_StateChanged;
            bottomSheet.State = BottomSheetState.Collapsed;
        }

        bool firstLoad = true;
        private void BottomSheet_StateChanged(object? sender, StateChangedEventArgs e)
        {
            try
            {
                var last = e.OldState;
                var newish = e.NewState;

                if (firstLoad)
                {
                    bottomSheet.AllowedState = BottomSheetAllowedState.FullExpanded;
                    firstLoad = false;
                }

                if (bottomSheet.State != BottomSheetState.Collapsed)
                {
                    bottomSheet.State = BottomSheetState.FullExpanded;
                }
                else
                {
                    bottomSheet.State = BottomSheetState.Collapsed;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error", ex.Message, "OK");
            }
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Clicked_OpenBottomSheet(object sender, EventArgs e)
        {
            try
            {
                if (bottomSheet.State == BottomSheetState.Collapsed)
                {
                    bottomSheet.State = BottomSheetState.FullExpanded;
                }
                else
                {
                    bottomSheet.State = BottomSheetState.Collapsed;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error", ex.Message, "OK");
            }
        }
    }
}
