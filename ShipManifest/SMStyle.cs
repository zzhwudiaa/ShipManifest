﻿using KSP.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ShipManifest
{
    internal static class SMStyle
    {
        internal static GUIStyle WindowStyle;
        internal static GUIStyle IconStyle;
        internal static GUIStyle ButtonSourceStyle;
        internal static GUIStyle ButtonTargetStyle;
        internal static GUIStyle ButtonToggledSourceStyle;
        internal static GUIStyle ButtonToggledTargetStyle;
        internal static GUIStyle ButtonStyle;
        internal static GUIStyle ButtonToggledStyle;
        internal static GUIStyle ButtonStyleLeft;
        internal static GUIStyle ButtonToggledStyleLeft;
        internal static GUIStyle ToggleStyleHeader;
        internal static GUIStyle ErrorLabelRedStyle;
        internal static GUIStyle LabelStyle;
        internal static GUIStyle LabelTabHeader;
        internal static GUIStyle LabelStyleBold;
        internal static GUIStyle LabelStyleRed;
        internal static GUIStyle LabelStyleCyan;
        internal static GUIStyle LabelStyleYellow;
        internal static GUIStyle LabelStyleGreen;
        internal static GUIStyle LabelStyleNoWrap;
        internal static GUIStyle LabelStyleNoPad;
        internal static GUIStyle LabelStyleHardRule;
        internal static GUIStyle ToolTipStyle;
        internal static GUIStyle ScrollStyle;

        internal static void SetupGUI()
        {
            if (WindowStyle == null)
            {
                SMSettings.LoadColors();
                SetStyles();
            }
        }

        internal static void SetStyles()
        {
            WindowStyle = new GUIStyle(GUI.skin.window);
            IconStyle = new GUIStyle();

            ButtonStyle = new GUIStyle(GUI.skin.button);
            ButtonStyle.normal.textColor = Color.white;
            ButtonStyle.hover.textColor = Color.blue;
            ButtonStyle.fontSize = 12;
            ButtonStyle.fontStyle = FontStyle.Normal;
            ButtonStyle.alignment = TextAnchor.MiddleCenter;

            ButtonToggledStyle = new GUIStyle(GUI.skin.button);
            ButtonToggledStyle.normal.textColor = Color.green;
            ButtonToggledStyle.fontSize = 12;
            ButtonToggledStyle.hover.textColor = Color.blue;
            ButtonToggledStyle.normal.background = ButtonToggledStyle.onActive.background;
            ButtonToggledStyle.fontStyle = FontStyle.Normal;
            ButtonToggledStyle.alignment = TextAnchor.MiddleCenter;

            ButtonStyleLeft = new GUIStyle(GUI.skin.button);
            ButtonStyleLeft.normal.textColor = Color.white;
            ButtonStyleLeft.hover.textColor = Color.green;
            ButtonStyleLeft.fontSize = 12;
            ButtonStyleLeft.fontStyle = FontStyle.Normal;
            ButtonStyleLeft.alignment = TextAnchor.MiddleLeft;

            ButtonToggledStyleLeft = new GUIStyle(GUI.skin.button);
            ButtonToggledStyleLeft.normal.textColor = Color.green;
            ButtonToggledStyleLeft.fontSize = 12;
            ButtonToggledStyleLeft.hover.textColor = Color.white;
            ButtonToggledStyleLeft.normal.background = ButtonToggledStyleLeft.onActive.background;
            ButtonToggledStyleLeft.fontStyle = FontStyle.Normal;
            ButtonToggledStyleLeft.alignment = TextAnchor.MiddleLeft;

            ButtonSourceStyle = new GUIStyle(GUI.skin.button);
            ButtonSourceStyle.normal.textColor = Color.white;
            ButtonSourceStyle.fontSize = 12;
            ButtonSourceStyle.hover.textColor = Color.blue;
            ButtonSourceStyle.fontStyle = FontStyle.Normal;
            ButtonSourceStyle.alignment = TextAnchor.UpperLeft;

            ButtonToggledSourceStyle = new GUIStyle(GUI.skin.button);
            ButtonToggledSourceStyle.normal.textColor = SMSettings.Colors[SMSettings.SourcePartColor];
            ButtonToggledSourceStyle.fontSize = 12;
            ButtonToggledSourceStyle.hover.textColor = Color.blue;
            ButtonToggledSourceStyle.normal.background = ButtonToggledSourceStyle.onActive.background;
            ButtonToggledSourceStyle.fontStyle = FontStyle.Normal;
            ButtonToggledSourceStyle.alignment = TextAnchor.UpperLeft;

            ButtonTargetStyle = new GUIStyle(GUI.skin.button);
            ButtonTargetStyle.normal.textColor = Color.white;
            ButtonTargetStyle.fontSize = 12;
            ButtonTargetStyle.hover.textColor = Color.blue;
            ButtonTargetStyle.fontStyle = FontStyle.Normal;
            ButtonTargetStyle.alignment = TextAnchor.UpperLeft;

            ButtonToggledTargetStyle = new GUIStyle(GUI.skin.button);
            ButtonToggledTargetStyle.normal.textColor = SMSettings.Colors[SMSettings.TargetPartColor];
            ButtonToggledTargetStyle.fontSize = 12;
            ButtonToggledTargetStyle.hover.textColor = Color.blue;
            ButtonToggledTargetStyle.normal.background = ButtonToggledSourceStyle.onActive.background;
            ButtonToggledTargetStyle.fontStyle = FontStyle.Normal;
            ButtonToggledTargetStyle.alignment = TextAnchor.UpperLeft;

            ToggleStyleHeader = new GUIStyle(GUI.skin.toggle);
            ToggleStyleHeader.padding.top = 10;
            ToggleStyleHeader.padding.bottom = 6;
            ToggleStyleHeader.wordWrap = false;
            ToggleStyleHeader.fontStyle = FontStyle.Bold;
            ToggleStyleHeader.margin = new RectOffset(0, 0, 0, 0);
            ToggleStyleHeader.alignment = TextAnchor.LowerLeft;

            ErrorLabelRedStyle = new GUIStyle(GUI.skin.label);
            ErrorLabelRedStyle.normal.textColor = Color.red;

            LabelStyle = new GUIStyle(GUI.skin.label);

            LabelTabHeader = new GUIStyle(GUI.skin.label);
            LabelTabHeader.padding.top = 10;
            LabelTabHeader.padding.bottom = 6;
            LabelTabHeader.wordWrap = false;
            LabelTabHeader.fontStyle = FontStyle.Bold;
            LabelTabHeader.margin = new RectOffset(0, 0, 0, 0);

            LabelStyleHardRule = new GUIStyle(GUI.skin.label);
            LabelStyleHardRule.padding.top = 0;
            LabelStyleHardRule.padding.bottom = 6;
            LabelStyleHardRule.wordWrap = false;
            LabelStyleHardRule.alignment = TextAnchor.LowerLeft;
            LabelStyleHardRule.fontStyle = FontStyle.Bold;
            LabelStyleHardRule.margin = new RectOffset(0, 0, 0, 0);

            LabelStyleNoWrap = new GUIStyle(GUI.skin.label);
            LabelStyleNoWrap.wordWrap = false;

            LabelStyleNoPad = new GUIStyle(GUI.skin.label);
            LabelStyleNoPad.padding.top = 0;
            LabelStyleNoPad.padding.bottom = 0;
            LabelStyleNoPad.wordWrap = false;

            LabelStyleBold = new GUIStyle(GUI.skin.label);
            LabelStyleBold.fontSize = 18;
            LabelStyleBold.fontStyle = FontStyle.Bold;

            LabelStyleRed = new GUIStyle(LabelStyle);
            LabelStyleRed.normal.textColor = Color.red;

            LabelStyleCyan = new GUIStyle(LabelStyle);
            LabelStyleCyan.normal.textColor = Color.cyan;

            LabelStyleYellow = new GUIStyle(LabelStyle);
            LabelStyleYellow.normal.textColor = Color.yellow;

            LabelStyleGreen = new GUIStyle(LabelStyle);
            LabelStyleGreen.normal.textColor = Color.green;

            ToolTipStyle = new GUIStyle(GUI.skin.label);
            ToolTipStyle.alignment = TextAnchor.MiddleLeft;
            ToolTipStyle.wordWrap = false;
            ToolTipStyle.fontStyle = FontStyle.Normal;
            ToolTipStyle.normal.textColor = Color.yellow;

            ScrollStyle = new GUIStyle(GUI.skin.box);        
        }
    }
}
