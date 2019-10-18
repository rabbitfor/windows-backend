﻿using Tizen.NUI.Components;
namespace Tizen.FH.NUI.Controls
{
    internal class UtilityOvalButtonStyle : IconButtonStyle
    {
        protected internal override Attributes GetAttributes()
        {
            if (Content != null)
            {
                return (Content as Attributes).Clone();
            }
            return base.GetAttributes();
        }
    }
}
