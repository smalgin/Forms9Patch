﻿using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms9Patch.UWP
{
    public static class SKRectExtensions
    {
        public static double X(this SKRect skRect) { return skRect.Left; }

        public static double Y(this SKRect skRect) { return skRect.Top; }

        public static void MoveTo(this SKPath path, double x, double y) => path.MoveTo((float)x, (float)y);

        public static void LineTo(this SKPath path, double x, double y) => path.LineTo((float)x, (float)y);
    }
}