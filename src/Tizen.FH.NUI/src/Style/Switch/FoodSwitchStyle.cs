﻿using Tizen.NUI;
using Tizen.NUI.Components;

namespace Tizen.FH.NUI.Controls
{
    internal class FoodSwitchStyle : StyleBase
    {
        protected internal override Attributes GetAttributes()
        {
            SwitchAttributes attributes = new SwitchAttributes
            {
                IsSelectable = true,
                SwitchBackgroundImageAttributes = new ImageAttributes
                {
                    Size = new Size(96, 60),
                    ResourceURL = new StringSelector
                    {
                        Normal = CommonResource.Instance.GetFHResourcePath() + "9. Controller/controller_switch_bg_off.png",
                        Selected = CommonResource.Instance.GetFHResourcePath() + "9. Controller/[Controller] App Primary Color/controller_switch_bg_on_ec7510.png",
                        Disabled = CommonResource.Instance.GetFHResourcePath() + "9. Controller/controller_switch_bg_off_dim.png",
                        DisabledSelected = CommonResource.Instance.GetFHResourcePath() + "9. Controller/[Controller] App Primary Color/controller_switch_bg_on_dim_ec7510.png",
                    },
                },
                SwitchHandlerImageAttributes = new ImageAttributes
                {
                    Size = new Size(60, 60),
                    ResourceURL = new StringSelector
                    {
                        Normal = CommonResource.Instance.GetFHResourcePath() + "9. Controller/controller_switch_handler.png",
                        Selected = CommonResource.Instance.GetFHResourcePath() + "9. Controller/controller_switch_handler.png",
                        Disabled = CommonResource.Instance.GetFHResourcePath() + "9. Controller/controller_switch_handler_dim.png",
                        DisabledSelected = CommonResource.Instance.GetFHResourcePath() + "9. Controller/controller_switch_handler_dim.png",
                    },
                },
            };

            return attributes;
        }
    }
}
