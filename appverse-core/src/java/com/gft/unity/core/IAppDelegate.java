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
package com.gft.unity.core;

import java.io.InputStream;

/**
 * Application Delegate interface to be implemented 
 * @author maps
 */
public interface IAppDelegate {
    
    public static String ACTIVITY_RESULT_CODE_BUNDLE_KEY = "appverse-result-receiver-activity-result-code";
    
    
    /**
     * Returns the config file path for this module
     * @return The module config-file relative path, to be loaded by the runtime. Null if no config file needs to be loaded
     */
    public String getConfigFilePath ();


    /**
     * Receives the config file data to be loaded for this module.
     * @param configData Inputstream with the module configuration data
     */
    public void setConfigFileLoadedData (InputStream configData);
    
    /**
     * Called on build time that aware the delegate about the build mode used
     * @param debuggable 
     */
    public void buildMode(boolean debuggable);
    
    /**
     * Called on application pause (application goes to background by the user or OS)
     */
    public void onPause();
    
    /**
     * Called on application resume (application comes to foreground by the user or OS)
     */
    public void onResume();
    
    /**
     * Called on application stop (application is no longer visible)
     */
    public void onStop();
    
    /**
     * Called on application destroy (application is finished by the OS)
     */
    public void onDestroy();
    
    /**
     * Called on application launch (application is opened by the user or the OS)
     */
    public void onCreate();
    
}
