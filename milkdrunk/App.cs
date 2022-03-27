using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace milkdrunk
{
    public partial class App
    {
        void Build()
        {
            Resources.Add("Primary", Color.FromHex("#bdacd1"));
            Resources.Add("Secondary", Color.FromHex("#acc0d1"));
            Resources.Add("Tertiary", Color.FromHex("#acd1bd"));
            Resources.Add("Disabled", Color.FromHex("#332196f3"));
            Resources.Add(DefaultResourceDictionary());
        }

        ResourceDictionary DefaultResourceDictionary()
        {
            var resourceDictionary = new ResourceDictionary()
            {
                ButtonStyle()
            };
            return resourceDictionary;
        }

        Style ButtonStyle()
        {
            var style = new Style(typeof(Button));
            style.Setters.Add(new()
            {
                Property = Button.TextColorProperty,
                Value = Color.White
            });
            style.Setters.Add(new()
            {
                Property = VisualStateManager.VisualStateGroupsProperty,
                Value = ButtonVisualStateGroups()
            });
            return style;
        }

        VisualStateGroupList ButtonVisualStateGroups()
        {
            return new()
            {
                ButtonVisualStateGroupCommonStates()
            };
        }

        VisualStateGroup ButtonVisualStateGroupCommonStates()
        {
            return new()
            {
                Name = "CommonStates",
                States =
                {
                    ButtonVisualStateNormal(),
                    ButtonVisualStateDisabled()
                }
            };
        }

        VisualState ButtonVisualStateNormal()
        {
            return new()
            {
                Name = "Normal",
                Setters =
                {
                    new()
                    {
                        Property = Button.BackgroundColorProperty,
                        Value = Resources.TryGetValue("Secondary", out var secondary) ? secondary : default
                    }
                }
            };
        }

        VisualState ButtonVisualStateDisabled()
        {
            return new()
            {
                Name = "Disabled",
                Setters =
                {
                    new()
                    {
                        Property = Button.BackgroundColorProperty,
                        Value = Resources.TryGetValue("Disabled", out var disabled) ? disabled : default
                    }
                }
            };
        }
    }
}
