using Syncfusion.Maui.Toolkit.Shimmer;
using Syncfusion_Shimmer_View.Models;
using System.Collections.ObjectModel;
using Syncfusion.Maui.Toolkit.Shimmer;

namespace Syncfusion_Shimmer_View
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public ObservableCollection<Cottage> Cottages { get; set; } = new ObservableCollection<Cottage>(CottageData.GetDummyCottages());

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            Shimmer.IsActive = !Shimmer.IsActive;
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            BuildShimmerGrid();
        }

        private void BuildShimmerGrid()
        {
            for (int i = 0; i < 7; i++)
            {
                var grid = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = 20 },
                        new RowDefinition { Height = 20 },
                        new RowDefinition { Height = 40 },
                        new RowDefinition { Height = 20 },
                        new RowDefinition { Height = 25 }
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Auto },
                        new ColumnDefinition { Width = GridLength.Star }
                    },
                    Margin = new Thickness(0,10)
                };

                var shimmer1 = new ShimmerView
                {
                    HeightRequest = 80,
                    WidthRequest = 80,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Start,
                    ShapeType = ShimmerShapeType.Rectangle
                };
                Grid.SetRow(shimmer1, 0);
                Grid.SetRowSpan(shimmer1, 3);
                Grid.SetColumn(shimmer1, 0);

                var shimmer2 = new ShimmerView
                {
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(10, 0, 0, 5),
                    ShapeType = ShimmerShapeType.Rectangle
                };
                Grid.SetRow(shimmer2, 0);
                Grid.SetColumn(shimmer2, 1);

                var shimmer3 = new ShimmerView
                {
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(10, 0, 0, 5),
                    ShapeType = ShimmerShapeType.Rectangle
                };
                Grid.SetRow(shimmer3, 1);
                Grid.SetColumn(shimmer3, 1);

                var shimmer4 = new ShimmerView
                {
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(10, 0, 0, 5),
                    ShapeType = ShimmerShapeType.Rectangle
                };
                Grid.SetRow(shimmer4, 2);
                Grid.SetColumn(shimmer4, 1);

                var shimmer5 = new ShimmerView
                {
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(10, 5, 0, 0),
                    ShapeType = ShimmerShapeType.Rectangle
                };
                Grid.SetRow(shimmer5, 3);
                Grid.SetColumn(shimmer5, 1);

                var box = new BoxView
                {
                    HeightRequest = 1,
                    BackgroundColor = Colors.LightGray,
                    Margin = new Thickness(0,10,0,0)
                };
                Grid.SetRow(box, 4);
                Grid.SetColumnSpan(box, 2);
                Grid.SetColumn(box, 0);

                grid.Children.Add(shimmer1);
                grid.Children.Add(shimmer2);
                grid.Children.Add(shimmer3);
                grid.Children.Add(shimmer4);
                grid.Children.Add(shimmer5);
                grid.Children.Add(box);

                ShimmerGrid.Add(grid);
            }
        }
    }
}
