﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms.Maps.Layers
{
    /// <summary>
    /// Represents a collection of ellipses grouped together into a layer.
    /// </summary>
    public class EllipseLayer : Layer
    {
        /// <summary>
        /// List of ellipses
        /// </summary>
        public List<Ellipse> Ellipses { get; set; } = new List<Ellipse>();
        
        /// <summary>
        /// Creates an ellipse layer with specified level
        /// </summary>
        /// <param name="level"></param>
        public EllipseLayer(int level) : base(level)
        {
        }
    }
}
