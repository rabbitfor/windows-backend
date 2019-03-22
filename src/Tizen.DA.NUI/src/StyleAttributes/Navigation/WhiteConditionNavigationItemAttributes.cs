﻿using Tizen.NUI.Xaml;
using Tizen.NUI;
using Tizen.NUI.Controls;

[assembly: Tizen.NUI.Xaml.XamlResourceId("Tizen.FH.NUI.res.Navigation.WhiteConditionNavigationItemAttributes.xaml", "WhiteConditionNavigationItemAttributes.xaml", typeof(Tizen.FH.NUI.Controls.WhiteConditionNavigationItemAttributes))]
namespace Tizen.FH.NUI.Controls
{
    internal class WhiteConditionNavigationItemAttributes : AttributesContainer
    {
        protected override Attributes GetAttributes()
        {
            NavigationItemAttributes attributes = new NavigationItemAttributes
            {
                TextAttributes = new TextAttributes
                {
                    Size2D = new Size2D(108, 24),
                    TextColor = new ColorSelector
                    {
                        Pressed = new Color(0, 0, 0, 1),
                        Disabled = new Color(0, 0, 0, 0.4f),
                        Other = new Color(0, 0, 0, 1),
                    },
                    PointSize = new FloatSelector { All = 8 },
                    FontFamily = "SamsungOneUI 500C",
                    PositionUsesPivotPoint = true,
                    ParentOrigin = Tizen.NUI.ParentOrigin.TopLeft,
                    PivotPoint = Tizen.NUI.PivotPoint.TopLeft,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                },
                SubTextAttributes = new TextAttributes
                {
                    Size2D = new Size2D(108, 24),
                    TextColor = new ColorSelector
                    {
                        Pressed = new Color(0, 0, 0, 1),
                        Disabled = new Color(0, 0, 0, 0.4f),
                        Other = new Color(0, 0, 0, 1),
                    },
                    PointSize = new FloatSelector { All = 8 },
                    FontFamily = "SamsungOneUI 500C",
                    PositionUsesPivotPoint = true,
                    ParentOrigin = Tizen.NUI.ParentOrigin.TopLeft,
                    PivotPoint = Tizen.NUI.PivotPoint.TopLeft,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                },
                IconAttributes = new ImageAttributes
                {
                    Size2D = new Size2D(56, 56),
                },
                Space = new Vector4(4, 4, 8, 16),
            };

            return attributes;
        }
    }
}
