﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms9Patch
{
    /// <summary>
    /// Enabled StepSize control of Xamarin.Forms.Slider element
    /// </summary>
    public class SliderStepSizeEffect : Xamarin.Forms.RoutingEffect, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        double _stepSize;

        /// <summary>
        /// StepSize property
        /// </summary>
        public double StepSize
        {
            get { return _stepSize; }
            set
            {
                if (value != _stepSize)
                {
                    _stepSize = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepSize"));
                }
            }
        }

        /// <summary>
        /// Constructor for SliderStepSizeEffect
        /// </summary>
        protected SliderStepSizeEffect() : base("Forms9Patch.SliderStepSizeEffect")
        {
        }

        /// <summary>
        /// Convenience constructor for SliderStepSizeEffect
        /// </summary>
        /// <param name="stepSize"></param>
        public SliderStepSizeEffect(double stepSize) : base("Forms9Patch.SliderStepSizeEffect")
        {
            _stepSize = stepSize;
        }

    }
}
