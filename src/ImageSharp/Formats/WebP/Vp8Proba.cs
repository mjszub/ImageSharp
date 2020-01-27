// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Formats.WebP
{
    /// <summary>
    /// Data for all frame-persistent probabilities.
    /// </summary>
    internal class Vp8Proba
    {
        private const int MbFeatureTreeProbs = 3;

        public Vp8Proba()
        {
            this.Segments = new uint[MbFeatureTreeProbs];
            this.Bands = new Vp8BandProbas[WebPConstants.NumTypes, WebPConstants.NumBands];
        }

        public uint[] Segments { get; }

        public Vp8BandProbas[,] Bands { get; }
    }
}
