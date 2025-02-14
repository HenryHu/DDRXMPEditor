﻿using DDR5XMPEditor.DDR5SPD;
using Stylet;
using System;
using System.ComponentModel;
using System.Linq;

namespace DDR5XMPEditor.Pages
{
    public class DDR5SPDEditorViewModel : Screen
    {
        public DDR5_SPD JedecProfile { get; set; }

        public double? Frequency
        {
            get
            {
                if (JedecProfile == null)
                {
                    return null;
                }

                return Math.Round(1.0 / ((double)JedecProfile.MinCycleTime / 1000000));
            }
        }

        public double? MegaTransfers
        {
            get
            {
                if (Frequency == null)
                {
                    return null;
                }

                return Frequency * 2;
            }
        }

        public DDR5SPDEditorViewModel()
        {
        }
    }
}
