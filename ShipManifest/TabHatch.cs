﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using ConnectedLivingSpace;

namespace ShipManifest
{
    static class TabHatch
    {
        internal static string ToolTip = "";
        internal static bool ToolTipActive = false;
        internal static bool ShowToolTips = true;

        private static Vector2 DisplayViewerPosition = Vector2.zero;
        internal static void Display()
        {
            // Reset Tooltip active flag...
            ToolTipActive = false;

            GUILayout.BeginVertical();
            GUI.enabled = true;
            GUILayout.Label("Hatch Control Center ", SMStyle.LabelTabHeader);
            GUILayout.Label("____________________________________________________________________________________________", SMStyle.LabelStyleHardRule, GUILayout.Height(10), GUILayout.Width(350));
            string step = "start";
            try
            {
                // Display all hatches
                for (int x = 0; x < SMAddon.smController.Hatches.Count; x++)
                {
                    ModHatch iHatch = SMAddon.smController.Hatches[x];
                    bool isEnabled = true;
                    bool open = false;

                    // get hatch state
                    if (!iHatch.IsDocked)
                        isEnabled = false;
                    if (iHatch.HatchOpen)
                        open = true;

                    step = "gui enable";
                    GUI.enabled = isEnabled;
                    bool newOpen = GUILayout.Toggle(open, iHatch.HatchStatus + " - " + iHatch.Title, GUILayout.Width(325));
                    step = "button toggle check";
                    if (!open && newOpen)
                    {
                        iHatch.OpenHatch(true);
                    }
                    else if (open && !newOpen)
                    {
                        iHatch.CloseHatch(true);
                    }
                    if (Event.current.type == EventType.Repaint)
                        iHatch.Highlight(GUILayoutUtility.GetLastRect());
                }
            }
            catch (Exception ex)
            {
                Utilities.LogMessage(string.Format(" in Hatches Tab at step {0}.  Error:  {1} \r\n\r\n{2}", step, ex.Message, ex.StackTrace), "Error", true);
            }
            GUI.enabled = true;
            GUILayout.EndVertical();

        }

        internal static void OpenAllHatches()
        {
            // iterate thru the hatch parts and open hatches
            // TODO: for realism, add a delay and a closing/opening sound
            foreach (ModHatch iHatch in SMAddon.smController.Hatches)
            {
                IModuleDockingHatch iModule = (IModuleDockingHatch)iHatch.HatchModule;
                if (iModule.IsDocked)
                {
                    iModule.HatchEvents["CloseHatch"].active = true;
                    iModule.HatchEvents["OpenHatch"].active = false;
                    iModule.HatchOpen = true;
                }
            }
            SMAddon.FireEventTriggers();
        }

        internal static void CloseAllHatches()
        {
            // iterate thru the hatch parts and open hatches
            // TODO: for realism, add a delay and a closing/opening sound
            foreach (ModHatch iHatch in SMAddon.smController.Hatches)
            {
                IModuleDockingHatch iModule = (IModuleDockingHatch)iHatch.HatchModule;
                if (iModule.IsDocked)
                {
                    iModule.HatchEvents["CloseHatch"].active = false;
                    iModule.HatchEvents["OpenHatch"].active = true;
                    iModule.HatchOpen = false;
                }
            }
            SMAddon.FireEventTriggers();
        }

    }
}
