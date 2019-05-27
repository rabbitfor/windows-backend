﻿using Tizen.NUI.CommonUI;
using Tizen.NUI;

namespace Tizen.FH.NUI.Controls
{
    internal class BasicShortToasStyle : StyleBase
    {
        protected override Attributes GetAttributes()
        {
            ToastAttributes attributes = new ToastAttributes
            {
                Size2D = new Tizen.NUI.Size2D(512, 132),
                UpSpace = 38,

                BackgroundImageAttributes = new ImageAttributes
                {
                    Size2D = new Tizen.NUI.Size2D(512, 132),
                    ResourceURL = new StringSelector
                    {
                        All = CommonResource.Instance.GetFHResourcePath() + "12. Toast Popup/toast_background.png",
                    },
                    Position2D = "0,0",
                    ParentOrigin = Tizen.NUI.ParentOrigin.Center,
                    PivotPoint = Tizen.NUI.PivotPoint.Center,
                    PositionUsesPivotPoint = true,
                    Opacity = new FloatSelector
                    {
                        All = 1,
                    },
                    Border = new RectangleSelector
                    {
                        All = new Tizen.NUI.Rectangle(64, 64, 4, 4)
                    }
                },

                TextAttributes = new TextAttributes
                {
                    Size2D = new Tizen.NUI.Size2D(320, 56),
                    HorizontalAlignment = Tizen.NUI.HorizontalAlignment.Center,
                    VerticalAlignment = Tizen.NUI.VerticalAlignment.Center,
                    Position2D = "96,38",
                    PivotPoint = Tizen.NUI.PivotPoint.TopLeft,
                    PositionUsesPivotPoint = true,
                    PointSize = new FloatSelector
                    {
                        All = 20,
                    },
                    TextColor = new ColorSelector
                    {
                        All = Color.Black,
                    }
                }

            };
            return attributes;
        }
    }
}
