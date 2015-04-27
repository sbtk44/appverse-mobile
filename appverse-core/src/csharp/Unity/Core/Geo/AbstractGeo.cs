/*
 Copyright (c) 2012 GFT Appverse, S.L., Sociedad Unipersonal.

 This Source  Code Form  is subject to the  terms of  the Appverse Public License 
 Version 2.0  (“APL v2.0”).  If a copy of  the APL  was not  distributed with this 
 file, You can obtain one at http://appverse.org/legal/appverse-license/.

 Redistribution and use in  source and binary forms, with or without modification, 
 are permitted provided that the  conditions  of the  AppVerse Public License v2.0 
 are met.

 THIS SOFTWARE IS PROVIDED BY THE  COPYRIGHT HOLDERS  AND CONTRIBUTORS "AS IS" AND
 ANY EXPRESS  OR IMPLIED WARRANTIES, INCLUDING, BUT  NOT LIMITED TO,   THE IMPLIED
 WARRANTIES   OF  MERCHANTABILITY   AND   FITNESS   FOR A PARTICULAR  PURPOSE  ARE
 DISCLAIMED. EXCEPT IN CASE OF WILLFUL MISCONDUCT OR GROSS NEGLIGENCE, IN NO EVENT
 SHALL THE  COPYRIGHT OWNER  OR  CONTRIBUTORS  BE LIABLE FOR ANY DIRECT, INDIRECT,
 INCIDENTAL,  SPECIAL,   EXEMPLARY,  OR CONSEQUENTIAL DAMAGES  (INCLUDING, BUT NOT
 LIMITED TO,  PROCUREMENT OF SUBSTITUTE  GOODS OR SERVICES;  LOSS OF USE, DATA, OR
 PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
 WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) 
 ARISING  IN  ANY WAY OUT  OF THE USE  OF THIS  SOFTWARE,  EVEN  IF ADVISED OF THE 
 POSSIBILITY OF SUCH DAMAGE.
 */
using System;
using System.Collections.Generic;
using System.Text;
#if WP8
using System.Threading.Tasks;
#endif

namespace Unity.Core.Geo
{
    public abstract class AbstractGeo : ILocation, IMap
    {

        #region Miembros de ILocation
#if !WP8
		public abstract Acceleration GetAcceleration ();

		public abstract float GetHeading ();

		public abstract float GetHeading (NorthType type);

		public abstract DeviceOrientation GetDeviceOrientation ();

		public abstract LocationCoordinate GetCoordinates ();

		public abstract float GetVelocity ();

		public abstract bool StartUpdatingLocation ();

		public abstract bool StopUpdatingLocation ();

		public abstract bool StartUpdatingHeading ();

		public abstract bool StopUpdatingHeading ();
		
		//public abstract GeoDecoderAttributes GetGeoDecoder(double latitude, double longitude);
		
		public abstract GeoDecoderAttributes GetGeoDecoder ();
		
		public abstract bool StartProximitySensor ();
		
		public abstract bool StopProximitySensor ();
		
		public abstract bool IsGPSEnabled ();
#else
        public abstract Task<Acceleration> GetAcceleration();
        public abstract Task<float> GetHeading();
        public abstract Task<float> GetHeading(NorthType type);
        public abstract Task<DeviceOrientation> GetDeviceOrientation();
        public abstract Task<LocationCoordinate> GetCoordinates();
        public abstract Task<float> GetVelocity();
        public abstract Task<bool> StartUpdatingLocation();
        public abstract Task<bool> StopUpdatingLocation();
        public abstract Task<bool> StartUpdatingHeading();
        public abstract Task<bool> StopUpdatingHeading();
        public abstract Task<GeoDecoderAttributes> GetGeoDecoder();
        public abstract Task<bool> StartProximitySensor();
        public abstract Task<bool> StopProximitySensor();
        public abstract Task<bool> IsGPSEnabled();
#endif

        #endregion

        #region Miembros de IMap
#if !WP8

		public abstract POI[] GetPOIList (LocationCoordinate location, float radius);

		public abstract POI[] GetPOIList (LocationCoordinate location, float radius, string queryText);

		public abstract POI[] GetPOIList (LocationCoordinate location, float radius, string queryText, LocationCategory category);

		public abstract POI[] GetPOIList (LocationCoordinate location, float radius, LocationCategory category);

		public abstract POI GetPOI (string id);

		public abstract bool UpdatePOI (POI poi);

		public abstract bool RemovePOI (string id);

		public abstract void GetMap ();

		public abstract void SetMapSettings (float scale, float boundingBox);
#else
        public abstract Task<POI[]> GetPOIList(LocationCoordinate location, float radius);
        public abstract Task<POI[]> GetPOIList(LocationCoordinate location, float radius, string queryText);
        public abstract Task<POI[]> GetPOIList(LocationCoordinate location, float radius, string queryText, LocationCategory category);
        public abstract Task<POI[]> GetPOIList(LocationCoordinate location, float radius, LocationCategory category);
        public abstract Task<POI> GetPOI(string id);
        public abstract Task<bool> UpdatePOI(POI poi);
        public abstract Task<bool> RemovePOI(string id);
        public abstract Task GetMap();
        public abstract Task SetMapSettings(float scale, float boundingBox);
#endif
        #endregion




    }
}
