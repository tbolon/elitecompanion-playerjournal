using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    public class ScanEvent : BaseEvent
    {
        public string BodyName { get; set; }

        public double DistanceFromArrivalLS { get; set; }

        public string StarType { get; set; }

        public double StellarMass { get; set; }

        public double AbsoluteMagnitude { get; set; }

        [JsonProperty("Age_MY")]
        public int AgeMY { get; set; }

        public bool TidalLock { get; set; }

        /// <summary>
        /// Terraformable, Terraforming, Terraformed, or null.
        /// </summary>
        public string TerraformState { get; set; }

        public string PlanetClass { get; set; }

        public string Atmosphere { get; set; }

        public string Volcanism { get; set; }

        public double MassEM { get; set; }

        public double Radius { get; set; }

        public double SurfaceGravity { get; set; }

        public double SurfaceTemperature { get; set; }

        public double SurfacePressure { get; set; }

        public bool Landable { get; set; }

        public double SemiMajorAxis { get; set; }

        public double Eccentricity { get; set; }

        public bool OrbitalInclination { get; set; }

        public double Periapsis { get; set; }

        public double OrbitalPeriod { get; set; }

        public double RotationPeriod { get; set; }

        public BodyRing[] Rings { get; set; }

        public Materials Materials { get; set; }
    }
}
