﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    /// <summary>
    /// Represents ellipse on the map.
    /// </summary>
    public class Ellipse
    {
        /// <summary>
        /// Ellipse coordinates.
        /// </summary>
        public GeoPoint Point { get; set; }

        /// <summary>
        /// Style to draw the ellipse.
        /// </summary>
        public EllipseStyle Style { get; set; }

        /// <summary>
        /// Custom data associated with the ellipse.
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Creates new <see cref="Ellipse"/> object with specified coordinates.
        /// </summary>
        /// <param name="point">Coordinates of the ellipse.</param>
        public Ellipse(GeoPoint point)
        {
            Point = point;
        }

        /// <summary>
        /// Creates new <see cref="Ellipse"/> object with specified coordinates and style.
        /// </summary>
        /// <param name="point">Coordinates of the ellipse.</param>
        /// <param name="style">Ellipse style.</param>
        public Ellipse(GeoPoint point, EllipseStyle style)
        {
            Point = point;
            Style = style;
        }
    }
}
